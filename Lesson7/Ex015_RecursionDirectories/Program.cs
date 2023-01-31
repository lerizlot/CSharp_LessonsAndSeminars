// Программа, которая выполняет обход директории (посмотреть все папки и файлы находящиеся внутри папки и так далее)

void CatalogInfo(string path, string indent = "") // indent - позволяет делать отступы
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем информацию о директории в которую зашли
    
    // получаем массив всех файлов в папке, пробегаем по ним
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводим информацию о текущем каталоге
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "/Users/lerizlot/Library/Mobile Documents/com~apple~CloudDocs/Developer/C# Lessons & Seminars/Lesson1";
CatalogInfo(path);
