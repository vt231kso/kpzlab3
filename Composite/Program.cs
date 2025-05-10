namespace Composite
{
  internal class Program
  {
    static void Main()
    {

      LightElementNode container = new LightElementNode("div", "container");
      LightElementNode title = new LightElementNode("h1", "title");
      LightTextNode titleText = new LightTextNode("Hello, State Pattern!");

      // Додаємо текст в активному стані
      title.AddChild(titleText);

      // Встановлюємо Disabled стан
      title.SetState(new DisabledState());

      // Спробуємо ще раз додати текст (повинно заблокувати)
      title.AddChild(new LightTextNode("Цей текст не додасться"));

      // Додаємо h1 до контейнера
      container.AddChild(title);

      Console.WriteLine(container.OuterHTML);
    }
  }
}
