﻿using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
    
class Program { 
  
    static void Main(string[] args) 
    { 
        // Prints the block devices of the process and the pipes connecting them 
        Console.WriteLine("Standard Input Stream: {0}",Console.In.ReadToEnd()); 
    }  
} 
    