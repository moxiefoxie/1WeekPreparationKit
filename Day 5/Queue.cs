using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfQueries = Convert.ToInt32(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        for (int query = 0; query < numberOfQueries; query++) 
        {
            var entry = Console.ReadLine().Split(' ');
            if(entry[0]=="1")
            {
                queue.Enqueue(entry[1]);
            }
            else if(entry[0]=="2")
            {
                queue.Dequeue();
            }
            else if(entry[0]=="3")
            {
                Console.WriteLine(queue.Peek());
            }
        }
    }
}
