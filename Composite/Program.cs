namespace Composite
{
  internal class Program
  {
    static void Main()
    {
      LightElementNode container = new LightElementNode("div", "container");

      LightElementNode title = new LightElementNode("h1", "title");
      title.AddChild(new LightTextNode("Hello, Template Method Pattern!"));

      container.AddChild(title);

      // Викликаємо шаблонний метод
      container.Render();
    }
  }
}
