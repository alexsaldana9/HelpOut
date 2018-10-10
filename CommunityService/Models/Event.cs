﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityService.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Category { set; get; }
        public string ExtraInfo { set; get; }
    }
}