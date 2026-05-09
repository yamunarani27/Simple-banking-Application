
bool backtillstartmeny =true;

while (backtillstartmeny)
{
    //välkommen meddlande  
    Console.WriteLine("Hej ! Välkommen till ABC bank ! ");

    //variabeldeklaration
    string username = "petter";
    string password = "abc123!";
    string meddelande = "";
    Decimal saldo = 10000;

    //ange uppgifter
    Console.Write("Ange användarnamn : ");
    string enteredusername = Console.ReadLine();

    Console.Write("Ange lösenord : ");
    string enteredpassword = Console.ReadLine();

    //start meny
    Console.WriteLine("Tryck 1 eller 2");
    Console.WriteLine(" 1.Logga in ");
    Console.WriteLine(" 2.Avsluta ");

    int choice = int.Parse(Console.ReadLine());

    
    //inloggningsvillkor
    if (choice == 1)
    {
        
        //kontrollera rätt uppgifter
        if (enteredusername == username && enteredpassword == password)
        {
            Console.WriteLine("Välkommen, Petter! ");
            Console.WriteLine("Ditt saldo: 10000 kr ");

            //Meny efter inloggning
            Console.WriteLine("Tryck 1,2 eller 3 för att fortsätta!");
            Console.WriteLine("1.Ta ut pengar");
            Console.WriteLine("2.Sätta in pengar");
            Console.WriteLine("3.Logga ut");
            int alternativ = int.Parse(Console.ReadLine());

            //ta ut pengar
            if (alternativ == 1)
            {
                //Ange Uttagssbelopp
                Console.Write("Hur mycket pengar?");
                Decimal Uttagsbelopp = Decimal.Parse(Console.ReadLine());

                if (Uttagsbelopp < saldo)
                {
                    meddelande = $"Ditt saldo : {saldo - Uttagsbelopp} kr";// saldot uppdateras
                }
                else
                {
                    meddelande = $"Inmatade pengar är större än den som finns på kontot ";
                }
                Console.WriteLine(meddelande);
                backtillstartmeny = false;

            }
            //sätta in pengar
            else if (alternativ == 2)
            {
                //Ange insättningsbelopp
                Console.Write("Hur mycket pengar?");
                Decimal insättningsbelopp = Decimal.Parse(Console.ReadLine());

                if (insättningsbelopp <= 50000)
                {
                    meddelande = $"Ditt saldo : {saldo + insättningsbelopp} kr";// saldot uppdateras
                }
                else
                {
                    meddelande = $"Man kan sätta in max 50k kronor";
                }
                Console.WriteLine(meddelande);
                backtillstartmeny = false;

            }
            //logga ut
            else if (alternativ == 3)

            {
                Console.WriteLine("Du är nu utloggad !Återgår till startmenyn");
                Console.WriteLine(); 
                backtillstartmeny = true;
            }
            else
            {
                Console.WriteLine("Ogiltigt val");
                backtillstartmeny = false;

            }
        }
        //ogiltiga inmatningar
        else
        {
            Console.WriteLine("Inloggningen misslyckades.Ogiltigt användarnamn eller lösenord.");
            backtillstartmeny = false;
        }
    }
    //avsluta
    else if(choice==2)
    {
        // gör ingenting
        backtillstartmeny = false;
    }
    else
    {
        Console.WriteLine("Ogiltigt val");
        backtillstartmeny = false;

    }
}

