namespace Web.API
{
    public class ApiEndpoints
    {
        private const string ApiBase = "api";
        public static class Method
        {
            private const string Base = $"{ApiBase}/Anime";
            public const string Create = Base;
            public const string Get = $"{Base}/{{id:guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:guid}}";
            public const string Delete = $"{Base}/{{id:guid}}";
        }
    }
}
