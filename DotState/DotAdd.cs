using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotState
{
    /// <summary>
    /// Change the Dot state into CAN ADD
    /// </summary>
    public class DotAdd : IDot
    {
        /// <summary>
        /// 新增小數點
        /// </summary>
        /// <param name="record">資料物件</param>
        /// <returns>修改後的資料物件</returns>
        public Record DotHandle(Record record)
        {
            record.InputUI = string.Concat(record.InputUI, ".");
            record.DotStatus = new DotExist();
            return record;
        }
    }
}
