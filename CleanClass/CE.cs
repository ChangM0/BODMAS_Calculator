using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CleanClass
{
    /// <summary>
    /// 清除input
    /// </summary>
    public class CE : Buttons
    {
        /// <summary>
        /// 將input更新為0
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.InputUI = "0";
            record.PlusMinusNumber2 = 0;
            record.MultiplyDivisionNumber2 = 0;
            record.DotStatus = new DotState.DotAdd();
        }

        /// <summary>
        /// 不動作
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyBackground(ref Record record)
        {
        }
    }
}
