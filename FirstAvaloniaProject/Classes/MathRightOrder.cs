using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAvaloniaProject
{
    public class MathRightOrder
    {
        public double Equation(string MathEquation)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), MathEquation);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);
            return result;
        }
    }
}
