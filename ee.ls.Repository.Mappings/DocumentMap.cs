using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Table("Documents");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();
            Map(x => x.DocType);
            Map(x => x.Abstract);
            Map(x => x.FilePath);
            Map(x => x.Labels);
            Map(x => x.Remark);
            Map(x => x.CreateTime);
            References(x => x.Uploador).Column("UploadorId").NotFound.Ignore();

        }
    }
}
