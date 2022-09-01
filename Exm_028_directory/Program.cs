// Работа с директориями
string path = "D:/it/C#/lecture/first/Exm_001_sum";
DirectoryInfo di = new DirectoryInfo(path); // указываем путь к папке сво-ва которой хотим посмотреть
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}