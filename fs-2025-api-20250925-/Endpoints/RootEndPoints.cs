namespace fs_2025_api_20250925_.Endpoints
{
    public static class RootEndPoints
    {
        public static void AddRootEndPoints(this WebApplication app)
        {
            app.MapGet("/", () => "Hello World");
            app.MapGet("/demo", () => "Hello World, this is a demo");
        }
    }
}
