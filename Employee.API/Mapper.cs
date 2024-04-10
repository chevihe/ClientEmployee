using AutoMapper;
using Employee.API.PostModel;
using Employee.Core.DTOs;
using Employee.Core.Entities;

namespace Employee.API
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Employee_, EmployeePostModel>().ReverseMap();
            CreateMap<EmployeeRole, EmployeeRolePostModel>().ReverseMap();
            CreateMap<Role, RolePostModel>().ReverseMap();
        }
    }
    
}
