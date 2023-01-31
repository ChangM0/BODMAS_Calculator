using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 每個按鈕的父類別
    /// </summary>
    public abstract class Buttons
    {
        /// <summary>
        /// 每個按鈕觸發後，各自要做的任務由此發動
        /// </summary>
        /// <param name="record">用以紀錄資訊的物件的位址</param>
        public abstract void Do(ref Record record);

        /// <summary>
        /// 在背景做更新，不會呈現在此次的UI上
        /// </summary>
        /// <param name="record">用以紀錄資訊的物件</param>
        public abstract void ModifyUI(ref Record record);
    }
}
