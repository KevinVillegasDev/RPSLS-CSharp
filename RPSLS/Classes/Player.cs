using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Classes
{
    public class Player
    {   
        //member variables
        public string name;
        public string choice = null;
        List<string> gestures = new List<string>()
            {
                "rock",
                "paper",
                "scissors",
                "lizard",
                "spock"

            };


        //constructor
        public Player(string name)
        {
            this.name = name;
            
            
        }
            

            

        //member methods
        public void ChooseGestures()
        {
            
            Console.WriteLine("Please select a gestures option");
            string gestureOption = Console.ReadLine();
            if(gestureOption == "1")
            {
                choice = gestures[0];
                Console.WriteLine("You picked " + choice);
            }
            else if(gestureOption == "2")
            {
                choice = gestures[1];
                Console.WriteLine("You picked " + choice);
            }
            else if(gestureOption == "3")
            {
                choice = gestures[2];
                Console.WriteLine("You picked " + choice);
            }
            else if(gestureOption == "4")
            {
                choice = gestures[3];
                Console.WriteLine("You picked " + choice);
            }
            else if(gestureOption == "5")
            {
                choice = gestures[4];
                Console.WriteLine("You picked " + choice);
            }

            
        }

        public void DisplayGestures()
        {
            int counter = 1;
            foreach(string gesture in gestures)
            {
                
                Console.WriteLine($"Press {counter} for {gesture}");
                counter++;
            }
        }
    }
}
