using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThamsoService
    {
        public string getLuongCB()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var thamso = from r in qltt.THAMSOes select r;
                return thamso.FirstOrDefault().LUONGCB;
            }
        }
        public int getSiSoToiDa()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var thamso = from r in qltt.THAMSOes select r;
                return (int)thamso.FirstOrDefault().SISOTOIDA;
            }
        }
        public int getSiSoToiThieu()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var thamso = from r in qltt.THAMSOes select r;
                return (int)thamso.FirstOrDefault().SISOTOITHIEU;
            }
        }
    }
}
