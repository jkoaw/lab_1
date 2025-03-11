using System.Linq.Expressions;
using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int pom1, pom2, wynik;
        string tymczas = "";
        string wyswietlacz;
        List<char> dzialania = [];
        List<int> liczby = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tymczas += '1';
            wyswietlacz += '1';
            textBox1.Text = wyswietlacz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tymczas += '2';
            wyswietlacz += '2';
            textBox1.Text = wyswietlacz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tymczas += '3';
            wyswietlacz += '3';
            textBox1.Text = wyswietlacz;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tymczas += '4';
            wyswietlacz += '4';
            textBox1.Text = wyswietlacz;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tymczas += '5';
            wyswietlacz += '5';
            textBox1.Text = wyswietlacz;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tymczas += '6';
            wyswietlacz += '6';
            textBox1.Text = wyswietlacz;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tymczas += '7';
            wyswietlacz += '7';
            textBox1.Text = wyswietlacz;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tymczas += '8';
            wyswietlacz += '8';
            textBox1.Text = wyswietlacz;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tymczas += '9';
            wyswietlacz += '9';
            textBox1.Text = wyswietlacz;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (tymczas.Length > 0)
            {
                tymczas += '0';
                wyswietlacz += '0';
                textBox1.Text = wyswietlacz;
            }
        }

        private void button_dodo_Click(object sender, EventArgs e)
        {
            wyswietlacz += " + ";
            for (int i = 0; i < tymczas.Length; i++)
            {
                if (pom1 > 0)
                {
                    pom1 *= 10;
                }
                pom1 += tymczas[i] - '0';
            }
            tymczas = "";
            liczby.Add(pom1);
            pom1 = 0;
            dzialania.Add('1');
            textBox1.Text = wyswietlacz;

        }

        private void button_ode_Click(object sender, EventArgs e)
        {
            wyswietlacz += " - ";
            for (int i = 0; i < tymczas.Length; i++)
            {
                if (pom1 > 0)
                {
                    pom1 *= 10;
                }
                pom1 += tymczas[i] - '0';
            }
            tymczas = "";
            liczby.Add(pom1);
            pom1 = 0;
            dzialania.Add('2');
            textBox1.Text = wyswietlacz;
        }

        private void button_mno_Click(object sender, EventArgs e)
        {
            wyswietlacz += " * ";
            for (int i = 0; i < tymczas.Length; i++)
            {
                if (pom1 > 0)
                {
                    pom1 *= 10;
                }
                pom1 += tymczas[i] - '0';
            }
            tymczas = "";
            liczby.Add(pom1);
            pom1 = 0;
            dzialania.Add('3');
            textBox1.Text = wyswietlacz;
        }

        private void button_dzi_Click(object sender, EventArgs e)
        {
            wyswietlacz += " / ";
            for (int i = 0; i < tymczas.Length; i++)
            {
                if (pom1 > 0)
                {
                    pom1 *= 10;
                }
                pom1 += tymczas[i] - '0';
            }
            tymczas = "";
            liczby.Add(pom1);
            pom1 = 0;
            dzialania.Add('4');
            textBox1.Text = wyswietlacz;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tymczas.Length; i++)
            {
                if (pom1 > 0)
                {
                    pom1 *= 10;
                }
                pom1 += tymczas[i] - '0';
                
            }
            tymczas = "";
            liczby.Add(pom1);
            pom1 = 0;
            for (int i = 0; i < dzialania.Count; i++)
            {
                if (dzialania[i] == '3' || dzialania[i] == '4')
                {
                    switch (dzialania[i])
                    {
                        case '3':
                            liczby[i] *= liczby[i + 1];
                            break;
                        case '4':
                            liczby[i] /= liczby[i + 1];
                            break;
                        default:
                            break;
                    }
                    liczby.RemoveAt(i + 1);
                    dzialania.RemoveAt(i);
                    i--;
                }
            }
            wynik += liczby[0];
            liczby.RemoveAt(0);
            while (dzialania.Count > 0)
            {
                switch (dzialania[0])
                {
                    case '1':
                        wynik += liczby[0];
                        liczby.RemoveAt(0);
                        dzialania.RemoveAt(0);
                        break;
                    case '2':
                        wynik -= liczby[0];
                        liczby.RemoveAt(0);
                        dzialania.RemoveAt(0);
                        break;
                    case '3':
                        wynik *= liczby[0];
                        liczby.RemoveAt(0);
                        dzialania.RemoveAt(0);
                        break;
                    case '4':
                        wynik /= liczby[0];
                        liczby.RemoveAt(0);
                        dzialania.RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            wyswietlacz = Convert.ToString(wynik, 10);
            textBox1.Text = wyswietlacz;
            wynik = 0;
            liczby.Clear();
            dzialania.Clear();
            wyswietlacz = "";
        }
    }
}
