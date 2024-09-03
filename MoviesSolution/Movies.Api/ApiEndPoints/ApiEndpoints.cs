namespace Movies.Api.ApiEndPoints
{
    public static class ApiEndpoints
    {
        public const string ApiBase = "api";
        
        public static class Movie
        {
            private const string Base = $"{ApiBase}/movies";
            public const string Create =Base ;
        }
    }
}
