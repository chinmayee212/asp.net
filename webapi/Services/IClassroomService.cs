using System.Collections.Generic;

namespace webapi.Services
{
    public interface IClassroomService
    {
        bool AddStudent(Student student);

        IEnumerable<Student> GetAllStudents();
    }
}