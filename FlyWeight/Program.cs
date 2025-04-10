using Composite;
namespace FlyWeight
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string filePath = "E:\\Політех\\kpz\\lab3\\Adapter\\FlyWeight\\book.txt"; 
      string[] lines = File.ReadAllLines(filePath);

      LightElementNode root = new LightElementNode("div", "book");
      LightElementFactory factory = new LightElementFactory();

      for (int i = 0; i < lines.Length; i++)
      {
        string line = lines[i].TrimEnd();
        LightElementNode element;

        if (string.IsNullOrEmpty(line))
          continue;
        if (i == 0)
          element = factory.GetElement("h1");
        else if (line.Length < 20)
          element = factory.GetElement("h2");
        else if (char.IsWhiteSpace(lines[i][0]))
          element = factory.GetElement("blockquote");
        else
          element = factory.GetElement("p");

        LightElementNode clone = new LightElementNode(element.TagName);
        clone.AddChild(new LightTextNode(line));
        root.AddChild(clone);
      }

      Console.WriteLine(root.InnerHTML);
      Console.WriteLine("Memory usage: " + GC.GetTotalMemory(false) + " bytes");
    }
  }
}
