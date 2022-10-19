namespace Program_2
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
            this.WeightLbl = new System.Windows.Forms.Label();
            this.DistanceLbl = new System.Windows.Forms.Label();
            this.DaysLbl = new System.Windows.Forms.Label();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.DistanceTxt = new System.Windows.Forms.TextBox();
            this.DaysTxt = new System.Windows.Forms.TextBox();
            this.CompALbl = new System.Windows.Forms.Label();
            this.CompBLbl = new System.Windows.Forms.Label();
            this.CompCLbl = new System.Windows.Forms.Label();
            this.CompAPrice = new System.Windows.Forms.Label();
            this.CompBPrice = new System.Windows.Forms.Label();
            this.CompCPrice = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(31, 35);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(87, 13);
            this.WeightLbl.TabIndex = 0;
            this.WeightLbl.Text = "Package Weight";
            // 
            // DistanceLbl
            // 
            this.DistanceLbl.AutoSize = true;
            this.DistanceLbl.Location = new System.Drawing.Point(30, 69);
            this.DistanceLbl.Name = "DistanceLbl";
            this.DistanceLbl.Size = new System.Drawing.Size(82, 13);
            this.DistanceLbl.TabIndex = 1;
            this.DistanceLbl.Text = "Distance (Miles)";
            // 
            // DaysLbl
            // 
            this.DaysLbl.AutoSize = true;
            this.DaysLbl.Location = new System.Drawing.Point(30, 107);
            this.DaysLbl.Name = "DaysLbl";
            this.DaysLbl.Size = new System.Drawing.Size(72, 13);
            this.DaysLbl.TabIndex = 2;
            this.DaysLbl.Text = "Delivery Days";
            // 
            // WeightTxt
            // 
            this.WeightTxt.Location = new System.Drawing.Point(151, 28);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(108, 20);
            this.WeightTxt.TabIndex = 3;
            // 
            // DistanceTxt
            // 
            this.DistanceTxt.Location = new System.Drawing.Point(151, 62);
            this.DistanceTxt.Name = "DistanceTxt";
            this.DistanceTxt.Size = new System.Drawing.Size(108, 20);
            this.DistanceTxt.TabIndex = 4;
            // 
            // DaysTxt
            // 
            this.DaysTxt.Location = new System.Drawing.Point(151, 100);
            this.DaysTxt.Name = "DaysTxt";
            this.DaysTxt.Size = new System.Drawing.Size(107, 20);
            this.DaysTxt.TabIndex = 5;
            // 
            // CompALbl
            // 
            this.CompALbl.AutoSize = true;
            this.CompALbl.Location = new System.Drawing.Point(303, 30);
            this.CompALbl.Name = "CompALbl";
            this.CompALbl.Size = new System.Drawing.Size(61, 13);
            this.CompALbl.TabIndex = 6;
            this.CompALbl.Text = "Company A";
            // 
            // CompBLbl
            // 
            this.CompBLbl.AutoSize = true;
            this.CompBLbl.Location = new System.Drawing.Point(303, 65);
            this.CompBLbl.Name = "CompBLbl";
            this.CompBLbl.Size = new System.Drawing.Size(61, 13);
            this.CompBLbl.TabIndex = 7;
            this.CompBLbl.Text = "Company B";
            // 
            // CompCLbl
            // 
            this.CompCLbl.AutoSize = true;
            this.CompCLbl.Location = new System.Drawing.Point(303, 103);
            this.CompCLbl.Name = "CompCLbl";
            this.CompCLbl.Size = new System.Drawing.Size(61, 13);
            this.CompCLbl.TabIndex = 8;
            this.CompCLbl.Text = "Company C";
            // 
            // CompAPrice
            // 
            this.CompAPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompAPrice.Location = new System.Drawing.Point(384, 27);
            this.CompAPrice.Name = "CompAPrice";
            this.CompAPrice.Size = new System.Drawing.Size(92, 16);
            this.CompAPrice.TabIndex = 9;
            // 
            // CompBPrice
            // 
            this.CompBPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompBPrice.Location = new System.Drawing.Point(383, 63);
            this.CompBPrice.Name = "CompBPrice";
            this.CompBPrice.Size = new System.Drawing.Size(92, 18);
            this.CompBPrice.TabIndex = 10;
            // 
            // CompCPrice
            // 
            this.CompCPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompCPrice.Location = new System.Drawing.Point(383, 99);
            this.CompCPrice.Name = "CompCPrice";
            this.CompCPrice.Size = new System.Drawing.Size(91, 17);
            this.CompCPrice.TabIndex = 11;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(156, 164);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(271, 34);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLbl.Location = new System.Drawing.Point(162, 138);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(253, 26);
            this.ResultLbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 377);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.CompCPrice);
            this.Controls.Add(this.CompBPrice);
            this.Controls.Add(this.CompAPrice);
            this.Controls.Add(this.CompCLbl);
            this.Controls.Add(this.CompBLbl);
            this.Controls.Add(this.CompALbl);
            this.Controls.Add(this.DaysTxt);
            this.Controls.Add(this.DistanceTxt);
            this.Controls.Add(this.WeightTxt);
            this.Controls.Add(this.DaysLbl);
            this.Controls.Add(this.DistanceLbl);
            this.Controls.Add(this.WeightLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label DistanceLbl;
        private System.Windows.Forms.Label DaysLbl;
        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.TextBox DistanceTxt;
        private System.Windows.Forms.TextBox DaysTxt;
        private System.Windows.Forms.Label CompALbl;
        private System.Windows.Forms.Label CompBLbl;
        private System.Windows.Forms.Label CompCLbl;
        private System.Windows.Forms.Label CompAPrice;
        private System.Windows.Forms.Label CompBPrice;
        private System.Windows.Forms.Label CompCPrice;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label ResultLbl;
    }
}

