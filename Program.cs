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
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri
//(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

Prodotto mioProdotto = new Prodotto();
Console.WriteLine("Codice prodotto: " + mioProdotto.GetCodice());
mioProdotto.SetNome("Penna");
Console.WriteLine("Nome prodotto: " + mioProdotto.GetNome());
mioProdotto.SetDescrizione("è una bella penna");
Console.WriteLine("Descrizione prodotto: " + mioProdotto.GetDescrizione());
mioProdotto.SetPrezzo(0.50f);
Console.WriteLine("Prezzo prodotto: " + mioProdotto.GetPrezzo());
mioProdotto.SetIva(22);
Console.WriteLine("Iva settata al: " + mioProdotto.GetIva() + "%");
Console.WriteLine("Prezzo con iva: " + mioProdotto.GetPrezzoIva());
Console.WriteLine("Nome e codice: " + mioProdotto.GetNomeCodice());
Console.WriteLine("bonus pad left: " + mioProdotto.PadLeft());



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
        codice = rnd.Next(99999999);
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
        return (this.prezzo * this.iva) / 100 + this.prezzo;
    }
    public string GetNomeCodice()
    {
        return this.nome + ", " + this.codice;
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
    public string PadLeft()
    {
        //se codice.Length < 8 aggiungere zeri a sx con un ciclo for che cicli per un numero di volte inferiore a 10-codice.Length e ad ognuno aggiunga 0,
        //poi somma gli 0 al codice
        string codice = Convert.ToString(this.codice);
        if (codice.Length < 8)
        {
            for (int i = 0; codice.Length < 8; i++)
            {
                codice = "0" + codice;
            }
        }
        return codice;
    }
}