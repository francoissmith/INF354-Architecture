namespace Architecture.Models
{
    public interface ICourseRepository
    {
        // Course
        Task<Course[]> GetAllCourseAsync();

        Task<Course> EditCourseAsync(int id, string name, string description, string duration);

        Task AddCourseAsync(string name, string descriptionm, string duration);

        Task DeleteCourseAsync(int id);

    }
}
