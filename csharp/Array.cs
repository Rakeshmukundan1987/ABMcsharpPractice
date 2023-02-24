using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        string[] statements = {
            "Rakesh", 
            "Rownie", 
            "Israa"
            
        };
        fncFilter(statements);
    }
    public static void fncFilter(string[]statements){
        for (int i=0;i<=statements.Length-1;i++){
            if(statements[i].Contains("Rownie")){
                Console.WriteLine (statements[i]);
                
            }
        }
    }
}