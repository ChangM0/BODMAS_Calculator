using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 當前次為 * 或 /，按下 + 或 - 時的狀態
    /// </summary>
    public class WaitPlusMinus : IBODMAS
    {
        /// <summary>
        /// 等待 */ 做完後，將 */ 的結果加入 +- 的算式
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public void OpMovement(ref Record record)
        {
            record.MultiplyDivisionstatus.OpMovement(ref record);
            
            record.PlusMinusNumber1 = record.Total;
            record.PlusMinusNumber2 = record.MultiplyDivisionNumber2;

            record.PrePlusMinusBtn.Compute(ref record);
        }
    }
}
