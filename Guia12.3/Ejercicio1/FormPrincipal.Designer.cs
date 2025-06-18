namespace Ejercicio1
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbNombre2 = new TextBox();
            tbNombre1 = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            btnAnotar = new Button();
            btnVer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbNombre2);
            groupBox1.Controls.Add(tbNombre1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(455, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 4;
            label3.Text = "Nombre Jugador 2";
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(179, 75);
            tbNombre2.Margin = new Padding(4);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.Size = new Size(143, 29);
            tbNombre2.TabIndex = 3;
            // 
            // tbNombre1
            // 
            tbNombre1.Location = new Point(179, 38);
            tbNombre1.Margin = new Padding(4);
            tbNombre1.Name = "tbNombre1";
            tbNombre1.Size = new Size(143, 29);
            tbNombre1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre Jugador 1";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(344, 41);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 55);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnAnotar
            // 
            btnAnotar.Location = new Point(128, 143);
            btnAnotar.Margin = new Padding(4);
            btnAnotar.Name = "btnAnotar";
            btnAnotar.Size = new Size(96, 55);
            btnAnotar.TabIndex = 0;
            btnAnotar.Text = "Anotar";
            btnAnotar.UseVisualStyleBackColor = true;
            btnAnotar.Click += btnAnotar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(258, 143);
            btnVer.Margin = new Padding(4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(184, 55);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver Ganador torneo";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 213);
            Controls.Add(btnVer);
            Controls.Add(groupBox1);
            Controls.Add(btnAnotar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tenis";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbNombre1;
        private Label label1;
        private Button btnRegistrar;
        private Button btnAnotar;
        private Label label3;
        private TextBox tbNombre2;
        private Button btnVer;
    }
}
