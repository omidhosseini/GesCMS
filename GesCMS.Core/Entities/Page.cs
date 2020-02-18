using GesCMS.Core.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GesCMS.Core.Entities
{
    public class Page : BaseEntity
    {
        public Page()
        {
            WidgetsInPage = new List<WidgetsInPage>();
        }

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
