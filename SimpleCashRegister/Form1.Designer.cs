
namespace SimpleCashRegister {
    partial class Form1 {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addToInvoiceButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dessertRadio = new System.Windows.Forms.RadioButton();
            this.softDrinkRadio = new System.Windows.Forms.RadioButton();
            this.friesRadio = new System.Windows.Forms.RadioButton();
            this.burgerButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eatInRadio = new System.Windows.Forms.RadioButton();
            this.zone3Radio = new System.Windows.Forms.RadioButton();
            this.zone2Radio = new System.Windows.Forms.RadioButton();
            this.zone1Radio = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeItemButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.deliveryText = new System.Windows.Forms.TextBox();
            this.salesTaxText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addToInvoiceButton);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.dessertRadio);
            this.groupBox1.Controls.Add(this.softDrinkRadio);
            this.groupBox1.Controls.Add(this.friesRadio);
            this.groupBox1.Controls.Add(this.burgerButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addToInvoiceButton
            // 
            this.addToInvoiceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addToInvoiceButton.Location = new System.Drawing.Point(16, 200);
            this.addToInvoiceButton.Name = "addToInvoiceButton";
            this.addToInvoiceButton.Size = new System.Drawing.Size(124, 28);
            this.addToInvoiceButton.TabIndex = 6;
            this.addToInvoiceButton.Text = "Add to Invoice";
            this.addToInvoiceButton.UseVisualStyleBackColor = false;
            this.addToInvoiceButton.Click += new System.EventHandler(this.addToInvoiceButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 165);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(26, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Qty:";
            this.quantityLabel.Click += new System.EventHandler(this.quantityLabel_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(45, 163);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown.TabIndex = 4;
            // 
            // dessertRadio
            // 
            this.dessertRadio.AutoSize = true;
            this.dessertRadio.Location = new System.Drawing.Point(16, 127);
            this.dessertRadio.Name = "dessertRadio";
            this.dessertRadio.Size = new System.Drawing.Size(61, 17);
            this.dessertRadio.TabIndex = 3;
            this.dessertRadio.Text = "Dessert";
            this.dessertRadio.UseVisualStyleBackColor = true;
            // 
            // softDrinkRadio
            // 
            this.softDrinkRadio.AutoSize = true;
            this.softDrinkRadio.Location = new System.Drawing.Point(16, 95);
            this.softDrinkRadio.Name = "softDrinkRadio";
            this.softDrinkRadio.Size = new System.Drawing.Size(72, 17);
            this.softDrinkRadio.TabIndex = 2;
            this.softDrinkRadio.Text = "Soft Drink";
            this.softDrinkRadio.UseVisualStyleBackColor = true;
            // 
            // friesRadio
            // 
            this.friesRadio.AutoSize = true;
            this.friesRadio.Location = new System.Drawing.Point(16, 62);
            this.friesRadio.Name = "friesRadio";
            this.friesRadio.Size = new System.Drawing.Size(47, 17);
            this.friesRadio.TabIndex = 1;
            this.friesRadio.Text = "Fries";
            this.friesRadio.UseVisualStyleBackColor = true;
            this.friesRadio.CheckedChanged += new System.EventHandler(this.friesRadio_CheckedChanged);
            // 
            // burgerButton
            // 
            this.burgerButton.AutoSize = true;
            this.burgerButton.Checked = true;
            this.burgerButton.Location = new System.Drawing.Point(16, 30);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(56, 17);
            this.burgerButton.TabIndex = 0;
            this.burgerButton.TabStop = true;
            this.burgerButton.Text = "Burger";
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.CheckedChanged += new System.EventHandler(this.burgerButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eatInRadio);
            this.groupBox2.Controls.Add(this.zone3Radio);
            this.groupBox2.Controls.Add(this.zone2Radio);
            this.groupBox2.Controls.Add(this.zone1Radio);
            this.groupBox2.Location = new System.Drawing.Point(26, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Options";
            // 
            // eatInRadio
            // 
            this.eatInRadio.AutoSize = true;
            this.eatInRadio.Checked = true;
            this.eatInRadio.Location = new System.Drawing.Point(16, 135);
            this.eatInRadio.Name = "eatInRadio";
            this.eatInRadio.Size = new System.Drawing.Size(97, 17);
            this.eatInRadio.TabIndex = 3;
            this.eatInRadio.TabStop = true;
            this.eatInRadio.Text = "Eat In / Pickup";
            this.eatInRadio.UseVisualStyleBackColor = true;
            this.eatInRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // zone3Radio
            // 
            this.zone3Radio.AutoSize = true;
            this.zone3Radio.Location = new System.Drawing.Point(16, 98);
            this.zone3Radio.Name = "zone3Radio";
            this.zone3Radio.Size = new System.Drawing.Size(59, 17);
            this.zone3Radio.TabIndex = 2;
            this.zone3Radio.Text = "Zone 3";
            this.zone3Radio.UseVisualStyleBackColor = true;
            this.zone3Radio.CheckedChanged += new System.EventHandler(this.zone3Radio_CheckedChanged);
            // 
            // zone2Radio
            // 
            this.zone2Radio.AutoSize = true;
            this.zone2Radio.Location = new System.Drawing.Point(16, 64);
            this.zone2Radio.Name = "zone2Radio";
            this.zone2Radio.Size = new System.Drawing.Size(59, 17);
            this.zone2Radio.TabIndex = 1;
            this.zone2Radio.Text = "Zone 2";
            this.zone2Radio.UseVisualStyleBackColor = true;
            this.zone2Radio.CheckedChanged += new System.EventHandler(this.zone2Radio_CheckedChanged);
            // 
            // zone1Radio
            // 
            this.zone1Radio.AutoSize = true;
            this.zone1Radio.Location = new System.Drawing.Point(16, 31);
            this.zone1Radio.Name = "zone1Radio";
            this.zone1Radio.Size = new System.Drawing.Size(59, 17);
            this.zone1Radio.TabIndex = 0;
            this.zone1Radio.Text = "Zone 1";
            this.zone1Radio.UseVisualStyleBackColor = true;
            this.zone1Radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemColumn,
            this.unitsColumn,
            this.rateColumn,
            this.subtotalColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(233, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 248);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Item";
            this.itemColumn.Width = 139;
            // 
            // unitsColumn
            // 
            this.unitsColumn.Text = "Units";
            this.unitsColumn.Width = 70;
            // 
            // rateColumn
            // 
            this.rateColumn.Text = "Rate";
            this.rateColumn.Width = 74;
            // 
            // subtotalColumn
            // 
            this.subtotalColumn.Text = "Subtotal";
            this.subtotalColumn.Width = 104;
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeItemButton.Location = new System.Drawing.Point(233, 275);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(119, 28);
            this.removeItemButton.TabIndex = 3;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(451, 285);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(73, 20);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal:";
            this.subtotalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(451, 322);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(68, 20);
            this.deliveryLabel.TabIndex = 5;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxLabel.Location = new System.Drawing.Point(451, 359);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(82, 20);
            this.salesTaxLabel.TabIndex = 6;
            this.salesTaxLabel.Text = "Sales Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(451, 393);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 20);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "TOTAL:";
            // 
            // subtotalText
            // 
            this.subtotalText.Enabled = false;
            this.subtotalText.Location = new System.Drawing.Point(544, 285);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(82, 20);
            this.subtotalText.TabIndex = 8;
            // 
            // deliveryText
            // 
            this.deliveryText.Enabled = false;
            this.deliveryText.Location = new System.Drawing.Point(544, 322);
            this.deliveryText.Name = "deliveryText";
            this.deliveryText.Size = new System.Drawing.Size(82, 20);
            this.deliveryText.TabIndex = 9;
            // 
            // salesTaxText
            // 
            this.salesTaxText.Enabled = false;
            this.salesTaxText.Location = new System.Drawing.Point(544, 359);
            this.salesTaxText.Name = "salesTaxText";
            this.salesTaxText.Size = new System.Drawing.Size(82, 20);
            this.salesTaxText.TabIndex = 10;
            // 
            // totalText
            // 
            this.totalText.Enabled = false;
            this.totalText.Location = new System.Drawing.Point(544, 393);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(82, 20);
            this.totalText.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(195, 465);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 37);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(346, 465);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 37);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 514);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.salesTaxText);
            this.Controls.Add(this.deliveryText);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simple Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader unitsColumn;
        private System.Windows.Forms.ColumnHeader rateColumn;
        private System.Windows.Forms.ColumnHeader subtotalColumn;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addToInvoiceButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button removeItemButton;
        public System.Windows.Forms.RadioButton dessertRadio;
        public System.Windows.Forms.RadioButton softDrinkRadio;
        public System.Windows.Forms.RadioButton friesRadio;
        public System.Windows.Forms.RadioButton burgerButton;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        public System.Windows.Forms.RadioButton zone1Radio;
        public System.Windows.Forms.RadioButton eatInRadio;
        public System.Windows.Forms.RadioButton zone3Radio;
        public System.Windows.Forms.RadioButton zone2Radio;
        public System.Windows.Forms.TextBox subtotalText;
        public System.Windows.Forms.TextBox deliveryText;
        public System.Windows.Forms.TextBox salesTaxText;
        public System.Windows.Forms.TextBox totalText;
    }
}

