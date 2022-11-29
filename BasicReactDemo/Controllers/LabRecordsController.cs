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
        private readonly List<FlattenedLabRecord> _records;

        public LabRecordsController(IOptions<List<FlattenedLabRecord>> recordsOptions) 
        { 
            _records = recordsOptions.Value;

        }

        // GET: LabRecordsController
        [HttpGet]
        public IEnumerable<FlattenedLabRecord> Index()
        {
            return _records;
        }

        // GET: LabRecordsController/Details/{name}
        public IEnumerable<FlattenedLabRecord> Details(string name)
        {
            var selected = _records
                .Where(r => string.Equals(r.Name, name));

            return selected;
        }


        // GET: LabRecordsController/Names
        [HttpGet]
        public IEnumerable<string> Names()
        {
            var selected = _records.Select(r => r.Name).Distinct();
            return selected;
        }

        //// GET: LabRecordsController/Categories
        //public IEnumerable<string> Categories()
        //{
        //    var selected = _records
        //        .Where(r => string.Equals(r.Name, name));

        //    return selected;
        //}

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
