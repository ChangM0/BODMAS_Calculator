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
            record.DotStatus = new DotAdd();

            record.EquationUI = $"{record.EquationUI}{record.InputUI} - ";

            // Plus & Minus
            record.PlusMinusStatus.OpMovement(ref record);
            record.PlusMinusStatus = new DoPlusMinus();

            // 回復 */ 至原始狀態
            record.MultiplyDivisionstatus = new InitMultiplyDivision();

            record.PrePlusMinusBtn = this;
        }

        /// <summary>
        /// 清空輸入的值及對應的UI
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyBackground(ref Record record)
        {
            record.InputUI = "0";
            record.Input = 0;
        }
    }
}
