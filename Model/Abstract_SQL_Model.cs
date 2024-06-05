using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSample.Model
{
    internal class Abstract_SQL_Model
    {
        internal abstract class BaseSQLModel
        {
            internal virtual string Get_SHIPOUT_ShipoutList()
            {
                return @"Select OutputTime, ID, Price, No
                        from MyTable
                        where OutputTime > CONVERT(varchar, GETDATE(), 112)
                        And ID like 'D%'
                        And Price > 10000
                        And No like 'P%'";
            }
            internal virtual string Get_Export_List()
            {
                return @"Select OutputTime, ID, Invoice, Receipt
                        from MyTable
                        where OutputTime > CONVERT(varchar, GETDATE(), 112)
                        And ID like 'D%'";
            }
        }
    }
}
