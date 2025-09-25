using fs_2025_api_20250925_.Data;
using Microsoft.AspNetCore.Http.HttpResults;

namespace fs_2025_api_20250925_.Endpoints
{
    public static class CourseEndPoints
    {
        public static void AddCourseEndPoints(this WebApplication app)
        {
            app.MapGet("/courses", LoadAllCoursesAsync); 
        }

        private static async Task<IResult> LoadAllCoursesAsync(CourseData courseData)
        {
            var output = courseData.Courses;
            return Results.Ok(output);
        }
    }
}

