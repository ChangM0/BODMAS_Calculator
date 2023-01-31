using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.NumberClass
{
    /// <summary>
    /// 不能輸入數字
    /// </summary>
    public class HoldingNumber : INumber
    {
        /// <summary>
        /// 提醒用戶目前不可輸入數字
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        /// <param name="no">各個數字按鈕的編號</param>
        public void NumberHandle(ref Record record, string no)
        {
            MessageBox.Show("請選擇運算子");
        }
    }
}
