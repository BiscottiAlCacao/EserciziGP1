
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        int[] ints = { 1, 2, 3, 4, 5 };
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    static void Esercizio2() // ESERCIZIO 2
    {
        List<string> strings = new List<string>();
        strings.Add("Hello!");
        foreach (string s in strings)
            Console.WriteLine(s);
        Console.WriteLine();
    }

    static void Esercizio3() // ESERCIZIO 3
    {
        int[,] ints = { { 1, 2, }, { 3, 4 } };
        for (int i = 0; i < ints.GetLength(0); i++)
            for (int j = 0; j < ints.GetLength(1); j++)
                Console.WriteLine(ints[i, j]);
        Console.WriteLine();
    }

    static void Esercizio4() // ESERCIZIO 4
    {
        int[] ints = { 1, 2, 3, 4 };
        int media = 0;
        foreach (int i in ints)
            media = media + i;
        media = media / ints.Length;
        Console.WriteLine(media);
        Console.WriteLine();
    }

    static void Esercizio5() // ESERCIZIO 5
    {
        List<Persona> persone = new List<Persona>();
        persone.Add(new Persona("Mario", 21));
        foreach (Persona persona in persone)
            Console.WriteLine($"{persona.Nome} {persona.Eta}");
        Console.WriteLine();
    }

    static void Esercizio6() // ESERCIZIO 6
    {
        bool[] interruttori = new bool[4];
        interruttori[0] = false;
        interruttori[1] = true;
        interruttori[2] = true;
        interruttori[3] = false;
        for (int i = 0; i < interruttori.Length; i++)
            Console.WriteLine($"L'iterrutore {i} è : {(interruttori[i] ? "Acceso" : "Spento")}");
        Console.WriteLine();
    }

    static void Esercizio7() // ESERCIZIO 7
    {
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(24);
        ints.Add(23);
        ints.Add(13);
        ints.Sort();
        foreach (int i in ints)
            Console.WriteLine(i.ToString());
        Console.WriteLine();
    }

    static void Esercizio8() // ESERCIZIO 8
    {
        int[] ints = { 1, 2, 1, 5, 5, 4, 3, 2, 4, 3, 1 };
        int[] frequenza = new int[6];

        foreach (int i in ints)
        {
            frequenza[i]++;
        }

        Console.WriteLine("Frequenza dei numeri:");
        for (int i = 1; i < frequenza.Length; i++)
        {
            Console.WriteLine($"Numero {i}: {frequenza[i]} occorrenze");
        }
        Console.WriteLine();
    }

    static void Esercizio9() // ESERCIZIO 9
    {
        List<string> strings = new List<string>();
        strings.Add("a");
        strings.Add("b");
        strings.Add("c");
        strings.Remove("c");
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    static void Esercizio10() // ESERCIZIO 10
    {
        int[] ints = { 1, 2, 3, 4, 5 };
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    static void Esercizio11() // ESERCIZIO 11
    {
        HashSet<int> valoriUnivoci = new HashSet<int>();


        valoriUnivoci.Add(10);
        valoriUnivoci.Add(20);
        valoriUnivoci.Add(10);

        Console.WriteLine("Valori univoci:");
        foreach (int valore in valoriUnivoci)
            Console.WriteLine(valore);
        Console.WriteLine();
    }

    static void Esercizio12() // ESERCIZIO 12
    {
        int[,] ints = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Matrice 3x3:");
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write(ints[i, j] + " ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }

    static void Esercizio13() // ESERCIZIO 13
    {
        int[] ints = { 1, 2, 3, 4, 5 };
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    static void Esercizio14() // ESERCIZIO 14
    {
        Persona[] persone = new Persona[3];
        persone[0] = new Persona("Dario", 45);
        persone[1] = new Persona("Franco", 31);
        persone[2] = new Persona("Carlo", 17);
        for (int i = 0; i < persone.Length; i++)
            Console.WriteLine($"{persone[i].Nome} {persone[i].Eta}");
        Console.WriteLine();
    }

    static void Esercizio15() // ESERCIZIO 15
    {
        int[] partita = { 1, 2, 3, 4, 5, 6 };
        bool uscire = true;
        List<int> punteggi = new List<int>();
        while (uscire)
        {

            Console.WriteLine("Torino è la capitale italiana? Scrivi 1 per Si // 2 Per No");
            int risposta = int.Parse(Console.ReadLine());
            if (risposta == 1)
            {
                Console.WriteLine("Hai indovinato");

                punteggi.Add(1);
                for (int i = 0; i < punteggi.Count; i++)
                {

                    Console.WriteLine($" Nella partita {partita[i]} hai fatto questo punteggio {punteggi[i]}");
                }
            }
            else if (risposta == 2)
            {
                Console.WriteLine("Hai sbagliato");

                punteggi.Add(0);
                for (int i = 0; i < punteggi.Count; i++)
                {

                    Console.WriteLine($" Nella partita {partita[i]} hai fatto questo punteggio {punteggi[i]}");
                }
            }

            else Console.WriteLine("Errore");

            Console.WriteLine("Vuoi fare un altra partita? true o false");
            uscire = bool.Parse(Console.ReadLine().ToLower());

        }
        Console.WriteLine();
    }

    static void Esercizio16() // ESERCIZIO 16
    {
        char[] arr = { 'c', 'i', 'a', 'o' };
        foreach (char c in arr)
        {
            Console.WriteLine(c);

        }
        Console.WriteLine();

    }

    static void Esercizio17() // ESERCIZIO 17
    {
        List<float> floats = new List<float>();
        Console.WriteLine("Aggiungi un valore float alla lista. Gli interi verranno bloccati");
        var valore = float.Parse(Console.ReadLine());
        if (valore is int)
        {
            Console.WriteLine("Errore: Non è consentito aggiungere valori di tipo int.");
        }
        else if (valore is float )
        {
            floats.Add(valore);
            Console.WriteLine($"Valore {valore} aggiunto alla lista.");
        }
            Console.WriteLine();
    }

    static void Esercizio18() // ESERCIZIO 18
    {
        string[] giorni = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };
        foreach (string s in giorni)
            Console.WriteLine(s);
        Console.WriteLine();
    }

    static void Esercizio19() // ESERCIZIO 19
    {
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(5);
        ints[0] = 3;
        foreach (int i in ints)
            Console.WriteLine(i);
        Console.WriteLine();
    }

    static void Esercizio20() // ESERCIZIO 20
    {
        string[] parole = { "Ciao", "come", "stai?" };

        string frase = string.Join(" ", parole);

        Console.WriteLine("La frase concatenata è: " + frase);
        Console.WriteLine();
    }

    static void Esercizio21() // ESERCIZIO 21
    {
        List<string> dati = new List<string>();

        Console.WriteLine("Inserisci dei dati. Digita 'fine' per terminare.");

        while (true)
        {
            Console.Write("Inserisci un dato: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fine")
            {
                break;
            }

            dati.Add(input);
        }

        Console.WriteLine("Ecco i dati inseriti:");
        foreach (string s in dati)
            Console.WriteLine(s);
        Console.WriteLine();
    }

    static void Esercizio22() // ESERCIZIO 22 
    {
        int[] ints = new int[3];
        Random rand = new Random();
        ints[0] = rand.Next(0, 10);
        ints[1] = rand.Next(0, 10);
        ints[2] = rand.Next(0, 10);
        foreach (int i in ints)
            Console.WriteLine(i);
        Console.WriteLine();
    }

    static void Esercizio23() // ESERCIZIO 23
    {
        List<int> ints = new List<int>();
        Console.WriteLine("Dammi un valore più grande di 10 e lo aggiungerò alla lista");
        int scelta = int.Parse(Console.ReadLine());
        if (scelta >= 10)
        {
            ints.Add(scelta);
            Console.WriteLine($"Il valore inserito è {ints[0]} ");
        }
        else
            Console.WriteLine("Il valore non è maggiore di 10");
        Console.WriteLine();
    }

    static void Esercizio24() // ESERCIZIO 24
    {
        int dimensione = 10;

        int[,] tabellaMoltiplicazione = new int[dimensione, dimensione];

        for (int i = 1; i <= dimensione; i++)
        {
            for (int j = 1; j <= dimensione; j++)
            {
                tabellaMoltiplicazione[i - 1, j - 1] = i * j;
            }
        }

        Console.WriteLine("Tabella di Moltiplicazione:");
        for (int i = 1; i <= dimensione; i++)
        {
            for (int j = 1; j <= dimensione; j++)
            {
                Console.Write($"{tabellaMoltiplicazione[i - 1, j - 1],4}");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Esercizio25() // ESERCIZIO 25
    {
        List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6 };

        int[] array = ints.ToArray();
        foreach (int i in array)
            Console.WriteLine(i);
        Console.WriteLine();
    }

}

class Persona
{
    public string Nome { get; set; }
    public int Eta { get; set; }

    public Persona(string nome, int eta)
    {
        this.Nome = nome;
        this.Eta = eta;
    }
}

