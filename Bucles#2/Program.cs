Dictionary<string, int> planes = new Dictionary<string, int>();
planes.Add("individual", 2500);
planes.Add("doble", 4600);
planes.Add("familiar", 2200);

int precio_individual = planes["individual"];
int precio_doble = planes["doble"];
int precio_familiar = planes["familiar"];

string cerrar = "cerrar";
Console.Write("Ingrese su tipo de plan (individual,doble,familiar): ");
string plan = Console.ReadLine();

while (plan != cerrar)
{
    Console.Write("Ingrese la cantidad de dias que se va a hospedar: ");
    int dias = int.Parse(Console.ReadLine());

    double subtotal_individual = dias * precio_individual;
    double subtotal_doble = dias * precio_doble;
    double subtotal_familiar = dias * precio_familiar;

    double Iva_aplicado_individual = (subtotal_individual * 0.16) + subtotal_individual;
    double Iva_aplicado_doble = (subtotal_doble * 0.16) + subtotal_doble;
    double Iva_aplicado_familiar = (subtotal_familiar * 0.16) + subtotal_familiar;

    switch (plan)
    {

        case "individual":
            double descuento_individual = (Iva_aplicado_individual * 0.05) + Iva_aplicado_individual;
            Console.WriteLine($"LA tarifa individual tiene un valor de: {precio_individual}");
            Console.WriteLine("La tarifa individual tiene un descuento de 5%");
            Console.WriteLine($"El total a pagar es de {descuento_individual}");
            break;

        case "doble":
            double descuento_doble = (Iva_aplicado_doble * 0.09) + Iva_aplicado_doble;
            Console.WriteLine($"LA tarifa doble tiene un valor de: {precio_doble}");
            Console.WriteLine("La tarifa doble tiene un descuento de 9%");
            Console.WriteLine($"El total a pagar es de {descuento_doble}");
            break;

        case "familiar":
            double descuento_familiar = (Iva_aplicado_familiar * 0.15) + Iva_aplicado_familiar;
            Console.WriteLine($"LA tarifa familiar tiene un valor de: {precio_familiar}");
            Console.WriteLine("La tarifa familiar tiene un descuento de 15%");
            Console.WriteLine($"El total a pagar es de {descuento_familiar}");
            break;
        
        default:
            Console.WriteLine("El plan no existe");
        break;
    }

    Console.Write("Desea realizar otra operacion(si/no): ");
    string confirmacion = Console.ReadLine();

    if (confirmacion == "si")
    {
        Console.Write("Ingrese su tipo de plan (individual,doble,familiar): ");
        plan = Console.ReadLine();

    }
    else
    {
        break;
    }

}