
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ee.ls.Service;
using ee.ls.Service.Contact.Args;

namespace ee.ls.Repository.Test
{
    [TestClass()]
    public class ServiceTests
    {
        CtsService server;
        [TestInitialize()]
        public void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
            server = new CtsService();
        }

        [TestMethod()]
        public void QueryAreaTest()
        {
            var request = new GetAreasRequest()
            {

            };
            var response = server.GetAreas(request);

        }

        [TestMethod()]
        public void AddCourtTest()
        {
            var request = new AddCourtRequest()
            {
                Name = "广州市番禺区人民法院",
                Province = "广东省",
                City = "广州市",
                County = "番禺区",
                Address = "沙头街桥兴大道731-733号",
                Rank = "基层法院",

            };
            var response = server.AddCourt(request);



            var request2 = new AddCourtRequest()
            {
                Name = "广州市天河区人民法院",
                Province = "广东省",
                City = "广州市",
                County = "番禺区",
                Address = "东圃明镜路1号",
                Rank = "基层法院",

            };
            var response2 = server.AddCourt(request2);

        }

        [TestMethod()]
        public void AddJudgeTest()
        {
            var request = new AddJudgeRequest()
            {
                Name = "小明",
                Gender = 1,
                PhoneNo = "13610142196",
                InCourtId = 1,
            };
            var response = server.AddJudge(request);

        }

        [TestMethod()]
        public void AddClientTest()
        {
            var request = new AddJudgeRequest()
            {
                Name = "小明",
                Gender = 1,
                PhoneNo = "13610142196",
                InCourtId = 1,
            };
            var response = server.AddJudge(request);

        }



        [TestMethod()]
        public void GetPropertyCategoryTest()
        {
            var request = new GetPropertyCategoryRequest()
            {
            };
            var response = server.GetPropertyCategory(request);

        }
        [TestMethod()]
        public void GetPropertyItemCategoryTest()
        {
            var request = new GetPropertyItemCategoryRequest()
            {
                Code = "Phone",
            };
            var response = server.GetPropertyItemCategory(request);

        }
    }
}