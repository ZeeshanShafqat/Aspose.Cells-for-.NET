Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles
    Public Class RenderOnePdfPagePerExcelWorksheet
        Public Shared Sub Main()
            'ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Initialize a new Workbook
            'Open an Excel file
            Dim workbook As New Workbook(dataDir & "input.xlsx")

            'Implement one page per worksheet option
            Dim pdfSaveOptions As New PdfSaveOptions()
            pdfSaveOptions.OnePagePerSheet = True

            'Save the PDF file
            workbook.Save(dataDir & "output.pdf", pdfSaveOptions)
            'ExEnd:1

        End Sub
    End Class
End Namespace