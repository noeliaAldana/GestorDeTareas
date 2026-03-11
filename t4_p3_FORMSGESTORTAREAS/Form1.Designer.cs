namespace t4_p3_FORMSGESTORTAREAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonDelete = new Button();
            buttonAdd = new Button();
            fecha = new DateTimePicker();
            lista = new ListBox();
            buttonName = new TextBox();
            label1 = new Label();
            infoTarea = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            buttonCompletar = new Button();
            chkPrioridadAlta = new CheckBox();
            cmbCategoria = new ComboBox();
            lblContadorTareas = new Label();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(297, 280);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 40);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "ELIMINAR";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button2_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 282);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(239, 38);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "AÑADIR";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button3_Click;
            // 
            // fecha
            // 
            fecha.Location = new Point(12, 232);
            fecha.Name = "fecha";
            fecha.Size = new Size(237, 23);
            fecha.TabIndex = 3;
            fecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(297, 145);
            lista.Name = "lista";
            lista.Size = new Size(231, 109);
            lista.TabIndex = 5;
            lista.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonName
            // 
            buttonName.Location = new Point(14, 57);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(235, 23);
            buttonName.TabIndex = 1;
            buttonName.TextChanged += buttonName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre de la tarea:";
            label1.Click += label1_Click;
            // 
            // infoTarea
            // 
            infoTarea.Location = new Point(297, 57);
            infoTarea.Multiline = true;
            infoTarea.Name = "infoTarea";
            infoTarea.Size = new Size(231, 82);
            infoTarea.TabIndex = 7;
            infoTarea.TextChanged += infoTarea_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripcion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 129);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 69);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 207);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "COMPLETADO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(416, 282);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(112, 38);
            buttonCompletar.TabIndex = 10;
            buttonCompletar.Text = "Completar Tarea";
            buttonCompletar.UseVisualStyleBackColor = true;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // chkPrioridadAlta
            // 
            chkPrioridadAlta.AutoSize = true;
            chkPrioridadAlta.Location = new Point(153, 207);
            chkPrioridadAlta.Name = "chkPrioridadAlta";
            chkPrioridadAlta.Size = new Size(98, 19);
            chkPrioridadAlta.TabIndex = 11;
            chkPrioridadAlta.Text = "Prioridad Alta";
            chkPrioridadAlta.UseVisualStyleBackColor = true;
            chkPrioridadAlta.CheckedChanged += chkPrioridadAlta_CheckedChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(14, 85);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 12;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // lblContadorTareas
            // 
            lblContadorTareas.AutoSize = true;
            lblContadorTareas.Location = new Point(298, 28);
            lblContadorTareas.Name = "lblContadorTareas";
            lblContadorTareas.Size = new Size(108, 15);
            lblContadorTareas.TabIndex = 13;
            lblContadorTareas.Text = "Contador de Tareas";
            lblContadorTareas.Click += lblContadorTareas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(548, 377);
            Controls.Add(lblContadorTareas);
            Controls.Add(cmbCategoria);
            Controls.Add(chkPrioridadAlta);
            Controls.Add(buttonCompletar);
            Controls.Add(checkBox1);
            Controls.Add(infoTarea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(buttonName);
            Controls.Add(lista);
            Controls.Add(fecha);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDelete;
        private Button buttonAdd;
        private DateTimePicker fecha;
        private ListBox lista;
        private TextBox buttonName;
        private Label label1;
        private TextBox infoTarea;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button buttonCompletar;
        private CheckBox chkPrioridadAlta;
        private ComboBox cmbCategoria;
        private Label lblContadorTareas;
    }
}
