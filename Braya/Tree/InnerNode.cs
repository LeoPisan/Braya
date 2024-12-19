namespace Braya.Tree;

public class InnerNode<T> : Node<T>
{
    private Node<T> parent;

    public InnerNode(Node<T> parent, int treeOrder) : base(treeOrder)
    {
        this.parent = parent;
    }
}