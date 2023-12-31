namespace Serenity.TypeScript;

internal class TypeOfExpression(IExpression expression) 
    : UnaryExpressionBase(SyntaxKind.TypeOfExpression), IGetRestChildren
{
    public /*UnaryExpression*/IExpression Expression { get; } = expression;

    public IEnumerable<INode> GetRestChildren()
    {
        return [Expression];
    }
}