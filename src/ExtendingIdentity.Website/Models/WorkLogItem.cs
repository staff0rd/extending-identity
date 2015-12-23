using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendingIdentity.Website.Models
{
    public class WorkLogItem
    {
        [Key]
        public int id { get; set; }
        public String UserId { get; set; }
        public int Hours { get; set; }
        public String Description { get; set; }
    }
}
