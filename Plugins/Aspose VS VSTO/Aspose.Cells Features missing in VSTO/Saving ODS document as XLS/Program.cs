﻿using Aspose.Cells;
/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Cells for .NET API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. If you do not wish to use NuGet, you can manually download Aspose.Cells for .NET API from http://www.aspose.com/downloads, install it and then add its reference to this project. For any issues, questions or suggestions please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.Plugins.AsposeVSVSTO
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenOfficeSpreadsheet();
            SaveAsOpenOfficeSpreadsheet();
            
        }
        static void OpenOfficeSpreadsheet()
        {
            string FilePath = @"..\..\..\Sample Files\";
            string srcFileName = FilePath + "Sample File.ods";
            string DestFileName = FilePath + "Output.xlsx";
            
            Workbook workbook = new Workbook(srcFileName);
            workbook.Save(DestFileName,SaveFormat.Xlsx);
        }
        static void SaveAsOpenOfficeSpreadsheet()
        {
            string FilePath = @"..\..\..\Sample Files\";
            string srcFileName = FilePath + "Sample File.xlsx";
            string DestFileName = FilePath + "Output.ods";
            
            Workbook workbook = new Workbook(srcFileName);
            workbook.Save(DestFileName, SaveFormat.ODS);
        }
    }
}
