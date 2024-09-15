namespace calculadora3
{
    public partial class Form1 : Form
    {
        public string valorAtualEsq = "";
        public string valorAtualDir = "";
        public string operacao = string.Empty;
        public double total = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            verificaNumero("1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            verificaNumero("2");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            verificaNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            verificaNumero("6");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            verificaNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            verificaNumero("4");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            verificaNumero("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            verificaNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            verificaNumero("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            verificaNumero("0");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            defineOperacao("+");
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            defineOperacao("-");
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            defineOperacao("*");
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            defineOperacao("/");
        }

        private void verificaNumero(string numero)
        {
            if (operacao == string.Empty)
            {
                adicionarNumeroEsq(numero);
            }
            else
            {
                adicionarNumeroDir(numero);
            }
        }


        private void adicionarNumeroEsq(string numero)
        {
            valorAtualEsq += numero;
            lblVisor.Text = valorAtualEsq.ToString();
        }

        private void adicionarNumeroDir(string numero)
        {
            valorAtualDir += numero;
            lblVisor.Text = valorAtualDir.ToString();
        }

        private void defineOperacao(string operador)
        {
            operacao = operador;
            lblVisor.Text += operacao;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = string.Empty;
            valorAtualDir = string.Empty;
            valorAtualEsq = string.Empty;
            operacao = string.Empty;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch(operacao)
            {
                case "+":
                    total = double.Parse(valorAtualEsq) + double.Parse(valorAtualDir);
                    break;
                case "-":
                    total = double.Parse(valorAtualEsq) - double.Parse(valorAtualDir);
                    break;
                case "*":
                    total = double.Parse(valorAtualEsq) * double.Parse(valorAtualDir);
                    break;
                case "/":
                    total = double.Parse(valorAtualEsq) / double.Parse(valorAtualDir);
                    break;

            }
        lblVisor.Text = total.ToString();
        }
    }
}
