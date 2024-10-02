DirectoryInfo directory = new DirectoryInfo(@"C:\temp");

int fileCount;

fileCount = directory.GetFiles().Count();
int directoryCount = directory.GetDirectories().Count();  
// Fonction récursive
static List<int> countAllElements(DirectoryInfo directory)
{
    int fileCount = 0;
    int directoriesCount = 0;
    List<int> allElements = new List<int>();

    Array dirList = directory.GetDirectories();

    fileCount += directory.GetFiles().Count();
    directoriesCount += directory.GetDirectories().Count();

    foreach (DirectoryInfo item in dirList)
    {
        fileCount += countAllElements(item)[0];
        directoriesCount += countAllElements(item)[1];

    }
    allElements.Add(fileCount);
    allElements.Add(directoriesCount);
    return allElements;
}

List<int> fileAndDirectoriesCount = countAllElements(directory);

Console.WriteLine("Fichiers :" + fileAndDirectoriesCount[0]+ "\n Dossiers :" + fileAndDirectoriesCount[1]);
Console.ReadLine();