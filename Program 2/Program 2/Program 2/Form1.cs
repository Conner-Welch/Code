// Grade ID: R7639
// Program #: 2
// Due Date: 10/15/2020
// This Program Calculates the total cost of three different companies
// After calculating each companies total it gives you the lowest cost company

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            int weight, distance, days; // variables of weight, distance, days
            string lowestcost; // allows input of string 

            const int MIN_WEIGHT = 0; // Minimum Weight
            const int MIN_DISTANCE = 0; // Minimum Distance
            const int MIN_DAYS = 0; // Minimum Days

            const double aWeight = 1; // These are the const variables used to compare the cost of Company A, including the multiple Days
            const double aDistance = .02;
            const double aDAY_ONE = 20;
            const double aDAY_TWO = 17;
            const double aDay_THREE = 15;
            const double aDAY_FOUR_SEVEN = 10;
            const double aDAY_EIGHTPLUS = 7;

            const double bWEIGHT_UNDER_TEN = 3; // These are used for Company B to give the accurate price
            const double bWEIGHT_TEN_FIFTY = 5;
            const double bWEIGHT_FIFTY_HUNDRED = 10;
            const double bWEIGHT_HUNDRED_TWOHUNDRED = 20;
            const double bWEIGHT_MORE = .15;
            const double bDISTANCE = .10;
            const double bDAYS_ONE_FOUR = 10;
            const double bDAYS_MORE = 7;

            const double cWEIGHT = .25; // These are used for Company C to get the accurate prices without magic numbers
            const double cDISTANCE_MORE = 40;
            const double cDISTANCE_750_1000 = 35;
            const double CDISTANCE_500_750 = 25;
            const double cDISTANCE_200_500 = 15;
            const double cDISTANCE_LESS = 10;
            const double cDAYS = 20;


            double priceA = 0; // Allows comparison for the result label
            double priceB = 0; 
            double priceC = 0;

            // below starts company A
            if (int.TryParse(WeightTxt.Text, out weight) && (weight > MIN_WEIGHT)) // Allows input of weight 
            {
                if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                {
                    if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                    {
                        if (days == 1) // The following statements allow accurate pricing considering days to be shipped
                        {
                            priceA = (weight * aWeight) + (distance * aDistance) + aDAY_ONE; // gets the price based on the days shipped
                            CompAPrice.Text = $"{priceA:C}"; // inputs price as currency in the Company A Result
                        }
                        else if (days == 2)
                        {
                            priceA = (weight * aWeight) + (distance * aDistance) + aDAY_TWO; // gets the price based on the days shipped
                            CompAPrice.Text = $"{priceA:C}"; // inputs price as currency in the Company A Result
                        }
                        else if (days == 3)
                        {
                            priceA = (weight * aWeight) + (distance * aDistance) + aDay_THREE; // gets the price based on the days shipped
                            CompAPrice.Text = $"{priceA:C}"; // inputs price as currency in the Company A Result
                        }
                        else if (days >= 4 && days <= 7)
                        {
                            priceA = (weight * aWeight) + (distance * aDistance) + aDAY_FOUR_SEVEN; // gets the price based on the days shipped
                            CompAPrice.Text = $"{priceA:C}"; // inputs price as currency in the Company A Result
                        }
                        else
                        {
                            priceA = (weight * aWeight) + (distance * aDistance) + aDAY_EIGHTPLUS; // gets the price based on the days shipped
                            CompAPrice.Text = $"{priceA:C}"; // inputs price as currency in the Company A Result
                        }
                    }
                    else
                        MessageBox.Show("Enter Valid Days"); // invalid days
                }
                else
                    MessageBox.Show("Enter Valid Distance"); // invalid distance
            }
            else
                MessageBox.Show("Enter Valid Weight"); // invalid weight


            // below this starts Company B 
            if (int.TryParse(WeightTxt.Text, out weight) && (weight > MIN_WEIGHT)) // allows input of weight
            {
                if (weight < 10) // if weight is less than 10
                {
                    if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            if (days >= 1 && days <= 4) // if days between 1 and 4
                            {
                                priceB = bWEIGHT_UNDER_TEN + (distance * bDISTANCE) + bDAYS_ONE_FOUR; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                            else // days greater than 4 
                            {
                                priceB = bWEIGHT_UNDER_TEN + (distance * bDISTANCE) + bDAYS_MORE; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else
                        MessageBox.Show("Enter Valid Distance"); // invalid distance
                }
                else if (weight >= 10 && weight < 50) // weight between 10 - 50
                {
                    if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            if (days >= 1 && days <= 4) // if days between 1 and 4
                            {
                                priceB = bWEIGHT_TEN_FIFTY + (distance * bDISTANCE) + bDAYS_ONE_FOUR; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                            else // days greater than 4
                            {
                                priceB = bWEIGHT_TEN_FIFTY + (distance * bDISTANCE) + bDAYS_MORE; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else
                        MessageBox.Show("Enter Valid Distance"); // invalid distance
                }
                else if (weight >= 50 && weight < 100) // weight between 50 - 100
                {
                    if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            if (days >= 1 && days <= 4) // if days between 1 and 4
                            {
                                priceB = bWEIGHT_FIFTY_HUNDRED + (distance * bDISTANCE) + bDAYS_ONE_FOUR; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                            else // days greater than 4
                            {
                                priceB = bWEIGHT_FIFTY_HUNDRED + (distance * bDISTANCE) + bDAYS_MORE; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else
                        MessageBox.Show("Enter Valid Distance"); // invalid distance
                }
                else if (weight >= 100 && weight < 200) // weight between 100 - 200
                {
                    if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            if (days >= 1 && days <= 4) // if days between 1 and 4
                            {
                                priceB = bWEIGHT_HUNDRED_TWOHUNDRED + (distance * bDISTANCE) + bDAYS_ONE_FOUR; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                            else // days greater than 4
                            {
                                priceB = bWEIGHT_HUNDRED_TWOHUNDRED + (distance * bDISTANCE) + bDAYS_MORE; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else
                        MessageBox.Show("Enter Valid Distance"); // invalid distance
                }
                else // weight greater than 200
                {
                    if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            if (days >= 1 && days <= 4) // if days between 1 and 4
                            {
                                priceB = (weight * bWEIGHT_MORE) + (distance * bDISTANCE) + bDAYS_ONE_FOUR; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                            else // days greater than 4
                            {
                                priceB = (weight * bWEIGHT_MORE) + (distance * bDISTANCE) + bDAYS_MORE; // caluclates total
                                CompBPrice.Text = $"{priceB:C}"; // places total in Company B result
                            }
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else
                        MessageBox.Show("Enter Valid Distance"); // invalid distance
                }
            }
            else
                MessageBox.Show("Enter Valid Weight"); // invalid weight


            // below starts company C
            if (int.TryParse(WeightTxt.Text, out weight) && (weight > MIN_WEIGHT)) // allows input of weight
            {
                if (int.TryParse(DistanceTxt.Text, out distance) && (distance > MIN_DISTANCE)) // allows input of distance
                {
                    if (distance < 200) // distance less than 200
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            priceC = (weight * cWEIGHT) + cDISTANCE_LESS + cDAYS; // caluclates total
                            CompCPrice.Text = $"{priceC:C}"; // places total in Company C result
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else if (distance >= 200 && distance < 500) // distance between 200 - 500
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            priceC = (weight * cWEIGHT) + cDISTANCE_200_500 + cDAYS; // caluclates total
                            CompCPrice.Text = $"{priceC:C}"; // places total in Company C result
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else if (distance >= 500 && distance < 750) // distance between 500 - 750
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            priceC = (weight * cWEIGHT) + CDISTANCE_500_750 + cDAYS; // caluclates total
                            CompCPrice.Text = $"{priceC:C}"; // places total in Company C result
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else if (distance >= 750 && distance < 1000) // distance between 750 - 1000
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            priceC = (weight * cWEIGHT) + cDISTANCE_750_1000 + cDAYS; // caluclates total
                            CompCPrice.Text = $"{priceC:C}"; // places total in Company C result
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                    else // distance greater than 1000
                    {
                        if (int.TryParse(DaysTxt.Text, out days) && (days > MIN_DAYS)) // allows input of days
                        {
                            priceC = (weight * cWEIGHT) + cDISTANCE_MORE + cDAYS; // caluclates total
                            CompCPrice.Text = $"{priceC:C}"; // places total in Company C result
                        }
                        else
                            MessageBox.Show("Enter Valid Days"); // invalid days
                    }
                }
                else
                    MessageBox.Show("Enter Valid Distance"); // invalid distance
            }
            else
                MessageBox.Show("Enter Valid Weight"); // invalid weight

           
          if (priceA < priceB && priceA < priceC) // sees if priceA is the lowest 
            {
                lowestcost = "A"; // makes the lowest cost Company A
                ResultLbl.Text = $"The Lowest Cost Company is {lowestcost}"; // places result in the result label
            }
          else if (priceB < priceA && priceB < priceC) // sees if priceB is the lowest
            {
                lowestcost = "B"; // makes the lowest cost company B
                ResultLbl.Text = $"The Lowest Cost Company is {lowestcost}"; // places result in the result label
            }
          else if ( priceC < priceA && priceC < priceB) // sees if priceC is the lowest
            {
                lowestcost = "C"; // makes the lowest cost company C
                ResultLbl.Text = $"The Lowest Cost Company is {lowestcost}"; // places result in the result label
            }
          else // if there is no clear lowest price
            {
                lowestcost = "Tie"; // makes the lowest cost a tie
                ResultLbl.Text = $"The Lowest Cost Company is a {lowestcost}"; // places result in the result label
            }



            
                
        }
    }
}
