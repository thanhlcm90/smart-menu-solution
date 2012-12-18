using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class StatisticsRepository : RepostitoryBase
    {
     
        public List<StatisticsDayDTO> getStatisticsbyDay()
        {
            try
            {
                List<StatisticsDayDTO> lst;
                lst = (from a in Context.BILLING
                       let k = new { 
                           iDay = a.SELL_DATE.ToString("dd/MM/yyyy")
                       }
                       group a by k into listg
                       select new StatisticsDayDTO()
                       {
                           Sell_date = listg.Key.iDay,
                           Total = listg.Sum(k => k.MONEY),
                           SumTable=listg.Count()
                       }).ToList();
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].SumDish = (from p in Context.BILLING_DETAIL 
                                      where p.BILLING.SELL_DATE.ToString("dd/MM/yyyy") == lst[i].Sell_date 
                                      select p.AMOUNT).Sum();
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
