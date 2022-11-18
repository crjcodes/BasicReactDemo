using BasicReactDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BasicReactDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LabRecordsController : Controller
    {
        private readonly List<LabRecord> _records;

        public LabRecordsController(IOptions<List<LabRecord>> recordsOptions) 
        { 
            _records = recordsOptions.Value;

        }

        // GET: LabRecordsController
        [HttpGet]
        public IEnumerable<LabRecord> Index()
        {
            return _records;
        }

        // GET: LabRecordsController/Details/{name}
        public LabRecord? Details(string name)
        {
            return _records.Where(r => string.Equals(r.Name, name)).FirstOrDefault();
        }

        // GET: LabRecordsController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: LabRecordsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LabRecordsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: LabRecordsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LabRecordsController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: LabRecordsController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
