﻿/// Ian Dill
/// February 19 2020
/// Cash Register
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Summative
{

    public partial class Form1 : Form
    {
        const double BURGER_PRICE = 1.00;
        const double FRY_PRICE = 0.50;
        const double DRINK_PRICE = 1.25;
        const double TAX = 0.13;
        

        public Form1()
        {
            
            InitializeComponent();
        }
        
        double burgerNumber;
        double fryNumber;
        double drinkNumber;
        double burgersubTotal;
        double frysubTotal;
        double drinksubTotal;
        double subTotal;
        double taxCalculation;
        double tenderedNumber;
        double changeNumber;
        public double totalPrice;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
           
           
            

            try {

                burgerNumber = Convert.ToInt16(burgerBox.Text);
                fryNumber = Convert.ToInt16(fryBox.Text);
                drinkNumber = Convert.ToInt16(drinkBox.Text);
                burgersubTotal = burgerNumber * BURGER_PRICE;
                frysubTotal = fryNumber * FRY_PRICE;
                drinksubTotal = drinkNumber * DRINK_PRICE;
                subTotal = burgersubTotal + frysubTotal + drinksubTotal;
                taxCalculation = TAX * subTotal;
                totalPrice = taxCalculation + subTotal;

                /// makes it so the values reset to the default 0 if no value is present
               
                if (burgerBox.Text == null || burgerBox.Text == "")
                {
                    burgerBox.Text = "0";
                }
                if (fryBox.Text == null || fryBox.Text == "")
                {
                    fryBox.Text = "0";
                }
                if (drinkBox.Text == null || drinkBox.Text == "")
                {
                    drinkBox.Text = "0";
                }
               


                /// makes the subtotal a currency value and displays the subtotal value

                subtotalpriceLabel.Text = $"{subTotal.ToString("C")}";
                subtotalpriceLabel.ForeColor = Color.Orange;


                /// displays the tax value and the total value which is the subtotal plus the tax
              
                taxpriceLabel.Text = $"{taxCalculation.ToString("C")}";
                totalpriceLabel.Text = $"{totalPrice.ToString("C")}";
                errorLabel.Text = "";
            }
            catch
            {
                /// if no value or a letter or too high a value is inserted
               
                errorLabel.Text = "please enter a valid number";
            }
            try
            {
                if (burgerBox.Text == "0" && fryBox.Text == "0" && drinkBox.Text == "0")
                {
                    errorLabel.Text = "Please Actually Order Something";
                    subtotalpriceLabel.Text = "";
                    taxpriceLabel.Text = "";
                    totalpriceLabel.Text = "";
                }
            }
            catch
            {

            }
      
            }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
           
            try {
                /// calculates the change
               
                tenderedNumber = Convert.ToInt16(tenderedBox.Text);
                changeNumber = tenderedNumber - totalPrice;

                /// displays change and makes sure the error goes away
                
                changetotalLabel.Text = $"{changeNumber.ToString("C")}";
                errorLabel.Text = "";
            }
            catch
            {
                /// if an invalid value is inserted
                
                errorLabel.Text = "Please enter a valid number";
            }
            try
            {
                if (Convert.ToInt16(tenderedBox.Text) < totalPrice)
                {
                    errorLabel.Text = "Insufficient Funds";
                    changetotalLabel.Text = "";
                }
            }
            catch
            {

            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            /// receipt text displays everything at .5 second intervals
           
            ordernumberLabel.Text = "Order Number 1";

            SoundPlayer num1 = new SoundPlayer(Properties.Resources.Receipt);
            num1.Play();

            Refresh();
            Thread.Sleep(500);

            dateLabel.Text = "February 25 2020";
            SoundPlayer num2 = new SoundPlayer(Properties.Resources.Receipt);
            num2.Play();

            Refresh();
            Thread.Sleep(500);

            orderburgerLabel.Text = $"Hamburgers    x{burgerNumber} @ {burgersubTotal.ToString("C")} ";
            SoundPlayer num3 = new SoundPlayer(Properties.Resources.Receipt);
            num3.Play();

            Refresh();
            Thread.Sleep(500);

            orderfryLabel.Text = $"Fries    x{fryNumber} @ {frysubTotal.ToString("C")}";
            SoundPlayer num4 = new SoundPlayer(Properties.Resources.Receipt);
            num4.Play();

            Refresh();
            Thread.Sleep(500);

            orderdrinkLabel.Text = $"Drinks    x{drinkNumber} @ {drinksubTotal.ToString("C")}";
            SoundPlayer num5 = new SoundPlayer(Properties.Resources.Receipt);
            num5.Play();

            Refresh();
            Thread.Sleep(500);

            ordersubtotalLabel.Text = "Subtotal";
            ordersubtotalpriceLabel.Text = $"{subTotal.ToString("C")}";
            SoundPlayer num6 = new SoundPlayer(Properties.Resources.Receipt);
            num6.Play();

            Refresh();
            Thread.Sleep(500);

            ordertaxLabel.Text = "Tax";
            ordertaxpriceLabel.Text = $"{taxCalculation.ToString("C")}";
            SoundPlayer num7 = new SoundPlayer(Properties.Resources.Receipt);
            num7.Play();

            Refresh();
            Thread.Sleep(500);

            ordertotalLabel.Text = "Total";
            ordertotalpriceLabel.Text = $"{totalPrice.ToString("C")}";

            SoundPlayer num8 = new SoundPlayer(Properties.Resources.Receipt);
            num8.Play();

            Refresh();
            Thread.Sleep(500);

            ordertenderedLabel.Text = "Tendered";
            ordertenderedtotalLabel.Text = $"{tenderedNumber.ToString("C")}";

            SoundPlayer num9 = new SoundPlayer(Properties.Resources.Receipt);
            num9.Play();

            Refresh();
            Thread.Sleep(500);

            orderchangeLabel.Text = "Change";
            orderchangetotalLabel.Text = $"{changeNumber.ToString("C")}";

            SoundPlayer num10 = new SoundPlayer(Properties.Resources.Receipt);
            num10.Play();

            Refresh();
            Thread.Sleep(500);

            byeLabel.Text = "Bye";

            SoundPlayer num11 = new SoundPlayer(Properties.Resources.Receipt);
            num11.Play();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            /// fully resets everything allowing the customer to input a new order
           
            burgerBox.Text = "0";
            fryBox.Text = "0";
            drinkBox.Text = "0";
            subtotalpriceLabel.Text = "";
            taxpriceLabel.Text = "";
            totalpriceLabel.Text = "";
            tenderedBox.Text = "0";
            changetotalLabel.Text = "";
            ordernumberLabel.Text = "";
            dateLabel.Text = "";
            orderburgerLabel.Text = "";
            orderfryLabel.Text = "";
            orderdrinkLabel.Text = "";
            ordersubtotalLabel.Text = "";
            ordersubtotalpriceLabel.Text = "";
            ordertaxLabel.Text = "";
            ordertaxpriceLabel.Text = "";
            ordertotalLabel.Text = "";
            ordertotalpriceLabel.Text = "";
            ordertenderedLabel.Text = "";
            ordertenderedtotalLabel.Text = "";
            orderchangeLabel.Text = "";
            orderchangetotalLabel.Text = "";
            byeLabel.Text = "";
            errorLabel.Text = "";
            frysubTotal = 0;
            burgersubTotal = 0;
            drinksubTotal = 0;
            burgerNumber = 0;
            fryNumber = 0;
            drinkNumber = 0;
            tenderedNumber = 0;
            subTotal = 0;
            taxCalculation = 0;
            totalPrice = 0;
            changeNumber = 0;



        }

        private void OrderdrinkLabel_Click(object sender, EventArgs e)
        {

        }
    }

    }
