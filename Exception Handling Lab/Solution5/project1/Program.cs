namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Exception example

            int x = 0, y = 0, z = 0;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = x / y;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("can't be null - " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("wrong format- " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("too large input - " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("can't divide by zero - " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("run time error - " + ex.Message);
            }
            finally
            {
                Console.WriteLine("finally called");
            }
            Console.WriteLine("Program continue");
            Console.WriteLine("z = " + z);

            /****************************************************************************/

            // 2- MyList class Example

            MyList<int> list = new MyList<int>(3);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            try
            {
                Console.WriteLine(list[3]);
                list[3] = 18;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Called");
            }

            /****************************************************************************/

            // 4- Add in file 

            List<string> list2 = new List<string>();
            string path = "C:\\Users\\ms221\\Mohamed Shehata\\ITI Mansoura\\C#\\C# Advanced\\Labs Solution\\Solution5\\project1\\newFile.txt";
            list2.Add("Hello");
            list2.Add("Good Morning");
            list2.Add("How are you?");


            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                foreach (string item in list2)
                {
                    file.WriteLine(item);
                }
            }
        }
    }
}

/*
عايز مثال عملي Console App يضم الحاجات دي:

try–catch → تجرب تعمل عملية ممكن يحصل فيها خطأ (Exception) وتعالجه.

ArrayList → تخزن فيها شوية بيانات (مثلاً أسماء أو أرقام).

Implement Dispose → تعمل كلاس خاص بيك يطبق IDisposable علشان تنظف الموارد.

Add in file (TextWriter) → تكتب البيانات اللي في ArrayList في ملف نصي باستخدام TextWriter.
 */