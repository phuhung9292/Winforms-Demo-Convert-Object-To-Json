using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAcess
{
    public class Class2DAO
    {
        private static List<Class2> list = new List<Class2>()
        {
            new Class2
            {
                Output_Presser = 200,
                ZSC =1,
                MAC_1=1,
                UPS_RUNNING=1,
                CHARGING=1,
                SD_1 =1,
                SELECT_SW=1,
                RESET =1,
                EMER_NO =1,
                UPS_STATUS =1,
                HR_1 =1,
                BC_1 =1,
                SV_1 =1,
    }
        };
        private static Class2DAO instance = null;
        private static readonly object instanceLock = new object();

        private Class2DAO() { }
        public static Class2DAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Class2DAO();
                    }
                    return instance;
                }
            }
        }
        public List<Class2> getTable2 => list;
    }
}
