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
        }

        private void infoTarea_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string titulo = buttonName.Text;
            string descripcion = textBox2.Text;

            if (titulo != "")
            {
                bool estado = checkBox1.Checked;
                Tarea tarea = new Tarea(titulo, descripcion, estado, fecha.Value);
                lista.Items.Add(tarea);
                buttonName.Text = "";
                textBox2.Text = "";
                checkBox1.Checked = false;
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
                    "Estado: COMPLETADO" + Environment.NewLine +
                    "Fecha: " + tarea.Fecha.ToShortDateString();
            }
        }
    }
}
