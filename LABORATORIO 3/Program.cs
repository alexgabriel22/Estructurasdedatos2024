public class Empleado
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Area { get; set; }
    public decimal SueldoBase { get; set; }
    public decimal HorasExtras { get; set; }
    public string TipoSeguro { get; set; }
    private static decimal porc_Afp = (decimal)0.11;
    private static decimal porc_Snp = (decimal)0.6;
    private static decimal porc_Essalud = (decimal)0.03;
    private static int contador = 0;

    public Empleado(string codigo, string nombre, string area, decimal sueldoBase, decimal horasExtras, string
    tipoSeguro)
    {
        contador++;
        Codigo = codigo;
        Nombre = nombre;
        Area = area;
        SueldoBase = sueldoBase;
        HorasExtras = horasExtras;
        TipoSeguro = tipoSeguro;
    }
    public decimal CalcularHorasExtras()
    {
        return SueldoBase * HorasExtras / 240;
    }
    public decimal CalcularMontoSeguro()
    {
        if (TipoSeguro == &quot; AFP & quot;)
return SueldoBase * porc_Afp;
        if (TipoSeguro == &quot; SNP & quot;)
return SueldoBase * porc_Snp;
        return 0;
    }
    public decimal CalcularMontoEssalud()
    {
        return SueldoBase * porc_Essalud;
    }
    public decimal CalularDescuento()
    {
        return CalcularMontoSeguro() + CalcularMontoEssalud();
    }
    public decimal SueldoBruto()
    {
        return SueldoBase + HorasExtras;
    }
    public decimal SueldoNeto()
    {
        return SueldoBruto() - CalularDescuento();
    }
    public static int GetContador()
    {
        return contador;
    }
}
