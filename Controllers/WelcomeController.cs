using Ex2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Ex2.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            ViewBag.Message = "Bienvenue dans ma nouvelle application!";
            return View();
        }
        public IActionResult WelcomeName(string prenom, string nom)
        {
            ViewBag.Message = $"Salut {prenom} {nom}! Bienvenue dans ma nouvelle application!";
            return View();
        }
        public string WelcomeEssai()
        {
            return "<h2>Bienvenu dans mon site web</h2>";
        }
        public ContentResult SendContent()
        {
            string s = "<h2>Bienvenu dans mon site web</h2>";
            return Content(s, "text/html");
        }
        public IActionResult Welcome3()
        {
            return View();
        }
        public IActionResult DisplayPdf()
        {
            // Chemin du fichier PDF
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "horaire.pdf");

            // Vérifier si le fichier existe
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("Le fichier PDF n'existe pas.");
            }

            // Retourner le fichier PDF en tant que résultat de type FileStreamResult
            return new FileStreamResult(new FileStream(filePath, FileMode.Open), "application/pdf");
        }
        public IActionResult Ex5()
        {
            List<Client> clients = new List<Client>();
            Client c1 = new Client(8195998789,"Jessy","Dion","Jessy123@gmail.com");
            Client c2 = new Client(8195997892, "Jessy", "Dion", "Jessy123@gmail.com");
            Client c3 = new Client(8195465987, "Jessy", "Dion", "Jessy123@gmail.com");
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);

            var json = JsonSerializer.Serialize(clients);

            return Content(json, "application/json");
        }
        public IActionResult RedirectToWelcomeDefault()
        {
            // Redirection vers la méthode d'action WelcomeDefault
            return RedirectToAction("WelcomeEssai");
        }
    }
}
