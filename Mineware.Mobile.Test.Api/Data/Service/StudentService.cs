using AutoMapper;
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

		public Task<IEnumerable<StudentInfoDTO>> StudentList()
		{
			throw new NotImplementedException();
		}
	}
}
