using Microsoft.AspNetCore.Mvc;
using MvcCoreUtilidades.Models;
using MvcCoreUtilidades.Repositories;

namespace MvcCoreUtilidades.Controllers
{
    public class CochesController : Controller
    {
        private RepositoryCoches repo;

        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _CochesPartial()
        {
            List<Coche> coches = this.repo.GetCoches();
            return PartialView("_CochesPartial", coches);
        }
        public IActionResult _CochesDetails(int idCoche)
        {
            Coche coche = this.repo.FindCoche(idCoche);
            return PartialView("_CochesDetailsView", coche);
        }

        public IActionResult Details(int idCoche)
        {
            Coche coche = this.repo.FindCoche(idCoche);
            return View(coche);
        }

    }
}
