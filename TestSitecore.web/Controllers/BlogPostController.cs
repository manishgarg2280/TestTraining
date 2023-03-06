using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSitecore.web.Models;
using Sitecore.Data.Fields;
//using Sitecore.Mvc.Controllers;

namespace TestSitecore.web.Controllers
{
    public class BlogPostController : Controller
    //public class BlogPostController : SitecoreController
    {
        // GET: BlogPost
        public ActionResult BlogDetails()
        {
            var contextItem = Sitecore.Context.Item;
            BlogPostViewModel model = new BlogPostViewModel();
            Field title = contextItem.Fields["Title"];
            Field summary = contextItem.Fields["Summary"];
            Field body = contextItem.Fields["Body"];
            DateField date = contextItem.Fields["Date"];
            ImageField image = contextItem.Fields["Image"];
            ReferenceField authorField = contextItem.Fields["Author"];

            Sitecore.Data.Items.Item authorItem = authorField.TargetItem;

            if (authorItem != null) { 
            Field authorName = authorItem.Fields["Author"];

            Field designation = authorItem.Fields["Designation"];
            Field authorImage = authorItem.Fields["Image"];
            Field authorSummary = authorItem.Fields["Summary"];
                model.Author = new Author
                {
                    AuthorName = authorName.Value,
                    Designation = designation.Value,
                    AuthorImage = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image.MediaItem))
                };
            }
            model.Title = title.Value;
            model.Summary = summary.Value;
            model.Body = body.Value;
            model.BlogPostDate = date.DateTime;
            model.BlogImage = Sitecore.StringUtil.EnsurePrefix('/',Sitecore.Resources.Media.MediaManager.GetMediaUrl(image.MediaItem));

            
           
            return View(model);
        }
    }
}