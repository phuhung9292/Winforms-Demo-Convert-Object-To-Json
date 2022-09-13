using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAcess
{
    public class Class1DAO
    {
        private static List<Class1> list = new List<Class1>()
        {
            new Class1
            {
                RBattery = 64,
                Temperature = 30,
                InputPressure = 30,
                SVA = 30,
                SVF = 30,
                GVF = 30,
                Vb_Today = 30,
                Vm_ToDay = 30,
                Vb_Yesterday= 30,
                Vm_Yesterday = 30,
                GVA = 30,
            } 
        };
        private static Class1DAO instance = null;
        private static readonly object instanceLock = new object();

        private Class1DAO() {  }
        public static Class1DAO Instance
        {
            get {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new Class1DAO();
                    }
                    return instance;
                }
            }
        }
        public List<Class1> getTable1 => list;
    }
}
