
class Program
{
    static void Main(string[] args)
    {
        Esercizio1();
        Esercizio2();
        Esercizio3();
        Esercizio4();
        Esercizio5();
        Esercizio6();
        Esercizio7();
        Esercizio8();
        Esercizio9();
        Esercizio10();
        Esercizio11();
        Esercizio12();
        Esercizio13();
        Esercizio14();
        Esercizio15();
        Esercizio16();
        Esercizio17();
        Esercizio18();
        Esercizio19();
        Esercizio20();
        Esercizio21();
        Esercizio22();
        Esercizio23();
        Esercizio24();
        Esercizio25();
    }


    static void Esercizio1() // ESERCIZIO 1
    {
        Console.WriteLine("Ora stamperò i numeri da 1 a 10");
        for (int i = 1; i < 11; i++)
            Console.WriteLine(i);

        Console.WriteLine();
    }

    static void Esercizio2() // ESERCIZIO 2
    {
        Console.WriteLine("Ora stamperò i numeri fino al raggiungimento di 100, aumentando sempre di 10");
        int valore = 0;
        while (valore < 100)
        {
            Console.WriteLine($"Valore attuale: {valore}");
            valore += 10; 
        }

        Console.WriteLine();
    }

    static void Esercizio3() // ESERCIZIO 3 
    {
        Console.WriteLine("Inserisci la scritta: malevoggia");
        string stringa = "malevoggia";
        string accettazione;
        do
        {
            accettazione = Console.ReadLine();
            if (accettazione != stringa)
                Console.WriteLine("Hai inserito la scritta sbagliata");
        }
        while (accettazione != stringa);

        Console.WriteLine();
    }

    static void Esercizio4() // ESERCIZIO 4
    {
        int[] array = new int[5];
        int somma = 0;
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        for (int i = 0; i < 5; i++)
            somma = array[i] + somma;
        Console.WriteLine($"La somma è {somma}");
        Console.WriteLine();
    }

    static void Esercizio5() // ESERCIZIO 5
    {
        Console.WriteLine("Ora stamperò i valori nella lista");
        List<string> list = new List<string>();
        list.Add("Mauro");
        list.Add("Riki");
        list.Add("Walter");
        list.Add("Michele");
        list.Add("Sebastiano");
        foreach (string i in list)
            Console.WriteLine(i);
        Console.WriteLine();
    }

    static void Esercizio6() // ESERCIZIO 6
    {
        Console.WriteLine("Dammi un numero e calcolerero il suo fattoriale");
        int fattoriale = int.Parse(Console.ReadLine());
        if (fattoriale < 0)
            Console.WriteLine("Non si può fare il fattoriale di un numero negativo");
        else if (fattoriale == 0 || fattoriale == 1)
            Console.WriteLine($"Il fattoriale è {fattoriale} ");
        else if (fattoriale > 1)
        {
            for (int i = fattoriale - 1; i > 0; i--)
                fattoriale = fattoriale * i;
            Console.WriteLine($" Il fattoriale è {fattoriale}");
        }
        else Console.WriteLine("ERRORE");

        Console.WriteLine();

    }

    static void Esercizio7() // ESERCIZIO 7
    {
        Console.WriteLine("Inserisci un numero intero e ti dirò sè è primo:");
        int numero = int.Parse(Console.ReadLine());
        bool check = false;
        while (!check)
        {
            for (int i = 2; i < numero; i++) 
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"{numero} non è un numero primo.");
                    check = true;

                }

            }
            if (numero <= 1)
            {
                Console.WriteLine($"{numero} non è un numero primo.");
                check = true;
            }
            else
            {
                Console.WriteLine($"{numero} è un numero primo.");
                check = true;
            }

        }
        Console.WriteLine();
    }

    static void Esercizio8() // ESERCIZIO 8
    {
      
        int massimo = 20; 
        bool check = true;

        do
        {
            Console.WriteLine("Dammi un numero e io ti dirò se è pari, il numero massimo che accetto è 20");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 20)
            {
                Console.WriteLine("Il numero è supeiore a 20");
            }
            else if (numero == 2)
                Console.WriteLine("Il numero è pari");
            else
            {
                numero = numero % 2;
                if (numero == 0)
                    Console.WriteLine("Il numero è pari");
                else
                    Console.WriteLine("Il numero è dispari");

            }
            Console.WriteLine("Vuoi continuare? Scrivi true se vuoi, false se non vuoi");
            check = bool.Parse(Console.ReadLine().ToLower());


        }
        while (check = false);

        Console.WriteLine();
    }

    static void Esercizio9() // ESERCIZIO 9
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array.Count() - i);
        Console.WriteLine();

    }

    static void Esercizio10() // ESERCIZIO 10
    {
        int valoreMassimo = 10; 
        Console.WriteLine("Moltiplicherò il numero finche non supera il valore 10 dopo si fermerà");
       
        int numero = 2; 
        int prodotto = 1; 

       
        while (numero <= valoreMassimo)
        {
            prodotto *= numero; 
            numero++;           
        }
        Console.WriteLine(numero);
        Console.WriteLine();
    }

    static void Esercizio11() // ESERCIZIO 11
    {
        List<int> numeri = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numeriModificati = new List<int>();

        foreach (int numero in numeri)
            numeriModificati.Add(numero * 2);
    
        numeri = numeriModificati;

        Console.WriteLine("Lista modificata:");

        foreach (int numero in numeri)
            Console.WriteLine(numero);
        Console.WriteLine();
    }

    static void Esercizio12() // ESERCIZIO 12
    {
        int i = 0;
        int somma = 0;
        int[] array = new int[] { 1, 2, 5, 7, 8, 9 };
        do
        {
            somma = somma + array[i];
            i++;
        } while (i < array.Length);
        Console.WriteLine(somma);
        Console.WriteLine();
    }

    static void Esercizio13() // ESERCIZIO 13
    {
        int valoreDaCercare = 7;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Controllo il numero: {i}");

            if (i == valoreDaCercare)
            {
                Console.WriteLine($"Trovato il valore {valoreDaCercare}!");
                break;
            }
        }
        Console.WriteLine();
    }

    static void Esercizio14() // ESERCIZIO 14
    {
        int numero = 1;

        while (numero <= 10)
        {
           
            if (numero % 2 == 0)
            {
                numero++; 
                continue; 
            }

            Console.WriteLine($"Numero dispari: {numero}");

            numero++;
        }
        Console.WriteLine();
    }

    static void Esercizio15() // ESERCIZIO 15
    {
        Console.WriteLine("Moltiplicherò i numeri fino ad un massimo di 7 volte");
        int numero1 = 5;
        int numero2 = 7;
        int i;
        for (i = 1; i <= numero2; i++)
            numero1 = numero1 * i;
        Console.WriteLine(numero1);
        Console.WriteLine();
    }

    static void Esercizio16() // ESERCIZIO 16
    {
        int[] array = { 1, 2, 3, 4, };
        int indice = 0;
        foreach (int i in array)
        {
            Console.WriteLine($"L'indice dell ' array è {indice} e il valore all'interno è {i}");
            indice++;
        }
        Console.WriteLine();
    }

    static void Esercizio17() // ESERCIZIO 17
    {
        bool uscita = false;
        do
        {
            Console.WriteLine("SCRIVI true SE VUOI USCIRE");
            uscita = bool.Parse(Console.ReadLine().ToLower());

        } while (!uscita);
        Console.WriteLine("Ora che sei uscito puoi festeggiare!!");
        Console.WriteLine();
    }

    static void Esercizio18() // ESERCIZIO 18
    {
        int somma = 0;
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                continue;
            else if (array[i] % 2 == 1)
                somma = array[i] + somma;
        }
        Console.WriteLine("La somma dei dispari è " + somma);
        Console.WriteLine();
    }

    static void Esercizio19() // ESERCIZIO 19
    {
        int valore = 0;
        int soglia = 10;

        while (valore < soglia)
        {
            Console.WriteLine($"Valore attuale: {valore}");
            valore++; 
        }

        Console.WriteLine($" Valore finale: {valore}");
        Console.WriteLine();
    }

    static void Esercizio20() // ESERCIZIO 20
    {
        Console.WriteLine("Adeeso calcolo la lunghezza di tutte le stringhe nella lista");
        List<string> list = new List<string>();
        list.Add("Ciao");
        list.Add("WEEEEEE");
        list.Add("hey");
        foreach (string s in list)
        {
            Console.WriteLine($"La lunghezza della lista {s} e di {s.Length}");
        }
        Console.WriteLine();
    }

    static void Esercizio21() // ESERCIZIO 21
    {
        string uscita = "";
        do
        {
            uscita = "";
            Console.WriteLine("SCRIVI exit SE VUOI USCIRE");
            Console.WriteLine("SCRIVI profile SE VUOI SAPERE LE INFORMAZIONI DELL'UTENTE");
            Console.WriteLine("SCRIVI exersice SE VUOI SAPERE IL NUMERO DELL'ESERCIZIO");
            uscita = Console.ReadLine().ToLower();
            switch (uscita)
            {
                case "profile":
                    {
                        Console.WriteLine("-NOME: LORENZO");
                        Console.WriteLine("-COGNOME : CAVARRETTA");
                        Console.WriteLine("-ETA : 21");
                        continue;
                    }
                case "exersice":
                    {
                        Console.WriteLine("-QUESTO E' L'ESERCIZIO NUMERO 21 DELLA CATEGORIA LOOP");
                        continue;
                    }
                case "exit":
                    continue;
                default:
                    Console.WriteLine("-VALORE NON VALIDO");
                    continue;
            }

        } while (uscita != "exit");
        Console.WriteLine("STAI USCENDO DAL MENU");
        Console.WriteLine();
    }

    static void Esercizio22() // ESERCIZIO 22
    {
        {
            Console.WriteLine("Numeri dispari multipli di 3 tra 1 e 20:");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        Console.WriteLine();
    }

    static void Esercizio23() // ESERCIZIO 23
    {
        int[] array = { 1, 7, 14, 5, 9, 16 };
        Console.WriteLine("Se vuoi uscire indovina uno dei numeri presennti nella mia array");
        int scelta = 0;
        int i = 0;
        while (true)
        {
            scelta = int.Parse(Console.ReadLine());
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == scelta)
                {
                    Console.WriteLine($"Bravo, {scelta} è presente nella mia array");
                    return;
                }
            }
            Console.WriteLine("Non hai indovinato ritenta");

        }
        Console.WriteLine();
    }

    static void Esercizio24() // ESERCIZIO 24
    {
        int[] array = { 1, 7, 14, 5, 9, 16 };
        float media = 0;
        for (int i = 0; i < array.Length; i++)
        {
            media = media + array[i];
        }
        media /= array.Length;
        Console.WriteLine("La media dell'array è " + media);
        Console.WriteLine();
    }

    static void Esercizio25() // ESERCIZIO 25 
    {
        int[] array = { 1, 7, 14, 5, 9, 16 };
        int[] copiato = new int[6];
        int j = 0;
        foreach (var i in array)
        {
            copiato[j] = i;
            Console.WriteLine(copiato[j]);
            j++;

        }
        Console.WriteLine();

    }



}