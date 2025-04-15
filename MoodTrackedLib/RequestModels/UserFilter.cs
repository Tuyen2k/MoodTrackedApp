using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackedLib.RequestModels
{
    public class UserFilterAll : UserFilterEmail
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? AccessFailedCount { get; set; }

    }

    public class UserFilterEmail {
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? LockoutEnabled { get; set; }
    }
}
