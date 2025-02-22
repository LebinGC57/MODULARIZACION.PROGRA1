using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Menu principal
            Console.Clear();
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("1. Calculadora basica");
            Console.WriteLine("2. Validacion de contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversion de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CalculadoraBasica();
                    break;
                case "2":
                    ValidacionContraseña();
                    break;
                case "3":
                    NumerosPrimos();
                    break;
                case "4":
                    SumaNumerosPares();
                    break;
                case "5":
                    ConversionTemperatura();
                    break;
                case "6":
                    ContadorVocales();
                    break;
                case "7":
                    CalculoFactorial();
                    break;
                case "8":
                    JuegoAdivinanza();
                    break;
                case "9":
                    PasoPorReferencia();
                    break;
                case "10":
                    TablaMultiplicar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opcion no valida. Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // 1. Calculadora basica
    static void CalculadoraBasica()
    {
        double num1, num2;
        string operacion;

        Console.WriteLine("Calculadora basica:");
        Console.Write("Ingrese el primer numero: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Numero no valido, intente nuevamente: ");
        }

        Console.Write("Ingrese el segundo numero: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Numero no valido, intente nuevamente: ");
        }

        Console.WriteLine("Seleccione la operacion (+, -, *, /): ");
        operacion = Console.ReadLine();

        double resultado = 0;

        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("No se puede dividir entre 0.");
                break;
            default:
                Console.WriteLine("Operacion no valida.");
                break;
        }

        Console.WriteLine($"Resultado: {resultado}");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 2. Validacion de contraseña
    static void ValidacionContraseña()
    {
        string contraseña;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            contraseña = Console.ReadLine();
            if (contraseña != "lebin5750")
            {
                Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
            }
        } while (contraseña != "lebin5750");

        Console.WriteLine("Acceso concedido.");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 3. Números primos
    static void NumerosPrimos()
    {
        int num;
        Console.Write("Ingrese un numero: ");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Numero no valido, intente nuevamente: ");
        }

        bool esPrimo = true;
        if (num <= 1)
            esPrimo = false;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            Console.WriteLine($"{num} es primo.");
        else
            Console.WriteLine($"{num} no es primo.");

        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 4. Suma de numeros pares
    static void SumaNumerosPares()
    {
        int suma = 0;
        int num;

        Console.WriteLine("Ingrese numeros para sumar los pares. Ingrese 0 para finalizar.");

        while (true)
        {
            Console.Write("Ingrese un numero: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Numero no valido, intente nuevamente: ");
            }

            if (num == 0)
                break;

            if (num % 2 == 0)
                suma += num;
        }

        Console.WriteLine($"La suma de los numeros pares es: {suma}");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 5. Conversion de temperatura
    static void ConversionTemperatura()
    {
        Console.WriteLine("Seleccione la conversion: ");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        string opcion = Console.ReadLine();

        double temperatura, resultado;

        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese la temperatura en Celsius: ");
                while (!double.TryParse(Console.ReadLine(), out temperatura))
                {
                    Console.Write("Temperatura no valida, intente nuevamente: ");
                }

                resultado = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"{temperatura}°C es igual a {resultado}°F");
                break;
            case "2":
                Console.Write("Ingrese la temperatura en Fahrenheit: ");
                while (!double.TryParse(Console.ReadLine(), out temperatura))
                {
                    Console.Write("Temperatura no valida, intente nuevamente: ");
                }

                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura}°F es igual a {resultado}°C");
                break;
            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }

        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 6. Contador de vocales
    static void ContadorVocales()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();
        int contador = 0;

        foreach (char c in frase)
        {
            if ("aeiou".Contains(c))
                contador++;
        }

        Console.WriteLine($"La cantidad de vocales es: {contador}");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 7. Calculo de factorial
    static void CalculoFactorial()
    {
        Console.Write("Ingrese un número: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        {
            Console.Write("Numero no válido o negativo, intente nuevamente: ");
        }

        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {num} es: {factorial}");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 8. Juego de adivinanza
    static void JuegoAdivinanza()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        do
        {
            Console.Write("Ingrese su intento: ");
            while (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.Write("Numero no válido, intente nuevamente: ");
            }

            if (intento < numeroSecreto)
                Console.WriteLine("Demasiado bajo.");
            else if (intento > numeroSecreto)
                Console.WriteLine("Demasiado alto.");
            else
                Console.WriteLine("¡Felicidades! Adivinaste el número.");

        } while (intento != numeroSecreto);

        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    // 9. Paso por referencia
    static void PasoPorReferencia()
    {
        int num1, num2;

        Console.Write("Ingrese el primer numero: ");
        while (!int.TryParse(Console.ReadLine(), out num1)) ;

        Console.Write("Ingrese el segundo numero: ");
        while (!int.TryParse(Console.ReadLine(), out num2)) ;

        Console.WriteLine($"Antes de intercambiar: num1 = {num1}, num2 = {num2}");

        Intercambiar(ref num1, ref num2);

        Console.WriteLine($"Después de intercambiar: num1 = {num1}, num2 = {num2}");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }

    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 10. Tabla de multiplicar
    static void TablaMultiplicar()
    {
        Console.Write("Ingrese un numero: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Numero no válido, intente nuevamente: ");
        }

        Console.WriteLine($"Tabla de multiplicar del {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }
}