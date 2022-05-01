using EasyMektep.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMektep.Interfaces
{
    public interface IProjectInterface
    {
        List<CourseCardModel> GetLastOpened();
        List<CourseCardModel> GetNewCourses();
        List<CourseCardModel> GetAllCourses();
        public void Complete(int id);
        public void Delete(int id);
        CourseModel GetCourse(int id);
        public void CompleteAssignment(int id);
        public void DeleteAssignment(int id);
        AssignmentCardModel GetAssignment(int id);
    }
}
