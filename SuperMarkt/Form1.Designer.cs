namespace SuperMarkt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.lBoxMerchandise = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(99, 90);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(262, 22);
            this.tbProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl";
            // 
            // tbProductNumber
            // 
            this.tbProductNumber.Location = new System.Drawing.Point(529, 89);
            this.tbProductNumber.Name = "tbProductNumber";
            this.tbProductNumber.Size = new System.Drawing.Size(100, 22);
            this.tbProductNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(712, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(876, 89);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(101, 45);
            this.btnDeleted.TabIndex = 5;
            this.btnDeleted.Text = "Entfernen";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // lBoxMerchandise
            // 
            this.lBoxMerchandise.FormattingEnabled = true;
            this.lBoxMerchandise.ItemHeight = 16;
            this.lBoxMerchandise.Location = new System.Drawing.Point(99, 285);
            this.lBoxMerchandise.Name = "lBoxMerchandise";
            this.lBoxMerchandise.Size = new System.Drawing.Size(546, 228);
            this.lBoxMerchandise.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1052, 637);
            this.Controls.Add(this.lBoxMerchandise);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbProductNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Super Markt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.ListBox lBoxMerchandise;
    }
}

