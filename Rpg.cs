using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami
{
    class Rpg
    {
        string gender;
        bool endselect = false;

        public void Game()
        {

            do
            {

            
            Console.WriteLine("Please choose your gender: 1)Male 2)Female 3)That");
            gender = Console.ReadLine();

            bool MaleGender = false;
            bool FemaleGender = false;
            bool ThatGender = false;


            switch (gender)
            {
                case "1":
                    string choise;
                    Console.WriteLine("Are you sure you want to become Male? (yes or no)");
                    choise = Console.ReadLine();
                    if(choise == "yes")
                    {
                        Console.WriteLine("Good boy!");
                            MaleGender = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Damn.");
                        continue;
                    }
                    case "2":
                        string choise2;
                        Console.WriteLine("Are you sure you want to become Female? (yes or no)");
                        choise2 = Console.ReadLine();
                        if (choise2 == "yes")
                        {
                            Console.WriteLine("Do you really want to play on hard difficulty? (yes, wait wtf i am a girl or no");
                            string insideanswer = Console.ReadLine();
                            if(insideanswer == "yes")
                            {
                                Console.WriteLine("Okay retard!");
                            }
                            else if(insideanswer == "wait wtf i am a girl")
                            {
                                Console.WriteLine("Okay sry get out there and play :3");
                            }
                            else if (insideanswer == "no")
                            {
                                Console.WriteLine("A wise choise!");
                            }

                            FemaleGender = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You will get fucked haha.");
                            continue;
                        }
                    case "3":
                        string choise3;
                        Console.WriteLine("Are you sure you want to become That? (yes or no)");
                        choise3 = Console.ReadLine();
                        if (choise3 == "yes")
                        {
                            Console.WriteLine("Deleting the game...");
                            ThatGender = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ok we count it as a misstype...");
                            continue;
                        }


                }
            } while (endselect == false);
        }

    }
}
