
class Program
{

    static void Main(string[] args)
    {
        Esercizio1();
        Esercizio2();
        Esercizio4();
        Esercizio5();
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
    }

    static void Esercizio1() // ESERCIZIO 1
    {
        Console.WriteLine("INSERISCI UN NUMERO");
        int Num = int.Parse(Console.ReadLine());
        int controlloNum = Num % 2;
        if (controlloNum == 0)
            Console.WriteLine("il numero è pari");
        else
            Console.WriteLine("il numero è dispari");



    }

    static void Esercizio2() // ESERCIZIO 2 E 3
    {
        Console.WriteLine("INSERISCI LA TUA ETA'");
        int Num = int.Parse(Console.ReadLine());
        if (Num >= 18)
            Console.WriteLine("Sei maggiorenne");
        else if (Num <= 17 && Num >= 14)
            Console.WriteLine("Sei un teenager");
        else if (Num <= 13 && Num >= 1)
            Console.WriteLine("Sei un bambino");
        else Console.WriteLine("ERRORE");
    }



    static void Esercizio4() // ESERCIZIO 4
    {
        Console.WriteLine("Inserisci valore");
        int compreso = int.Parse(Console.ReadLine());
        if (compreso < 10 || compreso > 20)
        {
            Console.WriteLine("Il numero non è compreso nell'intervallo [10, 20].");
        }
        else
        {
            Console.WriteLine("Il numero è compreso nell'intervallo [10, 20].");
        }
    }

    static void Esercizio5() // ESERCIZIO 5 E 6
    {
        Console.WriteLine("Ti piace la pasta alle zucchine?");
        Console.WriteLine("-- 0 o qualsiasi altro numero Se non ti piace // -- 1 Se ti piace");
        int sceltaaa = int.Parse(Console.ReadLine());
        bool scelta = (sceltaaa == 1);
        if (!scelta)
            Console.WriteLine("Non ti piace");
        else if (scelta)
            Console.WriteLine("Ti piace");
        else Console.WriteLine("ERRORE");

    }

    static void Esercizio7() // ESERCIZIO 7
    {
        {
            Console.WriteLine("Inserisci l'età:");
            int eta = int.Parse(Console.ReadLine());

            if (eta >= 0) 
            {
                if (eta <= 12)
                {
                    Console.WriteLine("Categoria: Bambino.");
                }
                else if (eta <= 19)
                {
                    Console.WriteLine("Categoria: Adolescente.");
                }
                else if (eta <= 59)
                {
                    Console.WriteLine("Categoria: Adulto.");
                }
                else
                {
                    Console.WriteLine("Categoria: Anziano.");
                }
            }
            else
            {
                Console.WriteLine("Errore: l'età non può essere negativa.");
            }
        }
    }

    static void Esercizio8() // ESERCIZIO 8
    {
        Console.WriteLine("Ti piace la Carbonara");
        Console.WriteLine("SCRIVI true SE TI PIACE OPPURE false SE NON TI PIACE");
        bool scelta = bool.Parse(Console.ReadLine());
        switch (scelta)
        {
            case true:
                Console.WriteLine("Ti piace");
                break;
            case false:
                Console.WriteLine("Non ti piace");
                break;
            default:
                Console.WriteLine("Errore");
                break;

        }
    }

    static void Esercizio9() // ESERCIZIO 9
    {
        Console.WriteLine("Inserisci un valore e ti dirò sè è piu grande o piu piccolo di 10");
        float numero = float.Parse(Console.ReadLine());

        if (numero == 10)
            Console.WriteLine("Il numero è dieci");
        else if (numero > 10)
            Console.WriteLine("Il numero è piu grande di 10");
        else Console.WriteLine("Il numero è piu piccolo di dieci");
    }

    static void Esercizio10()// ESERCIZIO 10
    {
        Console.WriteLine("Quanti gradi ci sono in casa tua?");
        float gradi = float.Parse(Console.ReadLine());
        string risultato = (gradi < 19.00f) ? "Freddo" : "Caldo";
        Console.WriteLine($"I gradi in casa tua sono {gradi} è fà {risultato}.");
    }

    static void Esercizio11() // ESERCIZIO 11
    {
        Console.WriteLine("Inserisci un voto (da 0 a 100):");
        int voto = int.Parse(Console.ReadLine());

        if (voto >= 90 && voto <= 100)
        {
            Console.WriteLine("Hai ottenuto un voto eccellente!");
        }
        else if (voto >= 75 && voto < 90)
        {
            Console.WriteLine("Hai ottenuto un buon voto.");
        }
        else if (voto >= 60 && voto < 75)
        {
            Console.WriteLine("Hai ottenuto un voto sufficiente.");
        }
        else if (voto >= 0 && voto < 60)
        {
            Console.WriteLine("Purtroppo il tuo voto è insufficiente.");
        }
        else
        {
            Console.WriteLine("Errore: il voto deve essere compreso tra 0 e 100.");
        }
    }

    static void Esercizio12() // ESERCIZIO 12
    {
        Console.WriteLine("Ora determinero se il primo valore che inserisci è  più grande o più piccolo del secondo che inserirai");
        Console.WriteLine("Inserisci il primo valore");
        int scelta1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo  valore");
        int scelta2 = int.Parse(Console.ReadLine());
        if (scelta1 > scelta2)
            Console.WriteLine($" il primo valore {scelta1} è piu grande di {scelta2}");
        else if (scelta1 < scelta2)
            Console.WriteLine($" il primo valore {scelta1} è piu piccolo di {scelta2}");
        else if (scelta1 == scelta2)
            Console.WriteLine($" il primo valore {scelta1} è uguale al secondo valore che è {scelta2}");
        else Console.WriteLine("ERRORE");


    }

    static void Esercizio13() // ESERCIZIO 13
    {
        Console.WriteLine("Metti il tuo nome e io lo stamperò");
        string nome = Console.ReadLine();
        if (nome == "" || nome == null)
            Console.WriteLine("Non hai inserito nessun nome");
        else Console.WriteLine($"il tuo nome è {nome}");
    }

    static void Esercizio14() // ESERCIZIO 14
    {
        Console.WriteLine("Inserisci un anno:");
        int anno = int.Parse(Console.ReadLine());

       
        if (anno % 4 == 0)
        {
            if (anno % 100 == 0)
            {
                if (anno % 400 == 0)
                {
                    Console.WriteLine($"{anno} è un anno bisestile.");
                }
                else
                {
                    Console.WriteLine($"{anno} non è un anno bisestile.");
                }
            }
            else
            {
                Console.WriteLine($"{anno} è un anno bisestile.");
            }
        }
        else
        {
            Console.WriteLine($"{anno} non è un anno bisestile.");
        }
    }

    static void Esercizio15() // ESERCIZIO 15
    {
        Console.WriteLine("Inserisci qua sotto la prima stringa");
        string stringa = Console.ReadLine();
        Console.WriteLine("Adesso inserisci una parola o stringa che è contenuta nella tua prima frase");
        string sottostringa = Console.ReadLine();
        if (stringa.Contains(sottostringa))
        {
            if (sottostringa == "" || sottostringa == null)
                Console.WriteLine("Non hai inserito nessuna sottostringa");
            else
                Console.WriteLine($"Nella stringa: {stringa} è presente la sottostringa : {sottostringa}");
        }
        else Console.WriteLine("La tua sottostringa non è presente nel primo testo inserito");
    }

    static void Esercizio16() // ESERCIZIO 16
    {
        int[] numeri = { 7, 42, 97, 82, 61, 38, 2 };
        Console.WriteLine("Ciao utente, indovina quali numeri ci sono nella mia lista :D");
        int scelta = int.Parse(Console.ReadLine());
        if (numeri.Contains(scelta))
            Console.WriteLine("Hai indovinato");
        else if (scelta == null)
            Console.WriteLine("Non hai inserito nulla");
        else Console.WriteLine("Hai sbagliato :(");

    }

    static void Esercizio17() // ESERCIZIO 17
    {
        Console.WriteLine("Inserisci un numero:");
        int numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            Console.WriteLine("Il numero è positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Il numero è negativo");
        }
        else
        {
            Console.WriteLine("Il numero è 0");
        }
    }

    static void Esercizio18() // ESERCIZIO 18
    {
        Console.WriteLine("Digita un numero da 1 a 7 per sapere che giornata della settimana raffigura");
        int giorno = int.Parse(Console.ReadLine());
        switch (giorno)
        {
            case 1:
                Console.WriteLine("Lunedi'");
                break;
            case 2:
                Console.WriteLine("Martedi'");
                break;
            case 3:
                Console.WriteLine("Mercoldi'");
                break;
            case 4:
                Console.WriteLine("Giovedi'");
                break;
            case 5:
                Console.WriteLine("Venerdi'");
                break;
            case 6:
                Console.WriteLine("Sabato");
                break;
            case 7:
                Console.WriteLine("Domenica");
                break;
            default:
                Console.WriteLine("ERRORE");
                break;
        }
    }

    static void Esercizio19() // ESERCIZIO 19
    {
        Console.WriteLine("Inserisci un numero e ti dirò sè può essere diviso per 3 e 5");
        int numero = int.Parse(Console.ReadLine());
        int resto;
        resto = numero % 3;
        if (resto == 0)
        {
            resto = numero % 5;
            if (resto == 0)
            {
                Console.WriteLine("Il numero puo essere diviso per 3 e 5");
            }
            else
            {
                Console.WriteLine("Il tuo numero puo essere diviso solo per 3");
            }
        }
        else if (resto != 0)
        {

            resto = numero % 5;
            if (resto == 0)
            {
                Console.WriteLine("Il tuo numero può essere diviso per 5");

            }
            else Console.WriteLine("Il tuo numero non puo essere diviso per 3 e 5");
        }
        else Console.WriteLine("errore");

    }

    static void Esercizio20() // ESERCIZIO 20
    {
        bool valore = true;
        if (valore)
        {
            Console.WriteLine("Il valore è true.");
        }
        else
        {
            Console.WriteLine("Il valore è false.");
        }
    }


    static void Esercizio21() // ESERCIZIO 21
    {
       
        Console.WriteLine("Inserisci un colore (rosso, blu, verde):");
        string colore = Console.ReadLine();

        switch (colore.ToLower()) 
        {
            case "rosso":
                Console.WriteLine("Hai scelto il rosso.");
                break;
            case "blu":
                Console.WriteLine("Hai scelto il blu.");
                break;
            case "verde":
                Console.WriteLine("Hai scelto il verde.");
                break;
            default:
                Console.WriteLine("Colore non riconosciuto.");
                break;
        }
    }

    static void Esercizio22() // ESERCIZIO 22
    {
      
        int[] numeri = new int[0]; 

        if (numeri == null || numeri.Length == 0)
        {
            Console.WriteLine("L'array è vuoto.");
        }
        else
        {
            Console.WriteLine("L'array contiene elementi.");
        }
    }

    static void Esercizio23() // ESERCIZIO 23
    {
        {
 
            Console.WriteLine("Inserisci un numero intero e ti dirò sè è primo:");
            int numero = int.Parse(Console.ReadLine());

           
            if (numero <= 1)
            {
                Console.WriteLine($"{numero} non è un numero primo.");
            }
            else
            {
                bool isPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0) 
                    {
                        isPrimo = false;
                        break;
                    }
                }

                if (isPrimo)
                {
                    Console.WriteLine($"{numero} è un numero primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} non è un numero primo.");
                }
            }
        }
    }

    static void Esercizio24() // ESERCIZIO 24
    {
        {
           
            Console.WriteLine("Inserisci una parola e ti dirò sè è palindroma:");
            string parola = Console.ReadLine();

            for (int i = 0; i < parola.Length / 2; i++)
            {
                if (parola[i] != parola[parola.Length - 1 - i])
                {
                    Console.WriteLine($"{parola} non è una parola palindroma.");
                    return;
                }
            }

            Console.WriteLine($"{parola} è una parola palindroma.");
        }


    }
}