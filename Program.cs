using System;

namespace ifStatement{

  class Program
 {
     static void Main(string[]args)
     {
    string inputStr=" ";
    Console.WriteLine("Basic while() Loop:");
while(inputStr!="exit"){
    inputStr=Console.ReadLine();
    Console.WriteLine("you entered {0}",inputStr);
}
        
  }
 }
}