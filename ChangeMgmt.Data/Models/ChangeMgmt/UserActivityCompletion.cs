using System;
using System.Collections.Generic;

namespace ChangeMgmt.Data.Models.ChangeMgmt
{
    public partial class UserActivityCompletion
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool Void { get; set; }
        public string Comments { get; set; }

        public virtual UserActivity Activity { get; set; }
        public virtual User User { get; set; }
    }
}
