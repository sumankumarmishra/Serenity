namespace Serenity.TypeScript;

internal class TupleTypeNode(NodeArray<ITypeNode> elementTypes)
    : TypeNodeBase(SyntaxKind.TupleType), IGetRestChildren
{
    public NodeArray<ITypeNode> ElementTypes { get; set; } = elementTypes;

    public IEnumerable<INode> GetRestChildren()
    {
        return ElementTypes;
    }
}