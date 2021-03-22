using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWeb.Models
{
    public class Truck
    {
        public string TruckNumber { get; set; }
        public string TruckName { get; set; }
        public bool Status { get; set; }
        public string DriverName { get; set; }

        public Truck(string tno, string tname, string dname, bool sts)
        {
            TruckNumber = tno;
            TruckName = tname;
            DriverName = dname;
            Status = sts;
        }

        

        public Truck()
        {
         }
        public static List<Truck> trucks = new List<Truck>();
       
        public static List<Truck> AllTrucks()
        {
            //trucks.Clear();
            trucks.Add(new Truck("TN29AY7802", "KKR Transports", "Raju", true));
            trucks.Add(new Truck("TN09CY5412", "Vinayaga Transports", "Maaran", false));
            trucks.Add(new Truck("TN30PR0007", "PRO Transports", "Raju", true));
            trucks.Add(new Truck("PY15GG1254", "SNR Transports", "Kumar", false));


            return trucks;
        }

        public void AddTruck(Truck truck)
        {
            trucks.Add(truck);
        }
        public void DeleteTruck(Truck truck)
        {
            trucks.Remove(truck);
        }
        public void UpdateTruck(Truck truck)
        {
            foreach (var item in trucks)
            {
                if (item.TruckNumber==truck.TruckNumber)
                {
                    item.TruckName = truck.TruckName;
                    item.Status = truck.Status;
                    item.DriverName = truck.DriverName;
                }
            }
            /*trucks.Where(trk => trk.TruckNumber == truck.TruckNumber)
                  .Select(t => { 
                      t.Status = truck.Status;
                      t.TruckName = truck.TruckName;
                      t.DriverName = truck.DriverName; 
                      
                      return t; 
                  });*/
        }
    }
}
