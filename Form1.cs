using Calculator.BODMASState;
using Calculator.DotState;
using Calculator.OperatorClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 記錄所有資訊
        /// </summary>
        private Record ToRecord;

        /// <summary>
        /// initial
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ToRecord = new Record();
            ToRecord.Total = 0;
            ToRecord.InputUI = "0";
            ToRecord.EquationUI = string.Empty;

            ToRecord.PlusMinusNumber1 = 0;
            ToRecord.PlusMinusNumber2 = 0;
            ToRecord.PlusMinusStatus = new InitPlusMinus();
            ToRecord.PrePlusMinusBtn = new Plus();

            ToRecord.MultiplyDivisionNumber1 = 0;
            ToRecord.MultiplyDivisionNumber2 = 0;
            ToRecord.MultiplyDivisionstatus = new InitMultiplyDivision();

            ToRecord.DotStatus = new DotAdd();
        }

        /// <summary>
        /// 共用的event
        /// </summary>
        /// <param name="sender">誰被碰到</param>
        /// <param name="e">e</param>
        public void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Buttons btnObject = btn.Tag as Buttons;

            // 做每個按鈕該做的
            btnObject.Do(ref ToRecord);

            // Print to UI
            textBox1.Text = ToRecord.EquationUI;
            textBox2.Text = ToRecord.InputUI;

            // 在背景做更新
            btnObject.ModifyBackground(ref ToRecord);
        }
    }
}
