﻿using Scheduler.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Data.Abstract
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
    }
}
