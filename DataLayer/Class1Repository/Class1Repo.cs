using BusinessLayer;
using DataLayer.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Class1Repository
{
    public class Class1Repo : IClass1Repo
    {
        public List<Class1> GetTable1() => Class1DAO.Instance.getTable1;
    }
}
