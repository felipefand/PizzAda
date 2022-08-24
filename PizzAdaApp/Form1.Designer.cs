namespace PizzAdaApp
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
            this.productBox = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registerNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerPriceBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.editNameBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editPriceBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productBox
            // 
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(12, 231);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(574, 23);
            this.productBox.TabIndex = 1;
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(12, 202);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(574, 23);
            this.filterBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Realizar Pedido";
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterButton.ForeColor = System.Drawing.Color.Black;
            this.filterButton.Location = new System.Drawing.Point(611, 202);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(143, 23);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Filtrar Produtos";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastrar Produto";
            // 
            // registerNameBox
            // 
            this.registerNameBox.Location = new System.Drawing.Point(61, 30);
            this.registerNameBox.Name = "registerNameBox";
            this.registerNameBox.Size = new System.Drawing.Size(340, 23);
            this.registerNameBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço:";
            // 
            // registerPriceBox
            // 
            this.registerPriceBox.Location = new System.Drawing.Point(453, 30);
            this.registerPriceBox.Name = "registerPriceBox";
            this.registerPriceBox.Size = new System.Drawing.Size(133, 23);
            this.registerPriceBox.TabIndex = 10;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(611, 30);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(143, 23);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Cadastrar";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Editar ou Remover Produto";
            // 
            // editNameBox
            // 
            this.editNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editNameBox.FormattingEnabled = true;
            this.editNameBox.Location = new System.Drawing.Point(61, 91);
            this.editNameBox.Name = "editNameBox";
            this.editNameBox.Size = new System.Drawing.Size(340, 23);
            this.editNameBox.TabIndex = 13;
            this.editNameBox.SelectedIndexChanged += new System.EventHandler(this.editNameBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Preço:";
            // 
            // editPriceBox
            // 
            this.editPriceBox.Location = new System.Drawing.Point(453, 91);
            this.editPriceBox.Name = "editPriceBox";
            this.editPriceBox.Size = new System.Drawing.Size(133, 23);
            this.editPriceBox.TabIndex = 16;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(611, 91);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(65, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.Black;
            this.removeButton.Location = new System.Drawing.Point(682, 91);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(72, 23);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.orderList.Location = new System.Drawing.Point(12, 260);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(742, 142);
            this.orderList.TabIndex = 19;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 650;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preço";
            this.columnHeader2.Width = 80;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToOrderButton.ForeColor = System.Drawing.Color.Black;
            this.addToOrderButton.Location = new System.Drawing.Point(611, 231);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(143, 23);
            this.addToOrderButton.TabIndex = 20;
            this.addToOrderButton.Text = "Adicionar ao Pedido";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsButton.ForeColor = System.Drawing.Color.Black;
            this.statsButton.Location = new System.Drawing.Point(611, 415);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(143, 23);
            this.statsButton.TabIndex = 21;
            this.statsButton.Text = "Consultar Estatísticas";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishOrderButton.ForeColor = System.Drawing.Color.Black;
            this.finishOrderButton.Location = new System.Drawing.Point(12, 415);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(135, 23);
            this.finishOrderButton.TabIndex = 22;
            this.finishOrderButton.Text = "Finalizar Pedido";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteEntryButton.Location = new System.Drawing.Point(453, 415);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(143, 23);
            this.deleteEntryButton.TabIndex = 23;
            this.deleteEntryButton.Text = "Deletar Última Entrada";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 136);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 15);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Status: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(153, 419);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 15);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Preço Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.editPriceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerPriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.productBox);
            this.Name = "Form1";
            this.Text = "PizzAda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox productBox;
        private TextBox filterBox;
        private Label label1;
        private Button filterButton;
        private Label label2;
        private TextBox registerNameBox;
        private Label label3;
        private Label label4;
        private TextBox registerPriceBox;
        private Button registerButton;
        private Label label5;
        private ComboBox editNameBox;
        private Label label6;
        private Label label7;
        private TextBox editPriceBox;
        private Button editButton;
        private Button removeButton;
        private ListView orderList;
        private Button addToOrderButton;
        private Button statsButton;
        private Button finishOrderButton;
        private Button deleteEntryButton;
        private Label statusLabel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label priceLabel;
    }
}