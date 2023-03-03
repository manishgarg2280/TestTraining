using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Web.UI.WebControls;

namespace TestSitecore.web.Models
{
    public class EventRenderingViewModel
    {
        public Item item { get; set; }
        public string EventName {
            get
            {
                return FieldRenderer.Render(this.item,"EventName");
            }
        }
        public string EventDate {
            get
            {
                return FieldRenderer.Render(this.item, "EventDate");
            }
        }
        public string EventDescription {
            get
            {
                return FieldRenderer.Render(this.item, "EventDescription");
            }
        }
        //public string EventName { get; set; }
        //public string EventDate { get; set; }
        //public string EventDescription { get; set; }
    }
}