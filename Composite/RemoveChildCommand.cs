namespace Composite
{
  public class RemoveChildCommand : ICommand
  {
    private LightElementNode _parent;
    private LightNode _child;

    public RemoveChildCommand(LightElementNode parent, LightNode child)
    {
      _parent = parent;
      _child = child;
    }

    public void Execute()
    {
      _parent.Children.Remove(_child);
    }
  }
}
