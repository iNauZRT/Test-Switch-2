Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Bienvenido");
Console.WriteLine();
Console.Write("Hoy obtendremos su RFC ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Registro Federal de Contribuyentes");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Click para continuar");
Console.ReadKey();
Console.Clear();
String[] RFC = new string[7];
Console.ForegroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
do
{
    Console.WriteLine("Datos personales");
    Console.Write("Ingrese su nombre: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[0] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETRA in RFC[0])
    {
        if (char.IsNumber(LETRA))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se aceptan numeros en esta casilla");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[0] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[0]));
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Ingrese su apellido paterno: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[1] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETRA in RFC[1])
    {
        if (char.IsNumber(LETRA))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se aceptan numeros en esta casilla");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[1] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[1]));
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Ingrese su apellido materno: ");
    Console.ForegroundColor = ConsoleColor.Green;
    RFC[2] = Console.ReadLine();
    Console.WriteLine();
    foreach (char LETRA in RFC[2])
    {
        if (char.IsNumber(LETRA))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se aceptan numeros en esta casilla");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            RFC[2] = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(RFC[2]));
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.WriteLine();
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("ingrese su fecha de nacimiento");
Console.Write("Dia: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[3] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Mes: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[4] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Año: ");
Console.ForegroundColor = ConsoleColor.Green;
RFC[5] = Convert.ToString(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ReadKey();
Console.Clear();
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Nombre: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[0]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Apellido Paterno: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[1]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Apellido Materno: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[2]);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Fecha de nacimiento: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[3] + " / " + RFC[4] + " / " + RFC[5]);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Su RFC es: ");
RFC[1] = RFC[1].Substring(0, 2);
RFC[1] = RFC[1].Replace("a", "x");
RFC[1] = RFC[1].Replace("e", "x");
RFC[1] = RFC[1].Replace("i", "x");
RFC[1] = RFC[1].Replace("o", "x");
RFC[1] = RFC[1].Replace("u", "x");
RFC[1] = RFC[1].ToUpper();
RFC[2] = RFC[2].Substring(0, 1);
RFC[2] = RFC[2].ToUpper();
RFC[0] = RFC[0].Substring(0, 1);
RFC[0] = RFC[0].ToUpper();
RFC[5] = RFC[5].Substring(2, 2);
RFC[6] = RFC[1] + RFC[2] + RFC[0] + RFC[5] + RFC[4] + RFC[3];
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(RFC[6]);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("No es una RFC completa ya que necesita homoclave");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=====================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();