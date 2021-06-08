using AutoMapper;
using Mineware.Mobile.Test.Api.Data.Models;
using Mineware.Mobile.Test.Global.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mineware.Mobile.Test.Api.Profiles
{
	public class StudentProfile : Profile
	{
		public StudentProfile()
		{
			CreateMap<AddStudentDTO, tbl_Student>();
			CreateMap<tbl_Student,AddStudentDTO>();
			CreateMap<tbl_Student, StudentInfoDTO>();
			CreateMap<StudentInfoDTO, tbl_Student>();
		}
	}
}
