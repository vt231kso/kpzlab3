namespace Proxy
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string filePath = "E:\\Політех\\kpz\\lab3\\Adapter\\Proxy\\test.txt"; 

      
      ITextReader smartTextReader = new SmartTextReader();

      
      ITextReader checker = new SmartTextChecker(smartTextReader);
      checker.ReadFile(filePath);

      
      ITextReader locker = new SmartTextReaderLocker(smartTextReader, @"^.*\.txt$"); 
      locker.ReadFile(filePath);

      
      locker.ReadFile("E:\\Політех\\kpz\\lab3\\Adapter\\Proxy\\forbidden_file.csv"); 
    }
  }
}
