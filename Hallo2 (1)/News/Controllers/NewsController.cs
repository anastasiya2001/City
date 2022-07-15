using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.EF;
using News.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace News.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Show(string path)
        {
            //return Content("Hallo world!" + id);
            ViewBag.Today = DateTime.Now.ToString("dd.mm.yyyy");
            DbCont db = new DbCont();
            db.Run();
            ViewBag.Rubrics = db.Rubrics.OrderBy(x => x.Name).ToList();

            if (path == null)
            {
                // в корне сайта 
                ViewBag.Publications = db.Publications.OrderByDescending(x => x.Date).ToList();
            }
            else
            {
                ViewBag.Publications = db.Publications.Where(x => x.Rubricator.Path == path).OrderByDescending(x => x.Date).ToList();
            }

            return View();
        }

        public IActionResult NewShow(string path, string nick, string text)
        {
            DbCont db = new DbCont();

            Publication p = db.Publications.FirstOrDefault(x => x.Path == path);
            if (p == null)
            {
                return NotFound();
            }

            if (nick != null && text != null)
            {
                Comment comment = new Comment
                {
                    Publication = p,
                    DateTime = DateTime.Now,
                    Nick = nick,
                    Text = text
                };
                db.Comments.Add(comment);
                // db.SaveChanges();
            }

            ViewBag.Comments = db.Comments.Where(x => x.Publication == p).OrderByDescending(x => x.DateTime).ToList();
            ViewBag.Publication = p;
            ViewBag.Today = DateTime.Now.ToString("dd.MM.yyyy");
            ViewBag.Rubrics = db.Rubrics.OrderBy(x => x.Name).ToList();

            return View();
        }
        public IActionResult Search(string text)
        {
            DbCont db = new DbCont();

            ViewBag.Today = DateTime.Now.ToString("dd.MM.yyyy");
            ViewBag.Rubrics = db.Rubrics.OrderBy(x => x.Name).ToList();

            var publications = db.Publications.Where(x => x.Title.IndexOf(text) >= 0 || x.Announce.IndexOf(text) >= 0).ToList();
            if (publications.Count == 0)
            {
                return View("SearchNoResults");
            }

            ViewBag.Publications = publications;
            return View("Search");
        }
        
    }
}
