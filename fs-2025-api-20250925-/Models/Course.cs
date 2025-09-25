namespace fs_2025_api_20250925_.Models
{

    public class Course
    {
        public int id { get; set; }
        public bool isPreorder { get; set; }
        public string courseUrl { get; set; }
        public string courseType { get; set; }
        public string courseName { get; set; }
        public int courseLessonCount { get; set; }
        public decimal courseLengthInHours { get; set; }
        public string shortDescription { get; set; }
        public string courseImage { get; set; }
        public int priceInUSD { get; set; }
        public string coursePreviewLink { get; set; }
    }

}
