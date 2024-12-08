using System;

public class TextAdventure
{
    public static void Main(string[] args)
    {
        Console.WriteLine("The snowstorm is heavily covering the road between Kırşehir and Bursa. You grip the steering wheel tighter, squinting your eyes under the storm. Your goal is to reach Bursa before sunrise.");
        Console.WriteLine("However, your car shakes and comes to a halt. When you look at the fuel gauge, you see that the fuel is out.");
        Console.WriteLine("What's your name driver?");
        string playerName = Console.ReadLine();
        Console.WriteLine($"\n{playerName}, it seems we have a problem. What's your first move?");


        Console.WriteLine("\na) Check your phone.");
        Console.WriteLine("b) Check if there’s anything useful in the car.");
        Console.WriteLine("c) Try to stop a passing car.");
        string choice1 = Console.ReadLine();


        if (choice1 == "a")
        {
            Console.WriteLine($"\nNo signal. What will you do now, {playerName}?");
            Console.WriteLine("a) Search the car to see if there's anything useful.");
            Console.WriteLine("b) Try to stop a passing car.");
            string choice2 = Console.ReadLine();

            if (choice2 == "a")
            {
                Console.WriteLine($"\nYou find an old blanket and a half-eaten packet of crisps. Doesn't look like it's gonna help much. What will you do, {playerName}?");
                Console.WriteLine("a) Try to stop a passing car.");
                Console.WriteLine("b) Give up and wait for someone to find you.");
                string choice3 = Console.ReadLine();

                if (choice3 == "a")
                {
                    Console.WriteLine($"\nYou stand by the road and wave. A car is approaching. It's the police! What will you do, {playerName}?");
                    Console.WriteLine("a) Explain your situation and ask for help.");
                    Console.WriteLine("b) You hope they leave you alone because you're afraid of getting in trouble.");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "a")
                    {
                        Console.WriteLine($"\nThe police are sympathetic and will call a tow truck for you. You are safe, {playerName}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nThe cops are questioning you and eventually they help you. {playerName}, you should be a little more careful.");
                    }
                }
                else
                {
                    Console.WriteLine($"\nYou waited for hours, {playerName}, and finally a tow truck driver found you. You're safe now, but you should have been more careful.");
                }
            }
            else
            {
                Console.WriteLine($"\nA truck driver stops. He's grumpy but offers you a ride to Ankara. What do you say, {playerName}?");
                Console.WriteLine("a) 'Ankara? No way! I need to get to Bursa.'");
                Console.WriteLine("b) 'Alright, better than freezing here. Thanks.'");
                string choice3 = Console.ReadLine();

                if (choice3 == "a")
                {
                    Console.WriteLine($"\nThe truck driver shrugs and drives off. You're alone again. What will you do now, {playerName}?");
                    Console.WriteLine("a) Check your phone again; maybe there’s a signal now.");
                    Console.WriteLine("b) Search the car again, maybe you missed something.");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "a")
                    {
                        Console.WriteLine($"\nStill no signal. {playerName}, you're out of luck. You're freezing to death.");
                    }
                    else
                    {
                        Console.WriteLine($"\nYou didn't find anything this time either. {playerName}, don't give up hope and keep waiting.");
                    }
                }
                else
                {
                    Console.WriteLine($"\nHours later, you arrive in Ankara. You're far away from Bursa! What will you do, {playerName}?");
                    Console.WriteLine("a) Call a friend for help.");
                    Console.WriteLine("b) Try to find a bus to Bursa.");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "a")
                    {
                        Console.WriteLine($"\nYour friend is coming to pick you up. {playerName}, you've finally reached Bursa!");
                    }
                    else
                    {
                        Console.WriteLine($"\nYou find a bus to Bursa and set off. {playerName}, you will finally reach your destination!");
                    }
                }
            }
        }
        else if (choice1 == "b")
        {
            Console.WriteLine($"\nYou find an old blanket and a half-eaten packet of crisps. Doesn't look like it's gonna help much. What will you do, {playerName}?");
            Console.WriteLine("a) Try to stop a passing car.");
            Console.WriteLine("b) Give up and wait for someone to find you.");
            string choice2 = Console.ReadLine();

            if (choice2 == "a")
            {
                Console.WriteLine($"\nYou stand by the road and wave. A car is approaching. It's the police! What will you do, {playerName}?");
                Console.WriteLine("a) Explain your situation and ask for help.");
                Console.WriteLine("b) You hope they leave you alone because you're afraid of getting in trouble.");
                string choice3 = Console.ReadLine();

                if (choice3 == "a")
                {
                    Console.WriteLine($"\nThe police are sympathetic and will call a tow truck for you. You are safe, {playerName}.");
                }
                else
                {
                    Console.WriteLine($"\nThe cops are questioning you and eventually they help you. {playerName}, you should be a little more careful.");
                }
            }
            else
            {
                Console.WriteLine($"\nYou didn't find anything this time either. {playerName}, don't give up hope and keep waiting.");
                string choice3 = Console.ReadLine();

                if (choice3 == "a")
                {
                    Console.WriteLine($"\nA truck driver stops. He's grumpy but offers you a ride to Ankara. What do you say, {playerName}?");
                    Console.WriteLine("a) 'Ankara? No way! I need to get to Bursa.'");
                    Console.WriteLine("b) 'Alright, better than freezing here. Thanks.'");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "a")
                    {
                        Console.WriteLine($"\nThe truck driver shrugs and drives off. You're alone again. What will you do now, {playerName}?");
                        Console.WriteLine("a) Check your phone again; maybe there’s a signal now.");
                        Console.WriteLine("b) Search the car again, maybe you missed something.");
                        string choice8 = Console.ReadLine();

                        if (choice4 == "a")
                        {
                            Console.WriteLine($"\nStill no signal. {playerName}, you're out of luck. You're freezing to death.");
                        }
                        else
                        {
                            Console.WriteLine($"\nYou didn't find anything this time either. {playerName}, don't give up hope and keep waiting.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nHours later, you arrive in Ankara. You're far away from Bursa! What will you do, {playerName}?");
                        Console.WriteLine("a) Call a friend for help.");
                        Console.WriteLine("b) Try to find a bus to Bursa.");
                        string choice7 = Console.ReadLine();

                        if (choice4 == "a")
                        {
                            Console.WriteLine($"\nYour friend is coming to pick you up. {playerName}, you've finally reached Bursa!");
                        }
                        else
                        {
                            Console.WriteLine($"\nYou find a bus to Bursa and set off. {playerName}, you will finally reach your destination!");
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"\nYou waited for hours, {playerName}, and finally a tow truck driver found you. You're safe now, but you should have been more careful.");
                }
            }
        }
        else
        {
            Console.WriteLine($"\nA truck driver stops. He's grumpy but offers you a ride to Ankara. What do you say, {playerName}?");
            Console.WriteLine("a) 'Ankara? No way! I need to get to Bursa.'");
            Console.WriteLine("b) 'Alright, better than freezing here. Thanks.'");
            string choice2 = Console.ReadLine();

            if (choice2 == "a")
            {
                Console.WriteLine($"\nThe truck driver shrugs and drives off. You're alone again. What will you do now, {playerName}?");
                Console.WriteLine("a) Check your phone again; maybe there’s a signal now.");
                Console.WriteLine("b) Search the car again, maybe you missed something.");
                string choice4 = Console.ReadLine();

                if (choice4 == "a")
                {
                    Console.WriteLine($"\nStill no signal. {playerName}, you're out of luck. You're freezing to death.");
                }
                else
                {
                    Console.WriteLine($"\nYou didn't find anything this time either. {playerName}, don't give up hope and keep waiting.");
                }
            }
            else
            {
                Console.WriteLine($"\nHours later, you arrive in Ankara. You're far away from Bursa! What will you do, {playerName}?");
                Console.WriteLine("a) Call a friend for help.");
                Console.WriteLine("b) Try to find a bus to Bursa.");
                string choice4 = Console.ReadLine();

                if (choice4 == "a")
                {
                    Console.WriteLine($"\nYour friend is coming to pick you up. {playerName}, you've finally reached Bursa!");
                }
                else
                {
                    Console.WriteLine($"\nYou find a bus to Bursa and set off. {playerName}, you will finally reach your destination!");
                }
            }
        }

        Console.ReadKey();
    }
}