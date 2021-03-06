using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Articles
{
    public class SetBackgroundPicture
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Instantiate a new Workbook.
            Workbook workbook = new Workbook();

            //Get the first worksheet.
            Worksheet sheet = workbook.Worksheets[0];

            //Define a string variable to store the image path.
            string ImageUrl = dataDir+ "aspose-logo.jpg";

            //Get the picture into the streams.
            FileStream fs = File.OpenRead(ImageUrl);

            //Define a byte array.
            byte[] imageData = new Byte[fs.Length];

            //Obtain the picture into the array of bytes from streams.
            fs.Read(imageData, 0, imageData.Length);

            //Close the stream.
            fs.Close();

            //Set the background image for the sheet.
            sheet.SetBackground(imageData);

            //Save the Excel file
            workbook.Save(dataDir+ "BackImageSheet.out.xlsx");

            //Save the HTML file
            workbook.Save(dataDir+ "BackImageSheet1.out.html", SaveFormat.Html);
 
        }
    }
}