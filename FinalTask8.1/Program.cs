namespace FinalTask8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(args[0]))
            {
                string[] dirs = Directory.GetDirectories(args[0]);
                foreach (var dir in dirs)
                {
                    try
                    {
                        Directory.Delete(dir, true);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine($"каталог {dir} доступен только для чтения или используется");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"у вас отсутствует доступ к каталогу {dir}");
                    }

                }
                string[] files = Directory.GetFiles(args[0]);
                foreach(var file in files)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine($"файл {file} доступен только для чтения или используется");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"у вас отсутствует доступ к файлу {file}");
                    }
                }
            }
            else
            {
                Console.WriteLine("наименование каталога указано неверно");
            }
        }
    }
}