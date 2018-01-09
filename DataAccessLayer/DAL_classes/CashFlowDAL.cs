using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataAccessLayer.DAL_classes
{
    public class CashFlowDAL : ICashFlowDAL
    {
        public CashFlowDAL()
        {

        }

        public void DeleteCashFlow(int id)
        {
            try
            {
                using (DomainContext ctx = new DomainContext())
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public CashFlow GetCashFlow(int id)
        {
            throw new NotImplementedException();
        }

        public void PostCashFlow(CashFlow cashflow)
        {
            throw new NotImplementedException();
        }

        public void PutCashFlow(CashFlow cashflow)
        {
            throw new NotImplementedException();
        }
    }
}
