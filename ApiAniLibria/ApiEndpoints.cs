﻿namespace Web.API
{
    public class ApiEndpoints
    {
        private const string ApiBase = "api";
        public static class Method
        {
            private const string Base = $"{ApiBase}/AniLibria";
            public const string Create = Base;
            public const string Get = $"{Base}/{{id:int}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:int}}";
            public const string Delete = $"{Base}/{{id:int}}";
        }
    }
}
