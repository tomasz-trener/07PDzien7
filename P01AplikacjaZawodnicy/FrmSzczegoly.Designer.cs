
namespace P01AplikacjaZawodnicy
{
    partial class FrmSzczegoly
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
            this.lblWynik = new System.Windows.Forms.Label();
            this.txtNapis = new System.Windows.Forms.TextBox();
            this.btnPrzekazNapis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(40, 26);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(35, 13);
            this.lblWynik.TabIndex = 0;
            this.lblWynik.Text = "label1";
            // 
            // txtNapis
            // 
            this.txtNapis.Location = new System.Drawing.Point(43, 73);
            this.txtNapis.Name = "txtNapis";
            this.txtNapis.Size = new System.Drawing.Size(127, 20);
            this.txtNapis.TabIndex = 1;
            // 
            // btnPrzekazNapis
            // 
            this.btnPrzekazNapis.Location = new System.Drawing.Point(176, 71);
            this.btnPrzekazNapis.Name = "btnPrzekazNapis";
            this.btnPrzekazNapis.Size = new System.Drawing.Size(113, 23);
            this.btnPrzekazNapis.TabIndex = 2;
            this.btnPrzekazNapis.Text = "Przekaż napis";
            this.btnPrzekazNapis.UseVisualStyleBackColor = true;
            this.btnPrzekazNapis.Click += new System.EventHandler(this.btnPrzekazNapis_Click);
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 125);
            this.Controls.Add(this.btnPrzekazNapis);
            this.Controls.Add(this.txtNapis);
            this.Controls.Add(this.lblWynik);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.TextBox txtNapis;
        private System.Windows.Forms.Button btnPrzekazNapis;
    }
}