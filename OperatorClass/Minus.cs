using Calculator.BODMASState;
using Calculator.DotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperatorClass
{
    /// <summary>
    /// -
    /// </summary>
    public class Minus : Buttons, IOperator
    {
        /// <summary>
        /// 做運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public void Compute(ref Record record)
        {
            record.Total = record.PlusMinusNumber1 - record.PlusMinusNumber2;
        }
        
        /// <summary>
        /// 送到傳入的state button去做運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.DotStatus = record.TheDotState[0];
            record.NumberStatus = record.TheNumberState[0];

            record.EquationUI = $"{record.EquationUI}{record.InputUI} - ";

            // Plus & Minus
            record.PlusMinusStatus.OpMovement(ref record);
            record.PlusMinusStatus = record.ThePlusMinusState[2];

            // 回復 */ 至原始狀態
            record.MultiplyDivisionstatus = record.TheMultiplyDivisionState[0];
            
            record.PrePlusMinusBtn = this;
        }

        /// <summary>
        /// 清空輸入的值及對應的UI
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyUI(ref Record record)
        {
            record.InputUI = record.Zero;
            record.Input = 0;
        }
    }
}
