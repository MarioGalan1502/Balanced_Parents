using NUnit.Framework;

namespace parentheses_Balanced.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void checkBalance_expression_IsNull()
        {
            Program check = new Program();

            Assert.That(()=> check.missing(null),Throws.ArgumentNullException);
            
        }

        [Test]
        public void checkBalance_no_missingCharanter()
        {
            Program check = new Program();
            Assert.AreEqual(' ',check.missing("(())"));
            
        }


        [Test]
        public void checkBalance_missing_open()
        {
            Program check = new Program();
            Assert.AreEqual('(',check.missing("()(())(()))"));
        }

        [Test]
        public void checkBalance_missing_close()
        {
            Program check = new Program();
            Assert.AreEqual(')',check.missing("()(())((())"));
            
        }

        [Test]
        public void checkBalance_no_parentheses_Found()
        {
            Program check = new Program();
            Assert.AreEqual(' ',check.missing("1 + 2 + mario"));
            
        }
    }
}