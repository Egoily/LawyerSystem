using System.Linq;
using ee.ls.Models.Entities;
using ee.Repository;
using ee.ls.Repository.Factory.Sqlite;
using ee.ls.Service.ContactInterfaces;
using ee.ls.Service.Contact.Args;
using ee.Framework;
using System;
using System.Collections.Generic;

namespace ee.ls.Service
{
    public class CtsService : ICtsService
    {

        private static bool IsSessionBuilded = false;
        public static void Build()
        {
            if (IsSessionBuilded) return;
            // create our  session factory
            SessionManager.Builder = new SqliteSessionFactoryBuilder();
            IsSessionBuilded = true;
        }
        public CtsService()
        {
            Build();
        }
        public BaseQueryResponse<Area> GetAreas(GetAreasRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseQueryResponse<Area>();
                    using (var repo = new NhRepository<Area>())
                    {
                        var query = repo.Query(x => x.Parent == null);

                        response.Total = query.Count();
                        response.QueryList = query.ToList();
                    }
                    return response;
                }
             );
        }

        public BaseResponse AddCourt(AddCourtRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhRepository<Court>())
                    {

                        var entity = repo.Query(x => x.Name == req.Name).FirstOrDefault();
                        if (entity != null)
                        {
                            throw new EeException(ErrorCodes.Existed, "Object is existed.");
                        }
                        entity = new Court()
                        {
                            Name = req.Name,
                            Province = req.Province,
                            City = req.City,
                            County = req.County,
                            Address = req.Address,
                            Rank = req.Rank,
                            ContactNo = req.ContactNo,

                        };
                        repo.Create(entity);
                    }
                    return response;
                }
            );

        }

        public BaseResponse UpdateCourt(UpdateCourtRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhRepository<Court>())
                    {
                        var entity = repo.GetById(req.Id);
                        if (entity == null)
                        {
                            throw new EeException(ErrorCodes.NotFound, "Object is not found.");
                        }
                        entity.Name = req.Name;
                        entity.Rank = req.Rank;
                        entity.Province = req.Province;
                        entity.City = req.City;
                        entity.County = req.County;
                        entity.Address = req.Address;
                        entity.ContactNo = req.ContactNo;
                        repo.Update(entity);
                    }
                    return response;
                }
            );

        }

        public BaseResponse RemoveCourt(RemoveCourtRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhRepository<Court>())
                    {
                        foreach (var id in req.Ids)
                        {
                            var entity = repo.GetById(id);
                            if (entity != null)
                            {
                                repo.Delete(entity);
                            }
                        }
                    }
                    return response;
                }
            );

        }

        public BaseQueryResponse<Court> QueryCourt(QueryCourtRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseQueryResponse<Court>();
                    using (var repo = new NhRepository<Court>())
                    {
                        var query = repo.Query();

                        response.Total = query.Count();
                        response.QueryList = query.ToList();
                    }
                    return response;
                }
             );
        }

        public BaseResponse AddJudge(AddJudgeRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhGlobalRepository())
                    {

                        var entity = repo.Query<Judge>(x => x.Name == req.Name && x.PhoneNo == req.PhoneNo).FirstOrDefault();
                        if (entity != null)
                        {
                            throw new EeException(ErrorCodes.Existed, "Object is existed.");
                        }
                        var court = repo.GetById<Court>(req.InCourtId);
                        entity = new Judge()
                        {
                            Name = req.Name,
                            PhoneNo = req.PhoneNo,
                            Gender = req.Gender,
                            InCourt = court,
                        };
                        repo.Create(entity);
                    }
                    return response;
                }
            );

        }

        public BaseResponse UpdateJudge(UpdateJudgeRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhGlobalRepository())
                    {
                        var entity = repo.GetById<Judge>(req.Id);
                        if (entity == null)
                        {
                            throw new EeException(ErrorCodes.NotFound, "Object is not found.");
                        }

                        entity.Name = req.Name;
                        entity.PhoneNo = req.PhoneNo;
                        entity.Gender = req.Gender;
                        entity.InCourt = repo.GetById<Court>(req.InCourtId) ?? throw new EeException(ErrorCodes.NotFound, "Court is not found.");

                        repo.Update(entity);
                    }
                    return response;
                }
            );

        }

        public BaseResponse RemoveJudge(RemoveJudgeRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhRepository<Judge>())
                    {
                        foreach (var id in req.Ids)
                        {
                            var entity = repo.GetById(id);
                            if (entity != null)
                            {
                                repo.Delete(entity);
                            }
                        }
                    }
                    return response;
                }
            );

        }

        public BaseQueryResponse<Judge> QueryJudge(QueryJudgeRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseQueryResponse<Judge>();
                    using (var repo = new NhRepository<Judge>())
                    {
                        var query = repo.Query();

                        response.Total = query.Count();
                        response.QueryList = query.ToList();
                    }
                    return response;
                }
             );
        }

        public BaseResponse AddClient(AddClientRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                 req =>
                 {
                     var response = new BaseResponse();
                     using (var repo = new NhGlobalRepository())
                     {

                         var entity = repo.Query<Client>(x => x.Name == req.Name).FirstOrDefault();
                         if (entity != null)
                         {
                             throw new EeException(ErrorCodes.Existed, "Object is existed.");
                         }
                         entity = new Client()
                         {
                             Name = req.Name,
                             //TODO:
                             CreateTime = DateTime.Now,

                         };
                         repo.Create(entity);
                     }
                     return response;
                 }
             );

        }

        public BaseResponse UpdateClient(UpdateClientRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                 req =>
                 {
                     var response = new BaseResponse();
                     using (var repo = new NhRepository<Client>())
                     {
                         var entity = repo.GetById(req.Id);
                         if (entity == null)
                         {
                             throw new EeException(ErrorCodes.NotFound, "Object is not found.");
                         }

                         entity.Name = req.Name;
                         //TODO:

                         repo.Update(entity);
                     }
                     return response;
                 }
             );

        }

        public BaseResponse RemoveClient(RemoveClientRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhRepository<Client>())
                    {
                        foreach (var id in req.Ids)
                        {
                            var entity = repo.GetById(id);
                            if (entity != null)
                            {
                                repo.Delete(entity);
                            }
                        }
                    }
                    return response;
                }
         );
        }

        public BaseQueryResponse<Client> QueryClient(QueryClientRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () =>
                {
                },

                req =>
                {
                    var response = new BaseQueryResponse<Client>();
                    using (var repo = new NhRepository<Client>())
                    {
                        var query = repo.Query();

                        response.Total = query.Count();
                        response.QueryList = query.ToList();
                    }
                    return response;
                }
             );
        }


        public BaseResponse CreateProject(CreateProjectRequest request)
        {
            var now = DateTime.Now;
            return ServiceProcessor.ProcessRequest(request,
                //inbound.do validate or do something here
                () => { },

                req =>
                {
                    var response = new BaseResponse();
                    using (var repo = new NhGlobalRepository())
                    {

                        var entity = repo.Query<Project>(x => x.Name == req.Name).FirstOrDefault();
                        if (entity != null)
                        {
                            throw new EeException(ErrorCodes.Existed, "Object is existed.");
                        }
                        var involvedClients = new List<ProjectClient>();
                        var clients = new List<Client>();
                        if (req.Clients.Any())
                        {
                            foreach (var client in req.Clients)
                            {
                                if (client.Id > 0)
                                {
                                    var c = repo.GetById<Client>(client.Id);
                                    if (c != null)
                                    {
                                        clients.Add(c);
                                    }
                                }
                                else
                                {
                                    var properties = new List<ClientPropertyItem>();
                                    if (client.Properties != null && client.Properties.Any())
                                    {
                                        int orderNo = 0;
                                        foreach (var property in client.Properties)
                                        {
                                            var categorty = repo.GetById<PropertyItemCategory>(property.Key);
                                            properties.Add(new ClientPropertyItem()
                                            {
                                                Id = 0,
                                                Category = categorty,
                                                Value = property.Value,
                                                CreateTime = now,
                                                OrderNo = orderNo++,
                                            });
                                        }

                                    }
                                    clients.Add(new Client()
                                    {
                                        Id = 0,
                                        Abbreviation = client.Abbreviation,
                                        IsNP = client.IsNP,
                                        Name = client.Name,
                                        Properties = properties,
                                        CreateTime = now,
                                    });
                                }
                            }
                        }
                        var owner = repo.GetById<SysUser>(req.OwnerId);
                        entity = new Project()
                        {
                            Name = req.Name,
                            Code = req.Code,
                            Level = req.Level,
                            InvolvedClients = involvedClients,
                            Owner = owner,
                            CreateTime = DateTime.Now,
                        };
                        repo.Create(entity);
                    }
                    return response;
                }
            );

        }

        public BaseQueryResponse<PropertyItemCategory> GetPropertyCategory(GetPropertyCategoryRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
               //inbound.do validate or do something here
               () => { },

               req =>
               {
                   var response = new BaseQueryResponse<PropertyItemCategory>();
                   using (var repo = new NhRepository<PropertyItemCategory>())
                   {
                       var query = repo.Query().Where(x => x.Parent == null);

                       response.Total = query.Count();
                       response.QueryList = query.ToList();
                   }
                   return response;
               }
            );
        }

        public BaseQueryResponse<PropertyItemCategory> GetPropertyItemCategory(GetPropertyItemCategoryRequest request)
        {
            return ServiceProcessor.ProcessRequest(request,
             //inbound.do validate or do something here
             () => { },

             req =>
             {
                 var response = new BaseQueryResponse<PropertyItemCategory>();
                 using (var repo = new NhRepository<PropertyItemCategory>())
                 {
                     var query = repo.Query().Where(x => x.Parent!=null&&x.Parent.Code==req.Code);

                     response.Total = query.Count();
                     response.QueryList = query.ToList();
                 }
                 return response;
             }
          );
        }
    }
}
