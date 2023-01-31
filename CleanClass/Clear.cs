using Calculator.BODMASState;
using Calculator.DotState;
using Calculator.OperatorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CleanClass
{
    /// <summary>
    /// 全部清空
    /// </summary>
    public class Clear : Buttons
    {
        /// /// <summary>
        /// 把數字新增到input
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.InputUI = record.Zero;
            record.EquationUI = string.Empty;
            record.Total = 0;
            record.Input = 0;
            record.PlusMinusNumber1 = 0;
            record.PlusMinusNumber2 = 0;
            record.MultiplyDivisionNumber1 = 0;
            record.MultiplyDivisionNumber2 = 0;

            record.DotStatus = record.TheDotState[0];
            record.NumberStatus = record.TheNumberState[0];
            record.MultiplyDivisionstatus = record.TheMultiplyDivisionState[0];
            record.PlusMinusStatus = record.ThePlusMinusState[0];
            record.PrePlusMinusBtn = new Plus();
        }

        /// <summary>
        /// 全部reset
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyUI(ref Record record)
        {
        }
    }
}
