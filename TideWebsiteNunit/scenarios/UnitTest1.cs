using NUnit.Framework;
using TideWebsiteNunit.pom;

namespace TideWebsiteNunit.scenarios
{
    [TestFixture]
    public class Tests:utilities.BaseClass1
    {   
        [Test]
        public void registration()
        {
            Signup s1 = new Signup();
            test = extent.CreateTest("registration").Info("teststarted");
            s1.openurl();
            s1.register();

        }
        [Test]
        
       
        public void login()
        {
            
            test = extent.CreateTest("login").Info("teststarted");
            Userlogin l1 = new Userlogin();
            l1.openurl();
            l1.log();
            
        }
    }
}