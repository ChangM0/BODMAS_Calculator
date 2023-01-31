using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NumberClass
{
    /// <summary>
    /// 現在可以加數字
    /// </summary>
    public class AddNumber : INumber
    {
        /// <summary>
        /// 把數字加上檯面上的
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        /// <param name="belongsNumber">各個數字按鈕的編號</param>
        public void NumberHandle(ref Record record, string belongsNumber)
        {
            record.Input = Convert.ToDecimal($"{record.InputUI}{belongsNumber}");
            record.InputUI = record.Input.ToString();
        }
    }
}
