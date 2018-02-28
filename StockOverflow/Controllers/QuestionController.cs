using Newtonsoft.Json;
using StockOverflow.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockOverflow.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            var path = "your path is here";

            var Item = new List<Item>();

            using (StreamReader streamreader = new StreamReader(path))
            {
                var json = streamreader.ReadToEnd();
                Rootobject RO = JsonConvert.DeserializeObject<Rootobject>(json);

                Item = RO.items.ToList();

            }

            return View(Item);
        }
    }
}