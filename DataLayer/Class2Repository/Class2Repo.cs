using BusinessLayer;
using DataLayer.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Class2Repository
{
    public class Class2Repo : IClass2Repo
    {
        public List<Class2> GetTable2() => Class2DAO.Instance.getTable2;
    }
}
