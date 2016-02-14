namespace DefectFinder
{
    public static class Constants
    {
        public class JsonTfsNodes
        {
            public static string Value = "value";
        }

        public class AppConfig
        {
            public static string UsernameKey = "username";
            public static string PasswordKey = "password";
            public static string TfsServer = "tfsServer";
            public static string WebApiVersion = "webApiVersion";
        }

        public class StateFilter
        {
            public static string WellFormed = "WellFormed";
            public static string CreatePending = "CreatePending";
            public static string Deleting = "Deleting";
            public static string New = "New";
            public static string All = "All";
        }
    }
}
