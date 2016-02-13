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

        public enum StateFilter
        {
            WellFormed,
            CreatePending,
            Deleting,
            New,
            All
        }
    }
}
