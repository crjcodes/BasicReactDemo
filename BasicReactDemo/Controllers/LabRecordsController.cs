using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicReactDemo.Controllers
{
    public class LabRecordsController : Controller
    {
        // GET: LabRecordsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LabRecordsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LabRecordsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LabRecordsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LabRecordsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LabRecordsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LabRecordsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LabRecordsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
