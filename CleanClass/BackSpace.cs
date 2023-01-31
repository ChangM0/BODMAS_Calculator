using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CleanClass
{
    /// <summary>
    /// 刪除最後一個字
    /// </summary>
    public class BackSpace : Buttons
    {
        /// <summary>
        /// 刪除最後一個字
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            try
            {
                record.InputUI = record.InputUI.Substring(0, record.InputUI.Length - 1);
                string test = record.InputUI.Substring(0, record.InputUI.Length - 1);
            }
            catch
            {
                record.InputUI = record.Zero;
            }
            record.Input = Convert.ToDecimal(record.InputUI);
        }

        /// <summary>
        /// 不動作
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyUI(ref Record record)
        {
        }
    }
}
