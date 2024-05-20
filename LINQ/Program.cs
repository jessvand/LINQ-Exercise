using System.Xml;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Here is my weightplate collection:");

            var kgPlateColorAndValues = new List<string>()
            {   "Little White Plates are 0.5kg",
                "Little Green Plates are 1.0kg",
                "Little Yellow Plates are 1.5kg",
                "Little Blue Plates are 2 kg",
                "Little Red Plates are 2.5kg",
                "Big Green Plates are 10kg ",
                "Big Yellow Plates are 15kg",
                "Big Blue Plates are 20kg",
                "Big Red Plates are 25kg"
            };

            //Filtering w LinQ

            var weightPlates = kgPlateColorAndValues.OrderBy(weightPlate => weightPlate.Length).ToList();

            weightPlates.ForEach(weightPlate => Console.WriteLine(weightPlate));
          
            
            
        }
    }
}
