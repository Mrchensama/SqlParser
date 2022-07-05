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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IClickHouseParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ClickHouseParserBaseListener : IClickHouseParserListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrameStart([NotNull] ClickHouseParser.FrameStartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrameStart([NotNull] ClickHouseParser.FrameStartContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery([NotNull] ClickHouseParser.QueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery([NotNull] ClickHouseParser.QueryContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSourceClause([NotNull] ClickHouseParser.SourceClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSourceClause([NotNull] ClickHouseParser.SourceClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRangeClause([NotNull] ClickHouseParser.RangeClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRangeClause([NotNull] ClickHouseParser.RangeClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUuidClause([NotNull] ClickHouseParser.UuidClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUuidClause([NotNull] ClickHouseParser.UuidClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEngineClause([NotNull] ClickHouseParser.EngineClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEngineClause([NotNull] ClickHouseParser.EngineClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTtlClause([NotNull] ClickHouseParser.TtlClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTtlClause([NotNull] ClickHouseParser.TtlClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEngineExpr([NotNull] ClickHouseParser.EngineExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEngineExpr([NotNull] ClickHouseParser.EngineExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCodecExpr([NotNull] ClickHouseParser.CodecExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCodecExpr([NotNull] ClickHouseParser.CodecExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTtlExpr([NotNull] ClickHouseParser.TtlExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTtlExpr([NotNull] ClickHouseParser.TtlExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropStmt([NotNull] ClickHouseParser.DropStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropStmt([NotNull] ClickHouseParser.DropStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataClause([NotNull] ClickHouseParser.DataClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataClause([NotNull] ClickHouseParser.DataClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKillStmt([NotNull] ClickHouseParser.KillStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKillStmt([NotNull] ClickHouseParser.KillStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithClause([NotNull] ClickHouseParser.WithClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithClause([NotNull] ClickHouseParser.WithClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTopClause([NotNull] ClickHouseParser.TopClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTopClause([NotNull] ClickHouseParser.TopClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFromClause([NotNull] ClickHouseParser.FromClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFromClause([NotNull] ClickHouseParser.FromClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowClause([NotNull] ClickHouseParser.WindowClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowClause([NotNull] ClickHouseParser.WindowClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhereClause([NotNull] ClickHouseParser.WhereClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhereClause([NotNull] ClickHouseParser.WhereClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHavingClause([NotNull] ClickHouseParser.HavingClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHavingClause([NotNull] ClickHouseParser.HavingClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitClause([NotNull] ClickHouseParser.LimitClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitClause([NotNull] ClickHouseParser.LimitClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinExpr([NotNull] ClickHouseParser.JoinExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinExpr([NotNull] ClickHouseParser.JoinExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinOp([NotNull] ClickHouseParser.JoinOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinOp([NotNull] ClickHouseParser.JoinOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSampleClause([NotNull] ClickHouseParser.SampleClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSampleClause([NotNull] ClickHouseParser.SampleClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitExpr([NotNull] ClickHouseParser.LimitExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitExpr([NotNull] ClickHouseParser.LimitExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderExpr([NotNull] ClickHouseParser.OrderExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderExpr([NotNull] ClickHouseParser.OrderExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRatioExpr([NotNull] ClickHouseParser.RatioExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRatioExpr([NotNull] ClickHouseParser.RatioExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSettingExpr([NotNull] ClickHouseParser.SettingExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSettingExpr([NotNull] ClickHouseParser.SettingExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowExpr([NotNull] ClickHouseParser.WindowExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowExpr([NotNull] ClickHouseParser.WindowExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetStmt([NotNull] ClickHouseParser.SetStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetStmt([NotNull] ClickHouseParser.SetStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowStmt([NotNull] ClickHouseParser.ShowStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowStmt([NotNull] ClickHouseParser.ShowStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUseStmt([NotNull] ClickHouseParser.UseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUseStmt([NotNull] ClickHouseParser.UseStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableExpr([NotNull] ClickHouseParser.TableExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableExpr([NotNull] ClickHouseParser.TableExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableArgList([NotNull] ClickHouseParser.TableArgListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableArgList([NotNull] ClickHouseParser.TableArgListContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] ClickHouseParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] ClickHouseParser.LiteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterval([NotNull] ClickHouseParser.IntervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterval([NotNull] ClickHouseParser.IntervalContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] ClickHouseParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] ClickHouseParser.KeywordContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlias([NotNull] ClickHouseParser.AliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlias([NotNull] ClickHouseParser.AliasContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] ClickHouseParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] ClickHouseParser.IdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumValue([NotNull] ClickHouseParser.EnumValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumValue([NotNull] ClickHouseParser.EnumValueContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace SqlParser.ClickHouse.Antlr4File2
