using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BODMASState
{
    /// <summary>
    /// 先乘除後加減的規範
    /// </summary>
    public interface IBODMAS
    {
        /// <summary>
        /// 每個狀態的動作
        /// </summary>
        /// <param name="record">紀錄資訊的物件的位址</param>
        void OpMovement(ref Record record); 
    }
}
