using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Page : AuditableEntity
    {
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
