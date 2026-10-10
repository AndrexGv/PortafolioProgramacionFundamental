//primer ejemplo
try
{
    Console.WriteLine("Cantidad de productos");
    int cantidad = int.Parse (Console.ReadLine());
    Console.WriteLine("El doble es: " + cantidad * 2);
}
catch(FormatException)
{
    Console.WriteLine("Agarramos un error de formato");
}
finally
{
    Console.WriteLine("AQUI TERMINO LA PRUEBA");
}
//segundo ejemplo
