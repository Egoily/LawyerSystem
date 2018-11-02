using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class JudgeMap : ClassMap<Judge>
    {
        public JudgeMap()
        {
            Table("Judges");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();
            Map(x => x.PhoneNo);
            Map(x => x.Name);
            Map(x => x.Gender);
            References(x => x.InCourt).Column("CourtId").NotFound.Ignore();
        }
    }
}
