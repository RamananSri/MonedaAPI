using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    interface ICashFlowDAL
    {
        //List<CashFlow>
        //CashFlow GetCashFlow(int id);
        void PostCashFlow(CashFlow cashflow);
        void DeleteCashFlow(int id);
        void PutCashFlow(CashFlow cashflow);
    }
}
