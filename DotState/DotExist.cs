using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotState
{
    /// <summary>
    /// Dot is exist
    /// </summary>
    public class DotExist : IDot
    {
        /// <summary>
        /// Do nothing
        /// </summary>
        /// <param name="record">資料物件</param>
        /// <returns>直接回傳不需更改的資料物件</returns>
        public Record DotHandle(Record record)
        {
            return record;
        }
    }
}
