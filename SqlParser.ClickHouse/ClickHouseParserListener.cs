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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ClickHouseParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IClickHouseParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrameStart([NotNull] ClickHouseParser.FrameStartContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrameStart([NotNull] ClickHouseParser.FrameStartContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery([NotNull] ClickHouseParser.QueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery([NotNull] ClickHouseParser.QueryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceClause([NotNull] ClickHouseParser.SourceClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceClause([NotNull] ClickHouseParser.SourceClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRangeClause([NotNull] ClickHouseParser.RangeClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRangeClause([NotNull] ClickHouseParser.RangeClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUuidClause([NotNull] ClickHouseParser.UuidClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUuidClause([NotNull] ClickHouseParser.UuidClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEngineClause([NotNull] ClickHouseParser.EngineClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEngineClause([NotNull] ClickHouseParser.EngineClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTtlClause([NotNull] ClickHouseParser.TtlClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTtlClause([NotNull] ClickHouseParser.TtlClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEngineExpr([NotNull] ClickHouseParser.EngineExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEngineExpr([NotNull] ClickHouseParser.EngineExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCodecExpr([NotNull] ClickHouseParser.CodecExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCodecExpr([NotNull] ClickHouseParser.CodecExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTtlExpr([NotNull] ClickHouseParser.TtlExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTtlExpr([NotNull] ClickHouseParser.TtlExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropStmt([NotNull] ClickHouseParser.DropStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropStmt([NotNull] ClickHouseParser.DropStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataClause([NotNull] ClickHouseParser.DataClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataClause([NotNull] ClickHouseParser.DataClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKillStmt([NotNull] ClickHouseParser.KillStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKillStmt([NotNull] ClickHouseParser.KillStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithClause([NotNull] ClickHouseParser.WithClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithClause([NotNull] ClickHouseParser.WithClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTopClause([NotNull] ClickHouseParser.TopClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTopClause([NotNull] ClickHouseParser.TopClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFromClause([NotNull] ClickHouseParser.FromClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFromClause([NotNull] ClickHouseParser.FromClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowClause([NotNull] ClickHouseParser.WindowClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowClause([NotNull] ClickHouseParser.WindowClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhereClause([NotNull] ClickHouseParser.WhereClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhereClause([NotNull] ClickHouseParser.WhereClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHavingClause([NotNull] ClickHouseParser.HavingClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHavingClause([NotNull] ClickHouseParser.HavingClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitClause([NotNull] ClickHouseParser.LimitClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitClause([NotNull] ClickHouseParser.LimitClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinExpr([NotNull] ClickHouseParser.JoinExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinExpr([NotNull] ClickHouseParser.JoinExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinOp([NotNull] ClickHouseParser.JoinOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinOp([NotNull] ClickHouseParser.JoinOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSampleClause([NotNull] ClickHouseParser.SampleClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSampleClause([NotNull] ClickHouseParser.SampleClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitExpr([NotNull] ClickHouseParser.LimitExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitExpr([NotNull] ClickHouseParser.LimitExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderExpr([NotNull] ClickHouseParser.OrderExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderExpr([NotNull] ClickHouseParser.OrderExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRatioExpr([NotNull] ClickHouseParser.RatioExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRatioExpr([NotNull] ClickHouseParser.RatioExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSettingExpr([NotNull] ClickHouseParser.SettingExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSettingExpr([NotNull] ClickHouseParser.SettingExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowExpr([NotNull] ClickHouseParser.WindowExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowExpr([NotNull] ClickHouseParser.WindowExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetStmt([NotNull] ClickHouseParser.SetStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetStmt([NotNull] ClickHouseParser.SetStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowStmt([NotNull] ClickHouseParser.ShowStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowStmt([NotNull] ClickHouseParser.ShowStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUseStmt([NotNull] ClickHouseParser.UseStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUseStmt([NotNull] ClickHouseParser.UseStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableExpr([NotNull] ClickHouseParser.TableExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableExpr([NotNull] ClickHouseParser.TableExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableArgList([NotNull] ClickHouseParser.TableArgListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableArgList([NotNull] ClickHouseParser.TableArgListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] ClickHouseParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] ClickHouseParser.LiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterval([NotNull] ClickHouseParser.IntervalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterval([NotNull] ClickHouseParser.IntervalContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] ClickHouseParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] ClickHouseParser.KeywordContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlias([NotNull] ClickHouseParser.AliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlias([NotNull] ClickHouseParser.AliasContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] ClickHouseParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] ClickHouseParser.IdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumValue([NotNull] ClickHouseParser.EnumValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumValue([NotNull] ClickHouseParser.EnumValueContext context);
}
} // namespace SqlParser.ClickHouse.Antlr4File2
