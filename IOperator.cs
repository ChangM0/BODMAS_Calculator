using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 運算子們的介面
    /// </summary>
    public interface IOperator
    {
        /// <summary>
        /// 規範每個運算子都需要的計算功能
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        void Compute(ref Record record);
    }
}
