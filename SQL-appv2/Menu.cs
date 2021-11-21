﻿using System;

namespace SQL_appv2
{
    class Menu
    {
        public void Run()
        {
            bool active = true;

            while (active)
            {
                Console.WriteLine("Hej, vad vill du göra? Välj med siffra nedan");
                Console.WriteLine("1. Hur många länder finns i databasen?");
                Console.WriteLine("2. Är samtliga usernames och passwords unika?");
                Console.WriteLine("3. Hur många är från Norden respektive Skandinavien?");
                Console.WriteLine("4. Vilket är det vanligast förekommande landet?");
                Console.WriteLine("5. Lista de 10 fösta användare vars efternamn börjar på bokstaven L.");
                Console.WriteLine("6. Visa alla användares vars för och efternamn har samma begynnelsebokstav");
                Console.WriteLine("7. Avsluta program.");

            
                string userInput = Console.ReadLine();
                int choice = 0;
                int.TryParse(userInput, out choice);

                switch (choice)
                {
                    case 1:
                        var sql = "SELECT COUNT(DISTINCT country)FROM MOCK_DATA";
                        var dt = SQLClass.GetDataTable(sql);

                        SQLClass.PrintRow(dt); // Printmetdo som skriver ut (dt) som matchar med kod från (sql)

                        Console.ReadLine();
                        Console.Clear();
                    break;
                    case 2:
                        sql = "SELECT COUNT(DISTINCT username)FROM MOCK_DATA"; // sql-string som skickas in till databas för att hämta rätt data.
                        dt = SQLClass.GetDataTable(sql); // tar fram ett table med den data som matchar vår sql-string. Återkommande i programmet.

                        if(dt.Rows.Count == 1000) // Kontrollerar om raderna som hämtas är lika med antalet rader som finns i databasen, stämmer detta inte så är alla username/lösenord ej unika.
                        {
                            Console.WriteLine("Samtliga användrnamn är unika.");
                        }else
                        {
                            Console.WriteLine("Alla användarnamn är ej unika.");
                        }

                        sql = "SELECT COUNT(DISTINCT password)FROM MOCK_DATA";
                        dt = SQLClass.GetDataTable(sql);

                        if (dt.Rows.Count == 1000) 
                        {
                            Console.WriteLine("Samtliga lösenord är unika.");
                        }
                        else
                        {
                            Console.WriteLine("Alla lösenord är ej unika.");
                        }


                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        active = false;
                        break;

                }
            }

        }

    }




}
    
