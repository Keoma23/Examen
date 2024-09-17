bool entrar = true;

void TipoNumero()
{
    Console.WriteLine("Escribe un numero: ");
    int Numero = int.Parse(Console.ReadLine());
    if (Numero == 0) { Console.WriteLine($"El {Numero} es Neutro"); }
    else if (Numero > 0) { Console.WriteLine($"El {Numero} es Positivo"); }
    else { Console.WriteLine($"El {Numero} es Negativo"); }
}

void DiaSemana()
{
    Console.WriteLine("Escribe un numero del 1 al 7: ");
    int Numero = int.Parse(Console.ReadLine());
    switch (Numero) {
        case 1: Console.WriteLine("Lunes"); break;
        case 2: Console.WriteLine("Martes"); break;
        case 3: Console.WriteLine("Miercoles"); break;
        case 4: Console.WriteLine("Jueves"); break;
        case 5: Console.WriteLine("Viernes"); break;
        case 6: Console.WriteLine("Sabado"); break;
        case 7: Console.WriteLine("Domingo"); break;
        default: Console.WriteLine("No existe ese dia"); break;
    }
}

void SumaCienPrimeros()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++) { suma += i; }
    Console.WriteLine("La suma de los 100 Primeros numeros es " + suma);
}

void NumeroHasta()
{
    Console.WriteLine("Escribe un numero mayor o igual al 1:");
    int Numero = int.Parse(Console.ReadLine());
    if (Numero >= 1)
    {
        String Cadena = "1";
        for (int i = 2; i <= Numero; i++)
        {
            Cadena += "," + i;
        }
        Console.WriteLine(Cadena);
    } else { Console.WriteLine("Numero menor a 1");  }
    
}

void CalcularArea()
{
    Console.WriteLine("Escribe el radio del Circulo:");
    double radio = double.Parse(Console.ReadLine());
    if (radio >= 0) {
        double area = 3.14 * Math.Sqrt(radio);
        Console.WriteLine($"El area es " + area);
    }
    else
    {
        Console.WriteLine("El radio de ser un numero entero)");
    }
    
}

void MiArreglo()
{
    String[] Arreglo = new string[4];
    Arreglo[0] = "Cereza";
    Arreglo[1] = "Mandarina";
    Arreglo[2] = "Manzana";
    Arreglo[3] = "Fresa";

    foreach (String s in Arreglo) { Console.WriteLine(s); }
}

void NombresGuardados()
{
    List<String> Nombres = new List<String>();
    Nombres.Add("Hugo");
    Nombres.Add("Pedro");
    Nombres.Add("Juan");
    Nombres.Add("Miguel");

    foreach (String s in Nombres) { Console.WriteLine(s); }
}

do
{
    Console.WriteLine("1. Tipo de Numero ");
    Console.WriteLine("2. Dia de la Semana");
    Console.WriteLine("3. Suma de los 100 primeros numeros");
    Console.WriteLine("4. Los numero del 1 al ...");
    Console.WriteLine("5. Calcular Area con el radio ");
    Console.WriteLine("6. Mostrar mi arreglo");
    Console.WriteLine("7. Mostrar nombres guardados");
    Console.WriteLine("8. SALIR");
    Console.WriteLine("");
    var opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:TipoNumero(); 
            break;
        case 2:DiaSemana(); 
            break;
        case 3:SumaCienPrimeros(); 
            break;
        case 4:NumeroHasta(); 
            break;
        case 5:CalcularArea(); 
            break;
        case 6:MiArreglo();
            break;
        case 7:NombresGuardados();
            break;
        case 8:
            entrar = false;
            break;
        default:
            Console.WriteLine("Elige una opcion del 1 al 8");
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("");

}
while (entrar);