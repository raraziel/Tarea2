// Ejercicio 1
Console.WriteLine("Escribe tu nombre");
string? nombre = Console.ReadLine();

Console.WriteLine("Escribe tu apellido");
string? apellido = Console.ReadLine();

Console.WriteLine("Escribe tu edad");
string? edad = Console.ReadLine();
int edad2 = Convert.ToInt32(edad);

Console.WriteLine("¿Sabes programar?");
string? programar = Console.ReadLine();

Console.WriteLine("Tu nombre es " + nombre + " tu apellido es " + apellido + " tienes " + edad2 + " años y " + programar + " sabes programar.");

// Ejercicio2
Console.WriteLine("Escribe MESA para conocer las caracteristicas");
float peso = 15.5f;
float largo = 2.50f;
string material = "Pino";
string color = "cafe";
Console.WriteLine("La mesa es de color " + color + " su peso es de " + peso + " su lardo es de " + largo + " y es de " + material);

Console.WriteLine("Escribe CARRO para conocer las caracteristicas");
int puertas = 4;
int rueda = 4;
string marca = "Toyota";
int itv_vigente = 48;
Console.WriteLine("El carro tiene " + puertas + " puertas" + " tiene " + rueda + " ruedas" + " su marca es " + marca + " y su ITV Vigentes es " + itv_vigente);

// Ejercicio3

int n1 = 10;
int n2 = 18;
Console.WriteLine("10 es menor que 18 "  + (n1 >= n2));

char uno = 'a';
Console.WriteLine("a es una letra " + (uno));

int a = 9;
int b = 11;

Console.WriteLine(a < 10 && b > 11);
Console.WriteLine(a < 10 && b < 12);

int c = 8;
int d = 10;
Console.WriteLine(c < 10 || d > 11);
Console.WriteLine(c < 10 || d < 12);


