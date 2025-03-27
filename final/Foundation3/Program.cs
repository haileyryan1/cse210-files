using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Event lecture = new Lecture("AI Summit", "Discuss AI", "03/27/2025", "10:00 AM", addr1, "Dr. Jones", 200);

        Address addr2 = new Address("15 Street Ave", "Buenos Aires", "BA", "Argentina");
        Event reception = new Reception("Networking", "Connect with leaders", "03/27/2025", "6:00 PM", addr2, "rsvp@example.com");

        Address addr3 = new Address("100 Party St", "San Diego", "CA", "USA");
        Event outdoor = new OutdoorGathering("Spring Kickoff", "Food and fun outdoors", "03/27/2025", "2:00 PM", addr3, "Sunny and 75°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n----------------------------\n");
        }
    }
}