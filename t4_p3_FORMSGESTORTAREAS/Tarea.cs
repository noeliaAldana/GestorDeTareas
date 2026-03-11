using System;

namespace t4_p3_FORMSGESTORTAREAS
{
    internal class Tarea
    {
        private string titulo;
        private string descripcion;
        private bool completada;
        private DateTime fecha;
		//
		private string categoria;
        //
		public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public bool PrioridadAlta { get; set; }

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
		//
		public string Categoria
		{
			get { return categoria; }
			set { categoria = value; }
		}
        //

		public Tarea(string titulo, string descripcion, bool completada, DateTime fecha, bool prioridadAlta, string categoria)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.completada = completada;
            this.fecha = fecha;
            PrioridadAlta = prioridadAlta;
            //
			this.categoria = categoria;
            //

		}

		public override string ToString()
        {
            string estado = Completada ? "✔ " : "";
            string prioridad = PrioridadAlta ? "🔥 " : "";

            return estado + Titulo + " [" + Categoria + "] " + prioridad;
        }
    }
}
