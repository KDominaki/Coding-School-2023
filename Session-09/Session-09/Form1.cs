using CalcLibrary;
namespace Session_09
{
    
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition,
            Division,
            Multiplication,
            Substraction,
            Power,
            Root
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsResNull();
            textBox.Text += "1";
            AddValues(1);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(2);
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(3);
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(4);
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(5);
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(6);
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(7);
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(8);
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(9);
            textBox.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IsResNull();
            AddValues(0);
            textBox.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
            _calcOperation = CalcOperation.Addition;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
            _calcOperation = CalcOperation.Substraction;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
            _calcOperation = CalcOperation.Division;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.Text += "^";
            _calcOperation = CalcOperation.Power;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text += (char)0x221A;
            _calcOperation = CalcOperation.Root;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Text += "=";
            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                    Addition addition= new Addition();
                    _result = addition.Sum(_value1.Value, _value2.Value);
                    break;
                case CalcOperation.Substraction:
                    _result = _value1 - _value2;
                    break;
                case CalcOperation.Division:
                    _result = _value1 / _value2;
                    break;
                case CalcOperation.Multiplication:
                    _result = _value1 * _value2;
                    break;
                case CalcOperation.Root:
                    double root =Convert.ToDouble(_value1.Value);
                    _result = Convert.ToDecimal(Math.Sqrt(root));
                    break;
                case CalcOperation.Power:
                    double powerOne = Convert.ToDouble(_value1.Value);
                    double powerTwo = Convert.ToDouble(_value2.Value);
                    _result = Convert.ToDecimal(Math.Pow(powerOne, powerTwo));
                    break;

                default:
                    break;
            }
            textBox.Text += _result;
        }

        private void IsResNull()
        {
            if (_result != null)
            {

                textBox.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
            else { }
        }

        private void AddValues(int num)
        {
            if (_value1 == null)
            {
                _value1 = num;
            }
            else
            {
                _value2 = num;
            }
        }

        private void SqueareRoot() 
        {
            if(_value1 != null)
            {
                
            }
        }

    
    }
}