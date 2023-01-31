using Calculator.BODMASState;
using Calculator.CleanClass;
using Calculator.DotState;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperatorClass
{
    /// <summary>
    /// =
    /// </summary>
    public class Equal : Buttons
    {
        /// <summary>
        /// 做 = 運算
        /// </summary>
        /// <param name="record">傳入紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            //＋－ 控制最終答案
            record.PlusMinusStatus.OpMovement(ref record);

            record.EquationUI = $"{record.EquationUI}{record.InputUI} = ";
            record.InputUI = record.Total.ToString();
        }

        /// <summary>
        /// 呼叫clear，做清除
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyUI(ref Record record)
        {
            record.ClearAction(ref record);
        }
    }
}
