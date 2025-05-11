/* 42 Magic Fortune Ball
Taianomainen Ennustuspallo voi ennustaa tulevaisuutta ja vastata kyllä/ei -kysymyksiisi 100 prosentin tarkkuudella Pythonin satunnaislukugeneraattorin avulla. Tämä ohjelma on samanlainen kuin Taikakuula-lelu, mutta sitä ei tarvitse ravistaa. Se sisältää myös funktion, joka tulostaa tekstiä hitaasti välilyönnein kirjainten välillä, antaen viesteille aavemaisen, salaperäisen vaikutelman.
Kuvaus
Ohjelma lukee käyttäjän syöttämän kyllä/ei-kysymyksen.
Se käyttää C#
Random-luokkaa valitakseen satunnaisesti vastauksen.
PrintWithSpookyEffect-funktio tulostaa vastauksen siten, että jokaisen kirjaimen väliin lisätään välilyönti ja viive, mikä luo aavemaisen vaikutelman.
Voit muokata viivettä (millisekunteina) tai vastauksia lisätäksesi lisää vaihtoehtoja!
 */
using System.Threading;

class MagicFortuneBall
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tervetuloa Taianomaisen Ennustuspallon luokse!");
        Console.Write("Kysy kyllä/ei -kysymys: ");
        Console.ReadLine();  // Lukee käyttäjän kysymyksen

        // Ennustuspallo vastaa satunnaisesti kyllä/ei-kysymyksiin
        string[] responses = { "Kyllä", "Ei", "Ehkä", "Epäselvää, kysy uudelleen", "Todennäköisesti", "Ei koskaan", "Mahdollisesti" };
        Random random = new Random();
        string response = responses[random.Next(responses.Length)];

        // Tulostetaan vastaus hitaasti välilyönnein
        PrintWithSpookyEffect(response);
    }

    static void PrintWithSpookyEffect(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c + " ");
            Thread.Sleep(150);  // Odottaa 150 millisekuntia jokaisen merkin jälkeen
        }
        Console.WriteLine();
    }
}

