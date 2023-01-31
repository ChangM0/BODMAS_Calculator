using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OthersClass
{
    /// <summary>
    /// 新增小數點
    /// </summary>
    public class Dot : Buttons
    {
        /// <summary>
        /// .
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {     
            record.DotStatus.DotHandle(ref record);
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
