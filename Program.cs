// See https://aka.ms/new-console-template for more information


//saca 2 cartas gana el que tenga las 2 mayores
using System.ComponentModel.Design;

Random cartas = new();

Console.WriteLine("lanza la 1era carta del Crupier presiona enter");
Console.ReadLine();
var crupier1 = cartas.Next(1,11);
Console.WriteLine($"La 1era carta del crupier: {crupier1}");
Console.WriteLine(" ");
Console.WriteLine("Lanza la 1era carta del jugador");
Console.ReadLine();
var jugador1 = cartas.Next(1,11);
Console.WriteLine($"la 1era carta del jugador: {jugador1}");
Console.WriteLine(" ");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine($"1era crupier {crupier1} y 1era jugador {jugador1}");
Console.WriteLine("--------------------------------------------------------------------------");


Console.WriteLine("lanza la 2da carta del Crupier presiona enter");
Console.ReadLine();
var crupier2 = cartas.Next(1, 11);
Console.WriteLine($"La 2da carta del crupier: {crupier2}");
Console.WriteLine(" ");
Console.WriteLine("Lanza la carta del jugador enter");
Console.ReadLine();
var jugador2 = cartas.Next(1, 11);
Console.WriteLine($"la 2da carta del jugador: {jugador2}");
Console.WriteLine(" ");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine($"la 2da del crupier {crupier2} y la 2da del jugador {jugador2}");
Console.WriteLine("--------------------------------------------------------------------------");
Console.ReadLine();

int crupierTotal = crupier1 + crupier2;
int jugadorTotal = jugador1 + jugador2;

Console.WriteLine($"las cartas del crupier {crupierTotal} las cartas del jugador {jugadorTotal}");
Console.WriteLine(" ");
Console.WriteLine("==========================================================================");

if (crupierTotal > jugadorTotal)
{
    Console.WriteLine($"Gana el crupier!! tiene {crupierTotal} que es mayor que el jugador {jugadorTotal} ");

 
}
else if (crupierTotal == jugadorTotal)
{
    Console.WriteLine($"los jugadores han empatado!!! crupier: {crupierTotal} jugador: {jugadorTotal}");

}
else
    Console.WriteLine($" Gana el jugador!! tiene las cartas mayores jugador: {jugadorTotal} el crupier: {crupierTotal}");


Console.WriteLine("==========================================================================");
