using System;

namespace EventEaseAppBlazor.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Organizador { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;

        public Event() { }

        public Event(int id, string nombre, DateTime fecha, string ubicacion, string descripcion, string organizador, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Fecha = fecha;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
            Organizador = organizador;
            Categoria = categoria;
        }
    }
}