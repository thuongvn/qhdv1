using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANGHANH2.Models
{
    public class DemoLoadData
    {
        static void Main(String[] args)
        {
            var context = new TCLDEntities();
            var truong = new Truong()
            {
                MaTruong = 1,
                TenTruong = "FPT"
            };

            context.Truongs.Add(truong);
            context.SaveChanges();
        }
    }
}