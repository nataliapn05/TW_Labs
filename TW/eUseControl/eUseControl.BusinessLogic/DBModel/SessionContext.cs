﻿using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel
{
    public class SessionContext:DbContext
    {
        public SessionContext() : base("name=Bib")
        {
        }
        public virtual DbSet<Session> Session { get; set; }
    }
}
