using System;

namespace ConsoleApp6
{
    class Program
    {
        private static string spørgsmål, svarSport, svarMusik, svarHovedstader, error;
        private static int overallPoint, pointScore, highScore;
        
        static void Main(string[] args)
        {
            for (int i = 15; i > 0; i--)
            {


                //pointsystem
                Console.WriteLine($"Points: {overallPoint += pointScore} \n");
                pointScore = 0;

                highScore = overallPoint += pointScore;



                //Kategorier
                Console.WriteLine("Vælg en kategori");
                Console.WriteLine("    1: Sport");
                Console.WriteLine("    2: Musik");
                Console.WriteLine("    3: Hovedstader");
                Console.WriteLine(); //ekstra kategori hvis vi har tid
                Console.WriteLine(); //ekstra kategori hvis vi har tid

                //Læser brugerens tast
                String kategorikey = Console.ReadKey().KeyChar.ToString();

                Console.Clear();

                
                    switch (kategorikey)
                    {
                        case "1":
                            spørgsmål = "Sport";
                            break;

                        case "2":
                            spørgsmål = "Musik";
                            break;

                        case "3":
                            spørgsmål = "Hovedstader";
                            break;

                        default:
                            error = "default1";
                            Console.WriteLine("Ugyldig tast.Tryk på hvilken som helst tast for at prøve igen");
                            break;
                    }

                





                //Sværhedsgrad på spørgsmål
                Console.WriteLine("    1: 200$");
                Console.WriteLine("    2: 400$");
                Console.WriteLine("    3: 600$");
                Console.WriteLine("    4: 800$");
                Console.WriteLine("    5: 1000$");


                String svarKey = Console.ReadKey().KeyChar.ToString();

                Console.Clear();



               




                //Hvis Man vælger kategorien Sport kommer man ind i denne case
                if (spørgsmål == "Sport")
                {
                    switch (svarKey)
                    {

                        case "1":
                            svarSport = "200$";
                            Console.WriteLine("Hvor mange spillere er der på banen på hvert et hold i fodbold?");

                            Console.WriteLine("   1: Hvad er 11?");
                            Console.WriteLine("   2: Hvad er 9?");
                            Console.WriteLine("   3: Hvad er 13?");


                            string playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 200;

                            } 
                            break;


                        case "2":
                            svarSport = "400$";
                            Console.WriteLine("Hvad står DBU for?");
                            Console.WriteLine("   1: Hvad er Dansk boldspil-Union?");
                            Console.WriteLine("   2: Hvad er Dansk bold-Union");
                            Console.WriteLine("   3: Hvad er Dansk badminton-Union");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 400;

                            }
                            break;


                        case "3":
                            svarSport = "600$";
                            Console.WriteLine("Hvor mange spillere er der på hvert hold i håndbold?");
                            Console.WriteLine("   1: Hvad er 6?");
                            Console.WriteLine("   2: Hvad er 7?");
                            Console.WriteLine("   3: Hvad er 8?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "2")
                            {
                                pointScore = 600;

                            }
                            break;


                        case "4":
                            svarSport = "800$";
                            Console.WriteLine("Hvem blev kåret som som den bedste fodboldspiller i 2015?");
                            Console.WriteLine("   1: Hvem er Lionel Messi?");
                            Console.WriteLine("   2: Hvem er Christiano Ronaldo?");
                            Console.WriteLine("   3: Hvem er Sergio Ramos");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 800;

                            }
                            break;


                        case "5":
                            svarSport = "1000$";
                            Console.WriteLine("Hvor højt hænger en basketball kurv fra gulvet?");
                            Console.WriteLine("   1: Hvad er 250cm?");
                            Console.WriteLine("   2: Hvad er 270cm?");
                            Console.WriteLine("   3: Hvad er 310cm?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "3")
                            {
                                pointScore = 1000;


                            }
                            break;


                        default:
                            Console.WriteLine("Ugyldig tast. Tryk på hvilken som helst tast for at prøve igen");
                            break;
                    }
                    









                //Hvis Man vælger kategorien Musik kommer man ind i denne case
                }
                else if (spørgsmål == "Musik")
                {

                    switch (svarKey)
                    {

                        case "1":
                            svarMusik = "200$";
                            Console.WriteLine("Hvem har skrevet sangen work (2016)");
                            Console.WriteLine("   1: Hvem er Rihanna?");
                            Console.WriteLine("   2: Hvem er Drake?");
                            Console.WriteLine("   3: Hvem er Ice Cube?");


                            string playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 200;


                            }
                            break;


                        case "2":
                            svarMusik = "400$";
                            Console.WriteLine("Blak har skrevet en sang hvor de synger et pigenavn er nede med det. Hvad er navnet på pigen?");
                            Console.WriteLine("   1: Pia");
                            Console.WriteLine("   2: Mette");
                            Console.WriteLine("   3: Camilla");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "2")
                            {
                                pointScore = 400;


                            }
                            break;


                        case "3":
                            svarMusik = "600$";
                            Console.WriteLine("En sanger der især er helt vild med champagne og lækre modeller");
                            Console.WriteLine("   1: Hvem er Kim Larsen?");
                            Console.WriteLine("   2: Hvem er Snoop dogg?");
                            Console.WriteLine("   3: Hvem er Guld Dreng?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "3")
                            {
                                pointScore = 600;


                            }
                            break;


                        case "4":
                            svarMusik = "800$";
                            Console.WriteLine("Hvad er dj gruppen Major Lazer's største hit?");
                            Console.WriteLine("   1: Hvad er Light it up?");
                            Console.WriteLine("   2: Hvad er Cold Water?");
                            Console.WriteLine("   3: Hvad er Lean On?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 800;


                            }
                            break;


                        case "5":
                            svarMusik = "1000$";
                            Console.WriteLine("Hvem har skrvet ''kærligheden brænder''?");
                            Console.WriteLine("   1: Hvem er Fede Finn & Funny Boyz?");
                            Console.WriteLine("   2: Hvem er Kim Larsen?");
                            Console.WriteLine("   3: Hvem er Thomas Helmig?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 1000;


                            }
                            break;
                    }












                }
                else if (spørgsmål == "Hovedstader")
                {

                    switch (svarKey)
                    {
                        case "1":
                            svarHovedstader = "200$";
                            Console.WriteLine("Hovedstaden i Danmark?");
                            Console.WriteLine("   1: Hvad er København?");
                            Console.WriteLine("   2: Hvad er Grenaa");
                            Console.WriteLine("   3: Hvad er Odense");


                            string playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 200;


                            }
                            break;

                        case "2":
                            svarHovedstader = "400$";
                            Console.WriteLine("Hovedstaden i Sverige?");
                            Console.WriteLine("   1: Hvad er Oslo?");
                            Console.WriteLine("   2: Hvad er Stockholm?");
                            Console.WriteLine("   3: Hvad er Malmø?");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "3")
                            {
                                pointScore = 400;


                            }
                            break;

                        case "3":
                            svarHovedstader = "600$";
                            Console.WriteLine("Hovedstaden i Ungarn?");
                            Console.WriteLine("   1: Hvad er Sofia?");
                            Console.WriteLine("   2: Hvad er Budapest");
                            Console.WriteLine("   3: Hvad er Skopje");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "2")
                            {
                                pointScore = 600;


                            }
                            break;

                        case "4":
                            svarHovedstader = "800$";
                            Console.WriteLine("Hovedstaden i Tyrkiet?");
                            Console.WriteLine("   1: Hvad er Ankara?");
                            Console.WriteLine("   2: Hvad er Alanya?");
                            Console.WriteLine("   3: Hvad er Istanbul");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "1")
                            {
                                pointScore = 800;


                            }
                            break;

                        case "5":
                            svarHovedstader = "1000$";
                            Console.WriteLine("Hovedstaden i Marokko?");
                            Console.WriteLine("   1: Hvad er Lomé?");
                            Console.WriteLine("   2: Hvad er Rabat");
                            Console.WriteLine("   3: Hvad er Antananarivo");


                            playerChoice = Console.ReadKey().KeyChar.ToString();
                            if (playerChoice == "2")
                            {
                                pointScore = 1000;


                            }
                            break;
                    }

                }


                Console.ReadLine();
                Console.Clear();
            }


            Console.WriteLine($"Tillykke din highscore blev: {highScore}");
            Console.ReadLine();

        }
        
    }
}
