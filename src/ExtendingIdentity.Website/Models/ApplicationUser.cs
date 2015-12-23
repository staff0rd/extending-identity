using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using ExtendingIdentity.Website.Models;

namespace ExtendingIdentity.Website.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<WorkLogItem> WorkLogItems { get; set; }
    }
}
