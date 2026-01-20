using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
   // Scenario: Add three items with different priorities.
   // Expected Result: Items should be added to the end of the queue
   //                  following the order in which they were enqueued.  
   //                  The item with the highest priority should be removed first.
   // milk should be first
   // cake should be second
   // beans should be last
   //
   // Defect(s) Found: The loop did not iterate through the entire list and
   //                  the item was not removed in the correct sequence.
                       // The item with the highest priority  was not being removed.

    public void TestPriorityQueue_1()
    {



          var priorityQueue = new PriorityQueue();
    

          priorityQueue.Enqueue("milk", 7);
          priorityQueue.Enqueue("beans", 1);
          priorityQueue.Enqueue("cake", 3);

          

          var first = priorityQueue.Dequeue();
          var second = priorityQueue.Dequeue();
          var third = priorityQueue.Dequeue();

          Assert.AreEqual("milk", first);  
          Assert.AreEqual("cake", second);
          Assert.AreEqual("beans", third); 
         


        

    }





    [TestMethod]
    // Scenario: Add 3 items, two of them with the same priority
    // Expected Result: Following the priority rule, the higher number has higher priority,
    //                  and items with the same priority are ordered according to their insertion order;
    //                  the one closest to the front of the queue should be removed first.
    // Defect(s) Found: The most recently added item was being removed first instead of the one
    //                  closest to the front of the queue (the oldest item).
    public void TestPriorityQueue_2()
    {
          var priorityQueue = new PriorityQueue();
    

          priorityQueue.Enqueue("milk", 0);
          priorityQueue.Enqueue("cake", 7);
          priorityQueue.Enqueue("beans", 0);

          

          var first = priorityQueue.Dequeue();
          var second = priorityQueue.Dequeue();
          var third = priorityQueue.Dequeue();


          // Expected output sequence:
          Assert.AreEqual("cake", first);  
          Assert.AreEqual("milk", second);
          Assert.AreEqual("beans", third); ;
    }







    [TestMethod]
    // Scenario: Attempt to remove an item from an empty queue
    // Expected Result: An InvalidOperationException should be thrown
    //                  with the message "A fila está vazia"
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue_ThrowsException()
    {
       // Arrange
       var priorityQueue = new PriorityQueue();


       // Act & Assert
       try
       {
           priorityQueue.Dequeue();
           Assert.Fail("An exception was expected but none was thrown.");
       }
       catch (InvalidOperationException ex)
       {
           Assert.AreEqual("The queue is empty.", ex.Message);
       }
    }




    // Add more test cases as needed below.
}