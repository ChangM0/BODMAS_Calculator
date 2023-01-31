﻿using Calculator.BODMASState;
using Calculator.DotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperatorClass
{
    /// <summary>
    /// *
    /// </summary>
    public class Multiply : Buttons, IOperator
    {
        /// <summary>
        /// 做運算
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public void Compute(ref Record record)
        {
            // 因為 */ 每次都會運算出結果(畢竟先乘除，舉凡遇到便直接運算)
            // 可以將結果都暫存在MultiplyDivisionNumber2
            // 以便下次計算時直接前移使用
            record.MultiplyDivisionNumber2 = record.MultiplyDivisionNumber1 * record.MultiplyDivisionNumber2;
        }
        
        /// <summary>
        /// 乘法按鈕按下後的動作。
        /// 更新UI，並進入目前state做對應動作
        /// </summary>
        /// <param name="record">紀錄資訊的Object</param>
        public override void Do(ref Record record)
        {
            record.DotStatus = record.TheDotState[0];
            record.NumberStatus = record.TheNumberState[0];

            record.EquationUI = $"{record.EquationUI}{record.InputUI} * ";

            // 強制 +- state 進入 wait
            record.PlusMinusStatus = record.ThePlusMinusState[1];

            // Multiply & Division
            record.MultiplyDivisionstatus.OpMovement(ref record);
            record.MultiplyDivisionstatus = record.TheMultiplyDivisionState[1];
            
            record.PreMultiplyDivisionBtn = this;
        }

        /// <summary>
        /// 清空輸入的值及對應的UI
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public override void ModifyUI(ref Record record)
        {
            record.InputUI = record.Zero;
            record.Input = 0;
        }
    }
}
