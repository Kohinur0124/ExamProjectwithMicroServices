using AuthApiExam.Model;
using AuthApiExam.Services;

namespace TestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("1", "1", "1", true)]
        public void TestFirst(string p, string ph, string r, bool t)
        {
            var dto = new DtoLogin()
            {
                Password = p,
                PhoneNumber = ph,
                Role = r,
            };
            var res = FunctionforTests.isFoundUser(dto);
            Assert.Equal(t, res);

        }
    }
}