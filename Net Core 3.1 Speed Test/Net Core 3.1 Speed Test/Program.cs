using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace Net_Core_3._1_Speed_Test
{
    
    
    public class Program
    {
        static void Main(string[] args) 
        {
            var summary = BenchmarkRunner.Run<ChainStringsWithStringBuilder>();
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

    [RPlotExporter, RankColumn]
    public class ChainStringsWithStringBuilder
    {
        int totalItems = 10000000;

        [Benchmark]
        public string ChainStringsExecution()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < totalItems; i++)
            {
                stringBuilder.Append("How much time is this gonna take?" + i);
            }
            return stringBuilder.ToString();
        }
    }


}
