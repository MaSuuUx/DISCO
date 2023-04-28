class Program
{
    //CONSTANTES
    const double precioH = 10, precioM = 5;
    const double descHDom = 0.5, descHJue = 0.1, descHMar = 0.3;
    const double descMujerLMS = 0.5, descMVie = 1.0;

    static void Main(string[] args)
    {
       //VARIABLE
        string cliente;

        //ENTRADA DE DATOS
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Discoteca Torogoz \n");
        Console.WriteLine("Bienvenido, introduzca el sexo del cliente \nHombre (H) \nMujer (M) ");
        cliente = Console.ReadLine().ToUpper();
        Console.WriteLine("--------------------------------------------------------------------");


        //LLAMADO A LOS METODOS
        if (cliente == "H" || cliente == "HOMBRE") DescuentosHombre();
        else if (cliente == "M" || cliente == "MUJER") DescuentosMujeres();
        else Console.WriteLine("Opcion invalida");
    }
    static void DescuentosHombre()
    {
        //VARIABLES
        string dia;
        double desc = 0;

        //ENTREADA DE DATOS
        Console.WriteLine("----------------------------");
        Console.WriteLine("DESCUENTOS DE HOMBRES");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Ingrese el dia de semana: \n Lun \n Mar \n Mie \n Jue \n Vie \n Sab \n Dom ");
        dia = Console.ReadLine().ToUpper();

        //PROCESO
        switch(dia)
        {
            case "DOM":
                desc = precioH - (precioH * descHDom);
                break;
            case "MAR":
                desc = precioH - (precioH * descHMar);
                break;
            case "JUE":
                desc = precioH - (precioH * descHJue);
                break;
            default:
                desc = precioH;
                break;
        }

        //SALIDA DE DATOS

        Console.WriteLine("----------------------------");
        Console.WriteLine($"El total a pagar es de ${desc}");
        Console.WriteLine("----------------------------");

    }
    static void DescuentosMujeres() 
    {
        //VARIABLES
        string dia;
        double desc = 0;

        //ENTREADA DE DATOS
        Console.WriteLine("----------------------------");
        Console.WriteLine("DESCUENTOS DE MUJERES");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Ingrese el dia de semana: \n Lun \n Mar \n Mie \n Jue \n Vie \n Sab \n Dom ");
        dia = Console.ReadLine().ToUpper();

        //PROCESO
        switch (dia)
        {
            case "LUN":
                desc = precioM - (precioM * descMujerLMS);
                break;
            case "MIE":
                desc = precioM - (precioM * descMujerLMS);
                break;
            case "SAB":
                desc = precioM - (precioM * descMujerLMS);
                break;
            case "VIE":
                desc = precioM - (precioM * descMVie);
                break;
            default:
                desc = precioM;
                break;
        }

        //SALIDA DE DATOS
        Console.WriteLine("----------------------------");
        Console.WriteLine($"El total a pagar es de ${desc}");
        Console.WriteLine("----------------------------");

    }
}
