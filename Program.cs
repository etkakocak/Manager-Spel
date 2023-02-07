using System;
using System.Collections.Generic;

namespace managerspel
{
    class Program
    {
        static void Main(string[] args)
        {
            lag dittlag;
            List<lag> serie = new List<lag>();
            lag fenerbahce = new lag("Fenerbahce SK", 137);
            fenerbahce.lrspelare("10- Mesut ÖZIL");
            fenerbahce.lrspelare("17- Irfan Can KAHVECI");
            fenerbahce.lrspelare("27- Miguel CRESPO");
            fenerbahce.lrspelare("13- Enner Goat VALENCIA");
            serie.Add(fenerbahce);

            lag galatasaray = new lag("Galatasaray", 106);
            galatasaray.lrspelare("7- Kerem AKTURKOGLU");
            galatasaray.lrspelare("67- Halil DERVISOGLU");
            galatasaray.lrspelare("25- Victor NELSSON");
            galatasaray.lrspelare("21- Olimpiu MORUTAN");
            serie.Add(galatasaray);

            lag besiktas = new lag("Besiktas JK", 108);
            besiktas.lrspelare("50- Guven YALCIN");
            besiktas.lrspelare("18- Rachid GHEZZAL");
            besiktas.lrspelare("17- Cyle LARIN");
            besiktas.lrspelare("15- Miralen PJANIC");
            serie.Add(besiktas);

            lag trabzon = new lag("Trabzonspor", 107);
            trabzon.lrspelare("18- Edin VISCA");
            trabzon.lrspelare("17- Marek HAMSIK");
            trabzon.lrspelare("9- Anthony NWAKAEME");
            trabzon.lrspelare("14- Andreas CORNELIUS");
            serie.Add(trabzon);

            lag basaksehir = new lag("Istanbul Basaksehir FK", 60);
            basaksehir.lrspelare("22- Fredrik GULBRANDSEN");
            basaksehir.lrspelare("77- Stefano OKAKA");
            basaksehir.lrspelare("21- Mahmut TEKDEMIR");
            basaksehir.lrspelare("42- Ömer Ali SAHINER");
            serie.Add(basaksehir);

            lag adana = new lag("Adana Demirspor", 40);
            adana.lrspelare("9- Mario BALOTELLI");
            adana.lrspelare("23- Yunus AKGUN");
            adana.lrspelare("67- Birkir BJARNASON");
            adana.lrspelare("88- Gökhan INLER");
            serie.Add(adana);

            lag konya = new lag("Konyaspor", 35);
            konya.lrspelare("7- Zymer BYTYQI");
            konya.lrspelare("14- Soner DIKMEN");
            konya.lrspelare("42- Abdulkerim BARDAKCI");
            konya.lrspelare("8- Amar RAHMANOVIC");
            serie.Add(konya);

            lag sivas = new lag("Sivasspor", 30);
            sivas.lrspelare("9- Mustapha YATABARE");
            sivas.lrspelare("17- Erdogan YESILYURT");
            sivas.lrspelare("16- Pedro HENRIQUE");
            sivas.lrspelare("37- Hakan ARSLAN");
            serie.Add(sivas);

            List<string> spelarlista_fen = fenerbahce.getspelare();
            List<string> spelarlista_gal = galatasaray.getspelare();
            List<string> spelarlista_bjk = besiktas.getspelare();
            List<string> spelarlista_ts = trabzon.getspelare();
            List<string> spelarlista_bfk = basaksehir.getspelare();
            List<string> spelarlista_ads = adana.getspelare();
            List<string> spelarlista_kon = konya.getspelare();
            List<string> spelarlista_siv = sivas.getspelare();



            Console.WriteLine("Välkommen till Managerspel Superlig...");
            Console.WriteLine("Du börjar som en huvudtränare och ska styra ett lag.");
            Console.WriteLine("Vi börjar med att lära ditt namn:");
            string mnamn = Console.ReadLine();
            Console.WriteLine("Välkommen Herr " + mnamn + "...");
            Console.ReadLine();


            Console.WriteLine("Välj ditt lag:");
            Console.WriteLine("1- Fenerbahce SK");
            Console.WriteLine("2- Galatasaray");
            Console.WriteLine("3- Besiktas JK");
            Console.WriteLine("4- Trabzonspor");
            Console.WriteLine("5- Istanbul Basaksehir FK");
            Console.WriteLine("6- Adana Demirspor");
            Console.WriteLine("7- Konyaspor");
            Console.WriteLine("8- Sivasspor");

            string lagnummer = Console.ReadLine();
            if (lagnummer == "1")
            {
                dittlag = fenerbahce;
            }
            else if (lagnummer == "2")
            {
                dittlag = galatasaray;
            }
            else if (lagnummer == "3")
            {
                dittlag = besiktas;
            }
            else if (lagnummer == "4")
            {
                dittlag = trabzon;
            }
            else if (lagnummer == "5")
            {
                dittlag = basaksehir;
            }
            else if (lagnummer == "6")
            {
                dittlag = adana;
            }
            else if (lagnummer == "7")
            {
                dittlag = konya;
            }
            else
            {
                dittlag = sivas;
            }

            int lagpoang = dittlag.getlagpo();
            string lagnamn = dittlag.getnynamn();
            List<string> spelarlista = dittlag.getspelare();
            int val = 0;
            while (val != 4)
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1- Värva eller sälja spelare");
                Console.WriteLine("2- Fixa din speltaktik");
                Console.WriteLine("3- Simulera till första match");
                Console.WriteLine("4- Ge upp och avgå");
                val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    int budget = 3000000;
                    int val_t = 0;
                    while (val_t != 3)
                    {
                        Console.WriteLine("Vad vill du göra?");
                        Console.WriteLine("1- Sälja spelare");
                        Console.WriteLine("2- Värva nya spelare");
                        Console.WriteLine("3- Tillbaka till meny");
                        val_t = Convert.ToInt32(Console.ReadLine());
                        if (val_t == 1)
                        {
                            int val_t1 = 0;
                            while (val_t1 != 4)
                            {
                                Console.WriteLine("Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                Console.WriteLine("Spelare som du får sälja:");
                                Console.WriteLine("1- Ferdi Beyoglu (-5 lagpoäng och +100.000 Euro budget)");
                                Console.WriteLine("2- Mehmed Kazan (-8 lagpoäng och +300.000 Euro budget)");
                                Console.WriteLine("3- Enes Esoglu (-15 lagpoäng och +1.100.000 Euro budget)");
                                Console.WriteLine("4- Gå ut");
                                val_t1 = Convert.ToInt32(Console.ReadLine());
                                if (val_t1 == 1)
                                {
                                    budget = budget + 100000;
                                    lagpoang = lagpoang - 5;
                                    Console.WriteLine("Du sålde spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                    Console.ReadLine();
                                }
                                else if (val_t1 == 2)
                                {
                                    budget = budget + 300000;
                                    lagpoang = lagpoang - 8;
                                    Console.WriteLine("Du sålde spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                    Console.ReadLine();
                                }
                                else if (val_t1 == 3)
                                {
                                    budget = budget + 1100000;
                                    lagpoang = lagpoang - 15;
                                    Console.WriteLine("Du sålde spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (val_t == 2)
                        {
                            int val_t2 = 0;
                            while (val_t2 != 4)
                            {
                                Console.WriteLine("Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                Console.WriteLine("Spelare som är lediga för att sälja:");
                                Console.WriteLine("1- Gedson Fernandes (+20 lagpoäng och -2.000.000 Euro budget)");
                                Console.WriteLine("2- Ali Akman (+13 lagpoäng och -1.050.000 Euro budget)");
                                Console.WriteLine("3- Cristiano Ronaldo (+50 lagpoäng och -4.500.000 Euro budget)");
                                Console.WriteLine("4- Gå ut");
                                val_t2 = Convert.ToInt32(Console.ReadLine());
                                if (val_t2 == 1)
                                {
                                    if (budget < 2000000)
                                    {
                                        Console.WriteLine("Du får inte värva spelaren eftersom du har inte tillräcklig med budget!");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        budget = budget - 2000000;
                                        lagpoang = lagpoang + 20;
                                        spelarlista.Add("71- Gedson FERNANDES");
                                        Console.WriteLine("Du köpte spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                        Console.ReadLine();
                                    }
                                }
                                else if (val_t2 == 2)
                                {
                                    if (budget < 1050000)
                                    {
                                        Console.WriteLine("Du får inte värva spelaren eftersom du har inte tillräcklig med budget!");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        budget = budget - 1050000;
                                        lagpoang = lagpoang + 13;
                                        spelarlista.Add("72- Ali AKMAN");
                                        Console.WriteLine("Du köpte spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                        Console.ReadLine();
                                    }
                                }
                                else if (val_t2 == 3)
                                {
                                    if (budget < 4500000)
                                    {
                                        Console.WriteLine("Du får inte värva spelaren eftersom du har inte tillräcklig med budget!");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        budget = budget - 4500000;
                                        lagpoang = lagpoang + 50;
                                        spelarlista.Add("73- Cristiano RONALDO");
                                        Console.WriteLine("Du köpte spelaren. Du har just nu " + budget + " Euro budget. Och ditt lagpoäng är " + lagpoang + ".");
                                        Console.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (val == 2)
                {
                    string spelsystem = "4-4-2";
                    string speltaktik = "Balanserad";
                    Console.WriteLine("Nuvarande spelsystem: " + spelsystem);
                    Console.WriteLine("Välj ny spelsystem. (3-5-2, 4-4-2, 5-3-2, 4-3-3)");
                    spelsystem = Console.ReadLine();
                    Console.WriteLine("Nuvarande speltaktik " + speltaktik);
                    Console.WriteLine("Välj ny speltaktik. (Extremt Defansif, Defansif, Balanserad, Offensiv, Extremt Offensiv)");
                    speltaktik = Console.ReadLine();
                    if (spelsystem == "3-5-2")
                    {
                        lagpoang = lagpoang + 15;
                    }
                    else if (spelsystem == "4-3-3")
                    {
                        lagpoang = lagpoang - 5;
                    }
                    if (speltaktik == "Extremt Defansif" || speltaktik == "Defansif")
                    {
                        lagpoang = lagpoang + 6;
                    }
                    else if (speltaktik == "Offensiv" || speltaktik == "Extremt Offensiv")
                    {
                        lagpoang = lagpoang - 5;
                    }
                    Console.WriteLine("Nuvarande spelsystem: " + spelsystem);
                    Console.WriteLine("Nuvarande speltaktik: " + speltaktik);
                    Console.ReadLine();
                }
                else if (val == 3)
                {
                    int pfen = 0;
                    int pgal = 0;
                    int pbjk = 0;
                    int pts = 0;
                    int pbfk = 0;
                    int pads = 0;
                    int pkon = 0;
                    int psiv = 0;
                    Console.WriteLine("Vi börjar med att köra matcher och nu är transferwindow är stängt och du kan inte ändra din taktik längre...");
                    Console.ReadLine();

                    //VECKA1
                    Console.WriteLine("VECKA 1");
                    Console.ReadLine();

                    Console.WriteLine("Fenerbahce SK mot Sivasspor:");
                    int x = 0;
                    int y = 0;
                    if (fenerbahce.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    Random number = new Random();
                    int goal_fener = number.Next(0, x);
                    int goal_sivas = number.Next(0, y);
                    for (int i = 0; i < goal_fener;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_sivas;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Fenerbahce SK " + goal_fener + "-" + goal_sivas + " Sivasspor");
                    if (goal_fener > goal_sivas)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener < goal_sivas)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Konyaspor mot Galatasaray:");
                    if (galatasaray.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala = number.Next(0, x);
                    int goal_konya = number.Next(0, y);
                    for (int i = 0; i < goal_gala;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_konya;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Galatasaray " + goal_gala + "-" + goal_konya + " Konyaspor");
                    if (goal_gala > goal_konya)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala < goal_konya)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Adana Demirspor mot Besiktas JK:");
                    if (besiktas.getlagpo() - adana.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (besiktas.getlagpo() - adana.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bes = number.Next(0, x);
                    int goal_ada = number.Next(0, y);
                    for (int i = 0; i < goal_bes;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    for (int i = 0; i < goal_ada;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANA DEMIRSPOR " + spelarlista_ads[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Adana Demirspor " + goal_ada + "-" + goal_bes + " Besiktas JK");
                    if (goal_bes > goal_ada)
                    {
                        pbjk = pbjk + 3;
                    }
                    else if (goal_bes < goal_ada)
                    {
                        pads = pads + 3;
                    }
                    else
                    {
                        pbjk = pbjk + 1;
                        pads = pads + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Istanbul Basaksehir FK mot Trabzonspor:");
                    if (trabzon.getlagpo() - basaksehir.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (trabzon.getlagpo() - basaksehir.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_tra = number.Next(0, x);
                    int goal_bas = number.Next(0, y);
                    for (int i = 0; i < goal_tra;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    for (int i = 0; i < goal_bas;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Istanbul Basaksehir FK " + goal_bas + "-" + goal_tra + " Trabzonspor");
                    if (goal_tra > goal_bas)
                    {
                        pts = pts + 3;
                    }
                    else if (goal_tra < goal_bas)
                    {
                        pbfk = pbfk + 3;
                    }
                    else
                    {
                        pts = pts + 1;
                        pbfk = pbfk + 1;
                    }
                    Console.ReadLine();


                    //VECKA2
                    Console.WriteLine("VECKA 2");
                    Console.ReadLine();

                    Console.WriteLine("Fenerbahce SK mot Konyaspor:");
                    if (fenerbahce.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener2 = number.Next(0, x);
                    int goal_konya2 = number.Next(0, y);
                    for (int i = 0; i < goal_fener2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_konya2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Fenerbahce SK " + goal_fener2 + "-" + goal_konya2 + " Konyaspor");
                    if (goal_fener2 > goal_konya2)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener2 < goal_konya2)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Sivaspor mot Adana Demirspor:");
                    if (adana.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (adana.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_adana2 = number.Next(0, x);
                    int goal_sivas2 = number.Next(0, y);
                    for (int i = 0; i < goal_adana2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANA DEMIRSPOR " + spelarlista_ads[index]);
                    }
                    for (int i = 0; i < goal_sivas2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Sivasspor " + goal_sivas2 + "-" + goal_adana2 + " Adana Demirspor");
                    if (goal_adana2 > goal_sivas2)
                    {
                        pads = pads + 3;
                    }
                    else if (goal_adana2 < goal_sivas2)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pads = pads + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Galatasaray mot Istanbul Basaksehir FK:");
                    if (galatasaray.getlagpo() - basaksehir.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - basaksehir.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala2 = number.Next(0, x);
                    int goal_bas2 = number.Next(0, y);
                    for (int i = 0; i < goal_gala2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_bas2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Galatasaray " + goal_gala2 + "-" + goal_bas2 + " Istanbul Basaksehir FK");
                    if (goal_gala2 > goal_bas2)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala2 < goal_bas2)
                    {
                        pbfk = pbfk + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        pbfk = pbfk + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Besiktas JK mot Trabzonspor:");
                    if (besiktas.getlagpo() - trabzon.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (besiktas.getlagpo() - trabzon.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bes2 = number.Next(0, x);
                    int goal_tra2 = number.Next(0, y);
                    for (int i = 0; i < goal_bes2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    for (int i = 0; i < goal_tra2;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Besiktas JK " + goal_bes2 + "-" + goal_tra2 + " Trabzonspor");
                    if (goal_bes2 > goal_tra2)
                    {
                        pbjk = pbjk + 3;
                    }
                    else if (goal_bes2 < goal_tra2)
                    {
                        pts = pts + 3;
                    }
                    else
                    {
                        pbjk = pbjk + 1;
                        pts = pts + 1;
                    }
                    Console.ReadLine();

                    //VECKA3
                    Console.WriteLine("VECKA 3");
                    Console.ReadLine();

                    Console.WriteLine("Adana Demirspor mot Fenerbahce SK:");
                    if (fenerbahce.getlagpo() - adana.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - adana.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener3 = number.Next(0, x);
                    int goal_ada3 = number.Next(0, y);
                    for (int i = 0; i < goal_fener3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_ada3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANA DEMIRSPOR " + spelarlista_ads[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Adana Demirspor " + goal_ada3 + "-" + goal_fener3 + " Fenerbahce SK");
                    if (goal_fener3 > goal_ada3)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener3 < goal_ada3)
                    {
                        pads = pads + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pads = pads + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Istanbul Basaksehir FK mot Konyaspor:");
                    if (basaksehir.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (basaksehir.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bas3 = number.Next(0, x);
                    int goal_konya3 = number.Next(0, y);
                    for (int i = 0; i < goal_bas3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    for (int i = 0; i < goal_konya3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Istanbul Basaksehir FK " + goal_bas3 + "-" + goal_konya3 + " Konyaspor");
                    if (goal_bas3 > goal_konya3)
                    {
                        pbfk = pbfk + 3;
                    }
                    else if (goal_bas3 < goal_konya3)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pbfk = pbfk + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Trabzonspor mot Sivasspor:");
                    if (trabzon.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (trabzon.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_tra3 = number.Next(0, x);
                    int goal_sivas3 = number.Next(0, y);
                    for (int i = 0; i < goal_tra3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    for (int i = 0; i < goal_sivas3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Trabzonspor " + goal_tra3 + "-" + goal_sivas3 + " Sivasspor");
                    if (goal_tra3 > goal_sivas3)
                    {
                        pts = pts + 3;
                    }
                    else if (goal_tra3 < goal_sivas3)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pts = pts + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Besiktas JK mot Galatasaray:");
                    if (galatasaray.getlagpo() - besiktas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - besiktas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala3 = number.Next(0, x);
                    int goal_bes3 = number.Next(0, y);
                    for (int i = 0; i < goal_gala3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_bes3;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Besiktas JK " + goal_bes3 + "-" + goal_gala3 + " Galatasaray");
                    if (goal_gala3 > goal_bes3)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala3 < goal_bes3)
                    {
                        pbjk = pbjk + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        pbjk = pbjk + 1;
                    }
                    Console.ReadLine();

                    //VECKA4
                    Console.WriteLine("VECKA 4");
                    Console.ReadLine();

                    Console.WriteLine("Fenerbahce SK mot Istanbul Basaksehir FK:");
                    if (fenerbahce.getlagpo() - basaksehir.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - basaksehir.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener4 = number.Next(0, x);
                    int goal_bas4 = number.Next(0, y);
                    for (int i = 0; i < goal_fener4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_bas4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Fenerbahce SK " + goal_fener4 + "-" + goal_bas4 + " Istanbul Basaksehir FK");
                    if (goal_fener4 > goal_bas4)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener4 < goal_bas4)
                    {
                        pbfk = pbfk + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pbfk = pbfk + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Adana Demirspor mot Trabzonspor:");
                    if (trabzon.getlagpo() - adana.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (trabzon.getlagpo() - adana.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_tra4 = number.Next(0, x);
                    int goal_ada4 = number.Next(0, y);
                    for (int i = 0; i < goal_tra4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    for (int i = 0; i < goal_ada4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANA DEMIRSPOR " + spelarlista_ads[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Adana Demirspor " + goal_ada4 + "-" + goal_tra4 + " Trabzonspor");
                    if (goal_tra4 > goal_ada4)
                    {
                        pts = pts + 3;
                    }
                    else if (goal_tra4 < goal_ada4)
                    {
                        pads = pads + 3;
                    }
                    else
                    {
                        pts = pts + 1;
                        pads = pads + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Konyaspor mot Besiktas JK:");
                    if (besiktas.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (besiktas.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bes4 = number.Next(0, x);
                    int goal_konya4 = number.Next(0, y);
                    for (int i = 0; i < goal_bes4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    for (int i = 0; i < goal_konya4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Konyaspor " + goal_konya4 + "-" + goal_bes4 + " Besiktas JK");
                    if (goal_bes4 > goal_konya4)
                    {
                        pbjk = pbjk + 3;
                    }
                    else if (goal_bes4 < goal_konya4)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pbjk = pbjk + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Sivasspor mot Galatasaray:");
                    if (galatasaray.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala4 = number.Next(0, x);
                    int goal_sivas4 = number.Next(0, y);
                    for (int i = 0; i < goal_gala4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_sivas4;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Sivasspor " + goal_sivas4 + "-" + goal_gala4 + " Galatasaray");
                    if (goal_gala4 > goal_sivas4)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala4 < goal_sivas4)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();


                    //VECKA5
                    Console.WriteLine("VECKA 5");
                    Console.ReadLine();

                    Console.WriteLine("Trabzonspor mot Fenerbahce SK:");
                    if (fenerbahce.getlagpo() - trabzon.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - trabzon.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener5 = number.Next(0, x);
                    int goal_tra5 = number.Next(0, y);
                    for (int i = 0; i < goal_fener5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_tra5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Trabzonspor " + goal_tra5 + "-" + goal_fener5 + " Fenerbahce SK");
                    if (goal_fener5 > goal_tra5)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener5 < goal_tra5)
                    {
                        pts = pts + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pts = pts + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Besiktas JK mot Istanbul Basaksehir FK:");
                    if (besiktas.getlagpo() - basaksehir.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (besiktas.getlagpo() - basaksehir.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bes5 = number.Next(0, x);
                    int goal_bas5 = number.Next(0, y);
                    for (int i = 0; i < goal_bes5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS JK " + spelarlista_bjk[index]);
                    }
                    for (int i = 0; i < goal_bas5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Besiktas JK " + goal_bes5 + "-" + goal_bas5 + " Istanbul Basaksehir FK");
                    if (goal_bes5 > goal_bas5)
                    {
                        pbjk = pbjk + 3;
                    }
                    else if (goal_bes5 < goal_bas5)
                    {
                        pbfk = pbfk + 3;
                    }
                    else
                    {
                        pbjk = pbjk + 1;
                        pbfk = pbfk + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Galatasaray mot Adana Demirspor:");
                    if (galatasaray.getlagpo() - adana.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - adana.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala5 = number.Next(0, x);
                    int goal_ada5 = number.Next(0, y);
                    for (int i = 0; i < goal_gala5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_ada5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANA DEMIRSPOR " + spelarlista_ads[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Galatasaray " + goal_gala5 + "-" + goal_ada5 + " Adana Demirspor");
                    if (goal_gala5 > goal_ada5)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala5 < goal_ada5)
                    {
                        pads = pads + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        pads = pads + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Sivasspor mot Konyaspor:");
                    if (sivas.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (sivas.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_sivas5 = number.Next(0, x);
                    int goal_konya5 = number.Next(0, y);
                    for (int i = 0; i < goal_sivas5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    for (int i = 0; i < goal_konya5;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Sivasspor " + goal_sivas5 + "-" + goal_konya5 + " Konyaspor");
                    if (goal_sivas5 > goal_konya5)
                    {
                        psiv = psiv + 3;
                    }
                    else if (goal_sivas5 < goal_konya5)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        psiv = psiv + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();


                    //VECKA6
                    Console.WriteLine("VECKA 6");
                    Console.ReadLine();

                    Console.WriteLine("Fenerbahce SK mot Besiktas JK:");
                    if (fenerbahce.getlagpo() - besiktas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - besiktas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener6 = number.Next(0, x);
                    int goal_bes6 = number.Next(0, y);
                    for (int i = 0; i < goal_fener6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_bes6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Fenerbahce SK " + goal_fener6 + "-" + goal_bes6 + " Besiktas JK");
                    if (goal_fener6 > goal_bes6)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener6 < goal_bes5)
                    {
                        pbjk = pbjk + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pbjk = pbjk + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Trabzonspor mot Galatasaray:");
                    if (galatasaray.getlagpo() - trabzon.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (galatasaray.getlagpo() - trabzon.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_gala6 = number.Next(0, x);
                    int goal_tra6 = number.Next(0, y);
                    for (int i = 0; i < goal_gala6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    for (int i = 0; i < goal_tra6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Galatasaray " + goal_gala6 + "-" + goal_tra6 + " Istanbul Basaksehir FK");
                    if (goal_gala6 > goal_tra6)
                    {
                        pgal = pgal + 3;
                    }
                    else if (goal_gala6 < goal_tra6)
                    {
                        pts = pts + 3;
                    }
                    else
                    {
                        pgal = pgal + 1;
                        pts = pts + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Istanbul Basaksehir FK mot Sivasspor:");
                    if (basaksehir.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (basaksehir.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bas6 = number.Next(0, x);
                    int goal_sivas6 = number.Next(0, y);
                    for (int i = 0; i < goal_bas6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    for (int i = 0; i < goal_sivas6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Istanbul Basaksehir FK " + goal_bas6 + "-" + goal_sivas6 + " Sivasspor");
                    if (goal_bas6 > goal_sivas6)
                    {
                        pbfk = pbfk + 3;
                    }
                    else if (goal_bas6 < goal_sivas6)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pbfk = pbfk + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Adana Demirspor mot Konyaspor:");
                    if (adana.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (adana.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_ada6 = number.Next(0, x);
                    int goal_konya6 = number.Next(0, y);
                    for (int i = 0; i < goal_ada6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANASPOR " + spelarlista_ads[index]);
                    }
                    for (int i = 0; i < goal_konya6;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Adana Demirspor " + goal_ada6 + "-" + goal_konya6 + " Konyaspor");
                    if (goal_ada6 > goal_konya6)
                    {
                        pads = pads + 3;
                    }
                    else if (goal_ada6 < goal_konya6)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pads = pads + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();


                    //VECKA7
                    Console.WriteLine("VECKA 7");
                    Console.ReadLine();

                    Console.WriteLine("Galatasaray mot Fenerbahce SK:");
                    if (fenerbahce.getlagpo() - galatasaray.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (fenerbahce.getlagpo() - galatasaray.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_fener7 = number.Next(0, x);
                    int goal_gala7 = number.Next(0, y);
                    for (int i = 0; i < goal_fener7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_fen.Count);
                        Console.WriteLine("MÅL FENERBAHCE " + spelarlista_fen[index]);
                    }
                    for (int i = 0; i < goal_gala7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_gal.Count);
                        Console.WriteLine("MÅL GALATASARAY " + spelarlista_gal[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Fenerbahce SK " + goal_fener7 + "-" + goal_gala7 + " Besiktas JK");
                    if (goal_fener7 > goal_gala7)
                    {
                        pfen = pfen + 3;
                    }
                    else if (goal_fener7 < goal_gala7)
                    {
                        pgal = pgal + 3;
                    }
                    else
                    {
                        pfen = pfen + 1;
                        pgal = pgal + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Sivasspor mot Besiktas JK:");
                    if (besiktas.getlagpo() - sivas.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (besiktas.getlagpo() - sivas.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bes7 = number.Next(0, x);
                    int goal_sivas7 = number.Next(0, y);
                    for (int i = 0; i < goal_bes7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bjk.Count);
                        Console.WriteLine("MÅL BESIKTAS " + spelarlista_bjk[index]);
                    }
                    for (int i = 0; i < goal_sivas7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_siv.Count);
                        Console.WriteLine("MÅL SIVASSPOR " + spelarlista_siv[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Besiktas JK " + goal_bes7 + "-" + goal_sivas7 + " Sivasspor");
                    if (goal_bes7 > goal_sivas7)
                    {
                        pbjk = pbjk + 3;
                    }
                    else if (goal_bes7 < goal_sivas7)
                    {
                        psiv = psiv + 3;
                    }
                    else
                    {
                        pbjk = pbjk + 1;
                        psiv = psiv + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Konyaspor mot Trabzonspor:");
                    if (trabzon.getlagpo() - konya.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (trabzon.getlagpo() - konya.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_tra7 = number.Next(0, x);
                    int goal_konya7 = number.Next(0, y);
                    for (int i = 0; i < goal_tra7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ts.Count);
                        Console.WriteLine("MÅL TRABZONSPOR " + spelarlista_ts[index]);
                    }
                    for (int i = 0; i < goal_konya7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_kon.Count);
                        Console.WriteLine("MÅL KONYASPOR " + spelarlista_kon[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Konyaspor " + goal_konya7 + "-" + goal_tra7 + " Trabzonspor");
                    if (goal_tra7 > goal_konya7)
                    {
                        pts = pts + 3;
                    }
                    else if (goal_tra7 < goal_konya7)
                    {
                        pkon = pkon + 3;
                    }
                    else
                    {
                        pts = pts + 1;
                        pkon = pkon + 1;
                    }
                    Console.ReadLine();

                    Console.WriteLine("Adana Demirspor mot Istanbul Basaksehir FK:");
                    if (basaksehir.getlagpo() - adana.getlagpo() < 20)
                    {
                        x = 3;
                        y = 2;
                    }
                    else if (basaksehir.getlagpo() - adana.getlagpo() >= 20)
                    {
                        x = 5;
                        y = 1;
                    }
                    else
                    {
                        x = 2;
                        y = 4;
                    }
                    number = new Random();
                    int goal_bas7 = number.Next(0, x);
                    int goal_ada7 = number.Next(0, y);
                    for (int i = 0; i < goal_bas7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_bfk.Count);
                        Console.WriteLine("MÅL BASAKSEHIR " + spelarlista_bfk[index]);
                    }
                    for (int i = 0; i < goal_ada7;)
                    {
                        i++;
                        var random = new Random();
                        int index = random.Next(spelarlista_ads.Count);
                        Console.WriteLine("MÅL ADANASPOR " + spelarlista_ads[index]);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Istanbul Basaksehir FK " + goal_bas7 + "-" + goal_ada7 + " Adana Demirspor");
                    if (goal_bas7 > goal_ada7)
                    {
                        pbfk = pbfk + 3;
                    }
                    else if (goal_bas7 < goal_ada7)
                    {
                        pads = pads + 3;
                    }
                    else
                    {
                        pbfk = pbfk + 1;
                        pads = pads + 1;
                    }
                    Console.ReadLine();



                    Console.ReadLine();
                }
            }
        }
    }
}