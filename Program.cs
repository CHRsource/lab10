#pragma warning disable
// задание 2

//string dir_name = @"..\..\..\basedir\dir0";
//DirectoryInfo dir = new(dir_name);
//Console.WriteLine("basedir/dir0/");
//if (dir.Exists)
//{
//    // a)
//    DirectoryInfo[] dirs = dir.GetDirectories();
//    Console.WriteLine("Общее количество файлов: " + dir.GetFiles().Length);
//    Console.WriteLine("Общее количество каталогов: " + dirs.Length);
//    // b)
//    Console.WriteLine("Имена каталогов из директории:");
//    foreach (DirectoryInfo d in dirs)
//        Console.WriteLine(d.Name);
//    // c)
//    Console.WriteLine("Количество файлов: " + dir.GetFiles().Length);
//    string[] txt_files = Directory.GetFiles(dir_name, "*.txt");
//    Console.WriteLine($"Кол-во текстовых файлов: {txt_files.Length}");
//    // d)
//    Console.WriteLine("Имена всех пустых директорий:");
//    PrintEmptyDirectories(@"..\..\..\basedir\");
//    // e)
//    FileInfo f = new(dir_name + @"\елки.txt");
//    Console.WriteLine("Полный абсолютный путь файла елки.txt: " + f.FullName);
//    // f)
//    Console.WriteLine("Имена всех вложенных файлов и директорий:");
//    PrintAllItems(@"..\..\..\basedir\");
//    // g)
//    Console.WriteLine($"Имя директории с максимальным количеством файлов: {GetDirectoryWithMaxFiles(@"..\..\..\basedir\")}");
//    // h)
//    string deepestItemPath = GetDeepestItemPath(@"..\..\..\basedir\");
//    FileInfo f2 = new(deepestItemPath);
//    Console.WriteLine($"Полное имя (абсолютный путь) файла или директории с самой глубокой вложенностью: {f2.FullName}");
//    // i) 
//    DriveInfo driveInfo = new DriveInfo("C:");
//    long freeSpace = driveInfo.AvailableFreeSpace;
//    Console.WriteLine($"Размер свободного дискового пространства на устройстве: {freeSpace} байт");
//    // j)
//    DriveInfo[] allDrives = DriveInfo.GetDrives();
//    Console.WriteLine($"Количество устройств хранения (дисков): {allDrives.Length}");
//    Console.WriteLine("Имена устройств хранения (дисков):");
//    foreach (var drive in allDrives)
//    {
//        Console.WriteLine(drive.Name);
//    }
//}
//static void PrintEmptyDirectories(string path)
//{
//    string[] dirNames = Directory.GetDirectories(path);
//    foreach (var dirName in dirNames)
//    {
//        if (Directory.GetFiles(dirName).Length == 0 && Directory.GetDirectories(dirName).Length == 0)
//        {
//            Console.WriteLine(dirName);
//        }
//        else
//        {
//            PrintEmptyDirectories(dirName);
//        }
//    }
//}
//static void PrintAllItems(string path)
//{
//    string[] fileNames = Directory.GetFiles(path);
//    string[] dirNames = Directory.GetDirectories(path);
//    foreach (var fileName in fileNames)
//    {
//        Console.WriteLine(fileName);
//    }
//    foreach (var dirName in dirNames)
//    {
//        Console.WriteLine(dirName);
//        PrintAllItems(dirName);
//    }
//}
//static string GetDirectoryWithMaxFiles(string path)
//{
//    string[] dirNames = Directory.GetDirectories(path);
//    int maxFilesCount = 0;
//    string dirWithMaxFiles = string.Empty;
//    foreach (var dirName in dirNames)
//    {
//        int filesCount = Directory.GetFiles(dirName).Length;
//        if (filesCount > maxFilesCount)
//        {
//            maxFilesCount = filesCount;
//            dirWithMaxFiles = dirName;
//        }
//    }
//    return dirWithMaxFiles;
//}
//static string GetDeepestItemPath(string path)
//{
//    string[] fileNames = Directory.GetFiles(path);
//    string[] dirNames = Directory.GetDirectories(path);
//    string deepestItemPath = string.Empty;
//    int deepestDepth = 0;
//    foreach (var fileName in fileNames)
//    {
//        FileInfo fileInfo = new(fileName);
//        if (fileInfo.DirectoryName.Split('\\').Length > deepestDepth)
//        {
//            deepestDepth = fileInfo.FullName.Split('\\').Length;
//            deepestItemPath = fileName;
//        }
//    }
//    foreach (var dirName in dirNames)
//    {
//        string itemPath = GetDeepestItemPath(dirName);
//        if (itemPath.Split('\\').Length > deepestDepth)
//        {
//            deepestDepth = itemPath.Split('\\').Length;
//            deepestItemPath = itemPath;
//        }
//    }
//    return deepestItemPath;
//}


// задание 3

//// a)
//string[] dirs = new string[] { @"..\..\..\basedir\Picture", @"..\..\..\basedir\Texts\History", @"..\..\..\basedir\Texts\Horror\First", };
//foreach (string d in dirs)
//    Directory.CreateDirectory(d);
//for (int i = 1; i < 6 + 1; i++)
//{
//    var myFile = File.Create(@$"..\..\..\basedir\Picture\{i}.txt");
//    myFile.Close();
//}

//// b)
//File.Copy(@"..\..\..\basedir\Picture\5.txt", @"..\..\..\basedir\Picture\5000.txt", true);
//File.Delete(@"..\..\..\basedir\Picture\5.txt");
//File.Move(@"..\..\..\basedir\Picture\5000.txt", @"..\..\..\basedir\Texts\History\5000.txt", true);

//// c)
//File.Delete(@"..\..\..\basedir\Picture\6.txt");
//Console.WriteLine("Какой из оставшихся в basedir/Picture/ файлов удалить? (1, 2, 3, 4)");
//int n = int.Parse(Console.ReadLine());
//File.Delete(@$"..\..\..\basedir\Picture\{n}.txt");
//Directory.Delete(@"..\..\..\basedir\Texts\Horror", true);
//Directory.Delete(@"..\..\..\basedir\Picture", true);


// задание 4

//// a)
//string path1 = @"..\..\..\basedir\data\dataset_1.txt";
//using (StreamReader r1 = new(path1))
//{
//    string[] nums = r1.ReadToEnd().Split();
//    double a = Double.Parse(nums[0]);
//    double b = Double.Parse(nums[1]);
//    Console.WriteLine($"a = {a}, b = {b}");
//    Console.WriteLine($"a + b = {a + b}");
//    Console.WriteLine($"a * b = {a * b}");
//    Console.WriteLine($"a + b^2 = {a + b * b}");
//}

//// b)
//string path2 = @"..\..\..\basedir\data\dataset_2.txt";
//using (StreamReader r2 = new(path2))
//{
//    int count_even = 0;
//    string? line;
//    while ((line = await r2.ReadLineAsync()) != null)
//    {
//        if (int.Parse(line) % 2 == 0)
//            count_even++;
//    }
//    Console.WriteLine("Количество четных чисел: " + count_even);
//}

//// c)
//string path3 = @"..\..\..\basedir\data\dataset_3.txt";  
//var file_res3 = File.Create(@"..\..\..\basedir\data\res_3.txt");
//file_res3.Close();
//using (StreamWriter res3 = new(@"..\..\..\basedir\data\res_3.txt"))
//{
//    using (StreamReader r3 = new(path3))
//    {
//        string[] nums3 = r3.ReadToEnd().Split();
//        for (int i = 0; i < nums3.Length; i++)
//        {
//            if (int.Parse(nums3[i]) < 9999)
//                res3.WriteLine(nums3[i]);
//        }
//    }

//    // d)
//    string path4 = @"..\..\..\basedir\data\dataset_4.txt";
//    using (StreamReader r4 = new(path4))
//    {
//        string[] nums4 = r4.ReadToEnd().Split();
//        int max = int.Parse(nums4[0]);
//        for (int i = 1; i < nums4.Length; i++)
//            if (int.Parse(nums4[i]) > max)
//                max = int.Parse(nums4[i]);
//        res3.WriteLine($"Максимальное число в dataset_4 = {max}");
//        Console.WriteLine($"Максимальное число в dataset_4 = {max}");
//    }
//}

//// e)
//string path5 = @"..\..\..\basedir\data\dataset_5.txt";
//using (StreamReader r5 = new(path5))
//{
//    string? line;
//    while ((line = await r5.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(line.ToUpper());
//    }
//}


// задание 5

var per = File.Create(@"..\..\..\basedir\data\persons.txt");
per.Close();
Person[] persons = new Person[] { new Person("Абзалов", 183, 85, new DateTime(2005, 2, 2)),
    new Person("Иванова", 170, 60, new DateTime(2003, 12, 11)),
    new Person("Воробьева", 155, 55, new DateTime(1990, 5, 25)) };
using (StreamWriter sw = new(@"..\..\..\basedir\data\persons.txt"))
{
    foreach (Person p in persons)
        PersonToFile(p, sw);
    for (int i = 0; i < 2; i++)
    {
        Person newp = new();
        newp.Input();
        PersonToFile(newp, sw);
    }
}

string[,] data = new string[5, 4];
using (StreamReader sr = new(@"..\..\..\basedir\data\persons.txt"))
{
    string? line;
    int i = 0, j = 0; 
    while ((line = sr.ReadLine()) != null)
    {
        data[i, j] = line;
        j++;
        if (j == 4) { i++; j = 0; }
    }
}
double mid_height = 0;
double mid_width = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Фамилия: " + data[i, 0]);
    DateTime db = Convert.ToDateTime(data[i, 3]);
    Console.WriteLine($"Возраст: {Age(db)}");
    mid_height += double.Parse(data[i, 1]);
    mid_width += double.Parse(data[i, 2]);
}
mid_height /= 5;
mid_width /= 5;
Console.WriteLine($"Средний рост = {mid_height:f1}");
Console.WriteLine($"Средний вес = {mid_width:f1}");
File.AppendAllText(@"..\..\..\basedir\data\persons.txt", $"Средний рост = {mid_height:f1}\n");
File.AppendAllText(@"..\..\..\basedir\data\persons.txt", $"Средний вес = {mid_width:f1}\n");

var overw = File.Create(@"..\..\..\basedir\data\overweight.txt");
overw.Close();
Console.WriteLine("Данные людей с избыточным весом:");
using (StreamWriter strw = new(@"..\..\..\basedir\data\overweight.txt"))
{
    for (int i = 0; i < 5; i++)
    {
        if (int.Parse(data[i, 2]) > int.Parse(data[i, 1]) - 100 + 10) {
            for (int j = 0; j < 4; j++)
                strw.WriteLine(data[i, j]);
            Console.WriteLine("Фамилия: " + data[i, 0]);
            Console.WriteLine("Рост(см): " + data[i, 1]);
            Console.WriteLine("Вес(кг): " + data[i, 2]);
            Console.WriteLine("Дата рождения: " + data[i, 3]);
        }
    }
}

static void PersonToFile(Person person, StreamWriter s)
{
    s.WriteLine(person.Surname);
    s.WriteLine(person.Height);
    s.WriteLine(person.Weight);
    s.WriteLine(person.Datebirth);
}
static int Age(DateTime db)
{
    DateTime now = DateTime.Now;
    int age = now.Year - db.Year;
    if (db > now.AddYears(-age)) age--;
    return age;
}

