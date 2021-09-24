using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Puente viejo",direccion= "calle 72",coord_x= -72.12341,coord_y= 4.723112,tipo= "Metro"},
                new Estaciones{id=2,nombre="La pradera",direccion= "carrera 32",coord_x= -43.98174,coord_y= 16.94772,tipo= "Alimentador"},
                new Estaciones{id=3,nombre="A31",direccion= "calle 5",coord_x= -5.96237,coord_y= 24.715239,tipo= "Tranvia"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetBusWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}