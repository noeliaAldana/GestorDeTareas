using System;

namespace t4_p3_FORMSGESTORTAREAS
{
    internal class Tarea
    {
        private string titulo;
        private string descripcion;
        private bool completada;
        private DateTime fecha;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public bool Completada
        {
            get { return completada; }
            set { completada = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Tarea(string titulo, string descripcion, bool completada, DateTime fecha)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.completada = completada;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return completada ? "✔ " + titulo : titulo;
        }
    }
}
