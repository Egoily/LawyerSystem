using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class PropertyItemCategortyMap : ClassMap<PropertyItemCategory>
    {
        public PropertyItemCategortyMap()
        {
            Table("PropertyItemCategories");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();
            Map(x => x.Name);
            Map(x => x.Code);
            References(x => x.Parent).Column("ParentId").LazyLoad(Laziness.False).NotFound.Ignore();
            HasMany(x => x.Children).KeyColumn("ParentId").Not.LazyLoad();
        }
    }
}
