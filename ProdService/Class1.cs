using AutoMapper;
using BLL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Models;

namespace ProdService
{
    public class ProdUserService
    {
        protected static MapperConfiguration autoMapperConfig;
        static User User { get; set; }
        static ProdUserService()
        {
            //进行配置
            autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserModel>();
                //配置不同属性的配置
                //.ForMember(m=>m.Password,opt=>opt.MapFrom(u=>u.Password));
                //忽略UserModel的Password,不要去映射
                //.ForMember(m => m.Password, opt => opt.Ignore());
                //null替换
                //.ForMember(m => m.Password, opt => opt.NullSubstitute("没有密码"));
            });
#if DEBUG   //断言，事先自行检查
            autoMapperConfig.AssertConfigurationIsValid();
#endif
            IMapper mapper = autoMapperConfig.CreateMapper();
            UserModel model = mapper.Map<UserModel>(User);
        }
        protected IMapper mapper
        {
            get
            {
                return autoMapperConfig.CreateMapper();
            }
        }
    }
}
