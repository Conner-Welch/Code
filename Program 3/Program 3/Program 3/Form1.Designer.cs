namespace Program_3
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
            this.stateLbl = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.productLbl = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.initialLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.initialCost = new System.Windows.Forms.Label();
            this.discountCost = new System.Windows.Forms.Label();
            this.taxCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(21, 38);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 0;
            this.stateLbl.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateBox.Location = new System.Drawing.Point(117, 37);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(95, 21);
            this.stateBox.TabIndex = 1;
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(22, 89);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(87, 13);
            this.productLbl.TabIndex = 2;
            this.productLbl.Text = "Product Number:";
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(121, 87);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(95, 20);
            this.productTxt.TabIndex = 3;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(26, 139);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(46, 13);
            this.amountLbl.TabIndex = 4;
            this.amountLbl.Text = "Amount:";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(113, 138);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(98, 20);
            this.amountTxt.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(114, 181);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(101, 21);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate!";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // initialLbl
            // 
            this.initialLbl.AutoSize = true;
            this.initialLbl.Location = new System.Drawing.Point(29, 242);
            this.initialLbl.Name = "initialLbl";
            this.initialLbl.Size = new System.Drawing.Size(58, 13);
            this.initialLbl.TabIndex = 7;
            this.initialLbl.Text = "Initial Cost:";
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Location = new System.Drawing.Point(28, 272);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(88, 13);
            this.discountLbl.TabIndex = 8;
            this.discountLbl.Text = "Discounted Cost:";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(30, 302);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(28, 13);
            this.taxLbl.TabIndex = 9;
            this.taxLbl.Text = "Tax:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(29, 334);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(61, 13);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "Total Price:";
            // 
            // initialCost
            // 
            this.initialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCost.Location = new System.Drawing.Point(120, 241);
            this.initialCost.Name = "initialCost";
            this.initialCost.Size = new System.Drawing.Size(88, 17);
            this.initialCost.TabIndex = 11;
            // 
            // discountCost
            // 
            this.discountCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountCost.Location = new System.Drawing.Point(120, 276);
            this.discountCost.Name = "discountCost";
            this.discountCost.Size = new System.Drawing.Size(88, 17);
            this.discountCost.TabIndex = 12;
            // 
            // taxCost
            // 
            this.taxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxCost.Location = new System.Drawing.Point(121, 302);
            this.taxCost.Name = "taxCost";
            this.taxCost.Size = new System.Drawing.Size(88, 17);
            this.taxCost.TabIndex = 13;
            // 
            // totalCost
            // 
            this.totalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCost.Location = new System.Drawing.Point(120, 334);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(88, 17);
            this.totalCost.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.taxCost);
            this.Controls.Add(this.discountCost);
            this.Controls.Add(this.initialCost);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.initialLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.productTxt);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.stateLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label initialLbl;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label initialCost;
        private System.Windows.Forms.Label discountCost;
        private System.Windows.Forms.Label taxCost;
        private System.Windows.Forms.Label totalCost;
    }
}

