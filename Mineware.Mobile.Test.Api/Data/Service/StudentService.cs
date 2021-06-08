using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mineware.Mobile.Test.Api.Data.Models;
using Mineware.Mobile.Test.Api.Service;
using Mineware.Mobile.Test.Global.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Data.Service
{
	public class StudentService : IStudent
	{
		private readonly TestDbContext _TestDbContext;
		private readonly IMapper _mapper;

		public StudentService(TestDbContext testDbContext,
			IMapper mapper)
		{
			_TestDbContext = testDbContext;
			_mapper = mapper;
		}

		public async Task AddStudent(AddStudentDTO addStudent_Dto)
		{
			try
			{
				var newStudent = new tbl_Student();
				_mapper.Map(addStudent_Dto, newStudent);
				await _TestDbContext.tbl_Students.AddAsync(newStudent);
				var info = await _TestDbContext.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				
			}

		}

		public async Task Delete(int studentID)
		{
			var student = await _TestDbContext.tbl_Students.Where(a => a.StudentID == studentID).FirstOrDefaultAsync();
			_TestDbContext.tbl_Students.Remove(student);
			await _TestDbContext.SaveChangesAsync();
		}

		public async Task<StudentInfoDTO> Student(int studentID)
		{
			var student = await _TestDbContext.tbl_Students.Where(a => a.StudentID == studentID).FirstOrDefaultAsync();
			var result = new StudentInfoDTO();
			_mapper.Map(student, result);

			return result;
		}

		public async Task<IEnumerable<StudentInfoDTO>> StudentList()
		{
			var students = await _TestDbContext.tbl_Students.ToListAsync();
			var result = new List<StudentInfoDTO>();
			_mapper.Map(students, result);

			return result;
		}

		public async Task UpdateStudent(StudentInfoDTO student)
		{
			var updateStudent = await _TestDbContext.tbl_Students.Where(a => a.StudentID == student.StudentID).FirstOrDefaultAsync();
			if(updateStudent != null)
			{
				_mapper.Map(student, updateStudent);
				await _TestDbContext.SaveChangesAsync();
			}
		}
	}
}
