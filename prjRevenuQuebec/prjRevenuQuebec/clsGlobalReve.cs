using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace prjRevenuQuebec
{
    public static class clsGlobalReve
    {

        public static DataSet setReve;

        public static SqlDataAdapter adpCompagnies, adpEmployes;
    }
}
