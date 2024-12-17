namespace Braya.Tree;

/// <summary>
/// The entry node in a b-tree
/// </summary>
public class Root<T> : Node<T>
{
    public Root(int treeOrder) : base(treeOrder)
    {
    }
}