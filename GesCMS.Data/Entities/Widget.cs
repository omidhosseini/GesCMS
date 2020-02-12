using System;
using System.Collections.Generic;
using System.Text;

namespace GesCMS.Data.Entities
{
    public class Widget
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int? ParentID { get; set; }
    }
}
