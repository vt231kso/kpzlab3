using Composite.Composite;

namespace Composite
{
  internal class Program
  {
    static void Main()
    {
      LightElementNode container = new LightElementNode("div", "container");
      LightElementNode title = new LightElementNode("h1", "title");
      LightTextNode titleText = new LightTextNode("Hello, Command Pattern!");
      CommandInvoker invoker = new CommandInvoker();

      // Команда додати текст до h1
      ICommand addTitleTextCommand = new AddChildCommand(title, titleText);

      // Команда додати h1 до контейнера
      ICommand addTitleCommand = new AddChildCommand(container, title);

      // Додаємо команди в invoker
      invoker.AddCommand(addTitleTextCommand);
      invoker.AddCommand(addTitleCommand);

      // Виконати всі команди
      invoker.ExecuteAll();

      // Вивід результату
      Console.WriteLine(container.OuterHTML);
    }
  }
}
