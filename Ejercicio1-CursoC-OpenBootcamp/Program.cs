Console.WriteLine("Introduce tu nombre: ");
var nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}");
var hora = DateTime.Now;
Console.WriteLine($"Son las {hora.Hour}:{hora.Minute} del día {hora.ToShortDateString()}");
