string Nombre;
double calificacion;


Console.WriteLine("Por favor, digita el nombre del empleado:");
Nombre = Console.ReadLine();
Console.WriteLine("Digita la calificacion, siendo 0.0 inaceptable, 0.4 aceptable, 0.6 meritorio: ");
calificacion = double.Parse(Console.ReadLine());

if(calificacion==0){

Console.WriteLine("El empleado " + Nombre + " con la calificacion " + calificacion + " no tiene bono, quedando el precio base de 50000");

}else if(calificacion==4){


Console.WriteLine("El empleado " + Nombre + " con la calificacion " + calificacion + " tiene un bono del 0.4, quedando en " + (0.4*50000));


}else if(calificacion==6){

Console.WriteLine("El empleado " + Nombre + " con la calificacion " + calificacion + " tiene un bono del 0.6, quedando en " + (0.6*50000));

}else{

Console.WriteLine("Solo las calificaciones establecidas");


} 


