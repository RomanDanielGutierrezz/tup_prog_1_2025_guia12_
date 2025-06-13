namespace EJ1
{
    partial class FormsDatos
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
            lbValor = new Label();
            tbValor = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(13, 28);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 0;
            lbValor.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(57, 25);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(191, 23);
            tbValor.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(57, 79);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(173, 79);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormsDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 128);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(tbValor);
            Controls.Add(lbValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormsDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormsDatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbValor;
        private TextBox textBox1;
        private Button btnOk;
        private Button btnCancel;
        public TextBox tbValor;
    }
}