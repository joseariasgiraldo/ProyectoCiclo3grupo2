using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Airbus",modelo= "A320",numero_asientos= "120",numero_cabinas= "2",capacidad_en_peso= "2000"},
                new Aviones{id=1,marca="Boeing",modelo= "747",numero_asientos= "100",numero_cabinas= "2",capacidad_en_peso= "1800"},
                
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetWithId(int id){
            return aviones.SingleOrDefault(a => a.id == id);
        }
    }
}