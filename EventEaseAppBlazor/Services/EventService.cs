using System;
using System.Collections.Generic;
using System.Linq;
using EventEaseAppBlazor.Models;

namespace EventEaseAppBlazor.Services
{
    public class EventService
    {
        private readonly List<Event> _eventos = new();
        private int _nextId = 1;

        public List<Event> GetAll()
        {
            return _eventos.ToList();
        }

        public void Add(Event evento)
        {
            evento.Id = _nextId++;
            _eventos.Add(evento);
        }

        public void Delete(int id)
        {
            var evento = _eventos.FirstOrDefault(e => e.Id == id);
            if (evento != null)
            {
                _eventos.Remove(evento);
            }
        }

        public Event? GetById(int id)
        {
            return _eventos.FirstOrDefault(e => e.Id == id);
        }
    }
}