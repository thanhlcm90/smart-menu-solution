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
                lst = (from a in Context.BILLING.ToList()
                       group a by a.SELL_DATE into listg
                     

                       select new StatisticsDayDTO() {Sell_date=listg.Key ,
                                                         SumTable = listg.Count(),
                                                        
                                                    //  Total = (from b in Context.BILLING where b.SELL_DATE == listg.Key select b.MONEY).Sum(),

                          
                       
                       
                       
                       
                       
                                                     }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
