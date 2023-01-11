using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 之前沒有任何一個運算子，按下 + 或 - 時的狀態
    /// </summary>
    public class InitPlusMinus : IBODMAS
    {
        /// <summary>
        /// 將輸入的資料移到total
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public void OpMovement(ref Record record)
        {
            record.Total = record.Input;
        }
    }
}
