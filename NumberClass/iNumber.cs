using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NumberClass
{
    /// <summary>
    /// 管理現在是否可加數字
    /// </summary>
    public interface INumber
    {
        /// <summary>
        /// 每個NumberState的觸發function
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        /// <param name="no">各個數字按鈕的編號</param>
        void NumberHandle(ref Record record, string no);
    }
}
