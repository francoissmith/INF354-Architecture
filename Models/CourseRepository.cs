using Microsoft.EntityFrameworkCore;

namespace Architecture.Models
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext;

        public CourseRepository(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }

        public async Task AddCourseAsync(string name, string description, string duration)
        {
            try
            {
                var newCourse = new Course
                {
                    Name = name,
                    Description = description,
                    Duration = duration
                };

                await _appDbContext.Courses.AddAsync(newCourse);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception($"Error adding course: {ex.Message}");
            }
        }


        public async Task DeleteCourseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Course> EditCourseAsync(int id, string name, string description, string duration)
        {
            throw new NotImplementedException();
        }

        public async Task<Course[]> GetAllCourseAsync()
        {
            IQueryable<Course> query = _appDbContext.Courses;
            return await query.ToArrayAsync();
        }
    }
}
