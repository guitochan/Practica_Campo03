public class Pregunta02
{
    public static void Main(String[] args)
    {
        Console.WriteLine("================== CALCULO DE ACUERDO DE NIVEL DE SERVICIO ==================");
        Console.WriteLine("=============================================================================");
        Console.WriteLine("======================= REGISTRE SU TICKET DE SOPORTE =======================");
        Console.WriteLine("=============================================================================");
        Console.WriteLine("\nIngrese la fecha y hora de creacion (YYYY-MM-DD HH:MM): ");
        DateTime fechaCreacion = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la fecha y hora de resolucion (YYYY-MM-DD HH:MM): ");
        DateTime fechaResolucion = DateTime.Parse(Console.ReadLine());
        
        double horasLaborales = CalcularHorasLaborales(fechaCreacion, fechaResolucion);
        
        Console.WriteLine("\nLas horas laborales son: " + horasLaborales+ " horas.");

        if(horasLaborales <= 8)
        {
            Console.WriteLine("Cumplido.");
        }
        else
        {
            Console.WriteLine("Incumplido. Horas laborales excedidas: " + (horasLaborales - 8) + " horas de mas.");
        }
    }

    public static double CalcularHorasLaborales(DateTime inicio, DateTime fin)
    {
        double horas = 0;

        DateTime actual = inicio;

        while(actual < fin)
        {
            if(actual.DayOfWeek != DayOfWeek.Saturday && actual.DayOfWeek != DayOfWeek.Sunday)
            {
                DateTime inicioLaboral = new DateTime(actual.Year, actual.Month, actual.Day, 9, 0, 0);
                DateTime finLaboral = new DateTime(actual.Year, actual.Month, actual.Day, 17, 0, 0);

                DateTime desde = actual > inicioLaboral ? actual : inicioLaboral;
                DateTime hasta = fin < finLaboral ? fin : finLaboral;

                if(desde < hasta)
                {
                    horas += (hasta - desde).TotalHours;
                }
            }

            actual = actual.Date.AddDays(1);
        }

        return horas;
    }
}