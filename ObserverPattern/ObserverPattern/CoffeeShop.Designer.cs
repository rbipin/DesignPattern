namespace ObserverPattern
{
    partial class CoffeeShop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCoffee = new System.Windows.Forms.Button();
            this.lstCoffee = new System.Windows.Forms.ListBox();
            this.lstSize = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCondiments = new System.Windows.Forms.ListBox();
            this.cmdCondiments = new System.Windows.Forms.Button();
            this.lstvwOrderItems = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdCoffee);
            this.groupBox1.Controls.Add(this.lstCoffee);
            this.groupBox1.Controls.Add(this.lstSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coffee";
            // 
            // cmdCoffee
            // 
            this.cmdCoffee.Location = new System.Drawing.Point(31, 257);
            this.cmdCoffee.Name = "cmdCoffee";
            this.cmdCoffee.Size = new System.Drawing.Size(195, 43);
            this.cmdCoffee.TabIndex = 2;
            this.cmdCoffee.Text = "Add Coffee";
            this.cmdCoffee.UseVisualStyleBackColor = true;
            this.cmdCoffee.Click += new System.EventHandler(this.cmdCoffee_Click);
            // 
            // lstCoffee
            // 
            this.lstCoffee.FormattingEnabled = true;
            this.lstCoffee.ItemHeight = 20;
            this.lstCoffee.Items.AddRange(new object[] {
            "Dark Roast",
            "Arabica",
            "Columbian Light Roast",
            "Decaf"});
            this.lstCoffee.Location = new System.Drawing.Point(6, 59);
            this.lstCoffee.Name = "lstCoffee";
            this.lstCoffee.Size = new System.Drawing.Size(271, 84);
            this.lstCoffee.TabIndex = 1;
            // 
            // lstSize
            // 
            this.lstSize.FormattingEnabled = true;
            this.lstSize.ItemHeight = 20;
            this.lstSize.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.lstSize.Location = new System.Drawing.Point(6, 178);
            this.lstSize.Name = "lstSize";
            this.lstSize.Size = new System.Drawing.Size(271, 64);
            this.lstSize.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Name";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(113, 43);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(193, 26);
            this.txtOrderName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdCondiments);
            this.groupBox2.Controls.Add(this.lstCondiments);
            this.groupBox2.Location = new System.Drawing.Point(322, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condiments";
            // 
            // lstCondiments
            // 
            this.lstCondiments.FormattingEnabled = true;
            this.lstCondiments.ItemHeight = 20;
            this.lstCondiments.Items.AddRange(new object[] {
            "Vanilla",
            "Mocha",
            "Hazel Nut",
            "Cinnamon",
            "Whip",
            "Milk"});
            this.lstCondiments.Location = new System.Drawing.Point(7, 59);
            this.lstCondiments.Name = "lstCondiments";
            this.lstCondiments.Size = new System.Drawing.Size(225, 84);
            this.lstCondiments.TabIndex = 0;
            // 
            // cmdCondiments
            // 
            this.cmdCondiments.Location = new System.Drawing.Point(34, 153);
            this.cmdCondiments.Name = "cmdCondiments";
            this.cmdCondiments.Size = new System.Drawing.Size(149, 40);
            this.cmdCondiments.TabIndex = 1;
            this.cmdCondiments.Text = "Add Condiments";
            this.cmdCondiments.UseVisualStyleBackColor = true;
            this.cmdCondiments.Click += new System.EventHandler(this.cmdCondiments_Click);
            // 
            // lstvwOrderItems
            // 
            this.lstvwOrderItems.Location = new System.Drawing.Point(582, 129);
            this.lstvwOrderItems.Name = "lstvwOrderItems";
            this.lstvwOrderItems.Size = new System.Drawing.Size(165, 188);
            this.lstvwOrderItems.TabIndex = 4;
            this.lstvwOrderItems.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPrice.Location = new System.Drawing.Point(643, 329);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(57, 20);
            this.lblOrderPrice.TabIndex = 6;
            this.lblOrderPrice.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Order";
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Location = new System.Drawing.Point(642, 103);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(0, 20);
            this.lblOrderName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 518);
            this.Controls.Add(this.lblOrderName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstvwOrderItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCoffee;
        private System.Windows.Forms.ListBox lstCoffee;
        private System.Windows.Forms.ListBox lstSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdCondiments;
        private System.Windows.Forms.ListBox lstCondiments;
        private System.Windows.Forms.ListView lstvwOrderItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrderName;
    }
}

