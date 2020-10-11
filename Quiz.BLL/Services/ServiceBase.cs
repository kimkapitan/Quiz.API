using AutoMapper;
using Quiz.DAL.EF;

namespace Quiz.BLL.Services
{
    public class ServiceBase
    {
        protected readonly IMapper Mapper;
        protected readonly ApplicationContext Context;

        public ServiceBase(IMapper mapper, ApplicationContext context)
        {
            Mapper = mapper;
            Context = context;
        }
    }
}
