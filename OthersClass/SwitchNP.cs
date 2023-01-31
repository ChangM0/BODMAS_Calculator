using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OthersClass
{
    /// <summary>
    /// 切換正負號
    /// </summary>
    public class SwitchNP : Buttons
    {
        /// <summary>
        /// 切換input正負號
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            decimal inputDecimal = -Convert.ToDecimal(record.InputUI);
            record.InputUI = inputDecimal.ToString();
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
