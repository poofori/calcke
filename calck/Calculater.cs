using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace calck
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();

            // Подключаем обработчик ко всем кнопкам, не меняя их внешний вид.
            foreach (Button button in Controls.OfType<Button>())
                button.Click += CalculatorButton_Click;

            txtDisplay.Text = "0";
            txtDisplay.ReadOnly = true;
        }

        private void CalculatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            string value = button.Text;

            switch (value)
            {
                case "C":
                    txtDisplay.Text = "0";
                    break;

                case "⌫":
                    DeleteLastCharacter();
                    break;

                case "=":
                    CalculateResult();
                    break;

                case "+":
                case "-":
                case "×":
                case "÷":
                    AddOperator(value);
                    break;

                case "(":
                    AddOpeningParenthesis();
                    break;

                case ")":
                    AddClosingParenthesis();
                    break;

                case ",":
                    AddDecimalSeparator();
                    break;

                default:
                    if (value.Length == 1 && char.IsDigit(value[0]))
                        AddDigit(value);
                    break;
            }
        }

        private void AddDigit(string digit)
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "Введите число:" ||
                txtDisplay.Text == "Ошибка")
                txtDisplay.Text = digit;
            else
                txtDisplay.Text += digit;
        }

        private void AddOperator(string op)
        {
            string expression = txtDisplay.Text;
            if (expression == "Введите число:" || expression == "Ошибка")
                expression = "0";

            if (expression.Length == 0)
            {
                if (op == "-")
                    txtDisplay.Text = "-";
                return;
            }

            char last = expression[expression.Length - 1];
            if ("+-×÷".Contains(last))
                expression = expression.Substring(0, expression.Length - 1);

            txtDisplay.Text = expression + op;
        }

        private void AddDecimalSeparator()
        {
            string expression = txtDisplay.Text;
            if (expression == "Введите число:" || expression == "Ошибка" || expression.Length == 0)
            {
                txtDisplay.Text = "0,";
                return;
            }

            int lastOperator = Math.Max(
                Math.Max(expression.LastIndexOf('+'), expression.LastIndexOf('-')),
                Math.Max(expression.LastIndexOf('×'), expression.LastIndexOf('÷')));
            int lastOpenParenthesis = expression.LastIndexOf('(');
            int start = Math.Max(lastOperator, lastOpenParenthesis);
            string currentNumber = expression.Substring(start + 1);

            if (!currentNumber.Contains(',') && !currentNumber.Contains('.'))
                txtDisplay.Text += ",";
        }

        private void AddOpeningParenthesis()
        {
            string expression = txtDisplay.Text;
            if (expression == "0" || expression == "Введите число:" || expression == "Ошибка")
                txtDisplay.Text = "(";
            else
                txtDisplay.Text += "(";
        }

        private void AddClosingParenthesis()
        {
            string expression = txtDisplay.Text;
            int open = expression.Count(c => c == '(');
            int close = expression.Count(c => c == ')');

            if (open > close && expression.Length > 0 &&
                !"+-×÷(,".Contains(expression[expression.Length - 1]))
                txtDisplay.Text += ")";
        }

        private void DeleteLastCharacter()
        {
            string expression = txtDisplay.Text;
            if (expression == "Введите число:" || expression == "Ошибка" || expression.Length <= 1)
                txtDisplay.Text = "0";
            else
                txtDisplay.Text = expression.Substring(0, expression.Length - 1);
        }

        private void CalculateResult()
        {
            string expression = txtDisplay.Text;
            if (string.IsNullOrWhiteSpace(expression) || expression == "Введите число:" ||
                expression == "Ошибка")
                return;

            try
            {
                // DataTable понимает обычные арифметические выражения и скобки.
                string normalized = expression
                    .Replace("×", "*")
                    .Replace("÷", "/")
                    .Replace(',', '.');

                object? result = new DataTable { Locale = CultureInfo.InvariantCulture }
                    .Compute(normalized, string.Empty);

                if (result == null || result == DBNull.Value)
                {
                    txtDisplay.Text = "Ошибка";
                    return;
                }

                double number = Convert.ToDouble(result, CultureInfo.InvariantCulture);
                if (double.IsNaN(number) || double.IsInfinity(number))
                {
                    txtDisplay.Text = "Ошибка";
                    return;
                }

                txtDisplay.Text = number.ToString("G", CultureInfo.CurrentCulture);
            }
            catch
            {
                txtDisplay.Text = "Ошибка";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Обработчик оставлен для совместимости с дизайнером формы.
        }
    }
}
