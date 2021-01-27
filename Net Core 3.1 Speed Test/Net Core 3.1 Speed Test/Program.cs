using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Net_Core_3._1_Speed_Test
{
    
    
    public class Program
    {
        static void Main(string[] args) 
        {
            var summary = BenchmarkRunner.Run<StringStartsWith>();
        }


    }

    [RPlotExporter, RankColumn]
    public class StringStartsWith
    {
        public string alphabetWithNumbers = "abcdefghijklmnopqrstuvwxyzåäö1234567890";
        public bool startsWith;

        [Benchmark]
        public void StartsWithExecution() 
        {
            for (int i = 0; i < 1000000000; i++)
            {
                alphabetWithNumbers.StartsWith("abcdefghijklmnopqrstuvwxyzåäö1234567890");
            }
        }  
    }


}
