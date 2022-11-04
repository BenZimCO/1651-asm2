using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2
{
    public class Team : Information
    {

        private List<Player> playerlist = new List<Player>();
        private List<Coach> coachlist = new List<Coach>();

        public Team() { }
       

        public void TeamMenu()
        {

            int menuchoice = 0;
            while (menuchoice != 13)
            {
                
                Console.WriteLine("Welcome to TEAM MANAGER");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Add player");
                Console.WriteLine("2) Show Player Info");
                Console.WriteLine("3) Find Player");
                Console.WriteLine("4) Remove Player ");
                Console.WriteLine("5) Update Player Info");
                Console.WriteLine("6) Add coach");
                Console.WriteLine("7) Show coach Info");
                Console.WriteLine("8) Find Coach ");
                Console.WriteLine("9) Remove Coach ");
                Console.WriteLine("10) Update Coach Info");
                Console.WriteLine("11) Exit");
                Console.Write("\r\nSelect an option: ");


                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Console.Clear();
                        Addplayer(playerlist);
                        break;
                    case 2:
                        Console.Clear();
                        ShowInformation();
                        break;
                    case 3:
                        Console.Clear();
                        SearchPlayer(playerlist);
                        break;
                    case 4:
                        Console.Clear();
                        RemovePlayer(playerlist);
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePlayer(playerlist);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("What coach do you want to add:");
                        Console.WriteLine("1) Coach");
                        Console.WriteLine("2) HeadCoach");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            AddCoach(coachlist);
                        }
                        else if(n == 2)
                        {
                            AddHeadCoach(coachlist);
                        }
                        break;
                    case 7:
                        Console.Clear();
                        DisplayCoach(coachlist);
                        break;
                    case 8:
                        Console.Clear();
                        SearchCoach(coachlist);
                        break;
                    case 9:
                        Console.Clear();
                        RemoveCoach(coachlist);
                        break;
                    case 10:
                        Console.Clear();
                        UpdateCoach(coachlist);
                        break;
                    case 11:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }

            }
        }

       
        
       
        public void Addplayer(List<Player> playerlist)
        {
            Console.WriteLine("How many player you want to input ? ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-------------Player information----------", i +
               1);
                Player player = new Player();
                player.Input();
                playerlist.Add(player);
            }
        }



        public void ShowInformation()
        {

            Console.WriteLine("---------------Player information----------------");
            for (int i = 0; i < playerlist.Count; i++)
            {
                playerlist[i].ShowInformation();
            }
        }


        public void SearchPlayer(List<Player> playerlist)
        {
            Console.WriteLine("Choose an option you want to search:");
            Console.WriteLine("1) Find player by Name");
            Console.WriteLine("2) Find player by ID");
            Console.WriteLine("3) Find Player by Pos");
            Console.WriteLine("4) Back to the menu");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What's player do you want to search? ");
                    Console.Write("Input name: ");
                    string searchh = Console.ReadLine();
                    for (int i = 0; i < playerlist.Count; i++)
                    {
                        if (playerlist[i].Name.Equals(searchh))
                        {
                            Console.WriteLine("-------------Player information----------");
                            playerlist[i].ShowInformation();
                        }
                       
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("What's id do you want to search? ");
                    Console.Write("Input id: ");
                    int findid = int.Parse(Console.ReadLine());
                    for (int i = 0; i < playerlist.Count; i++)
                    {
                        if (playerlist[i].PlayerID.Equals(findid))
                        {
                            Console.WriteLine("-------------Player information----------");
                            playerlist[i].ShowInformation();
                        }
                       
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("What's position do you want to search? ");
                    Console.Write("Input position: ");
                    string find = Console.ReadLine();
                    for (int i = 0; i < playerlist.Count; i++)
                    {
                        if (playerlist[i].Position.Equals(find))
                        {
                            Console.WriteLine("-------------Player information----------");
                            playerlist[i].ShowInformation();
                        }
                       
                    }
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry, invalid selection");
                    break;
            }
            
        }
        public void RemovePlayer(List<Player> playerlist)
        {
            Console.WriteLine("Chose the option you want to remove by:");
            Console.WriteLine("1) Name");
            Console.WriteLine("2) ID");
            Console.WriteLine("3) Pos");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.Write("Input name you want to remove: ");
                string a = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|----- Player has been removed! -----|");
                Console.WriteLine("|------------------------------------|");
                playerlist.RemoveAll(r => r.Name == a);
            }
            else if (c == 2)
            {
                Console.Write("Input name you want to remove: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|----- Player has been removed! -----|");
                Console.WriteLine("|------------------------------------|");
                playerlist.RemoveAll(r => r.PlayerID == b);
            }
            else if (c == 3)
            {
                Console.Write("Input position you want to remove: ");
                string cd = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|----- Player has been removed! -----|");
                Console.WriteLine("|------------------------------------|");
                playerlist.RemoveAll(r => r.Position == cd);
            }
        }
        public void UpdatePlayer(List<Player> playerlist)
        {
            Console.WriteLine("Enter playerID you want to update:");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter name you want to change:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter position you want to change:");
            string pos = Console.ReadLine();
            Player player = playerlist.FirstOrDefault(x => x.PlayerID == id);
            if (player != null)
            {
                player.Name = name;
                player.Position = pos;
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|----- Player has been updated! -----|");
                Console.WriteLine("|------------------------------------|");
            }
            else
            {
                Console.WriteLine("there is no player with that ID");
            }
        }
        public void AddCoach(List<Coach> coachlist)
        {
            Console.WriteLine("How many coach you want to input ? ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-------------Coach information----------", i +
               1);
                Coach coach = new Coach();
                coach.InputCoach();
                coachlist.Add(coach);
            }
        }
        public void AddHeadCoach(List<Coach> coachlist)
        {
            Console.WriteLine("How many coach you want to input ? ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-------------Coach information----------", i +
               1);
                HeadCoach Hcoach = new HeadCoach();
                Hcoach.InputCoach();
                coachlist.Add(Hcoach);
            }
        }


        public void DisplayCoach(List<Coach> coachlist)
        {
            Console.WriteLine("---------------Coach information----------------");
            for (int i = 0; i < coachlist.Count; i++)
            {
                coachlist[i].ShowInformation();
            }
        }
        public void SearchCoach(List<Coach> coachlist)
        {
            Console.WriteLine("Choose an option you want to search:");
            Console.WriteLine("1) Find coach by Name");
            Console.WriteLine("2) Find coach by ID");
            Console.WriteLine("3) Find coach by Exp");
            Console.WriteLine("4) Back to the menu");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What's coach do you want to search? ");
                    Console.Write("Input name: ");
                    string searchh = Console.ReadLine();
                    for (int i = 0; i < coachlist.Count; i++)
                    {
                        if (coachlist[i].Cname.Equals(searchh))
                        {
                            Console.WriteLine("-------------Coach information----------");
                            coachlist[i].ShowInformation();
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("What's id do you want to search? ");
                    Console.Write("Input id: ");
                    int findid = int.Parse(Console.ReadLine());
                    for (int i = 0; i < coachlist.Count; i++)
                    {
                        if (coachlist[i].CoachID.Equals(findid))
                        {
                            Console.WriteLine("-------------Coach information----------");
                            coachlist[i].ShowInformation();
                        }
                     
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("How many experience do you want to search? ");
                    Console.Write("Input Experience: ");
                    int find = int.Parse(Console.ReadLine());
                    for (int i = 0; i < coachlist.Count; i++)
                    {
                        if (coachlist[i].Experience.Equals(find))
                        {
                            Console.WriteLine("-------------Coach information----------");
                            coachlist[i].ShowInformation();
                        }
                       
                    }
                    break;
                case 4:
                    Console.Clear();
                    break;
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry, invalid selection");
                    break;
            }

        }
        
        public void RemoveCoach(List<Coach> coachlist)
        {
            Console.Write("Input your coach name: ");
            string a = Console.ReadLine();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|----- Coach has been removed! -----|");
            Console.WriteLine("|------------------------------------|");
            coachlist.RemoveAll(r => r.Cname == a);
        }
        public void UpdateCoach(List<Coach> coachlist)
        {
            Console.WriteLine("Enter coachID you want to update:");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter name you want to change:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter experience you want to change:");
            int exp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary you want to change:");
            int salary = Int32.Parse(Console.ReadLine());
            Coach coach = coachlist.FirstOrDefault(x => x.CoachID == id);
            if (coach != null)
            {
                coach.Salary = salary;
                coach.Cname = name;
                coach.Experience = exp;
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|----- Coach has been updated! -----|");
                Console.WriteLine("|------------------------------------|");
            }
            else 
            {
                Console.WriteLine("There is no coach with that ID");
            }
        }
    }

}

