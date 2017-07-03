﻿using Ninesky.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninesky.DAL
{
    /// <summary>
    /// 数据上下文
    /// <remarks>创建：2017.07.03</remarks>
    /// </summary>
    public class NineskyDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public NineskyDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
