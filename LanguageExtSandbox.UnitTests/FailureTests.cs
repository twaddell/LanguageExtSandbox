using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace LanguageExtSandbox.UnitTests
{
    [TestClass]
    public class FailureTests
    {
        [TestMethod]
        public void ItShouldConvertToAndFromJson()
        {
            var data = new Failure("This is a test");

            var json = JsonConvert.SerializeObject(data);
            var actual = JsonConvert.DeserializeObject<Failure>(json);

            Assert.AreEqual(data, actual);
        }
    }
}
