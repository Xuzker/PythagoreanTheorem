namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            Assert.That(5-0+1, Is.EqualTo(6));
        }

        [Test]
        public void Test3()
        {
            Assert.That(2 - 2, Is.EqualTo(0));
        }
    }
}