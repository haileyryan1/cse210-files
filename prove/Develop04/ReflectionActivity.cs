class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on past experiences of strength and resilience.") {}

    protected override void RunActivity()
    {
        Random _random = new Random();
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        ShowSpinner(3);

        List<string> _selectedQuestions = new List<string>();
        while (_selectedQuestions.Count < 3)
        {
            string _question = _questions[_random.Next(_questions.Count)];
            if (!_selectedQuestions.Contains(_question))
            {
                _selectedQuestions.Add(_question);
            }
        }

        foreach (string _question in _selectedQuestions)
        {
            Console.WriteLine(_question);
            ShowSpinner(5);
        }
    }
}   