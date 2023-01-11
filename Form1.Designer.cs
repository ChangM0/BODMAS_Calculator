using Calculator.CleanClass;
using Calculator.OperatorClass;
using Calculator.OthersClass;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            Calculator.OperatorClass.Equal equal1 = new Calculator.OperatorClass.Equal();
            Calculator.OthersClass.Dot dot1 = new Calculator.OthersClass.Dot();
            Calculator.OthersClass.SwitchNP switchNP1 = new Calculator.OthersClass.SwitchNP();
            Calculator.OperatorClass.Plus plus1 = new Calculator.OperatorClass.Plus();
            Calculator.OperatorClass.Minus minus1 = new Calculator.OperatorClass.Minus();
            Calculator.OperatorClass.Multiply multiply1 = new Calculator.OperatorClass.Multiply();
            Calculator.OperatorClass.Division division1 = new Calculator.OperatorClass.Division();
            Calculator.CleanClass.Clear clear1 = new Calculator.CleanClass.Clear();
            Calculator.CleanClass.BackSpace backSpace1 = new Calculator.CleanClass.BackSpace();
            Calculator.CleanClass.CE ce1 = new Calculator.CleanClass.CE();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPN = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMulitply = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(-2, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(350, 43);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(-2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(350, 39);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.UseWaitCursor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(262, 363);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 75);
            this.button10.TabIndex = 65;
            this.button10.Tag = new SquareRoot();
            this.button10.Text = "√";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonEqual.Location = new System.Drawing.Point(262, 434);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(91, 75);
            this.buttonEqual.TabIndex = 62;
            this.buttonEqual.Tag = new Equal();
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button0.Location = new System.Drawing.Point(87, 363);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(90, 75);
            this.button0.TabIndex = 61;
            this.button0.Tag = new Numbers("0");
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDot.Location = new System.Drawing.Point(174, 363);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(90, 75);
            this.buttonDot.TabIndex = 60;
            this.buttonDot.Tag = new Dot();
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonPN
            // 
            this.buttonPN.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPN.Location = new System.Drawing.Point(-1, 363);
            this.buttonPN.Name = "buttonPN";
            this.buttonPN.Size = new System.Drawing.Size(90, 75);
            this.buttonPN.TabIndex = 59;
            this.buttonPN.Tag = new SwitchNP();
            this.buttonPN.Text = "+/-";
            this.buttonPN.UseVisualStyleBackColor = true;
            this.buttonPN.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPlus.Location = new System.Drawing.Point(262, 291);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(91, 75);
            this.buttonPlus.TabIndex = 58;
            this.buttonPlus.Tag = new Plus();
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(87, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 75);
            this.button2.TabIndex = 57;
            this.button2.Tag = new Numbers("2");
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(174, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 75);
            this.button3.TabIndex = 56;
            this.button3.Tag = new Numbers("3");
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(-1, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 75);
            this.button1.TabIndex = 55;
            this.button1.Tag = new Numbers("1");
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMinus.Location = new System.Drawing.Point(262, 220);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(91, 75);
            this.buttonMinus.TabIndex = 54;
            this.buttonMinus.Tag = new Minus();
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(86, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 75);
            this.button5.TabIndex = 53;
            this.button5.Tag = new Numbers("5");
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(174, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 75);
            this.button6.TabIndex = 52;
            this.button6.Tag = new Numbers("6");
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(-1, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 75);
            this.button4.TabIndex = 51;
            this.button4.Tag = new Numbers("4");
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonMulitply
            // 
            this.buttonMulitply.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMulitply.Location = new System.Drawing.Point(262, 148);
            this.buttonMulitply.Name = "buttonMulitply";
            this.buttonMulitply.Size = new System.Drawing.Size(91, 75);
            this.buttonMulitply.TabIndex = 50;
            this.buttonMulitply.Tag = new Multiply();
            this.buttonMulitply.Text = "×";
            this.buttonMulitply.UseVisualStyleBackColor = true;
            this.buttonMulitply.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(87, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 75);
            this.button8.TabIndex = 49;
            this.button8.Tag = new Numbers("8");
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(174, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 75);
            this.button9.TabIndex = 48;
            this.button9.Tag = new Numbers("9");
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(-1, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 75);
            this.button7.TabIndex = 47;
            this.button7.Tag = new Numbers("7");
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDivision.Location = new System.Drawing.Point(262, 75);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(91, 75);
            this.buttonDivision.TabIndex = 46;
            this.buttonDivision.Tag = new Division();
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonC.Location = new System.Drawing.Point(87, 75);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(90, 75);
            this.buttonC.TabIndex = 45;
            this.buttonC.Tag = new Clear();
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBackward.Location = new System.Drawing.Point(174, 75);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(90, 75);
            this.buttonBackward.TabIndex = 44;
            this.buttonBackward.Tag = new BackSpace();
            this.buttonBackward.Text = "◄ ";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCE.Location = new System.Drawing.Point(-1, 75);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(90, 75);
            this.buttonCE.TabIndex = 43;
            this.buttonCE.Tag = new CE();
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 508);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonPN);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMulitply);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonCE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPN;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMulitply;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button10;
    }
}

