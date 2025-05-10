using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public abstract class LightNode
  {
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }

    public void Render()
    {
      OnCreated();
      OnInserted();
      OnStylesApplied();
      OnClassListApplied();
      OnTextRendered();
    }

    // Хуки: ці методи можуть бути перевизначені у підкласах
    public virtual void OnCreated()
    {
      Console.WriteLine($"[Created] {GetType().Name} елемент створено.");
    }

    public virtual void OnInserted()
    {
      Console.WriteLine($"[Inserted] {GetType().Name} елемент вставлено.");
    }

    public virtual void OnStylesApplied()
    {
      Console.WriteLine($"[Styles Applied] Стилі застосовано до {GetType().Name}.");
    }

    public virtual void OnClassListApplied()
    {
      Console.WriteLine($"[Class List Applied] Клас до {GetType().Name} додано.");
    }

    public virtual void OnTextRendered()
    {
      Console.WriteLine($"[Text Rendered] Текст відрендерено для {GetType().Name}.");
    }
  }
}
