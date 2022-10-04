using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pizza_s_Home
{
     
    
      
    public partial class Form1 : Form
    {
       
        int numOfpizza = 0;
        int numOfdrinks = 0;
        int numOfwing = 0;
        double pizzaPrice = 15.00;
        double wingPrice =  2.00;
        double drinksPrice = 1.00;
        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        int numOfmoney = 0;
        double moneyHave;
        
        public Form1()
        {
            InitializeComponent();
            changeButton.Enabled = false;
            printButton.Enabled = false;
            newOrderButton.Enabled = false;
        }


        

        private void calulateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfpizza = Convert.ToInt32(pizzaInput.Text);
                numOfdrinks = Convert.ToInt32(drinksInput.Text);
                numOfwing = Convert.ToInt32(wingsInput.Text);

                subTotal = numOfpizza * pizzaPrice + numOfdrinks * drinksPrice + numOfwing * wingPrice;
                subOutput.Text = $"{subTotal.ToString("C")}";

                taxAmount = subTotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalPrice = subTotal + taxAmount;
                totalOutput.Text = $"{totalPrice.ToString("C")}";
                changeButton.Enabled = true;
            }
      
            
            catch
            {
                subOutput.Text = "ERROR ERROR ERROR";
                totalOutput.Text = "ERROR ERROR ERROR";
                taxOutput.Text = "ERROR ERROR ERRRO";
            }
            
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfmoney = Convert.ToInt32(moneyText.Text);
                moneyHave = numOfmoney - totalPrice;
                changeOutput.Text = $"{moneyHave.ToString("C")}";
                printButton.Enabled = true;







            }
            catch
            {
                changeOutput.Text = "ERROR ERROR ERROR ERRRO";

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printLabel.Text =  $"      Pizza's Hut Inc";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n\n  Order Number 2068";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n   Oct 3 2022";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n\n Pizza x{numOfpizza} @    {pizzaPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n Drinks x{numOfdrinks} @   {drinksPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n Wings x{numOfwing} @    {wingPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n\n SubTotal      {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n Tax           {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n Total         {totalPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n\n Tendered  {numOfmoney.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text += $"\n Change   {moneyHave.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            printLabel.Text +=      $"\n Have A Good Day";


            newOrderButton.Enabled = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            numOfdrinks = 0;
            numOfmoney = 0;
            numOfpizza=0;
            numOfwing = 0;
            pizzaInput.Text = "";
            wingsInput.Text = "";
            drinksInput.Text = "";
            subOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            moneyText.Text = "";
            changeOutput.Text = "";
            printLabel.Text = "";
        }
    }
}
