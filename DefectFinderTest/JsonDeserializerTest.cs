using DefectFinder.Core;
using DefectFinderTest.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DefectFinderTest
{
    [TestClass]
    public class JsonDeserializerTest
    {
        [TestMethod]
        public void Deserialization_of_projects_proper_response_returns_3_rows()
        {
            //Arrange
            var response = TfsWebApi.GetResponse("projects.json");

            //Act
            var projectLst = JsonDeserializer.DeserializeProjects(response);

            //Assert
            Assert.AreEqual(3, projectLst.Count);
        }

        [TestMethod]
        public void Deserialization_of_projects_empty_response_returns_not_initialize_list()
        {
            //Arrange
            var response = TfsWebApi.GetResponse("emptyResponse.json");

            //Act
            var projectLst = JsonDeserializer.DeserializeProjects(response);

            //Assert
            Assert.IsNull(projectLst);
        }
    }
}
