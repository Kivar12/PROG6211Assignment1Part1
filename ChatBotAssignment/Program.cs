using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            AddColor();

            AddLogo();
            
            AddSound();

            Console.WriteLine("\n=================||||||||=================");
            var greetingMessage = "Welcome to Cybersecurity Awareness Bot";
            Console.WriteLine(greetingMessage);
            Console.WriteLine("=================||||||||=================\n");


            Console.WriteLine("\nPlease enter your name: ");
            Console.Write("User: ");
            String name = Console.ReadLine();

            GetUserName(name);

            GetUserInput(name);

        }

        static void AddColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        static void AddLogo()
        {
            Console.WriteLine("-----------------########-----------------");
            Console.WriteLine("CBSA");
            Console.WriteLine("The CyberSpace of Security");
            Console.WriteLine("-----------------########-----------------\n");
        }

        static void AddSound()
        {
            SoundPlayer voicePlayer = new SoundPlayer(@"C:\\Users\\lab_services_student\\source\\repos\\ChatBotAssignment\voicemessage.WAV");
            voicePlayer.Load();
            voicePlayer.Play();
        }

        static void GetUserName(String name)
        {
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Welcome to Chatbot " + name + ".");
            Console.WriteLine("Please let me know what you would like for me to do " + name + ".");
            Console.WriteLine("How may I help you " + name + "?");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
        }

        static void GetUserInput(String name)
        {
            Console.Write("User: ");
            String UserInput = Console.ReadLine();

            while (UserInput != "Exit")
            {
                
                if (string.IsNullOrWhiteSpace(UserInput))
                {
                    Console.WriteLine("You did not type anything. Please type something");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");
                }
                else if (UserInput == "How are you?")
                {
                    Console.WriteLine("Chatbot: I am doing good thanks. How may I assist?");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else if (UserInput == "What's your purpose?")
                {
                    Console.WriteLine("Chatbot: My purpose is to help users with any questions or issues they have with Cybersecurity.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");
                }
                else if (UserInput == "What can I ask you about?")
                {
                    Console.WriteLine("Chatbot: You can ask me about anything about cybersecurity such as cybersecurity attacks," +
                                " passwords, types of cybersecurity attacks or vulnerabilities and any other issues  related to cybersecurity.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else if (UserInput == "What is important about password safety?")
                {
                    Console.WriteLine("Chatbot: Password safety is important because it ensures that all your confidential data is protected" +
                        "from anyone who is not authorized to access your data by a strong password that only you know.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else if (UserInput == "What does a password contain?")
                {
                    Console.WriteLine("Chatbot: A password contains a combination of letters, numbers and symbols.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else if (UserInput == "What is phishing?")
                {
                    Console.WriteLine("Chatbot: Phishing is the practice of sending emails to users, tricking users into clicking the email and " +
                        "revealing confidential information such as passwords and PIN numbers by posing as a legitimate organisation.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else if (UserInput == "What is safe browsing?")
                {
                    Console.WriteLine("Chatbot: Safe browsing is a security service that protects users' devices by warning users about the potential " +
                        "dangers when users visit dangerous websites, click on phishing emails or when users download malicious software that harm their devices.");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");

                }
                else
                {
                    Console.WriteLine("Chatbot: I didn't quite understand that. Could you rephrase?");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------\n");
                }

                Console.Write("User: ");
                UserInput = Console.ReadLine();
            }
            
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Thank you for using Chatbot " + name + "." + "\nPlease come back if have any other issues. \nHave a nice day!");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
