using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("1236526498", "C3", "4578236984", 8);
n1.InstalarAplicativo("Whatsapp");
n1.DetalhesSmartphone();

Console.WriteLine("---------------------------------");

Iphone i1 = new Iphone("551155498778", "Iphone 11", "7889521584", 128);
i1.InstalarAplicativo("Whatsapp");
i1.DetalhesSmartphone();