
using System.Diagnostics.Metrics;

class Program
{
   
    public  static void Main(string[] args)
    {
        int risultato = Esercizio1(4,4);
        Console.WriteLine(risultato);

        Esercizio2();
        Esercizio3("Compito Natalizio");
        Esercizio4();
        Esercizio6();
        Esercizio7();
        Esercizio8();
        Esercizio9();
        
        Mela mela = new Mela("pera");
        Esercizio10(mela);

        List<int> lista = new List<int>();
        Esercizio11(lista);

        Esercizio12();

    }

    public static int Esercizio1(int numero, int numero2) //ESERCIZIO1
    {
       return  numero + numero2;
    }

    public static void Esercizio2() //ESERCIZIO 2
    {
        System.Console.WriteLine("Come stai? ");
    }

    public static void Esercizio3(string scritta1) //ESERCIZIO 3
    {
        int contaCaratteri = scritta1.Count();
        Console.WriteLine("Le lettere sono: ");
        Console.WriteLine(contaCaratteri);
    }

    static void Esercizio4(string nome = "Utente") //ESERCIZIO 4
    {
        Console.WriteLine($"Ciao, {nome}!");
    }

    static void Esercizio5(int[] array) //ESERCIZIO 5
    {
        array[0] = 1;
        array[1] = 2;
    }

    static void Esercizio6() //ESERCIZIO 6
    {
        Console.WriteLine("Inserisci un numero e calcolerò il suo fattoriale: ");
        int numero = int.Parse(Console.ReadLine());

        long fattoriale = CalcolaFattoriale(numero);
        Console.WriteLine($"Il fattoriale di {numero} è: {fattoriale}");
    }

    static int CalcolaFattoriale(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Il fattoriale non è definito per numeri negativi.");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        return n * CalcolaFattoriale(n - 1);
    }

    static void Esercizio7() //ESERCIZIO 7
    {
        bool condizione;
        Console.WriteLine("Ti piace la pasta con le cozze?");
        Console.WriteLine("-- 0 Se non ti piace // -- 1 Se ti piace");
        string scelta = Console.ReadLine();
        switch (scelta)
        {
            case "0":
                condizione = false;
                return;
            case "1":
                condizione = true;
                return;
            default:
                throw new Exception("Valore non valido");
                return;

        }

    }
    static void Esercizio8() //ESERCIZIO 8
    {
        Console.WriteLine("Inserisca un qualsiasi numero");
        int valoreControllare = 0;
        try
        {
            valoreControllare = int.Parse(Console.ReadLine());

        }
        catch (Exception)
        {
            Console.WriteLine("Errore");
        }

        Console.WriteLine("il valore è:" + valoreControllare);
    }

    static void Esercizio9() //ESERCIZIO 9
    {
        List<int> Lista = new List<int>();
        bool controllo = true;
        while (controllo == true)
        {
            Console.WriteLine("Digitare i valori che si vogliono aggiungere alla lista");
            int aggiungi = int.Parse(Console.ReadLine());
            Lista.Add(aggiungi);
            Console.WriteLine("Vuoi aggiungere altri valori? premi 1 se vuoi aggiungere altri valori, qualsiasi altro numero ti farà uscire");
            int uscita = int.Parse(Console.ReadLine());
            if (uscita == 1)
                controllo = true;
            else controllo = false;

        }

        Console.WriteLine("I numeri inseriti sono: ");
        foreach (int i in Lista)
        {
            Console.WriteLine(i.ToString());
        }

    }

    static Mela Esercizio10(Mela mela) //ESERCIZIO 10
    {
        return new Mela("mela");
       
    }

    static void Esercizio11(List<int> lista) //ESERCIZIO 11
    {
        lista.Add(12);
        lista.Add(13);
        lista.RemoveAt(1);
        lista.Clear();
    }

    static void Esercizio12() //ESERCIZIO 12
    {
        Console.WriteLine("INSERISCI UN NUMERO");
        int Num = int.Parse(Console.ReadLine());
        int controlloNum = Num % 2;
        if (controlloNum == 0)
            Console.WriteLine("il numero è pari");
        else
            Console.WriteLine("il numero è dispari");

    }
    
}



class Mela
{
    public string Apple { get; set; }
    public Mela( string mela)
    {
        this.Apple = mela;
    }
   
}