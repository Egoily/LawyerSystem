﻿using FluentNHibernate.Mapping;
using ee.ls.Models.Entities;

namespace ee.ls.Repository.Mappings
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Table("Projects");
            Id(x => x.Id);
            //.GeneratedBy.Assigned();
            Map(x => x.Name);
            Map(x => x.Code);
            Map(x => x.Level);
            Map(x => x.Details);
            Map(x => x.CreateTime);
            Map(x => x.UpdateTime);
            HasMany(x => x.InvolvedClients).Cascade.All();
            References(x => x.Owner).Column("OwnerId").NotFound.Ignore();
        }
    }
}
