
public class Program
{


    public static void Main(String[] args)
    {
        int numero = 0; //ESERCIZIO 1 
        numero = 4;

        string scritta1 = "Come stai? "; // ESERCIZIO 2 
        string scritta2 = "Ciao, " + scritta1;
        Console.WriteLine(scritta2);

        bool vero; //ESERCIZIO 3
        vero = true;

        double numeroPreciso = 1.49999999; //ESERCIZIO 4 

        char carattere = 'A'; //ESERCIZIO 5

        decimal valutaMonetaria = 10.5m; //ESERCIZIO 6

        float numeroSemipreciso = 1.49999999f; //ESERCIZIO 7
        Console.WriteLine(numeroSemipreciso);
        Console.WriteLine(numeroPreciso);

        long numeroLungo = 43000000000; //ESERCIZIO 8

        short numeroCorto = 32767; //ESERCIZIO 9
        Console.Write(numeroLungo);
        Console.WriteLine(numeroCorto);

        byte rappr = 154; //ESERCIZIO 10

        const int costante = 20; //ESERCIZIO 11 NON SI PUO' MODIFICARE

        int mesi = 12, giorni = 365; //ESERCIZIO 12

        var verifica = 10.4; //ESERCIZIO 13

        int mele = 10; //ESERCIZIO 14

        float casting; //ESERCIZIO 15
        casting = (float)numero;

        const string walter = "Walter"; //ESECIZIO 16

        DateTime dateTime = new DateTime(2025, 1, 1); //ESERCIZIO 17

        int numero2 = 3; //ESERCIZIO 18
        int somma;
        somma = numero + numero2;
    }
}