
namespace P01AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            this.btnPokazSzczegoly = new System.Windows.Forms.Button();
            this.txtNapis = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPokazSzczegoly
            // 
            this.btnPokazSzczegoly.Location = new System.Drawing.Point(22, 22);
            this.btnPokazSzczegoly.Name = "btnPokazSzczegoly";
            this.btnPokazSzczegoly.Size = new System.Drawing.Size(143, 64);
            this.btnPokazSzczegoly.TabIndex = 0;
            this.btnPokazSzczegoly.Text = "Szczegóły";
            this.btnPokazSzczegoly.UseVisualStyleBackColor = true;
            this.btnPokazSzczegoly.Click += new System.EventHandler(this.btnPokazSzczegoly_Click);
            // 
            // txtNapis
            // 
            this.txtNapis.Location = new System.Drawing.Point(22, 109);
            this.txtNapis.Name = "txtNapis";
            this.txtNapis.Size = new System.Drawing.Size(143, 20);
            this.txtNapis.TabIndex = 1;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(19, 150);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(35, 13);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "label1";
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 195);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.txtNapis);
            this.Controls.Add(this.btnPokazSzczegoly);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokazSzczegoly;
        private System.Windows.Forms.TextBox txtNapis;
        private System.Windows.Forms.Label lblWynik;
    }
}

