using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class AreaMap : ClassMap<Area>
    {
        public AreaMap()
        {
            Table("Areas");

            Id(x => x.AreaCode);
            //.GeneratedBy.Assigned();
            Map(x => x.Name);
            References(x => x.Parent).Column("ParentId").LazyLoad(Laziness.False).NotFound.Ignore();
            HasMany(x => x.Children).KeyColumn("ParentId").Not.LazyLoad();
        }
    }
}
