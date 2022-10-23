using AutoMapper;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.ProjectStateMachine
{
    public class ActiveProjectState : BaseState
    {
        public ActiveProjectState(IMapper mapper, IServiceProvider serviceProvider, _160020Context context) : base(mapper, serviceProvider, context)
        {
        }
    }
}
