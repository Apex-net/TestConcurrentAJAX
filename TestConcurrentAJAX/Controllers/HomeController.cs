using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.SessionState;

namespace TestConcurrentAJAX.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult CreateAsync()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public async Task<ActionResult> CreateAsync(int id)
        {
            ////try
            ////{
            ////    // TODO: Add insert logic here

            ////    return RedirectToAction("Index");
            ////}
            ////catch
            ////{
            ////    return View();
            ////}

            var delay = new Random().Next(3000, 3000);
            await Task.Delay(delay);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        double NextDouble(Random rng, double min, double max)
        {
            return min + (rng.NextDouble() * (max - min));
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
