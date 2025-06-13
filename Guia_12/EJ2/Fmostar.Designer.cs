namespace EJ2
{
    partial class Fmostar
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
            lbMostrarValor = new Label();
            btnSalir = new Button();
            lbNumero = new Label();
            SuspendLayout();
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.AutoSize = true;
            lbMostrarValor.Location = new Point(25, 36);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(33, 15);
            lbMostrarValor.TabIndex = 1;
            lbMostrarValor.Text = "Valor";
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.OK;
            btnSalir.Location = new Point(69, 78);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lbNumero
            // 
            lbNumero.BackColor = SystemColors.ActiveCaption;
            lbNumero.Location = new Point(69, 36);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(134, 23);
            lbNumero.TabIndex = 3;
            lbNumero.Text = "Numero";
            // 
            // Fmostar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 136);
            Controls.Add(lbNumero);
            Controls.Add(btnSalir);
            Controls.Add(lbMostrarValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Fmostar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fmostar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbMostrarValor;
        private Button btnSalir;
        public Label lbNumero;
    }
}