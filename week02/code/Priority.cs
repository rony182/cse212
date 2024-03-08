
public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario:  Create a queue with the following items and priorities: First (1), Second (2)
        var queue = new PriorityQueue();
        queue.Enqueue("First", 1);
        queue.Enqueue("Second", 2);

        var result = queue.ToString();

        Console.WriteLine("Test 1");
        Console.WriteLine(result);
        // Expected Result: 
        Console.WriteLine("[First (Pri:1), Second (Pri:2)]");

        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Should dequeue the highest priority item

        var queue2 = new PriorityQueue();
        queue2.Enqueue("Low", 1); // Lower priority
        queue2.Enqueue("Mid", 2); // Medium priority
        queue2.Enqueue("High", 3); // Highest priority

        // Act
        var dequeuedItem = queue2.Dequeue();

        Console.WriteLine("Test 2");
        Console.WriteLine(dequeuedItem);

        // Expected Result: 
        Console.WriteLine("High");

        // Defect(s) Found: was not dequeuing the highest priority item

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Should dequeue the highest priority item

        var queue3 = new PriorityQueue();
        queue3.Enqueue("Low", 1); // Lower priority
        queue3.Enqueue("Mid", 2); // Medium priority
        queue3.Enqueue("High1", 3); // Highest priority
        queue3.Enqueue("High", 3);
        // Act
        var dequeuedItemrepeated = queue3.Dequeue();

        Console.WriteLine("Test 3");
        Console.WriteLine(dequeuedItemrepeated);

        // Expected Result: 
        Console.WriteLine("High1");

        // Defect(s) Found: was not dequeuing the highest priority item

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Should return an error message when the queue is empty

        var queue4 = new PriorityQueue();
        var dequeuedItemEmpty = queue4.Dequeue();

        Console.WriteLine("Test 4");
        Console.WriteLine(dequeuedItemEmpty);

        // Expected Result:
        Console.WriteLine("The queue is empty.");

        // Defect(s) Found: none
    }
}