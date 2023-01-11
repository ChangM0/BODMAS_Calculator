using Calculator.BODMASState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 記錄目前數值及狀態的物件，用來回傳的規範
    /// </summary>
    public class Record
    {
        /// <summary>
        /// 紀錄total
        /// </summary>
        public decimal Total;

        /// <summary>
        /// 紀錄現在輸入的數字
        /// </summary>
        public decimal Input;

        /// <summary>
        /// 把現在輸入的數字放到UI
        /// </summary>
        public string InputUI;

        /// <summary>
        /// 加上根號的equation
        /// </summary>
        public string EquationUI;

        /// <summary>
        /// PM第一個運算元
        /// </summary>
        public decimal PlusMinusNumber1;

        /// <summary>
        /// PM第二個運算元
        /// </summary>
        public decimal PlusMinusNumber2;

        /// <summary>
        /// 上次的+-運算子，主要用來計算的
        /// </summary>
        public IOperator PrePlusMinusBtn;

        /// <summary>
        /// 判斷是否可直接計算(後加減)
        /// </summary>
        public IBODMAS PlusMinusStatus;

        /// <summary>
        /// MD第一個運算元
        /// </summary>
        public decimal MultiplyDivisionNumber1;

        /// <summary>
        /// MD第二個運算元
        /// </summary>
        public decimal MultiplyDivisionNumber2;

        /// <summary>
        /// 上次的*/運算子，主要用來計算的
        /// </summary>
        public IOperator PreMultiplyDivisionBtn;

        /// <summary>
        /// 判斷是否可直接計算(直接乘除)
        /// </summary>
        public IBODMAS MultiplyDivisionstatus;

        /// <summary>
        /// 紀錄input是否可再加小數點
        /// </summary>
        public DotState.IDot DotStatus;
    }
}
