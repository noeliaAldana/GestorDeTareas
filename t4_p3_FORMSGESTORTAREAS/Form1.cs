using System;
using System.Windows.Forms;

namespace t4_p3_FORMSGESTORTAREAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.Items.Add("Personal");
            cmbCategoria.Items.Add("Estudios");
            cmbCategoria.SelectedIndex = 0;
        }

        private void infoTarea_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string titulo = buttonName.Text;
            string descripcion = textBox2.Text;
            bool prioridadAlta = chkPrioridadAlta.Checked;
            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "";

            if (titulo != "")
            {
                bool estado = checkBox1.Checked;
                Tarea tarea = new Tarea(titulo, descripcion, estado, fecha.Value, prioridadAlta, categoria);
                lista.Items.Add(tarea);
				//
				ActualizarContador();

				//
				buttonName.Text = "";
                textBox2.Text = "";
                checkBox1.Checked = false;
                chkPrioridadAlta.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                Tarea tarea = (Tarea)lista.SelectedItem;
                infoTarea.Text =
                    "Nombre: " + tarea.Titulo + Environment.NewLine +
                    "Descripción: " + tarea.Descripcion + Environment.NewLine +
                    "Categoría: " + tarea.Categoria + Environment.NewLine +
                    "Prioridad Alta: " + (tarea.PrioridadAlta ? "SI" : "NO") + Environment.NewLine +
                    "Estado: " + (tarea.Completada ? "COMPLETADO" : "NO COMPLETADO") +
                    Environment.NewLine +
                    "Fecha: " + tarea.Fecha.ToShortDateString();
            }
            else
            {
                infoTarea.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                lista.Items.RemoveAt(lista.SelectedIndex);
                infoTarea.Text = "";
				ActualizarContador();
			}
		}

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                Tarea tarea = (Tarea)lista.SelectedItem;
                tarea.Completada = true;

                int index = lista.SelectedIndex;
                lista.Items[index] = tarea;

                infoTarea.Text =
                    "Nombre: " + tarea.Titulo + Environment.NewLine +
                    "Descripción: " + tarea.Descripcion + Environment.NewLine +
                    "Categoría: " + tarea.Categoria + Environment.NewLine +
                    "Prioridad Alta: " + (tarea.PrioridadAlta ? "SI" : "NO") + Environment.NewLine +
                    "Estado: COMPLETADO" + Environment.NewLine +
                    "Fecha: " + tarea.Fecha.ToShortDateString();
            }
        }

        private void chkPrioridadAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrioridadAlta.Checked)
            {
                chkPrioridadAlta.Text = "Prioridad Alta 🔥";
            }
            else
            {
                chkPrioridadAlta.Text = "Prioridad Alta";
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cmbCategoria.SelectedItem.ToString();

        }

        private void lblContadorTareas_Click(object sender, EventArgs e)
        {

        }
		//lblcontadortareas
		private void ActualizarContador()
		{
			lblContadorTareas.Text = "Total de tareas: " + lista.Items.Count;
		}
		//
	}
}
