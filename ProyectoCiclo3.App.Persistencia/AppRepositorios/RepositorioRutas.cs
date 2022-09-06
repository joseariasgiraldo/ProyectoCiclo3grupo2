using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Bogota",destino= "Italia",tiempo_estimado= "15"},
                new Rutas{id=1,origen="Medellin",destino= "Canada",tiempo_estimado= "11"},
                
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(a => a.id == id);
        }
    }
}