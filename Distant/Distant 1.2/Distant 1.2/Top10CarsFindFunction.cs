using System.Collections.Generic; 
using System.Linq;                
using DataStructure;             

namespace Functions
{
    public static class CarFinder
    {
        public static List<Car> FindTop10Cars(List<Car> allCars)
        {
            List<Car> top10 = allCars
                .OrderByDescending(c => c.Power) 
                .Take(10)                        
                .ToList();                       

            return top10;
        }
    }
}