// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SqlParser.ClickHouse.Antlr4File2 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IClickHouseParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ClickHouseParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IClickHouseParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFrameStart([NotNull] ClickHouseParser.FrameStartContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuery([NotNull] ClickHouseParser.QueryContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSourceClause([NotNull] ClickHouseParser.SourceClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRangeClause([NotNull] ClickHouseParser.RangeClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUuidClause([NotNull] ClickHouseParser.UuidClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEngineClause([NotNull] ClickHouseParser.EngineClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTtlClause([NotNull] ClickHouseParser.TtlClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEngineExpr([NotNull] ClickHouseParser.EngineExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCodecExpr([NotNull] ClickHouseParser.CodecExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTtlExpr([NotNull] ClickHouseParser.TtlExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDropStmt([NotNull] ClickHouseParser.DropStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataClause([NotNull] ClickHouseParser.DataClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitKillStmt([NotNull] ClickHouseParser.KillStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWithClause([NotNull] ClickHouseParser.WithClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTopClause([NotNull] ClickHouseParser.TopClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFromClause([NotNull] ClickHouseParser.FromClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWindowClause([NotNull] ClickHouseParser.WindowClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhereClause([NotNull] ClickHouseParser.WhereClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHavingClause([NotNull] ClickHouseParser.HavingClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLimitClause([NotNull] ClickHouseParser.LimitClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinExpr([NotNull] ClickHouseParser.JoinExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinOp([NotNull] ClickHouseParser.JoinOpContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSampleClause([NotNull] ClickHouseParser.SampleClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLimitExpr([NotNull] ClickHouseParser.LimitExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrderExpr([NotNull] ClickHouseParser.OrderExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRatioExpr([NotNull] ClickHouseParser.RatioExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSettingExpr([NotNull] ClickHouseParser.SettingExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWindowExpr([NotNull] ClickHouseParser.WindowExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSetStmt([NotNull] ClickHouseParser.SetStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShowStmt([NotNull] ClickHouseParser.ShowStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUseStmt([NotNull] ClickHouseParser.UseStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableExpr([NotNull] ClickHouseParser.TableExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableArgList([NotNull] ClickHouseParser.TableArgListContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLiteral([NotNull] ClickHouseParser.LiteralContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInterval([NotNull] ClickHouseParser.IntervalContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitKeyword([NotNull] ClickHouseParser.KeywordContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlias([NotNull] ClickHouseParser.AliasContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifier([NotNull] ClickHouseParser.IdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEnumValue([NotNull] ClickHouseParser.EnumValueContext context) { return VisitChildren(context); }
}
} // namespace SqlParser.ClickHouse.Antlr4File2
