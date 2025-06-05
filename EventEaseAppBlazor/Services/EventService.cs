using System;
using System.Collections.Generic;
using System.Linq;
using EventEaseAppBlazor.Models;

namespace EventEaseAppBlazor.Services
{
    public class EventService
    {
        private readonly List<Event> eventos = new()
        {
            new Event { Id = 1, Nombre = "Concierto de Rock", Fecha = new DateTime(2024, 6, 15), Ubicacion = "Madrid", Descripcion = "Un gran concierto de rock.", Organizador = "LiveMusic", Categoria = "Música" },
            new Event { Id = 2, Nombre = "Feria del Libro", Fecha = new DateTime(2024, 7, 10), Ubicacion = "Barcelona", Descripcion = "Feria anual de libros.", Organizador = "Cultura Viva", Categoria = "Cultura" },
            new Event { Id = 3, Nombre = "Maratón Ciudad", Fecha = new DateTime(2024, 8, 5), Ubicacion = "Valencia", Descripcion = "Maratón anual.", Organizador = "DeportePlus", Categoria = "Deporte" }
        };

        public List<Event> GetAll() => eventos.ToList();

        public Event? GetById(int id) => eventos.FirstOrDefault(e => e.Id == id);

        public void Add(Event nuevo)
        {
            nuevo.Id = eventos.Any() ? eventos.Max(e => e.Id) + 1 : 1;
            eventos.Add(nuevo);
        }

        public void Remove(int id)
        {
            var evento = eventos.FirstOrDefault(e => e.Id == id);
            if (evento != null)
                eventos.Remove(evento);
        }
    }
}