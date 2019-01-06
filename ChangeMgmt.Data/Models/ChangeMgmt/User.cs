using System;
using System.Collections.Generic;

namespace ChangeMgmt.Data.Models.ChangeMgmt
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Password { get; set; }
    }
}
