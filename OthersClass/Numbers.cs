using Calculator.NumberClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OthersClass
{
    /// <summary>
    /// 把數字印上去
    /// </summary>
    public class Numbers : Buttons
    {
        /// <summary>
        /// 存當前object的數值
        /// </summary>
        private string MyNumber;

        /// <summary>
        /// 於生成時就賦予數值
        /// </summary>
        /// <param name="idx">接收數字</param>
        public Numbers(string idx)
        {
            MyNumber = idx;
        }

        /// <summary>
        /// 把數字新增到input
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.NumberStatus.NumberHandle(ref record, MyNumber);
            //record.Input = Convert.ToDecimal($"{record.InputUI}{MyNumber}");
            //record.InputUI = record.Input.ToString();
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
