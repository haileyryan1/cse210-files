using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("27 Mar 2025", 30, 3.0),
            new Cycling("28 Mar 2025", 45, 15.0),
            new Swimming("29 Mar 2025", 60, 46)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
