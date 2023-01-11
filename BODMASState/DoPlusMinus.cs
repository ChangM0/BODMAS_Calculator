using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 當前次為 + 或 -，按下 + 或 - 時的狀態
    /// </summary>
    public class DoPlusMinus : IBODMAS
    {
        /// <summary>
        /// 做上個運算子 + 或 - 的運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public void OpMovement(ref Record record)
        {
            record.PlusMinusNumber1 = record.Total;
            record.PlusMinusNumber2 = record.Input;

            record.PrePlusMinusBtn.Compute(ref record);
        }
    }
}
