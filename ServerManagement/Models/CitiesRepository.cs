namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "São Paulo",
            "Osasco",
            "Guarulhos",
            "São Bernardo",
            "Rio de Janeiro",
            "BH",
            "Porto Alegre",
            "Curitiba",
            "Manaus",
            "Recife",
            "Fortaleza",
            "Salvador",
        };

        public static List<string> GetCities() => cities.OrderBy(c=>c).ToList();
    }
}
