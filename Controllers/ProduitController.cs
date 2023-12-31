using Microsoft.AspNetCore.Mvc;
using tp4Routing.Models;

namespace tp4Routing.Controllers
{
    public class ProduitController : Controller
    {
       static List<Produit> produits = new List<Produit>
        {
            new Produit { Id = 1, Description = "Produit 1", PrixUnitaire = 10.99m },
            new Produit { Id = 2, Description = "Produit 2", PrixUnitaire = 15.99m },
            new Produit { Id = 3, Description = "Produit 3", PrixUnitaire = 8.49m }

        };

        //routing par attributs
        [Route("/")]
        [Route("Accueil")]
        [Route("Accueil/Index")]
        public IActionResult Accueil()
        {
            ViewBag.ProduitsList = produits;
            return View();
        }
        //public IActionResult ListProduits()
        //{
        //    return View();
        //}

        [Route("Edit")]
        [Route("Edit/{id:int}")]
        public IActionResult Edit(int Id)
        {
            return View(produits[Id-1]);
        }

        [Route("Update")]
        [Route("Update/{id:int}")]
        public IActionResult Update(Produit produit)
        {
           // ViewBag.ProduitsList = produits;
            var product = produits.Find(p => p.Id == produit.Id);
            product.Description = produit.Description ;
            return RedirectToAction("Lister");
        }

        [Route("Lister")]
        [Route("Lister/{id:int}")]
        public IActionResult Lister()
        {
            ViewBag.ProduitsList = produits;
            return View();
        }


    }
}
