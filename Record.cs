using Calculator.BODMASState;
using Calculator.CleanClass;
using Calculator.DotState;
using Calculator.NumberClass;
using Calculator.OperatorClass;
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
        /// 避免重複宣告"0"
        /// </summary>
        public string Zero;

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
        /// 上次的+-運算子
        /// </summary>
        public IOperator PrePlusMinusBtn;

        /// <summary>
        /// 目前加減的狀態
        /// </summary>
        public IBODMAS PlusMinusStatus;

        /// <summary>
        /// 將new好的PlusMinusState存於此，便不用重複new
        /// </summary>
        public IBODMAS[] ThePlusMinusState;

        /// <summary>
        /// MD第一個運算元
        /// </summary>
        public decimal MultiplyDivisionNumber1;

        /// <summary>
        /// MD第二個運算元
        /// </summary>
        public decimal MultiplyDivisionNumber2;

        /// <summary>
        /// 上次的*/運算子
        /// </summary>
        public IOperator PreMultiplyDivisionBtn;

        /// <summary>
        /// 目前乘除的狀態
        /// </summary>
        public IBODMAS MultiplyDivisionstatus;

        /// <summary>
        /// 將new好的MultiplyDivisionState存於此，便不用重複new
        /// </summary>
        public IBODMAS[] TheMultiplyDivisionState;

        /// <summary>
        /// 紀錄input是否可再加小數點的狀態
        /// </summary>
        public IDot DotStatus;

        /// <summary>
        /// 將new好的DotState存於此，便不用重複new
        /// </summary>
        public IDot[] TheDotState;


        public INumber NumberStatus;

        public INumber[] TheNumberState; 

        /// <summary>
        /// Clear Button
        /// </summary>
        private Buttons ClearBtn;

        /// <summary>
        /// 初始化record
        /// </summary>
        public Record()
        {
            ThePlusMinusState = new IBODMAS[] 
            {
                new InitPlusMinus(),
                new WaitPlusMinus(),
                new DoPlusMinus()
            };

            TheMultiplyDivisionState = new IBODMAS[] 
            {
                new InitMultiplyDivision(),
                new JustDoItMultiplyDivision()
            };

            TheDotState = new IDot[] 
            {
                new DotAdd(),
                new DotExist()
            };

            TheNumberState = new INumber[]
            {
                new AddNumber(),
                new HoldingNumber()
            };

            Zero = "0";
            Total = 0;
            InputUI = Zero;
            EquationUI = string.Empty;

            PlusMinusNumber1 = 0;
            PlusMinusNumber2 = 0;
            PlusMinusStatus = ThePlusMinusState[0];
            PrePlusMinusBtn = new Plus();

            MultiplyDivisionNumber1 = 0;
            MultiplyDivisionNumber2 = 0;
            MultiplyDivisionstatus = TheMultiplyDivisionState[0];

            DotStatus = TheDotState[0];
            NumberStatus = TheNumberState[0];

            ClearBtn = new Clear();
        }

        /// <summary>
        /// 呼叫Clear Button清理資訊，減少重複new
        /// </summary>
        /// <param name="record">紀錄資訊的Object位址</param>
        public void ClearAction(ref Record record)
        {
            ClearBtn.Do(ref record);
        }
    }
}
