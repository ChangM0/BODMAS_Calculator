using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 可以做 * 運算。
    /// 當前次為 * 或 /，按下 * 或 / 時的狀態
    /// </summary>
    public class JustDoItMultiplyDivision : IBODMAS
    {
        /// <summary>
        /// 做上個運算子 * 或 / 的運算
        /// </summary>
        /// <param name="record">紀錄資料的物件位址</param>
        public void OpMovement(ref Record record)
        {
            record.MultiplyDivisionNumber1 = record.MultiplyDivisionNumber2;
            record.MultiplyDivisionNumber2 = record.Input;

            record.PreMultiplyDivisionBtn.Compute(ref record);
        }
    }
}
