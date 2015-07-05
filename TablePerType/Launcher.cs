using System;

namespace TablePerType
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            using (var context = new TablePerTypeDataContext())
            {
                foreach (var derivate in context.Derivate)
                {
                    Console.WriteLine(derivate.Name + " " + derivate.Description);
                }

                Console.ReadKey();
            }
        }
    }
}
