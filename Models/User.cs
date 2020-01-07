﻿using System;
using System.Collections.Generic;

namespace WebApi_NetCore.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public short JobId { get; set; }
        public byte? JobLevel { get; set; }
        public int PubId { get; set; }
        public DateTime HireDate { get; set; }

        public Job Job { get; set; }
        public Publisher Pub { get; set; }
    }
}
