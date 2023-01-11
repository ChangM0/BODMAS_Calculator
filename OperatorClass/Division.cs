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
    /// 除法
    /// </summary>
    public class Division : Buttons, IOperator
    {
        /// <summary>
        /// 做除法運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        public void Compute(ref Record record)
        {
            try
            {
                record.MultiplyDivisionNumber2 = record.MultiplyDivisionNumber1 / record.MultiplyDivisionNumber2;
            }
            catch
            {
                //record.EquationUI = record.EquationUI.Substring(0, record.EquationUI.Length - 2);
                Console.WriteLine("不能除以0");
            }
        }

        /// <summary>
        /// 送到傳入的state button去做運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.DotStatus = new DotAdd();

            record.EquationUI = $"{record.EquationUI}{record.InputUI} / ";
           
            // 強制 +- state 進入 wait
            record.PlusMinusStatus = new WaitPlusMinus();

            // Multiply & Division
            record.MultiplyDivisionstatus.OpMovement(ref record);
            record.MultiplyDivisionstatus = new JustDoItMultiplyDivision();
            
            record.PreMultiplyDivisionBtn = this;
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
