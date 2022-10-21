using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class UsersService : BaseCRUDService<Model.User, Database.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IUsersService
    {
        public UsersService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Model.User Insert(UserInsertRequest insert)
        {
            var entity = base.Insert(insert);

            foreach (var roleId in insert.RolesIdList)
            {
                Database.UserRole role = new Database.UserRole();

                role.RoleId = roleId;
                role.UserId = entity.UserId;

                role.LastModified = DateTime.Now;

                Context.UserRoles.Add(role);
            }

            Context.SaveChanges();

            return entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, User entity)
        {
            var salt = GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }

        public static string GenerateSalt()
        {
            // Temp solution
            return Convert.ToBase64String(new byte[16]);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
