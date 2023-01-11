using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperatorClass
{
    /// <summary>
    /// √
    /// </summary>
    public class SquareRoot : Buttons
    {
        /// <summary>
        /// 按下根號後將數值開根號
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        public override void Do(ref Record record)
        {
            record.EquationUI = $"{record.EquationUI} √ {record.InputUI}";
            
            record.Input = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(record.InputUI)).ToString());
        }

        /// <summary>
        /// 更新 UI 為空
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        public override void ModifyBackground(ref Record record)
        {
            record.InputUI = string.Empty;
        }
    }
}
