using System;
using System.Collections.Generic;

namespace ChangeMgmt.Data.Models.ChangeMgmt
{
    public partial class UserActivity
    {
        public UserActivity()
        {
            UserActivityCompletion = new HashSet<UserActivityCompletion>();
        }

        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserActivityCompletion> UserActivityCompletion { get; set; }
    }
}
