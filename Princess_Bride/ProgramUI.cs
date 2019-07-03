using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princess_Bride
{
    public class ProgramUI
    {
        public void Run()
        {
            try
            {
                bool running = true;
                while (running)
                {
                    Console.Clear();

                    Console.WriteLine(@"(  _ \(  _ \(  )(  ( \ / __)(  __)/ ___)/ ___)  (  _ \(  _ \(  )(    \(  __) ");
                    Console.WriteLine(@" ) __/ )   / )( /    /( (__  ) _) \___ \\___ \   ) _ ( )   / )(  ) D ( ) _)  ");
                    Console.WriteLine(@"(__)  (__\_)(__)\_)__) \___)(____)(____/(____/  (____/(__\_)(__)(____/(____) ");
                    Console.WriteLine(@"  __   ____  _  _  ____  __ _  ____  _  _  ____  ____                        ");
                    Console.WriteLine(@" / _\ (    \/ )( \(  __)(  ( \(_  _)/ )( \(  _ \(  __)                       ");
                    Console.WriteLine(@"/    \ ) D (\ \/ / ) _) /    /  )(  ) \/ ( )   / ) _)                        ");
                    Console.WriteLine(@"\_/\_/(____/ \__/ (____)\_)__) (__) \____/(__\_)(____)                       ");

                    Console.Write("\n" +
                        "1. Start Adventure\n" +
                        "2. Exit Application\n");

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Introduction();
                            break;
                        case 2:
                            running = false;
                            break;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Inconceivable! You Died! Please start again");
                Console.ReadLine();
                Run();
            }
        }

        public void Introduction()
        {
            Console.Clear();
            Console.WriteLine(" You are known by many names: Man in Black, Dread Pirate Richards, Farmhand, but your true love knows you as Westley.\n" +
                " You've come to the country of Florin in search of her. You've learned that Princess Buttercup has been abducted\n" +
                " by a band of mercernaries, led by a short, balding Sicilian named Vizzini. Armed with this information, you\n" +
                " strike off on your adventure to save Buttercup.\n" +
                "\n" +
                " Press return to continue");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You board a ship and track the mercenaries to the Cliffs of Insanity. You come to a long rope ladder scaling the cliffs and see Vezzini being carried up the ladder by a very large man. What would you like to do?\n" +
                "\n" +
                "1. Climb the ladder after him.\n" +
                "2. Seek an alternate route to the top.");
            
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ClimbTheLadder();
                    break;
                case 2:
                    AlternateRoute();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Try again!");
                    Console.ReadLine();
                    Introduction();
                    break;
                    
            }
        }

        public void AlternateRoute()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("In your efforts to find an alternate route, your ship is caught in a terrible storm, where you are thrown overboard and devoured by a kraken.\n" +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Sorry Mate, but you are certainly still dead!You must make a choice.");
                        Console.ReadLine();
                        AlternateRoute();
                        break;
                }
            }
        }

        public void ClimbTheLadder()
        {
            Console.Clear();
            Console.WriteLine("After a grueling climb, where you keep hearing Vezzini exclaim, \"Inconceivable\", you finally arrive to the top of the Cliff of Insanity to be met by a waiting swordsman.\n" +
                "\n" +
                "Swordsman: \"Hello! My name is Inigo Montoya. You seem a decent fellow. I hate to kill you.\"\n" +
                "\n" +
                "What do you do?\n" +
                "\n" +
                "1. Lay down your sword and throw yourself at the mercy of Inigo, who seems a decent fellow.\n" +
                "2. Salute Inigo and engage him in an epic sword battle.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SurrenderToInigo();
                    break;
                case 2:
                    FightInigo();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Try again!");
                    Console.ReadLine();
                    ClimbTheLadder();
                    break;

            }

        }

        public void SurrenderToInigo()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Inigo accepted your honorable surrender. However, his boss, Vezzini, ordered him to throw you off the Cliff of Insanity. Unfortunately, you didn't survive the fall because the cliff was insanely high.\n" +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Inigo totally killed you! Restart or Return to Main Menu? I.E. choose 1 or 2!");
                        Console.ReadLine();
                        SurrenderToInigo();
                        break;
                }
            }
        }

        public void FightInigo()
        {
            Console.Clear();
            Console.WriteLine("After an honorable sword fight, you best Inigo and manage to knock him unconscious with the hilt of your sword.\n" +
                "\n" +
                "You turn around to see a mountain of a man coming towards you. He is the largest man you've ever seen; an absolute giant! You manage to evade his initial swipe and size him up.\n" +
                "\n" +
                "Quick, what's your plan of attack?\n" +
                "\n" +
                "1. Try to choke the giant out.\n" +
                "2. Go toe to toe with the giant, trading punch for punch.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ChokeAndre();
                    break;
                case 2:
                    PunchAndre();
                    break;
                default:
                    Console.WriteLine("No other choices! Inconceivable!");
                    Console.ReadLine();
                    FightInigo();
                    break;
            }
        }

        public void PunchAndre()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("You manage to land one meaningless punch before the giant grabs hold of you and slings you against a rocky outcrop. The last thing you remember is what a good arm and aim he has.\n" +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Well, ummm, you are dead! So, no other choices mate! I.E. choose 1 or 2 !");
                        Console.ReadLine();
                        PunchAndre();
                        break;
                }
            }
        }

        public void ChokeAndre()
        {
            Console.Clear();
            Console.WriteLine("You wait until the giant lunges, roll between his legs and quickly scale up his back. Your arm can barley get around his neck, but you manage to put him in a sleeper hold. After what seems like an eternity, he finally crashes to the ground, unconscious.\n" +
                "\n" +
                "\"Inconceivable!\" yells Vezzini. You turn to see him sitting at a table with a knife to Buttercup's throat. \"We are at an impasse\", Vezzini explains, \"as I am no match for you physically and you're no match for my brains. I challenge you to a battle of wits!\"\n" +
                "\n" +
                "There are two goblets of wine, at least one is poisoned. Which do you drink?\n" +
                "\n" +
                "1. Drink the wine in front of you.\n" +
                "2. Take Vezzini's wine and drink it.");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SurvivePoison();
                    break;
                case 2:
                    SurvivePoison();
                    break;
                default:
                    Console.WriteLine("Inconceivable! You only have 2 choices!");
                    Console.ReadLine();
                    ChokeAndre();
                    break;
            }
        }

        public void SurvivePoison()
        {
            Console.Clear();
            Console.WriteLine("You both drink and Vezzini starts laughing maniacally, thinking he's outwitted you. In the middle of his gloating, he keels over dead." +
                "\n" +
                "As you are freeing Buttercup from her bonds, you see in the distance a host of soldiers coming your direction. Buttercup informs you that is Prince Humperdinck who wants to take her for his wife.\n" +
                "\n" +
                "There are at least 15 well trained soldiers, what would you like to do?\n" +
                "\n" +
                "1. Stand your ground and fight.\n" +
                "2. Try to outrun them and hide in the Fire Swamp.");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FightSoldiers();
                    break;
                case 2:
                    TheFireSwamp();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Try again!");
                    Console.ReadLine();
                    SurvivePoison();
                    break;
            }
        }

        public void FightSoldiers()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("You put Buttercup behind you and manage to dispatch a few of the soldiers. They finally understand that fighting you one at a time is dumb, and the remaining soldiers charge you. The last thing you see is a six-fingered man unsheathing his sword and plunging it into your chest." +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("You died! No other choices! 1 or 2?");
                        Console.ReadLine();
                        FightSoldiers();
                        break;
                }
            }
        }

        public void TheFireSwamp()
        {
            Console.Clear();
            Console.WriteLine("Just in the nick of time, you and Buttercup enter the Fire Swamp, evading Prince Humperdinck's forces. There are three terrors in the fire swamp: the flame spurts, the lightning sand and the Rodents Of Unusual Size (ROUS). As you work your way through the swamp, avoiding the flame spurts and the lightning sand, you're stalked by two ROUS.\n" +
                "\n" +
                "Suddenly, the two ROUS attack. You manage to knock one aside, but lose your sword in the process. Buttercup cries out as the other ROUS is charging right at her. What do you do?\n" +
                "\n" +
                "1. Go retrieve your sword." +
                "2. Jump on the ROUS's back.");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FindSword();
                    break;
                case 2:
                    SaveButtercup();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Only 2 choices mate!");
                    Console.ReadLine();
                    TheFireSwamp();
                    break;
            }
        }

        public void FindSword()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("You see your sword lying in the distance and you take a giant leap towards it. As you grasp the hilt, a giant flame spurt erupts, engulfing you in flames. The last thing you hear is Buttercup screaming as a ROUS drags her deeper into the swamp.\n" +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Inconceivable! Try again!");
                        Console.ReadLine();
                        FindSword();
                        break;
                }
            }
        }

        public void SaveButtercup()
        {
            Console.Clear();
            Console.WriteLine("You take a glance around for your sword, but there's no time. You leap onto the back of the ROUS and manage it to pull it away from Buttercup. Face to face with the rodent, you notice it's razor sharp teeth, red, beady eyes and the horrible smell. Just when you think it will overpower you, a flame spurt erupts nearby and you roll over to it and roast the ROUS over the flame.\n" +
                "\n" +
                "From somewhere, you summon your strength, pick up your pace and reach the edge of the fire swamp. Just ahead you see the calm waters of the bay and a sailboat that you had stowed there for your return home with Buttercup. As you come onto the sandy beach, Prince Humperdinchk with his battalion of soldiers cuts you off from the water.\n" +
                "\n" +
                "Humperdinck: \"Surrender the Princess or die\".\n" +
                "\n" +
                "1. You're surrounded but draw your sword." +
                "2. Lay down your sword and surrender.");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SurrenderToHumperdinck();
                    break;
                case 2:
                    SurrenderToHumperdinck();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Either Surrender or save your lady!");
                    Console.ReadLine();
                    SaveButtercup();
                    break;
            }
        }

        public void SurrenderToHumperdinck()
        {
            Console.Clear();
            Console.WriteLine("Before an action can be taken, Buttercup, sensing that this was a fight you could not win, steps up and addresses Humperdinck.\n" +
                "\n" +
                "Buttercup: \"If we surrender, and I return with you, will you promise not to hurt this man?\n" +
                "\n" +
                "Humperdinck: \"May I live a thousand years and never hunt again. I swear no harm will come to this man.\" \n" +
                "\n" +
                "With that, Buttercup hops on the back of Humperdinck's horse and they ride off. Buttercup is out of sight and his henchman, Count Rugen, clubs you on the head and you wake in the Pit of Despair. You are hooked up to a medieval torture device and Count Rugen tortures you until you lose consciousness.\n" +
                "\n" +
                "Press return to continue...");

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You open your eyes and are amazed to see that you're no longer in the Pit of Despair, but on a castle wall with Inigo, the Spanish swordsman, and Fezzik, the giant you choked out. \"How did I get here?\", you ask.\n" +
                "\n" +
                "Inigo explains that he was looking for Count Rugen and found you in the Pit of Despair, mostly dead. You still feel mostly dead as you can't walk or weild your sword. You are at Humperdinck's castle and Buttercup is set to be married in 30 minutes. The gate to the tower needs to be open but it's being guarded by 60 men.\n" +
                "\n" +
                "What would you like to do?\n" +
                "\n" +
                "1. Send Fezzik and Inigo in to fight the sixty men.\n" +
                "2. Come up with something more creative.");


            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SendFezzikAndInigo();
                    break;
                case 2:
                    SomethingCreative();
                    break;
                default:
                    Console.WriteLine("You have no other choices!");
                    Console.ReadLine();
                    SurrenderToHumperdinck();
                    break;
            }
        }

        public void SendFezzikAndInigo()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Fezzik and Inigo jump into the battalion of soldiers. They hold their own but eventually they are overrun and captured. You, not having use of your arms or legs, are captured and Princess Buttercup marries Prince Humperdinck.\n" +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("You are definitely dead! 1 or 2?");
                        Console.ReadLine();
                        SendFezzikAndInigo();
                        break;
                }
            }
        }

        public void SomethingCreative()
        {
            Console.Clear();
            Console.WriteLine("You come up with a plan to make Fezzik look bigger than he is but having him stand in a wheelbarrow while Inigo pushes him towards the soldiers. To make him even more terrifying, you light his cloak on fire. All soldiers flee at the sight of him. The gate is open." +
                    "\n" +
                    "You storm the castle, Fezzik dragging you behind him like a child drags a blanket. Count Rugen and four soldiers come towards you in the hallway but Inigo quickly dispatches the four soldiers leaving only Rugen.\n" +
                    "\n" +
                    "Inigo: \"Hello! My name is Inigo Montoya. You killed my father. Prepare to die.\"\n" +
                    "\n" +
                    "And off he goes after Rugen; Fezzik quickly on his heels to assist. You manage to drag yourself to Buttercup's room and are reunited with your true love.\n" +
                    "\n" +
                    "Press return to continue.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your happy reunion is short lived as Humperdinck storms into the room, sword drawn. You're regaining some feeling in your arms and legs, but it's not enough.\n" +
                "\n" +
                "What would you like to do?\n" +
                "\n" +
                "1. Insult Humperdinck and call him a wart-hog faced buffoon.\n" +
                "2. Attempt to fight to the best of your ability.");


            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    InsultHumperdinck();
                    break;
                case 2:
                    FightHumperdinck();
                    break;
                default:
                    Console.WriteLine("Inconceivable! Either insult like a man or fight like a man!");
                    Console.ReadLine();
                    SomethingCreative();
                    break;
            }

        }

        public void FightHumperdinck()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("You do your best to lift your sword, but have no strength. Humperdinck easily disarms you and fatally wounds you with his sword and takes Buttercup as his own." +
                    "\n" +
                    "What would you like to do?\n" +
                    "\n" +
                    "1. Restart Adventure\n" +
                    "2. Return to Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Introduction();
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("HAHAHAHA! Inconceivable! 1 or 2?");
                        Console.ReadLine();
                        FightHumperdinck();
                        break;
                }
            }
        }

        public void InsultHumperdinck()
        {
            Console.Clear();
            Console.WriteLine("You go on an epic rant. Throwing insult and threats at Humperdinck so quickly that you can see him lose his color. He's so intimidated that he throws down his weapon and surrenders.\n" +
                "\n" +
                "You have Buttercup tie him up and Inigo comes into the room having exacted his vengance on Rugen. Fezzik calls to you from outside the window where he is waiting with four white horses.\n" +
                "\n" +
                "The four of you escape the castle and Inigo and Fezzik go their own way. You and Buttercup live happily ever after.\n" +
                "\n" +
                "Press any key for the ending.");

                
                Console.Clear();

            Console.WriteLine(@" ________             _______      _______    _         ______     _   _ ");
            Console.WriteLine(@" \__  __/ |\     /|  (  ____ \    (  ____ \  ( (    /| ( __   \   ( ) ( )");
            Console.WriteLine(@"   ) (    | )   ( |  | (    \/    | (    \/  |  \  ( | | (  \  )  | | | | ");
            Console.WriteLine(@"   | |    | (___) |  | (__        | (__      |   \ | | | |   ) |  | | | | ");
            Console.WriteLine(@"   | |    |  ___  |  |  __)       |  __)     | (\ \) | | |   | |  | | | | ");
            Console.WriteLine(@"   | |    | (   ) |  | (          | (        | | \   | | |   ) |  (_) (_)  ");
            Console.WriteLine(@"   | |    | )   ( |  | (____/\    | (____ /\ | )  \  | | (__ / )   _   _   ");
            Console.WriteLine(@"   )_(    |/     \|  (_______ /   (_______ / |/    )_) (______ /  (_) (_)  ");










        }
    }

}
