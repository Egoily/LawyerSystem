using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class SysUserMap : ClassMap<SysUser>
    {
        public SysUserMap()
        {
            Table("SysUsers");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();
            Map(x => x.PhoneNo);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.Nickname);
            Map(x => x.Status);
            Map(x => x.Level);
            Map(x => x.CreateTime);
            Map(x => x.UpdateTime);
        }
    }
}
