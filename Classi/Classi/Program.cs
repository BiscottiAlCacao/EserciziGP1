
class Program
{

    static void Main(string[] args)
    {
        Esercizio1();
        Esercizio3();
        Esercizio4();
        Esercizio7();
        Esercizio8();
        Esercizio9();
    }

    static void Esercizio1() // ESERCIZIO 1 E 2
    {

        Lavoro lavoro1 = new Lavoro("Muratore", "Costruisce case");
        Persona persona1 = new Persona("Mario", 34);    
        persona1.MostraInformazioniPersona();
        lavoro1.MostraInformazioniLavoro();
        Console.WriteLine();
    }

    // ESERCIZIO 2 GIà FATTO NEL 1

    static void Esercizio3() // ESERCIZIO 3
    {
        Console.WriteLine("Dammi un primo valore");
        int valore1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dammi un secondo valore");
        int valore2 = int.Parse(Console.ReadLine());
        Metodo somma = new Metodo(valore1, valore2);
        int add = somma.Somma();
        Console.WriteLine(add);
        Console.WriteLine();

    }

    static void Esercizio4() // ESERCIZIO 4
    {
        Lavoro lavoro1 = new Lavoro("Giardiniere", "Si occupa del giardino");
        Antonio antonio = new Antonio("Piero", 20, lavoro1);
        antonio.MostraInformazioniPersona();
        Console.WriteLine();
    }

    static void Esercizio7() // ESERCIZIO 7
    {
        var lista = new Lista<string>();
        lista[0] = "Scuola";
        Console.WriteLine(lista[0]);
        Console.WriteLine();
    }

    static void Esercizio8() //ESERCIZIO 8
    {
        Lavoro lavoro1 = new Lavoro("Muratore", "Costruisce case");
        Persona persona1 = new Persona("Mario", 34, lavoro1);   
        persona1.MostraInformazioniPersonaLavoro();
        Console.WriteLine();
    }

    static void Esercizio9() // ESERCIZIO 9
    {
        List<Persona> persone = new List<Persona>
        {
            new Persona("Mario Rossi", 30),
            new Persona("Anna Bianchi", 25),
            new Persona("Luigi Verdi", 40),
            new Persona("Chiara Neri", 35)
        };

        List<Lavoro> lavori = new List<Lavoro>
        {
            new Lavoro("Meccannico", "Aggiusta automobili"),
            new Lavoro("Designer Grafico", "Crea Locandine"),
            new Lavoro("Analista Dati", "Analizza i dati della propria azienda"),
            new Lavoro("Profossore Scuola Supeiore", "Insegna letteratura nella scuola superiore")
        };

        Random random = new Random();


        foreach (var persona in persone)
        {
            int lavoroIndex = random.Next(lavori.Count);
            persona.AssegnaLavoro(lavori[lavoroIndex]);
            persona.MostraInformazioniPersonaLavoro();
        }

        Console.WriteLine();
    }
   
}



public class Persona
{
    public string Nome { get; set; }
    public int Eta { get; set; }

    public Lavoro Lavoro { get; set; }

    public Persona(string nome, int eta, Lavoro lavoro) //ESERCIZIO 8
    {
        this.Nome = nome;
        this.Eta = eta;
        this.Lavoro = lavoro;
    }

    public Persona(string nome, int eta)
    {
        this.Nome = nome;
        this.Eta = eta;
    }

    public virtual void MostraInformazioniPersona()  // ESERCIZIO 5 
    {
        Console.WriteLine($"Nome: {Nome}, Età: {Eta}");
    }

    public virtual void MostraInformazioniPersonaLavoro()  //ESERCIZIO 8
    {
        Console.WriteLine($"Nome: {Nome}, Età: {Eta}");
        Lavoro.MostraInformazioniLavoro();  
    }

    public virtual void AssegnaLavoro(Lavoro lavoro)
    {
        Lavoro = lavoro;
    }
}


public class Lavoro
{
    public string Lavori { get; set; }
    public string Descrizioni { get; set; }

    public Lavoro(string lavori, string descrizioni)
    {
        this.Lavori = lavori;
        this.Descrizioni = descrizioni;
    }

    public virtual void MostraInformazioniLavoro()
    {
        Console.WriteLine($"Lavoro: {Lavori}, Età: {Descrizioni}");
    }
}

class Metodo
{
    public int Valore1 { get; set; }

    public int Valore2 { get; set; }

    public Metodo(int valore1, int valore2)
    {
        this.Valore1 = valore1;
        this.Valore2 = valore2;
    }

    public int Somma()
    {
        return Valore1 + Valore2;
    }




}

public class Antonio : Persona
{
    public Antonio(string nome, int eta, Lavoro lavoro) : base(nome, eta, lavoro)
    {

    }

    public override void MostraInformazioniPersona()
    {
        Console.WriteLine($"Nome: {Nome}, Età: {Eta}");
        Console.WriteLine("Tuo padre si chiama Antonio");
    }
}

class Giocatori //ESERCIZIO 6
{
    public List<string> players { get; set; }

    public Giocatori()
    {
        players = new List<string>();
    }

    public void AggiungiPlayer(string giocatore)
    {
        players.Add(giocatore);
    }

    public void RimuoviGiocatore(string giocatore)
    {
        players.Remove(giocatore);
    }
}

class Lista<T>
{
    private T[] lista = new T[5];


    public T this[int i]
    {
        get { return lista[i]; }
        set { lista[i] = value; }
    }

}