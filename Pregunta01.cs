public class Pregunta01
{
    public static void Main(string[] args)
    {
        string comprobante;

        Console.WriteLine("Ingrese el comprobante: ");
        comprobante = Console.ReadLine();

        if (ValidarComprobante(comprobante))
        {
            Console.WriteLine("El comprobante es válido.");
        }
        else
        {
            Console.WriteLine("El comprobante es inválido.");
        }
    }

    public static bool ValidarComprobante(string _comprobante)
    {
        bool esValido = true;
        int i = 0;

        if(_comprobante.Length != 13)
        {
            esValido = false;
        }

        if (esValido)
        {
            if (_comprobante.Substring(0,1) != "B" && _comprobante.Substring(0,1) != "F")
            {
                esValido = false;
            }
        }

        if (esValido)
        {
            for (i = 1; i <= 3; i++)
            {
                if (!(int.Parse(_comprobante.Substring(i,1)) >= 0 && int.Parse(_comprobante.Substring(i,1)) <= 9))
                {
                    esValido = false;
                }
            }
            
        }

        if (esValido)
        {
            if (_comprobante.Substring(4,1) != "-")
            {
                esValido = false;
            }
        }

        if (esValido)
        {
            for (i = 5; i <= 12; i++)
            {
                if (!(int.Parse(_comprobante.Substring(i,1)) >= 0 && int.Parse(_comprobante.Substring(i,1)) <= 9))
                {
                    esValido = false;
                }
            }
            
        }

        return esValido;
    }
}