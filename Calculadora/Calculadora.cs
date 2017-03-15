using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class frm_calculadora : Form {
        private string operacao = null;
        private string num = "";
        private double? resultado = null;
        private double? memoria;

        private double? num1 = null;
        private double? num2 = null;

        public frm_calculadora() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btn_calcular_Click(object sender, EventArgs e) {
            calcular();
        }

        private void calcular() {
            num2 = double.Parse(num);
            //display_sec.Text += "=";
            num = "";
            switch (operacao) {
                case "soma":
                    resultado = (num1 + num2);
                    break;
                case "subt":
                    resultado = (num1 - num2);
                    break;
                case "mult":
                    resultado = (num1 * num2);
                    break;
                case "div":
                    resultado = (num1 / num2);
                    break;
                case "porc":
                    resultado = 0;
                    break;
                case "sqrt":
                    resultado = Math.Sqrt((double)num2);
                    break;
                default:

                    break;
            }
            operacao = "concluida";
            num1 = null;
            num2 = null;
            display.Text = resultado.ToString();
        }

        private void btn_soma_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "soma";
                num1 = double.Parse(num);
                num = "";
                display_sec.Text += "+";
            }
            else {
                if(num != "") {
                    calcular();
                }
                operacao = "soma";
                num1 = (double)resultado;
                display_sec.Text += "+";
            }
        }

        private void btn_subt_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "subt";
                num1 = double.Parse(num);
                num = "";
                display_sec.Text += "-";
            }
            else {
                if (num != "") {
                    calcular();
                }
                operacao = "subt";
                num1 = (double)resultado;
                display_sec.Text += "-";
            }
        }

        private void btn_mult_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "mult";
                num1 = double.Parse(num);
                num = "";
                display_sec.Text += "*";
            }
            else {
                if (num != "") {
                    calcular();
                }
                operacao = "mult";
                num1 = (double)resultado;
                display_sec.Text += "*";
            }
        }

        private void btn_div_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "div";
                num1 = double.Parse(num);
                num = "";
                display_sec.Text += "/";
            }
            else {
                if(num != "") {
                    calcular();
                }
                operacao = "div";
                num1 = (double)resultado;
                display_sec.Text += "/";
            }
        }

        private void btn_porc_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "porc";
                num1 = double.Parse(num);
                num = "";
                display_sec.Text += "%";
            }
            else {
                if (num != "") {
                    calcular();
                }
                operacao = "porc";
                num1 = (double)resultado;
                display_sec.Text += "%";
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e) {
            if (operacao == null) {
                operacao = "sqrt";
                display_sec.Text += "√";
            }
            else {
                if (num != "") {
                    calcular();
                }
                operacao = "sqrt";
                display_sec.Text += "√";
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            operacao = null;
            display.ResetText();
            display_sec.ResetText();
            num = "";
            num1 = 0;
            num2 = 0;
        }

        private void pressionar_botao(string valor) {
            num += valor;
            display_sec.Text += valor;
        }

        private void btn_0_Click(object sender, EventArgs e) {
            pressionar_botao("0");
        }
        private void btn_1_Click(object sender, EventArgs e) {
            pressionar_botao("1");
        }
        private void btn_2_Click(object sender, EventArgs e) {
            pressionar_botao("2");
        }
        private void btn_3_Click(object sender, EventArgs e) {
            pressionar_botao("3");
        }
        private void btn_4_Click(object sender, EventArgs e) {
            pressionar_botao("4");
        }
        private void btn_5_Click(object sender, EventArgs e) {
            pressionar_botao("5");
        }
        private void btn_6_Click(object sender, EventArgs e) {
            pressionar_botao("6");
        }
        private void btn_7_Click(object sender, EventArgs e) {
            pressionar_botao("7");
        }
        private void btn_8_Click(object sender, EventArgs e) {
            pressionar_botao("8");
        }
        private void btn_9_Click(object sender, EventArgs e) {
            pressionar_botao("9");
        }
        private void btn_ponto_Click(object sender, EventArgs e) {
            pressionar_botao(",");
        }

        private void btn_men_Click(object sender, EventArgs e) {
            if (resultado != null) {
                memoria = resultado;
            }
            else {
                memoria = double.Parse(num);
            }
            lbl_mem.Text = "M";
        }

        private void btn_menR_Click(object sender, EventArgs e) {
            memoria = null;
            lbl_mem.Text = "";
        }

        private void btn_menU_Click(object sender, EventArgs e) {
            if (memoria != null) {
                if (num1 == null) {
                    num1 = memoria;
                }
                else {
                    num2 = memoria;
                }
                pressionar_botao(memoria.ToString());
            }
            else {
                display_error.Text = "Não há valor na memória!";
            }
        }

        private void calculadora_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.D0:
                case Keys.NumPad0:
                    pressionar_botao("0");
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    pressionar_botao("1");
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    pressionar_botao("2");
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    pressionar_botao("3");
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    pressionar_botao("4");
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    pressionar_botao("5");
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    pressionar_botao("6");
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    pressionar_botao("7");
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    pressionar_botao("8");
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    pressionar_botao("9");
                    break;
                case Keys.Decimal:
                    pressionar_botao(",");
                    break;
                case Keys.Add:
                    btn_soma_Click(null, null);
                    break;
                case Keys.Subtract:
                    btn_subt_Click(null, null);
                    break;
                case Keys.Multiply:
                    btn_mult_Click(null, null);
                    break;
                case Keys.Divide:
                    btn_div_Click(null, null);
                    break;
                case Keys.Enter:
                    calcular();
                    break;
                case Keys.Back:
                case Keys.Delete:
                    btn_limpar_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}