namespace EJ1
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
            btnSolicitar = new Button();
            lbResultado = new Label();
            lbMostrarValor = new Label();
            btnVer = new Button();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(85, 22);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(121, 54);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Agregar";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(30, 152);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(95, 140);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(100, 41);
            lbMostrarValor.TabIndex = 2;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(89, 81);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(111, 40);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 190);
            Controls.Add(btnVer);
            Controls.Add(lbMostrarValor);
            Controls.Add(lbResultado);
            Controls.Add(btnSolicitar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label lbResultado;
        private Label lbMostrarValor;
        private Button btnVer;
    }
}
