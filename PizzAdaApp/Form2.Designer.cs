namespace PizzAdaApp
{
    partial class Form2
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
            this.orderCountLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderCountLabel
            // 
            this.orderCountLabel.AutoSize = true;
            this.orderCountLabel.Location = new System.Drawing.Point(12, 9);
            this.orderCountLabel.Name = "orderCountLabel";
            this.orderCountLabel.Size = new System.Drawing.Size(96, 15);
            this.orderCountLabel.TabIndex = 0;
            this.orderCountLabel.Text = "Total de Pedidos:";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(12, 51);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(120, 15);
            this.totalValueLabel.TabIndex = 1;
            this.totalValueLabel.Text = "Valor Total de Vendas:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(186, 121);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 156);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.orderCountLabel);
            this.Name = "Form2";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button okButton;
        public Label orderCountLabel;
        public Label totalValueLabel;
    }
}