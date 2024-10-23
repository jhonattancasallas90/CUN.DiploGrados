using System;
using Humanizer;

public static class DateConversor
{
    // Método principal para convertir fecha a letras
    public static string ConvertirFechaALetras(DateTime fecha)
    {
        string diaTexto = DiaALetras(fecha.Day);
        string mesTexto = MesEnLetras(fecha.Month);
        string anoTexto = AñoALetras(fecha.Year);

        return $"{diaTexto} de {mesTexto} de {anoTexto}";
    }

    // Convertir el día a texto
    public static string DiaALetras(int dia)
    {
        return dia.ToWords(); // Humanizer convierte el número a palabras
    }

    // Convertir el mes a texto
    public static string MesEnLetras(int mes)
    {
        // Los nombres de los meses en español
        string[] meses = {
            "enero", "febrero", "marzo", "abril", "mayo", "junio",
            "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"
        };
        return meses[mes - 1]; // Resta 1 porque los índices empiezan en 0
    }

    // Convertir el año a texto
    public static string AñoALetras(int ano)
    {
        return ano.ToWords(); // Humanizer convierte el número a palabras
    }
}

