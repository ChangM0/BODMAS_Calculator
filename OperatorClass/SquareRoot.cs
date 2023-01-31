using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.OperatorClass
{
    /// <summary>
    /// √
    /// </summary>
    public class SquareRoot : Buttons
    {
        /// <summary>
        /// 按下根號後將數值開根號
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        public override void Do(ref Record record)
        {
            record.DotStatus = record.TheDotState[0];
            record.EquationUI = $"{record.EquationUI} √ {record.InputUI}";
            try
            {
                record.Input = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(record.InputUI)).ToString());
                record.NumberStatus = record.TheNumberState[1];
                record.InputUI = string.Empty;
            }
            catch (Exception e)
            {
                // 若輸入的值不可開根號，則淨空算式
                MessageBox.Show(e.Message.ToString());
                record.ClearAction(ref record);
            }
        }

        /// <summary>
        /// 更新 UI 為空
        /// </summary>
        /// <param name="record">紀錄資訊的Object的位址</param>
        public override void ModifyUI(ref Record record)
        {
        }
    }
}
