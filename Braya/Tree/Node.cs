using Braya.Data;

namespace Braya.Tree;

/// <summary>
/// A basic node in a b-tree
/// </summary>
public class Node<T>
{
    private readonly List<Node<T>> _children;
    private int _treeOrder;
    private List<IAbstractData<T>> _data;

    /// <summary>
    /// Instantiate a node
    /// </summary>
    /// <param name="treeOrder">Set up the order of the tree (the same for all of its nodes)</param>
    protected Node(int treeOrder)
    {
        _children = [];
        _treeOrder = treeOrder;
        _data = [];
    }

    /// <summary>
    /// Order of the tree
    /// </summary>
    protected int TreeOrder
    {
        get => _treeOrder;
        set => _treeOrder = value;
    }
    
    /// <summary>
    /// Indicates if a node is a leaf or not
    /// </summary>
    public bool IsLeaf => _children.Count == 0;

    /// <summary>
    /// Give the depth of the subtree with the current node as its root
    /// </summary>
    public int Depth
    {
        get
        {
            if (_children.Count == 0)
                return 1;
            return _children[0].Depth + 1;
        }
    }

    /// <summary>
    /// Add a value to the node or one of its children
    /// </summary>
    /// <param name="value">The value to add</param>
    public void AddValue(IAbstractData<T> value)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Search a value in the node and its children
    /// </summary>
    /// <param name="value">The value searched</param>
    /// <returns>The value</returns>
    public IAbstractData<T>? SearchValue(IAbstractData<T> value)
    {
        IAbstractData<T>? result = null;
        // Checks if the value is stored in the node and returns it if it is the case
        var internalResult = _data.Find(data => data.Equals(value));
        if (internalResult != null)
            result = internalResult;

        // If there is no child or the value has been found internally
        if (_children.Count <= 0 || result != null) return result;
        
        // Pass the request to the children if the value is not contained in the node
        for (var i = 0; i < _data.Count; i++)
        {
            if (_data[i].IsGreaterThan(value))
            {
                result = _children[i].SearchValue(value);
            }
        }

        // If we haven't found the correct child yet, then it must be the in the last one
        result ??= _children.Last().SearchValue(value);

        return result;
    }
}