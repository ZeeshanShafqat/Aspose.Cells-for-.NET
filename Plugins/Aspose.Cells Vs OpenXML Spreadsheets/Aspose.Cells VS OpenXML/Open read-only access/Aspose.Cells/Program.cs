﻿using Aspose.Cells;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Cells for .NET API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. If you do not wish to use NuGet, you can manually download Aspose.Cells for .NET API from http://www.aspose.com/downloads, install it and then add its reference to this project. For any issues, questions or suggestions please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Plugins.AsposeVSOpenXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"..\..\..\..\Sample Files\";
            string FileName = FilePath + "Open a spreadsheet document for read-only access.xlsx";
            OpenSpreadsheetDocumentReadonly(FileName);
        }
        public static void OpenSpreadsheetDocumentReadonly(string filepath)
        {
            // Open a SpreadsheetDocument based on a filepath.
            Workbook workbook = new Workbook(filepath);
        }
    }
}
