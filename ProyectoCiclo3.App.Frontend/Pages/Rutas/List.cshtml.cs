using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace ProyectoCiclo3.App.Frontend.Pages
{

    [Authorize]
    public class ListRutaModel : PageModel
    {
        [BindProperty]
        public Rutas Ruta { get; set; }
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> Rutas { get; set; }

        public ListRutaModel(RepositorioRutas repositorioRutas)
        {
            this.repositorioRutas = repositorioRutas;
        }

        public void OnGet()
        {
            Rutas = repositorioRutas.GetAll();
        }
        public IActionResult OnPost()
        {
            if (Ruta.id > 0)
            {
                //Ruta = repositorioRutas.Delete(Ruta.id);
                repositorioRutas.Delete(Ruta.id);
            }
            return RedirectToPage("./List");
        }



    }
}
