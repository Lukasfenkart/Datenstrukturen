using LinkedList;
using NUnit.Framework;

namespace TestProject1
{
    public class TestSingleLinkedList
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetNode_MultipleElements_ReturnsElement()
        {
            // ToDo
            

        }

        [Test]
        public void TestDeleteNode_FromTheMiddle_ElementIsDeleted()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addlast(new Node(1));
            linkedList.addlast(new Node(2));
            linkedList.addlast(new Node(3));
            linkedList.addlast(new Node(4));
            linkedList.deletelast();


        }

        [Test]
        public void TestAddLast_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addlast(new Node(1));
            linkedList.addlast(new Node(2));
            linkedList.addlast(new Node(3));
            linkedList.addlast(new Node(4));
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 1);
            Assert.AreEqual(node.next.data, 2);
            Assert.AreEqual(node.next.next.data, 3);
            Assert.AreEqual(node.next.next.next.data, 4);
            Assert.AreEqual(4, linkedList.size());

        }

        [Test]
        public void TestAddFirst_MultipleElements_ElementsAreAdded()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.addfirst(new Node(1));
            linkedList.addfirst(new Node(2));
            linkedList.addfirst(new Node(3));
            linkedList.addfirst(new Node(4));
            var node = linkedList.GetFirst();
            Assert.AreEqual(node.data, 4);
            Assert.AreEqual(node.next.data, 3);
            Assert.AreEqual(node.next.next.data, 2);
            Assert.AreEqual(node.next.next.next.data, 1);
            Assert.AreEqual(4, linkedList.size());

        }
    }
}