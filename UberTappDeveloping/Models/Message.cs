﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UberTappDeveloping.Models
{
    public class Message
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }
    }
}