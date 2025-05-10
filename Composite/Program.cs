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

      // Команда додати текст до h1
      ICommand addTitleTextCommand = new AddChildCommand(title, titleText);
      addTitleTextCommand.Execute();

      // Команда додати h1 до контейнера
      ICommand addTitleCommand = new AddChildCommand(container, title);
      addTitleCommand.Execute();

      // Вивід результату
      Console.WriteLine(container.OuterHTML);
    }
  }
}
