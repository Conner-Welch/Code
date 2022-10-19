//Grade ID: R7639
//Program #3
//Due Date: 11/5/2020
//This program calculates the total cost as well as  the discounted, pre tax, and tax cost
//This program makes use of arrays and loops to calculate

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        string[] states = { "KY", "OH", "IN", "IL" }; //Array for States
        double[] taxes = { .06, .0717, .07, .0874 }; // Array for taxes in states
        int[] productNumber = { 1001, 1002, 1003, 1004, 1005, 1006, 1007 }; // Array on Product numbers
        double[] productPrices = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; //Array on Product Prices
        int[] itemAmount = { 0, 5, 10, 20 }; //Array for amounts that works with discounts
        double[] itemDiscount = { 0.00, 0.05, 0.10, 0.15 }; //Array that gives discount


        const int MINQTY = 0; // These three are set constants for input
        const int MINPRODUCTNUM = 1001;
        const int MAXPRODUCTNUM = 1007;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            bool validProduct = false; //Booleans to help with solving the array and loops
            bool stateFound = false;
            bool validAmount = false;

            double preTax, discounted, totalTaxCost, total = 0; // Variables to caluclate each total

            double discount = 0; // sets discount percentage 
            double tax = 0; // sets tax percentage
            double itemPrice = 0; // sets item price
            int product, amount; // allows input of product number and amount




            if (stateBox.SelectedIndex >= 0) // If the state is one of the selcted in the box
            {
                if (int.TryParse(productTxt.Text, out product) && (product >= MINPRODUCTNUM && product <= MAXPRODUCTNUM)) //Allows input of product between 1001 - 1007
                {
                    if (int.TryParse(amountTxt.Text, out amount) && (amount >= MINQTY)) // allows input of a given amount greater than 0
                    {
                        for (int i = 0; i < productNumber.Length && !validProduct; i++) //For loop to determine a valid product
                        {
                            if (product == productNumber[i]) 
                            {
                                validProduct = true; // product number entered is in the array it becomes true
                                itemPrice = productPrices[i]; // sets price to the given prduct number
                            }
                        }

                        for (int b = 0; b < states.Length && !stateFound; b++) //For loop to determine tax
                        {
                            if (stateBox.Text == states[b])
                            {
                                stateFound = true; //State entered is in the selection
                                tax = taxes[b]; // sets tax to given state
                            }
                        }

                        for (int c = 0; c < itemAmount.Length && !validAmount; c++) // for loop to determine discount
                        {
                            if (amount == itemAmount[c])
                            {
                                validAmount = true; // valid amount given
                                discount = itemDiscount[c]; // discount set to the given amount
                            }
                        }

                        {
                            preTax = itemPrice * amount; // calculates pretax cost
                            initialCost.Text = $"{preTax:C}"; // string interpolation to set price in label



                            discounted = (itemPrice * amount * discount) + (itemPrice * amount); // calculates discount cost
                            discountCost.Text = $"{discounted:C}"; // string interpolation to set price in label



                            totalTaxCost = (itemPrice * amount * tax); // calculates tax
                            taxCost.Text = $"{totalTaxCost:C}"; // string interpolation to set price in label



                            total = discounted + totalTaxCost; //calculates total given discount and tax
                            totalCost.Text = $"{total:C}"; // string interpolation to set price in label
                        }
                    }
                    else
                        MessageBox.Show("Enter Valid Amount");
                }
                else
                    MessageBox.Show("Enter Valid Product Number");
            }
          


        }
    }
}
