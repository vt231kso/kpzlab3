namespace Composite
{
  internal class Program
  {
    static void Main()
    {
      LightElementNode container = new LightElementNode("div", "container");

      LightElementNode title = new LightElementNode("h1", "title");
      title.AddChild(new LightTextNode("Hello, LightHTML!"));

      LightElementNode list = new LightElementNode("ul", "list");

      LightElementNode firstItem = new LightElementNode("li");
      firstItem.AddChild(new LightTextNode("First item"));

      LightElementNode secondItem = new LightElementNode("li");
      secondItem.AddChild(new LightTextNode("Second item"));

      list.AddChild(firstItem);
      list.AddChild(secondItem);

      container.AddChild(title);
      container.AddChild(list);

      Console.WriteLine(container.InnerHTML);
      Console.WriteLine("\nIterator traversal:");
      var iterator = new DepthFirstIterator(container);
      while (iterator.HasNext())
      {
        var node = iterator.Next();
        Console.WriteLine(node.OuterHTML);
      }
      Console.WriteLine("\nIterator traversal (Breadth-First):");
      var bfsIterator = new BreadthFirstIterator(container);
      while (bfsIterator.HasNext())
      {
        var node = bfsIterator.Next();
        Console.WriteLine(node.OuterHTML);
      }


    }
  }
}
