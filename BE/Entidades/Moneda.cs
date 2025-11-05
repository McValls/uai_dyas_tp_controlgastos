namespace BE
{
    public enum Moneda
    {
        PESOS,
        DOLARES
    }

    public static class MonedaExtensions
    {
        public static string ToStringCustom(this Moneda moneda)
        {
            switch (moneda)
            {
                case Moneda.PESOS:
                    return "$";
                case Moneda.DOLARES:
                    return "u$s";
                default:
                    return moneda.ToString();
            }
        }
    }
}