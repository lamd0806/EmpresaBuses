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
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }

        public Estaciones Create(Estaciones newEstacion)
        {
            if(estaciones.Count > 0){
           newEstacion.id=estaciones.Max(r => r.id) +1; 
            }else{
               newEstacion.id = 1; 
            }
           estaciones.Add(newEstacion);
           return newEstacion;
        }

        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;
        }

        public Estaciones Delete(int id)
        {
        var estacion= estaciones.SingleOrDefault(b => b.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }

    }
}