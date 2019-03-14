using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class CharacterCreation
    {
        
        
        public static void genderMenu()
        {
            bool endselect = false;
            List<string> genderSelect = new List<string>()
        {
            "Male",
            "Female",
            "That"
        };
            List<string> yesOrNoSelect = new List<string>()
            {
                "Yes",
                "No"
            };
            List<string> yesOrNoSelectGirl = new List<string>()
            {
                "Yes",
                "WAIT!!! WTF!!! I'm a girl!",
                "No"
            };
            bool MaleGender = false;
            bool FemaleGender = false;
            bool ThatGender = false;
            
            do
            {
                
                string selectedMenuItem = moveMenu(genderSelect);
                switch (selectedMenuItem)
                {
                    case "Male":
                        string[] maleQuestion = { "Are you sure you want to become Male?", "Good boy!", "Damn." };
                        do
                        {
                            Console.Clear();
                            Console.SetCursorPosition((Console.WindowWidth - maleQuestion[0].Length) / 2, Console.CursorTop);
                            Console.WriteLine(maleQuestion[0]);
                            Console.Write("\n\n");
                            string choise = yesOrNo(yesOrNoSelect);
                            switch (choise)
                            {
                                case "Yes":
                                    Console.SetCursorPosition((Console.WindowWidth - maleQuestion[1].Length) / 2, Console.CursorTop);
                                    Console.WriteLine(maleQuestion[1]);
                                    MaleGender = true;
                                    break;
                                case "No":
                                    Console.SetCursorPosition((Console.WindowWidth - maleQuestion[2].Length) / 2, Console.CursorTop);
                                    Console.WriteLine(maleQuestion[2]);
                                    break;
                            }
                        } while (true);
                        break;
                    case "Female":
                        string[] femaleQuestion = {"Are you sure you want to become Female?", "Do you really want to play on hard difficulty?", "Okay retard!", "Okay sry get out there and play :3" , "A wise choise!" , "You will get fucked haha." };
                        do
                        {
                            Console.Clear();
                            Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[0].Length) / 2, Console.CursorTop);
                            Console.WriteLine(femaleQuestion[0]);
                            Console.Write("\n\n");
                            string choise2 = yesOrNo(yesOrNoSelect);
                            switch (choise2)
                            {
                                
                                case "Yes":
                                    do
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[1].Length) / 2, Console.CursorTop);
                                        Console.WriteLine(femaleQuestion[1]);
                                        Console.Write("\n\n");
                                        string choiseGirl = yesOrNoGirl(yesOrNoSelectGirl);
                                        switch (choiseGirl)
                                        {
                                            case "Yes":
                                                Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[2].Length) / 2, Console.CursorTop);
                                                Console.WriteLine(femaleQuestion[2]);
                                                FemaleGender = true;
                                                break;
                                            case "WAIT!!!WTF!!!I'm a girl!":
                                                Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[3].Length) / 2, Console.CursorTop);
                                                Console.WriteLine(femaleQuestion[3]);
                                                FemaleGender = true;
                                                break;
                                            case "No":
                                                Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[4].Length) / 2, Console.CursorTop);
                                                Console.WriteLine(femaleQuestion[4]);
                                                break;
                                        }


                                    } while (true);
                                case "No":
                                    Console.SetCursorPosition((Console.WindowWidth - femaleQuestion[5].Length) / 2, Console.CursorTop);
                                    Console.WriteLine(femaleQuestion[5]);
                                    break;
                            }

                        } while (true);
                        
                    case "That":
                        string[] choosen = { "Deleting the game...", "Ok we count it as a misstype...", "Are you sure you want to become That?" };
                        do
                        {
                            Console.Clear();
                            Console.SetCursorPosition((Console.WindowWidth - choosen[2].Length) / 2, Console.CursorTop);
                            Console.WriteLine(choosen[2]);
                            Console.Write("\n\n");
                            string choise3 = yesOrNo(yesOrNoSelect);
                            switch (choise3)
                            {
                                case"Yes":
                                    Console.SetCursorPosition((Console.WindowWidth - choosen[0].Length) / 2, Console.CursorTop);
                                    Console.WriteLine(choosen[0]);
                                    ThatGender = true;
                                    break;
                                case "No":
                                    Console.SetCursorPosition((Console.WindowWidth - choosen[1].Length) / 2, Console.CursorTop);
                                    Console.WriteLine(choosen[1]);
                                    break;
                            }


                        } while (true);


                }
                Console.Clear();
            } while (endselect == false) ;
           
            }
                  













    static int index = 0;

        public static string yesOrNoGirl(List<string> yesOrNoSelect)
        {
            for (int i = 0; i < yesOrNoSelect.Count; i++)
            {
                if (i == index)
                {
                    Console.SetCursorPosition((Console.WindowWidth - yesOrNoSelect[i].Length) / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(yesOrNoSelect[i]);
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth - yesOrNoSelect[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine(yesOrNoSelect[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == yesOrNoSelect.Count - 1)
                {
                    index = 0;

                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = 2;

                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return yesOrNoSelect[index];
            }
            return "";
        }








        public static string yesOrNo(List<string> yesOrNoSelect)
        {
            for (int i = 0; i < yesOrNoSelect.Count; i++)
            {
                if (i == index)
                {
                    Console.SetCursorPosition((Console.WindowWidth - yesOrNoSelect[i].Length) / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(yesOrNoSelect[i]);
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth - yesOrNoSelect[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine(yesOrNoSelect[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == yesOrNoSelect.Count - 1)
                {
                    index = 0;

                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = 2;

                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return yesOrNoSelect[index];
            }
            return "";
        }











    public static string moveMenu(List<string> genderSelect)
        {
            string choose = "Choose your gender:";
            Console.SetCursorPosition((Console.WindowWidth - choose.Length) / 2, Console.CursorTop);
            Console.WriteLine(choose);
            for (int i = 0; i < genderSelect.Count; i++)
            {
                if (i == index)
                {
                    Console.SetCursorPosition((Console.WindowWidth - genderSelect[i].Length) / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(genderSelect[i]);
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth - genderSelect[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine(genderSelect[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == genderSelect.Count - 1)
                {
                    index = 0;

                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = 2;

                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return genderSelect[index];
            }
            return " ";
        }
        public static void choosenGender(string gender)
        {

        }
    }
}
