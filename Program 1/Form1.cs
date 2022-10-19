// Grade ID: R7639
// Program 1
// Due Date : 9/22/2020
// Course: CIS 199-01
// This program calculates the total estimate cost of placing floors and underlayment
// As well as whether this is the first room or not
// Also calculating the total labor cost



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            const double LABOR_PER_YARD = 3.25; // Labor cost
            const double UNDERLAYMENT_PER_YARD = 4.25; // Underlay Cost
            const double FIRST_ROOM = 50.00; // First Room price
            const double SQFT_SQYD = 9.0; // Used to calculate SQ Yards
            const double EXCESS = .10; // The excess for hardwood
            // A set of named constants used for calculations

            double width, length, hardwoodprice, SQYards, hardwoodcost, underlaycost, laborcost, totalcost; // All of these have decimals 
            int underlayment, firstroom; // single digit in yes or no(1 or 0)

            width = double.Parse(MaxWidthTxtBox.Text); // Allows input of width

            length = double.Parse(MaxLengthTxtBox.Text); // Allows input of Length

            hardwoodprice = double.Parse(HardwoodPriceTxtBox.Text); // Allows input of the hardwood price

            underlayment = int.Parse(UnderlaymentTxtBox.Text); // Allows input of whether undelay is needed or not

            firstroom = int.Parse(FirstRoomTxtBox.Text); // Allows input on whether this is the first room

            SQYards = (width * length) / SQFT_SQYD;
            TotalSqYards.Text = $"{SQYards:F1}";
            // Calculates Sq Yards and sets it to currency

            hardwoodcost = ((SQYards * hardwoodprice) * EXCESS) + (SQYards * hardwoodprice);
            TotalHardwoodCost.Text = $"{hardwoodcost:C}";
            // Calculates cost of Hardwood including the excess amount and sets it to currency

            if (underlayment == 1)
                underlaycost = SQYards * UNDERLAYMENT_PER_YARD;
            else
                underlaycost = SQYards * 0;
            TotalUnderlayCost.Text = $"{underlaycost:C}";
            // Using if-else statement to define underlayment cost
            // Had trouble using a regular if statement thats why if-else was used here
            // using if statement gave me CS0165 error
             
            

            if (firstroom == 1)
                laborcost = (SQYards * LABOR_PER_YARD) + FIRST_ROOM;
            else
                laborcost = SQYards * LABOR_PER_YARD;
            TotalLaborCost.Text = $"{laborcost:C}";
            // using if else statement to calculate labor cost 
            // differentiates between having the first room or not

            totalcost = hardwoodcost + underlaycost + laborcost;
            GrandTotalCost.Text = $"{totalcost:C}";
            // calculates total cost in a currency format

 
        }
    }
}
