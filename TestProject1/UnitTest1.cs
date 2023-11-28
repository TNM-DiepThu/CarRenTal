
using CarRenTal.View.ViewLogin;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        public LoginForm form;
        [SetUp]
        public void Setup()
        {
            form = new LoginForm();
        }
        [TearDown]
        public void Dispose()
        {
            form.Dispose();
        }


        [Test]
        public void Test1()
        {
            form.tx_user.Text = "1";
            form.tx_pass.Text = "1";
            form.bt_login_Click(null, null);
            
            Assert.That(form.checkLogin,Is.False);
        }

        [Test]
        public void Test2()
        {
            form.tx_user.Text = "phucnk";
            form.tx_pass.Text = "1";
            form.bt_login_Click(null, null);

            Assert.That(form.checkLogin, Is.True);
        }
    }
}