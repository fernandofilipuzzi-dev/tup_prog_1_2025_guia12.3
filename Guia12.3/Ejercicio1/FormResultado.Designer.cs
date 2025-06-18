namespace Ejercicio1_Tenis
{
    partial class FormResultado
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
            groupBox3 = new GroupBox();
            tbResultado = new TextBox();
            button1 = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbResultado);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(4, 2);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(484, 151);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(8, 30);
            tbResultado.Margin = new Padding(4);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(468, 113);
            tbResultado.TabIndex = 2;
            tbResultado.Text = "tbResultado";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(196, 160);
            button1.Name = "button1";
            button1.Size = new Size(96, 38);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormResultado
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 210);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormResultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        public TextBox tbResultado;
        private Button button1;
    }
}