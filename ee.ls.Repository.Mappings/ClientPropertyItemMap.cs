﻿using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class ClientPropertyItemMap : ClassMap<ClientPropertyItem>
    {
        public ClientPropertyItemMap()
        {
            Table("ClientPropertyItems");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();   
            Map(x => x.Value);
            Map(x => x.OrderNo);
            Map(x => x.CreateTime);
            Map(x => x.UpdateTime);

            References(x => x.Client).Column("ClientId").NotFound.Ignore();
            References(x => x.Category).Column("PropertyItemCategoryId").NotFound.Ignore();
        }
    }
}
