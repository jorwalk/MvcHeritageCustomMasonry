using System.Web.Mvc;

namespace MvcHeritageCustomMasonry.Controllers
{
    public class RockController : Controller
    {
        public enum HarristoneCategories
        {
            Chief_Joseph,
            Cobble,
            Fieldstone,
            Granite,
            Ledgestone,
            Guillotine,
            Limestone,
            Ridgestone,
            Rolled_River_Rock,
            Sandstone,
            Thin_Brick,
            Uintah
        }

        public enum EldoradoCategories
        {
            Bluffstone,
            Cliffstone,
            Country_Rubble,
            Fieldledge,
            Hillstone,
            Limestone,
            Mountain_Ledge,
            River_Rock,
            Rustic_Ledge,
            Shadow_Rock,
            Stacked_Stone,
            Top_Rock
        };

        //
        // GET: /Rock/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Rock/Harristone
        public ActionResult Harristone(HarristoneCategories categories)
        {
            return View(categories);
        }

        //
        // GET: /Rock/Eldorado
        public ActionResult Eldorado(EldoradoCategories categories)
        {
            return View(categories);
        }
    }
}