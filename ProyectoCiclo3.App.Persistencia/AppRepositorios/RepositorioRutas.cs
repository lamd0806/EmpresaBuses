using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;

namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas{
            List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                //Los nombres de los campos deben coincidir con los nombres creados en la entidad
                new Rutas{id=1,origen=1,destino= 2,tiempo_estimado= 30},
                new Rutas{id=2,origen=2,destino= 3,tiempo_estimado= 180},
                new Rutas{id=3,origen=5,destino= 1,tiempo_estimado= 210}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return rutas.SingleOrDefault(r => r.id == id);
        }

        public Rutas Create(Rutas newRuta)
        {
           newRuta.id=rutas.Max(r => r.id) +1; 
           rutas.Add(newRuta);
           return newRuta;
        }

        public Rutas Update(Rutas newRutas){
            var ruta= rutas.SingleOrDefault(r => r.id == newRutas.id);
            if(ruta != null){
                ruta.origen = newRutas.origen;
                ruta.destino = newRutas.destino;
                ruta.tiempo_estimado = newRutas.tiempo_estimado;
            }
        return ruta;
        }


    }
}