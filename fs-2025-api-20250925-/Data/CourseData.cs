using fs_2025_api_20250925_.Models;
using System.Text.Json;

namespace fs_2025_api_20250925_.Data
{
    public class CourseData
    {
        public List<Course> Courses { get; private set; } = new List<Course>();

        public CourseData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "coursedata.json");
            var jsonData = File.ReadAllText(filePath);
            Courses = JsonSerializer.Deserialize<List<Course>>(jsonData, options) ?? new List<Course>();
        }

    }
}
