using fs_2025_api_20250925_.Data;

namespace fs_2025_api_20250925_.Startup
{
    public static class DependenciesConfig
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<CourseData>();
        }
    }
}
