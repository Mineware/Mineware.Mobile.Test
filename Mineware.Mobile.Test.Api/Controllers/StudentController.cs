using Microsoft.AspNetCore.Mvc;
using Mineware.Mobile.Test.Api.Service;
using Mineware.Mobile.Test.Global.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Controllers
{
	[Route("api/Student")]
	[ApiController]
	public class StudentController : Controller
	{
		IStudent _student;
		public StudentController(IStudent student)
		{
			_student = student;
		}

		[HttpPost("Add")]
		public async Task<IActionResult> Add(AddStudentDTO addStudent_Dto)
		{
			await _student.AddStudent(addStudent_Dto);
			return Ok();
		}

		[HttpGet]
		
		public async Task<IActionResult> AllStudents()
		{
			var students = await _student.StudentList();
			return Ok(students);
		}

		[HttpGet]
		[Route("{studentID}")]
		public async Task<IActionResult> Student(int studentID)
		{
			var student = await _student.Student(studentID);
			return Ok(student);
		}


		[HttpPut]
		public async Task<IActionResult> Add(StudentInfoDTO updateStudent)
		{
			await _student.UpdateStudent(updateStudent);
			return Ok();
		}
	}
}
