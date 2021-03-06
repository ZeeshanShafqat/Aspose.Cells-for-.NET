using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Files.Handling
{
    public class OpeningFilesThroughStream
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            // Opening through Stream
            //Create a Stream object
            FileStream fstream = new FileStream(dataDir + "Book2.xls", FileMode.Open);

            //Creating a Workbook object, open the file from a Stream object
            //that contains the content of file and it should support seeking
            Workbook workbook2 = new Workbook(fstream);
            Console.WriteLine("Workbook opened using stream successfully!");
            fstream.Close();
            //ExEnd:1
            }
          }
      }    
