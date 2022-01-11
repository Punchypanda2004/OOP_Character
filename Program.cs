using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("Boris", "Bingo, you a ded", "Bongus");
            Character character2 = new Character("Splix", "Meaning of yes", "you, make me some cake");
            character1.speak(1);
            character2.setLevel(2);
            character2.speak(2);
        }
    }

    class Character
    {
        private string name;
        private string catch1;
        private string catch2;
        private int level;

        public Character(string charName, string catchPhrase1, string catchPhrase2)
        {
           this.name = charName;
           this.catch1 = catchPhrase1;
           this.catch2 = catchPhrase2;
           this.level = 0;
        }

        public void speak(int phraseNum)
        {
            if (phraseNum == 1)
            {
                Console.WriteLine(this.catch1);
            }
            else if (phraseNum == 2)
            {
                Console.WriteLine(this.catch2);
            }
        }

        public void setLevel(int newLevel)
        {
            this.level = newLevel;
            Console.WriteLine(this.name + " is now level " + this.level + "!");
        }
    }
}
