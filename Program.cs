// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;



Prodotto penna = new Prodotto ("Penna Bic","Una penna senza pretese.", 1.5f, 22f);


Console.WriteLine(penna.nomeProdotto);
Console.WriteLine($"CODICE PRODOTTO: {penna.GetCodiceProdotto()}");
Console.WriteLine(penna.descrizioneProdotto);
Console.WriteLine($"Prezzo senza IVA: {penna.prezzoNoIVA} EUR");
Console.WriteLine($"Prezzo IVA inclusa con IVA del {penna.percentualeIVA}% : {penna.calcPrezzoIvato()} EUR");
Console.WriteLine("-----------------------------------------------------");


Prodotto saldatore = new Prodotto("Saldatore Hakko","Un'eccellente stazione saldante per gli appassionati del fai da te!", 149.99f, 22f);

Console.WriteLine(saldatore.nomeProdotto);
Console.WriteLine($"CODICE PRODOTTO: {saldatore.GetCodiceProdotto()}");
Console.WriteLine(saldatore.descrizioneProdotto);
Console.WriteLine($"Prezzo senza IVA: {saldatore.prezzoNoIVA} EUR");
Console.WriteLine($"Prezzo IVA inclusa con IVA del {saldatore.percentualeIVA}% : {saldatore.calcPrezzoIvato()} EUR");
Console.WriteLine("-----------------------------------------------------");