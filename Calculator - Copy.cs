using Microsoft.VisualBasic.Logging;

namespace Calculator_2
{
    public partial class Calculator : Form
    {
        bool operandPerformed = false;// this boolean checks to see if the algebra equation has been pressed 
        string operand = "";//variable that stores the +-*/
        double result = 0;//double variable holds results 
        double num1; //storeing first opernd 
        double num2; // storing 2nd operand 
        public Calculator()
        {
            InitializeComponent();
        }
        double ans;//create variable for answer 
        //num1 will come from input 1 box and num2  will come from input 2 box 
        int count;//variable that will be used for counting 

        private void bttnAdd_Click(object sender, EventArgs e)// THIS IS MY ADDITION BUTTON
        {

            if (double.TryParse(Input1.Text, out double num1) && double.TryParse(Input2.Text, out double num2))
            {//using double b/c its c# best for algorigthms , tryParse makes the string numeric, calling both input values 
                operand = "+"; // store the operator so i can use it without pop up 
                operandPerformed = true;
                InputResult.Text = ""; // Display the result in the input Result box 
            }
            else //what happenes if the input is not a number 

            {
                MessageBox.Show("Please enter a number in both boxes.");
            }

        }

        private void bttnSub_Click(object sender, EventArgs e)//THIS IS MY SUBTRACTION BUTTON 
        {
            if (double.TryParse(Input1.Text, out double num1) && double.TryParse(Input2.Text, out double num2))
            //validating or calling these two inputs as reference to where I want my string to be converted to numers 
            {
                operand = "-";
                operandPerformed = true;
                InputResult.Text = ""; // Display the result in the input Result box 
            }
            else //what happenes if the input is not a number 

            {
                MessageBox.Show("Please enter a number in both boxes.");

            }
        }

        private void bttnMult_Click(object sender, EventArgs e)//THIS IS MY MULTIPLICATION BUTTON 
        {
            if (double.TryParse(Input1.Text, out double num1) && double.TryParse(Input2.Text, out double num2))
            {// This also stores the input string that is converted to a number and stored in num1 or num 2 
                operand = "*";
                operandPerformed = true;
                InputResult.Text = ""; // Display the result in the input Result box 
            }
            else //what happenes if the input is not a number 

            {
                MessageBox.Show("Please enter a number in both boxes."); //this calles a message box to pop up and the red section is what i want it to say 

            }
        }

        private void bttnDiv_Click(object sender, EventArgs e)//THIS IS MY DIV BUTTON 
        {
            if (double.TryParse(Input1.Text, out double num1) && double.TryParse(Input2.Text, out double num2))
            {// this also makes sure both inputs are valid number and if they are it will follow what is in the {}
                operand = "/";
                InputResult.Text = ""; // Display the result in the input Result box 
                operandPerformed = true; //operation is starting
            }
            else //what happenes if the input is not a number 

            {
                MessageBox.Show("Please enter a number."); // will bring up a pop up box which called me called upon by a MESSAGEBOX.SHOW 

            }
        }

        private void bttnEquals_Click(object sender, EventArgs e)
        {
            if (operandPerformed && double.TryParse(Input2.Text, out num2))
            {
                num1 = double.Parse(Input1.Text);
                switch (operand)
                {
                    case "+": //Addition 
                        ans = num1 + num2;
                        InputResult.Text = ans.ToString();
                        break;
                    case "-": //Subtraction
                        ans = num1 - num2;
                        InputResult.Text = ans.ToString();
                        break;
                    case "*": //multiplication 
                        ans = num1 * num2;
                        InputResult.Text = ans.ToString();
                        break;
                    case "/": // division 
                        ans = num1 / num2;
                        InputResult.Text = ans.ToString();
                        break;
                }
                InputResult.Text = ans.ToString(); // Will display the answe to the equation in the designated text result box 
                Input1.Clear();// clear the input box 1
                Input2.Clear();// clear input box 2
                operandPerformed = false; // ends the count 
            }
            else
            {
                MessageBox.Show("Please enter a Number in both fields ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
