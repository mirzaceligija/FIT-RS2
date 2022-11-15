using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectWe.Model;
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
            if(insert.Password != insert.ConfirmPassword)
            {
                throw new UserException("Password confirmation did not match the password!");
            }

            var entity = base.Insert(insert);

            List<int> defaultRoles = new List<int> { 2 }; // 2 stands for manager

            foreach (var roleId in defaultRoles)
            {
                Database.UserRole role = new Database.UserRole();

                role.RoleId = roleId;
                role.UserId = entity.UserId;

                role.CreatedAt = DateTime.Now;
                role.LastModified = DateTime.Now;

                Context.UserRoles.Add(role);
            }

            Context.SaveChanges();

            return entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, Database.User entity)
        {
            var salt = GenerateSalt();
            entity.CreatedAt = DateTime.Now;
            entity.LastModified = DateTime.Now;
            entity.PasswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }

        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
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

        public override IQueryable<Database.User> AddFilter(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.Username == search.Username);
            }

            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                filteredQuery = filteredQuery.Where(x => x.Email == search.Email);
            }

            return filteredQuery;
        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            if (search?.IncludeRoles == true)
            {
                query = query.Include("UserRoles.Role");
            }

            return query;
        }

        public Model.User Login(string username, string password)
        {
            var entity = Context.Users.Include("UserRoles.Role").FirstOrDefault(x => x.Username == username);
            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return Mapper.Map<Model.User>(entity);
        }
    }
}
