namespace SalesSystemV3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.nextIDButton = new System.Windows.Forms.Button();
            this.nextIDText = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.itemNametextBox = new System.Windows.Forms.TextBox();
            this.itemDestextBox = new System.Windows.Forms.TextBox();
            this.itemCattextBox = new System.Windows.Forms.TextBox();
            this.itemCosttextBox = new System.Windows.Forms.TextBox();
            this.itemSaletextBox = new System.Windows.Forms.TextBox();
            this.itemNamelabel = new System.Windows.Forms.Label();
            this.itemDeslabel = new System.Windows.Forms.Label();
            this.itemCatlabel = new System.Windows.Forms.Label();
            this.itemCostlabel = new System.Windows.Forms.Label();
            this.itemSalelabel = new System.Windows.Forms.Label();
            this.ItemNameListrichTextBox = new System.Windows.Forms.RichTextBox();
            this.ItemListbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSalebutton = new System.Windows.Forms.Button();
            this.itemNamecomboBox = new System.Windows.Forms.ComboBox();
            this.SalesdataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ItemPricetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CatagorytextBox2 = new System.Windows.Forms.TextBox();
            this.DescriptextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nextIDButton
            // 
            this.nextIDButton.Location = new System.Drawing.Point(791, 29);
            this.nextIDButton.Name = "nextIDButton";
            this.nextIDButton.Size = new System.Drawing.Size(75, 23);
            this.nextIDButton.TabIndex = 0;
            this.nextIDButton.Text = "Next ID";
            this.nextIDButton.UseVisualStyleBackColor = true;
            this.nextIDButton.Click += new System.EventHandler(this.nextIDButton_Click);
            // 
            // nextIDText
            // 
            this.nextIDText.Location = new System.Drawing.Point(873, 31);
            this.nextIDText.Name = "nextIDText";
            this.nextIDText.Size = new System.Drawing.Size(100, 20);
            this.nextIDText.TabIndex = 1;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(257, 119);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemNametextBox
            // 
            this.itemNametextBox.Location = new System.Drawing.Point(132, 11);
            this.itemNametextBox.Name = "itemNametextBox";
            this.itemNametextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNametextBox.TabIndex = 3;
            // 
            // itemDestextBox
            // 
            this.itemDestextBox.Location = new System.Drawing.Point(132, 38);
            this.itemDestextBox.Name = "itemDestextBox";
            this.itemDestextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDestextBox.TabIndex = 4;
            // 
            // itemCattextBox
            // 
            this.itemCattextBox.Location = new System.Drawing.Point(132, 65);
            this.itemCattextBox.Name = "itemCattextBox";
            this.itemCattextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCattextBox.TabIndex = 5;
            // 
            // itemCosttextBox
            // 
            this.itemCosttextBox.Location = new System.Drawing.Point(132, 92);
            this.itemCosttextBox.Name = "itemCosttextBox";
            this.itemCosttextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCosttextBox.TabIndex = 6;
            // 
            // itemSaletextBox
            // 
            this.itemSaletextBox.Location = new System.Drawing.Point(132, 119);
            this.itemSaletextBox.Name = "itemSaletextBox";
            this.itemSaletextBox.Size = new System.Drawing.Size(100, 20);
            this.itemSaletextBox.TabIndex = 7;
            // 
            // itemNamelabel
            // 
            this.itemNamelabel.AutoSize = true;
            this.itemNamelabel.Location = new System.Drawing.Point(16, 11);
            this.itemNamelabel.Name = "itemNamelabel";
            this.itemNamelabel.Size = new System.Drawing.Size(58, 13);
            this.itemNamelabel.TabIndex = 10;
            this.itemNamelabel.Text = "Item Name";
            // 
            // itemDeslabel
            // 
            this.itemDeslabel.AutoSize = true;
            this.itemDeslabel.Location = new System.Drawing.Point(16, 38);
            this.itemDeslabel.Name = "itemDeslabel";
            this.itemDeslabel.Size = new System.Drawing.Size(60, 13);
            this.itemDeslabel.TabIndex = 11;
            this.itemDeslabel.Text = "Description";
            // 
            // itemCatlabel
            // 
            this.itemCatlabel.AutoSize = true;
            this.itemCatlabel.Location = new System.Drawing.Point(17, 65);
            this.itemCatlabel.Name = "itemCatlabel";
            this.itemCatlabel.Size = new System.Drawing.Size(49, 13);
            this.itemCatlabel.TabIndex = 12;
            this.itemCatlabel.Text = "Catagory";
            // 
            // itemCostlabel
            // 
            this.itemCostlabel.AutoSize = true;
            this.itemCostlabel.Location = new System.Drawing.Point(17, 92);
            this.itemCostlabel.Name = "itemCostlabel";
            this.itemCostlabel.Size = new System.Drawing.Size(55, 13);
            this.itemCostlabel.TabIndex = 13;
            this.itemCostlabel.Text = "Cost Price";
            // 
            // itemSalelabel
            // 
            this.itemSalelabel.AutoSize = true;
            this.itemSalelabel.Location = new System.Drawing.Point(17, 119);
            this.itemSalelabel.Name = "itemSalelabel";
            this.itemSalelabel.Size = new System.Drawing.Size(55, 13);
            this.itemSalelabel.TabIndex = 14;
            this.itemSalelabel.Text = "Sale Price";
            // 
            // ItemNameListrichTextBox
            // 
            this.ItemNameListrichTextBox.Location = new System.Drawing.Point(12, 16);
            this.ItemNameListrichTextBox.Name = "ItemNameListrichTextBox";
            this.ItemNameListrichTextBox.Size = new System.Drawing.Size(104, 233);
            this.ItemNameListrichTextBox.TabIndex = 15;
            this.ItemNameListrichTextBox.Text = "";
            // 
            // ItemListbutton
            // 
            this.ItemListbutton.Location = new System.Drawing.Point(122, 16);
            this.ItemListbutton.Name = "ItemListbutton";
            this.ItemListbutton.Size = new System.Drawing.Size(106, 23);
            this.ItemListbutton.TabIndex = 17;
            this.ItemListbutton.Text = "Show Item list";
            this.ItemListbutton.UseVisualStyleBackColor = true;
            this.ItemListbutton.Click += new System.EventHandler(this.ItemListbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.itemNametextBox);
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.itemDestextBox);
            this.panel1.Controls.Add(this.itemCattextBox);
            this.panel1.Controls.Add(this.itemSalelabel);
            this.panel1.Controls.Add(this.itemCosttextBox);
            this.panel1.Controls.Add(this.itemCostlabel);
            this.panel1.Controls.Add(this.itemSaletextBox);
            this.panel1.Controls.Add(this.itemCatlabel);
            this.panel1.Controls.Add(this.itemNamelabel);
            this.panel1.Controls.Add(this.itemDeslabel);
            this.panel1.Location = new System.Drawing.Point(785, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 161);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Show next avalable Item ID number ( just for testing )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add new Items to inventory list ( no error checking yet, will crash if left blank" +
    " )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Show list of stored item names";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ItemListbutton);
            this.panel2.Controls.Add(this.ItemNameListrichTextBox);
            this.panel2.Location = new System.Drawing.Point(785, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 266);
            this.panel2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Add single item sale";
            // 
            // AddSalebutton
            // 
            this.AddSalebutton.Location = new System.Drawing.Point(128, 135);
            this.AddSalebutton.Name = "AddSalebutton";
            this.AddSalebutton.Size = new System.Drawing.Size(75, 23);
            this.AddSalebutton.TabIndex = 24;
            this.AddSalebutton.Text = "Add Sale";
            this.AddSalebutton.UseVisualStyleBackColor = true;
            this.AddSalebutton.Click += new System.EventHandler(this.AddSalebutton_Click);
            // 
            // itemNamecomboBox
            // 
            this.itemNamecomboBox.FormattingEnabled = true;
            this.itemNamecomboBox.Location = new System.Drawing.Point(51, 11);
            this.itemNamecomboBox.Name = "itemNamecomboBox";
            this.itemNamecomboBox.Size = new System.Drawing.Size(152, 21);
            this.itemNamecomboBox.TabIndex = 26;
            this.itemNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.itemNamecomboBox_SelectedIndexChanged);
            // 
            // SalesdataGridView
            // 
            this.SalesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesdataGridView.Location = new System.Drawing.Point(12, 310);
            this.SalesdataGridView.Name = "SalesdataGridView";
            this.SalesdataGridView.Size = new System.Drawing.Size(600, 293);
            this.SalesdataGridView.TabIndex = 27;
            // 
            // ItemPricetextBox
            // 
            this.ItemPricetextBox.Location = new System.Drawing.Point(51, 38);
            this.ItemPricetextBox.Name = "ItemPricetextBox";
            this.ItemPricetextBox.Size = new System.Drawing.Size(71, 20);
            this.ItemPricetextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sales Data ( doesnt show items within sale, can\'t edit )";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CatagorytextBox2);
            this.panel3.Controls.Add(this.DescriptextBox1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.AddSalebutton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.itemNamecomboBox);
            this.panel3.Controls.Add(this.ItemPricetextBox);
            this.panel3.Location = new System.Drawing.Point(12, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 211);
            this.panel3.TabIndex = 31;
            // 
            // CatagorytextBox2
            // 
            this.CatagorytextBox2.Location = new System.Drawing.Point(51, 92);
            this.CatagorytextBox2.Name = "CatagorytextBox2";
            this.CatagorytextBox2.Size = new System.Drawing.Size(152, 20);
            this.CatagorytextBox2.TabIndex = 36;
            // 
            // DescriptextBox1
            // 
            this.DescriptextBox1.Location = new System.Drawing.Point(51, 65);
            this.DescriptextBox1.Name = "DescriptextBox1";
            this.DescriptextBox1.Size = new System.Drawing.Size(151, 20);
            this.DescriptextBox1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "( just displays, doesnt update )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Item";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(SalesSystemV3.Inventory);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalesdataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextIDText);
            this.Controls.Add(this.nextIDButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextIDButton;
        private System.Windows.Forms.TextBox nextIDText;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox itemNametextBox;
        private System.Windows.Forms.TextBox itemDestextBox;
        private System.Windows.Forms.TextBox itemCattextBox;
        private System.Windows.Forms.TextBox itemCosttextBox;
        private System.Windows.Forms.TextBox itemSaletextBox;
        private System.Windows.Forms.Label itemNamelabel;
        private System.Windows.Forms.Label itemDeslabel;
        private System.Windows.Forms.Label itemCatlabel;
        private System.Windows.Forms.Label itemCostlabel;
        private System.Windows.Forms.Label itemSalelabel;
        private System.Windows.Forms.RichTextBox ItemNameListrichTextBox;
        private System.Windows.Forms.Button ItemListbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddSalebutton;
        private System.Windows.Forms.ComboBox itemNamecomboBox;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.DataGridView SalesdataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox ItemPricetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CatagorytextBox2;
        private System.Windows.Forms.TextBox DescriptextBox1;
        private System.Windows.Forms.Label label8;
    }
}

