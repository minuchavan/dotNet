﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationExample
{
    [Serializable]
    internal class Notice
    {
        public int NoticeID { get; set; }
        public string NoticeTitle { get; set; }
        public string NoticeDescription { get; set; }
        public DateTime NoticeDate { get; set; }
        public string createdBy { get; set; } = "Admin";
    }
}
