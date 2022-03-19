Imports System
Imports System.IO
Imports Microsoft.VisualBasic.FileIO


Module Program
    Dim OriginalPath As String
    Dim NewPath As String
    Dim ThisDate As Date = Today
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
    Dim DayFormat As String = ThisDate.ToString("yyyy'-'MM'-'dd")
    Dim NewFileName As String
    Dim RenamedPath As String
    Dim PathPlusName As String




    Sub Main(args As String())
        Console.WriteLine("WELCOME TO THE BACKUP FILE FINALIZER THAT IS GREAT AND UGLY AND YUSEFUL")
        Console.WriteLine("B.U.F.F.G.U.Y.")

        System.Console.WriteLine("Entire File Path Of Files You Need To Back Up: ")
        OriginalPath = Console.ReadLine()
        System.Console.WriteLine("Enter File Path To Copy Files To: ")
        NewPath = System.Console.ReadLine()

        Dim files As New DirectoryInfo(OriginalPath)
        Dim names As FileInfo() = files.GetFiles()
        Dim file As FileInfo



        For Each file In names
            PathPlusName = OriginalPath + "\" + file.Name
            NewFileName = DayFormat + "_" + dayName + "_" + file.Name
            RenamedPath = NewPath + "\" + DayFormat + "\" + NewFileName
            Console.WriteLine("Renaming " + file.Name + " To " + dayName + " " + DayFormat + " " + file.Name)
            Console.WriteLine("Movinf File From " + OriginalPath + " To " + RenamedPath)
            Console.WriteLine(NewFileName)
            Console.WriteLine(RenamedPath)
            FileSystem.CopyFile(PathPlusName, RenamedPath)
            Console.WriteLine("Copy Successful")

        Next file


    End Sub

End Module
