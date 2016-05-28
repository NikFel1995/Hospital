
namespace Hospital
{
    public static class DataConnection
    {

        public const string DataBaseName = "Ведение карточек пациентов в больнице";

        public static string Ip { get; set; }

        public static string Port { get; set; }

        public static string User { get; set; }

        public static string Password { get; set; }

        public static string UserType { get; set; }


        public const string DataDefaultSourse = ". , 1433";
    }
}
