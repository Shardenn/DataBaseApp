using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyManager
{
    public static class DataHandling
    {
        
        public static Color AddColor(string EnteredColor)
        {
            using (RoadPenaltyContext db = new RoadPenaltyContext())
            {
                int i = db.Colors.Where(p => (p.ColorName == EnteredColor)).Count();
                if(i != 0)
                {
                    Console.WriteLine("Such color already exists");
                    return null;
                }

                Color newColor = new Color { ColorName = EnteredColor };
                db.Colors.Add(newColor);

                db.SaveChanges();
                return newColor;
            }
        }

        public static Manufacturer AddManufacturer(string EnteredManufacturer)
        {
            using (RoadPenaltyContext db = new RoadPenaltyContext())
            {
                int i = db.Manufacturers.Where(p => (p.ManufacturerName == EnteredManufacturer)).Count();
                if (i != 0)
                {
                    Console.WriteLine("Such Manufacturer already exists");
                    return null;
                }

                Manufacturer newManufacturer = new Manufacturer { ManufacturerName = EnteredManufacturer };
                db.Manufacturers.Add(newManufacturer);

                db.SaveChanges();
                return newManufacturer;
            }
        }

        public static ViolationType AddViolationType(string EnteredViolationType, int EnteredFine)
        {
            using (RoadPenaltyContext db = new RoadPenaltyContext())
            {
                int i = db.ViolationTypes.Where(p => (p.Type == EnteredViolationType)).Count();
                if (i != 0)
                {
                    Console.WriteLine("Such violation type already defined");
                    return null;
                }

                ViolationType newViolationType = new ViolationType
                {
                    Type = EnteredViolationType,
                    Fine = EnteredFine
                };

                db.ViolationTypes.Add(newViolationType);

                db.SaveChanges();
                return newViolationType;
            }
        }
    }
}
