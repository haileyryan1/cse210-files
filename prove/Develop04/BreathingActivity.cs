class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding deep breathing.") {}

    protected override void RunActivity()
    {
        int _elapsed = 0;
        while (_elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
            _elapsed += 6;
        }
    }
}