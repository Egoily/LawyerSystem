using ee.ls.Models.Entities;
using ee.ls.Service.Contact;
using ee.ls.Service.Contact.Args;
using ee.Framework;
using System.Collections.Generic;

namespace ee.ls.Service.ContactInterfaces
{
    public interface ICtsService
    {
        BaseQueryResponse<Area> GetAreas(GetAreasRequest request);
        BaseQueryResponse<PropertyItemCategory> GetPropertyCategory(GetPropertyCategoryRequest request);
        BaseQueryResponse<PropertyItemCategory> GetPropertyItemCategory(GetPropertyItemCategoryRequest request);
        BaseResponse AddCourt(AddCourtRequest request);
        BaseResponse UpdateCourt(UpdateCourtRequest request);
        BaseResponse RemoveCourt(RemoveCourtRequest request);
        BaseQueryResponse<Court> QueryCourt(QueryCourtRequest request);

        BaseResponse AddJudge(AddJudgeRequest request);
        BaseResponse UpdateJudge(UpdateJudgeRequest request);
        BaseResponse RemoveJudge(RemoveJudgeRequest request);
        BaseQueryResponse<Judge> QueryJudge(QueryJudgeRequest request);

        BaseResponse AddClient(AddClientRequest request);
        BaseResponse UpdateClient(UpdateClientRequest request);
        BaseResponse RemoveClient(RemoveClientRequest request);
        BaseQueryResponse<Client> QueryClient(QueryClientRequest request);

    }
}
