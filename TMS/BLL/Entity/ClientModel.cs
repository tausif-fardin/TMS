﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class ClientModel
    {
        public int clientid { get; set; }
        public string clientname { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string type { get; set; }
        public string clientemail { get; set; }
        public string mobilenumber { get; set; }
        public int employeeid { get; set; }
        public bool status { get; set; }
    }
}
