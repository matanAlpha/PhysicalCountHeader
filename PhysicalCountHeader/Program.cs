using System;
using System.IO;

namespace PhysicalCountHeader
{
    class Program
    {


        static void Main(string[] args)
        {
            string headerLine = "CONO,WHLO,STNB,STRN,STQI,STDI,STTM,STBT,STAG";

            DateTime theNow = DateTime.Now;
            writeToFile(headerLine, theNow);

        }

        private static void writeToFile(string headerLine, DateTime theNow)
        {
            string[] outLines = new string[2];
            outLines[0] = headerLine;

            string reportedDate = theNow.ToString("yyyyMMdd");
            string reportedTime = theNow.ToString("HHmmss");

            string lineToWrite = "1,100,1200917,101,0," + reportedDate + "," + reportedTime + ",1,2";
            outLines[1] = lineToWrite;
            string deleteMtsFileName = "PhysicalCount.csv";
            File.WriteAllLines(deleteMtsFileName, outLines);
        }
    }
}