using System;
using System.Collections.Generic;

namespace Composite
{
  // Інтерфейс Ітератора
  public interface ILightNodeIterator
  {
    bool HasNext();
    LightNode Next();
  }

  // Ітератор в глибину (Depth-First Search)
  public class DepthFirstIterator : ILightNodeIterator
  {
    private Stack<LightNode> _stack = new();

    public DepthFirstIterator(LightNode root)
    {
      _stack.Push(root);
    }

    public bool HasNext() => _stack.Count > 0;

    public LightNode Next()
    {
      var node = _stack.Pop();

      if (node is LightElementNode elementNode)
      {
        // Додаємо дітей у зворотному порядку для правильного обходу
        for (int i = elementNode.Children.Count - 1; i >= 0; i--)
        {
          _stack.Push(elementNode.Children[i]);
        }
      }

      return node;
    }
  }
  // Ітератор в ширину (Breadth-First Search)
  public class BreadthFirstIterator : ILightNodeIterator
  {
    private Queue<LightNode> _queue = new();

    public BreadthFirstIterator(LightNode root)
    {
      _queue.Enqueue(root);
    }

    public bool HasNext() => _queue.Count > 0;

    public LightNode Next()
    {
      var node = _queue.Dequeue();

      if (node is LightElementNode elementNode)
      {
        foreach (var child in elementNode.Children)
        {
          _queue.Enqueue(child);
        }
      }

      return node;
    }
  }

}
