using DesafioPOO.Models;

Nokia nokia = new Nokia("9200031", "Moto", "12434521345", 8);
Iphone iphone = new Iphone("4342555", "Apple", "3232323", 16);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
