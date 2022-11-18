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

        /// <summary>
        /// Until I know React well enough to tell it a nested structure...
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        static public List<FlattenedLabRecord> Flatten(LabRecord? record) 
        {
            // Yes, LINQ would condense this nicely
            // keeping expanded for debugging and development

            var result = new List<FlattenedLabRecord>();

            if (record == null)
                return result;

            foreach (var labMeasurement in record.LabMeasurements)
            {
                var flattened = new FlattenedLabRecord()
                {
                    Name = record.Name,
                    DateMeasured = labMeasurement.DateMeasured,
                    Value = labMeasurement.Value
                };

                result.Add(flattened);
            }

            return result; 
        }

        // GET: LabRecordsController/Details/{name}
        public IEnumerable<FlattenedLabRecord> Details(string name)
        {
            var selected = _records
                .Where(r => string.Equals(r.Name, name));

            return selected;
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
