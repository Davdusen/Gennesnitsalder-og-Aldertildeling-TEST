using System;
using System.Collections.Generic;
using System.Linq;

namespace AlderTildeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Bruger Liste
            var ages = new List<int>(); //Opretter en liste til at gemme ages variablen.
            string userInput;

            Console.WriteLine("Skriv aldre.");
            Console.WriteLine("Tryk calculate for at afslutte");

            while (true) // Uendelig løkke, indtil brugeren skriver "calculate"
            {
                userInput = Console.ReadLine();

                //Når brugeren skriver "calculate", bryder man ud a while loop og går videre til at beregne gennemsnittet, ude af løkken.
                if (userInput.ToLower() == "calculate")
                {
                    break;
                }

                if (int.TryParse(userInput, out int age)) // Forsøger at konvertere userinput til et heltal
                {
                    ages.Add(age); // Tilføjer den konverterede alder til listen
                }
                else
                {
                    Console.WriteLine("Ugyldigt input, prøv igen."); // Håndterer ugyldigt input
                }
            }

            if (ages.Count > 0) // Tjekker om der er nogen aldre i listen
            {
                float ageAverage = (float)ages.Sum() / ages.Count; // Bruger float for at få decimaler
                Console.WriteLine("Gennemsnitsalderen er: " + ageAverage); // Udskriver gennemsnitsalderen
            }
            else
            {
                Console.WriteLine("Ingen aldre blev indtastet."); // Håndterer tilfælde hvor ingen aldre blev indtastet
            }
        }
    }
}
            */
            //Bruger Array
            Console.WriteLine("Skriv hvor mange mennesker du vil indtaste alder for:");

            int numberOfPeople = int.Parse(Console.ReadLine()); //Læser brugerinput af hvor mange personer der skal gemmes en alder på
            int[] Ages = new int[numberOfPeople]; //Opretter et array til at gemme alder på

            int totalAge = 0; //Variabel til at gemme den totale alder

            for (int i = 0; i < numberOfPeople; i++) //Starter en for loop, som bliver ved med at loope så længe 'i'  er mindre end numberOfPeople
            {
                while (true) //Så længe at der er mindre 'i' end numberOfPeople, så fortsætter loopen
                {
                    Console.WriteLine($"Skriv alder på person {i + 1}:"); //Fortæller brugeren at de skal skrive alderen for hver person med tal som de har skrevet.
                    //fx: hvis de har skrevet at der er 3 mennesker, skriver den: Skriv alder på person 1, skriv alder på person 2, skriv alder på person 3, og derefter stopper.
                    string UserInput = Console.ReadLine();

                    if (int.TryParse(UserInput, out int Age)) //Hvis det som brugeren har skrevet kan blive lavet om til en int, så gør programmet følgende.
                    {
                        Ages[i] = Age; //Ages[i] bliver lavet om til Age
                        totalAge += Age; //Dette er det samme som at sige: totalAge = totalAge + Age; Dette tilføjer derfor brugerinputtet til (totalAge)
                        break; //Stopper "While" loopet or starter derfor forfra med "for" loopet
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt information, skriv venligst et tal"); //Da der ikke står andet her vil programmet blive ved med at skrive dette indtil der bliver givet gyldig data.
                    }
                }
            }
            float AverageAge = (float)totalAge / numberOfPeople; //En float værdi 'AverageAge' som er totalAge / numberOfPeople. Dette giver gennemsnitsalderen
            Console.WriteLine($"Alle alderne til sammen er: {totalAge}"); //Skriver hvad alle aldrene til sammen er
            Console.WriteLine($"Gennemsnitsalderen er: {AverageAge}"); //Skriver gennemsnitsalderen.

            Console.WriteLine("Vil du søge efter en bestemt alder i arrayet?");

            string WantToSearchAnswer = Console.ReadLine();

            if (WantToSearchAnswer.ToLower() == "ja")
            {
                Console.WriteLine("Hvilken person vil du søge efter?");
                string AgeToSearchInput = Console.ReadLine();
                if (int.TryParse(AgeToSearchInput, out int personNumber)) //Vil forsøge at lave det skrevede om til en int ved navn personNumber
                {
                    if (personNumber >= 1 && personNumber <= numberOfPeople) //Hvis personnumber er større eller = 1 og personNumber er mindre = numberOfPeople så gør dette
                    {
                        Console.WriteLine($"Alderen for person {personNumber} er: {Ages[personNumber - 1]}"); //Minusser med 1 fordi arrays altid starter på 0.
                    }
                    else
                        Console.WriteLine("Ugyldigt input, dette tal er ikke på listen");
                }
                else
                {
                    Console.WriteLine("Ugyldigt Input, prøv igen");
                }
            }
        }
    }
}