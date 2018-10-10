using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityService.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Category { set; get; }
        public string ExtraInfo { set; get; }
    }
}