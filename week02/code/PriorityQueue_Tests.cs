using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try to remove the item with the highest priority from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: Dequeue() was not removing any item.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priority: health (2), family (5), study (1),
    // gym (5), trip (4) and run until the queue is empty
    // Expected Result: family, gym, trip, health, study
    // Defect(s) Found: Priority was not comparing correctly and loop did not run over all the items.
    public void TestPriorityQueue_AlsoSamePriority()
    {
        var health = new PriorityItem("health", 2);
        var family = new PriorityItem("family", 5);
        var study = new PriorityItem("study", 1);
        var gym = new PriorityItem("gym", 5);
        var trip = new PriorityItem("trip", 4);

        PriorityItem[] expectedResult = [family, gym, trip, health, study];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("health", 2);
        priorityQueue.Enqueue("family", 5);
        priorityQueue.Enqueue("study", 1);
        priorityQueue.Enqueue("gym", 5);
        priorityQueue.Enqueue("trip", 4);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var itemValue = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, itemValue);
            i++;
        }
    }

    // Add more test cases as needed below.
}