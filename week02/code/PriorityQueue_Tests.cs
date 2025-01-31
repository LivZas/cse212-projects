using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Situation: Add one item to the queue and then remove it.
    // Expected Result: The item that was added should be the one that is removed.
    // Problems Found: None expected.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

 
    [TestMethod]
    // Situation: Add two items with the same priority and then remove them.
    // Expected Result: The items should be removed in the order they were added (FIFO).
    // Problems Found: None expected.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 1);
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result1);
        Assert.AreEqual("Item2", result2);
    }

   [TestMethod]
    // Situation: Add multiple items with different priorities and then remove them.
    // Expected Result: The item with the highest priority should be removed first.
    // Problems Found: None expected.
    
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 2);
        var result1 = priorityQueue.Dequeue(); // Should be Item2 (highest priority)
        var result2 = priorityQueue.Dequeue(); // Should be Item3 (next highest priority)
        var result3 = priorityQueue.Dequeue(); // Should be Item1 (lowest priority)
        Assert.AreEqual("Item2", result1);
        Assert.AreEqual("Item3", result2);
        Assert.AreEqual("Item1", result3);
    }

    [TestMethod]
    // Situation: Try to remove an item from an empty queue.
    // Expected Result: It should throw an error (InvalidOperationException).
    // Problems Found: None expected.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}

    // Add more test cases as needed below.


