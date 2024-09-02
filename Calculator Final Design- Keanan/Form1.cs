using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Final_Design__Keanan
{
    public partial class Form1 : Form
    {

        private double TotalSum; //Setting to Integer
        private double FirstValue; //First Value
        private double SecondVaue;
        private string MethodChoice;
        private bool isFirstValue = true;
        public Form1()
        {
            InitializeComponent();

            TotalSum = 0;
            FirstValue = 0;
            SecondVaue = 0;
            MethodChoice = "Clear";
            


        }

        private void DisplayBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayBox.Text = TotalSum.ToString(); //When the program opens, it automatically sets the value to zero
            
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //When user presses clear button, you want the program to basically reset , all values
            TotalSum = 0; FirstValue = 0; SecondVaue = 0; MethodChoice = "clear"; DisplayBox.Text = TotalSum.ToString();
            FirstValue = 0;
            MethodChoice = "Clear";
            Decimalbtn.Enabled = true; //reenable decimal place
            isFirstValue = true;


        }

        private void Dividebtn_Click(object sender, EventArgs e)
        {
            MethodChoice = "Divide";
            FirstValue = double.Parse(DisplayBox.Text); //first value
            isFirstValue = true; //knows first value now
        }

        private void Multiplybtn_Click(object sender, EventArgs e)
        {
            MethodChoice = "Multiply";
            FirstValue = double.Parse(DisplayBox.Text); //first value
            isFirstValue = true; //knows first value now
        }

        private void Minusbtn_Click(object sender, EventArgs e)
        {
            MethodChoice = "Minus";
            FirstValue = double.Parse(DisplayBox.Text); //first value
            isFirstValue = true; //knows first value now
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            FirstValue = double.Parse(DisplayBox.Text); //Setting the first value to whats entered on screen
            MethodChoice = "Add";
            isFirstValue = true; //first number stored 
        }

        private void NumberOnScreen(string number) //Add numbers to textbox without overiding them so it wil add
        {
            if (isFirstValue)
            {
                //if first number replace zero
                DisplayBox.Text = number;
                isFirstValue = false; //onto second number now first number done
            }
            else
            {
                DisplayBox.Text += number; //Number after first value

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        NumberOnScreen("0"); //add zero to screen
        }
        private void Onebtn_Click(object sender, EventArgs e)
        {
            
            NumberOnScreen("1");
            
        }
        private void Twobtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("2"); 
        }
        private void Threebtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("3");
        }
        private void Fourbtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("4");
        }
        private void Fivebtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("5");
        }
        private void Sixbtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("6");
        }
        private void SevenBTN_Click(object sender, EventArgs e)
        {
            NumberOnScreen("7");
        }
        private void Eightbtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("8");
        }
        private void Ninebtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen("9");
        }

        private void Decimalbtn_Click(object sender, EventArgs e)
        {
            NumberOnScreen(".");
            Decimalbtn.Enabled = false; //Cant use decimal place more than once
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(DisplayBox.Text); //grabbing the second number on the screen

            //Operations below

            if (MethodChoice == "Add")
            {
                TotalSum = FirstValue + secondValue;
            }
            if (MethodChoice == "Minus")
            {
                TotalSum = FirstValue - secondValue;
            }
            if (MethodChoice == "Divide")
            {
                TotalSum = FirstValue / secondValue;
            }
            if (MethodChoice == "Multiply")
            {
                TotalSum = FirstValue * secondValue;
            }

            DisplayBox.Text = TotalSum.ToString(); //show result
            FirstValue = TotalSum; //if they want to carry on with the operation like using the total sum + new nubmer or something
        }
    }
}
