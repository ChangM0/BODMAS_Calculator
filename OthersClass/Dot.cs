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
        /// 新增小數點到字串，如果不能轉成decimal，表示裏頭已含有.，所以抓到錯的話，把剛剛新增的.給刪除
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {     
            record.DotStatus.DotHandle(record);
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
