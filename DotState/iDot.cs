using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotState
{
    /// <summary>
    /// Dot interface
    /// </summary>
    public interface IDot
    {
        /// <summary>
        /// 每個dot的觸發function
        /// </summary>
        /// <param name="record">資訊物件</param>
        /// <returns>更新的record</returns>
        Record DotHandle(Record record);
    }
}
