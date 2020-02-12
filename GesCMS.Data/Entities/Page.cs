using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GesCMS.Data.Entities
{
    public class Page
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Page Title")]
        public string PageTitle { get; set; }
        public virtual List<WidgetsInPage> WidgetsInPage { get; set; }
        [Display(Name = "Parent Page")]
        public virtual Page ParentPage { get; set; }
        public string Route { get; set; }
        [Display(Name = "set as Home Page ")]
        public bool IsHomePage { get; set; }
    }
}
