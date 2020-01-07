using System;
using System.Collections.Generic;

namespace WebApi_NetCore.Models
{
    public partial class Job
    {
        public Job()
        {
            User = new HashSet<User>();
        }

        public short JobId { get; set; }
        public string JobDesc { get; set; }

        public ICollection<User> User { get; set; }
    }
}
