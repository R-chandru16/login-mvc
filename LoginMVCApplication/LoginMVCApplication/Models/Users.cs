﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVCApplication.Models
{
    public class Users
    {
          
          [Key]
            public string EmailID { get; set; }
            public string Password { get; set; }
        }
    }


