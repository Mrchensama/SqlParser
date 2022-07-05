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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ClickHouseParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IClickHouseParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>ExistsTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExistsTableStmt([NotNull] ClickHouseParser.ExistsTableStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExistsDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExistsDatabaseStmt([NotNull] ClickHouseParser.ExistsDatabaseStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTernaryOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprTernaryOp([NotNull] ClickHouseParser.ColumnExprTernaryOpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprAlias([NotNull] ClickHouseParser.ColumnExprAliasContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprExtract</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprExtract([NotNull] ClickHouseParser.ColumnExprExtractContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprNegate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprNegate([NotNull] ClickHouseParser.ColumnExprNegateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprSubquery([NotNull] ClickHouseParser.ColumnExprSubqueryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprLiteral</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprLiteral([NotNull] ClickHouseParser.ColumnExprLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprArray</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprArray([NotNull] ClickHouseParser.ColumnExprArrayContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprSubstring</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprSubstring([NotNull] ClickHouseParser.ColumnExprSubstringContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprCast</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprCast([NotNull] ClickHouseParser.ColumnExprCastContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprOr</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprOr([NotNull] ClickHouseParser.ColumnExprOrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence1</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprPrecedence1([NotNull] ClickHouseParser.ColumnExprPrecedence1Context context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence2</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprPrecedence2([NotNull] ClickHouseParser.ColumnExprPrecedence2Context context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprPrecedence3</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprPrecedence3([NotNull] ClickHouseParser.ColumnExprPrecedence3Context context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprInterval</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprInterval([NotNull] ClickHouseParser.ColumnExprIntervalContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprIsNull</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprIsNull([NotNull] ClickHouseParser.ColumnExprIsNullContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprWinFunctionTarget</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprWinFunctionTarget([NotNull] ClickHouseParser.ColumnExprWinFunctionTargetContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTrim</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprTrim([NotNull] ClickHouseParser.ColumnExprTrimContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTuple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprTuple([NotNull] ClickHouseParser.ColumnExprTupleContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprArrayAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprArrayAccess([NotNull] ClickHouseParser.ColumnExprArrayAccessContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprBetween([NotNull] ClickHouseParser.ColumnExprBetweenContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprParens([NotNull] ClickHouseParser.ColumnExprParensContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTimestamp</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprTimestamp([NotNull] ClickHouseParser.ColumnExprTimestampContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAnd</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprAnd([NotNull] ClickHouseParser.ColumnExprAndContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprTupleAccess</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprTupleAccess([NotNull] ClickHouseParser.ColumnExprTupleAccessContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprCase</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprCase([NotNull] ClickHouseParser.ColumnExprCaseContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprDate</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprDate([NotNull] ClickHouseParser.ColumnExprDateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprNot</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprNot([NotNull] ClickHouseParser.ColumnExprNotContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprWinFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprWinFunction([NotNull] ClickHouseParser.ColumnExprWinFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprIdentifier([NotNull] ClickHouseParser.ColumnExprIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprFunction([NotNull] ClickHouseParser.ColumnExprFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprAsterisk([NotNull] ClickHouseParser.ColumnExprAsteriskContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnsExprColumn([NotNull] ClickHouseParser.ColumnsExprColumnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprAsterisk</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnsExprAsterisk([NotNull] ClickHouseParser.ColumnsExprAsteriskContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnsExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnsExprSubquery([NotNull] ClickHouseParser.ColumnsExprSubqueryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AttachDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttachDictionaryStmt([NotNull] ClickHouseParser.AttachDictionaryStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinExprOp([NotNull] ClickHouseParser.JoinExprOpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprTable</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinExprTable([NotNull] ClickHouseParser.JoinExprTableContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprCrossOp</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinExprCrossOp([NotNull] ClickHouseParser.JoinExprCrossOpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinExprParens</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinExprParens([NotNull] ClickHouseParser.JoinExprParensContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DropDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDropDatabaseStmt([NotNull] ClickHouseParser.DropDatabaseStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DropTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDropTableStmt([NotNull] ClickHouseParser.DropTableStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExplainSyntaxStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplainSyntaxStmt([NotNull] ClickHouseParser.ExplainSyntaxStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExplainASTStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplainASTStmt([NotNull] ClickHouseParser.ExplainASTStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableElementExprProjection([NotNull] ClickHouseParser.TableElementExprProjectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprConstraint</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableElementExprConstraint([NotNull] ClickHouseParser.TableElementExprConstraintContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableElementExprColumn([NotNull] ClickHouseParser.TableElementExprColumnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableElementExprIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableElementExprIndex([NotNull] ClickHouseParser.TableElementExprIndexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateViewStmt([NotNull] ClickHouseParser.CreateViewStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateDictionaryStmt([NotNull] ClickHouseParser.CreateDictionaryStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateDatabaseStmt([NotNull] ClickHouseParser.CreateDatabaseStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateLiveViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateLiveViewStmt([NotNull] ClickHouseParser.CreateLiveViewStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateMaterializedViewStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateMaterializedViewStmt([NotNull] ClickHouseParser.CreateMaterializedViewStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>CreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateTableStmt([NotNull] ClickHouseParser.CreateTableStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpFull</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinOpFull([NotNull] ClickHouseParser.JoinOpFullContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpInner</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinOpInner([NotNull] ClickHouseParser.JoinOpInnerContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>JoinOpLeftRight</c>
	/// labeled alternative in <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinOpLeftRight([NotNull] ClickHouseParser.JoinOpLeftRightContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprIdentifier</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableExprIdentifier([NotNull] ClickHouseParser.TableExprIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprSubquery</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableExprSubquery([NotNull] ClickHouseParser.TableExprSubqueryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprAlias</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableExprAlias([NotNull] ClickHouseParser.TableExprAliasContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TableExprFunction</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableExprFunction([NotNull] ClickHouseParser.TableExprFunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseReplace</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseReplace([NotNull] ClickHouseParser.AlterTableClauseReplaceContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyOrderBy</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModifyOrderBy([NotNull] ClickHouseParser.AlterTableClauseModifyOrderByContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseUpdate</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseUpdate([NotNull] ClickHouseParser.AlterTableClauseUpdateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseClearProjection([NotNull] ClickHouseParser.AlterTableClauseClearProjectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyRemove</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModifyRemove([NotNull] ClickHouseParser.AlterTableClauseModifyRemoveContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDelete</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDelete([NotNull] ClickHouseParser.AlterTableClauseDeleteContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseComment([NotNull] ClickHouseParser.AlterTableClauseCommentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDropColumn([NotNull] ClickHouseParser.AlterTableClauseDropColumnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDetach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDetach([NotNull] ClickHouseParser.AlterTableClauseDetachContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseAddIndex([NotNull] ClickHouseParser.AlterTableClauseAddIndexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropPartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDropPartition([NotNull] ClickHouseParser.AlterTableClauseDropPartitionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMaterializeIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseMaterializeIndex([NotNull] ClickHouseParser.AlterTableClauseMaterializeIndexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMaterializeProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseMaterializeProjection([NotNull] ClickHouseParser.AlterTableClauseMaterializeProjectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseMovePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseMovePartition([NotNull] ClickHouseParser.AlterTableClauseMovePartitionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseRename</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseRename([NotNull] ClickHouseParser.AlterTableClauseRenameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseFreezePartition</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseFreezePartition([NotNull] ClickHouseParser.AlterTableClauseFreezePartitionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseClearColumn([NotNull] ClickHouseParser.AlterTableClauseClearColumnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModify</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModify([NotNull] ClickHouseParser.AlterTableClauseModifyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseClearIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseClearIndex([NotNull] ClickHouseParser.AlterTableClauseClearIndexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseRemoveTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseRemoveTTL([NotNull] ClickHouseParser.AlterTableClauseRemoveTTLContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyCodec</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModifyCodec([NotNull] ClickHouseParser.AlterTableClauseModifyCodecContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAttach</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseAttach([NotNull] ClickHouseParser.AlterTableClauseAttachContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDropProjection([NotNull] ClickHouseParser.AlterTableClauseDropProjectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseDropIndex</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseDropIndex([NotNull] ClickHouseParser.AlterTableClauseDropIndexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyComment</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModifyComment([NotNull] ClickHouseParser.AlterTableClauseModifyCommentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseModifyTTL</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseModifyTTL([NotNull] ClickHouseParser.AlterTableClauseModifyTTLContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddProjection</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseAddProjection([NotNull] ClickHouseParser.AlterTableClauseAddProjectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableClauseAddColumn</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClauseAddColumn([NotNull] ClickHouseParser.AlterTableClauseAddColumnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateDatabaseStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowCreateDatabaseStmt([NotNull] ClickHouseParser.ShowCreateDatabaseStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showDatabasesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowDatabasesStmt([NotNull] ClickHouseParser.ShowDatabasesStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowCreateTableStmt([NotNull] ClickHouseParser.ShowCreateTableStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showTablesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowTablesStmt([NotNull] ClickHouseParser.ShowTablesStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showDictionariesStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowDictionariesStmt([NotNull] ClickHouseParser.ShowDictionariesStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>showCreateDictionaryStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowCreateDictionaryStmt([NotNull] ClickHouseParser.ShowCreateDictionaryStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaAsTableClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSchemaAsTableClause([NotNull] ClickHouseParser.SchemaAsTableClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaAsFunctionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSchemaAsFunctionClause([NotNull] ClickHouseParser.SchemaAsFunctionClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SchemaDescriptionClause</c>
	/// labeled alternative in <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSchemaDescriptionClause([NotNull] ClickHouseParser.SchemaDescriptionClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>KillMutationStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKillMutationStmt([NotNull] ClickHouseParser.KillMutationStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseValues</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDataClauseValues([NotNull] ClickHouseParser.DataClauseValuesContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseFormat</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDataClauseFormat([NotNull] ClickHouseParser.DataClauseFormatContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DataClauseSelect</c>
	/// labeled alternative in <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDataClauseSelect([NotNull] ClickHouseParser.DataClauseSelectContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>frameStart</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrameStart([NotNull] ClickHouseParser.FrameStartContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>frameBetween</c>
	/// labeled alternative in <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrameBetween([NotNull] ClickHouseParser.FrameBetweenContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprNested</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExprNested([NotNull] ClickHouseParser.ColumnTypeExprNestedContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprParam</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExprParam([NotNull] ClickHouseParser.ColumnTypeExprParamContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprSimple</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExprSimple([NotNull] ClickHouseParser.ColumnTypeExprSimpleContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprComplex</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExprComplex([NotNull] ClickHouseParser.ColumnTypeExprComplexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnTypeExprEnum</c>
	/// labeled alternative in <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExprEnum([NotNull] ClickHouseParser.ColumnTypeExprEnumContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AlterTableStmt</c>
	/// labeled alternative in <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableStmt([NotNull] ClickHouseParser.AlterTableStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.queryStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQueryStmt([NotNull] ClickHouseParser.QueryStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery([NotNull] ClickHouseParser.QueryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alterStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterStmt([NotNull] ClickHouseParser.AlterStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alterTableClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlterTableClause([NotNull] ClickHouseParser.AlterTableClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.addAfterColumnName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddAfterColumnName([NotNull] ClickHouseParser.AddAfterColumnNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.assignmentExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExprList([NotNull] ClickHouseParser.AssignmentExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.assignmentExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpr([NotNull] ClickHouseParser.AssignmentExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableColumnPropertyType([NotNull] ClickHouseParser.TableColumnPropertyTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.partitionClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartitionClause([NotNull] ClickHouseParser.PartitionClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.attachStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttachStmt([NotNull] ClickHouseParser.AttachStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.checkStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCheckStmt([NotNull] ClickHouseParser.CheckStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.createStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreateStmt([NotNull] ClickHouseParser.CreateStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionarySchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionarySchemaClause([NotNull] ClickHouseParser.DictionarySchemaClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryAttrDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionaryAttrDfnt([NotNull] ClickHouseParser.DictionaryAttrDfntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryEngineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionaryEngineClause([NotNull] ClickHouseParser.DictionaryEngineClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryPrimaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionaryPrimaryKeyClause([NotNull] ClickHouseParser.DictionaryPrimaryKeyClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionaryArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionaryArgExpr([NotNull] ClickHouseParser.DictionaryArgExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sourceClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSourceClause([NotNull] ClickHouseParser.SourceClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.lifetimeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLifetimeClause([NotNull] ClickHouseParser.LifetimeClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.layoutClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLayoutClause([NotNull] ClickHouseParser.LayoutClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.rangeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRangeClause([NotNull] ClickHouseParser.RangeClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dictionarySettingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionarySettingsClause([NotNull] ClickHouseParser.DictionarySettingsClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.clusterClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClusterClause([NotNull] ClickHouseParser.ClusterClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.uuidClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUuidClause([NotNull] ClickHouseParser.UuidClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.destinationClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDestinationClause([NotNull] ClickHouseParser.DestinationClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.subqueryClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubqueryClause([NotNull] ClickHouseParser.SubqueryClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableSchemaClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableSchemaClause([NotNull] ClickHouseParser.TableSchemaClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.engineClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEngineClause([NotNull] ClickHouseParser.EngineClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableCommentClause([NotNull] ClickHouseParser.TableCommentClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnCommentClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnCommentClause([NotNull] ClickHouseParser.ColumnCommentClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.partitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartitionByClause([NotNull] ClickHouseParser.PartitionByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.primaryKeyClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryKeyClause([NotNull] ClickHouseParser.PrimaryKeyClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sampleByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSampleByClause([NotNull] ClickHouseParser.SampleByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ttlClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTtlClause([NotNull] ClickHouseParser.TtlClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.engineExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEngineExpr([NotNull] ClickHouseParser.EngineExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableElementExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableElementExpr([NotNull] ClickHouseParser.TableElementExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableColumnDfnt([NotNull] ClickHouseParser.TableColumnDfntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableColumnPropertyExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableColumnPropertyExpr([NotNull] ClickHouseParser.TableColumnPropertyExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableIndexDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableIndexDfnt([NotNull] ClickHouseParser.TableIndexDfntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableProjectionDfnt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableProjectionDfnt([NotNull] ClickHouseParser.TableProjectionDfntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.codecExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCodecExpr([NotNull] ClickHouseParser.CodecExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.codecArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCodecArgExpr([NotNull] ClickHouseParser.CodecArgExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ttlExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTtlExpr([NotNull] ClickHouseParser.TtlExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.describeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDescribeStmt([NotNull] ClickHouseParser.DescribeStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dropStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDropStmt([NotNull] ClickHouseParser.DropStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.existsStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExistsStmt([NotNull] ClickHouseParser.ExistsStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.explainStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplainStmt([NotNull] ClickHouseParser.ExplainStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.insertStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInsertStmt([NotNull] ClickHouseParser.InsertStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnsClause([NotNull] ClickHouseParser.ColumnsClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.dataClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDataClause([NotNull] ClickHouseParser.DataClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.killStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKillStmt([NotNull] ClickHouseParser.KillStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.optimizeStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptimizeStmt([NotNull] ClickHouseParser.OptimizeStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.renameStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRenameStmt([NotNull] ClickHouseParser.RenameStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.projectionSelectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProjectionSelectStmt([NotNull] ClickHouseParser.ProjectionSelectStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectUnionStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectUnionStmt([NotNull] ClickHouseParser.SelectUnionStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectStmtWithParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectStmtWithParens([NotNull] ClickHouseParser.SelectStmtWithParensContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.selectStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectStmt([NotNull] ClickHouseParser.SelectStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.withClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithClause([NotNull] ClickHouseParser.WithClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.topClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTopClause([NotNull] ClickHouseParser.TopClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.fromClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFromClause([NotNull] ClickHouseParser.FromClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.arrayJoinClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayJoinClause([NotNull] ClickHouseParser.ArrayJoinClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.windowClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindowClause([NotNull] ClickHouseParser.WindowClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.prewhereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrewhereClause([NotNull] ClickHouseParser.PrewhereClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhereClause([NotNull] ClickHouseParser.WhereClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.groupByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupByClause([NotNull] ClickHouseParser.GroupByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.havingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHavingClause([NotNull] ClickHouseParser.HavingClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderByClause([NotNull] ClickHouseParser.OrderByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.projectionOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProjectionOrderByClause([NotNull] ClickHouseParser.ProjectionOrderByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitByClause([NotNull] ClickHouseParser.LimitByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitClause([NotNull] ClickHouseParser.LimitClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSettingsClause([NotNull] ClickHouseParser.SettingsClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinExpr([NotNull] ClickHouseParser.JoinExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinOp([NotNull] ClickHouseParser.JoinOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinOpCross"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinOpCross([NotNull] ClickHouseParser.JoinOpCrossContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.joinConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinConstraintClause([NotNull] ClickHouseParser.JoinConstraintClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.sampleClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSampleClause([NotNull] ClickHouseParser.SampleClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.limitExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimitExpr([NotNull] ClickHouseParser.LimitExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderExprList([NotNull] ClickHouseParser.OrderExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.orderExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderExpr([NotNull] ClickHouseParser.OrderExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.ratioExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRatioExpr([NotNull] ClickHouseParser.RatioExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSettingExprList([NotNull] ClickHouseParser.SettingExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.settingExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSettingExpr([NotNull] ClickHouseParser.SettingExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.windowExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindowExpr([NotNull] ClickHouseParser.WindowExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winPartitionByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWinPartitionByClause([NotNull] ClickHouseParser.WinPartitionByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winOrderByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWinOrderByClause([NotNull] ClickHouseParser.WinOrderByClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWinFrameClause([NotNull] ClickHouseParser.WinFrameClauseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameExtend"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWinFrameExtend([NotNull] ClickHouseParser.WinFrameExtendContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.winFrameBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWinFrameBound([NotNull] ClickHouseParser.WinFrameBoundContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.setStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetStmt([NotNull] ClickHouseParser.SetStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.showStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowStmt([NotNull] ClickHouseParser.ShowStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.systemStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSystemStmt([NotNull] ClickHouseParser.SystemStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.truncateStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTruncateStmt([NotNull] ClickHouseParser.TruncateStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.useStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUseStmt([NotNull] ClickHouseParser.UseStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.watchStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWatchStmt([NotNull] ClickHouseParser.WatchStmtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnTypeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnTypeExpr([NotNull] ClickHouseParser.ColumnTypeExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExprList([NotNull] ClickHouseParser.ColumnExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnsExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnsExpr([NotNull] ClickHouseParser.ColumnsExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExpr([NotNull] ClickHouseParser.ColumnExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnArgList([NotNull] ClickHouseParser.ColumnArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnArgExpr([NotNull] ClickHouseParser.ColumnArgExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnLambdaExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnLambdaExpr([NotNull] ClickHouseParser.ColumnLambdaExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.columnIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnIdentifier([NotNull] ClickHouseParser.ColumnIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.nestedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNestedIdentifier([NotNull] ClickHouseParser.NestedIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableExpr([NotNull] ClickHouseParser.TableExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableFunctionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableFunctionExpr([NotNull] ClickHouseParser.TableFunctionExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableIdentifier([NotNull] ClickHouseParser.TableIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableArgList([NotNull] ClickHouseParser.TableArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.tableArgExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableArgExpr([NotNull] ClickHouseParser.TableArgExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.databaseIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatabaseIdentifier([NotNull] ClickHouseParser.DatabaseIdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.floatingLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatingLiteral([NotNull] ClickHouseParser.FloatingLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.numberLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberLiteral([NotNull] ClickHouseParser.NumberLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] ClickHouseParser.LiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterval([NotNull] ClickHouseParser.IntervalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyword([NotNull] ClickHouseParser.KeywordContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.keywordForAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeywordForAlias([NotNull] ClickHouseParser.KeywordForAliasContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlias([NotNull] ClickHouseParser.AliasContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] ClickHouseParser.IdentifierContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.identifierOrNull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierOrNull([NotNull] ClickHouseParser.IdentifierOrNullContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ClickHouseParser.enumValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumValue([NotNull] ClickHouseParser.EnumValueContext context);
}
} // namespace SqlParser.ClickHouse.Antlr4File2
