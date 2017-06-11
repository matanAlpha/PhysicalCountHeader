using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhysicalCountHeader
{
    class Program
    {


        static void Main(string[] args)
        {
            string headerLine = "CONO,WHLO,STNB,STRN,STQI,STDI,STTM,STBT,STAG";

            DateTime theNow = DateTime.Now;
            readWriteDelteFile(headerLine, theNow);

        }

        private static void readWriteDelteFile(string headerLine, DateTime theNow)
        {
            string[] outLines = new string[2];
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");

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