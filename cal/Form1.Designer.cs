namespace cal
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            num0 = new Button();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            enter = new Label();
            add = new Button();
            sub = new Button();
            mul = new Button();
            div = new Button();
            del = new Button();
            equ = new Button();
            dot = new Button();
            percent = new Button();
            clear = new Button();
            clearE = new Button();
            minus = new Button();
            inverse = new Button();
            pow = new Button();
            root = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // num0
            // 
            num0.Location = new Point(100, 400);
            num0.Name = "num0";
            num0.Size = new Size(100, 50);
            num0.TabIndex = 9;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num_Click;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(0, 250);
            num1.Name = "num1";
            num1.Size = new Size(100, 50);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num_Click;
            // 
            // num2
            // 
            num2.Location = new Point(100, 250);
            num2.Name = "num2";
            num2.Size = new Size(100, 50);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num_Click;
            // 
            // num3
            // 
            num3.Location = new Point(200, 250);
            num3.Name = "num3";
            num3.Size = new Size(100, 50);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num_Click;
            // 
            // num4
            // 
            num4.Location = new Point(0, 300);
            num4.Name = "num4";
            num4.Size = new Size(100, 50);
            num4.TabIndex = 3;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num_Click;
            // 
            // num5
            // 
            num5.Location = new Point(100, 300);
            num5.Name = "num5";
            num5.Size = new Size(100, 50);
            num5.TabIndex = 4;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num_Click;
            // 
            // num6
            // 
            num6.Location = new Point(200, 300);
            num6.Name = "num6";
            num6.Size = new Size(100, 50);
            num6.TabIndex = 5;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num_Click;
            // 
            // num7
            // 
            num7.Location = new Point(0, 350);
            num7.Name = "num7";
            num7.Size = new Size(100, 50);
            num7.TabIndex = 6;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num_Click;
            // 
            // num8
            // 
            num8.Location = new Point(100, 350);
            num8.Name = "num8";
            num8.Size = new Size(100, 50);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num_Click;
            // 
            // num9
            // 
            num9.Location = new Point(200, 350);
            num9.Name = "num9";
            num9.Size = new Size(100, 50);
            num9.TabIndex = 8;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num_Click;
            // 
            // enter
            // 
            enter.BackColor = SystemColors.Control;
            enter.BorderStyle = BorderStyle.FixedSingle;
            enter.Dock = DockStyle.Top;
            enter.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            enter.ForeColor = SystemColors.ActiveCaptionText;
            enter.Location = new Point(0, 0);
            enter.Name = "enter";
            enter.Size = new Size(400, 138);
            enter.TabIndex = 0;
            enter.Text = "0";
            enter.TextAlign = ContentAlignment.BottomRight;
            // 
            // add
            // 
            add.Location = new Point(300, 300);
            add.Name = "add";
            add.Size = new Size(100, 50);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += symbol_Click;
            // 
            // sub
            // 
            sub.Location = new Point(300, 350);
            sub.Name = "sub";
            sub.Size = new Size(100, 50);
            sub.TabIndex = 16;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += symbol_Click;
            // 
            // mul
            // 
            mul.Location = new Point(300, 250);
            mul.Name = "mul";
            mul.Size = new Size(100, 50);
            mul.TabIndex = 13;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            mul.Click += symbol_Click;
            // 
            // div
            // 
            div.Location = new Point(300, 200);
            div.Name = "div";
            div.Size = new Size(100, 50);
            div.TabIndex = 14;
            div.Text = "÷";
            div.UseVisualStyleBackColor = true;
            div.Click += symbol_Click;
            // 
            // del
            // 
            del.Location = new Point(200, 200);
            del.Name = "del";
            del.Size = new Size(100, 50);
            del.TabIndex = 19;
            del.Text = "Del";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // equ
            // 
            equ.Location = new Point(300, 400);
            equ.Name = "equ";
            equ.Size = new Size(100, 50);
            equ.TabIndex = 17;
            equ.Text = "=";
            equ.UseVisualStyleBackColor = true;
            equ.Click += equ_Click;
            // 
            // dot
            // 
            dot.Location = new Point(200, 400);
            dot.Name = "dot";
            dot.Size = new Size(100, 50);
            dot.TabIndex = 12;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // percent
            // 
            percent.Location = new Point(0, 150);
            percent.Name = "percent";
            percent.Size = new Size(100, 50);
            percent.TabIndex = 24;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += percent_Click;
            // 
            // clear
            // 
            clear.Location = new Point(100, 200);
            clear.Name = "clear";
            clear.Size = new Size(100, 50);
            clear.TabIndex = 18;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // clearE
            // 
            clearE.Enabled = false;
            clearE.Location = new Point(0, 200);
            clearE.Name = "clearE";
            clearE.Size = new Size(100, 50);
            clearE.TabIndex = 20;
            clearE.Text = "CE";
            clearE.UseVisualStyleBackColor = true;
            clearE.Click += clear_Click;
            // 
            // minus
            // 
            minus.Location = new Point(0, 400);
            minus.Name = "minus";
            minus.Size = new Size(100, 50);
            minus.TabIndex = 11;
            minus.Text = "+/-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // inverse
            // 
            inverse.Location = new Point(300, 150);
            inverse.Name = "inverse";
            inverse.Size = new Size(100, 50);
            inverse.TabIndex = 21;
            inverse.Text = "1/x";
            inverse.UseVisualStyleBackColor = true;
            inverse.Click += inverse_Click;
            // 
            // pow
            // 
            pow.Location = new Point(200, 150);
            pow.Name = "pow";
            pow.Size = new Size(100, 50);
            pow.TabIndex = 22;
            pow.Text = "^2";
            pow.UseVisualStyleBackColor = true;
            pow.Click += pow_Click;
            // 
            // root
            // 
            root.Location = new Point(100, 150);
            root.Name = "root";
            root.Size = new Size(100, 50);
            root.TabIndex = 23;
            root.Text = "√";
            root.UseVisualStyleBackColor = true;
            root.Click += root_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 36);
            label1.TabIndex = 25;
            label1.Text = "\r\n";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.BackColor = SystemColors.ControlLight;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(332, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 26;
            label2.Text = "\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 453);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(num0);
            Controls.Add(enter);
            Controls.Add(add);
            Controls.Add(sub);
            Controls.Add(mul);
            Controls.Add(div);
            Controls.Add(equ);
            Controls.Add(percent);
            Controls.Add(clear);
            Controls.Add(clearE);
            Controls.Add(del);
            Controls.Add(minus);
            Controls.Add(dot);
            Controls.Add(inverse);
            Controls.Add(root);
            Controls.Add(pow);
            MaximumSize = new Size(418, 500);
            MinimumSize = new Size(418, 500);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //数字
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        //窗口
        private System.Windows.Forms.Label enter;
        //加减乘除
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;

        //退格键
        private System.Windows.Forms.Button del;
        //等于
        private System.Windows.Forms.Button equ;
        //小数点
        private System.Windows.Forms.Button dot;
        //百分号
        private System.Windows.Forms.Button percent;
        //C
        private System.Windows.Forms.Button clear;
        //CE
        private System.Windows.Forms.Button clearE;
        //负数
        private System.Windows.Forms.Button minus;

        //倒数
        private System.Windows.Forms.Button inverse;
        //根号
        private System.Windows.Forms.Button root;
        //乘方
        private System.Windows.Forms.Button pow;
        private Label label1;
        private Label label2;
    }
}

