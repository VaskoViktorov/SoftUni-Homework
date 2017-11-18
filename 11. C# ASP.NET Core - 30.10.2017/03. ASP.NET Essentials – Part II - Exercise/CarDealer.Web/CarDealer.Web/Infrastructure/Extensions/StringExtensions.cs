namespace CarDealer.Web.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string ToPrice(this decimal priceText)
        {
            return $"${priceText:F2}";
        }

        public static string ToPercentage(this double percentageText)
        {
            return $"{percentageText*100}%";
        }

        public static string ToKilometers(this long distanceText)
        {
            return $"{distanceText / 1000} km";
        }
    }
}
