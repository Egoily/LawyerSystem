using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("Clients");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();   
            Map(x => x.IsNP);
            Map(x => x.Name);
            Map(x => x.Abbreviation);
            Map(x => x.CreateTime);
            Map(x => x.UpdateTime);

            HasMany(x => x.Properties);
        }
    }
}
