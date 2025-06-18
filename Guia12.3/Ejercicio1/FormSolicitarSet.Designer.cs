namespace Ejercicio1_Tenis
{
    partial class FormSolicitarSet
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
            groupBox2 = new GroupBox();
            lbNroSet = new Label();
            label5 = new Label();
            label4 = new Label();
            nudResultado2 = new NumericUpDown();
            nudResultado1 = new NumericUpDown();
            label2 = new Label();
            btnAnotar = new Button();
            button1 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudResultado2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResultado1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbNroSet);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudResultado2);
            groupBox2.Controls.Add(nudResultado1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnAnotar);
            groupBox2.Location = new Point(13, 13);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(457, 145);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Anotar Sets";
            // 
            // lbNroSet
            // 
            lbNroSet.AutoSize = true;
            lbNroSet.BackColor = SystemColors.ActiveCaption;
            lbNroSet.Location = new Point(223, 27);
            lbNroSet.Margin = new Padding(4, 0, 4, 0);
            lbNroSet.Name = "lbNroSet";
            lbNroSet.Size = new Size(72, 21);
            lbNroSet.TabIndex = 6;
            lbNroSet.Text = "lbNroSet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 5;
            label5.Text = "Número Set:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 4;
            label4.Text = "Jugador 2";
            // 
            // nudResultado2
            // 
            nudResultado2.Location = new Point(166, 90);
            nudResultado2.Margin = new Padding(5, 6, 5, 6);
            nudResultado2.Name = "nudResultado2";
            nudResultado2.Size = new Size(91, 29);
            nudResultado2.TabIndex = 3;
            // 
            // nudResultado1
            // 
            nudResultado1.Location = new Point(30, 91);
            nudResultado1.Margin = new Padding(5, 6, 5, 6);
            nudResultado1.Name = "nudResultado1";
            nudResultado1.Size = new Size(96, 29);
            nudResultado1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Jugador 1";
            // 
            // btnAnotar
            // 
            btnAnotar.DialogResult = DialogResult.OK;
            btnAnotar.Location = new Point(346, 75);
            btnAnotar.Margin = new Padding(4);
            btnAnotar.Name = "btnAnotar";
            btnAnotar.Size = new Size(96, 55);
            btnAnotar.TabIndex = 0;
            btnAnotar.Text = "Anotar";
            btnAnotar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(192, 166);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormSolicitarSet
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 214);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormSolicitarSet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de sets";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudResultado2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResultado1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        public Label lbNroSet;
        private Label label5;
        private Label label4;
        public NumericUpDown nudResultado2;
        public NumericUpDown nudResultado1;
        private Label label2;
        private Button btnAnotar;
        private Button button1;
    }
}