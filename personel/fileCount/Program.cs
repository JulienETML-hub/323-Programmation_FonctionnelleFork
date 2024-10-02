using System.Linq;

DirectoryInfo directory = new DirectoryInfo(@"C:\temp");

int fileCount;

fileCount = directory.GetFiles().Count();
int directoryCount = directory.GetDirectories().Count();  
// Fonction récursive
static List<int> countAllElements(DirectoryInfo directory)
{
    int fileCount = 0;
    int directoriesCount = 0;

    fileCount += directory.GetFiles().Count();
    directoriesCount += directory.GetDirectories().Count();


    //Tuple aa = dirList.SelectMany (e =>Tuple(filea: e.GetFiles().Count(), directorya: e.GetDirectories().Count())).ToList();
    List<int> allElements = new List<int>();

    List<DirectoryInfo> dirList = directory.GetDirectories().ToList();

    // allElements[0] += dirList.Aggregate(e => countAllElements(e)[0]);
    dirList.ForEach(item =>
    {
        fileCount += countAllElements(item)[0];
        directoriesCount += countAllElements(item)[1];

    }
    );
    allElements.Add(fileCount);
    allElements.Add(directoriesCount);
    return allElements;
}

List<int> fileAndDirectoriesCount = countAllElements(directory);

Console.WriteLine("Fichiers :" + fileAndDirectoriesCount[0]+ " Dossiers :" + fileAndDirectoriesCount[1]);
Console.ReadLine();