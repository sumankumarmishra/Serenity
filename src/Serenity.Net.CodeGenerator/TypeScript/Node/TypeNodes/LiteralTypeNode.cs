namespace Serenity.TypeScript;

internal class LiteralTypeNode(IExpression literal)
    : TypeNodeBase(SyntaxKind.LiteralType), IGetRestChildren
{
    public IExpression Literal { get; set; } = literal;

    public IEnumerable<INode> GetRestChildren()
    {
        return [Literal];
    }
}