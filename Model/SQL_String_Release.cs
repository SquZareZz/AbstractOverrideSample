using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractOverrideSample.Model.Abstract_SQL_Model;

namespace AbstractOverrideSample.Model
{
    internal class SQL_String_Release : BaseSQLModel
    {
        //OutputTime 必須設定我要的時間
        //理論上，正式環境必須跟常態方法維持一致，除非要針對特定客戶的特例才會 override 新條件複寫
        //否則 Abstract 名存實亡。為維持架構與例外可能，還是保有這些 override

        //internal override string Get_SHIPOUT_ShipoutList()
        //{
        //    return @"Select OutputTime, ID, Price, No
        //                from MyTable
        //                where OutputTime > CONVERT(varchar, CAST('2024-06-04' AS datetime), 112)
        //                And ID like 'D%'
        //                And Price > 10000
        //                And No like 'P%'";
        //}

        //internal override string Get_Export_List()
        //{
        //    return @"Select OutputTime, ID, Invoice, Receipt
        //                from MyTable
        //                where OutputTime > CONVERT(varchar, CAST('2024-06-04' AS datetime), 112)
        //                And ID like 'D%'";
        //}
    }
}
