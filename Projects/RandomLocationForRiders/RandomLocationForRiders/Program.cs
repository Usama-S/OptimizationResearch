using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLocationForRiders
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  min_lat          max_lat         min_long        max_long
            // -19.8753564      -30.085743      -43.176536      -51.245997


            using (var db = new Optimization_P2Entities())
            {
                Random r = new Random();

                var drivers = db.drivers.ToList();
                drivers.ForEach(a => {
                    a.current_latitude = Math.Round(GetRandomNumberInRange(r, -19.8753564, -30.085743), 7);
                    a.current_longitude = Math.Round(GetRandomNumberInRange(r, -43.176536, -51.245997), 7);
                });
                db.SaveChanges();
            }


        }



        public static double GetRandomNumberInRange(Random randomInstance, double minNumber, double maxNumber)
        {
            return randomInstance.NextDouble() * (maxNumber - minNumber) + minNumber;
        }
    }
}
