public class ListingActivity : Activity
{
    int _count;
    List<string> _prompts = new List<string>();
    private List<string> _unusedPrompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        ResetUnusedPrompts();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();

        Console.WriteLine($"You listed {_count} items!");
        

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        
        if (_unusedPrompts.Count == 0)
        {
            ResetUnusedPrompts();
        }

        
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string selectedPrompt = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        Console.WriteLine($"--- {selectedPrompt} ---");
        return selectedPrompt;
    }

    List<string> GetListFromUser()
    {
        List<string> listStrings = new List<string>();
        _count = 0;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        

        while (DateTime.Now <= futureTime)
        {
            string strings = Console.ReadLine();
            listStrings.Add(strings);
            _count++;
        }
        return  listStrings;
    }

    private void ResetUnusedPrompts()
    {
        _unusedPrompts = new List<string>(_prompts);
    }
}