namespace Zadanie1 // KLASA, TOSTRING, LISTY
{
    class Płyta // klasa plyta, ToString (szablon) oddajacy informacje o plycie, decyzja cd czy dvd oraz edytujplyte dzieki .this
    {
        public Utwór info, info2, info3, info4, info5;
        public string tytuł;
        public bool cddvd;
        public int czas_trwania;
        public string spis_utworów;
        public string spis_wykonawców;

        public string ToString()
        {
            Console.WriteLine("=========== ALBUM ===========");
            string cd = (cddvd == true) ? "DVD" : "CD";
            return $"Tytuł: {this.tytuł}\nCD czy DVD:" + cd + $"\nCzas trwania albumu: {this.czas_trwania} min\n\nSpis utworów:{this.spis_utworów} \n\nSpis wykonawców: {this.spis_wykonawców}\n=============================";
        }
        public void EdytujPlyte()
        {
            Console.WriteLine("Aktualne dane płyty:");
            Console.WriteLine(this.ToString());

            Console.WriteLine("Podaj nowy tytuł:");
            this.tytuł = Console.ReadLine();

            Console.WriteLine("Podaj rodzaj (CD lub DVD):");
            string rodzaj = Console.ReadLine();
            this.cddvd = (rodzaj.ToLower() == "DVD");

            Console.WriteLine("Podaj czas trwania albumu (w minutach):");
            int czas;
            while (!int.TryParse(Console.ReadLine(), out czas) || czas <= 0)
            {
                Console.WriteLine("Podaj poprawny czas trwania albumu (liczba dodatnia):");
            }
            this.czas_trwania = czas;

            Console.WriteLine("Podaj nowy spis utworów (oddzielaj poszczególne utwory znakiem nowej linii):");
            this.spis_utworów = Console.ReadLine();

            Console.WriteLine("Podaj nowy spis wykonawców (oddzielaj poszczególnych wykonawców znakiem nowej linii):");
            this.spis_wykonawców = Console.ReadLine();

            Console.WriteLine("Dane płyty zostały zaktualizowane:");
            Console.WriteLine(this.ToString());
        }
    }
    class Utwór // klasa utwor, ToString (szablon) oddajacy informacje o utworze
    {
        public int numer;
        public string tytuł_utworu;
        public decimal czas_trwania_utworu;
        public string spis_wykonawców;

        public string ToString()
        {
            Console.WriteLine("=========== UTWÓR ===========");
            return $"Tytuł: {this.tytuł_utworu}," +
                $"\nNumer utworu {this.numer}, " +
                $"\nCzas trwania utworu: {this.czas_trwania_utworu}, " +
                $"\nSpis wykonawców: {this.spis_wykonawców}" +
                $"\n=============================";
        }

        public void EdytujUtwor()
        {
            Console.WriteLine("Aktualne dane utworu:");
            Console.WriteLine(this.ToString());

            Console.WriteLine("Podaj nowy tytuł:");
            this.tytuł_utworu = Console.ReadLine();

            Console.WriteLine("Podaj nowy czas trwania utworu:");
            int czas;
            while (!int.TryParse(Console.ReadLine(), out czas) || czas <= 0)
            {
                Console.WriteLine("Podaj poprawny czas trwania albumu (liczba dodatnia):");
            }
            this.czas_trwania_utworu = czas;

            Console.WriteLine("Podaj nowy spis wykonawców (oddzielaj poszczególnych wykonawców znakiem nowej linii):");
            this.spis_wykonawców = Console.ReadLine();
        }
    }

    internal class Program // program
    {
        static void Main(string[] args)
        {
            // utworzenie listy
            Płyta[] płyty = new Płyta[2];



            ////////////////////////////////////////////////////////////////////////////////

            // lista 1
            płyty[0] = new Płyta();

            płyty[0].tytuł = "NEVERMIND";
            płyty[0].cddvd = true;
            płyty[0].czas_trwania = 48;
            płyty[0].spis_utworów = "\n„Smells Like Teen Spirit” – 5:02\n„In Bloom” – 4:15\n„Come as You Are” – 3:39\n„Breed” – 3:04\n„Lithium” – 4:17\n„Polly” – 2:56\n„Territorial Pissings” – 2:23\n„Drain You” – 3:44\n„Lounge Act” – 2:37\n„Stay Away” – 3:33\n„On a Plain” – 3:17\n„Something in the Way” – 3:51\n„Endless, Nameless” (utwór bonusowy na niektórych wydaniach) – 6:44";
            płyty[0].spis_wykonawców = "\nKurt Cobain – wokal, gitara\r\nDave Grohl – perkusja, chórki\r\nKrist Novoselic – gitara basowa, chórki\r\nChad Channing – perkusja w Polly\r\nKirk Canning – wiolonczela w Something in the Way\r\nButch Vig i Nirvana – produkcja\r\nAndy Wallace – miksowanie";



            płyty[0].info = new Utwór();
            płyty[0].info.numer = 1;
            płyty[0].info.tytuł_utworu = "Smells Like Teen Spirit";
            płyty[0].info.czas_trwania_utworu = 5.02M;
            płyty[0].info.spis_wykonawców = płyty[0].spis_wykonawców;

            płyty[0].info2 = new Utwór();
            płyty[0].info2.numer = 2;
            płyty[0].info2.tytuł_utworu = "Lithium";
            płyty[0].info2.czas_trwania_utworu = 4.16M;
            płyty[0].info2.spis_wykonawców = płyty[0].spis_wykonawców;

            płyty[0].info3 = new Utwór();
            płyty[0].info3.numer = 3;
            płyty[0].info3.tytuł_utworu = "Come as You Are";
            płyty[0].info3.czas_trwania_utworu = 3.39M;
            płyty[0].info3.spis_wykonawców = płyty[0].spis_wykonawców;

            ////////////////////////////////////////////////////////////////////////////////

            // lista 2
            płyty[1] = new Płyta();
            płyty[1].tytuł = "IN UTERO";
            płyty[1].cddvd = false;
            płyty[1].czas_trwania = 42;
            płyty[1].spis_utworów = "\nServe the Servants” – 3:36\r\n„Scentless Apprentice” – 3:47\r\n„Heart-Shaped Box” – 4:41\r\n„Rape Me” – 2:49\r\n„Frances Farmer Will Have Her Revenge on Seattle” – 4:09\r\n„Dumb” – 2:32\r\n„Very Ape” – 1:55\r\n„Milk It” – 3:54\r\n„Pennyroyal Tea” – 3:37\r\n„Radio Friendly Unit Shifter\" – 4:51\r\n„Tourette's” – 1:35\r\n„All Apologies” – 3:51\r\n„Gallons of Rubbing Alcohol Flow Through the Strip” (utwór niedostępny na wydaniach amerykańskich) – 7:31";
            płyty[1].spis_wykonawców = "\nKurt Cobain – wokal, gitara\r\nDave Grohl – perkusja, chórki\r\nKrist Novoselic – gitara basowa, chórki";

            płyty[1].info4 = new Utwór();
            płyty[1].info4.numer = 1;
            płyty[1].info4.tytuł_utworu = "Heart-Shaped Box";
            płyty[1].info4.czas_trwania_utworu = 4.41M;
            płyty[1].info4.spis_wykonawców = płyty[1].spis_wykonawców;

            płyty[1].info5 = new Utwór();
            płyty[1].info5.numer = 2;
            płyty[1].info5.tytuł_utworu = "Rape Me";
            płyty[1].info5.czas_trwania_utworu = 2.49M;
            płyty[1].info5.spis_wykonawców = płyty[1].spis_wykonawców;


            // menu
            bool wyjscie = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("==================================");
                Console.WriteLine("           Wybierz płytę:");
                Console.WriteLine("      a - NEVERMIND - NIRVANA");
                Console.WriteLine("      b - IN UTERO - NIRVANA");
                Console.WriteLine("==================================");
                Console.WriteLine("Jeżeli chcesz sam uzupełnić płytę");
                Console.WriteLine("          KLIKNIJ 'c'");
                Console.WriteLine("==================================");
                Console.WriteLine("      d - EDYTUJ ALBUM");
                Console.WriteLine("      e - EDYTUJ UTWÓR");
                Console.WriteLine("==================================");
                Console.WriteLine("      x - WYJŚCIE      ");
                Console.WriteLine("");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine("Wybrałeś album NEVERMIND");
                        Console.WriteLine($"{płyty[0].ToString()}");
                        Console.WriteLine("\n1 - Smells Like Teen Spirit");
                        Console.WriteLine("2 - Lithium");
                        Console.WriteLine("3 - Come as You Are");


                        string input2 = Console.ReadLine();

                        switch (input2)
                        {
                            case "1":
                                Console.WriteLine("\nWybrałeś utwór Smells Like Teen Spirit\n");
                                Console.WriteLine($"{płyty[0].info.ToString()}");
                                break;

                            case "2":
                                Console.WriteLine("\nWybrałeś utwór Lithium\n");
                                Console.WriteLine($"{płyty[0].info2.ToString()}");
                                break;

                            case "3":
                                Console.WriteLine("\nWybrałeś utwór Come as You Are\n");
                                Console.WriteLine($"{płyty[0].info3.ToString()}");
                                break;

                            default:
                                Console.WriteLine("zle");
                                break;
                        }
                        break;


                    case "b":
                        Console.WriteLine("Wybrałeś album IN UTERO");
                        Console.WriteLine($"{płyty[1].ToString()}");
                        Console.WriteLine("\n1 - Heart-Shaped Box");
                        Console.WriteLine("2 - Rape Me");
                        string input3 = Console.ReadLine();
                        switch (input3)
                        {
                            case "1":
                                Console.WriteLine("\nWybrałeś utwór Heart-Shaped Box\n");
                                Console.WriteLine($"{płyty[1].info4.ToString()}");
                                break;

                            case "2":
                                Console.WriteLine("\nWybrałeś utwór Rape Me\n");
                                Console.WriteLine($"{płyty[1].info5.ToString()}");
                                break;

                            default:
                                Console.WriteLine("Wybrałeś złą literę");
                                break;
                        }
                        break;


                    case "c":
                        string linia1, linia2, linia3, linia4;
                        Console.WriteLine("Wpisz tytuł albumu");
                        linia1 = Console.ReadLine();

                        Console.WriteLine("CD czy DVD");
                        linia2 = Console.ReadLine();

                        Console.WriteLine("Spis utworów");
                        linia3 = Console.ReadLine();

                        Console.WriteLine("Spis wykonawców");
                        linia4 = Console.ReadLine();



                        Console.WriteLine("=========== UTWÓR ===========" +
                        $"Tytuł: {linia1}," +
                            $"\nNumer utworu {linia2}, " +
                            $"\nCzas trwania utworu: {linia3}, " +
                            $"\nSpis wykonawców: {linia4}" +
                            $"\n=============================");
                        break;

                    case "d":
                        Console.WriteLine("Wybierz numer albumu do edycji (1 lub 2):");
                        string numerAlbumu = Console.ReadLine();
                        if (numerAlbumu == "1")
                        {
                            płyty[0].EdytujPlyte();
                        }
                        else if (numerAlbumu == "2")
                        {
                            płyty[1].EdytujPlyte();
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy numer albumu");
                        }
                        break;

                    case "e":
                        Console.WriteLine("Wybierz numer albumu do edycji (1 lub 2):");
                        string numerAlbumu2 = Console.ReadLine();
                        if (numerAlbumu2 == "1")
                        {
                            Console.WriteLine("Wybierz numer utworu do edycji (1,2,3):");
                            string numerutworow = Console.ReadLine();
                            if (numerutworow == "1")
                            {
                                płyty[0].info.EdytujUtwor();
                            }
                            if (numerutworow == "2")
                            {
                                płyty[0].info2.EdytujUtwor();
                            }
                            if (numerutworow == "3")
                            {
                                płyty[0].info3.EdytujUtwor();
                            }
                        }
                        else if (numerAlbumu2 == "2")
                        {
                            Console.WriteLine("Wybierz numer utworu do edycji (1,2):");
                            string numerutworow = Console.ReadLine();
                            if (numerutworow == "1")
                            {
                                płyty[0].info4.EdytujUtwor();
                            }
                            if (numerutworow == "1")
                            {
                                płyty[0].info5.EdytujUtwor();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Nieprawidłowy numer albumu");
                        }
                        break;

                    case "x":
                        Console.WriteLine("Wyjście z menu");
                        wyjscie = true; // Ustawienie flagi zakończenia menu
                        break;
                }
            } while (!wyjscie);

        }
    }
}