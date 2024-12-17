class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }


    public void bRun()
    {
        Console.WriteLine("Get Ready... ");
        Thread.Sleep(2000);
        //ShowSpinner();

            
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); 

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDownSeconds();
            Thread.Sleep(3000);

            Console.WriteLine();
            Console.Write("Now, breathe out...");
            ShowCountDownSeconds();
            Thread.Sleep(3000);
        }

        DisplayEndingMessage();
        ShowSpinner();

    }
}