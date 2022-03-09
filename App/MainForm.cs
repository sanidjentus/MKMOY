using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace App
{
    public partial class MainForm : Form
    {
        private int RoNum = 3;

        private bool is1 = false;
        private bool is2 = false;

        public double sigma0;
        public double sigma1;
        public double sigma2;

        public double k0;
        public double k1;
        public double k2;

        public double toDouble(string str)
        {
            bool IsNeg = false;
            double Re = 0;
            double ReD = 0;

            int i = 0;

            if (str[i] == '-') { i++; }//проверка, что вещественная часть отрицательна
            while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
            {
                Re = Re * 10 + (double)(str[i]) - (double)('0');
                i++;
            }
            if (i < str.Length && str[i] == '.')
            {
                int t = 10;
                i++;
                while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                {
                    ReD = ReD + ((double)(str[i]) - (double)('0')) / t;
                    t *= 10;
                    i++;
                }
                Re = Re + ReD;
                if (IsNeg) return -Re;
                else return Re;
            }
            else 
            {
                if (IsNeg) return -Re;
                else return Re;
            }
        }

        public bool isDouble(string str)
        {
            bool wasDot = false;
            bool IsNeg = false;

            int i = 0;
            if (str != "")
            {
                if (str[i] == '-') { i++; }//проверка, что вещественная часть отрицательна
                if (i < str.Length && str[i] >= '0' && str[i] <= '9')
                {
                    while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                    {
                        i++;
                    }
                    if (i < str.Length && str[i] == '.')
                    {
                        wasDot = true;
                        i++;
                        if (i == str.Length || (i < str.Length && (str[i] < '0' || str[i] > '9'))) return false;
                        while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                        {
                            i++;
                        }
                        if (i == str.Length) return true;
                        else return false;
                    }
                    else 
                    {
                        if (i == str.Length) return true;
                        else return false;
                    } 
                        
                }
                else return false;
                
            }
            else return false;
        }

        public Complex toComplex(string str)
        {
            Complex c;
            bool reIsNeg = false;
            bool imIsNeg = false;
            double Re = 0;
            double ReD = 0;
            double Im = 0;
            double ImD = 0;

            int i = 0;
            if (str[i] == '-') { i++; reIsNeg = true; }//проверка, что вещественная часть отрицательна
            if (str[i] != 'i')
            {
                while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                {
                    Re = Re * 10 + (double)(str[i]) - (double)('0');
                    i++;
                }
                if (i < str.Length && str[i] == '.')
                {
                    int t = 10;
                    i++;
                    while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                    {
                        ReD = ReD + ((double)(str[i]) - (double)('0'))/t;
                        t *= 10;
                        i++;
                    }
                }
                if (i < str.Length && (str[i] == '+' || str[i] == '-'))
                {
                    if (str[i] == '-') imIsNeg = true; // проверка на отрицательность мнимой части
                    i++;
                    if (str[i] == 'i')
                    {
                        Re = Re + ReD;
                        if (reIsNeg) Re *= -1;
                        Im = 1;
                        if (imIsNeg) Im *= -1;
                        c = new Complex(Re, Im);
                        return c;
                    }
                    while (i < str.Length && str[i] >= '0' && str[i] <= '9')// считывание мнимной части
                    {
                        Im = Im * 10 + (double)(str[i]) - (double)('0');
                        i++;
                    }
                    if (i < str.Length && str[i] == '.')
                    {
                        int t = 10;
                        i++;
                        while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                        {
                            ImD = ImD*10 + ((double)(str[i]) - (double)('0'))/t;
                            t *= 10;
                            i++;
                        }
                    }
                    Re = Re + ReD;
                    Im = Im + ImD;
                    if (reIsNeg) Re *= -1;
                    if (imIsNeg) Im *= -1;
                    c = new Complex(Re, Im);
                    return c;
                }
                else
                {
                    if (i == str.Length)
                    {
                        Re = Re + ReD;
                        if (reIsNeg) Re *= -1;
                        c = new Complex(Re, 0);
                        return c;
                    }
                    else
                    {
                        Re = Re + ReD;
                        if (reIsNeg) Re *= -1;
                        Im = Re;
                        c = new Complex(0, Im);
                        return c;
                    }
                }
            }
            else 
            {
                Im = 1;
                if (reIsNeg) Im *= -1;
                c = new Complex(0, Im);
                return c;
            }
        }

        public bool isComplex(string str)
        {
            //Complex c = new Complex();
            bool wasDot = false;
            bool reIsNeg = false;
            bool imIsNeg = false;

            int i = 0;
            if (str != "")
            {
                if (str[i] == '-') { i++; }//проверка, что вещественная часть отрицательна
                if (i < str.Length && str[i] != 'i')
                {
                    if (i < str.Length && str[i] >= '0' && str[i] <= '9')
                    {
                        while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                        {
                            i++;
                        }
                        if (i < str.Length && str[i] == '.')
                        {
                            wasDot = true;
                            i++;
                            if (i == str.Length || (i<str.Length && (str[i] < '0' || str[i] > '9'))) return false;
                            while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                            {
                                i++;
                            }
                        }
                        if (i < str.Length && (str[i] == '+' || str[i] == '-'))
                        {
                            if (str[i] == '-') imIsNeg = true; // проверка на отрицательность мнимой части
                            i++;
                            wasDot = false;
                            if (i < str.Length && str[i] >= '0' && str[i] <= '9')
                            {
                                while (i < str.Length && str[i] >= '0' && str[i] <= '9')// считывание мнимной части
                                {
                                    i++;
                                }
                                if (i < str.Length && str[i] == '.')
                                {
                                    wasDot = true;
                                    i++;
                                    if (wasDot && i < str.Length && !(str[i] >= '0' && str[i] <= '9')) return false;
                                    while (i < str.Length && str[i] >= '0' && str[i] <= '9') //считываение вещественной части
                                    {
                                        i++;
                                    }
                                }
                                if (i == str.Length - 1 && str[i] == 'i') return true;
                                else return false;
                            }
                            else
                            {
                                if (wasDot) return false;
                                if (i < str.Length && str[i] == 'i') return true;
                                else return false;
                            }
                        }
                        else
                        {
                            if (i == str.Length) return true;
                            else
                            {
                                if (str[i] == 'i' && str.Length - 1 == i) return true;
                                return false;
                            }
                        }
                    }
                    else return false;
                }
                else
                {
                    if (i < str.Length && str[i] == 'i') return true;
                    return false;
                }
            }
            else return false;
        }

        public void refreshButtons()
        {
            coeff1Name.ForeColor = Color.Gray;
            coeff2Name.ForeColor = Color.Gray;

            root1.ForeColor = Color.Gray;
            root2.ForeColor = Color.Gray;

            coeff1Name.Text = "Коэфф.";
            coeff2Name.Text = "Коэфф.";

            coeff1TextBox.Text = "";
            coeff2TextBox.Text = "";

            rootBox1.Text = "";
            rootBox2.Text = "";

            sigmaBox1.Text = "";
            sigmaBox2.Text = "";
            sigmaBox3.Text = "";

            kBox1.Text = "";
            kBox2.Text = "";
            kBox3.Text = "";

            qValueBox.Text = "";
            iValueBox.Text = "";

            coeff1TextBox.Enabled = false;
            coeff2TextBox.Enabled = false;

            rootBox1.Enabled = false;
            rootBox2.Enabled = false;

            lipBox0.Enabled = false;
            lipBox1.Enabled = false;

            formulaPic1.Visible = false;
            formulaPic2.Visible = false;
            diffurPic1.Visible = false;
            diffurPic2.Visible = false;

            if (is1)
            {
                coeff1Name.ForeColor = Color.Black;
                coeff2Name.ForeColor = Color.Black;

                root1.ForeColor = Color.Black;

                l0Name.ForeColor = Color.Black;
                l1Name.ForeColor = Color.Black;

                coeff1Name.Text = "a0";
                coeff2Name.Text = "a1";

                coeff1TextBox.Enabled = true;
                coeff2TextBox.Enabled = true;

                rootBox1.Enabled = true;

                lipBox0.Enabled = true;
                lipBox1.Enabled = true;

                iValueBox.Visible = false;
                iCheckBox.Visible = false;
                iNameLabel.Visible = false;
                iDoneLabel.Visible = false;

                kBox1.Visible = false;
                kBox2.Visible = false;
                kBox3.Visible = false;
                kLabel1.Visible = false;
                kLabel2.Visible = false;
                kLabel3.Visible = false;
                iBlockLabel.Visible = false;

                formulaPic1.Visible = true;
                diffurPic1.Visible  = true;
            }
            else if (is2)
            {
                coeff1Name.ForeColor = Color.Black;
                coeff2Name.ForeColor = Color.Black;

                root1.ForeColor = Color.Black;
                root2.ForeColor = Color.Black;

                l0Name.ForeColor = Color.Black;
                l1Name.ForeColor = Color.Black;

                coeff1Name.Text = "a";
                coeff2Name.Text = "b";

                coeff1TextBox.Enabled = true;
                coeff2TextBox.Enabled = true;

                rootBox1.Enabled = true;
                rootBox2.Enabled = true;

                lipBox0.Enabled = true;
                lipBox1.Enabled = true;

                iValueBox.Visible  = true;
                iCheckBox.Visible  = true;
                iNameLabel.Visible = true;
                iDoneLabel.Visible = true;

                kBox1.Visible       = true;
                kBox2.Visible       = true;
                kBox3.Visible       = true;
                kLabel1.Visible     = true;
                kLabel2.Visible     = true;
                kLabel3.Visible     = true;
                iBlockLabel.Visible = true;

                formulaPic2.Visible = true;
                diffurPic2.Visible  = true;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            selectN.Items.Add("1");
            selectN.Items.Add("2");

            qualityBox.Items.Add("1");
            qualityBox.Items.Add("2");
            qualityBox.Items.Add("3");
            qualityBox.Items.Add("4");
            qualityBox.Items.Add("5");

            selectN.DropDownStyle = ComboBoxStyle.DropDownList;
            selectN.SelectedIndexChanged += selectN_SelectedIndexChanged;

            qualityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            qualityBox.SelectedIndexChanged += qualityBox_SelectedIndexChanged;

            errMsg.Text = "";
            errMsgL.Text = "";
            rootStateLabel.Text = "";
            qDoneLabel.Text = "";
            iDoneLabel.Text = "";
            AnswerLabel.Text = "";
            refreshButtons();
        }

        void selectN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = selectN.SelectedItem.ToString();
            if (selectedState == "1")
            {
                is1 = true;
                is2 = false;
            }
            else if (selectedState == "2")
            {
                is1 = false;
                is2 = true;
            }
            errMsg.Text = "";
            errMsgL.Text = "";
            AnswerLabel.Text = "";
            rootStateLabel.Text = "";
            refreshButtons();
        }

        void qualityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = qualityBox.SelectedItem.ToString();
            if (selectedState != "")
            {
                RoNum = (int)(toDouble(selectedState));
            }
            else RoNum = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool coeffOk;

            k0 = k1 = k2 = 0;

            if (is1)
            {
                string aa0 = coeff1TextBox.Text;
                string aa1 = coeff2TextBox.Text;

                coeffOk = isComplex(aa0) && isComplex(aa1);

                if (!coeffOk) errMsg.Text = "Один или несколько коэффициентов недопустимы/пусты!";
                else errMsg.Text = "";

                if (coeffOk)
                {
                    Complex a0 = toComplex(aa0);
                    Complex a1 = toComplex(aa1);
                    if (a0 != 0 && a1 != 0)
                    {
                        Complex lambd = -(a1 / a0);

                        string l1disp = Math.Round(lambd.Real, RoNum).ToString();
                        if (lambd.Imaginary > 0) l1disp += "+" + Math.Round(lambd.Imaginary, RoNum).ToString() + "i";
                        else if (lambd.Imaginary < 0) l1disp += Math.Round(lambd.Imaginary, RoNum).ToString() + "i";

                        rootBox1.Text = l1disp;

                        sigma0 = 1 / (a0.Magnitude * lambd.Magnitude);
                        sigma1 = lambd.Magnitude / (a0.Magnitude * lambd.Magnitude);
                        sigma2 = a1.Magnitude * sigma0;

                        sigmaBox1.Text = Math.Round(sigma0, RoNum).ToString();
                        sigmaBox2.Text = Math.Round(sigma1, RoNum).ToString();
                        sigmaBox3.Text = Math.Round(sigma2, RoNum).ToString();

                        
                    }
                    else
                    {
                        errMsg.Text = "Один или несколько коэффициентов недопустимы/пусты!";
                    }
                }
            }
            else if (is2)
            {
                string aa = coeff1TextBox.Text;
                string bb = coeff2TextBox.Text;

                coeffOk = isDouble(aa) && isDouble(bb);

                if (!coeffOk) errMsg.Text = "Один или несколько коэффициентов недопустимы/пусты!";
                else errMsg.Text = "";

                if (coeffOk)
                {
                    double a = toDouble(aa);
                    double b = toDouble(bb);
                    if(a!=0 && b!=0)
                    {
                        double d = (a * a) / 4 - b;

                        if (d > 0)
                        {
                            double lambd1 = -a / 2 + Math.Sqrt(d);
                            double lambd2 = -a / 2 - Math.Sqrt(d);

                            rootBox1.Text = Math.Round(lambd1, RoNum).ToString();
                            rootBox2.Text = Math.Round(lambd2, RoNum).ToString();

                            if (b <= (a * a) / 2) sigma0 = 1 / Math.Abs(b);
                            else sigma0 = 1 / (Math.Abs(a) * Math.Sqrt(-d));

                            if (b > 0) sigma1 = 1 / Math.Abs(a);
                            else sigma1 = 1 / Math.Sqrt(4 * Math.Abs(b) + a * a);

                            sigma2 = Math.Abs(b) * sigma0;

                            rootStateLabel.Text = "Случай разных корней";

                            sigmaBox1.Text = Math.Round(sigma0, RoNum).ToString();
                            sigmaBox2.Text = Math.Round(sigma1, RoNum).ToString();
                            sigmaBox3.Text = Math.Round(sigma2, RoNum).ToString();

                            k0 = Math.Round(1 / Math.Abs(lambd1 * lambd2), RoNum);

                            if (lambd1 * lambd2 > 0)
                            {
                               k1 = Math.Round(2 * Math.Pow(Math.Abs(lambd1), Math.Abs(lambd1) / (Math.Abs(lambd2) - Math.Abs(lambd1))) * Math.Pow(Math.Abs(lambd2), Math.Abs(lambd2) / (Math.Abs(lambd1) - Math.Abs(lambd2))), RoNum);

                                double pow1 = 2 * lambd2 / (lambd2 - lambd1);
                                double pow2 = -a / (lambd2 - lambd1);
                                double pow3 = 2 * lambd1 / (lambd2 - lambd1);

                                double lambdp = Math.Abs(lambd1);
                                double lambdn = Math.Abs(lambd2);

                                k2 = Math.Round(2 * (1-(Math.Pow(lambdp,pow1)/Math.Pow(lambdn,pow2) - Math.Pow(lambdp, pow2) / Math.Pow(lambdn, pow3)) /(lambd1-lambd2)), RoNum);
                            }
                            else if (lambd1 * lambd2 < 0)
                            {
                                k1 = 2 / Math.Abs(lambd1 - lambd2);
                                k2 = 2;
                            }
                        }
                        else if (d == 0)
                        {
                            double lambd = -a / 2;

                            rootBox1.Text = Math.Round(lambd, RoNum).ToString();
                            rootBox2.Text = Math.Round(lambd, RoNum).ToString();

                            if (b <= (a * a) / 2) sigma0 = 1 / Math.Abs(b);
                            else sigma0 = 1 / (Math.Abs(a) * Math.Sqrt(-d));

                            if (b > 0) sigma1 = 1 / Math.Abs(a);
                            else sigma1 = 1 / Math.Sqrt(4 * Math.Abs(b) + a * a);

                            sigma2 = Math.Abs(b) * sigma0;

                            rootStateLabel.Text = "Случай кратных корней";

                            sigmaBox1.Text = Math.Round(sigma0, RoNum).ToString();
                            sigmaBox2.Text = Math.Round(sigma1, RoNum).ToString();
                            sigmaBox3.Text = Math.Round(sigma2, RoNum).ToString();

                            if (isDouble(rootBox1.Text))
                            {
                                k0 = Math.Round(1 / Math.Abs(lambd * lambd), RoNum);
                                k1 = Math.Round(2 / (Math.E * Math.Abs(lambd)), RoNum);
                                k2 = Math.Round(2 * (1 + 1 / (Math.E * Math.E)), RoNum);
                            }

                            kBox1.Text = "";
                            kBox2.Text = "";
                            kBox3.Text = "";

                            kBox1.Text = k0.ToString();
                            kBox2.Text = k1.ToString();
                            kBox3.Text = k2.ToString();
                        }
                        else
                        {
                            Complex lambd1 = new Complex(-a / 2, Math.Sqrt(-d));
                            Complex lambd2 = new Complex(-a / 2, -Math.Sqrt(-d));

                            string l1disp = Math.Round(lambd1.Real, RoNum).ToString();
                            if (lambd1.Imaginary > 0) l1disp += "+" + Math.Round(lambd1.Imaginary, RoNum).ToString()+"i";
                            else if (lambd1.Imaginary < 0) l1disp += Math.Round(lambd1.Imaginary, RoNum).ToString() +"i";

                            string l2disp = Math.Round(lambd2.Real, RoNum).ToString();
                            if (lambd2.Imaginary > 0) l2disp += "+" + Math.Round(lambd2.Imaginary, RoNum).ToString() + "i";
                            else if (lambd2.Imaginary < 0) l2disp += Math.Round(lambd2.Imaginary, RoNum).ToString() + "i";

                            rootBox1.Text = l1disp;
                            rootBox2.Text = l2disp; 

                            if (b <= (a * a) / 2) sigma0 = 1 / Math.Abs(b);
                            else sigma0 = 1 / (Math.Abs(a) * Math.Sqrt(-d));

                            if (b > 0) sigma1 = 1 / Math.Abs(a);
                            else sigma1 = 1 / Math.Sqrt(4 * Math.Abs(b) + a * a);

                            sigma2 = Math.Abs(b) * sigma0;

                            rootStateLabel.Text = "Случай комплексно сопряжённых корней";

                            sigmaBox1.Text = Math.Round(sigma0, RoNum).ToString();
                            sigmaBox2.Text = Math.Round(sigma1, RoNum).ToString();
                            sigmaBox3.Text = Math.Round(sigma2, RoNum).ToString();

                            double alp = lambd1.Real;
                            double bet = lambd2.Imaginary;

                            k0 = Math.Round(1 / ((alp * alp + bet * bet) * Math.Tanh((Math.PI / 2) * Math.Abs(alp / bet))), RoNum);
                            k1 = Math.Round(Math.Pow(Math.E, -(Math.Abs(alp / bet) * Math.Atan(Math.Abs(bet / alp)))) * (1 + 1 / Math.Tanh((Math.PI / 2) * Math.Abs(alp / bet))) / (alp * alp + bet * bet), RoNum);

                            if (Math.Abs(alp) > Math.Abs(bet))
                            {
                                double first, second, arctg;
                                first = Math.Abs(bet) * (3 * alp * alp - bet * bet) / (alp * alp - bet * bet);
                                second = 2 * Math.Abs(bet) * ((1 + Math.Pow(Math.E, -Math.Abs(alp / bet) * Math.PI)) / (1 - Math.Pow(Math.E, -Math.Abs(alp / bet) * 2 * Math.PI)));
                                arctg = Math.Atan(2 * Math.Abs(alp * bet) / (alp * alp - bet * bet));

                                k2 = Math.Round(1 + first - second * Math.Pow(Math.E, -Math.Abs(alp / bet) * arctg), RoNum);
                            }
                            else if (Math.Abs(alp) < Math.Abs(bet))
                            {
                                double first, second, arctg;
                                first = Math.Abs(bet) * (3 * alp * alp - bet * bet) / (alp * alp - bet * bet);
                                second = 2 * Math.Abs(bet) * ((1 + Math.Pow(Math.E, -Math.Abs(alp / bet) * Math.PI)) / (1 - Math.Pow(Math.E, -Math.Abs(alp / bet) * 2 * Math.PI)));
                                arctg = Math.Atan(2 * Math.Abs(alp * bet) / (alp * alp - bet * bet));

                                k2 = Math.Round(1 + first - second * Math.Pow(Math.E, -Math.Abs(alp / bet) * (Math.PI - arctg)), RoNum);
                            }
                            else
                            {
                                k2 = Math.Round(1 - 1 / Math.Abs(2 * alp) + (Math.Pow(Math.E, 3 * Math.PI / 2) + Math.Pow(Math.E, Math.PI / 2)) / (Math.Abs(alp) * (Math.Pow(Math.E, 2 * Math.PI) - 1)), RoNum);
                            }
                        }

                        kBox1.Text = "";
                        kBox2.Text = "";
                        kBox3.Text = "";

                        kBox1.Text = k0.ToString();
                        kBox2.Text = k1.ToString();
                        kBox3.Text = k2.ToString();
                    }
                    else errMsg.Text = "Коэффициент(ы) нулевой(ые)!";
                }
            }
            else 
            {
                errMsg.Text = "Ошибка! Не выбран порядок уравнения!";
                refreshButtons();
            }
        }

        private void coeff1TextBox_TextChanged(object sender, EventArgs e)
        {
            string str = coeff1TextBox.Text;
            if ((isComplex(str) && is1) || (isDouble(str) && is2)) checkCoeff1.Checked = true;
            else checkCoeff1.Checked = false;
            errMsg.Text = "";
            rootStateLabel.Text = "";
            qDoneLabel.Text = "";
            iDoneLabel.Text = "";
            AnswerLabel.Text = "";
        }

        private void coeff2TextBox_TextChanged(object sender, EventArgs e)
        {
            string str = coeff2TextBox.Text;
            if ((isComplex(str) && is1) || (isDouble(str) && is2)) checkCoeff2.Checked = true;
            else checkCoeff2.Checked = false;
            errMsg.Text = "";
            rootStateLabel.Text = "";
            qDoneLabel.Text = "";
            iDoneLabel.Text = "";
            AnswerLabel.Text = "";
        }

        private void lipBox0_TextChanged(object sender, EventArgs e)
        {
            string str = lipBox0.Text;
            if (isDouble(str)) l0Check.Checked = true;
            else l0Check.Checked = false;
            errMsgL.Text = "";
            qDoneLabel.Text = "";
            iDoneLabel.Text = "";
            AnswerLabel.Text = "";
        }

        private void lipBox1_TextChanged(object sender, EventArgs e)
        {
            string str = lipBox1.Text;
            if (isDouble(str)) l1Check.Checked = true;
            else l1Check.Checked = false;
            errMsgL.Text = "";
            qDoneLabel.Text = "";
            iDoneLabel.Text = "";
            AnswerLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool lipOk;

            string ll0 = lipBox0.Text;
            string ll1 = lipBox1.Text;

            string s0 = sigmaBox1.Text;
            string s1 = sigmaBox2.Text;

            qDoneLabel.Text = "";

            if (s0 == "" || s1 == "") 
            {
                errMsgL.Text = "Постоянные сигма не определены!";
                AnswerLabel.Text = "";
            }
            else
            {
                lipOk = isDouble(ll0) && isDouble(ll1);

                if (!lipOk) errMsgL.Text = "Не все константы вещественные!";
                else
                {
                    double l0 = toDouble(ll0);
                    double l1 = toDouble(ll1);

                    if (l0 >= 0 && l1 >= 0)
                    {
                        double qValue = l0 * sigma0 + l1 * sigma1;
                        double iValue = l0 * k0 + l1 * k1;
                        qCheckBox.Checked = qValue < 1;
                        qValueBox.Text = Math.Round(qValue, RoNum).ToString();
                        iCheckBox.Checked = iValue < 1;
                        iValueBox.Text = Math.Round(iValue, RoNum).ToString();
                        if (qCheckBox.Checked)
                        {
                            qDoneLabel.ForeColor = Color.Green;
                            qDoneLabel.Text = "ВЫПОЛНЕНО";
                        }
                        else
                        {
                            qDoneLabel.ForeColor = Color.Red;
                            qDoneLabel.Text = "НЕ ВЫПОЛНЕНО";
                        }

                        if (iCheckBox.Checked)
                        {
                            iDoneLabel.ForeColor = Color.Green;
                            iDoneLabel.Text = "ВЫПОЛНЕНО";
                        }
                        else
                        {
                            iDoneLabel.ForeColor = Color.Red;
                            iDoneLabel.Text = "НЕ ВЫПОЛНЕНО";
                        }

                        if (qCheckBox.Checked && iCheckBox.Checked)
                        {
                            AnswerLabel.ForeColor = Color.Blue;
                            AnswerLabel.Text = "Уравнение имеет единственное, устойчивое решение x(t). У этого " +
                                               "решения оказываются ограниченными все производные " +
                                               "до 2-го порядка включительно.";
                        }
                        else
                        {
                            AnswerLabel.ForeColor = Color.Red;
                            AnswerLabel.Text = "Не найдено ограниченное решение x(t). У этого решения оказываются " +
                                                "ограниченными все производные до 2-го порядка включительно.";
                        }
                        errMsgL.Text = "";
                    }
                    else
                    { 
                        errMsgL.Text = "Константа(ы) отрицательна(ы)!";
                        AnswerLabel.Text = "";
                    }
                }
            }
        }
    }
}
