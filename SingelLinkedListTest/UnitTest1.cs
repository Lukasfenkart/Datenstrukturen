using LinkedList;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addlast(new Node(1));
            linkedList.addlast(new Node(2));
            linkedList.addlast(new Node(3));
            linkedList.addlast(new Node(4));
            Assert.AreEqual(4, linkedList.size());
        }
    }
}