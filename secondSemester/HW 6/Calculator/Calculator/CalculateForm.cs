namespace CalculatorNamespace
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// User interface for calculator.
    /// </summary>
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
            
            calculator = new Calculator();
        }   

        /// <summary>
        /// Method for press the key operator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorClick(object sender, EventArgs e)
        {
            Button ourButton = sender as Button;

            if (label.Text == "Error")
            {
                label.Text = "";
                calculator.ClearAll();
            }

            if (calculator.state == (int)States.firstNumberPoint || calculator.state == (int)States.secondNumberPoint
			|| calculator.state == (int)States.none)
		        return;

	        if (calculator.state == (int)States.secondNumberEnter || calculator.state == (int)States.secondNumberFraction)
	        {
                try
                {
                    calculator.CalculateAnswer();
                }
                catch (DivideByZeroException)
                {  
                    this.label.Text = "Error";
                    return;
                }

                this.label.Text = calculator.CalculateAnswer().ToString() + ourButton.Text;
	        }
	        else if (calculator.state == (int)States.operationAdd)
	        {
                string newText = this.label.Text.Remove(this.label.Text.Length - 1); ;
                newText += ourButton.Text;
                this.label.Text = newText;
	        }
	        else
                this.label.Text += ourButton.Text;

            calculator.AddOperation(ourButton.Text);
        }

        /// <summary>
        /// Method for press the key delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, EventArgs e)
        {
            label.Text = "";
            calculator.ClearAll();
        }

        /// <summary>
        /// Method for press the key number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberClick(object sender, EventArgs e)
        {
            if (label.Text == "Error")
            {
                label.Text = "";
                calculator.ClearAll();
            }

            Button ourButton = sender as Button;

            if (calculator.state == (int)States.none || calculator.state == (int)States.answer)
                this.label.Text = "";
            this.label.Text += ourButton.Text;
            calculator.AddNumber(Int32.Parse(ourButton.Text));
        }

        /// <summary>
        /// Method for press the key equal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalClick(object sender, EventArgs e)
        {
            if (label.Text == "Error")
            {
                label.Text = "";
                calculator.ClearAll();
            }

            if (calculator.state == (int)States.secondNumberEnter || calculator.state == (int)States.secondNumberFraction)
	        {   
                try
                {
                    calculator.CalculateAnswer();
                }
                catch (DivideByZeroException)
                {
                    this.label.Text = "Error";
                    return;
                }

                label.Text = calculator.CalculateAnswer().ToString(); ;
		        calculator.AnswerToFirstNumber();
		        calculator.state = (int)States.answer;
	        }
        }

        /// <summary>
        /// Method for press the key point.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pointClick(object sender, EventArgs e)
        {
            if (calculator.state == (int)States.firstNumberEnter || calculator.state == (int)States.secondNumberEnter)
            {
                calculator.AddPoint();
                label.Text += ".";
            }
        }

        private Calculator calculator;
    }
    
}
