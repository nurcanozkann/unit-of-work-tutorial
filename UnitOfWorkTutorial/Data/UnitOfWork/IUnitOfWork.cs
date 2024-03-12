using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkTutorial.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public int Commit();
    }
}
