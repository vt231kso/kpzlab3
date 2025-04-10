namespace FileLoggerAdapter
{
  class Program
  {
    static void Main()
    {
      Logger consoleLogger = new Logger();
      consoleLogger.Log("Це повідомлення в консоль.");
      consoleLogger.Warn("Це попередження в консоль!");
      consoleLogger.Error("Це помилка в консоль!");

      Logger fileLogger = new FileLogger("log.txt");
      fileLogger.Log("Це повідомлення в файл.");
      fileLogger.Warn("Це попередження в файл!");
      fileLogger.Error("Це помилка в файл!");

      Console.WriteLine("Логи записані у log.txt");
    }
  }

}
