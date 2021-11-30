using AutoMapper;
using leave_management.Data;
using leave_management.Models;

namespace leave_management.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
