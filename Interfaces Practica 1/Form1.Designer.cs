namespace Interfaces_Practica_1
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
            dataGridView1 = new DataGridView();
            agregarbtn = new Button();
            eliminarbtn = new Button();
            modificarbtn = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(330, 406);
            dataGridView1.TabIndex = 0;
            // 
            // agregarbtn
            // 
            agregarbtn.Location = new Point(12, 415);
            agregarbtn.Name = "agregarbtn";
            agregarbtn.Size = new Size(75, 23);
            agregarbtn.TabIndex = 1;
            agregarbtn.Text = "Agregar";
            agregarbtn.UseVisualStyleBackColor = true;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Location = new Point(174, 415);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(75, 23);
            eliminarbtn.TabIndex = 2;
            eliminarbtn.Text = "Eliminar";
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // modificarbtn
            // 
            modificarbtn.Location = new Point(93, 415);
            modificarbtn.Name = "modificarbtn";
            modificarbtn.Size = new Size(75, 23);
            modificarbtn.TabIndex = 3;
            modificarbtn.Text = "Modificar";
            modificarbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(modificarbtn);
            Controls.Add(eliminarbtn);
            Controls.Add(agregarbtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button agregarbtn;
        private Button eliminarbtn;
        private Button modificarbtn;
        private TextBox textBox1;
    }
}
