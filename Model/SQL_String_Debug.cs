using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractOverrideSample.Model.Abstract_SQL_Model;

namespace AbstractOverrideSample.Model
{
    internal class SQL_String_Debug : BaseSQLModel
    {
        //OutputTime 必須設定我要的時間
        internal override string Get_SHIPOUT_ShipoutList()
        {
            return @"Select OutputTime, ID, Price, No
                        from MyTable
                        where OutputTime > CONVERT(varchar, CAST('2024-06-04' AS datetime), 112)
                        And ID like 'D%'
                        And Price > 10000
                        And No like 'P%'";
        }
        internal override string Get_Export_List()
        {
            return @"Select OutputTime, ID, Invoice, Receipt
                        from MyTable
                        where OutputTime > CONVERT(varchar, CAST('2024-06-04' AS datetime), 112)
                        And ID like 'D%'";
        }
    }
}
