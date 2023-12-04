Console.WriteLine("Reto 2: Multiplicacion Rusa");
int Eleccion = 0;
int Multiplicador = 0;
int Multiplicando = 0;
while (Eleccion != 2)
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Realizar multiplicacion rusa");
        Console.WriteLine("2. Salir");
        Console.WriteLine("");
        Console.Write("Ingrese opcion que desea revisar: ");
        Eleccion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (Eleccion)
        {   
            case 1:
                Console.WriteLine("Multiplicacion Rusa");
                Console.Write("Ingrese el multiplicador: ");
                Multiplicador = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el multiplicando: ");
                Multiplicando = int.Parse(Console.ReadLine());
                int Producto = 0;
                Console.Write("El resultado es: ");
                while (Multiplicador!= 1)
                {
                    if (Multiplicador % 2 != 0)
                    {
                        Producto = Producto + Multiplicando;
                        Console.Write(Multiplicando);
                        Console.Write(" + ");
                    }
                        Multiplicador = Multiplicador / 2;
                        Multiplicando = Multiplicando * 2;
                }
                Console.Write(Multiplicando + " = ");
                Producto = Producto + Multiplicando;
                Console.WriteLine(Producto);
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("Lo esperamos pronto");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Valor incorrecto, ingrese un valor valido");
        Console.Write("Presione enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}