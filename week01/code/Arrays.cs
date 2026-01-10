using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public static class Arrays
{


    public static void Run() {
        double[] list = MultiplesOf(7,5);///example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}");
        var numbers = new List<int>{1,2,3,4,5,6,7,8,9};
        RotateListRight(numbers, 3);
        
        
    }


    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)  // In the function, there will be two inputs: number and length
    {   var Multiples = new List <double>();     // Before the loop, you need a list to store the result. 

        for (var i=1; i < length + 1; ++i) // Create a loop where the index number starts at 1 and goes through the list
                                           //based on the length, which is the requested quantity plus 1 

        {
             var result = number*i; //With the result of each index, we multiply it by Number,
                                    // which is the initial number. 

             Multiples.Add(result); // the list is add the results.
             }



        return Multiples.ToArray(); // the list is returned with all the multiples.
    }





    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> numbers, int amount)
    { 

        //Step 1


        int totaldata = numbers.Count; // we need to count how many items are in the numbers List to find out the position of the index amount
        int pas1amount = totaldata-amount; // with the result of the total count minus the amount, we know the initial value to extract the subsequent numbers
        List<int> results = new List<int>(); // a list to store the future results of the numbers that will be positioned at the beginning
        List<int> remainder = numbers.GetRange(0,pas1amount); // a list to store the remainder that will be added after the rotation
        
        for ( int i = pas1amount; i < totaldata; ++i) // we start a list counting from the result pas1amount with the count limited to the total of the numbers List,  
                                         // Example: If pas1amount is 6, then the starting index will be 6... up to the total count, picking the subsequent numbers from -> 6...(last number of the list). = 6, 7, 8, 9
        {   
            results.Add(numbers[i]); // we add each return to form the first part of the list that is rotating based on the loop index
        };

        //Step 2

        // now we combine the two lists in the order remainder + result, that is always in a clockwise direction
        List<int> final = results.Concat(remainder).ToList();
        
        // this makes the numbers list empty after the entire process so it can be updated with the rotation result
        numbers.Clear();

        // now we add the elements from the final list into the numbers list
        numbers.AddRange(final);

        

        //public static


        Console.WriteLine("\n======================\nArray  Solution\n======================");
        Console.WriteLine("<List[]>{" + string.Join(", ", final) + "}"); 
        
        
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}