﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotState
{
    /// <summary>
    /// Dot is exist
    /// </summary>
    public class DotExist : IDot
    {
        /// <summary>
        /// 不做任何舉動
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public void DotHandle(ref Record record)
        {
        }
    }
}
