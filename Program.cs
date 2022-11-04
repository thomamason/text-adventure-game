using System;
using static System.Console;

namespace MainGame
{
    class Game
    {
        static string CharacterName = "NoName";
        static string NomDeGuerre = "NoName";

        public static void StartGame()
        {
            WindowWidth = LargestWindowWidth - 50;

            Title = "Basterd Quest - a game by T.G. Featherstone";
            string TitleText = @"
 ▄▄▄▄    ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ▓█████▄      █████   █    ██ ▓█████   ██████ ▄▄▄█████▓
▓█████▄ ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ██▌   ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒
▒██▒ ▄██▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒░██   █▌   ▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░
▒██░█▀  ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ░▓█▄   ▌   ░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ 
░▓█  ▀█▓ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒░▒████▓    ░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░ 
░▒▓███▀▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▒▓  ▒    ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   
▒░▒   ░   ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░ ░ ▒  ▒     ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░    
 ░    ░   ░   ▒   ░  ░  ░    ░         ░     ░░   ░  ░ ░  ░       ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░      
 ░            ░  ░      ░              ░  ░   ░        ░           ░       ░        ░  ░      ░           
      ░                                              ░                                                    
";
            Functions.Text("Welcome, nerds, to T.G Featherstone's...............");
            Functions.Command("Press any key");
            ReadKey();
            Beep();
            Clear();
            Functions.Text(TitleText);
            Functions.Command("\nPress any key");
            ReadKey();
            Beep();
            Clear();
            NameCharacter();
        }
        static void NameCharacter()
        {
            Functions.Narrator("What is your name, traveller?");
            Functions.Command("Please enter your name below.");
            CharacterName = ReadLine();
            Functions.Narrator("I see... a mighty appellation! And by what moniker do the denizens of this realm know you as, " + CharacterName + "?");
            Functions.Command("Please enter your Nom de Guerre");
            NomDeGuerre = ReadLine();
            Functions.Narrator("Ooooh noooo! " + CharacterName + " " + NomDeGuerre + "!");
            Functions.Narrator("...");
            Functions.Narrator("I'm quaking in my boots!");
            Functions.Narrator(";p");
            ReadKey();
            Functions.Narrator("...........");
            ReadKey();
            Functions.Narrator("................");
            ReadKey();
            Functions.Narrator("So, uh... You ready to get into it?");
            ReadKey();
            Functions.Narrator("Well alright");
            Functions.Narrator(CharacterName + ", arrrrre yooooou rrrready?");
            Functions.Text("You hear a tremendous riff");
            ReadKey();
            Drink();
        }
        static void CureHangover()
        {
            if (Trait.Hungover == true)
            {
                Trait.Hungover = false;
                Functions.Command("Your hangover fades away!");
            }
            else
            {
                return;
            }
        }
        static void Shot()
        {
            if (Trait.Hungover == true)
            {
                Functions.Text("You knock the shot back and slam the glass down on the table. A second later, you realise your mistake and collapse to your knees vomiting profusely.");
                Functions.Text("\nThe shady men fall about laughing. They shoo you away from their table. Powerless to resist in your weakened state, you comply");
                ReadKey();
                BarFloor();
            }
            else
            {
                Functions.Text("You pour the viscous fluid down your throat. Curiously, it has no smell, but its taste burns with the fury of a thousand suns. You get it down though, and grin broadly at your new friends.");
                ReadKey();
                Functions.Npc("Shady Man", "Haha! Well done! Here, take this dagger. And keep your voice down. The crows are everywhere...");
                Functions.Command("You got a dagger!");
                Trait.HasDagger = true;
                Functions.Text("The shady mans face drops at his own mention of crows. You add the dagger to inventory and wish the men well before returning to the bar floor");
                ReadKey();
                BarFloor();
            }
        }
        static void Drink()
        {
            string input = "";
            Clear();
            Functions.Text("You are stood at the bar in the bloody stool. What will you have to drink?\nA) Tia Maria w/ Lucozade.\nB) Amyl Nitrates. From the top-shelf, of course.\nC) Magnum Tonic, straight-up.");
            Functions.Command("Please type A, B or C");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Functions.Text("You take a sip. It's very refreshing!");
                ReadKey();
                BarFloor();
            }
            if (input == "B")
            {
                Functions.Text("\"Fuck it.\" you think. You drink the shot. And black out.");
                Functions.Command("You got the \'British Bulldog\' Trait (+1 to Con Saves Vs. Solvents)");
                Trait.Aficionado = true;
                ReadKey();
                DrankPoppers();
            }
            else
            {
                Functions.Text("The bartender places an ice cold bottle of Magnum on a napkin that's surface glistens white as the driven snow. Your lips quiver as you raise the bottle. You feel... firmer, stronger, more powerful.");
                CureHangover();
                ReadKey();
                BarFloor();
            }
        }
        static void BarFloor()
        {
            string input = "";
            Clear();
            Functions.Text("You look around the bar and see a number of lively patrons engaged in frolicing, as well as several shady souls glaring over their tankards from the ghastly shadows");
            Functions.Text("The bar is being propped up by a half dozen customers and manned by a woman with horns protruding from her head. Taking stock of the calibre of drinkers in this establishment, you notice \namongst them a flamboyant bard, a pidgeon mage with a mischievous glint it their eye, a gnome whose eyes glow from a life in the underdark, two men - identical in appearance - arguing with one another. Caught in the middle is a half-elf clad in dark leather armour.");
            Functions.Text("");
            Functions.Text("Will you:\nA) Dance and make merry with the revellers.\nB) Introduce yourself to the fellows lurking in the corners. Maybe you can get in on their game?\nC)Approach the bar.");
            Functions.Command("Please type A, B, or C.");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Functions.Text("You boogie down and have a great time.");
                Functions.Text("");
                CureHangover();
                Functions.Text("Dancing is great fun! Want to keep going?");
                Functions.Command("Continue dancing? Y/N?");
                input = ReadLine();
                input = input.ToUpper();
                if (input == "Y")
                {
                    Functions.Text("You are the dancing queen.");
                    Functions.Command("You have earned the 'Dancing Queen' trait! (+1 to charisma while in nightclubs and on dancefloors");
                    Trait.DancingQueen = true;
                    Functions.Command("Press any key");
                    ReadKey(true);
                    BarFloor();
                }
                else
                {
                    Functions.Text("You leave the dance floor.");
                    Functions.Command("Press any key");
                    ReadKey(true);
                    BarFloor();
                }

            }
            else if (input == "B")
            {
                SusMenIntro();
            }
            else if (input == "C")
            {
                TheBar();
            }
        }
        static void DrankPoppers()
        {
            Clear();
            Functions.Text("You awaken.\nYou try to open your eyes but searing light forces them shut.\n \n..\n \nThe ringing in your ears subsides a little, and you can make out several voices slowly coming into focus.");
            Functions.Npc("Unknown", "... mmmph mumble feffffrrghh mumble mmph...");
            Functions.Npc("Unknown", "Hey, you. You're finally awake.");
            Functions.Text("You groan.");
            Functions.Command("You have a hangover! (-1 to Con saves - cooldown 300s)");
            Trait.Hungover = true;
            ReadKey();
            BarFloor();
        }
        static void SusMenIntro()
        {
            if (Trait.Aficionado == true)
            {
                Functions.Text("As you approach a group of five particularly sus looking individuals, one of them looks in your direction and smiles warmly...");
                // if hungover then you throw up and they kick you out. otherwise they gift a dagger. you can lose hungover trait by doing something else before talking to these guys.
                Functions.Npc("Shady Man", "Well now, if it isn't " + NomDeGuerre + ". What brings you here," + CharacterName + "? Never mind. Sit, and drink nectar with us.");
                ReadKey();
                Shot();
            }
            if (Trait.Aficionado == false)
            {
                Functions.Text("As you approach a group of five particularly sus looking individuals, one of them looks in your direction and grimaces. He speaks...");
                Functions.Npc("Shady man", "Keep walking, adventurer. No geeks, freaks, or neeks at this table.");
                Functions.Text("He's got you bang to rights there, nerd. You return to the bar floor and wonder how you could win the favour of these dubious fellows.");
                ReadKey();
                Drink();
            }
        }
        static void TheBar()
        {
            Functions.Text("You walk up to a spot at the bar in between the pidgeon mage and the bard.\n Will you A) Get the bartenders attention and order a drink?\nB) Introduce yourself to the mage and the bard?\nC) Just loiter about.");
            Functions.Command("Please select A, B, or C");
            string input = "";
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Drink();
            }
            else if (input == "B")
            {
                Functions.Text("OK. What topic of conversation will you break the ice with?");
                Functions.Command("Please type the topic of conversation below.");
                input = ReadLine();
                Functions.Text("You introduce yourself to the bard and the mage, and ask what their views on " + input + " is?");
                ReadKey();
                Functions.Text("They stare at you incredulously. Several seconds pass before you back away from the interaction. As you turn away, you hear one say \"what a horrible person\". ");
                Functions.Command("Press any key");
                ReadKey();
                EndGame();
            }
            else if (input == "C")
            {
                Functions.Text("You watch the world go by...");
                ReadKey();
                BarFloor();
            }
        }
        static void EndGame()
        {
            Clear();
            Functions.Text("You see a figure in the centre of the room. They are robed in raggedy garb and their head is downturned\n" +
                "and covered with a filth-ridden hood. The stench of muck caked-up in the wretches clothes finally begins\n" +
                "to take hold, and the bar patrons pinch their noses in disgust.\n" +
                "\n" +
                "The figure stands just a few feet before you now. You realise they have moved several feet since you\n" +
                "first saw them. And now you are face to face. The room has fallen silent.\n" +
                "\n" +
                "A) Speak with the figure.\n" +
                "B) Attempt to leave.");
            Functions.Command("Please type A or B followed by Enter.");
            string input = "";
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Functions.Text("You open your mouth to speak... but as you open your mouth to speak, no words issue forth. \n" +
                    "Instead, you gag between fits of blinding tears that stream down your face, as you seemingly\n" +
                    "regurgitate an egg. It is much smaller than a chicken or duck egg and warm in your hand.\n" +
                    "\n");
                Trait.HasEgg = true;
                Functions.Command("Press any key");
                ReadKey(true);
                EndGame2();
            }
            else
            {
                ReadKey(true);
                EndGame2();
            }
        }

        static void EndGame2()
        {
            Clear();
            Functions.Text("You recoil and turn in horror, but the figure is already there to meet you. You see the white of an eye\n" +
                "peering out from under soiled hair and cloth. Slowly, but with feline grace, the figure raises a hand to\n" +
                "their eye");
            Functions.Command("Press any key");
            ReadKey(true);
            if (Trait.HasDagger == true)
            {
                Functions.Text("You draw your dagger and brandish it towards to the figure. You can scarcely believe your eyes to\n" +
                    "see the dagger is now a fistful of worms, wriggling and squirming. Panicked, you drop the worms\n" +
                    "to the floor.");
                Functions.Command("Press any key");
                ReadKey(true);
            }
            Functions.Text("The figure begins to work their fingers into their eye socket and with a single, swift motion, they\n" +
                "pluck their eyeball out. From within the weeping wound, you notice a stir and then a flutter, before\n" +
                "a murderous torrent of crows pour out, their wings flapping wildly and blotting out all light.");
            ReadKey(true);
            if (Trait.HasEgg == true)
            {
                Functions.Text("You feel the egg in your hand stir. You look down to see a tiny bird stretching its wings\n" +
                    "triumphantly amongst the shards of your product. It gazes up at you, and although the din of a\n" +
                    "million crow wings flapping asynchronously is deafening, you hear the child's words clearly:");
                ReadKey();
                Functions.Npc("Crow Baby", "mm..mmuh..Mother?");
                ReadKey(true);
                Functions.Text("The child... YOUR child... It has your eyes. You begin to weep.");
                ReadKey(true);
            }
            Clear();
            Functions.Text(@"
  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                     ░                   
");
            Functions.Command("Thanks for playing. Type A to play again or B to quit.");
            string input = "";
            input = input.ToUpper();
            input = ReadLine();
            if (input == "A")
            {
                StartGame();
            }
            else
            {
                return;
            }
        }
    }
    class Trait
    {
        public static bool Aficionado = false;
        public static bool Hungover = false;
        public static bool HasDagger = false;
        public static bool HasEgg = false;
        public static bool DancingQueen = false;


    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
        }
    }
}