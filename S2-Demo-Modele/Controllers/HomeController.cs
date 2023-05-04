using Microsoft.AspNetCore.Mvc;
using S2_Demo_Modele.Models;

namespace S2_Demo_Modele.Controllers
{
    public class HomeController : Controller
    {
        //Récupérer la liste d'étudiant : modèle de base de donnée
        List<Etudiant> liste = ListeEtudiants.GetEtudiants();
        
        //Afficher la liste d'étudiants
        public IActionResult Index()
        {
            ViewData["Liste"] = liste;
            return View();
        }

        //Chercher un étudiant
        public IActionResult Chercher(int numero)
        {
            ViewData["Numero"] = numero;
            Etudiant etudiantTrouve = liste.FirstOrDefault(e => e.Numero == numero);
            if(etudiantTrouve != null)
            {
                ViewData["Nom"] = etudiantTrouve.Nom;
                return View("Etudiant");
            }   
            return View("Erreur");
        }
    }
}
