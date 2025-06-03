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
            usuarioTxt = new TextBox();
            claveTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            mensajeTxt = new Label();
            SuspendLayout();
            // 
            // usuarioTxt
            // 
            usuarioTxt.Location = new Point(67, 78);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(123, 23);
            usuarioTxt.TabIndex = 0;
            // 
            // claveTxt
            // 
            claveTxt.Location = new Point(67, 154);
            claveTxt.Name = "claveTxt";
            claveTxt.Size = new Size(123, 23);
            claveTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 57);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 133);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(174, 203);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // mensajeTxt
            // 
            mensajeTxt.AutoSize = true;
            mensajeTxt.Location = new Point(37, 193);
            mensajeTxt.Name = "mensajeTxt";
            mensajeTxt.Size = new Size(0, 15);
            mensajeTxt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 238);
            Controls.Add(mensajeTxt);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(claveTxt);
            Controls.Add(usuarioTxt);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuarioTxt;
        private TextBox claveTxt;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private Label mensajeTxt;
    }
}
