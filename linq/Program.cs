using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<course> clst = new List<course>()
            {
                new course{Cid=1,Cname="c#",Fees=7000,StartDate=Convert.ToDateTime("10-02-2020")},
                new course{Cid=2,Cname="dotnet",Fees=7500,StartDate=Convert.ToDateTime("11-02-2020")},
                new course{Cid=3,Cname="java",Fees=6000,StartDate=Convert.ToDateTime("12-02-2020")},
                new course{Cid=4,Cname="sql",Fees=6500,StartDate=Convert.ToDateTime("13-02-2020")},
            };
            //linq query
            var query = from gq in clst
                       // where gq.Cid == 2
                       orderby gq.Fees
                        select gq;
            foreach(var q in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.Cid, q.Cname, q.StartDate, q.Fees);
            }


        }
    }
}
