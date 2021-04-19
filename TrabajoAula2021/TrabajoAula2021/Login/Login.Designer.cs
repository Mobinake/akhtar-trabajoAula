namespace TrabajoAula2021.Login
{
    partial class Login
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
            this.labelprueba = new System.Windows.Forms.Label();
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelprueba
            // 
            this.labelprueba.AutoSize = true;
            this.labelprueba.Location = new System.Drawing.Point(157, 220);
            this.labelprueba.Name = "labelprueba";
            this.labelprueba.Size = new System.Drawing.Size(41, 13);
            this.labelprueba.TabIndex = 0;
            this.labelprueba.Text = "Prueba";
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(33, 215);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(75, 23);
            this.buttonPrueba.TabIndex = 1;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(103, 169);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(30, 58);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(30, 102);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 13);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonPrueba);
            this.Controls.Add(this.labelprueba);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelprueba;
        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPass;
    }
}