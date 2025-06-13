namespace EJ2
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
            tbValor = new TextBox();
            btnMostrar = new Button();
            lbValor = new Label();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Location = new Point(56, 25);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(210, 23);
            tbValor.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.DialogResult = DialogResult.Continue;
            btnMostrar.Location = new Point(272, 19);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(164, 32);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Valor";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(12, 28);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 70);
            Controls.Add(lbValor);
            Controls.Add(btnMostrar);
            Controls.Add(tbValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbValor;
        private Button btnMostrar;
        private Label lbValor;
    }
}
