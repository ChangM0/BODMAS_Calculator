using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 新的一次 */ 運算。
    /// 亦即前面沒有運算子時，或前次為 +- 時，按下 * 或 / 時的狀態
    /// </summary>
    public class InitMultiplyDivision : IBODMAS
    {
        /// <summary>
        /// 更新運算元
        /// </summary>
        /// <param name="record">紀錄資料的物件位址</param>
        public void OpMovement(ref Record record)
        {
            record.MultiplyDivisionNumber1 = record.MultiplyDivisionNumber2;
            record.MultiplyDivisionNumber2 = record.Input;
        }
    }
}
