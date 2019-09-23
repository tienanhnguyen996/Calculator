using System;
using System.Windows.Forms;

namespace Caculator
{
    
    public partial class Form1 : Form
    {
        #region Khai Báo Biến

        string Input ,Result;
        string a, b;
        char dauCuoi;
        bool isInputa, isInputb, isAdda, isAddb, isDone;
        
        #endregion
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        #region Xử lí Input
        private void Btn0_Click(object sender, EventArgs e)
        {
            if(isDone == true)
            {
                Reset();
                isDone = false;
            }
            if(isInputa == true)
            {
                a += "0";
                ShowResult(a);
            }
            else
            {
                if(isInputb == true)
                {
                    b += "0";
                    ShowResult(b);
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "1";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "1";
                    ShowResult(b);
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "2";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "2";
                    ShowResult(b);
                }
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "3";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "3";
                    ShowResult(b);
                }
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "4";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "4";
                    ShowResult(b);
                }
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "5";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "5";
                    ShowResult(b);
                }
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "6";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "6";
                    ShowResult(b);
                }
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "7";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "7";
                    ShowResult(b);
                }
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "8";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "8";
                    ShowResult(b);
                }
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (isDone == true)
            {
                Reset();
                isDone = false;
            }
            if (isInputa == true)
            {
                a += "9";
                ShowResult(a);
            }
            else
            {
                if (isInputb == true)
                {
                    b += "9";
                    ShowResult(b);
                }
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if(isDone ==true)
            {
                isDone = false;
                string luu = Result;
                Reset();
                Result = luu;
                a = Result;
            }
            if(String.IsNullOrEmpty(a) == false)
            {
                if (isInputa == true && isInputb == false)
                {
                    Result = a;
                    if(isAdda == false)
                    {
                        Input += a;
                    }
                    isInputb = true;
                    isInputa = false;
                }
                else
                {
                    if(isInputa == false&&isInputb==true)
                    {
                        Caculate(Result, b);
                        if(isAddb == false)
                        {
                            Input += b;
                        }
                        else
                        {
                            isAddb = false;
                        }
                        b = "";
                    }
                }
                if (Input[Input.Length - 1] == ' ')
                {
                    Input = Input.Remove(Input.Length - 3, 3);
                }
                Input += " + ";
                dauCuoi = '+';
                ShowResult(Result);
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isInputa == true && isInputb == false)
                {
                    Result = a;
                    if (isAdda == false)
                    {
                        Input += a;
                    }
                    isInputb = true;
                    isInputa = false;
                }
                else
                {
                    if (isInputa == false && isInputb == true)
                    {
                        Caculate(Result, b);
                        if (isAddb == false)
                        {
                            Input += b;
                        }
                        else
                        {
                            isAddb = false;
                        }
                        b = "";
                    }
                }
                if (Input[Input.Length - 1] == ' ')
                {
                    Input = Input.Remove(Input.Length - 3, 3);
                }
                Input += " - ";
                dauCuoi = '-';
                ShowResult(Result);
            }
        }

        private void BtnMultiplied_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isInputa == true && isInputb == false)
                {
                    Result = a;
                    if (isAdda == false)
                    {
                        Input += a;
                    }
                    isInputb = true;
                    isInputa = false;
                }
                else
                {
                    if (isInputa == false && isInputb == true)
                    {
                        Caculate(Result, b);
                        if (isAddb == false)
                        {
                            Input += b;
                        }
                        else
                        {
                            isAddb = false;
                        }
                        b = "";
                    }
                }
                if (Input[Input.Length - 1] == ' ')
                {
                    Input = Input.Remove(Input.Length - 3, 3);
                }
                Input += " × ";
                dauCuoi = '×';
                ShowResult(Result);
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
                if (String.IsNullOrEmpty(a) == false)
                {
                    if (isInputa == true && isInputb == false)
                    {
                        Result = a;
                        if (isAdda == false)
                        {
                            Input += a;
                        }
                        isInputb = true;
                        isInputa = false;
                    }
                    else
                    {
                        if (isInputa == false && isInputb == true)
                        {
                            Caculate(Result, b);
                            if (isAddb == false)
                            {
                                Input += b;
                            }
                            else
                            {
                                isAddb = false;
                            }
                            b = "";
                        }
                    }
                    if (Input[Input.Length - 1] == ' ')
                    {
                        Input = Input.Remove(Input.Length - 3, 3);
                    }
                    Input += " ÷ ";
                    dauCuoi = '÷';
                    ShowResult(Result);
                }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if(isDone == false)
            {
                
                Caculate(Result, b);
                if (Input.Equals(""))
                {
                    Input = a;
                }
                if (b.Equals("") == false&&isAddb == false)
                {
                    Input += b;
                }
                Input += " = ";
                ShowResult(Result);
                isDone = true;
            }
        }

        private void BtnDeleteOne_Click(object sender, EventArgs e)
        {
            if(isInputa == true&&a.Equals("")==false)
            {
                a = a.Remove(a.Length - 1, 1);
                ShowResult(a);
            }
            if(isInputb == true&&b.Equals("")==false)
            {
                b = b.Remove(b.Length - 1, 1);
                ShowResult(b);
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            Reset();
            ShowResult("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isInputa == true && a.Equals("") == false)
                {
                    a += ".";
                    ShowResult(a);
                }
                else
                {
                    if (isInputb == true && b.Equals("") == false)
                    {
                        b += ".";
                        ShowResult(b);
                    }
                }
            }
            
        }

        private void BtnDeleteAns_Click(object sender, EventArgs e)
        {
            if(isInputa == true)
            {
                a = "";
            }
            if(isInputb == true)
            {
                b = "";
            }
            ShowResult("0");
        }

        private void BtnNegate_Click(object sender, EventArgs e)
        {
            if(isDone == true)
            {
                Input = "negate(" + Result + ")";
                if (Result[0]!='-')
                {
                    Result = "-" + Result;
                }
                else
                {
                    Result = Result.Remove(0, 1);
                }
                ShowResult(Result);
            }
            else
            {
                if (isInputa == true && String.IsNullOrEmpty(a) == false)
                {
                    if (a[0] != '-')
                    {
                        a = "-" + a;
                        ShowResult(a);
                    }
                    else
                    {
                        a = a.Remove(0, 1);
                        ShowResult(a);
                    }
                }
                if (isInputb == true && String.IsNullOrEmpty(b) == false)
                {
                    if (b[0] != '-')
                    {
                        b = "-" + b;
                        ShowResult(b);
                    }
                    else
                    {
                        b = b.Remove(0, 1);
                        ShowResult(b);
                    }
                }
            }
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isDone == true)
                {
                    Input = Result + "% = ";
                    double kq = double.Parse(Result) / 100;
                    Result = kq.ToString();
                    ShowResult(Result);
                }
                else
                {
                    if (isInputa == true)
                    {
                        Input += a + "%";
                        isAdda = true;
                        double kq =double.Parse(a) /100;
                        a = kq.ToString();
                        ShowResult(a);
                    }
                    if (isInputb == true && String.IsNullOrEmpty(b) == false)
                    {
                        Input += b + "%";
                        isAddb = true;
                        double kq = double.Parse(b) / 100;
                        b = kq.ToString();
                        ShowResult(b);
                    }
                }
            }
        }

        private void BtnSquareroot_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isDone == true)
                {
                    Input = "√(" + Result + ") = ";
                    double kq = Math.Sqrt(double.Parse(Result));
                    Result = kq.ToString();
                    ShowResult(Result);
                }
                else
                {
                    if (isInputa == true)
                    {
                        Input += "√(" + a + ")";
                        isAdda = true;
                        double kq = Math.Sqrt(double.Parse(a));
                        a = kq.ToString();
                        ShowResult(a);
                    }
                    if (isInputb == true && String.IsNullOrEmpty(b) == false)
                    {
                        Input += "√(" + b + ")";
                        isAddb = true;
                        double kq = Math.Sqrt(double.Parse(b));
                        b = kq.ToString();
                        ShowResult(b);
                    }
                }
            }
        }

        private void Btnsquared_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(a) == false)
            {
                if (isDone == true)
                {
                    Input = Result + "² = ";
                    double kq = Math.Pow(double.Parse(Result),2);
                    Result = kq.ToString();
                    ShowResult(Result);
                }
                else
                {
                    if (isInputa == true)
                    {
                        Input += a + "²";
                        isAdda = true;
                        double kq = Math.Pow(double.Parse(a),2);
                        a = kq.ToString();
                        ShowResult(a);
                    }
                    if (isInputb == true && String.IsNullOrEmpty(b) == false)
                    {
                        Input += b + "²";
                        isAddb = true;
                        double kq = Math.Pow(double.Parse(b), 2);
                        b = kq.ToString();
                        ShowResult(b);
                    }
                }
            }
        }

        private void BtnMotphanX_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(a)==false)
            {
                if(isDone == true)
                {
                    Input = "1/(" + Result + ") = ";
                    float kq = 1 / float.Parse(Result);
                    Result = kq.ToString();
                    ShowResult(Result);
                }
                else
                {
                    if(isInputa == true)
                    {
                        Input += "1/(" + a + ")";
                        isAdda = true;
                        float kq = 1 / float.Parse(a);
                        a = kq.ToString();
                        ShowResult(a);
                    }
                    if (isInputb == true&&String.IsNullOrEmpty(b) == false)
                    {
                        Input += "1/(" + b + ")";
                        isAddb = true;
                        float kq = 1 / float.Parse(b);
                        b = kq.ToString();
                        ShowResult(b);
                    }
                }
            }
        }

        #endregion

        #region Hàm
        private void ShowResult(string strResult)
        {
            result.Text = strResult;
            hasInput.Text = Input;
        }
        private void Caculate(string Numa, string Numb)
        {
            if (isInputa == true && isInputb == false)
            {
                if (a.Equals("") == true)
                {
                    Result = "";
                }
                else
                {
                    Result = a;
                }
            }
            else
            {
                if(b.Equals("")==false)
                {
                    switch (dauCuoi)
                    {
                        case '+':
                            {
                                float kq = float.Parse(Numa) + float.Parse(Numb);
                                Result = kq.ToString();
                                break;
                            }
                        case '-':
                            {
                                float kq = float.Parse(Numa) - float.Parse(Numb);
                                Result = kq.ToString();
                                break;
                            }
                        case '×':
                            {
                                float kq = float.Parse(Numa) * float.Parse(Numb);
                                Result = kq.ToString();
                                break;
                            }
                        case '÷':
                            {
                                float kq = float.Parse(Numa) / float.Parse(Numb);
                                Result = kq.ToString();
                                break;
                            }
                    }
                }
            }           
        }
        private void Reset()
        {
            isInputa = true;
            isInputb = false;
            isAdda = false;
            isAddb = false;
            a = "";
            b = "";
            Input = "";
            Result = "";
            ShowResult(Result);
        }
        #endregion
    }
}
