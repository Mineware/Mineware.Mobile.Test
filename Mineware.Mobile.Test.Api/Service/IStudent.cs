using Mineware.Mobile.Test.Global.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Service
{
	public interface IStudent
	{
		Task AddStudent(AddStudentDTO addStudent_Dto);
		Task<IEnumerable<StudentInfoDTO>> StudentList();
		Task<StudentInfoDTO> Student(int studentID);
		Task UpdateStudent(StudentInfoDTO student);
		Task Delete(int studentID);
	}
}
