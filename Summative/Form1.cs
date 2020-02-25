using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Summative
{

    public partial class Form1 : Form
    {
        const double burgerPrice = 1.00;
        const double fryPrice = 0.50;
        const double drinkPrice = 1.25;
        const double tax = 0.13;
        

        public Form1()
        {
            
            InitializeComponent();
        }
        double totalPrice;
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
   
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            /// Ian Dill
            /// February 19 2020
            /// Cash Register
           
           
            

            try {

                burgerNumber = Convert.ToInt16(burgerBox.Text);
                fryNumber = Convert.ToInt16(fryBox.Text);
                drinkNumber = Convert.ToInt16(drinkBox.Text);
                burgersubTotal = burgerNumber * burgerPrice;
                frysubTotal = fryNumber * fryPrice;
                drinksubTotal = drinkNumber * drinkPrice;
                subTotal = burgersubTotal + frysubTotal + drinksubTotal;
                taxCalculation = tax * subTotal;
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



        }

        private void OrderdrinkLabel_Click(object sender, EventArgs e)
        {

        }
    }

    }
