using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("99885545", "C9", "5222dddd2s1142", 4);
Iphone iphone = new Iphone("88555455", "I13", "2252ddss1s12aa1", 6);


Console.WriteLine("IPhone -> Numero: "+iphone.Numero +" Imei: "+ iphone.Imei+" Modelo: "+iphone.Modelo+" Memoria: "+iphone.Memoria);
iphone.InstalarAplicativo("CrapCrop");
Console.WriteLine("Nokia -> Numero: " + nokia.Numero + " Imei: " + nokia.Imei + " Modelo: " + nokia.Modelo + " Memoria: " + nokia.Memoria);
nokia.InstalarAplicativo("CrapCrop");