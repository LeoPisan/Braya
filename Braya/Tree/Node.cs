using Braya.Data;

namespace Braya.Tree;

/// <summary>
/// A basic node in a b-tree
/// </summary>
public class Node<T>
{
    private List<Node<T>> children;
    private int treeOrder;
    private List<AbstractData<T>> data = [];

    /// <summary>
    /// Instantiate a node
    /// </summary>
    /// <param name="treeOrder"></param>
    protected Node(int treeOrder)
    {
        this.children = [];
        this.treeOrder = treeOrder;
    }

    protected int TreeOrder
    {
        get => treeOrder;
        set => treeOrder = value;
    }
}