using System;
using entityframework_02; 

namespace entityframework_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EventHubDbContext())
            {
                context.Database.EnsureCreated();
                Console.WriteLine("EventHub Database created successfully with mixed configurations!");
            }
        }
    }
}
