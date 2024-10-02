DirectoryInfo directory = new DirectoryInfo(@"C:\temp");

int fileCount;

fileCount = directory.GetFiles().Count();

Console.WriteLine(fileCount);
Console.ReadLine();