using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Files.Handling
{
    public class OpeningFilesThroughPath
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            // Opening through Path
            //Creating a Workbook object and opening an Excel file using its file path
            Workbook workbook1 = new Workbook(dataDir + "Book1.xls");
            Console.WriteLine("Workbook opened using path successfully!");
            //ExEnd:1
            
        }
    }
}
            
