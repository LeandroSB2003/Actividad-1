string Nombre;
int Edad=0;
int PrecioB= 15000;


Console.WriteLine("Por favor, digita tu nombre:");
Nombre = Console.ReadLine();
Console.WriteLine("Por favor, digita tu edad: ");
Edad = Int32.Parse(Console.ReadLine());

if(Edad<4){

Console.WriteLine("El cliente " + Nombre + " con la edad de " + Edad + " tiene acceso gratis");

}else if(Edad>=4 && Edad<18){


Console.WriteLine("El cliente " + Nombre + " con la edad de " + Edad + " tiene un descuento del 5% por lo que paga " + (15000-5*PrecioB/100));

}else if(Edad>=18){

Console.WriteLine("El cliente " + Nombre + " con la edad de " + Edad + " tiene un descuento del 3% por lo que paga " + (15000-3*PrecioB/100));

}
