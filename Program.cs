namespace FamilyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> FamilyList = new Dictionary<string,string>();

            //adding Family
            FamilyList.Add("Chris V", "Husband");
            FamilyList.Add("Aubrey H", "Daughter");
            FamilyList.Add("Siri H", "Daughter");
            FamilyList.Add("Oliver H", "Son");
            FamilyList.Add("Donna C", "Mother");
            FamilyList.Add("David C", "Father");

            Console.WriteLine("FamilyList Keys");
            Dictionary<string, string>.KeyCollection keys = FamilyList.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("FamilyList Values");
            Dictionary<string, string>.ValueCollection values = FamilyList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("FamilyList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in FamilyList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            FamilyList.Remove("David C");

            Console.WriteLine($"There are now {FamilyList.Count} members listed in your family");
            Console.WriteLine($"Revised FamilyList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in FamilyList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
        }   

    }
}