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
            Substraction
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox.Text += "1";

            if (_result != null)
            {

                textBox.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            textBox.Text += "1";

            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //textBox.Text += "2";
            if (_result != null)
            {

                textBox.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            textBox.Text += "2";

            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
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
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.Text += "^";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text += "r";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Text += "=";
            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                    _result = _value1 + _value2;
                    break;

                default:
                    break;
            }
            textBox.Text += _result;
        }

    
    }
}