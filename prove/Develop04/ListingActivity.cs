class ListingActivity : Activity{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing","This activity helps you list positive aspects of your life.") {}

    protected override void RunActivity()
    {
        {
            Random _random = new Random();
            Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
            ShowCountdown(5);

            List<string> _items = new List<string>();
            int _elapsed = 0;

            while (_elapsed < _duration)
            {
                Console.Write("Enter an item: ");
                _items.Add(Console.ReadLine() ?? "");
                _elapsed +=5;
            }
            Console.WriteLine($"You lists {_items.Count} items.");
        }
    }
}