using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class MainForm : Form
    {
        private string currentInput = "";
        private string currentOperation = "";
        private double currentResult = 0;
        private bool isNewCalculation = true;
        private bool hasDecimalPoint = false;

        public MainForm()
        {
            InitializeComponent();
            
            btnDecimal.Enabled = true;
            btnNegate.Enabled = true;
            
            btnDecimal.Click += new EventHandler(DecimalButton_Click);
            btnNegate.Click += new EventHandler(NegateButton_Click);

            ResultScreen.TextAlign = HorizontalAlignment.Right;
            ResultScreen.ReadOnly = true;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (isNewCalculation)
            {
                currentInput = "";
                isNewCalculation = false;
            }
            
            if (currentInput == "0" && button.Text == "0")
                return;
                
            if (currentInput == "0" && button.Text != "0")
                currentInput = button.Text;
            else
                currentInput += button.Text;
                
            UpdateDisplay();
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (double.TryParse(currentInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double inputValue))
                {
                    if (!string.IsNullOrEmpty(currentOperation))
                    {
                        PerformCalculation(inputValue);
                        UpdateDisplay(currentResult);
                    }
                    else
                    {
                        currentResult = inputValue;
                    }
                }
                else
                {
                    ShowError("Invalid input");
                    return;
                }
            }
            else if (string.IsNullOrEmpty(currentOperation) && currentResult == 0)
            {
                currentResult = 0;
            }

            currentOperation = button.Text;
            isNewCalculation = true;
            hasDecimalPoint = false;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperation))
            {
                if (double.TryParse(currentInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double inputValue))
                {
                    PerformCalculation(inputValue);
                    UpdateDisplay(currentResult);
                    
                    currentOperation = "";
                    isNewCalculation = true;
                    hasDecimalPoint = false;
                }
                else if (string.IsNullOrEmpty(currentInput))
                {
                    UpdateDisplay(currentResult);
                }
                else
                {
                    ShowError("Invalid input");
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Name == "btnClearEntry")
            {
                currentInput = "";
                hasDecimalPoint = false;
                UpdateDisplay("0");
            }
            else if (button.Name == "btnClear")
            {
                currentInput = "";
                currentOperation = "";
                currentResult = 0;
                isNewCalculation = true;
                hasDecimalPoint = false;
                UpdateDisplay("0");
            }
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                if (currentInput[currentInput.Length - 1] == '.')
                {
                    hasDecimalPoint = false;
                }
                
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                
                if (string.IsNullOrEmpty(currentInput))
                {
                    UpdateDisplay("0");
                }
                else
                {
                    UpdateDisplay();
                }
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!hasDecimalPoint)
            {
                if (isNewCalculation || string.IsNullOrEmpty(currentInput))
                {
                    currentInput = "0";
                    isNewCalculation = false;
                }
                
                currentInput += ".";
                hasDecimalPoint = true;
                UpdateDisplay();
            }
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (currentInput.StartsWith("-"))
                {
                    currentInput = currentInput.Substring(1);
                }
                else
                {
                    currentInput = "-" + currentInput;
                }
                
                UpdateDisplay();
            }
            else if (currentResult != 0)
            {
                currentResult = -currentResult;
                currentInput = currentResult.ToString(CultureInfo.InvariantCulture);
                UpdateDisplay();
            }
        }

        private void PerformCalculation(double secondNumber)
        {
            try
            {
                switch (currentOperation)
                {
                    case "+":
                        currentResult += secondNumber;
                        break;
                    case "-":
                        currentResult -= secondNumber;
                        break;
                    case "×":
                        currentResult *= secondNumber;
                        break;
                    case "÷":
                        if (Math.Abs(secondNumber) < double.Epsilon)
                        {
                            ShowError("Cannot divide by zero");
                            return;
                        }
                        currentResult /= secondNumber;
                        break;
                    default:
                        currentResult = secondNumber;
                        break;
                }
                
                if (double.IsInfinity(currentResult) || double.IsNaN(currentResult))
                {
                    ShowError("Calculation error");
                    currentResult = 0;
                }
                
                currentInput = "";
            }
            catch (Exception ex)
            {
                ShowError($"Error: {ex.Message}");
                Reset();
            }
        }

        private void UpdateDisplay(double value)
        {
            ResultScreen.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        private void UpdateDisplay(string value = null)
        {
            ResultScreen.Text = value ?? currentInput;
        }

        private void ShowError(string message)
        {
            ResultScreen.Text = message;
            isNewCalculation = true;
        }

        private void Reset()
        {
            currentInput = "";
            currentOperation = "";
            currentResult = 0;
            isNewCalculation = true;
            hasDecimalPoint = false;
            UpdateDisplay("0");
        }
    }
}