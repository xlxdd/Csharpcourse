using System;
using System.Collections;
using System.Globalization;
using static System.Globalization.NumberStyles;
using static System.Net.Mime.MediaTypeNames;

namespace cal
{
    public partial class Form1 : Form
    {
        int maxLength = 8;
        double op1 = 0;
        double op2 = 0;
        string op = "";
        double res = 0;

        bool havedot = false;

        string str = "";

        int status = 0;//状态码
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //text部分
        //数字键
        private void num_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            str = b.Text;
            switch (status)
            {
                case 0:
                    status = 0;
                    if (enter.Text == "0")
                    {
                        enter.Text = str;
                    }
                    else
                    {
                        if (enter.Text.Length < maxLength)
                        {
                            enter.Text += str;
                        }
                    }
                    break;
                case 1:
                    status = 0;
                    enter.Text = str;
                    havedot = false;
                    break;
                case 2:
                    status = 2;
                    if (enter.Text == "0")
                    {
                        enter.Text = str;
                    }
                    else
                    {
                        if (enter.Text.Length < maxLength)
                        {
                            enter.Text += str;
                        }
                    }
                    break;
                case 3:
                    status = 2;
                    enter.Text = str;
                    havedot = false;
                    break;
                case 4:
                    status = 0;
                    enter.Text = str;
                    havedot = false;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default:
                    break;
            }
        }
        //退格
        private void del_Click(object sender, EventArgs e)
        {
            string c = enter.Text.Substring(enter.Text.Length - 1);
            switch (status)
            {
                case 0:
                    status = 0;
                    if (enter.Text.Length == 1)
                    {
                        enter.Text = "0";
                    }
                    else
                    {
                        enter.Text = enter.Text.Substring(enter.Text.Length - 1);
                        if (c == ".")
                        {
                            havedot = false;
                        }
                    }
                    break;
                //这三种状态下退格键无效
                //case 1:
                //    status = 0;
                //    break;
                case 2:
                    status = 2;
                    if (enter.Text.Length == 1)
                    {
                        enter.Text = "0";
                    }
                    else
                    {
                        enter.Text = enter.Text.Substring(0, enter.Text.Length - 1);
                        if (c == ".")
                        {
                            havedot = false;
                        }
                    }
                    break;
                //case 3:
                //    status = 2;
                //    break;
                //case 4:
                //    status = 0;
                //    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default:
                    break;
            }
        }

        //小数点
        private void dot_Click(object sender, EventArgs e)
        {
            if (havedot == true)
            {
                return;
            }
            switch (status)
            {
                case 0:
                    status = 0;
                    if (enter.Text.Length < maxLength)
                    {
                        enter.Text += ".";
                        havedot = true;
                    }
                    break;
                case 1:
                    status = 0;
                    enter.Text = "0";
                    break;
                case 2:
                    status = 2;
                    if (enter.Text.Length < maxLength)
                    {
                        enter.Text += ".";
                        havedot = true;
                    }
                    break;
                case 3:
                    status = 2;
                    enter.Text = "0";
                    break;
                case 4:
                    status = 0;
                    enter.Text = "0";
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default:
                    break;
            }
        }

        //加减乘除 二元运算符
        private void symbol_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (status)
            {
                case 0:
                case 1:
                    status = 2;
                    op = b.Text;
                    try
                    {
                        op1 = double.Parse(enter.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }

                    label1.Text = op1.ToString();
                    if (label1.Text.Length > 20)
                    {
                        label1.Text = label1.Text.Substring(20);
                    }
                    label2.Text = op;
                    enter.Text = "0";
                    break;
                case 2:
                case 3:
                    status = 2;
                    try
                    {
                        op2 = double.Parse(enter.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }
                    switch (op)
                    {
                        case "+":
                            res = op1 + op2;
                            break;
                        case "-":
                            res = op1 - op2;
                            break;
                        case "*":
                            res = op1 * op2;
                            break;
                        case "÷":
                            if (op2 == 0)
                            {
                                enter.Text = "ERROR";
                                status = 5;
                                return;
                            }
                            res = op1 / op2;
                            break;
                        default: break;
                    }
                    op = b.Text;
                    op1 = res;
                    label1.Text = op1.ToString();
                    if (label1.Text.Length > 20)
                    {
                        label1.Text = label1.Text.Substring(20);
                    }
                    label2.Text = op;
                    enter.Text = "0";
                    break;
                case 4:
                    op = b.Text;
                    status = 2;
                    try
                    {
                        op1 = double.Parse(enter.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }
                    label1.Text = op1.ToString();
                    if (label1.Text.Length > 20)
                    {
                        label1.Text = label1.Text.Substring(20);
                    }
                    label2.Text = op;
                    enter.Text = "0";
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
        }



        //一元运算符部分
        //正负号
        private void minus_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    status = 1;
                    break;
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 3;
                    break;
                case 3:
                    status = 3;
                    break;
                case 4:
                    status = 4;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
            try
            {
                op1 = double.Parse(enter.Text);
            }
            catch (FormatException)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            res = op1 * (-1);
            enter.Text = res.ToString();
            if (enter.Text.Length > 20)
            {
                enter.Text = enter.Text.Substring(20);
            }
        }

        //百分号
        private void percent_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    status = 1;
                    break;
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 3;
                    break;
                case 3:
                    status = 3;
                    break;
                case 4:
                    status = 4;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
            try
            {
                op1 = double.Parse(enter.Text);
            }
            catch (FormatException)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            res = op1 * (0.01);
            enter.Text = res.ToString();
            if (enter.Text.Length > 20)
            {
                enter.Text = enter.Text.Substring(20);
            }
        }
        //  1/x
        private void inverse_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    status = 1;
                    break;
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 3;
                    break;
                case 3:
                    status = 3;
                    break;
                case 4:
                    status = 4;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
            try
            {
                op1 = double.Parse(enter.Text);
            }
            catch (FormatException)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            if (op1 == 0)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            res = 1 / op1;
            enter.Text = res.ToString();
            if (enter.Text.Length > 20)
            {
                enter.Text = enter.Text.Substring(0, 20);
            }
        }
        // x^2
        private void pow_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    status = 1;
                    break;
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 3;
                    break;
                case 3:
                    status = 3;
                    break;
                case 4:
                    status = 4;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
            try
            {
                op1 = double.Parse(enter.Text);
            }
            catch (FormatException)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            res = op1 * op1;
            enter.Text = res.ToString();
            if (enter.Text.Length > 20)
            {
                enter.Text = enter.Text.Substring(0, 20);
            }
        }
        // sqrt(x)
        private void root_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    status = 1;
                    break;
                case 1:
                    status = 1;
                    break;
                case 2:
                    status = 3;
                    break;
                case 3:
                    status = 3;
                    break;
                case 4:
                    status = 4;
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
            try
            {
                op1 = double.Parse(enter.Text);
            }
            catch (FormatException)
            {
                enter.Text = "ERROR";
                status = 5;
                return;
            }
            if (op1 < 0)
            {
                status = 5;
                enter.Text = "ERROR";
                return;
            }
            res = Math.Sqrt(op1);
            enter.Text = res.ToString();
            if (enter.Text.Length > 20)
            {
                enter.Text = enter.Text.Substring(0, 20);
            }
        }

        //清除
        private void clear_Click(object sender, EventArgs e)
        {
            status = 0;
            enter.Text = "0";
            label1.Text = "";
            label2.Text = "";
            havedot = false;
        }

        //等于号
        private void equ_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                case 1:
                    break;
                case 2:
                case 3:
                    status = 4;
                    try
                    {
                        op1 = double.Parse(label1.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }
                    try
                    {
                        op2 = double.Parse(enter.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }

                    switch (op)
                    {
                        case "+":
                            res = op1 + op2;
                            break;
                        case "-":
                            res = op1 - op2;
                            break;
                        case "*":
                            res = op1 * op2;
                            break;
                        case "÷":
                            if (op2 == 0)
                            {
                                enter.Text = "ERROR";
                                status = 5;
                                return;
                            }
                            res = op1 / op2;
                            break;
                        default: break;
                    }
                    op1 = res;
                    label1.Text = "";
                    label2.Text = "";
                    enter.Text = res.ToString();
                    if (enter.Text.Length > 20)
                    {
                        enter.Text = enter.Text.Substring(20);
                    }
                    break;
                case 4:
                    status = 4;
                    try
                    {
                        op1 = double.Parse(enter.Text);
                    }
                    catch (FormatException)
                    {
                        enter.Text = "ERROR";
                        status = 5;
                        return;
                    }
                    switch (op)
                    {
                        case "+":
                            res = op1 + op2;
                            break;
                        case "-":
                            res = op1 - op2;
                            break;
                        case "*":
                            res = op1 * op2;
                            break;
                        case "÷":
                            if (op2 == 0)
                            {
                                enter.Text = "ERROR";
                                status = 5;
                                return;
                            }
                            res = op1 / op2;
                            break;
                        default: break;
                    }
                    op1 = res;
                    enter.Text = res.ToString();
                    if (enter.Text.Length > 20)
                    {
                        enter.Text = enter.Text.Substring(20);
                    }
                    break;
                case 5:
                    status = 0;
                    enter.Text = "0";
                    label1.Text = "";
                    label2.Text = "";
                    havedot = false;
                    break;
                default: break;
            }
        }
    }
}