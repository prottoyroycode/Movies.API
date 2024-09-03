namespace Movies.Api.ApiEndPoints
{
    public static class ApiEndpoints
    {
        public const string ApiBase = "api";
        
        public static class Movies
        {
            private const string Base = $"{ApiBase}/movies";


            public const string Create =Base ;
            public const string Get = $"{Base}/{{id:guid}}";
            public const string GetAll = $"{Base}";
        }
    }
}
