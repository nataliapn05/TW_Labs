﻿using eUseControl.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public URole Level { get; set; }
        //public List<string> Products { get; set; }
    }
}