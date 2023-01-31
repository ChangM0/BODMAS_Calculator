using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotState
{
    /// <summary>
    /// Dot state : CAN ADD
    /// </summary>
    public class DotAdd : IDot
    {
        /// <summary>
        /// 新增小數點
        /// </summary>
        /// <param name="record">資料物件</param>
        public void DotHandle(ref Record record)
        {
            record.InputUI = string.Concat(record.InputUI, ".");
            record.DotStatus = record.TheDotState[1];
        }
    }
}
