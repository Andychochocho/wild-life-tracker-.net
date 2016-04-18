using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using WildLifeTracker.Models;
using Microsoft.Data.Entity;

namespace WildLifeTracker.Controllers
{
    public class SpeciesController : Controller
    {
        private WildLifeTrackerContext db = new WildLifeTrackerContext();
        public IActionResult Index()
        {
            return View(db.Sightings.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisSighting = db.Sightings.FirstOrDefault(x => x.SightingId == id);
            return View(thisSighting);
        }
       
    }
}
