using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages;

public class DadJokesModel : PageModel
{
    // Stores all 12 dad jokes
    public string[] DadJokes =
    {
        "What do lawyers wear to court? Lawsuits.",
        "What do elves learn in school? The elf-abet.",
        "What did one toilet say to another? You look flushed.",
        "Whats the difference between a poorly dressed man on a tricycle and a well-dressed man on a bicycle? Attire.",
        "What do sprinters eat before they race? Nothing. They fast.",
        "What has more lives than a cat? A frog, because it croaks every day.",
        "How did the barber win the race? He knew a short cut.",
        "I told my friend 10 jokes to make him laugh. Sadly, no pun in ten did.",
        "Two fish are in a tank. One turns to the other and says, “Any idea how to drive this thing?”",
        "What did the tomato say to the other tomato during a race? Ketchup.",
        "Why shouldnt you write with a broken pen? Because its pointless.",
        "Why can't you trust the king of the jungle? Because he's always lion."
    };

 
    public string[] CurrentJokes = new string[2];

    // This will decide how many dad jokes will show.
    public int NumberOfJokes = 2;

    public void OnGet()
    {
        GetRandomJokes();
    }

    public void OnPost()
    {
        GetRandomJokes();
    }

    // THe method will pick 2 random jokes 
    public void GetRandomJokes()
    {
        Random random = new Random();

        for (int i = 0; i < NumberOfJokes; i++)
        {
            int randomNumber = random.Next(0, DadJokes.Length);

            CurrentJokes[i] = DadJokes[randomNumber];
        }
    }
}