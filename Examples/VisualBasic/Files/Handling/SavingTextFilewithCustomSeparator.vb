Imports System.IO

Imports Aspose.Cells
Imports System

Namespace Aspose.Cells.Examples.Files.Handling
    Public Class SavingTextFilewithCustomSeparator
        Public Shared Sub Main(ByVal args() As String)
            'ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim filePath As String = dataDir & "Book1.xlsx"

            'Create a Workbook object and opening the file from its path
            Dim wb As New Workbook(filePath)

            'Instantiate Text File's Save Options
            Dim options As New TxtSaveOptions()

            'Specify the separator
            options.Separator = Convert.ToChar(";")

            'Save the file with the options
            wb.Save(dataDir & "output.csv", options)

            'ExEnd:1


        End Sub
    End Class
End Namespace
