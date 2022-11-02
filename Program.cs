// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)


//Prodotto mioProdotto = new Prodotto();
//mioProdotto.codice = 2;
//Console.WriteLine(mioProdotto.codice);
//mioProdotto.Accenditi();
//mioProdotto.CambiaCose(45);
//Console.WriteLine(mioProdotto.codice);

//public class Prodotto
//{
//    public int codice;
//    private string nome;
//    private string descrizione;
//    private float prezzo;
//    private float iva;
//    public void Accenditi()
//    {
//        Console.WriteLine("VROOM!");
//    }
//    public void CambiaCose(int nuovoCoso)
//    {
//        codice = nuovoCoso;
//    }
//}


Prodotto mioProdotto = new Prodotto();
Console.WriteLine(mioProdotto.GetCodice());
mioProdotto.SetNome("Penna");
Console.WriteLine(mioProdotto.GetNome());
mioProdotto.SetDescrizione("è una bella penna");
Console.WriteLine(mioProdotto.GetDescrizione());
mioProdotto.SetPrezzo(0.50f);
Console.WriteLine(mioProdotto.GetPrezzo());
mioProdotto.SetIva(22);
Console.WriteLine(mioProdotto.GetIva());

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private float prezzo;
    private int iva;

    public Prodotto()
    {
        Random rnd = new Random();
        codice = rnd.Next(9999999);
    }
    //Getter
    public int GetCodice()
    {
        return this.codice;
    }
    public string GetNome()
    {
        return this.nome;
    }
    public string GetDescrizione()
    {
        return this.descrizione;
    }
    public float GetPrezzo()
    {
        return this.prezzo;
    }
    public float GetIva()
    {
        return this.iva;
    }
    public float GetPrezzoIva()
    {
        return this.prezzo + this.iva;
    }
    //Setter
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }
    public void SetPrezzo(float prezzo)
    {
        this.prezzo = prezzo;
    }
    public void SetIva(int iva)
    {
        this.iva = iva;
    }
}