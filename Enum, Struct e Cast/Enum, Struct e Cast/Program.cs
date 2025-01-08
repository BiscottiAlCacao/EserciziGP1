
class Program
{
    static void Main(string[] args)
    {
        Esercizio1();
        Esercizio2();
        Esercizio4();
        Esercizio5();
        Esercizio6();
        Esercizio8();
        Esercizio13();
        Esercizio14();
        Esercizio15();
        Esercizio16();
        Esercizio17();
        Esercizio18();
        Esercizio19();
        Esercizio20();
        Esercizio23();
        Esercizio24();
        Esercizio25();

    }


    enum Settimana
    {
        Lunedì,
        Martedì,
        Mercoledì,
        Giovedì,
        Venerdì,
        Sabato,
        Domenica
    }

    static void Esercizio1() // ESERCIZIO 1
    {
        foreach (Settimana i in Enum.GetValues(typeof(Settimana)))
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    enum PrioritàTasks
    {
        ignorare = 0,
        prioritàBassa = 1,
        prioritàMedia = 2,
        prioritàAlta = 3
    }

    static void Esercizio2() // ESERCIZIO 2
    {
        Console.WriteLine("\nTutti i livelli di priorità:");
        foreach (PrioritàTasks livello in Enum.GetValues(typeof(PrioritàTasks)))
        {
            Console.WriteLine($"- {livello} ({(int)livello})");
        }
        Console.WriteLine();
    }

    enum SceltaSwitchCase
    {
        menu = 0,
        esci = 1,
        profile = 2,
        exersice = 3
    }

    static void Esercizio3() // ESERCIZIO 3 E 21
    {
        SceltaSwitchCase uscita;
        while (true)
        {

            Console.WriteLine("SCRIVI 1 SE VUOI USCIRE");
            Console.WriteLine("SCRIVI 2 SE VUOI SAPERE LE INFORMAZIONI DELL'UTENTE");
            Console.WriteLine("SCRIVI 3 SE VUOI SAPERE IL NUMERO DELL'ESERCIZIO");
            uscita = (SceltaSwitchCase)int.Parse(Console.ReadLine());
            switch (uscita)
            {
                case SceltaSwitchCase.profile:
                    {
                        Console.WriteLine("-NOME: LORENZO");
                        Console.WriteLine("-COGNOME : CAVARRETTA");
                        Console.WriteLine("-ETA : 21");
                        continue;
                    }
                case SceltaSwitchCase.exersice:
                    {
                        Console.WriteLine("-QUESTO E' L'ESERCIZIO NUMERO 3 DELLA CATEGORIA ENUM");
                        continue;
                    }
                case SceltaSwitchCase.esci:
                    {
                        Console.WriteLine("STAI USCENDO DAL MENU");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("-VALORE NON VALIDO");
                        continue;
                    }
            }

        }
        Console.WriteLine();
    }

    static void Esercizio4() // ESERCIZIO 4
    {
        Punto2D punto1 = new Punto2D(2, 4);
        Punto2D punto2 = new Punto2D(3, 5);

        double risultato = Punto2D.CalcolaDistanza(punto1, punto2);

        Console.WriteLine($"La distanza tra i due punti è: {risultato}");
        Console.WriteLine();
    }

    static void Esercizio5() // ESERCIZIO 5
    {
        Rettangolo rettangolo = new Rettangolo(6, 3);
        double area = rettangolo.CalcoloArea();
        Console.WriteLine($"L'area del rettangolo è: {area}");
        Console.WriteLine();
    }

    static void Esercizio6() // ESERCIZIO 6 E 11
    {
        TipoVeicolo scelta;
        Console.WriteLine("Seleziona il tuo veicolo -- Da 0 a 4");
        scelta = (TipoVeicolo)int.Parse(Console.ReadLine());
        switch (scelta)
        {
            case TipoVeicolo.Bicicletta:
                Console.WriteLine($"Hai selezionato il veicolo {TipoVeicolo.Bicicletta}");
                break;
            case TipoVeicolo.Auto:
                Console.WriteLine($"Hai selezionato il veicolo {TipoVeicolo.Auto}");
                break;
            case TipoVeicolo.Camion:
                Console.WriteLine($"Hai selezionato il veicolo {TipoVeicolo.Camion}");
                break;
            case TipoVeicolo.Moto:
                Console.WriteLine($"Hai selezionato il veicolo {TipoVeicolo.Moto}");
                break;
            case TipoVeicolo.Autobus:
                Console.WriteLine($"Hai selezionato il veicolo {TipoVeicolo.Autobus}");
                break;
        }
        Console.WriteLine();
    }

    static void Esercizio8() // ESERCIZIO 8
    {
        Console.WriteLine("Dammi un valore da 1 a 7 e ti dirò a che giorno della settimana corrisponde");
        int valore = int.Parse(Console.ReadLine());

        Settimana giorno = (Settimana)valore;

        Console.WriteLine($"Il valore {valore} corrisponde a: {giorno}");
        Console.WriteLine();
    }

    static void Esercizio13() // ESERCIZIO 13
    {
        for (int i = 1; i < 13; i++)
        {
            Mesi mese = (Mesi)i;

            Console.WriteLine($"{i}: {mese}");
        }
        Console.WriteLine();
    }

    static void Esercizio14() // ESERCIZIO 14
    {
        Persona persona = new Persona("Mario Rossi", 30);

        Console.WriteLine(persona.Nome, persona.Eta);

        persona.Nome = "Luigi Verdi";
        persona.Eta = 40;

        Console.WriteLine(persona.Nome, persona.Eta);
        Console.WriteLine();
    }

    static void Esercizio15() // ESERCIZIO 15
    {
        double numeroDouble = 123.456;
        int numeroInt;

        numeroInt = (int)numeroDouble;
        Console.WriteLine(numeroInt);

        Console.WriteLine();
    }

    static void Esercizio16() // ESERCIZIO 16 PUO' CONTARE ANCHE COME 21
    {
        Random rand = new Random();

        TipoErrore errore = (TipoErrore)rand.Next(0, 5);
        switch (errore)
        {
            case TipoErrore.NessunErrore:
                Console.WriteLine("Tutto funziona correttamente.");
                break;

            case TipoErrore.ErroreConnessione:
                Console.WriteLine("Errore di connessione: verifica la rete.");
                break;

            case TipoErrore.ErroreInput:
                Console.WriteLine("Errore di input: verifica i dati forniti.");
                break;

            case TipoErrore.ErroreDatabase:
                Console.WriteLine("Errore del database: contatta il supporto tecnico.");
                break;

            case TipoErrore.ErroreFile:
                Console.WriteLine("Errore nel file: verifica i permessi o il percorso.");
                break;

            case TipoErrore.ErroreGenerico:
                Console.WriteLine("Errore sconosciuto: prova a riavviare l'app.");
                break;

            default:
                Console.WriteLine("Errore non riconosciuto.");
                break;
        }
        Console.WriteLine();
    }

    static void Esercizio17() // ESERCIZIO 17
    {
        Posizione3D p1 = new Posizione3D(1.0, 2.0, 3.0);
        Posizione3D p2 = new Posizione3D(4.0, 6.0, 8.0);

        double deltaX = p2.X - p1.X;
        double deltaY = p2.Y - p1.Y;
        double deltaZ = p2.Z - p1.Z;

        double posizione = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        Console.WriteLine("La distanza è " + posizione);
        Console.WriteLine();
    }

    static void Esercizio18() // ESERCIZIO 18
    {
        Random random = new Random();
        PermessoApp permessoUtente = (PermessoApp)random.Next(0, 5);

        switch (permessoUtente)
        {
            case PermessoApp.NessunPermesso:
                Console.WriteLine("L'utente non ha alcun permesso.");
                break;

            case PermessoApp.Lettura:
                Console.WriteLine("L'utente ha il permesso di lettura.");
                break;

            case PermessoApp.Scrittura:
                Console.WriteLine("L'utente ha il permesso di scrittura.");
                break;

            case PermessoApp.Amministratore:
                Console.WriteLine("L'utente ha il permesso di amministratore.");
                break;

            case PermessoApp.SuperUtente:
                Console.WriteLine("L'utente ha il permesso di super utente.");
                break;
        }
        Console.WriteLine();
    }

    static void Esercizio19() // ESERCIZIO 19
    {
        Console.WriteLine("Crea la tua data personalizzata");
        Console.WriteLine("Anno :");
        int anno = int.Parse(Console.ReadLine());
        Console.WriteLine("Mese:");
        int mese = int.Parse(Console.ReadLine());
        Console.WriteLine("Giorno");
        int giorno = int.Parse(Console.ReadLine());
        DataPersonalizzata dataPersonalizzata = new DataPersonalizzata(anno, mese, giorno);
        Console.WriteLine($"La tua data è : { dataPersonalizzata.Anno} { dataPersonalizzata.Mese} { dataPersonalizzata.Giorno}");
        Console.WriteLine();
    }

    static void Esercizio20() // ESERCIZIO 20
    {
        Carta carta1 = new Carta("Asso", "Cuori");
        Carta carta2 = new Carta("Re", "Picche");
        Carta carta3 = new Carta("10", "Quadri");
        Console.WriteLine($"La carta è un {carta1.Valore} {carta1.Seme}");
        Console.WriteLine($"La carta è un {carta2.Valore} {carta2.Seme}");
        Console.WriteLine($"La carta è un {carta3.Valore} {carta3.Seme}");
        Console.WriteLine();
    }

    //ESERCIZO 21 GIA FATTO IN UNO QUALSIASI SWITCH CON UN ENUM

    static void Esercizio23() // ESERCIZIO 23
    {
        double numeroDouble = 123.456;
        float numeroFloat;

        numeroFloat = (float)numeroDouble;
        Console.WriteLine(numeroFloat);
        Console.WriteLine();
    }

    static void Esercizio24() // ESERCIZIO 24
    {
        TipiFile tipiFile = TipiFile.Pdf;

        Console.WriteLine($"Il tipo di file selezionato è: {tipiFile}");
        Console.WriteLine();
    }

    static void Esercizio25() // ESERCIZIO 25
    {
        Vettore v1 = new Vettore(1, 2, 3);
        Vettore v2 = new Vettore(4, 5, 6);

        double scalare = v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        Console.WriteLine($"Prodotto scalare: {scalare}");
        Console.WriteLine();
    }


    struct Punto2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double CalcolaDistanza(Punto2D punto1, Punto2D punto2)
        {
            double deltaX = punto2.X - punto1.X;
            double deltaY = punto2.Y - punto1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    struct Rettangolo
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rettangolo(int h, int b)
        {
            A = h;
            B = b;

        }

        public double CalcoloArea()
        {
            return A * B;
        }
    }


    enum TipoVeicolo // ESERCIZIO 9
    {
        Auto = 0,
        Moto = 1,
        Camion = 2,
        Autobus = 3,
        Bicicletta = 4
    }

    struct Rettangolo2 // ESERCIZIO 7
    {
        public double Larghezza { get; }
        public double Altezza { get; }

       
        public Rettangolo2(double larghezza, double altezza)
        {
            Larghezza = larghezza;
            Altezza = altezza;
        }

        
        public double CalcolaArea()
        {
            return Larghezza * Altezza;
        }
    }

    public struct RGBColor // ESERCIZIO 10
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

      
        public RGBColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        //ESERCIZIO 11 GIA' FATTO NEL 6
    }

    public readonly struct Point // ESERCIZIO 12
    {
        
        public double X { get; }
        public double Y { get; }

       
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

    }

    enum Mesi
    {
        Gennaio = 1,
        Febbraio,
        Marzo,
        Aprile,
        Maggio,
        Giugno,
        Luglio,
        Agosto,
        Settembre,
        Ottobre,
        Novembre,
        Dicembre
    }

    public struct Persona
    {
        
        public string Nome { get; set; }
        public int Eta { get; set; }

        
        public Persona(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }
    }

    public enum TipoErrore
    {
        NessunErrore = 0,        
        ErroreConnessione = 1,   
        ErroreInput = 2,         
        ErroreDatabase = 3,      
        ErroreFile = 4,         
        ErroreGenerico = 5     
    }


    public struct Posizione3D
    {
        
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

       
        public Posizione3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

    }

    public enum PermessoApp
    {
        NessunPermesso = 0,   
        Lettura = 1,          
        Scrittura = 2,        
        Amministratore = 4,   
        SuperUtente = 5      
    }

    public struct DataPersonalizzata
    {
        // Proprietà
        public int Giorno { get; set; }
        public int Mese { get; set; }
        public int Anno { get; set; }


        public DataPersonalizzata(int giorno, int mese, int anno)
        {
            Giorno = giorno;
            Mese = mese;
            Anno = anno;
        }
    }

    public struct Carta
    {
       
        public string Valore { get; }
        public string Seme { get; }

       
        public Carta(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }
    }

    public struct Musica // ESERCIZIO 22
    {
       
        public string[] Canzoni { get; }

        
        public Musica(string[] canzoni)
        {
            Canzoni = canzoni;
        }
    }

    public enum TipiFile
    {
        Pdf,
        Docx,
        Xlsx,
        Txt,
        Csv,
        Jpeg,
        Png
    }

    struct Vettore
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Vettore(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
