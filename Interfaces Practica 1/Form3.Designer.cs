namespace Interfaces_Practica_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            Nombre = new Label();
            crearBtn = new Button();
            dtpFechaFin = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(63, 9);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // crearBtn
            // 
            crearBtn.Location = new Point(77, 240);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(75, 23);
            crearBtn.TabIndex = 2;
            crearBtn.Text = "Guardar";
            crearBtn.UseVisualStyleBackColor = true;
            crearBtn.Click += btnGuardar_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(63, 115);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 23);
            dtpFechaFin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 97);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Fecha Fin";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 296);
            Controls.Add(label1);
            Controls.Add(dtpFechaFin);
            Controls.Add(crearBtn);
            Controls.Add(Nombre);
            Controls.Add(txtNombre);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label Nombre;
        private Button crearBtn;
        private DateTimePicker dtpFechaFin;
        private Label label1;
    }
}