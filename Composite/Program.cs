namespace Composite
{
  internal class Program
  {
    static void Main()
    {
      //LightElementNode container = new LightElementNode("div", "container");

      //LightElementNode title = new LightElementNode("h1", "title");
      //title.AddChild(new LightTextNode("Hello, LightHTML!"));

      //LightElementNode list = new LightElementNode("ul", "list");

      //LightElementNode firstItem = new LightElementNode("li");
      //firstItem.AddChild(new LightTextNode("First item"));

      //LightElementNode secondItem = new LightElementNode("li");
      //secondItem.AddChild(new LightTextNode("Second item"));

      //list.AddChild(firstItem);
      //list.AddChild(secondItem);

      //container.AddChild(title);
      //container.AddChild(list);

      //Console.WriteLine(container.InnerHTML);
      var container = new LightElementNode("div", "container");

      container.AddChild(new LightTextNode("Test images:"));
      container.AddChild(new Image("images/cat.png"));  // автоматично — файл
      container.AddChild(new Image("https://example.com/dog.jpg")); // автоматично — з мережі

      Console.WriteLine(container.OuterHTML);

    }
  }
}
