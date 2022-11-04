using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASM_2
{
    public class Player : Information
    {
        private int playerID;
        private string name;
        private string position;
        public int PlayerID
        {
            get => playerID;
            set => playerID = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Position
        {
            get => position;
            set
            {
                bool containtsInt = value.Any(char.IsDigit);
                if (containtsInt)
                {
                    throw new ArgumentException("player not valid");
                }
                position = value;
            }

        }
        public Player(int playerID,string position,string name)
        {
            this.PlayerID = playerID;
            this.Position = position;   
            this.Name = name;
        }
        public void Input()
        {
            Console.Write("Input player name: ");
            Name = Console.ReadLine();
            Console.Write("Input ID: ");
            PlayerID = int.Parse(Console.ReadLine());
            Console.Write("Input Player position: ");
            Position = Console.ReadLine();
        }

        public Player()
        {

        }
        public void ShowInformation()
        {
            Console.WriteLine("- Player name: {0} | ID: {1} | Position: {2}", Name, PlayerID, Position);
            Console.WriteLine("----------------------------------------");
        }
    }
}
