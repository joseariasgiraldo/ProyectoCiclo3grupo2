using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Aviones> GetAll()
        {
            return _appContext.Aviones;
        }
 
        public Aviones GetWithId(int id){
            return _appContext.Aviones.Find(id);
        }

        public Aviones Update(Aviones newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);
            if(avion != null){
                avion.modelo = newAvion.modelo;
                avion.marca = newAvion.marca;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_banos = newAvion.numero_banos;
                avion.capacidad_peso = newAvion.capacidad_peso;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
            return avion;
        }

        public Aviones Create(Aviones newavion)
        {
            var addavion = _appContext.Aviones.Add(newavion);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addavion.Entity;
        }

        public Aviones Delete(int id)
        {
            var avion = _appContext.Aviones.Find(id);
            if (avion != null){
                _appContext.Aviones.Remove(avion);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }

    }
}