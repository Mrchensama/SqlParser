// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SqlParser.ClickHouse.Antlr4File2 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ClickHouseParser : Parser {
	public const int
		ADD=1, AFTER=2, ALIAS=3, ALL=4, ALTER=5, AND=6, ANTI=7, ANY=8, ARRAY=9, 
		AS=10, ASCENDING=11, ASOF=12, AST=13, ASYNC=14, ATTACH=15, BETWEEN=16, 
		BOTH=17, BY=18, CASE=19, CAST=20, CHECK=21, CLEAR=22, CLUSTER=23, CODEC=24, 
		COLLATE=25, COLUMN=26, COMMENT=27, CONSTRAINT=28, CREATE=29, CROSS=30, 
		CUBE=31, CURRENT=32, DATABASE=33, DATABASES=34, DATE=35, DAY=36, DEDUPLICATE=37, 
		DEFAULT=38, DELAY=39, DELETE=40, DESC=41, DESCENDING=42, DESCRIBE=43, 
		DETACH=44, DICTIONARIES=45, DICTIONARY=46, DISK=47, DISTINCT=48, DISTRIBUTED=49, 
		DROP=50, ELSE=51, END=52, ENGINE=53, EVENTS=54, EXISTS=55, EXPLAIN=56, 
		EXPRESSION=57, EXTRACT=58, FETCHES=59, FINAL=60, FIRST=61, FLUSH=62, FOLLOWING=63, 
		FOR=64, FORMAT=65, FREEZE=66, FROM=67, FULL=68, FUNCTION=69, GLOBAL=70, 
		GRANULARITY=71, GROUP=72, HAVING=73, HIERARCHICAL=74, HOUR=75, ID=76, 
		IF=77, ILIKE=78, IN=79, INDEX=80, INF=81, INJECTIVE=82, INNER=83, INSERT=84, 
		INTERVAL=85, INTO=86, IS=87, IS_OBJECT_ID=88, JOIN=89, KEY=90, KILL=91, 
		LAST=92, LAYOUT=93, LEADING=94, LEFT=95, LIFETIME=96, LIKE=97, LIMIT=98, 
		LIVE=99, LOCAL=100, LOGS=101, MATERIALIZE=102, MATERIALIZED=103, MAX=104, 
		MERGES=105, MIN=106, MINUTE=107, MODIFY=108, MONTH=109, MOVE=110, MUTATION=111, 
		NAN_SQL=112, NO=113, NOT=114, NULL_SQL=115, NULLS=116, OFFSET=117, ON=118, 
		OPTIMIZE=119, OR=120, ORDER=121, OUTER=122, OUTFILE=123, OVER=124, PARTITION=125, 
		POPULATE=126, PRECEDING=127, PREWHERE=128, PRIMARY=129, PROJECTION=130, 
		QUARTER=131, RANGE=132, RELOAD=133, REMOVE=134, RENAME=135, REPLACE=136, 
		REPLICA=137, REPLICATED=138, RIGHT=139, ROLLUP=140, ROW=141, ROWS=142, 
		SAMPLE=143, SECOND=144, SELECT=145, SEMI=146, SENDS=147, SET=148, SETTINGS=149, 
		SHOW=150, SOURCE=151, START=152, STOP=153, SUBSTRING=154, SYNC=155, SYNTAX=156, 
		SYSTEM=157, TABLE=158, TABLES=159, TEMPORARY=160, TEST=161, THEN=162, 
		TIES=163, TIMEOUT=164, TIMESTAMP=165, TO=166, TOP=167, TOTALS=168, TRAILING=169, 
		TRIM=170, TRUNCATE=171, TTL=172, TYPE=173, UNBOUNDED=174, UNION=175, UPDATE=176, 
		USE=177, USING=178, UUID=179, VALUES=180, VIEW=181, VOLUME=182, WATCH=183, 
		WEEK=184, WHEN=185, WHERE=186, WINDOW=187, WITH=188, YEAR=189, JSON_FALSE=190, 
		JSON_TRUE=191, IDENTIFIER=192, FLOATING_LITERAL=193, OCTAL_LITERAL=194, 
		DECIMAL_LITERAL=195, HEXADECIMAL_LITERAL=196, STRING_LITERAL=197, ARROW=198, 
		ASTERISK=199, BACKQUOTE=200, BACKSLASH=201, COLON=202, COMMA=203, CONCAT=204, 
		DASH=205, DOT=206, EQ_DOUBLE=207, EQ_SINGLE=208, GE=209, GT=210, LBRACE=211, 
		LBRACKET=212, LE=213, LPAREN=214, LT=215, NOT_EQ=216, PERCENT=217, PLUS=218, 
		QUERY=219, QUOTE_DOUBLE=220, QUOTE_SINGLE=221, RBRACE=222, RBRACKET=223, 
		RPAREN=224, SEMICOLON=225, SLASH=226, UNDERSCORE=227, MULTI_LINE_COMMENT=228, 
		SINGLE_LINE_COMMENT=229, WHITESPACE=230;
	public const int
		RULE_queryStmt = 0, RULE_query = 1, RULE_alterStmt = 2, RULE_alterTableClause = 3, 
		RULE_addAfterColumnName = 4, RULE_assignmentExprList = 5, RULE_assignmentExpr = 6, 
		RULE_tableColumnPropertyType = 7, RULE_partitionClause = 8, RULE_attachStmt = 9, 
		RULE_checkStmt = 10, RULE_createStmt = 11, RULE_dictionarySchemaClause = 12, 
		RULE_dictionaryAttrDfnt = 13, RULE_dictionaryEngineClause = 14, RULE_dictionaryPrimaryKeyClause = 15, 
		RULE_dictionaryArgExpr = 16, RULE_sourceClause = 17, RULE_lifetimeClause = 18, 
		RULE_layoutClause = 19, RULE_rangeClause = 20, RULE_dictionarySettingsClause = 21, 
		RULE_clusterClause = 22, RULE_uuidClause = 23, RULE_destinationClause = 24, 
		RULE_subqueryClause = 25, RULE_tableSchemaClause = 26, RULE_engineClause = 27, 
		RULE_tableCommentClause = 28, RULE_columnCommentClause = 29, RULE_partitionByClause = 30, 
		RULE_primaryKeyClause = 31, RULE_sampleByClause = 32, RULE_ttlClause = 33, 
		RULE_engineExpr = 34, RULE_tableElementExpr = 35, RULE_tableColumnDfnt = 36, 
		RULE_tableColumnPropertyExpr = 37, RULE_tableIndexDfnt = 38, RULE_tableProjectionDfnt = 39, 
		RULE_codecExpr = 40, RULE_codecArgExpr = 41, RULE_ttlExpr = 42, RULE_describeStmt = 43, 
		RULE_dropStmt = 44, RULE_existsStmt = 45, RULE_explainStmt = 46, RULE_insertStmt = 47, 
		RULE_columnsClause = 48, RULE_dataClause = 49, RULE_killStmt = 50, RULE_optimizeStmt = 51, 
		RULE_renameStmt = 52, RULE_projectionSelectStmt = 53, RULE_selectUnionStmt = 54, 
		RULE_selectStmtWithParens = 55, RULE_selectStmt = 56, RULE_withClause = 57, 
		RULE_topClause = 58, RULE_fromClause = 59, RULE_arrayJoinClause = 60, 
		RULE_windowClause = 61, RULE_prewhereClause = 62, RULE_whereClause = 63, 
		RULE_groupByClause = 64, RULE_havingClause = 65, RULE_orderByClause = 66, 
		RULE_projectionOrderByClause = 67, RULE_limitByClause = 68, RULE_limitClause = 69, 
		RULE_settingsClause = 70, RULE_joinExpr = 71, RULE_joinOp = 72, RULE_joinOpCross = 73, 
		RULE_joinConstraintClause = 74, RULE_sampleClause = 75, RULE_limitExpr = 76, 
		RULE_orderExprList = 77, RULE_orderExpr = 78, RULE_ratioExpr = 79, RULE_settingExprList = 80, 
		RULE_settingExpr = 81, RULE_windowExpr = 82, RULE_winPartitionByClause = 83, 
		RULE_winOrderByClause = 84, RULE_winFrameClause = 85, RULE_winFrameExtend = 86, 
		RULE_winFrameBound = 87, RULE_setStmt = 88, RULE_showStmt = 89, RULE_systemStmt = 90, 
		RULE_truncateStmt = 91, RULE_useStmt = 92, RULE_watchStmt = 93, RULE_columnTypeExpr = 94, 
		RULE_columnExprList = 95, RULE_columnsExpr = 96, RULE_columnExpr = 97, 
		RULE_columnArgList = 98, RULE_columnArgExpr = 99, RULE_columnLambdaExpr = 100, 
		RULE_columnIdentifier = 101, RULE_nestedIdentifier = 102, RULE_tableExpr = 103, 
		RULE_tableFunctionExpr = 104, RULE_tableIdentifier = 105, RULE_tableArgList = 106, 
		RULE_tableArgExpr = 107, RULE_databaseIdentifier = 108, RULE_floatingLiteral = 109, 
		RULE_numberLiteral = 110, RULE_literal = 111, RULE_interval = 112, RULE_keyword = 113, 
		RULE_keywordForAlias = 114, RULE_alias = 115, RULE_identifier = 116, RULE_identifierOrNull = 117, 
		RULE_enumValue = 118;
	public static readonly string[] ruleNames = {
		"queryStmt", "query", "alterStmt", "alterTableClause", "addAfterColumnName", 
		"assignmentExprList", "assignmentExpr", "tableColumnPropertyType", "partitionClause", 
		"attachStmt", "checkStmt", "createStmt", "dictionarySchemaClause", "dictionaryAttrDfnt", 
		"dictionaryEngineClause", "dictionaryPrimaryKeyClause", "dictionaryArgExpr", 
		"sourceClause", "lifetimeClause", "layoutClause", "rangeClause", "dictionarySettingsClause", 
		"clusterClause", "uuidClause", "destinationClause", "subqueryClause", 
		"tableSchemaClause", "engineClause", "tableCommentClause", "columnCommentClause", 
		"partitionByClause", "primaryKeyClause", "sampleByClause", "ttlClause", 
		"engineExpr", "tableElementExpr", "tableColumnDfnt", "tableColumnPropertyExpr", 
		"tableIndexDfnt", "tableProjectionDfnt", "codecExpr", "codecArgExpr", 
		"ttlExpr", "describeStmt", "dropStmt", "existsStmt", "explainStmt", "insertStmt", 
		"columnsClause", "dataClause", "killStmt", "optimizeStmt", "renameStmt", 
		"projectionSelectStmt", "selectUnionStmt", "selectStmtWithParens", "selectStmt", 
		"withClause", "topClause", "fromClause", "arrayJoinClause", "windowClause", 
		"prewhereClause", "whereClause", "groupByClause", "havingClause", "orderByClause", 
		"projectionOrderByClause", "limitByClause", "limitClause", "settingsClause", 
		"joinExpr", "joinOp", "joinOpCross", "joinConstraintClause", "sampleClause", 
		"limitExpr", "orderExprList", "orderExpr", "ratioExpr", "settingExprList", 
		"settingExpr", "windowExpr", "winPartitionByClause", "winOrderByClause", 
		"winFrameClause", "winFrameExtend", "winFrameBound", "setStmt", "showStmt", 
		"systemStmt", "truncateStmt", "useStmt", "watchStmt", "columnTypeExpr", 
		"columnExprList", "columnsExpr", "columnExpr", "columnArgList", "columnArgExpr", 
		"columnLambdaExpr", "columnIdentifier", "nestedIdentifier", "tableExpr", 
		"tableFunctionExpr", "tableIdentifier", "tableArgList", "tableArgExpr", 
		"databaseIdentifier", "floatingLiteral", "numberLiteral", "literal", "interval", 
		"keyword", "keywordForAlias", "alias", "identifier", "identifierOrNull", 
		"enumValue"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "'false'", 
		"'true'", null, null, null, null, null, null, "'->'", "'*'", "'`'", "'\\'", 
		"':'", "','", "'||'", "'-'", "'.'", "'=='", "'='", "'>='", "'>'", "'{'", 
		"'['", "'<='", "'('", "'<'", null, "'%'", "'+'", "'?'", "'\"'", "'''", 
		"'}'", "']'", "')'", "';'", "'/'", "'_'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ADD", "AFTER", "ALIAS", "ALL", "ALTER", "AND", "ANTI", "ANY", "ARRAY", 
		"AS", "ASCENDING", "ASOF", "AST", "ASYNC", "ATTACH", "BETWEEN", "BOTH", 
		"BY", "CASE", "CAST", "CHECK", "CLEAR", "CLUSTER", "CODEC", "COLLATE", 
		"COLUMN", "COMMENT", "CONSTRAINT", "CREATE", "CROSS", "CUBE", "CURRENT", 
		"DATABASE", "DATABASES", "DATE", "DAY", "DEDUPLICATE", "DEFAULT", "DELAY", 
		"DELETE", "DESC", "DESCENDING", "DESCRIBE", "DETACH", "DICTIONARIES", 
		"DICTIONARY", "DISK", "DISTINCT", "DISTRIBUTED", "DROP", "ELSE", "END", 
		"ENGINE", "EVENTS", "EXISTS", "EXPLAIN", "EXPRESSION", "EXTRACT", "FETCHES", 
		"FINAL", "FIRST", "FLUSH", "FOLLOWING", "FOR", "FORMAT", "FREEZE", "FROM", 
		"FULL", "FUNCTION", "GLOBAL", "GRANULARITY", "GROUP", "HAVING", "HIERARCHICAL", 
		"HOUR", "ID", "IF", "ILIKE", "IN", "INDEX", "INF", "INJECTIVE", "INNER", 
		"INSERT", "INTERVAL", "INTO", "IS", "IS_OBJECT_ID", "JOIN", "KEY", "KILL", 
		"LAST", "LAYOUT", "LEADING", "LEFT", "LIFETIME", "LIKE", "LIMIT", "LIVE", 
		"LOCAL", "LOGS", "MATERIALIZE", "MATERIALIZED", "MAX", "MERGES", "MIN", 
		"MINUTE", "MODIFY", "MONTH", "MOVE", "MUTATION", "NAN_SQL", "NO", "NOT", 
		"NULL_SQL", "NULLS", "OFFSET", "ON", "OPTIMIZE", "OR", "ORDER", "OUTER", 
		"OUTFILE", "OVER", "PARTITION", "POPULATE", "PRECEDING", "PREWHERE", "PRIMARY", 
		"PROJECTION", "QUARTER", "RANGE", "RELOAD", "REMOVE", "RENAME", "REPLACE", 
		"REPLICA", "REPLICATED", "RIGHT", "ROLLUP", "ROW", "ROWS", "SAMPLE", "SECOND", 
		"SELECT", "SEMI", "SENDS", "SET", "SETTINGS", "SHOW", "SOURCE", "START", 
		"STOP", "SUBSTRING", "SYNC", "SYNTAX", "SYSTEM", "TABLE", "TABLES", "TEMPORARY", 
		"TEST", "THEN", "TIES", "TIMEOUT", "TIMESTAMP", "TO", "TOP", "TOTALS", 
		"TRAILING", "TRIM", "TRUNCATE", "TTL", "TYPE", "UNBOUNDED", "UNION", "UPDATE", 
		"USE", "USING", "UUID", "VALUES", "VIEW", "VOLUME", "WATCH", "WEEK", "WHEN", 
		"WHERE", "WINDOW", "WITH", "YEAR", "JSON_FALSE", "JSON_TRUE", "IDENTIFIER", 
		"FLOATING_LITERAL", "OCTAL_LITERAL", "DECIMAL_LITERAL", "HEXADECIMAL_LITERAL", 
		"STRING_LITERAL", "ARROW", "ASTERISK", "BACKQUOTE", "BACKSLASH", "COLON", 
		"COMMA", "CONCAT", "DASH", "DOT", "EQ_DOUBLE", "EQ_SINGLE", "GE", "GT", 
		"LBRACE", "LBRACKET", "LE", "LPAREN", "LT", "NOT_EQ", "PERCENT", "PLUS", 
		"QUERY", "QUOTE_DOUBLE", "QUOTE_SINGLE", "RBRACE", "RBRACKET", "RPAREN", 
		"SEMICOLON", "SLASH", "UNDERSCORE", "MULTI_LINE_COMMENT", "SINGLE_LINE_COMMENT", 
		"WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ClickHouseParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public ClickHouseParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class QueryStmtContext : ParserRuleContext {
		public QueryContext query() {
			return GetRuleContext<QueryContext>(0);
		}
		public ITerminalNode INTO() { return GetToken(ClickHouseParser.INTO, 0); }
		public ITerminalNode OUTFILE() { return GetToken(ClickHouseParser.OUTFILE, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode FORMAT() { return GetToken(ClickHouseParser.FORMAT, 0); }
		public IdentifierOrNullContext identifierOrNull() {
			return GetRuleContext<IdentifierOrNullContext>(0);
		}
		public ITerminalNode SEMICOLON() { return GetToken(ClickHouseParser.SEMICOLON, 0); }
		public InsertStmtContext insertStmt() {
			return GetRuleContext<InsertStmtContext>(0);
		}
		public QueryStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_queryStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterQueryStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitQueryStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQueryStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QueryStmtContext queryStmt() {
		QueryStmtContext _localctx = new QueryStmtContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_queryStmt);
		int _la;
		try {
			State = 252;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case ALTER:
			case ATTACH:
			case CHECK:
			case CREATE:
			case DESC:
			case DESCRIBE:
			case DETACH:
			case DROP:
			case EXISTS:
			case EXPLAIN:
			case KILL:
			case OPTIMIZE:
			case RENAME:
			case REPLACE:
			case SELECT:
			case SET:
			case SHOW:
			case SYSTEM:
			case TRUNCATE:
			case USE:
			case WATCH:
			case WITH:
			case LPAREN:
				EnterOuterAlt(_localctx, 1);
				{
				State = 238; query();
				State = 242;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==INTO) {
					{
					State = 239; Match(INTO);
					State = 240; Match(OUTFILE);
					State = 241; Match(STRING_LITERAL);
					}
				}

				State = 246;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==FORMAT) {
					{
					State = 244; Match(FORMAT);
					State = 245; identifierOrNull();
					}
				}

				State = 249;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==SEMICOLON) {
					{
					State = 248; Match(SEMICOLON);
					}
				}

				}
				break;
			case INSERT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 251; insertStmt();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class QueryContext : ParserRuleContext {
		public AlterStmtContext alterStmt() {
			return GetRuleContext<AlterStmtContext>(0);
		}
		public AttachStmtContext attachStmt() {
			return GetRuleContext<AttachStmtContext>(0);
		}
		public CheckStmtContext checkStmt() {
			return GetRuleContext<CheckStmtContext>(0);
		}
		public CreateStmtContext createStmt() {
			return GetRuleContext<CreateStmtContext>(0);
		}
		public DescribeStmtContext describeStmt() {
			return GetRuleContext<DescribeStmtContext>(0);
		}
		public DropStmtContext dropStmt() {
			return GetRuleContext<DropStmtContext>(0);
		}
		public ExistsStmtContext existsStmt() {
			return GetRuleContext<ExistsStmtContext>(0);
		}
		public ExplainStmtContext explainStmt() {
			return GetRuleContext<ExplainStmtContext>(0);
		}
		public KillStmtContext killStmt() {
			return GetRuleContext<KillStmtContext>(0);
		}
		public OptimizeStmtContext optimizeStmt() {
			return GetRuleContext<OptimizeStmtContext>(0);
		}
		public RenameStmtContext renameStmt() {
			return GetRuleContext<RenameStmtContext>(0);
		}
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public SetStmtContext setStmt() {
			return GetRuleContext<SetStmtContext>(0);
		}
		public ShowStmtContext showStmt() {
			return GetRuleContext<ShowStmtContext>(0);
		}
		public SystemStmtContext systemStmt() {
			return GetRuleContext<SystemStmtContext>(0);
		}
		public TruncateStmtContext truncateStmt() {
			return GetRuleContext<TruncateStmtContext>(0);
		}
		public UseStmtContext useStmt() {
			return GetRuleContext<UseStmtContext>(0);
		}
		public WatchStmtContext watchStmt() {
			return GetRuleContext<WatchStmtContext>(0);
		}
		public QueryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterQuery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitQuery(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQuery(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QueryContext query() {
		QueryContext _localctx = new QueryContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_query);
		try {
			State = 272;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 254; alterStmt();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 255; attachStmt();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 256; checkStmt();
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 257; createStmt();
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 258; describeStmt();
				}
				break;

			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 259; dropStmt();
				}
				break;

			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 260; existsStmt();
				}
				break;

			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 261; explainStmt();
				}
				break;

			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 262; killStmt();
				}
				break;

			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 263; optimizeStmt();
				}
				break;

			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 264; renameStmt();
				}
				break;

			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 265; selectUnionStmt();
				}
				break;

			case 13:
				EnterOuterAlt(_localctx, 13);
				{
				State = 266; setStmt();
				}
				break;

			case 14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 267; showStmt();
				}
				break;

			case 15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 268; systemStmt();
				}
				break;

			case 16:
				EnterOuterAlt(_localctx, 16);
				{
				State = 269; truncateStmt();
				}
				break;

			case 17:
				EnterOuterAlt(_localctx, 17);
				{
				State = 270; useStmt();
				}
				break;

			case 18:
				EnterOuterAlt(_localctx, 18);
				{
				State = 271; watchStmt();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AlterStmtContext : ParserRuleContext {
		public AlterStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alterStmt; } }
	 
		public AlterStmtContext() { }
		public virtual void CopyFrom(AlterStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class AlterTableStmtContext : AlterStmtContext {
		public ITerminalNode ALTER() { return GetToken(ClickHouseParser.ALTER, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public AlterTableClauseContext[] alterTableClause() {
			return GetRuleContexts<AlterTableClauseContext>();
		}
		public AlterTableClauseContext alterTableClause(int i) {
			return GetRuleContext<AlterTableClauseContext>(i);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public AlterTableStmtContext(AlterStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AlterStmtContext alterStmt() {
		AlterStmtContext _localctx = new AlterStmtContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_alterStmt);
		int _la;
		try {
			_localctx = new AlterTableStmtContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 274; Match(ALTER);
			State = 275; Match(TABLE);
			State = 276; tableIdentifier();
			State = 278;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 277; clusterClause();
				}
			}

			State = 280; alterTableClause();
			State = 285;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 281; Match(COMMA);
				State = 282; alterTableClause();
				}
				}
				State = 287;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AlterTableClauseContext : ParserRuleContext {
		public AlterTableClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alterTableClause; } }
	 
		public AlterTableClauseContext() { }
		public virtual void CopyFrom(AlterTableClauseContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class AlterTableClauseReplaceContext : AlterTableClauseContext {
		public ITerminalNode REPLACE() { return GetToken(ClickHouseParser.REPLACE, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public AlterTableClauseReplaceContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseReplace(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseReplace(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseReplace(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyOrderByContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode ORDER() { return GetToken(ClickHouseParser.ORDER, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public AlterTableClauseModifyOrderByContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModifyOrderBy(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModifyOrderBy(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModifyOrderBy(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseUpdateContext : AlterTableClauseContext {
		public ITerminalNode UPDATE() { return GetToken(ClickHouseParser.UPDATE, 0); }
		public AssignmentExprListContext assignmentExprList() {
			return GetRuleContext<AssignmentExprListContext>(0);
		}
		public WhereClauseContext whereClause() {
			return GetRuleContext<WhereClauseContext>(0);
		}
		public AlterTableClauseUpdateContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseUpdate(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseUpdate(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseUpdate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseClearProjectionContext : AlterTableClauseContext {
		public ITerminalNode CLEAR() { return GetToken(ClickHouseParser.CLEAR, 0); }
		public ITerminalNode PROJECTION() { return GetToken(ClickHouseParser.PROJECTION, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseClearProjectionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseClearProjection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseClearProjection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseClearProjection(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyRemoveContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode REMOVE() { return GetToken(ClickHouseParser.REMOVE, 0); }
		public TableColumnPropertyTypeContext tableColumnPropertyType() {
			return GetRuleContext<TableColumnPropertyTypeContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseModifyRemoveContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModifyRemove(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModifyRemove(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModifyRemove(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDeleteContext : AlterTableClauseContext {
		public ITerminalNode DELETE() { return GetToken(ClickHouseParser.DELETE, 0); }
		public ITerminalNode WHERE() { return GetToken(ClickHouseParser.WHERE, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public AlterTableClauseDeleteContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDelete(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDelete(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDelete(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseCommentContext : AlterTableClauseContext {
		public ITerminalNode COMMENT() { return GetToken(ClickHouseParser.COMMENT, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseCommentContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseComment(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseComment(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseComment(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDropColumnContext : AlterTableClauseContext {
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseDropColumnContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDropColumn(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDropColumn(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDropColumn(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDetachContext : AlterTableClauseContext {
		public ITerminalNode DETACH() { return GetToken(ClickHouseParser.DETACH, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseDetachContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDetach(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDetach(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDetach(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseAddIndexContext : AlterTableClauseContext {
		public ITerminalNode ADD() { return GetToken(ClickHouseParser.ADD, 0); }
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public TableIndexDfntContext tableIndexDfnt() {
			return GetRuleContext<TableIndexDfntContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode AFTER() { return GetToken(ClickHouseParser.AFTER, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public AlterTableClauseAddIndexContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseAddIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseAddIndex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseAddIndex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDropPartitionContext : AlterTableClauseContext {
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseDropPartitionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDropPartition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDropPartition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDropPartition(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseMaterializeIndexContext : AlterTableClauseContext {
		public ITerminalNode MATERIALIZE() { return GetToken(ClickHouseParser.MATERIALIZE, 0); }
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseMaterializeIndexContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseMaterializeIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseMaterializeIndex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseMaterializeIndex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseMaterializeProjectionContext : AlterTableClauseContext {
		public ITerminalNode MATERIALIZE() { return GetToken(ClickHouseParser.MATERIALIZE, 0); }
		public ITerminalNode PROJECTION() { return GetToken(ClickHouseParser.PROJECTION, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseMaterializeProjectionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseMaterializeProjection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseMaterializeProjection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseMaterializeProjection(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseMovePartitionContext : AlterTableClauseContext {
		public ITerminalNode MOVE() { return GetToken(ClickHouseParser.MOVE, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public ITerminalNode TO() { return GetToken(ClickHouseParser.TO, 0); }
		public ITerminalNode DISK() { return GetToken(ClickHouseParser.DISK, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode VOLUME() { return GetToken(ClickHouseParser.VOLUME, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public AlterTableClauseMovePartitionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseMovePartition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseMovePartition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseMovePartition(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseRenameContext : AlterTableClauseContext {
		public ITerminalNode RENAME() { return GetToken(ClickHouseParser.RENAME, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext[] nestedIdentifier() {
			return GetRuleContexts<NestedIdentifierContext>();
		}
		public NestedIdentifierContext nestedIdentifier(int i) {
			return GetRuleContext<NestedIdentifierContext>(i);
		}
		public ITerminalNode TO() { return GetToken(ClickHouseParser.TO, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseRenameContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseRename(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseRename(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseRename(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseFreezePartitionContext : AlterTableClauseContext {
		public ITerminalNode FREEZE() { return GetToken(ClickHouseParser.FREEZE, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseFreezePartitionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseFreezePartition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseFreezePartition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseFreezePartition(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseClearColumnContext : AlterTableClauseContext {
		public ITerminalNode CLEAR() { return GetToken(ClickHouseParser.CLEAR, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseClearColumnContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseClearColumn(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseClearColumn(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseClearColumn(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public TableColumnDfntContext tableColumnDfnt() {
			return GetRuleContext<TableColumnDfntContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseModifyContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModify(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModify(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModify(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseClearIndexContext : AlterTableClauseContext {
		public ITerminalNode CLEAR() { return GetToken(ClickHouseParser.CLEAR, 0); }
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public AlterTableClauseClearIndexContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseClearIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseClearIndex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseClearIndex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseRemoveTTLContext : AlterTableClauseContext {
		public ITerminalNode REMOVE() { return GetToken(ClickHouseParser.REMOVE, 0); }
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public AlterTableClauseRemoveTTLContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseRemoveTTL(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseRemoveTTL(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseRemoveTTL(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyCodecContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public CodecExprContext codecExpr() {
			return GetRuleContext<CodecExprContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseModifyCodecContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModifyCodec(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModifyCodec(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModifyCodec(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseAttachContext : AlterTableClauseContext {
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public AlterTableClauseAttachContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseAttach(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseAttach(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseAttach(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDropProjectionContext : AlterTableClauseContext {
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode PROJECTION() { return GetToken(ClickHouseParser.PROJECTION, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseDropProjectionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDropProjection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDropProjection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDropProjection(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseDropIndexContext : AlterTableClauseContext {
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseDropIndexContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseDropIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseDropIndex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseDropIndex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyCommentContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ColumnCommentClauseContext columnCommentClause() {
			return GetRuleContext<ColumnCommentClauseContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AlterTableClauseModifyCommentContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModifyComment(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModifyComment(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModifyComment(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseModifyTTLContext : AlterTableClauseContext {
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public TtlClauseContext ttlClause() {
			return GetRuleContext<TtlClauseContext>(0);
		}
		public AlterTableClauseModifyTTLContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseModifyTTL(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseModifyTTL(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseModifyTTL(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseAddProjectionContext : AlterTableClauseContext {
		public ITerminalNode ADD() { return GetToken(ClickHouseParser.ADD, 0); }
		public ITerminalNode PROJECTION() { return GetToken(ClickHouseParser.PROJECTION, 0); }
		public TableProjectionDfntContext tableProjectionDfnt() {
			return GetRuleContext<TableProjectionDfntContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode AFTER() { return GetToken(ClickHouseParser.AFTER, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public AlterTableClauseAddProjectionContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseAddProjection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseAddProjection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseAddProjection(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AlterTableClauseAddColumnContext : AlterTableClauseContext {
		public ITerminalNode ADD() { return GetToken(ClickHouseParser.ADD, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public TableColumnDfntContext tableColumnDfnt() {
			return GetRuleContext<TableColumnDfntContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public AddAfterColumnNameContext addAfterColumnName() {
			return GetRuleContext<AddAfterColumnNameContext>(0);
		}
		public AlterTableClauseAddColumnContext(AlterTableClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlterTableClauseAddColumn(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlterTableClauseAddColumn(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlterTableClauseAddColumn(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AlterTableClauseContext alterTableClause() {
		AlterTableClauseContext _localctx = new AlterTableClauseContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_alterTableClause);
		int _la;
		try {
			State = 500;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,35,_ctx) ) {
			case 1:
				_localctx = new AlterTableClauseAddColumnContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 288; Match(ADD);
				State = 289; Match(COLUMN);
				State = 293;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,7,_ctx) ) {
				case 1:
					{
					State = 290; Match(IF);
					State = 291; Match(NOT);
					State = 292; Match(EXISTS);
					}
					break;
				}
				State = 295; tableColumnDfnt();
				State = 297;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==AFTER) {
					{
					State = 296; addAfterColumnName();
					}
				}

				}
				break;

			case 2:
				_localctx = new AlterTableClauseAddIndexContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 299; Match(ADD);
				State = 300; Match(INDEX);
				State = 304;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,9,_ctx) ) {
				case 1:
					{
					State = 301; Match(IF);
					State = 302; Match(NOT);
					State = 303; Match(EXISTS);
					}
					break;
				}
				State = 306; tableIndexDfnt();
				State = 309;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==AFTER) {
					{
					State = 307; Match(AFTER);
					State = 308; nestedIdentifier();
					}
				}

				}
				break;

			case 3:
				_localctx = new AlterTableClauseAddProjectionContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 311; Match(ADD);
				State = 312; Match(PROJECTION);
				State = 316;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,11,_ctx) ) {
				case 1:
					{
					State = 313; Match(IF);
					State = 314; Match(NOT);
					State = 315; Match(EXISTS);
					}
					break;
				}
				State = 318; tableProjectionDfnt();
				State = 321;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==AFTER) {
					{
					State = 319; Match(AFTER);
					State = 320; nestedIdentifier();
					}
				}

				}
				break;

			case 4:
				_localctx = new AlterTableClauseAttachContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 323; Match(ATTACH);
				State = 324; partitionClause();
				State = 327;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==FROM) {
					{
					State = 325; Match(FROM);
					State = 326; tableIdentifier();
					}
				}

				}
				break;

			case 5:
				_localctx = new AlterTableClauseClearColumnContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 329; Match(CLEAR);
				State = 330; Match(COLUMN);
				State = 333;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,14,_ctx) ) {
				case 1:
					{
					State = 331; Match(IF);
					State = 332; Match(EXISTS);
					}
					break;
				}
				State = 335; nestedIdentifier();
				State = 338;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IN) {
					{
					State = 336; Match(IN);
					State = 337; partitionClause();
					}
				}

				}
				break;

			case 6:
				_localctx = new AlterTableClauseClearIndexContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 340; Match(CLEAR);
				State = 341; Match(INDEX);
				State = 344;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,16,_ctx) ) {
				case 1:
					{
					State = 342; Match(IF);
					State = 343; Match(EXISTS);
					}
					break;
				}
				State = 346; nestedIdentifier();
				State = 349;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IN) {
					{
					State = 347; Match(IN);
					State = 348; partitionClause();
					}
				}

				}
				break;

			case 7:
				_localctx = new AlterTableClauseClearProjectionContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 351; Match(CLEAR);
				State = 352; Match(PROJECTION);
				State = 355;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,18,_ctx) ) {
				case 1:
					{
					State = 353; Match(IF);
					State = 354; Match(EXISTS);
					}
					break;
				}
				State = 357; nestedIdentifier();
				State = 360;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IN) {
					{
					State = 358; Match(IN);
					State = 359; partitionClause();
					}
				}

				}
				break;

			case 8:
				_localctx = new AlterTableClauseCommentContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 362; Match(COMMENT);
				State = 363; Match(COLUMN);
				State = 366;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,20,_ctx) ) {
				case 1:
					{
					State = 364; Match(IF);
					State = 365; Match(EXISTS);
					}
					break;
				}
				State = 368; nestedIdentifier();
				State = 369; Match(STRING_LITERAL);
				}
				break;

			case 9:
				_localctx = new AlterTableClauseDeleteContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 371; Match(DELETE);
				State = 372; Match(WHERE);
				State = 373; columnExpr(0);
				}
				break;

			case 10:
				_localctx = new AlterTableClauseDetachContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 374; Match(DETACH);
				State = 375; partitionClause();
				}
				break;

			case 11:
				_localctx = new AlterTableClauseDropColumnContext(_localctx);
				EnterOuterAlt(_localctx, 11);
				{
				State = 376; Match(DROP);
				State = 377; Match(COLUMN);
				State = 380;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,21,_ctx) ) {
				case 1:
					{
					State = 378; Match(IF);
					State = 379; Match(EXISTS);
					}
					break;
				}
				State = 382; nestedIdentifier();
				}
				break;

			case 12:
				_localctx = new AlterTableClauseDropIndexContext(_localctx);
				EnterOuterAlt(_localctx, 12);
				{
				State = 383; Match(DROP);
				State = 384; Match(INDEX);
				State = 387;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,22,_ctx) ) {
				case 1:
					{
					State = 385; Match(IF);
					State = 386; Match(EXISTS);
					}
					break;
				}
				State = 389; nestedIdentifier();
				}
				break;

			case 13:
				_localctx = new AlterTableClauseDropProjectionContext(_localctx);
				EnterOuterAlt(_localctx, 13);
				{
				State = 390; Match(DROP);
				State = 391; Match(PROJECTION);
				State = 394;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,23,_ctx) ) {
				case 1:
					{
					State = 392; Match(IF);
					State = 393; Match(EXISTS);
					}
					break;
				}
				State = 396; nestedIdentifier();
				}
				break;

			case 14:
				_localctx = new AlterTableClauseDropPartitionContext(_localctx);
				EnterOuterAlt(_localctx, 14);
				{
				State = 397; Match(DROP);
				State = 398; partitionClause();
				}
				break;

			case 15:
				_localctx = new AlterTableClauseFreezePartitionContext(_localctx);
				EnterOuterAlt(_localctx, 15);
				{
				State = 399; Match(FREEZE);
				State = 401;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==PARTITION) {
					{
					State = 400; partitionClause();
					}
				}

				}
				break;

			case 16:
				_localctx = new AlterTableClauseMaterializeIndexContext(_localctx);
				EnterOuterAlt(_localctx, 16);
				{
				State = 403; Match(MATERIALIZE);
				State = 404; Match(INDEX);
				State = 407;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,25,_ctx) ) {
				case 1:
					{
					State = 405; Match(IF);
					State = 406; Match(EXISTS);
					}
					break;
				}
				State = 409; nestedIdentifier();
				State = 412;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IN) {
					{
					State = 410; Match(IN);
					State = 411; partitionClause();
					}
				}

				}
				break;

			case 17:
				_localctx = new AlterTableClauseMaterializeProjectionContext(_localctx);
				EnterOuterAlt(_localctx, 17);
				{
				State = 414; Match(MATERIALIZE);
				State = 415; Match(PROJECTION);
				State = 418;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,27,_ctx) ) {
				case 1:
					{
					State = 416; Match(IF);
					State = 417; Match(EXISTS);
					}
					break;
				}
				State = 420; nestedIdentifier();
				State = 423;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==IN) {
					{
					State = 421; Match(IN);
					State = 422; partitionClause();
					}
				}

				}
				break;

			case 18:
				_localctx = new AlterTableClauseModifyCodecContext(_localctx);
				EnterOuterAlt(_localctx, 18);
				{
				State = 425; Match(MODIFY);
				State = 426; Match(COLUMN);
				State = 429;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,29,_ctx) ) {
				case 1:
					{
					State = 427; Match(IF);
					State = 428; Match(EXISTS);
					}
					break;
				}
				State = 431; nestedIdentifier();
				State = 432; codecExpr();
				}
				break;

			case 19:
				_localctx = new AlterTableClauseModifyCommentContext(_localctx);
				EnterOuterAlt(_localctx, 19);
				{
				State = 434; Match(MODIFY);
				State = 435; Match(COLUMN);
				State = 438;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,30,_ctx) ) {
				case 1:
					{
					State = 436; Match(IF);
					State = 437; Match(EXISTS);
					}
					break;
				}
				State = 440; nestedIdentifier();
				State = 441; columnCommentClause();
				}
				break;

			case 20:
				_localctx = new AlterTableClauseModifyRemoveContext(_localctx);
				EnterOuterAlt(_localctx, 20);
				{
				State = 443; Match(MODIFY);
				State = 444; Match(COLUMN);
				State = 447;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,31,_ctx) ) {
				case 1:
					{
					State = 445; Match(IF);
					State = 446; Match(EXISTS);
					}
					break;
				}
				State = 449; nestedIdentifier();
				State = 450; Match(REMOVE);
				State = 451; tableColumnPropertyType();
				}
				break;

			case 21:
				_localctx = new AlterTableClauseModifyContext(_localctx);
				EnterOuterAlt(_localctx, 21);
				{
				State = 453; Match(MODIFY);
				State = 454; Match(COLUMN);
				State = 457;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,32,_ctx) ) {
				case 1:
					{
					State = 455; Match(IF);
					State = 456; Match(EXISTS);
					}
					break;
				}
				State = 459; tableColumnDfnt();
				}
				break;

			case 22:
				_localctx = new AlterTableClauseModifyOrderByContext(_localctx);
				EnterOuterAlt(_localctx, 22);
				{
				State = 460; Match(MODIFY);
				State = 461; Match(ORDER);
				State = 462; Match(BY);
				State = 463; columnExpr(0);
				}
				break;

			case 23:
				_localctx = new AlterTableClauseModifyTTLContext(_localctx);
				EnterOuterAlt(_localctx, 23);
				{
				State = 464; Match(MODIFY);
				State = 465; ttlClause();
				}
				break;

			case 24:
				_localctx = new AlterTableClauseMovePartitionContext(_localctx);
				EnterOuterAlt(_localctx, 24);
				{
				State = 466; Match(MOVE);
				State = 467; partitionClause();
				State = 477;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,33,_ctx) ) {
				case 1:
					{
					State = 468; Match(TO);
					State = 469; Match(DISK);
					State = 470; Match(STRING_LITERAL);
					}
					break;

				case 2:
					{
					State = 471; Match(TO);
					State = 472; Match(VOLUME);
					State = 473; Match(STRING_LITERAL);
					}
					break;

				case 3:
					{
					State = 474; Match(TO);
					State = 475; Match(TABLE);
					State = 476; tableIdentifier();
					}
					break;
				}
				}
				break;

			case 25:
				_localctx = new AlterTableClauseRemoveTTLContext(_localctx);
				EnterOuterAlt(_localctx, 25);
				{
				State = 479; Match(REMOVE);
				State = 480; Match(TTL);
				}
				break;

			case 26:
				_localctx = new AlterTableClauseRenameContext(_localctx);
				EnterOuterAlt(_localctx, 26);
				{
				State = 481; Match(RENAME);
				State = 482; Match(COLUMN);
				State = 485;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,34,_ctx) ) {
				case 1:
					{
					State = 483; Match(IF);
					State = 484; Match(EXISTS);
					}
					break;
				}
				State = 487; nestedIdentifier();
				State = 488; Match(TO);
				State = 489; nestedIdentifier();
				}
				break;

			case 27:
				_localctx = new AlterTableClauseReplaceContext(_localctx);
				EnterOuterAlt(_localctx, 27);
				{
				State = 491; Match(REPLACE);
				State = 492; partitionClause();
				State = 493; Match(FROM);
				State = 494; tableIdentifier();
				}
				break;

			case 28:
				_localctx = new AlterTableClauseUpdateContext(_localctx);
				EnterOuterAlt(_localctx, 28);
				{
				State = 496; Match(UPDATE);
				State = 497; assignmentExprList();
				State = 498; whereClause();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AddAfterColumnNameContext : ParserRuleContext {
		public ITerminalNode AFTER() { return GetToken(ClickHouseParser.AFTER, 0); }
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public AddAfterColumnNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_addAfterColumnName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAddAfterColumnName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAddAfterColumnName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddAfterColumnName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AddAfterColumnNameContext addAfterColumnName() {
		AddAfterColumnNameContext _localctx = new AddAfterColumnNameContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_addAfterColumnName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 502; Match(AFTER);
			State = 503; nestedIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentExprListContext : ParserRuleContext {
		public AssignmentExprContext[] assignmentExpr() {
			return GetRuleContexts<AssignmentExprContext>();
		}
		public AssignmentExprContext assignmentExpr(int i) {
			return GetRuleContext<AssignmentExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public AssignmentExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentExprList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAssignmentExprList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAssignmentExprList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignmentExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentExprListContext assignmentExprList() {
		AssignmentExprListContext _localctx = new AssignmentExprListContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_assignmentExprList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 505; assignmentExpr();
			State = 510;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 506; Match(COMMA);
				State = 507; assignmentExpr();
				}
				}
				State = 512;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentExprContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ITerminalNode EQ_SINGLE() { return GetToken(ClickHouseParser.EQ_SINGLE, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public AssignmentExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAssignmentExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAssignmentExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignmentExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentExprContext assignmentExpr() {
		AssignmentExprContext _localctx = new AssignmentExprContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_assignmentExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 513; nestedIdentifier();
			State = 514; Match(EQ_SINGLE);
			State = 515; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableColumnPropertyTypeContext : ParserRuleContext {
		public ITerminalNode ALIAS() { return GetToken(ClickHouseParser.ALIAS, 0); }
		public ITerminalNode CODEC() { return GetToken(ClickHouseParser.CODEC, 0); }
		public ITerminalNode COMMENT() { return GetToken(ClickHouseParser.COMMENT, 0); }
		public ITerminalNode DEFAULT() { return GetToken(ClickHouseParser.DEFAULT, 0); }
		public ITerminalNode MATERIALIZED() { return GetToken(ClickHouseParser.MATERIALIZED, 0); }
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public TableColumnPropertyTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableColumnPropertyType; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableColumnPropertyType(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableColumnPropertyType(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableColumnPropertyType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableColumnPropertyTypeContext tableColumnPropertyType() {
		TableColumnPropertyTypeContext _localctx = new TableColumnPropertyTypeContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_tableColumnPropertyType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 517;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALIAS) | (1L << CODEC) | (1L << COMMENT) | (1L << DEFAULT))) != 0) || _la==MATERIALIZED || _la==TTL) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PartitionClauseContext : ParserRuleContext {
		public ITerminalNode PARTITION() { return GetToken(ClickHouseParser.PARTITION, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode ID() { return GetToken(ClickHouseParser.ID, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public PartitionClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_partitionClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterPartitionClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitPartitionClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPartitionClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PartitionClauseContext partitionClause() {
		PartitionClauseContext _localctx = new PartitionClauseContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_partitionClause);
		try {
			State = 524;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,37,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 519; Match(PARTITION);
				State = 520; columnExpr(0);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 521; Match(PARTITION);
				State = 522; Match(ID);
				State = 523; Match(STRING_LITERAL);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AttachStmtContext : ParserRuleContext {
		public AttachStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attachStmt; } }
	 
		public AttachStmtContext() { }
		public virtual void CopyFrom(AttachStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class AttachDictionaryStmtContext : AttachStmtContext {
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public AttachDictionaryStmtContext(AttachStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAttachDictionaryStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAttachDictionaryStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAttachDictionaryStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AttachStmtContext attachStmt() {
		AttachStmtContext _localctx = new AttachStmtContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_attachStmt);
		int _la;
		try {
			_localctx = new AttachDictionaryStmtContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 526; Match(ATTACH);
			State = 527; Match(DICTIONARY);
			State = 528; tableIdentifier();
			State = 530;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 529; clusterClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CheckStmtContext : ParserRuleContext {
		public ITerminalNode CHECK() { return GetToken(ClickHouseParser.CHECK, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public CheckStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checkStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCheckStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCheckStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCheckStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CheckStmtContext checkStmt() {
		CheckStmtContext _localctx = new CheckStmtContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_checkStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 532; Match(CHECK);
			State = 533; Match(TABLE);
			State = 534; tableIdentifier();
			State = 536;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==PARTITION) {
				{
				State = 535; partitionClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CreateStmtContext : ParserRuleContext {
		public CreateStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_createStmt; } }
	 
		public CreateStmtContext() { }
		public virtual void CopyFrom(CreateStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CreateViewStmtContext : CreateStmtContext {
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public SubqueryClauseContext subqueryClause() {
			return GetRuleContext<SubqueryClauseContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode OR() { return GetToken(ClickHouseParser.OR, 0); }
		public ITerminalNode REPLACE() { return GetToken(ClickHouseParser.REPLACE, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public UuidClauseContext uuidClause() {
			return GetRuleContext<UuidClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public TableSchemaClauseContext tableSchemaClause() {
			return GetRuleContext<TableSchemaClauseContext>(0);
		}
		public CreateViewStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateViewStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateViewStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateViewStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CreateDictionaryStmtContext : CreateStmtContext {
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public DictionarySchemaClauseContext dictionarySchemaClause() {
			return GetRuleContext<DictionarySchemaClauseContext>(0);
		}
		public DictionaryEngineClauseContext dictionaryEngineClause() {
			return GetRuleContext<DictionaryEngineClauseContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode REPLACE() { return GetToken(ClickHouseParser.REPLACE, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public UuidClauseContext uuidClause() {
			return GetRuleContext<UuidClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public ITerminalNode OR() { return GetToken(ClickHouseParser.OR, 0); }
		public CreateDictionaryStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateDictionaryStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateDictionaryStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateDictionaryStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CreateDatabaseStmtContext : CreateStmtContext {
		public ITerminalNode DATABASE() { return GetToken(ClickHouseParser.DATABASE, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public EngineExprContext engineExpr() {
			return GetRuleContext<EngineExprContext>(0);
		}
		public CreateDatabaseStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateDatabaseStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateDatabaseStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateDatabaseStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CreateLiveViewStmtContext : CreateStmtContext {
		public ITerminalNode LIVE() { return GetToken(ClickHouseParser.LIVE, 0); }
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public SubqueryClauseContext subqueryClause() {
			return GetRuleContext<SubqueryClauseContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public UuidClauseContext uuidClause() {
			return GetRuleContext<UuidClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public ITerminalNode WITH() { return GetToken(ClickHouseParser.WITH, 0); }
		public ITerminalNode TIMEOUT() { return GetToken(ClickHouseParser.TIMEOUT, 0); }
		public DestinationClauseContext destinationClause() {
			return GetRuleContext<DestinationClauseContext>(0);
		}
		public TableSchemaClauseContext tableSchemaClause() {
			return GetRuleContext<TableSchemaClauseContext>(0);
		}
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public CreateLiveViewStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateLiveViewStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateLiveViewStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateLiveViewStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CreateMaterializedViewStmtContext : CreateStmtContext {
		public ITerminalNode MATERIALIZED() { return GetToken(ClickHouseParser.MATERIALIZED, 0); }
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public SubqueryClauseContext subqueryClause() {
			return GetRuleContext<SubqueryClauseContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public DestinationClauseContext destinationClause() {
			return GetRuleContext<DestinationClauseContext>(0);
		}
		public EngineClauseContext engineClause() {
			return GetRuleContext<EngineClauseContext>(0);
		}
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public UuidClauseContext uuidClause() {
			return GetRuleContext<UuidClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public TableSchemaClauseContext tableSchemaClause() {
			return GetRuleContext<TableSchemaClauseContext>(0);
		}
		public ITerminalNode POPULATE() { return GetToken(ClickHouseParser.POPULATE, 0); }
		public CreateMaterializedViewStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateMaterializedViewStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateMaterializedViewStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateMaterializedViewStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CreateTableStmtContext : CreateStmtContext {
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode REPLACE() { return GetToken(ClickHouseParser.REPLACE, 0); }
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public UuidClauseContext uuidClause() {
			return GetRuleContext<UuidClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public TableSchemaClauseContext tableSchemaClause() {
			return GetRuleContext<TableSchemaClauseContext>(0);
		}
		public EngineClauseContext engineClause() {
			return GetRuleContext<EngineClauseContext>(0);
		}
		public SubqueryClauseContext subqueryClause() {
			return GetRuleContext<SubqueryClauseContext>(0);
		}
		public TableCommentClauseContext tableCommentClause() {
			return GetRuleContext<TableCommentClauseContext>(0);
		}
		public ITerminalNode OR() { return GetToken(ClickHouseParser.OR, 0); }
		public CreateTableStmtContext(CreateStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCreateTableStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCreateTableStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCreateTableStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CreateStmtContext createStmt() {
		CreateStmtContext _localctx = new CreateStmtContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_createStmt);
		int _la;
		try {
			State = 694;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,76,_ctx) ) {
			case 1:
				_localctx = new CreateDatabaseStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 538;
				_la = _input.La(1);
				if ( !(_la==ATTACH || _la==CREATE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 539; Match(DATABASE);
				State = 543;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,40,_ctx) ) {
				case 1:
					{
					State = 540; Match(IF);
					State = 541; Match(NOT);
					State = 542; Match(EXISTS);
					}
					break;
				}
				State = 545; databaseIdentifier();
				State = 547;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 546; clusterClause();
					}
				}

				State = 550;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ENGINE) {
					{
					State = 549; engineExpr();
					}
				}

				}
				break;

			case 2:
				_localctx = new CreateDictionaryStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 559;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case ATTACH:
					{
					State = 552; Match(ATTACH);
					}
					break;
				case CREATE:
					{
					State = 553; Match(CREATE);
					State = 556;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OR) {
						{
						State = 554; Match(OR);
						State = 555; Match(REPLACE);
						}
					}

					}
					break;
				case REPLACE:
					{
					State = 558; Match(REPLACE);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 561; Match(DICTIONARY);
				State = 565;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,45,_ctx) ) {
				case 1:
					{
					State = 562; Match(IF);
					State = 563; Match(NOT);
					State = 564; Match(EXISTS);
					}
					break;
				}
				State = 567; tableIdentifier();
				State = 569;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==UUID) {
					{
					State = 568; uuidClause();
					}
				}

				State = 572;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 571; clusterClause();
					}
				}

				State = 574; dictionarySchemaClause();
				State = 575; dictionaryEngineClause();
				}
				break;

			case 3:
				_localctx = new CreateLiveViewStmtContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 577;
				_la = _input.La(1);
				if ( !(_la==ATTACH || _la==CREATE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 578; Match(LIVE);
				State = 579; Match(VIEW);
				State = 583;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,48,_ctx) ) {
				case 1:
					{
					State = 580; Match(IF);
					State = 581; Match(NOT);
					State = 582; Match(EXISTS);
					}
					break;
				}
				State = 585; tableIdentifier();
				State = 587;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==UUID) {
					{
					State = 586; uuidClause();
					}
				}

				State = 590;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 589; clusterClause();
					}
				}

				State = 597;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==WITH) {
					{
					State = 592; Match(WITH);
					State = 593; Match(TIMEOUT);
					State = 595;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==DECIMAL_LITERAL) {
						{
						State = 594; Match(DECIMAL_LITERAL);
						}
					}

					}
				}

				State = 600;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==TO) {
					{
					State = 599; destinationClause();
					}
				}

				State = 603;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,54,_ctx) ) {
				case 1:
					{
					State = 602; tableSchemaClause();
					}
					break;
				}
				State = 605; subqueryClause();
				}
				break;

			case 4:
				_localctx = new CreateMaterializedViewStmtContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 607;
				_la = _input.La(1);
				if ( !(_la==ATTACH || _la==CREATE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 608; Match(MATERIALIZED);
				State = 609; Match(VIEW);
				State = 613;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,55,_ctx) ) {
				case 1:
					{
					State = 610; Match(IF);
					State = 611; Match(NOT);
					State = 612; Match(EXISTS);
					}
					break;
				}
				State = 615; tableIdentifier();
				State = 617;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==UUID) {
					{
					State = 616; uuidClause();
					}
				}

				State = 620;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 619; clusterClause();
					}
				}

				State = 623;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==AS || _la==LPAREN) {
					{
					State = 622; tableSchemaClause();
					}
				}

				State = 630;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case TO:
					{
					State = 625; destinationClause();
					}
					break;
				case ENGINE:
					{
					State = 626; engineClause();
					State = 628;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==POPULATE) {
						{
						State = 627; Match(POPULATE);
						}
					}

					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 632; subqueryClause();
				}
				break;

			case 5:
				_localctx = new CreateTableStmtContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 641;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case ATTACH:
					{
					State = 634; Match(ATTACH);
					}
					break;
				case CREATE:
					{
					State = 635; Match(CREATE);
					State = 638;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OR) {
						{
						State = 636; Match(OR);
						State = 637; Match(REPLACE);
						}
					}

					}
					break;
				case REPLACE:
					{
					State = 640; Match(REPLACE);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 644;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==TEMPORARY) {
					{
					State = 643; Match(TEMPORARY);
					}
				}

				State = 646; Match(TABLE);
				State = 650;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,64,_ctx) ) {
				case 1:
					{
					State = 647; Match(IF);
					State = 648; Match(NOT);
					State = 649; Match(EXISTS);
					}
					break;
				}
				State = 652; tableIdentifier();
				State = 654;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==UUID) {
					{
					State = 653; uuidClause();
					}
				}

				State = 657;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 656; clusterClause();
					}
				}

				State = 660;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,67,_ctx) ) {
				case 1:
					{
					State = 659; tableSchemaClause();
					}
					break;
				}
				State = 663;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ENGINE) {
					{
					State = 662; engineClause();
					}
				}

				State = 666;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==AS) {
					{
					State = 665; subqueryClause();
					}
				}

				State = 669;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==COMMENT) {
					{
					State = 668; tableCommentClause();
					}
				}

				}
				break;

			case 6:
				_localctx = new CreateViewStmtContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 671;
				_la = _input.La(1);
				if ( !(_la==ATTACH || _la==CREATE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 674;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==OR) {
					{
					State = 672; Match(OR);
					State = 673; Match(REPLACE);
					}
				}

				State = 676; Match(VIEW);
				State = 680;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,72,_ctx) ) {
				case 1:
					{
					State = 677; Match(IF);
					State = 678; Match(NOT);
					State = 679; Match(EXISTS);
					}
					break;
				}
				State = 682; tableIdentifier();
				State = 684;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==UUID) {
					{
					State = 683; uuidClause();
					}
				}

				State = 687;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 686; clusterClause();
					}
				}

				State = 690;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,75,_ctx) ) {
				case 1:
					{
					State = 689; tableSchemaClause();
					}
					break;
				}
				State = 692; subqueryClause();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionarySchemaClauseContext : ParserRuleContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public DictionaryAttrDfntContext[] dictionaryAttrDfnt() {
			return GetRuleContexts<DictionaryAttrDfntContext>();
		}
		public DictionaryAttrDfntContext dictionaryAttrDfnt(int i) {
			return GetRuleContext<DictionaryAttrDfntContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public DictionarySchemaClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionarySchemaClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionarySchemaClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionarySchemaClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionarySchemaClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionarySchemaClauseContext dictionarySchemaClause() {
		DictionarySchemaClauseContext _localctx = new DictionarySchemaClauseContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_dictionarySchemaClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 696; Match(LPAREN);
			State = 697; dictionaryAttrDfnt();
			State = 702;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 698; Match(COMMA);
				State = 699; dictionaryAttrDfnt();
				}
				}
				State = 704;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 705; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionaryAttrDfntContext : ParserRuleContext {
		public Dictionary<string> attrs = new Dictionary<string>();
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ColumnTypeExprContext columnTypeExpr() {
			return GetRuleContext<ColumnTypeExprContext>(0);
		}
		public ITerminalNode[] DEFAULT() { return GetTokens(ClickHouseParser.DEFAULT); }
		public ITerminalNode DEFAULT(int i) {
			return GetToken(ClickHouseParser.DEFAULT, i);
		}
		public LiteralContext[] literal() {
			return GetRuleContexts<LiteralContext>();
		}
		public LiteralContext literal(int i) {
			return GetRuleContext<LiteralContext>(i);
		}
		public ITerminalNode[] EXPRESSION() { return GetTokens(ClickHouseParser.EXPRESSION); }
		public ITerminalNode EXPRESSION(int i) {
			return GetToken(ClickHouseParser.EXPRESSION, i);
		}
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode[] HIERARCHICAL() { return GetTokens(ClickHouseParser.HIERARCHICAL); }
		public ITerminalNode HIERARCHICAL(int i) {
			return GetToken(ClickHouseParser.HIERARCHICAL, i);
		}
		public ITerminalNode[] INJECTIVE() { return GetTokens(ClickHouseParser.INJECTIVE); }
		public ITerminalNode INJECTIVE(int i) {
			return GetToken(ClickHouseParser.INJECTIVE, i);
		}
		public ITerminalNode[] IS_OBJECT_ID() { return GetTokens(ClickHouseParser.IS_OBJECT_ID); }
		public ITerminalNode IS_OBJECT_ID(int i) {
			return GetToken(ClickHouseParser.IS_OBJECT_ID, i);
		}
		public DictionaryAttrDfntContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionaryAttrDfnt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionaryAttrDfnt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionaryAttrDfnt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionaryAttrDfnt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionaryAttrDfntContext dictionaryAttrDfnt() {
		DictionaryAttrDfntContext _localctx = new DictionaryAttrDfntContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_dictionaryAttrDfnt);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 707; identifier();
			State = 708; columnTypeExpr();
			State = 730;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,79,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					State = 728;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,78,_ctx) ) {
					case 1:
						{
						State = 709;
						if (!(!_localctx.attrs.count("default"))) throw new FailedPredicateException(this, "!$attrs.count(\"default\")");
						State = 710; Match(DEFAULT);
						State = 711; literal();
						_localctx.attrs.insert("default");
						}
						break;

					case 2:
						{
						State = 714;
						if (!(!_localctx.attrs.count("expression"))) throw new FailedPredicateException(this, "!$attrs.count(\"expression\")");
						State = 715; Match(EXPRESSION);
						State = 716; columnExpr(0);
						_localctx.attrs.insert("expression");
						}
						break;

					case 3:
						{
						State = 719;
						if (!(!_localctx.attrs.count("hierarchical"))) throw new FailedPredicateException(this, "!$attrs.count(\"hierarchical\")");
						State = 720; Match(HIERARCHICAL);
						_localctx.attrs.insert("hierarchical");
						}
						break;

					case 4:
						{
						State = 722;
						if (!(!_localctx.attrs.count("injective"))) throw new FailedPredicateException(this, "!$attrs.count(\"injective\")");
						State = 723; Match(INJECTIVE);
						_localctx.attrs.insert("injective");
						}
						break;

					case 5:
						{
						State = 725;
						if (!(!_localctx.attrs.count("is_object_id"))) throw new FailedPredicateException(this, "!$attrs.count(\"is_object_id\")");
						State = 726; Match(IS_OBJECT_ID);
						_localctx.attrs.insert("is_object_id");
						}
						break;
					}
					} 
				}
				State = 732;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,79,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionaryEngineClauseContext : ParserRuleContext {
		public Dictionary<string> clauses = new Dictionary<string>();
		public DictionaryPrimaryKeyClauseContext dictionaryPrimaryKeyClause() {
			return GetRuleContext<DictionaryPrimaryKeyClauseContext>(0);
		}
		public SourceClauseContext[] sourceClause() {
			return GetRuleContexts<SourceClauseContext>();
		}
		public SourceClauseContext sourceClause(int i) {
			return GetRuleContext<SourceClauseContext>(i);
		}
		public LifetimeClauseContext[] lifetimeClause() {
			return GetRuleContexts<LifetimeClauseContext>();
		}
		public LifetimeClauseContext lifetimeClause(int i) {
			return GetRuleContext<LifetimeClauseContext>(i);
		}
		public LayoutClauseContext[] layoutClause() {
			return GetRuleContexts<LayoutClauseContext>();
		}
		public LayoutClauseContext layoutClause(int i) {
			return GetRuleContext<LayoutClauseContext>(i);
		}
		public RangeClauseContext[] rangeClause() {
			return GetRuleContexts<RangeClauseContext>();
		}
		public RangeClauseContext rangeClause(int i) {
			return GetRuleContext<RangeClauseContext>(i);
		}
		public DictionarySettingsClauseContext[] dictionarySettingsClause() {
			return GetRuleContexts<DictionarySettingsClauseContext>();
		}
		public DictionarySettingsClauseContext dictionarySettingsClause(int i) {
			return GetRuleContext<DictionarySettingsClauseContext>(i);
		}
		public DictionaryEngineClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionaryEngineClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionaryEngineClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionaryEngineClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionaryEngineClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionaryEngineClauseContext dictionaryEngineClause() {
		DictionaryEngineClauseContext _localctx = new DictionaryEngineClauseContext(_ctx, State);
		EnterRule(_localctx, 28, RULE_dictionaryEngineClause);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 734;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,80,_ctx) ) {
			case 1:
				{
				State = 733; dictionaryPrimaryKeyClause();
				}
				break;
			}
			State = 758;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,82,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					State = 756;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,81,_ctx) ) {
					case 1:
						{
						State = 736;
						if (!(!_localctx.clauses.count("source"))) throw new FailedPredicateException(this, "!$clauses.count(\"source\")");
						State = 737; sourceClause();
						_localctx.clauses.insert("source");
						}
						break;

					case 2:
						{
						State = 740;
						if (!(!_localctx.clauses.count("lifetime"))) throw new FailedPredicateException(this, "!$clauses.count(\"lifetime\")");
						State = 741; lifetimeClause();
						_localctx.clauses.insert("lifetime");
						}
						break;

					case 3:
						{
						State = 744;
						if (!(!_localctx.clauses.count("layout"))) throw new FailedPredicateException(this, "!$clauses.count(\"layout\")");
						State = 745; layoutClause();
						_localctx.clauses.insert("layout");
						}
						break;

					case 4:
						{
						State = 748;
						if (!(!_localctx.clauses.count("range"))) throw new FailedPredicateException(this, "!$clauses.count(\"range\")");
						State = 749; rangeClause();
						_localctx.clauses.insert("range");
						}
						break;

					case 5:
						{
						State = 752;
						if (!(!_localctx.clauses.count("settings"))) throw new FailedPredicateException(this, "!$clauses.count(\"settings\")");
						State = 753; dictionarySettingsClause();
						_localctx.clauses.insert("settings");
						}
						break;
					}
					} 
				}
				State = 760;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,82,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionaryPrimaryKeyClauseContext : ParserRuleContext {
		public ITerminalNode PRIMARY() { return GetToken(ClickHouseParser.PRIMARY, 0); }
		public ITerminalNode KEY() { return GetToken(ClickHouseParser.KEY, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public DictionaryPrimaryKeyClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionaryPrimaryKeyClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionaryPrimaryKeyClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionaryPrimaryKeyClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionaryPrimaryKeyClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionaryPrimaryKeyClauseContext dictionaryPrimaryKeyClause() {
		DictionaryPrimaryKeyClauseContext _localctx = new DictionaryPrimaryKeyClauseContext(_ctx, State);
		EnterRule(_localctx, 30, RULE_dictionaryPrimaryKeyClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 761; Match(PRIMARY);
			State = 762; Match(KEY);
			State = 763; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionaryArgExprContext : ParserRuleContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public DictionaryArgExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionaryArgExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionaryArgExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionaryArgExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionaryArgExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionaryArgExprContext dictionaryArgExpr() {
		DictionaryArgExprContext _localctx = new DictionaryArgExprContext(_ctx, State);
		EnterRule(_localctx, 32, RULE_dictionaryArgExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 765; identifier();
			State = 772;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case AFTER:
			case ALIAS:
			case ALL:
			case ALTER:
			case AND:
			case ANTI:
			case ANY:
			case ARRAY:
			case AS:
			case ASCENDING:
			case ASOF:
			case AST:
			case ASYNC:
			case ATTACH:
			case BETWEEN:
			case BOTH:
			case BY:
			case CASE:
			case CAST:
			case CHECK:
			case CLEAR:
			case CLUSTER:
			case CODEC:
			case COLLATE:
			case COLUMN:
			case COMMENT:
			case CONSTRAINT:
			case CREATE:
			case CROSS:
			case CUBE:
			case CURRENT:
			case DATABASE:
			case DATABASES:
			case DATE:
			case DAY:
			case DEDUPLICATE:
			case DEFAULT:
			case DELAY:
			case DELETE:
			case DESC:
			case DESCENDING:
			case DESCRIBE:
			case DETACH:
			case DICTIONARIES:
			case DICTIONARY:
			case DISK:
			case DISTINCT:
			case DISTRIBUTED:
			case DROP:
			case ELSE:
			case END:
			case ENGINE:
			case EVENTS:
			case EXISTS:
			case EXPLAIN:
			case EXPRESSION:
			case EXTRACT:
			case FETCHES:
			case FINAL:
			case FIRST:
			case FLUSH:
			case FOLLOWING:
			case FOR:
			case FORMAT:
			case FREEZE:
			case FROM:
			case FULL:
			case FUNCTION:
			case GLOBAL:
			case GRANULARITY:
			case GROUP:
			case HAVING:
			case HIERARCHICAL:
			case HOUR:
			case ID:
			case IF:
			case ILIKE:
			case IN:
			case INDEX:
			case INJECTIVE:
			case INNER:
			case INSERT:
			case INTERVAL:
			case INTO:
			case IS:
			case IS_OBJECT_ID:
			case JOIN:
			case KEY:
			case KILL:
			case LAST:
			case LAYOUT:
			case LEADING:
			case LEFT:
			case LIFETIME:
			case LIKE:
			case LIMIT:
			case LIVE:
			case LOCAL:
			case LOGS:
			case MATERIALIZE:
			case MATERIALIZED:
			case MAX:
			case MERGES:
			case MIN:
			case MINUTE:
			case MODIFY:
			case MONTH:
			case MOVE:
			case MUTATION:
			case NO:
			case NOT:
			case NULLS:
			case OFFSET:
			case ON:
			case OPTIMIZE:
			case OR:
			case ORDER:
			case OUTER:
			case OUTFILE:
			case OVER:
			case PARTITION:
			case POPULATE:
			case PRECEDING:
			case PREWHERE:
			case PRIMARY:
			case QUARTER:
			case RANGE:
			case RELOAD:
			case REMOVE:
			case RENAME:
			case REPLACE:
			case REPLICA:
			case REPLICATED:
			case RIGHT:
			case ROLLUP:
			case ROW:
			case ROWS:
			case SAMPLE:
			case SECOND:
			case SELECT:
			case SEMI:
			case SENDS:
			case SET:
			case SETTINGS:
			case SHOW:
			case SOURCE:
			case START:
			case STOP:
			case SUBSTRING:
			case SYNC:
			case SYNTAX:
			case SYSTEM:
			case TABLE:
			case TABLES:
			case TEMPORARY:
			case TEST:
			case THEN:
			case TIES:
			case TIMEOUT:
			case TIMESTAMP:
			case TO:
			case TOP:
			case TOTALS:
			case TRAILING:
			case TRIM:
			case TRUNCATE:
			case TTL:
			case TYPE:
			case UNBOUNDED:
			case UNION:
			case UPDATE:
			case USE:
			case USING:
			case UUID:
			case VALUES:
			case VIEW:
			case VOLUME:
			case WATCH:
			case WEEK:
			case WHEN:
			case WHERE:
			case WINDOW:
			case WITH:
			case YEAR:
			case JSON_FALSE:
			case JSON_TRUE:
			case IDENTIFIER:
				{
				State = 766; identifier();
				State = 769;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==LPAREN) {
					{
					State = 767; Match(LPAREN);
					State = 768; Match(RPAREN);
					}
				}

				}
				break;
			case INF:
			case NAN_SQL:
			case NULL_SQL:
			case FLOATING_LITERAL:
			case OCTAL_LITERAL:
			case DECIMAL_LITERAL:
			case HEXADECIMAL_LITERAL:
			case STRING_LITERAL:
			case DASH:
			case DOT:
			case PLUS:
				{
				State = 771; literal();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SourceClauseContext : ParserRuleContext {
		public ITerminalNode SOURCE() { return GetToken(ClickHouseParser.SOURCE, 0); }
		public ITerminalNode[] LPAREN() { return GetTokens(ClickHouseParser.LPAREN); }
		public ITerminalNode LPAREN(int i) {
			return GetToken(ClickHouseParser.LPAREN, i);
		}
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode[] RPAREN() { return GetTokens(ClickHouseParser.RPAREN); }
		public ITerminalNode RPAREN(int i) {
			return GetToken(ClickHouseParser.RPAREN, i);
		}
		public DictionaryArgExprContext[] dictionaryArgExpr() {
			return GetRuleContexts<DictionaryArgExprContext>();
		}
		public DictionaryArgExprContext dictionaryArgExpr(int i) {
			return GetRuleContext<DictionaryArgExprContext>(i);
		}
		public SourceClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sourceClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSourceClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSourceClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSourceClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SourceClauseContext sourceClause() {
		SourceClauseContext _localctx = new SourceClauseContext(_ctx, State);
		EnterRule(_localctx, 34, RULE_sourceClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 774; Match(SOURCE);
			State = 775; Match(LPAREN);
			State = 776; identifier();
			State = 777; Match(LPAREN);
			State = 781;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (((((_la - 2)) & ~0x3f) == 0 && ((1L << (_la - 2)) & ((1L << (AFTER - 2)) | (1L << (ALIAS - 2)) | (1L << (ALL - 2)) | (1L << (ALTER - 2)) | (1L << (AND - 2)) | (1L << (ANTI - 2)) | (1L << (ANY - 2)) | (1L << (ARRAY - 2)) | (1L << (AS - 2)) | (1L << (ASCENDING - 2)) | (1L << (ASOF - 2)) | (1L << (AST - 2)) | (1L << (ASYNC - 2)) | (1L << (ATTACH - 2)) | (1L << (BETWEEN - 2)) | (1L << (BOTH - 2)) | (1L << (BY - 2)) | (1L << (CASE - 2)) | (1L << (CAST - 2)) | (1L << (CHECK - 2)) | (1L << (CLEAR - 2)) | (1L << (CLUSTER - 2)) | (1L << (CODEC - 2)) | (1L << (COLLATE - 2)) | (1L << (COLUMN - 2)) | (1L << (COMMENT - 2)) | (1L << (CONSTRAINT - 2)) | (1L << (CREATE - 2)) | (1L << (CROSS - 2)) | (1L << (CUBE - 2)) | (1L << (CURRENT - 2)) | (1L << (DATABASE - 2)) | (1L << (DATABASES - 2)) | (1L << (DATE - 2)) | (1L << (DAY - 2)) | (1L << (DEDUPLICATE - 2)) | (1L << (DEFAULT - 2)) | (1L << (DELAY - 2)) | (1L << (DELETE - 2)) | (1L << (DESC - 2)) | (1L << (DESCENDING - 2)) | (1L << (DESCRIBE - 2)) | (1L << (DETACH - 2)) | (1L << (DICTIONARIES - 2)) | (1L << (DICTIONARY - 2)) | (1L << (DISK - 2)) | (1L << (DISTINCT - 2)) | (1L << (DISTRIBUTED - 2)) | (1L << (DROP - 2)) | (1L << (ELSE - 2)) | (1L << (END - 2)) | (1L << (ENGINE - 2)) | (1L << (EVENTS - 2)) | (1L << (EXISTS - 2)) | (1L << (EXPLAIN - 2)) | (1L << (EXPRESSION - 2)) | (1L << (EXTRACT - 2)) | (1L << (FETCHES - 2)) | (1L << (FINAL - 2)) | (1L << (FIRST - 2)) | (1L << (FLUSH - 2)) | (1L << (FOLLOWING - 2)) | (1L << (FOR - 2)) | (1L << (FORMAT - 2)))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (FREEZE - 66)) | (1L << (FROM - 66)) | (1L << (FULL - 66)) | (1L << (FUNCTION - 66)) | (1L << (GLOBAL - 66)) | (1L << (GRANULARITY - 66)) | (1L << (GROUP - 66)) | (1L << (HAVING - 66)) | (1L << (HIERARCHICAL - 66)) | (1L << (HOUR - 66)) | (1L << (ID - 66)) | (1L << (IF - 66)) | (1L << (ILIKE - 66)) | (1L << (IN - 66)) | (1L << (INDEX - 66)) | (1L << (INJECTIVE - 66)) | (1L << (INNER - 66)) | (1L << (INSERT - 66)) | (1L << (INTERVAL - 66)) | (1L << (INTO - 66)) | (1L << (IS - 66)) | (1L << (IS_OBJECT_ID - 66)) | (1L << (JOIN - 66)) | (1L << (KEY - 66)) | (1L << (KILL - 66)) | (1L << (LAST - 66)) | (1L << (LAYOUT - 66)) | (1L << (LEADING - 66)) | (1L << (LEFT - 66)) | (1L << (LIFETIME - 66)) | (1L << (LIKE - 66)) | (1L << (LIMIT - 66)) | (1L << (LIVE - 66)) | (1L << (LOCAL - 66)) | (1L << (LOGS - 66)) | (1L << (MATERIALIZE - 66)) | (1L << (MATERIALIZED - 66)) | (1L << (MAX - 66)) | (1L << (MERGES - 66)) | (1L << (MIN - 66)) | (1L << (MINUTE - 66)) | (1L << (MODIFY - 66)) | (1L << (MONTH - 66)) | (1L << (MOVE - 66)) | (1L << (MUTATION - 66)) | (1L << (NO - 66)) | (1L << (NOT - 66)) | (1L << (NULLS - 66)) | (1L << (OFFSET - 66)) | (1L << (ON - 66)) | (1L << (OPTIMIZE - 66)) | (1L << (OR - 66)) | (1L << (ORDER - 66)) | (1L << (OUTER - 66)) | (1L << (OUTFILE - 66)) | (1L << (OVER - 66)) | (1L << (PARTITION - 66)) | (1L << (POPULATE - 66)) | (1L << (PRECEDING - 66)) | (1L << (PREWHERE - 66)) | (1L << (PRIMARY - 66)))) != 0) || ((((_la - 131)) & ~0x3f) == 0 && ((1L << (_la - 131)) & ((1L << (QUARTER - 131)) | (1L << (RANGE - 131)) | (1L << (RELOAD - 131)) | (1L << (REMOVE - 131)) | (1L << (RENAME - 131)) | (1L << (REPLACE - 131)) | (1L << (REPLICA - 131)) | (1L << (REPLICATED - 131)) | (1L << (RIGHT - 131)) | (1L << (ROLLUP - 131)) | (1L << (ROW - 131)) | (1L << (ROWS - 131)) | (1L << (SAMPLE - 131)) | (1L << (SECOND - 131)) | (1L << (SELECT - 131)) | (1L << (SEMI - 131)) | (1L << (SENDS - 131)) | (1L << (SET - 131)) | (1L << (SETTINGS - 131)) | (1L << (SHOW - 131)) | (1L << (SOURCE - 131)) | (1L << (START - 131)) | (1L << (STOP - 131)) | (1L << (SUBSTRING - 131)) | (1L << (SYNC - 131)) | (1L << (SYNTAX - 131)) | (1L << (SYSTEM - 131)) | (1L << (TABLE - 131)) | (1L << (TABLES - 131)) | (1L << (TEMPORARY - 131)) | (1L << (TEST - 131)) | (1L << (THEN - 131)) | (1L << (TIES - 131)) | (1L << (TIMEOUT - 131)) | (1L << (TIMESTAMP - 131)) | (1L << (TO - 131)) | (1L << (TOP - 131)) | (1L << (TOTALS - 131)) | (1L << (TRAILING - 131)) | (1L << (TRIM - 131)) | (1L << (TRUNCATE - 131)) | (1L << (TTL - 131)) | (1L << (TYPE - 131)) | (1L << (UNBOUNDED - 131)) | (1L << (UNION - 131)) | (1L << (UPDATE - 131)) | (1L << (USE - 131)) | (1L << (USING - 131)) | (1L << (UUID - 131)) | (1L << (VALUES - 131)) | (1L << (VIEW - 131)) | (1L << (VOLUME - 131)) | (1L << (WATCH - 131)) | (1L << (WEEK - 131)) | (1L << (WHEN - 131)) | (1L << (WHERE - 131)) | (1L << (WINDOW - 131)) | (1L << (WITH - 131)) | (1L << (YEAR - 131)) | (1L << (JSON_FALSE - 131)) | (1L << (JSON_TRUE - 131)) | (1L << (IDENTIFIER - 131)))) != 0)) {
				{
				{
				State = 778; dictionaryArgExpr();
				}
				}
				State = 783;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 784; Match(RPAREN);
			State = 785; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LifetimeClauseContext : ParserRuleContext {
		public ITerminalNode LIFETIME() { return GetToken(ClickHouseParser.LIFETIME, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] DECIMAL_LITERAL() { return GetTokens(ClickHouseParser.DECIMAL_LITERAL); }
		public ITerminalNode DECIMAL_LITERAL(int i) {
			return GetToken(ClickHouseParser.DECIMAL_LITERAL, i);
		}
		public ITerminalNode MIN() { return GetToken(ClickHouseParser.MIN, 0); }
		public ITerminalNode MAX() { return GetToken(ClickHouseParser.MAX, 0); }
		public LifetimeClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lifetimeClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLifetimeClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLifetimeClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLifetimeClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LifetimeClauseContext lifetimeClause() {
		LifetimeClauseContext _localctx = new LifetimeClauseContext(_ctx, State);
		EnterRule(_localctx, 36, RULE_lifetimeClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 787; Match(LIFETIME);
			State = 788; Match(LPAREN);
			State = 798;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case DECIMAL_LITERAL:
				{
				State = 789; Match(DECIMAL_LITERAL);
				}
				break;
			case MIN:
				{
				State = 790; Match(MIN);
				State = 791; Match(DECIMAL_LITERAL);
				State = 792; Match(MAX);
				State = 793; Match(DECIMAL_LITERAL);
				}
				break;
			case MAX:
				{
				State = 794; Match(MAX);
				State = 795; Match(DECIMAL_LITERAL);
				State = 796; Match(MIN);
				State = 797; Match(DECIMAL_LITERAL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 800; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LayoutClauseContext : ParserRuleContext {
		public ITerminalNode LAYOUT() { return GetToken(ClickHouseParser.LAYOUT, 0); }
		public ITerminalNode[] LPAREN() { return GetTokens(ClickHouseParser.LPAREN); }
		public ITerminalNode LPAREN(int i) {
			return GetToken(ClickHouseParser.LPAREN, i);
		}
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode[] RPAREN() { return GetTokens(ClickHouseParser.RPAREN); }
		public ITerminalNode RPAREN(int i) {
			return GetToken(ClickHouseParser.RPAREN, i);
		}
		public DictionaryArgExprContext[] dictionaryArgExpr() {
			return GetRuleContexts<DictionaryArgExprContext>();
		}
		public DictionaryArgExprContext dictionaryArgExpr(int i) {
			return GetRuleContext<DictionaryArgExprContext>(i);
		}
		public LayoutClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_layoutClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLayoutClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLayoutClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLayoutClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LayoutClauseContext layoutClause() {
		LayoutClauseContext _localctx = new LayoutClauseContext(_ctx, State);
		EnterRule(_localctx, 38, RULE_layoutClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 802; Match(LAYOUT);
			State = 803; Match(LPAREN);
			State = 804; identifier();
			State = 805; Match(LPAREN);
			State = 809;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (((((_la - 2)) & ~0x3f) == 0 && ((1L << (_la - 2)) & ((1L << (AFTER - 2)) | (1L << (ALIAS - 2)) | (1L << (ALL - 2)) | (1L << (ALTER - 2)) | (1L << (AND - 2)) | (1L << (ANTI - 2)) | (1L << (ANY - 2)) | (1L << (ARRAY - 2)) | (1L << (AS - 2)) | (1L << (ASCENDING - 2)) | (1L << (ASOF - 2)) | (1L << (AST - 2)) | (1L << (ASYNC - 2)) | (1L << (ATTACH - 2)) | (1L << (BETWEEN - 2)) | (1L << (BOTH - 2)) | (1L << (BY - 2)) | (1L << (CASE - 2)) | (1L << (CAST - 2)) | (1L << (CHECK - 2)) | (1L << (CLEAR - 2)) | (1L << (CLUSTER - 2)) | (1L << (CODEC - 2)) | (1L << (COLLATE - 2)) | (1L << (COLUMN - 2)) | (1L << (COMMENT - 2)) | (1L << (CONSTRAINT - 2)) | (1L << (CREATE - 2)) | (1L << (CROSS - 2)) | (1L << (CUBE - 2)) | (1L << (CURRENT - 2)) | (1L << (DATABASE - 2)) | (1L << (DATABASES - 2)) | (1L << (DATE - 2)) | (1L << (DAY - 2)) | (1L << (DEDUPLICATE - 2)) | (1L << (DEFAULT - 2)) | (1L << (DELAY - 2)) | (1L << (DELETE - 2)) | (1L << (DESC - 2)) | (1L << (DESCENDING - 2)) | (1L << (DESCRIBE - 2)) | (1L << (DETACH - 2)) | (1L << (DICTIONARIES - 2)) | (1L << (DICTIONARY - 2)) | (1L << (DISK - 2)) | (1L << (DISTINCT - 2)) | (1L << (DISTRIBUTED - 2)) | (1L << (DROP - 2)) | (1L << (ELSE - 2)) | (1L << (END - 2)) | (1L << (ENGINE - 2)) | (1L << (EVENTS - 2)) | (1L << (EXISTS - 2)) | (1L << (EXPLAIN - 2)) | (1L << (EXPRESSION - 2)) | (1L << (EXTRACT - 2)) | (1L << (FETCHES - 2)) | (1L << (FINAL - 2)) | (1L << (FIRST - 2)) | (1L << (FLUSH - 2)) | (1L << (FOLLOWING - 2)) | (1L << (FOR - 2)) | (1L << (FORMAT - 2)))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (FREEZE - 66)) | (1L << (FROM - 66)) | (1L << (FULL - 66)) | (1L << (FUNCTION - 66)) | (1L << (GLOBAL - 66)) | (1L << (GRANULARITY - 66)) | (1L << (GROUP - 66)) | (1L << (HAVING - 66)) | (1L << (HIERARCHICAL - 66)) | (1L << (HOUR - 66)) | (1L << (ID - 66)) | (1L << (IF - 66)) | (1L << (ILIKE - 66)) | (1L << (IN - 66)) | (1L << (INDEX - 66)) | (1L << (INJECTIVE - 66)) | (1L << (INNER - 66)) | (1L << (INSERT - 66)) | (1L << (INTERVAL - 66)) | (1L << (INTO - 66)) | (1L << (IS - 66)) | (1L << (IS_OBJECT_ID - 66)) | (1L << (JOIN - 66)) | (1L << (KEY - 66)) | (1L << (KILL - 66)) | (1L << (LAST - 66)) | (1L << (LAYOUT - 66)) | (1L << (LEADING - 66)) | (1L << (LEFT - 66)) | (1L << (LIFETIME - 66)) | (1L << (LIKE - 66)) | (1L << (LIMIT - 66)) | (1L << (LIVE - 66)) | (1L << (LOCAL - 66)) | (1L << (LOGS - 66)) | (1L << (MATERIALIZE - 66)) | (1L << (MATERIALIZED - 66)) | (1L << (MAX - 66)) | (1L << (MERGES - 66)) | (1L << (MIN - 66)) | (1L << (MINUTE - 66)) | (1L << (MODIFY - 66)) | (1L << (MONTH - 66)) | (1L << (MOVE - 66)) | (1L << (MUTATION - 66)) | (1L << (NO - 66)) | (1L << (NOT - 66)) | (1L << (NULLS - 66)) | (1L << (OFFSET - 66)) | (1L << (ON - 66)) | (1L << (OPTIMIZE - 66)) | (1L << (OR - 66)) | (1L << (ORDER - 66)) | (1L << (OUTER - 66)) | (1L << (OUTFILE - 66)) | (1L << (OVER - 66)) | (1L << (PARTITION - 66)) | (1L << (POPULATE - 66)) | (1L << (PRECEDING - 66)) | (1L << (PREWHERE - 66)) | (1L << (PRIMARY - 66)))) != 0) || ((((_la - 131)) & ~0x3f) == 0 && ((1L << (_la - 131)) & ((1L << (QUARTER - 131)) | (1L << (RANGE - 131)) | (1L << (RELOAD - 131)) | (1L << (REMOVE - 131)) | (1L << (RENAME - 131)) | (1L << (REPLACE - 131)) | (1L << (REPLICA - 131)) | (1L << (REPLICATED - 131)) | (1L << (RIGHT - 131)) | (1L << (ROLLUP - 131)) | (1L << (ROW - 131)) | (1L << (ROWS - 131)) | (1L << (SAMPLE - 131)) | (1L << (SECOND - 131)) | (1L << (SELECT - 131)) | (1L << (SEMI - 131)) | (1L << (SENDS - 131)) | (1L << (SET - 131)) | (1L << (SETTINGS - 131)) | (1L << (SHOW - 131)) | (1L << (SOURCE - 131)) | (1L << (START - 131)) | (1L << (STOP - 131)) | (1L << (SUBSTRING - 131)) | (1L << (SYNC - 131)) | (1L << (SYNTAX - 131)) | (1L << (SYSTEM - 131)) | (1L << (TABLE - 131)) | (1L << (TABLES - 131)) | (1L << (TEMPORARY - 131)) | (1L << (TEST - 131)) | (1L << (THEN - 131)) | (1L << (TIES - 131)) | (1L << (TIMEOUT - 131)) | (1L << (TIMESTAMP - 131)) | (1L << (TO - 131)) | (1L << (TOP - 131)) | (1L << (TOTALS - 131)) | (1L << (TRAILING - 131)) | (1L << (TRIM - 131)) | (1L << (TRUNCATE - 131)) | (1L << (TTL - 131)) | (1L << (TYPE - 131)) | (1L << (UNBOUNDED - 131)) | (1L << (UNION - 131)) | (1L << (UPDATE - 131)) | (1L << (USE - 131)) | (1L << (USING - 131)) | (1L << (UUID - 131)) | (1L << (VALUES - 131)) | (1L << (VIEW - 131)) | (1L << (VOLUME - 131)) | (1L << (WATCH - 131)) | (1L << (WEEK - 131)) | (1L << (WHEN - 131)) | (1L << (WHERE - 131)) | (1L << (WINDOW - 131)) | (1L << (WITH - 131)) | (1L << (YEAR - 131)) | (1L << (JSON_FALSE - 131)) | (1L << (JSON_TRUE - 131)) | (1L << (IDENTIFIER - 131)))) != 0)) {
				{
				{
				State = 806; dictionaryArgExpr();
				}
				}
				State = 811;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 812; Match(RPAREN);
			State = 813; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RangeClauseContext : ParserRuleContext {
		public ITerminalNode RANGE() { return GetToken(ClickHouseParser.RANGE, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode MIN() { return GetToken(ClickHouseParser.MIN, 0); }
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode MAX() { return GetToken(ClickHouseParser.MAX, 0); }
		public RangeClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rangeClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterRangeClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitRangeClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRangeClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RangeClauseContext rangeClause() {
		RangeClauseContext _localctx = new RangeClauseContext(_ctx, State);
		EnterRule(_localctx, 40, RULE_rangeClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 815; Match(RANGE);
			State = 816; Match(LPAREN);
			State = 827;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case MIN:
				{
				State = 817; Match(MIN);
				State = 818; identifier();
				State = 819; Match(MAX);
				State = 820; identifier();
				}
				break;
			case MAX:
				{
				State = 822; Match(MAX);
				State = 823; identifier();
				State = 824; Match(MIN);
				State = 825; identifier();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 829; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionarySettingsClauseContext : ParserRuleContext {
		public ITerminalNode SETTINGS() { return GetToken(ClickHouseParser.SETTINGS, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public SettingExprListContext settingExprList() {
			return GetRuleContext<SettingExprListContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public DictionarySettingsClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionarySettingsClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDictionarySettingsClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDictionarySettingsClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionarySettingsClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionarySettingsClauseContext dictionarySettingsClause() {
		DictionarySettingsClauseContext _localctx = new DictionarySettingsClauseContext(_ctx, State);
		EnterRule(_localctx, 42, RULE_dictionarySettingsClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 831; Match(SETTINGS);
			State = 832; Match(LPAREN);
			State = 833; settingExprList();
			State = 834; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClusterClauseContext : ParserRuleContext {
		public ITerminalNode ON() { return GetToken(ClickHouseParser.ON, 0); }
		public ITerminalNode CLUSTER() { return GetToken(ClickHouseParser.CLUSTER, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ClusterClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_clusterClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterClusterClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitClusterClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitClusterClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ClusterClauseContext clusterClause() {
		ClusterClauseContext _localctx = new ClusterClauseContext(_ctx, State);
		EnterRule(_localctx, 44, RULE_clusterClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 836; Match(ON);
			State = 837; Match(CLUSTER);
			State = 840;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case AFTER:
			case ALIAS:
			case ALL:
			case ALTER:
			case AND:
			case ANTI:
			case ANY:
			case ARRAY:
			case AS:
			case ASCENDING:
			case ASOF:
			case AST:
			case ASYNC:
			case ATTACH:
			case BETWEEN:
			case BOTH:
			case BY:
			case CASE:
			case CAST:
			case CHECK:
			case CLEAR:
			case CLUSTER:
			case CODEC:
			case COLLATE:
			case COLUMN:
			case COMMENT:
			case CONSTRAINT:
			case CREATE:
			case CROSS:
			case CUBE:
			case CURRENT:
			case DATABASE:
			case DATABASES:
			case DATE:
			case DAY:
			case DEDUPLICATE:
			case DEFAULT:
			case DELAY:
			case DELETE:
			case DESC:
			case DESCENDING:
			case DESCRIBE:
			case DETACH:
			case DICTIONARIES:
			case DICTIONARY:
			case DISK:
			case DISTINCT:
			case DISTRIBUTED:
			case DROP:
			case ELSE:
			case END:
			case ENGINE:
			case EVENTS:
			case EXISTS:
			case EXPLAIN:
			case EXPRESSION:
			case EXTRACT:
			case FETCHES:
			case FINAL:
			case FIRST:
			case FLUSH:
			case FOLLOWING:
			case FOR:
			case FORMAT:
			case FREEZE:
			case FROM:
			case FULL:
			case FUNCTION:
			case GLOBAL:
			case GRANULARITY:
			case GROUP:
			case HAVING:
			case HIERARCHICAL:
			case HOUR:
			case ID:
			case IF:
			case ILIKE:
			case IN:
			case INDEX:
			case INJECTIVE:
			case INNER:
			case INSERT:
			case INTERVAL:
			case INTO:
			case IS:
			case IS_OBJECT_ID:
			case JOIN:
			case KEY:
			case KILL:
			case LAST:
			case LAYOUT:
			case LEADING:
			case LEFT:
			case LIFETIME:
			case LIKE:
			case LIMIT:
			case LIVE:
			case LOCAL:
			case LOGS:
			case MATERIALIZE:
			case MATERIALIZED:
			case MAX:
			case MERGES:
			case MIN:
			case MINUTE:
			case MODIFY:
			case MONTH:
			case MOVE:
			case MUTATION:
			case NO:
			case NOT:
			case NULLS:
			case OFFSET:
			case ON:
			case OPTIMIZE:
			case OR:
			case ORDER:
			case OUTER:
			case OUTFILE:
			case OVER:
			case PARTITION:
			case POPULATE:
			case PRECEDING:
			case PREWHERE:
			case PRIMARY:
			case QUARTER:
			case RANGE:
			case RELOAD:
			case REMOVE:
			case RENAME:
			case REPLACE:
			case REPLICA:
			case REPLICATED:
			case RIGHT:
			case ROLLUP:
			case ROW:
			case ROWS:
			case SAMPLE:
			case SECOND:
			case SELECT:
			case SEMI:
			case SENDS:
			case SET:
			case SETTINGS:
			case SHOW:
			case SOURCE:
			case START:
			case STOP:
			case SUBSTRING:
			case SYNC:
			case SYNTAX:
			case SYSTEM:
			case TABLE:
			case TABLES:
			case TEMPORARY:
			case TEST:
			case THEN:
			case TIES:
			case TIMEOUT:
			case TIMESTAMP:
			case TO:
			case TOP:
			case TOTALS:
			case TRAILING:
			case TRIM:
			case TRUNCATE:
			case TTL:
			case TYPE:
			case UNBOUNDED:
			case UNION:
			case UPDATE:
			case USE:
			case USING:
			case UUID:
			case VALUES:
			case VIEW:
			case VOLUME:
			case WATCH:
			case WEEK:
			case WHEN:
			case WHERE:
			case WINDOW:
			case WITH:
			case YEAR:
			case JSON_FALSE:
			case JSON_TRUE:
			case IDENTIFIER:
				{
				State = 838; identifier();
				}
				break;
			case STRING_LITERAL:
				{
				State = 839; Match(STRING_LITERAL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UuidClauseContext : ParserRuleContext {
		public ITerminalNode UUID() { return GetToken(ClickHouseParser.UUID, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public UuidClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_uuidClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterUuidClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitUuidClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUuidClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UuidClauseContext uuidClause() {
		UuidClauseContext _localctx = new UuidClauseContext(_ctx, State);
		EnterRule(_localctx, 46, RULE_uuidClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 842; Match(UUID);
			State = 843; Match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DestinationClauseContext : ParserRuleContext {
		public ITerminalNode TO() { return GetToken(ClickHouseParser.TO, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public DestinationClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_destinationClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDestinationClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDestinationClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDestinationClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DestinationClauseContext destinationClause() {
		DestinationClauseContext _localctx = new DestinationClauseContext(_ctx, State);
		EnterRule(_localctx, 48, RULE_destinationClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 845; Match(TO);
			State = 846; tableIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SubqueryClauseContext : ParserRuleContext {
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public SubqueryClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_subqueryClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSubqueryClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSubqueryClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSubqueryClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SubqueryClauseContext subqueryClause() {
		SubqueryClauseContext _localctx = new SubqueryClauseContext(_ctx, State);
		EnterRule(_localctx, 50, RULE_subqueryClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 848; Match(AS);
			State = 849; selectUnionStmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableSchemaClauseContext : ParserRuleContext {
		public TableSchemaClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableSchemaClause; } }
	 
		public TableSchemaClauseContext() { }
		public virtual void CopyFrom(TableSchemaClauseContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class SchemaAsTableClauseContext : TableSchemaClauseContext {
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public SchemaAsTableClauseContext(TableSchemaClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSchemaAsTableClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSchemaAsTableClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSchemaAsTableClause(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SchemaAsFunctionClauseContext : TableSchemaClauseContext {
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public TableFunctionExprContext tableFunctionExpr() {
			return GetRuleContext<TableFunctionExprContext>(0);
		}
		public SchemaAsFunctionClauseContext(TableSchemaClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSchemaAsFunctionClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSchemaAsFunctionClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSchemaAsFunctionClause(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SchemaDescriptionClauseContext : TableSchemaClauseContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public TableElementExprContext[] tableElementExpr() {
			return GetRuleContexts<TableElementExprContext>();
		}
		public TableElementExprContext tableElementExpr(int i) {
			return GetRuleContext<TableElementExprContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public SchemaDescriptionClauseContext(TableSchemaClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSchemaDescriptionClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSchemaDescriptionClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSchemaDescriptionClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableSchemaClauseContext tableSchemaClause() {
		TableSchemaClauseContext _localctx = new TableSchemaClauseContext(_ctx, State);
		EnterRule(_localctx, 52, RULE_tableSchemaClause);
		int _la;
		try {
			State = 866;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,91,_ctx) ) {
			case 1:
				_localctx = new SchemaDescriptionClauseContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 851; Match(LPAREN);
				State = 852; tableElementExpr();
				State = 857;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 853; Match(COMMA);
					State = 854; tableElementExpr();
					}
					}
					State = 859;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 860; Match(RPAREN);
				}
				break;

			case 2:
				_localctx = new SchemaAsTableClauseContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 862; Match(AS);
				State = 863; tableIdentifier();
				}
				break;

			case 3:
				_localctx = new SchemaAsFunctionClauseContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 864; Match(AS);
				State = 865; tableFunctionExpr();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EngineClauseContext : ParserRuleContext {
		public Dictionary<string> clauses = new Dictionary<string>();
		public EngineExprContext engineExpr() {
			return GetRuleContext<EngineExprContext>(0);
		}
		public OrderByClauseContext[] orderByClause() {
			return GetRuleContexts<OrderByClauseContext>();
		}
		public OrderByClauseContext orderByClause(int i) {
			return GetRuleContext<OrderByClauseContext>(i);
		}
		public PartitionByClauseContext[] partitionByClause() {
			return GetRuleContexts<PartitionByClauseContext>();
		}
		public PartitionByClauseContext partitionByClause(int i) {
			return GetRuleContext<PartitionByClauseContext>(i);
		}
		public PrimaryKeyClauseContext[] primaryKeyClause() {
			return GetRuleContexts<PrimaryKeyClauseContext>();
		}
		public PrimaryKeyClauseContext primaryKeyClause(int i) {
			return GetRuleContext<PrimaryKeyClauseContext>(i);
		}
		public SampleByClauseContext[] sampleByClause() {
			return GetRuleContexts<SampleByClauseContext>();
		}
		public SampleByClauseContext sampleByClause(int i) {
			return GetRuleContext<SampleByClauseContext>(i);
		}
		public TtlClauseContext[] ttlClause() {
			return GetRuleContexts<TtlClauseContext>();
		}
		public TtlClauseContext ttlClause(int i) {
			return GetRuleContext<TtlClauseContext>(i);
		}
		public SettingsClauseContext[] settingsClause() {
			return GetRuleContexts<SettingsClauseContext>();
		}
		public SettingsClauseContext settingsClause(int i) {
			return GetRuleContext<SettingsClauseContext>(i);
		}
		public EngineClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_engineClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterEngineClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitEngineClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEngineClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EngineClauseContext engineClause() {
		EngineClauseContext _localctx = new EngineClauseContext(_ctx, State);
		EnterRule(_localctx, 54, RULE_engineClause);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 868; engineExpr();
			State = 895;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,93,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					State = 893;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,92,_ctx) ) {
					case 1:
						{
						State = 869;
						if (!(!_localctx.clauses.count("orderByClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"orderByClause\")");
						State = 870; orderByClause();
						_localctx.clauses.insert("orderByClause");
						}
						break;

					case 2:
						{
						State = 873;
						if (!(!_localctx.clauses.count("partitionByClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"partitionByClause\")");
						State = 874; partitionByClause();
						_localctx.clauses.insert("partitionByClause");
						}
						break;

					case 3:
						{
						State = 877;
						if (!(!_localctx.clauses.count("primaryKeyClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"primaryKeyClause\")");
						State = 878; primaryKeyClause();
						_localctx.clauses.insert("primaryKeyClause");
						}
						break;

					case 4:
						{
						State = 881;
						if (!(!_localctx.clauses.count("sampleByClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"sampleByClause\")");
						State = 882; sampleByClause();
						_localctx.clauses.insert("sampleByClause");
						}
						break;

					case 5:
						{
						State = 885;
						if (!(!_localctx.clauses.count("ttlClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"ttlClause\")");
						State = 886; ttlClause();
						_localctx.clauses.insert("ttlClause");
						}
						break;

					case 6:
						{
						State = 889;
						if (!(!_localctx.clauses.count("settingsClause"))) throw new FailedPredicateException(this, "!$clauses.count(\"settingsClause\")");
						State = 890; settingsClause();
						_localctx.clauses.insert("settingsClause");
						}
						break;
					}
					} 
				}
				State = 897;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,93,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableCommentClauseContext : ParserRuleContext {
		public ITerminalNode COMMENT() { return GetToken(ClickHouseParser.COMMENT, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public TableCommentClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableCommentClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableCommentClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableCommentClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableCommentClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableCommentClauseContext tableCommentClause() {
		TableCommentClauseContext _localctx = new TableCommentClauseContext(_ctx, State);
		EnterRule(_localctx, 56, RULE_tableCommentClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 898; Match(COMMENT);
			State = 899; Match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnCommentClauseContext : ParserRuleContext {
		public ITerminalNode COMMENT() { return GetToken(ClickHouseParser.COMMENT, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ColumnCommentClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnCommentClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnCommentClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnCommentClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnCommentClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnCommentClauseContext columnCommentClause() {
		ColumnCommentClauseContext _localctx = new ColumnCommentClauseContext(_ctx, State);
		EnterRule(_localctx, 58, RULE_columnCommentClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 901; Match(COMMENT);
			State = 902; Match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PartitionByClauseContext : ParserRuleContext {
		public ITerminalNode PARTITION() { return GetToken(ClickHouseParser.PARTITION, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public PartitionByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_partitionByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterPartitionByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitPartitionByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPartitionByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PartitionByClauseContext partitionByClause() {
		PartitionByClauseContext _localctx = new PartitionByClauseContext(_ctx, State);
		EnterRule(_localctx, 60, RULE_partitionByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 904; Match(PARTITION);
			State = 905; Match(BY);
			State = 906; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrimaryKeyClauseContext : ParserRuleContext {
		public ITerminalNode PRIMARY() { return GetToken(ClickHouseParser.PRIMARY, 0); }
		public ITerminalNode KEY() { return GetToken(ClickHouseParser.KEY, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public PrimaryKeyClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryKeyClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterPrimaryKeyClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitPrimaryKeyClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrimaryKeyClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryKeyClauseContext primaryKeyClause() {
		PrimaryKeyClauseContext _localctx = new PrimaryKeyClauseContext(_ctx, State);
		EnterRule(_localctx, 62, RULE_primaryKeyClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 908; Match(PRIMARY);
			State = 909; Match(KEY);
			State = 910; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SampleByClauseContext : ParserRuleContext {
		public ITerminalNode SAMPLE() { return GetToken(ClickHouseParser.SAMPLE, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public SampleByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sampleByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSampleByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSampleByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSampleByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SampleByClauseContext sampleByClause() {
		SampleByClauseContext _localctx = new SampleByClauseContext(_ctx, State);
		EnterRule(_localctx, 64, RULE_sampleByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 912; Match(SAMPLE);
			State = 913; Match(BY);
			State = 914; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TtlClauseContext : ParserRuleContext {
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public TtlExprContext[] ttlExpr() {
			return GetRuleContexts<TtlExprContext>();
		}
		public TtlExprContext ttlExpr(int i) {
			return GetRuleContext<TtlExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public TtlClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ttlClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTtlClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTtlClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTtlClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TtlClauseContext ttlClause() {
		TtlClauseContext _localctx = new TtlClauseContext(_ctx, State);
		EnterRule(_localctx, 66, RULE_ttlClause);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 916; Match(TTL);
			State = 917; ttlExpr();
			State = 922;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,94,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 918; Match(COMMA);
					State = 919; ttlExpr();
					}
					} 
				}
				State = 924;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,94,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EngineExprContext : ParserRuleContext {
		public ITerminalNode ENGINE() { return GetToken(ClickHouseParser.ENGINE, 0); }
		public IdentifierOrNullContext identifierOrNull() {
			return GetRuleContext<IdentifierOrNullContext>(0);
		}
		public ITerminalNode EQ_SINGLE() { return GetToken(ClickHouseParser.EQ_SINGLE, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public EngineExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_engineExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterEngineExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitEngineExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEngineExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EngineExprContext engineExpr() {
		EngineExprContext _localctx = new EngineExprContext(_ctx, State);
		EnterRule(_localctx, 68, RULE_engineExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 925; Match(ENGINE);
			State = 927;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==EQ_SINGLE) {
				{
				State = 926; Match(EQ_SINGLE);
				}
			}

			State = 929; identifierOrNull();
			State = 935;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,97,_ctx) ) {
			case 1:
				{
				State = 930; Match(LPAREN);
				State = 932;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 931; columnExprList();
					}
				}

				State = 934; Match(RPAREN);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableElementExprContext : ParserRuleContext {
		public TableElementExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableElementExpr; } }
	 
		public TableElementExprContext() { }
		public virtual void CopyFrom(TableElementExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TableElementExprProjectionContext : TableElementExprContext {
		public ITerminalNode PROJECTION() { return GetToken(ClickHouseParser.PROJECTION, 0); }
		public TableProjectionDfntContext tableProjectionDfnt() {
			return GetRuleContext<TableProjectionDfntContext>(0);
		}
		public TableElementExprProjectionContext(TableElementExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableElementExprProjection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableElementExprProjection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableElementExprProjection(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableElementExprConstraintContext : TableElementExprContext {
		public ITerminalNode CONSTRAINT() { return GetToken(ClickHouseParser.CONSTRAINT, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode CHECK() { return GetToken(ClickHouseParser.CHECK, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public TableElementExprConstraintContext(TableElementExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableElementExprConstraint(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableElementExprConstraint(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableElementExprConstraint(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableElementExprColumnContext : TableElementExprContext {
		public TableColumnDfntContext tableColumnDfnt() {
			return GetRuleContext<TableColumnDfntContext>(0);
		}
		public TableElementExprColumnContext(TableElementExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableElementExprColumn(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableElementExprColumn(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableElementExprColumn(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableElementExprIndexContext : TableElementExprContext {
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public TableIndexDfntContext tableIndexDfnt() {
			return GetRuleContext<TableIndexDfntContext>(0);
		}
		public TableElementExprIndexContext(TableElementExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableElementExprIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableElementExprIndex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableElementExprIndex(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableElementExprContext tableElementExpr() {
		TableElementExprContext _localctx = new TableElementExprContext(_ctx, State);
		EnterRule(_localctx, 70, RULE_tableElementExpr);
		try {
			State = 947;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,98,_ctx) ) {
			case 1:
				_localctx = new TableElementExprColumnContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 937; tableColumnDfnt();
				}
				break;

			case 2:
				_localctx = new TableElementExprConstraintContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 938; Match(CONSTRAINT);
				State = 939; identifier();
				State = 940; Match(CHECK);
				State = 941; columnExpr(0);
				}
				break;

			case 3:
				_localctx = new TableElementExprIndexContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 943; Match(INDEX);
				State = 944; tableIndexDfnt();
				}
				break;

			case 4:
				_localctx = new TableElementExprProjectionContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 945; Match(PROJECTION);
				State = 946; tableProjectionDfnt();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableColumnDfntContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ColumnTypeExprContext columnTypeExpr() {
			return GetRuleContext<ColumnTypeExprContext>(0);
		}
		public TableColumnPropertyExprContext tableColumnPropertyExpr() {
			return GetRuleContext<TableColumnPropertyExprContext>(0);
		}
		public ColumnCommentClauseContext columnCommentClause() {
			return GetRuleContext<ColumnCommentClauseContext>(0);
		}
		public CodecExprContext codecExpr() {
			return GetRuleContext<CodecExprContext>(0);
		}
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public TableColumnDfntContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableColumnDfnt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableColumnDfnt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableColumnDfnt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableColumnDfnt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableColumnDfntContext tableColumnDfnt() {
		TableColumnDfntContext _localctx = new TableColumnDfntContext(_ctx, State);
		EnterRule(_localctx, 72, RULE_tableColumnDfnt);
		int _la;
		try {
			State = 979;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,107,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 949; nestedIdentifier();
				State = 950; columnTypeExpr();
				State = 952;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ALIAS || _la==DEFAULT || _la==MATERIALIZED) {
					{
					State = 951; tableColumnPropertyExpr();
					}
				}

				State = 955;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==COMMENT) {
					{
					State = 954; columnCommentClause();
					}
				}

				State = 958;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==CODEC) {
					{
					State = 957; codecExpr();
					}
				}

				State = 962;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==TTL) {
					{
					State = 960; Match(TTL);
					State = 961; columnExpr(0);
					}
				}

				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 964; nestedIdentifier();
				State = 966;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,103,_ctx) ) {
				case 1:
					{
					State = 965; columnTypeExpr();
					}
					break;
				}
				State = 968; tableColumnPropertyExpr();
				State = 970;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==COMMENT) {
					{
					State = 969; columnCommentClause();
					}
				}

				State = 973;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==CODEC) {
					{
					State = 972; codecExpr();
					}
				}

				State = 977;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==TTL) {
					{
					State = 975; Match(TTL);
					State = 976; columnExpr(0);
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableColumnPropertyExprContext : ParserRuleContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode DEFAULT() { return GetToken(ClickHouseParser.DEFAULT, 0); }
		public ITerminalNode MATERIALIZED() { return GetToken(ClickHouseParser.MATERIALIZED, 0); }
		public ITerminalNode ALIAS() { return GetToken(ClickHouseParser.ALIAS, 0); }
		public TableColumnPropertyExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableColumnPropertyExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableColumnPropertyExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableColumnPropertyExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableColumnPropertyExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableColumnPropertyExprContext tableColumnPropertyExpr() {
		TableColumnPropertyExprContext _localctx = new TableColumnPropertyExprContext(_ctx, State);
		EnterRule(_localctx, 74, RULE_tableColumnPropertyExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 981;
			_la = _input.La(1);
			if ( !(_la==ALIAS || _la==DEFAULT || _la==MATERIALIZED) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			State = 982; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableIndexDfntContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode TYPE() { return GetToken(ClickHouseParser.TYPE, 0); }
		public ColumnTypeExprContext columnTypeExpr() {
			return GetRuleContext<ColumnTypeExprContext>(0);
		}
		public ITerminalNode GRANULARITY() { return GetToken(ClickHouseParser.GRANULARITY, 0); }
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public TableIndexDfntContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableIndexDfnt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableIndexDfnt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableIndexDfnt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableIndexDfnt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableIndexDfntContext tableIndexDfnt() {
		TableIndexDfntContext _localctx = new TableIndexDfntContext(_ctx, State);
		EnterRule(_localctx, 76, RULE_tableIndexDfnt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 984; nestedIdentifier();
			State = 985; columnExpr(0);
			State = 986; Match(TYPE);
			State = 987; columnTypeExpr();
			State = 988; Match(GRANULARITY);
			State = 989; Match(DECIMAL_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableProjectionDfntContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public ProjectionSelectStmtContext projectionSelectStmt() {
			return GetRuleContext<ProjectionSelectStmtContext>(0);
		}
		public TableProjectionDfntContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableProjectionDfnt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableProjectionDfnt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableProjectionDfnt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableProjectionDfnt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableProjectionDfntContext tableProjectionDfnt() {
		TableProjectionDfntContext _localctx = new TableProjectionDfntContext(_ctx, State);
		EnterRule(_localctx, 78, RULE_tableProjectionDfnt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 991; nestedIdentifier();
			State = 992; projectionSelectStmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CodecExprContext : ParserRuleContext {
		public ITerminalNode CODEC() { return GetToken(ClickHouseParser.CODEC, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public CodecArgExprContext[] codecArgExpr() {
			return GetRuleContexts<CodecArgExprContext>();
		}
		public CodecArgExprContext codecArgExpr(int i) {
			return GetRuleContext<CodecArgExprContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public CodecExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_codecExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCodecExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCodecExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCodecExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CodecExprContext codecExpr() {
		CodecExprContext _localctx = new CodecExprContext(_ctx, State);
		EnterRule(_localctx, 80, RULE_codecExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 994; Match(CODEC);
			State = 995; Match(LPAREN);
			State = 996; codecArgExpr();
			State = 1001;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 997; Match(COMMA);
				State = 998; codecArgExpr();
				}
				}
				State = 1003;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 1004; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CodecArgExprContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public CodecArgExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_codecArgExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterCodecArgExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitCodecArgExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCodecArgExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CodecArgExprContext codecArgExpr() {
		CodecArgExprContext _localctx = new CodecArgExprContext(_ctx, State);
		EnterRule(_localctx, 82, RULE_codecArgExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1006; identifier();
			State = 1012;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==LPAREN) {
				{
				State = 1007; Match(LPAREN);
				State = 1009;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1008; columnExprList();
					}
				}

				State = 1011; Match(RPAREN);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TtlExprContext : ParserRuleContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode DELETE() { return GetToken(ClickHouseParser.DELETE, 0); }
		public ITerminalNode TO() { return GetToken(ClickHouseParser.TO, 0); }
		public ITerminalNode DISK() { return GetToken(ClickHouseParser.DISK, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode VOLUME() { return GetToken(ClickHouseParser.VOLUME, 0); }
		public TtlExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ttlExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTtlExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTtlExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTtlExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TtlExprContext ttlExpr() {
		TtlExprContext _localctx = new TtlExprContext(_ctx, State);
		EnterRule(_localctx, 84, RULE_ttlExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1014; columnExpr(0);
			State = 1022;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,111,_ctx) ) {
			case 1:
				{
				State = 1015; Match(DELETE);
				}
				break;

			case 2:
				{
				State = 1016; Match(TO);
				State = 1017; Match(DISK);
				State = 1018; Match(STRING_LITERAL);
				}
				break;

			case 3:
				{
				State = 1019; Match(TO);
				State = 1020; Match(VOLUME);
				State = 1021; Match(STRING_LITERAL);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DescribeStmtContext : ParserRuleContext {
		public TableExprContext tableExpr() {
			return GetRuleContext<TableExprContext>(0);
		}
		public ITerminalNode DESCRIBE() { return GetToken(ClickHouseParser.DESCRIBE, 0); }
		public ITerminalNode DESC() { return GetToken(ClickHouseParser.DESC, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public DescribeStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_describeStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDescribeStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDescribeStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDescribeStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DescribeStmtContext describeStmt() {
		DescribeStmtContext _localctx = new DescribeStmtContext(_ctx, State);
		EnterRule(_localctx, 86, RULE_describeStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1024;
			_la = _input.La(1);
			if ( !(_la==DESC || _la==DESCRIBE) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			State = 1026;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,112,_ctx) ) {
			case 1:
				{
				State = 1025; Match(TABLE);
				}
				break;
			}
			State = 1028; tableExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DropStmtContext : ParserRuleContext {
		public DropStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dropStmt; } }
	 
		public DropStmtContext() { }
		public virtual void CopyFrom(DropStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DropDatabaseStmtContext : DropStmtContext {
		public ITerminalNode DATABASE() { return GetToken(ClickHouseParser.DATABASE, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ITerminalNode DETACH() { return GetToken(ClickHouseParser.DETACH, 0); }
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public DropDatabaseStmtContext(DropStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDropDatabaseStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDropDatabaseStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDropDatabaseStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DropTableStmtContext : DropStmtContext {
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode DETACH() { return GetToken(ClickHouseParser.DETACH, 0); }
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public ITerminalNode NO() { return GetToken(ClickHouseParser.NO, 0); }
		public ITerminalNode DELAY() { return GetToken(ClickHouseParser.DELAY, 0); }
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public DropTableStmtContext(DropStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDropTableStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDropTableStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDropTableStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DropStmtContext dropStmt() {
		DropStmtContext _localctx = new DropStmtContext(_ctx, State);
		EnterRule(_localctx, 88, RULE_dropStmt);
		int _la;
		try {
			State = 1061;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,120,_ctx) ) {
			case 1:
				_localctx = new DropDatabaseStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1030;
				_la = _input.La(1);
				if ( !(_la==DETACH || _la==DROP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1031; Match(DATABASE);
				State = 1034;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,113,_ctx) ) {
				case 1:
					{
					State = 1032; Match(IF);
					State = 1033; Match(EXISTS);
					}
					break;
				}
				State = 1036; databaseIdentifier();
				State = 1038;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 1037; clusterClause();
					}
				}

				}
				break;

			case 2:
				_localctx = new DropTableStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1040;
				_la = _input.La(1);
				if ( !(_la==DETACH || _la==DROP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1047;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case DICTIONARY:
					{
					State = 1041; Match(DICTIONARY);
					}
					break;
				case TABLE:
				case TEMPORARY:
					{
					State = 1043;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==TEMPORARY) {
						{
						State = 1042; Match(TEMPORARY);
						}
					}

					State = 1045; Match(TABLE);
					}
					break;
				case VIEW:
					{
					State = 1046; Match(VIEW);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1051;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,117,_ctx) ) {
				case 1:
					{
					State = 1049; Match(IF);
					State = 1050; Match(EXISTS);
					}
					break;
				}
				State = 1053; tableIdentifier();
				State = 1055;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ON) {
					{
					State = 1054; clusterClause();
					}
				}

				State = 1059;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==NO) {
					{
					State = 1057; Match(NO);
					State = 1058; Match(DELAY);
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExistsStmtContext : ParserRuleContext {
		public ExistsStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_existsStmt; } }
	 
		public ExistsStmtContext() { }
		public virtual void CopyFrom(ExistsStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ExistsTableStmtContext : ExistsStmtContext {
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public ExistsTableStmtContext(ExistsStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterExistsTableStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitExistsTableStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExistsTableStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExistsDatabaseStmtContext : ExistsStmtContext {
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode DATABASE() { return GetToken(ClickHouseParser.DATABASE, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ExistsDatabaseStmtContext(ExistsStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterExistsDatabaseStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitExistsDatabaseStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExistsDatabaseStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExistsStmtContext existsStmt() {
		ExistsStmtContext _localctx = new ExistsStmtContext(_ctx, State);
		EnterRule(_localctx, 90, RULE_existsStmt);
		int _la;
		try {
			State = 1076;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,123,_ctx) ) {
			case 1:
				_localctx = new ExistsDatabaseStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1063; Match(EXISTS);
				State = 1064; Match(DATABASE);
				State = 1065; databaseIdentifier();
				}
				break;

			case 2:
				_localctx = new ExistsTableStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1066; Match(EXISTS);
				State = 1073;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,122,_ctx) ) {
				case 1:
					{
					State = 1067; Match(DICTIONARY);
					}
					break;

				case 2:
					{
					State = 1069;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==TEMPORARY) {
						{
						State = 1068; Match(TEMPORARY);
						}
					}

					State = 1071; Match(TABLE);
					}
					break;

				case 3:
					{
					State = 1072; Match(VIEW);
					}
					break;
				}
				State = 1075; tableIdentifier();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExplainStmtContext : ParserRuleContext {
		public ExplainStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explainStmt; } }
	 
		public ExplainStmtContext() { }
		public virtual void CopyFrom(ExplainStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ExplainSyntaxStmtContext : ExplainStmtContext {
		public ITerminalNode EXPLAIN() { return GetToken(ClickHouseParser.EXPLAIN, 0); }
		public ITerminalNode SYNTAX() { return GetToken(ClickHouseParser.SYNTAX, 0); }
		public QueryContext query() {
			return GetRuleContext<QueryContext>(0);
		}
		public ExplainSyntaxStmtContext(ExplainStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterExplainSyntaxStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitExplainSyntaxStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExplainSyntaxStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExplainASTStmtContext : ExplainStmtContext {
		public ITerminalNode EXPLAIN() { return GetToken(ClickHouseParser.EXPLAIN, 0); }
		public ITerminalNode AST() { return GetToken(ClickHouseParser.AST, 0); }
		public QueryContext query() {
			return GetRuleContext<QueryContext>(0);
		}
		public ExplainASTStmtContext(ExplainStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterExplainASTStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitExplainASTStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExplainASTStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExplainStmtContext explainStmt() {
		ExplainStmtContext _localctx = new ExplainStmtContext(_ctx, State);
		EnterRule(_localctx, 92, RULE_explainStmt);
		try {
			State = 1084;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,124,_ctx) ) {
			case 1:
				_localctx = new ExplainASTStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1078; Match(EXPLAIN);
				State = 1079; Match(AST);
				State = 1080; query();
				}
				break;

			case 2:
				_localctx = new ExplainSyntaxStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1081; Match(EXPLAIN);
				State = 1082; Match(SYNTAX);
				State = 1083; query();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InsertStmtContext : ParserRuleContext {
		public ITerminalNode INSERT() { return GetToken(ClickHouseParser.INSERT, 0); }
		public ITerminalNode INTO() { return GetToken(ClickHouseParser.INTO, 0); }
		public DataClauseContext dataClause() {
			return GetRuleContext<DataClauseContext>(0);
		}
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode FUNCTION() { return GetToken(ClickHouseParser.FUNCTION, 0); }
		public TableFunctionExprContext tableFunctionExpr() {
			return GetRuleContext<TableFunctionExprContext>(0);
		}
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ColumnsClauseContext columnsClause() {
			return GetRuleContext<ColumnsClauseContext>(0);
		}
		public InsertStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_insertStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterInsertStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitInsertStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInsertStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InsertStmtContext insertStmt() {
		InsertStmtContext _localctx = new InsertStmtContext(_ctx, State);
		EnterRule(_localctx, 94, RULE_insertStmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1086; Match(INSERT);
			State = 1087; Match(INTO);
			State = 1089;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,125,_ctx) ) {
			case 1:
				{
				State = 1088; Match(TABLE);
				}
				break;
			}
			State = 1094;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,126,_ctx) ) {
			case 1:
				{
				State = 1091; tableIdentifier();
				}
				break;

			case 2:
				{
				State = 1092; Match(FUNCTION);
				State = 1093; tableFunctionExpr();
				}
				break;
			}
			State = 1097;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,127,_ctx) ) {
			case 1:
				{
				State = 1096; columnsClause();
				}
				break;
			}
			State = 1099; dataClause();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnsClauseContext : ParserRuleContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public NestedIdentifierContext[] nestedIdentifier() {
			return GetRuleContexts<NestedIdentifierContext>();
		}
		public NestedIdentifierContext nestedIdentifier(int i) {
			return GetRuleContext<NestedIdentifierContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnsClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnsClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnsClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnsClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnsClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnsClauseContext columnsClause() {
		ColumnsClauseContext _localctx = new ColumnsClauseContext(_ctx, State);
		EnterRule(_localctx, 96, RULE_columnsClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1101; Match(LPAREN);
			State = 1102; nestedIdentifier();
			State = 1107;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 1103; Match(COMMA);
				State = 1104; nestedIdentifier();
				}
				}
				State = 1109;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 1110; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DataClauseContext : ParserRuleContext {
		public DataClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dataClause; } }
	 
		public DataClauseContext() { }
		public virtual void CopyFrom(DataClauseContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DataClauseValuesContext : DataClauseContext {
		public ITerminalNode VALUES() { return GetToken(ClickHouseParser.VALUES, 0); }
		public DataClauseValuesContext(DataClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDataClauseValues(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDataClauseValues(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDataClauseValues(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DataClauseFormatContext : DataClauseContext {
		public ITerminalNode FORMAT() { return GetToken(ClickHouseParser.FORMAT, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public DataClauseFormatContext(DataClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDataClauseFormat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDataClauseFormat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDataClauseFormat(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DataClauseSelectContext : DataClauseContext {
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(ClickHouseParser.Eof, 0); }
		public ITerminalNode SEMICOLON() { return GetToken(ClickHouseParser.SEMICOLON, 0); }
		public DataClauseSelectContext(DataClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDataClauseSelect(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDataClauseSelect(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDataClauseSelect(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DataClauseContext dataClause() {
		DataClauseContext _localctx = new DataClauseContext(_ctx, State);
		EnterRule(_localctx, 98, RULE_dataClause);
		int _la;
		try {
			State = 1121;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case FORMAT:
				_localctx = new DataClauseFormatContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1112; Match(FORMAT);
				State = 1113; identifier();
				}
				break;
			case VALUES:
				_localctx = new DataClauseValuesContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1114; Match(VALUES);
				}
				break;
			case SELECT:
			case WITH:
			case LPAREN:
				_localctx = new DataClauseSelectContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1115; selectUnionStmt();
				State = 1117;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==SEMICOLON) {
					{
					State = 1116; Match(SEMICOLON);
					}
				}

				State = 1119; Match(Eof);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KillStmtContext : ParserRuleContext {
		public KillStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_killStmt; } }
	 
		public KillStmtContext() { }
		public virtual void CopyFrom(KillStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class KillMutationStmtContext : KillStmtContext {
		public ITerminalNode KILL() { return GetToken(ClickHouseParser.KILL, 0); }
		public ITerminalNode MUTATION() { return GetToken(ClickHouseParser.MUTATION, 0); }
		public WhereClauseContext whereClause() {
			return GetRuleContext<WhereClauseContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public ITerminalNode SYNC() { return GetToken(ClickHouseParser.SYNC, 0); }
		public ITerminalNode ASYNC() { return GetToken(ClickHouseParser.ASYNC, 0); }
		public ITerminalNode TEST() { return GetToken(ClickHouseParser.TEST, 0); }
		public KillMutationStmtContext(KillStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterKillMutationStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitKillMutationStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitKillMutationStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public KillStmtContext killStmt() {
		KillStmtContext _localctx = new KillStmtContext(_ctx, State);
		EnterRule(_localctx, 100, RULE_killStmt);
		int _la;
		try {
			_localctx = new KillMutationStmtContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 1123; Match(KILL);
			State = 1124; Match(MUTATION);
			State = 1126;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 1125; clusterClause();
				}
			}

			State = 1128; whereClause();
			State = 1130;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ASYNC || _la==SYNC || _la==TEST) {
				{
				State = 1129;
				_la = _input.La(1);
				if ( !(_la==ASYNC || _la==SYNC || _la==TEST) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OptimizeStmtContext : ParserRuleContext {
		public ITerminalNode OPTIMIZE() { return GetToken(ClickHouseParser.OPTIMIZE, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public PartitionClauseContext partitionClause() {
			return GetRuleContext<PartitionClauseContext>(0);
		}
		public ITerminalNode FINAL() { return GetToken(ClickHouseParser.FINAL, 0); }
		public ITerminalNode DEDUPLICATE() { return GetToken(ClickHouseParser.DEDUPLICATE, 0); }
		public OptimizeStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_optimizeStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterOptimizeStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitOptimizeStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOptimizeStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OptimizeStmtContext optimizeStmt() {
		OptimizeStmtContext _localctx = new OptimizeStmtContext(_ctx, State);
		EnterRule(_localctx, 102, RULE_optimizeStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1132; Match(OPTIMIZE);
			State = 1133; Match(TABLE);
			State = 1134; tableIdentifier();
			State = 1136;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 1135; clusterClause();
				}
			}

			State = 1139;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==PARTITION) {
				{
				State = 1138; partitionClause();
				}
			}

			State = 1142;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==FINAL) {
				{
				State = 1141; Match(FINAL);
				}
			}

			State = 1145;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==DEDUPLICATE) {
				{
				State = 1144; Match(DEDUPLICATE);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RenameStmtContext : ParserRuleContext {
		public ITerminalNode RENAME() { return GetToken(ClickHouseParser.RENAME, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public TableIdentifierContext[] tableIdentifier() {
			return GetRuleContexts<TableIdentifierContext>();
		}
		public TableIdentifierContext tableIdentifier(int i) {
			return GetRuleContext<TableIdentifierContext>(i);
		}
		public ITerminalNode[] TO() { return GetTokens(ClickHouseParser.TO); }
		public ITerminalNode TO(int i) {
			return GetToken(ClickHouseParser.TO, i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public RenameStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_renameStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterRenameStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitRenameStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRenameStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RenameStmtContext renameStmt() {
		RenameStmtContext _localctx = new RenameStmtContext(_ctx, State);
		EnterRule(_localctx, 104, RULE_renameStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1147; Match(RENAME);
			State = 1148; Match(TABLE);
			State = 1149; tableIdentifier();
			State = 1150; Match(TO);
			State = 1151; tableIdentifier();
			State = 1159;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 1152; Match(COMMA);
				State = 1153; tableIdentifier();
				State = 1154; Match(TO);
				State = 1155; tableIdentifier();
				}
				}
				State = 1161;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 1163;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 1162; clusterClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProjectionSelectStmtContext : ParserRuleContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode SELECT() { return GetToken(ClickHouseParser.SELECT, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public WithClauseContext withClause() {
			return GetRuleContext<WithClauseContext>(0);
		}
		public GroupByClauseContext groupByClause() {
			return GetRuleContext<GroupByClauseContext>(0);
		}
		public ProjectionOrderByClauseContext projectionOrderByClause() {
			return GetRuleContext<ProjectionOrderByClauseContext>(0);
		}
		public ProjectionSelectStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_projectionSelectStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterProjectionSelectStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitProjectionSelectStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProjectionSelectStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProjectionSelectStmtContext projectionSelectStmt() {
		ProjectionSelectStmtContext _localctx = new ProjectionSelectStmtContext(_ctx, State);
		EnterRule(_localctx, 106, RULE_projectionSelectStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1165; Match(LPAREN);
			State = 1167;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WITH) {
				{
				State = 1166; withClause();
				}
			}

			State = 1169; Match(SELECT);
			State = 1170; columnExprList();
			State = 1172;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==GROUP) {
				{
				State = 1171; groupByClause();
				}
			}

			State = 1175;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ORDER) {
				{
				State = 1174; projectionOrderByClause();
				}
			}

			State = 1177; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectUnionStmtContext : ParserRuleContext {
		public SelectStmtWithParensContext[] selectStmtWithParens() {
			return GetRuleContexts<SelectStmtWithParensContext>();
		}
		public SelectStmtWithParensContext selectStmtWithParens(int i) {
			return GetRuleContext<SelectStmtWithParensContext>(i);
		}
		public ITerminalNode[] UNION() { return GetTokens(ClickHouseParser.UNION); }
		public ITerminalNode UNION(int i) {
			return GetToken(ClickHouseParser.UNION, i);
		}
		public ITerminalNode[] ALL() { return GetTokens(ClickHouseParser.ALL); }
		public ITerminalNode ALL(int i) {
			return GetToken(ClickHouseParser.ALL, i);
		}
		public SelectUnionStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectUnionStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSelectUnionStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSelectUnionStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelectUnionStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SelectUnionStmtContext selectUnionStmt() {
		SelectUnionStmtContext _localctx = new SelectUnionStmtContext(_ctx, State);
		EnterRule(_localctx, 108, RULE_selectUnionStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1179; selectStmtWithParens();
			State = 1185;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==UNION) {
				{
				{
				State = 1180; Match(UNION);
				State = 1181; Match(ALL);
				State = 1182; selectStmtWithParens();
				}
				}
				State = 1187;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectStmtWithParensContext : ParserRuleContext {
		public SelectStmtContext selectStmt() {
			return GetRuleContext<SelectStmtContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public SelectStmtWithParensContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectStmtWithParens; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSelectStmtWithParens(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSelectStmtWithParens(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelectStmtWithParens(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SelectStmtWithParensContext selectStmtWithParens() {
		SelectStmtWithParensContext _localctx = new SelectStmtWithParensContext(_ctx, State);
		EnterRule(_localctx, 110, RULE_selectStmtWithParens);
		try {
			State = 1193;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case SELECT:
			case WITH:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1188; selectStmt();
				}
				break;
			case LPAREN:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1189; Match(LPAREN);
				State = 1190; selectUnionStmt();
				State = 1191; Match(RPAREN);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectStmtContext : ParserRuleContext {
		public ITerminalNode SELECT() { return GetToken(ClickHouseParser.SELECT, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public WithClauseContext withClause() {
			return GetRuleContext<WithClauseContext>(0);
		}
		public ITerminalNode DISTINCT() { return GetToken(ClickHouseParser.DISTINCT, 0); }
		public TopClauseContext topClause() {
			return GetRuleContext<TopClauseContext>(0);
		}
		public FromClauseContext fromClause() {
			return GetRuleContext<FromClauseContext>(0);
		}
		public ArrayJoinClauseContext arrayJoinClause() {
			return GetRuleContext<ArrayJoinClauseContext>(0);
		}
		public WindowClauseContext windowClause() {
			return GetRuleContext<WindowClauseContext>(0);
		}
		public PrewhereClauseContext prewhereClause() {
			return GetRuleContext<PrewhereClauseContext>(0);
		}
		public WhereClauseContext whereClause() {
			return GetRuleContext<WhereClauseContext>(0);
		}
		public GroupByClauseContext groupByClause() {
			return GetRuleContext<GroupByClauseContext>(0);
		}
		public ITerminalNode[] WITH() { return GetTokens(ClickHouseParser.WITH); }
		public ITerminalNode WITH(int i) {
			return GetToken(ClickHouseParser.WITH, i);
		}
		public ITerminalNode TOTALS() { return GetToken(ClickHouseParser.TOTALS, 0); }
		public HavingClauseContext havingClause() {
			return GetRuleContext<HavingClauseContext>(0);
		}
		public OrderByClauseContext orderByClause() {
			return GetRuleContext<OrderByClauseContext>(0);
		}
		public LimitByClauseContext limitByClause() {
			return GetRuleContext<LimitByClauseContext>(0);
		}
		public LimitClauseContext limitClause() {
			return GetRuleContext<LimitClauseContext>(0);
		}
		public SettingsClauseContext settingsClause() {
			return GetRuleContext<SettingsClauseContext>(0);
		}
		public ITerminalNode CUBE() { return GetToken(ClickHouseParser.CUBE, 0); }
		public ITerminalNode ROLLUP() { return GetToken(ClickHouseParser.ROLLUP, 0); }
		public SelectStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSelectStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSelectStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelectStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SelectStmtContext selectStmt() {
		SelectStmtContext _localctx = new SelectStmtContext(_ctx, State);
		EnterRule(_localctx, 112, RULE_selectStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1196;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WITH) {
				{
				State = 1195; withClause();
				}
			}

			State = 1198; Match(SELECT);
			State = 1200;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,145,_ctx) ) {
			case 1:
				{
				State = 1199; Match(DISTINCT);
				}
				break;
			}
			State = 1203;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,146,_ctx) ) {
			case 1:
				{
				State = 1202; topClause();
				}
				break;
			}
			State = 1205; columnExprList();
			State = 1207;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==FROM) {
				{
				State = 1206; fromClause();
				}
			}

			State = 1210;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ARRAY || _la==INNER || _la==LEFT) {
				{
				State = 1209; arrayJoinClause();
				}
			}

			State = 1213;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WINDOW) {
				{
				State = 1212; windowClause();
				}
			}

			State = 1216;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==PREWHERE) {
				{
				State = 1215; prewhereClause();
				}
			}

			State = 1219;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WHERE) {
				{
				State = 1218; whereClause();
				}
			}

			State = 1222;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==GROUP) {
				{
				State = 1221; groupByClause();
				}
			}

			State = 1226;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,153,_ctx) ) {
			case 1:
				{
				State = 1224; Match(WITH);
				State = 1225;
				_la = _input.La(1);
				if ( !(_la==CUBE || _la==ROLLUP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;
			}
			State = 1230;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WITH) {
				{
				State = 1228; Match(WITH);
				State = 1229; Match(TOTALS);
				}
			}

			State = 1233;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==HAVING) {
				{
				State = 1232; havingClause();
				}
			}

			State = 1236;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ORDER) {
				{
				State = 1235; orderByClause();
				}
			}

			State = 1239;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,157,_ctx) ) {
			case 1:
				{
				State = 1238; limitByClause();
				}
				break;
			}
			State = 1242;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==LIMIT) {
				{
				State = 1241; limitClause();
				}
			}

			State = 1245;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==SETTINGS) {
				{
				State = 1244; settingsClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WithClauseContext : ParserRuleContext {
		public ITerminalNode WITH() { return GetToken(ClickHouseParser.WITH, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public WithClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_withClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWithClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWithClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWithClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WithClauseContext withClause() {
		WithClauseContext _localctx = new WithClauseContext(_ctx, State);
		EnterRule(_localctx, 114, RULE_withClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1247; Match(WITH);
			State = 1248; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TopClauseContext : ParserRuleContext {
		public ITerminalNode TOP() { return GetToken(ClickHouseParser.TOP, 0); }
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public ITerminalNode WITH() { return GetToken(ClickHouseParser.WITH, 0); }
		public ITerminalNode TIES() { return GetToken(ClickHouseParser.TIES, 0); }
		public TopClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_topClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTopClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTopClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTopClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TopClauseContext topClause() {
		TopClauseContext _localctx = new TopClauseContext(_ctx, State);
		EnterRule(_localctx, 116, RULE_topClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1250; Match(TOP);
			State = 1251; Match(DECIMAL_LITERAL);
			State = 1254;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,160,_ctx) ) {
			case 1:
				{
				State = 1252; Match(WITH);
				State = 1253; Match(TIES);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FromClauseContext : ParserRuleContext {
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public JoinExprContext joinExpr() {
			return GetRuleContext<JoinExprContext>(0);
		}
		public FromClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fromClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterFromClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitFromClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFromClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FromClauseContext fromClause() {
		FromClauseContext _localctx = new FromClauseContext(_ctx, State);
		EnterRule(_localctx, 118, RULE_fromClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1256; Match(FROM);
			State = 1257; joinExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArrayJoinClauseContext : ParserRuleContext {
		public ITerminalNode ARRAY() { return GetToken(ClickHouseParser.ARRAY, 0); }
		public ITerminalNode JOIN() { return GetToken(ClickHouseParser.JOIN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ITerminalNode LEFT() { return GetToken(ClickHouseParser.LEFT, 0); }
		public ITerminalNode INNER() { return GetToken(ClickHouseParser.INNER, 0); }
		public ArrayJoinClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayJoinClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterArrayJoinClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitArrayJoinClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArrayJoinClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArrayJoinClauseContext arrayJoinClause() {
		ArrayJoinClauseContext _localctx = new ArrayJoinClauseContext(_ctx, State);
		EnterRule(_localctx, 120, RULE_arrayJoinClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1260;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==INNER || _la==LEFT) {
				{
				State = 1259;
				_la = _input.La(1);
				if ( !(_la==INNER || _la==LEFT) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
			}

			State = 1262; Match(ARRAY);
			State = 1263; Match(JOIN);
			State = 1264; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WindowClauseContext : ParserRuleContext {
		public ITerminalNode WINDOW() { return GetToken(ClickHouseParser.WINDOW, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public WindowExprContext windowExpr() {
			return GetRuleContext<WindowExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public WindowClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_windowClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWindowClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWindowClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWindowClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WindowClauseContext windowClause() {
		WindowClauseContext _localctx = new WindowClauseContext(_ctx, State);
		EnterRule(_localctx, 122, RULE_windowClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1266; Match(WINDOW);
			State = 1267; identifier();
			State = 1268; Match(AS);
			State = 1269; Match(LPAREN);
			State = 1270; windowExpr();
			State = 1271; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrewhereClauseContext : ParserRuleContext {
		public ITerminalNode PREWHERE() { return GetToken(ClickHouseParser.PREWHERE, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public PrewhereClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prewhereClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterPrewhereClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitPrewhereClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrewhereClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrewhereClauseContext prewhereClause() {
		PrewhereClauseContext _localctx = new PrewhereClauseContext(_ctx, State);
		EnterRule(_localctx, 124, RULE_prewhereClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1273; Match(PREWHERE);
			State = 1274; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereClauseContext : ParserRuleContext {
		public ITerminalNode WHERE() { return GetToken(ClickHouseParser.WHERE, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public WhereClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWhereClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWhereClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWhereClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WhereClauseContext whereClause() {
		WhereClauseContext _localctx = new WhereClauseContext(_ctx, State);
		EnterRule(_localctx, 126, RULE_whereClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1276; Match(WHERE);
			State = 1277; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GroupByClauseContext : ParserRuleContext {
		public ITerminalNode GROUP() { return GetToken(ClickHouseParser.GROUP, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode CUBE() { return GetToken(ClickHouseParser.CUBE, 0); }
		public ITerminalNode ROLLUP() { return GetToken(ClickHouseParser.ROLLUP, 0); }
		public GroupByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_groupByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterGroupByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitGroupByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGroupByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GroupByClauseContext groupByClause() {
		GroupByClauseContext _localctx = new GroupByClauseContext(_ctx, State);
		EnterRule(_localctx, 128, RULE_groupByClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1279; Match(GROUP);
			State = 1280; Match(BY);
			State = 1287;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,162,_ctx) ) {
			case 1:
				{
				State = 1281;
				_la = _input.La(1);
				if ( !(_la==CUBE || _la==ROLLUP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1282; Match(LPAREN);
				State = 1283; columnExprList();
				State = 1284; Match(RPAREN);
				}
				break;

			case 2:
				{
				State = 1286; columnExprList();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HavingClauseContext : ParserRuleContext {
		public ITerminalNode HAVING() { return GetToken(ClickHouseParser.HAVING, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public HavingClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_havingClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterHavingClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitHavingClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHavingClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HavingClauseContext havingClause() {
		HavingClauseContext _localctx = new HavingClauseContext(_ctx, State);
		EnterRule(_localctx, 130, RULE_havingClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1289; Match(HAVING);
			State = 1290; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OrderByClauseContext : ParserRuleContext {
		public ITerminalNode ORDER() { return GetToken(ClickHouseParser.ORDER, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public OrderExprListContext orderExprList() {
			return GetRuleContext<OrderExprListContext>(0);
		}
		public OrderByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orderByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterOrderByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitOrderByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOrderByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OrderByClauseContext orderByClause() {
		OrderByClauseContext _localctx = new OrderByClauseContext(_ctx, State);
		EnterRule(_localctx, 132, RULE_orderByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1292; Match(ORDER);
			State = 1293; Match(BY);
			State = 1294; orderExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProjectionOrderByClauseContext : ParserRuleContext {
		public ITerminalNode ORDER() { return GetToken(ClickHouseParser.ORDER, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ProjectionOrderByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_projectionOrderByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterProjectionOrderByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitProjectionOrderByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProjectionOrderByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProjectionOrderByClauseContext projectionOrderByClause() {
		ProjectionOrderByClauseContext _localctx = new ProjectionOrderByClauseContext(_ctx, State);
		EnterRule(_localctx, 134, RULE_projectionOrderByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1296; Match(ORDER);
			State = 1297; Match(BY);
			State = 1298; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LimitByClauseContext : ParserRuleContext {
		public ITerminalNode LIMIT() { return GetToken(ClickHouseParser.LIMIT, 0); }
		public LimitExprContext limitExpr() {
			return GetRuleContext<LimitExprContext>(0);
		}
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public LimitByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_limitByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLimitByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLimitByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLimitByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LimitByClauseContext limitByClause() {
		LimitByClauseContext _localctx = new LimitByClauseContext(_ctx, State);
		EnterRule(_localctx, 136, RULE_limitByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1300; Match(LIMIT);
			State = 1301; limitExpr();
			State = 1302; Match(BY);
			State = 1303; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LimitClauseContext : ParserRuleContext {
		public ITerminalNode LIMIT() { return GetToken(ClickHouseParser.LIMIT, 0); }
		public LimitExprContext limitExpr() {
			return GetRuleContext<LimitExprContext>(0);
		}
		public ITerminalNode WITH() { return GetToken(ClickHouseParser.WITH, 0); }
		public ITerminalNode TIES() { return GetToken(ClickHouseParser.TIES, 0); }
		public LimitClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_limitClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLimitClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLimitClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLimitClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LimitClauseContext limitClause() {
		LimitClauseContext _localctx = new LimitClauseContext(_ctx, State);
		EnterRule(_localctx, 138, RULE_limitClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1305; Match(LIMIT);
			State = 1306; limitExpr();
			State = 1309;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==WITH) {
				{
				State = 1307; Match(WITH);
				State = 1308; Match(TIES);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SettingsClauseContext : ParserRuleContext {
		public ITerminalNode SETTINGS() { return GetToken(ClickHouseParser.SETTINGS, 0); }
		public SettingExprListContext settingExprList() {
			return GetRuleContext<SettingExprListContext>(0);
		}
		public SettingsClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_settingsClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSettingsClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSettingsClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSettingsClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SettingsClauseContext settingsClause() {
		SettingsClauseContext _localctx = new SettingsClauseContext(_ctx, State);
		EnterRule(_localctx, 140, RULE_settingsClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1311; Match(SETTINGS);
			State = 1312; settingExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinExprContext : ParserRuleContext {
		public JoinExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinExpr; } }
	 
		public JoinExprContext() { }
		public virtual void CopyFrom(JoinExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class JoinExprOpContext : JoinExprContext {
		public JoinExprContext[] joinExpr() {
			return GetRuleContexts<JoinExprContext>();
		}
		public JoinExprContext joinExpr(int i) {
			return GetRuleContext<JoinExprContext>(i);
		}
		public ITerminalNode JOIN() { return GetToken(ClickHouseParser.JOIN, 0); }
		public JoinConstraintClauseContext joinConstraintClause() {
			return GetRuleContext<JoinConstraintClauseContext>(0);
		}
		public JoinOpContext joinOp() {
			return GetRuleContext<JoinOpContext>(0);
		}
		public ITerminalNode GLOBAL() { return GetToken(ClickHouseParser.GLOBAL, 0); }
		public ITerminalNode LOCAL() { return GetToken(ClickHouseParser.LOCAL, 0); }
		public JoinExprOpContext(JoinExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinExprOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinExprOp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinExprOp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class JoinExprTableContext : JoinExprContext {
		public TableExprContext tableExpr() {
			return GetRuleContext<TableExprContext>(0);
		}
		public ITerminalNode FINAL() { return GetToken(ClickHouseParser.FINAL, 0); }
		public SampleClauseContext sampleClause() {
			return GetRuleContext<SampleClauseContext>(0);
		}
		public JoinExprTableContext(JoinExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinExprTable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinExprTable(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinExprTable(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class JoinExprCrossOpContext : JoinExprContext {
		public JoinExprContext[] joinExpr() {
			return GetRuleContexts<JoinExprContext>();
		}
		public JoinExprContext joinExpr(int i) {
			return GetRuleContext<JoinExprContext>(i);
		}
		public JoinOpCrossContext joinOpCross() {
			return GetRuleContext<JoinOpCrossContext>(0);
		}
		public JoinExprCrossOpContext(JoinExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinExprCrossOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinExprCrossOp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinExprCrossOp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class JoinExprParensContext : JoinExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public JoinExprContext joinExpr() {
			return GetRuleContext<JoinExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public JoinExprParensContext(JoinExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinExprParens(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinExprParens(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinExprParens(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public JoinExprContext joinExpr() {
		return joinExpr(0);
	}

	private JoinExprContext joinExpr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		JoinExprContext _localctx = new JoinExprContext(_ctx, _parentState);
		JoinExprContext _prevctx = _localctx;
		int _startState = 142;
		EnterRecursionRule(_localctx, 142, RULE_joinExpr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1326;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,166,_ctx) ) {
			case 1:
				{
				_localctx = new JoinExprTableContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 1315; tableExpr(0);
				State = 1317;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,164,_ctx) ) {
				case 1:
					{
					State = 1316; Match(FINAL);
					}
					break;
				}
				State = 1320;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,165,_ctx) ) {
				case 1:
					{
					State = 1319; sampleClause();
					}
					break;
				}
				}
				break;

			case 2:
				{
				_localctx = new JoinExprParensContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1322; Match(LPAREN);
				State = 1323; joinExpr(0);
				State = 1324; Match(RPAREN);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 1345;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,170,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1343;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,169,_ctx) ) {
					case 1:
						{
						_localctx = new JoinExprCrossOpContext(new JoinExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_joinExpr);
						State = 1328;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 1329; joinOpCross();
						State = 1330; joinExpr(4);
						}
						break;

					case 2:
						{
						_localctx = new JoinExprOpContext(new JoinExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_joinExpr);
						State = 1332;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 1334;
						_errHandler.Sync(this);
						_la = _input.La(1);
						if (_la==GLOBAL || _la==LOCAL) {
							{
							State = 1333;
							_la = _input.La(1);
							if ( !(_la==GLOBAL || _la==LOCAL) ) {
							_errHandler.RecoverInline(this);
							} else {
								if (_input.La(1) == TokenConstants.Eof) {
									matchedEOF = true;
								}

								_errHandler.ReportMatch(this);
								Consume();
							}
							}
						}

						State = 1337;
						_errHandler.Sync(this);
						_la = _input.La(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANTI) | (1L << ANY) | (1L << ASOF))) != 0) || ((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (FULL - 68)) | (1L << (INNER - 68)) | (1L << (LEFT - 68)))) != 0) || _la==RIGHT || _la==SEMI) {
							{
							State = 1336; joinOp();
							}
						}

						State = 1339; Match(JOIN);
						State = 1340; joinExpr(0);
						State = 1341; joinConstraintClause();
						}
						break;
					}
					} 
				}
				State = 1347;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,170,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class JoinOpContext : ParserRuleContext {
		public JoinOpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinOp; } }
	 
		public JoinOpContext() { }
		public virtual void CopyFrom(JoinOpContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class JoinOpFullContext : JoinOpContext {
		public ITerminalNode FULL() { return GetToken(ClickHouseParser.FULL, 0); }
		public ITerminalNode OUTER() { return GetToken(ClickHouseParser.OUTER, 0); }
		public ITerminalNode ALL() { return GetToken(ClickHouseParser.ALL, 0); }
		public ITerminalNode ANY() { return GetToken(ClickHouseParser.ANY, 0); }
		public JoinOpFullContext(JoinOpContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinOpFull(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinOpFull(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinOpFull(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class JoinOpInnerContext : JoinOpContext {
		public ITerminalNode INNER() { return GetToken(ClickHouseParser.INNER, 0); }
		public ITerminalNode ALL() { return GetToken(ClickHouseParser.ALL, 0); }
		public ITerminalNode ANY() { return GetToken(ClickHouseParser.ANY, 0); }
		public ITerminalNode ASOF() { return GetToken(ClickHouseParser.ASOF, 0); }
		public JoinOpInnerContext(JoinOpContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinOpInner(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinOpInner(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinOpInner(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class JoinOpLeftRightContext : JoinOpContext {
		public ITerminalNode LEFT() { return GetToken(ClickHouseParser.LEFT, 0); }
		public ITerminalNode RIGHT() { return GetToken(ClickHouseParser.RIGHT, 0); }
		public ITerminalNode OUTER() { return GetToken(ClickHouseParser.OUTER, 0); }
		public ITerminalNode SEMI() { return GetToken(ClickHouseParser.SEMI, 0); }
		public ITerminalNode ALL() { return GetToken(ClickHouseParser.ALL, 0); }
		public ITerminalNode ANTI() { return GetToken(ClickHouseParser.ANTI, 0); }
		public ITerminalNode ANY() { return GetToken(ClickHouseParser.ANY, 0); }
		public ITerminalNode ASOF() { return GetToken(ClickHouseParser.ASOF, 0); }
		public JoinOpLeftRightContext(JoinOpContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinOpLeftRight(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinOpLeftRight(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinOpLeftRight(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public JoinOpContext joinOp() {
		JoinOpContext _localctx = new JoinOpContext(_ctx, State);
		EnterRule(_localctx, 144, RULE_joinOp);
		int _la;
		try {
			State = 1391;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,184,_ctx) ) {
			case 1:
				_localctx = new JoinOpInnerContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1357;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,173,_ctx) ) {
				case 1:
					{
					State = 1349;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANY) | (1L << ASOF))) != 0)) {
						{
						State = 1348;
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANY) | (1L << ASOF))) != 0)) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					State = 1351; Match(INNER);
					}
					break;

				case 2:
					{
					State = 1352; Match(INNER);
					State = 1354;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANY) | (1L << ASOF))) != 0)) {
						{
						State = 1353;
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANY) | (1L << ASOF))) != 0)) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					}
					break;

				case 3:
					{
					State = 1356;
					_la = _input.La(1);
					if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANY) | (1L << ASOF))) != 0)) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					}
					break;
				}
				}
				break;

			case 2:
				_localctx = new JoinOpLeftRightContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1373;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,178,_ctx) ) {
				case 1:
					{
					State = 1360;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANTI) | (1L << ANY) | (1L << ASOF))) != 0) || _la==SEMI) {
						{
						State = 1359;
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANTI) | (1L << ANY) | (1L << ASOF))) != 0) || _la==SEMI) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					State = 1362;
					_la = _input.La(1);
					if ( !(_la==LEFT || _la==RIGHT) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					State = 1364;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OUTER) {
						{
						State = 1363; Match(OUTER);
						}
					}

					}
					break;

				case 2:
					{
					State = 1366;
					_la = _input.La(1);
					if ( !(_la==LEFT || _la==RIGHT) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					State = 1368;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OUTER) {
						{
						State = 1367; Match(OUTER);
						}
					}

					State = 1371;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANTI) | (1L << ANY) | (1L << ASOF))) != 0) || _la==SEMI) {
						{
						State = 1370;
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ALL) | (1L << ANTI) | (1L << ANY) | (1L << ASOF))) != 0) || _la==SEMI) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					}
					break;
				}
				}
				break;

			case 3:
				_localctx = new JoinOpFullContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1389;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,183,_ctx) ) {
				case 1:
					{
					State = 1376;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==ALL || _la==ANY) {
						{
						State = 1375;
						_la = _input.La(1);
						if ( !(_la==ALL || _la==ANY) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					State = 1378; Match(FULL);
					State = 1380;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OUTER) {
						{
						State = 1379; Match(OUTER);
						}
					}

					}
					break;

				case 2:
					{
					State = 1382; Match(FULL);
					State = 1384;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==OUTER) {
						{
						State = 1383; Match(OUTER);
						}
					}

					State = 1387;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==ALL || _la==ANY) {
						{
						State = 1386;
						_la = _input.La(1);
						if ( !(_la==ALL || _la==ANY) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						}
					}

					}
					break;
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinOpCrossContext : ParserRuleContext {
		public ITerminalNode CROSS() { return GetToken(ClickHouseParser.CROSS, 0); }
		public ITerminalNode JOIN() { return GetToken(ClickHouseParser.JOIN, 0); }
		public ITerminalNode GLOBAL() { return GetToken(ClickHouseParser.GLOBAL, 0); }
		public ITerminalNode LOCAL() { return GetToken(ClickHouseParser.LOCAL, 0); }
		public ITerminalNode COMMA() { return GetToken(ClickHouseParser.COMMA, 0); }
		public JoinOpCrossContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinOpCross; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinOpCross(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinOpCross(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinOpCross(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public JoinOpCrossContext joinOpCross() {
		JoinOpCrossContext _localctx = new JoinOpCrossContext(_ctx, State);
		EnterRule(_localctx, 146, RULE_joinOpCross);
		int _la;
		try {
			State = 1399;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case CROSS:
			case GLOBAL:
			case LOCAL:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1394;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==GLOBAL || _la==LOCAL) {
					{
					State = 1393;
					_la = _input.La(1);
					if ( !(_la==GLOBAL || _la==LOCAL) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					}
				}

				State = 1396; Match(CROSS);
				State = 1397; Match(JOIN);
				}
				break;
			case COMMA:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1398; Match(COMMA);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JoinConstraintClauseContext : ParserRuleContext {
		public ITerminalNode ON() { return GetToken(ClickHouseParser.ON, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ITerminalNode USING() { return GetToken(ClickHouseParser.USING, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public JoinConstraintClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_joinConstraintClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterJoinConstraintClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitJoinConstraintClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitJoinConstraintClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public JoinConstraintClauseContext joinConstraintClause() {
		JoinConstraintClauseContext _localctx = new JoinConstraintClauseContext(_ctx, State);
		EnterRule(_localctx, 148, RULE_joinConstraintClause);
		try {
			State = 1410;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,187,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1401; Match(ON);
				State = 1402; columnExprList();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1403; Match(USING);
				State = 1404; Match(LPAREN);
				State = 1405; columnExprList();
				State = 1406; Match(RPAREN);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1408; Match(USING);
				State = 1409; columnExprList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SampleClauseContext : ParserRuleContext {
		public ITerminalNode SAMPLE() { return GetToken(ClickHouseParser.SAMPLE, 0); }
		public RatioExprContext[] ratioExpr() {
			return GetRuleContexts<RatioExprContext>();
		}
		public RatioExprContext ratioExpr(int i) {
			return GetRuleContext<RatioExprContext>(i);
		}
		public ITerminalNode OFFSET() { return GetToken(ClickHouseParser.OFFSET, 0); }
		public SampleClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sampleClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSampleClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSampleClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSampleClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SampleClauseContext sampleClause() {
		SampleClauseContext _localctx = new SampleClauseContext(_ctx, State);
		EnterRule(_localctx, 150, RULE_sampleClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1412; Match(SAMPLE);
			State = 1413; ratioExpr();
			State = 1416;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,188,_ctx) ) {
			case 1:
				{
				State = 1414; Match(OFFSET);
				State = 1415; ratioExpr();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LimitExprContext : ParserRuleContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode COMMA() { return GetToken(ClickHouseParser.COMMA, 0); }
		public ITerminalNode OFFSET() { return GetToken(ClickHouseParser.OFFSET, 0); }
		public LimitExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_limitExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLimitExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLimitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLimitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LimitExprContext limitExpr() {
		LimitExprContext _localctx = new LimitExprContext(_ctx, State);
		EnterRule(_localctx, 152, RULE_limitExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1418; columnExpr(0);
			State = 1421;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==OFFSET || _la==COMMA) {
				{
				State = 1419;
				_la = _input.La(1);
				if ( !(_la==OFFSET || _la==COMMA) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1420; columnExpr(0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OrderExprListContext : ParserRuleContext {
		public OrderExprContext[] orderExpr() {
			return GetRuleContexts<OrderExprContext>();
		}
		public OrderExprContext orderExpr(int i) {
			return GetRuleContext<OrderExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public OrderExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orderExprList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterOrderExprList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitOrderExprList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOrderExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OrderExprListContext orderExprList() {
		OrderExprListContext _localctx = new OrderExprListContext(_ctx, State);
		EnterRule(_localctx, 154, RULE_orderExprList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1423; orderExpr();
			State = 1428;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,190,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 1424; Match(COMMA);
					State = 1425; orderExpr();
					}
					} 
				}
				State = 1430;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,190,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OrderExprContext : ParserRuleContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode NULLS() { return GetToken(ClickHouseParser.NULLS, 0); }
		public ITerminalNode COLLATE() { return GetToken(ClickHouseParser.COLLATE, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode ASCENDING() { return GetToken(ClickHouseParser.ASCENDING, 0); }
		public ITerminalNode DESCENDING() { return GetToken(ClickHouseParser.DESCENDING, 0); }
		public ITerminalNode DESC() { return GetToken(ClickHouseParser.DESC, 0); }
		public ITerminalNode FIRST() { return GetToken(ClickHouseParser.FIRST, 0); }
		public ITerminalNode LAST() { return GetToken(ClickHouseParser.LAST, 0); }
		public OrderExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orderExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterOrderExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitOrderExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOrderExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OrderExprContext orderExpr() {
		OrderExprContext _localctx = new OrderExprContext(_ctx, State);
		EnterRule(_localctx, 156, RULE_orderExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1431; columnExpr(0);
			State = 1433;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,191,_ctx) ) {
			case 1:
				{
				State = 1432;
				_la = _input.La(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ASCENDING) | (1L << DESC) | (1L << DESCENDING))) != 0)) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;
			}
			State = 1437;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,192,_ctx) ) {
			case 1:
				{
				State = 1435; Match(NULLS);
				State = 1436;
				_la = _input.La(1);
				if ( !(_la==FIRST || _la==LAST) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;
			}
			State = 1441;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,193,_ctx) ) {
			case 1:
				{
				State = 1439; Match(COLLATE);
				State = 1440; Match(STRING_LITERAL);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RatioExprContext : ParserRuleContext {
		public NumberLiteralContext[] numberLiteral() {
			return GetRuleContexts<NumberLiteralContext>();
		}
		public NumberLiteralContext numberLiteral(int i) {
			return GetRuleContext<NumberLiteralContext>(i);
		}
		public ITerminalNode SLASH() { return GetToken(ClickHouseParser.SLASH, 0); }
		public RatioExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ratioExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterRatioExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitRatioExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRatioExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RatioExprContext ratioExpr() {
		RatioExprContext _localctx = new RatioExprContext(_ctx, State);
		EnterRule(_localctx, 158, RULE_ratioExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1443; numberLiteral();
			State = 1446;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,194,_ctx) ) {
			case 1:
				{
				State = 1444; Match(SLASH);
				State = 1445; numberLiteral();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SettingExprListContext : ParserRuleContext {
		public SettingExprContext[] settingExpr() {
			return GetRuleContexts<SettingExprContext>();
		}
		public SettingExprContext settingExpr(int i) {
			return GetRuleContext<SettingExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public SettingExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_settingExprList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSettingExprList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSettingExprList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSettingExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SettingExprListContext settingExprList() {
		SettingExprListContext _localctx = new SettingExprListContext(_ctx, State);
		EnterRule(_localctx, 160, RULE_settingExprList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1448; settingExpr();
			State = 1453;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,195,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 1449; Match(COMMA);
					State = 1450; settingExpr();
					}
					} 
				}
				State = 1455;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,195,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SettingExprContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode EQ_SINGLE() { return GetToken(ClickHouseParser.EQ_SINGLE, 0); }
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public SettingExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_settingExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSettingExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSettingExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSettingExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SettingExprContext settingExpr() {
		SettingExprContext _localctx = new SettingExprContext(_ctx, State);
		EnterRule(_localctx, 162, RULE_settingExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1456; identifier();
			State = 1457; Match(EQ_SINGLE);
			State = 1458; literal();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WindowExprContext : ParserRuleContext {
		public WinPartitionByClauseContext winPartitionByClause() {
			return GetRuleContext<WinPartitionByClauseContext>(0);
		}
		public WinOrderByClauseContext winOrderByClause() {
			return GetRuleContext<WinOrderByClauseContext>(0);
		}
		public WinFrameClauseContext winFrameClause() {
			return GetRuleContext<WinFrameClauseContext>(0);
		}
		public WindowExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_windowExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWindowExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWindowExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWindowExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WindowExprContext windowExpr() {
		WindowExprContext _localctx = new WindowExprContext(_ctx, State);
		EnterRule(_localctx, 164, RULE_windowExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1461;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==PARTITION) {
				{
				State = 1460; winPartitionByClause();
				}
			}

			State = 1464;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ORDER) {
				{
				State = 1463; winOrderByClause();
				}
			}

			State = 1467;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==RANGE || _la==ROWS) {
				{
				State = 1466; winFrameClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WinPartitionByClauseContext : ParserRuleContext {
		public ITerminalNode PARTITION() { return GetToken(ClickHouseParser.PARTITION, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public WinPartitionByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_winPartitionByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWinPartitionByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWinPartitionByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWinPartitionByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WinPartitionByClauseContext winPartitionByClause() {
		WinPartitionByClauseContext _localctx = new WinPartitionByClauseContext(_ctx, State);
		EnterRule(_localctx, 166, RULE_winPartitionByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1469; Match(PARTITION);
			State = 1470; Match(BY);
			State = 1471; columnExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WinOrderByClauseContext : ParserRuleContext {
		public ITerminalNode ORDER() { return GetToken(ClickHouseParser.ORDER, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public OrderExprListContext orderExprList() {
			return GetRuleContext<OrderExprListContext>(0);
		}
		public WinOrderByClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_winOrderByClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWinOrderByClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWinOrderByClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWinOrderByClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WinOrderByClauseContext winOrderByClause() {
		WinOrderByClauseContext _localctx = new WinOrderByClauseContext(_ctx, State);
		EnterRule(_localctx, 168, RULE_winOrderByClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1473; Match(ORDER);
			State = 1474; Match(BY);
			State = 1475; orderExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WinFrameClauseContext : ParserRuleContext {
		public WinFrameExtendContext winFrameExtend() {
			return GetRuleContext<WinFrameExtendContext>(0);
		}
		public ITerminalNode ROWS() { return GetToken(ClickHouseParser.ROWS, 0); }
		public ITerminalNode RANGE() { return GetToken(ClickHouseParser.RANGE, 0); }
		public WinFrameClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_winFrameClause; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWinFrameClause(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWinFrameClause(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWinFrameClause(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WinFrameClauseContext winFrameClause() {
		WinFrameClauseContext _localctx = new WinFrameClauseContext(_ctx, State);
		EnterRule(_localctx, 170, RULE_winFrameClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1477;
			_la = _input.La(1);
			if ( !(_la==RANGE || _la==ROWS) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			State = 1478; winFrameExtend();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WinFrameExtendContext : ParserRuleContext {
		public WinFrameExtendContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_winFrameExtend; } }
	 
		public WinFrameExtendContext() { }
		public virtual void CopyFrom(WinFrameExtendContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class FrameStartContext : WinFrameExtendContext {
		public WinFrameBoundContext winFrameBound() {
			return GetRuleContext<WinFrameBoundContext>(0);
		}
		public FrameStartContext(WinFrameExtendContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterFrameStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitFrameStart(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFrameStart(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FrameBetweenContext : WinFrameExtendContext {
		public ITerminalNode BETWEEN() { return GetToken(ClickHouseParser.BETWEEN, 0); }
		public WinFrameBoundContext[] winFrameBound() {
			return GetRuleContexts<WinFrameBoundContext>();
		}
		public WinFrameBoundContext winFrameBound(int i) {
			return GetRuleContext<WinFrameBoundContext>(i);
		}
		public ITerminalNode AND() { return GetToken(ClickHouseParser.AND, 0); }
		public FrameBetweenContext(WinFrameExtendContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterFrameBetween(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitFrameBetween(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFrameBetween(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WinFrameExtendContext winFrameExtend() {
		WinFrameExtendContext _localctx = new WinFrameExtendContext(_ctx, State);
		EnterRule(_localctx, 172, RULE_winFrameExtend);
		try {
			State = 1486;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case CURRENT:
			case INF:
			case NAN_SQL:
			case UNBOUNDED:
			case FLOATING_LITERAL:
			case OCTAL_LITERAL:
			case DECIMAL_LITERAL:
			case HEXADECIMAL_LITERAL:
			case DASH:
			case DOT:
			case PLUS:
				_localctx = new FrameStartContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1480; winFrameBound();
				}
				break;
			case BETWEEN:
				_localctx = new FrameBetweenContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1481; Match(BETWEEN);
				State = 1482; winFrameBound();
				State = 1483; Match(AND);
				State = 1484; winFrameBound();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WinFrameBoundContext : ParserRuleContext {
		public ITerminalNode CURRENT() { return GetToken(ClickHouseParser.CURRENT, 0); }
		public ITerminalNode ROW() { return GetToken(ClickHouseParser.ROW, 0); }
		public ITerminalNode UNBOUNDED() { return GetToken(ClickHouseParser.UNBOUNDED, 0); }
		public ITerminalNode PRECEDING() { return GetToken(ClickHouseParser.PRECEDING, 0); }
		public ITerminalNode FOLLOWING() { return GetToken(ClickHouseParser.FOLLOWING, 0); }
		public NumberLiteralContext numberLiteral() {
			return GetRuleContext<NumberLiteralContext>(0);
		}
		public WinFrameBoundContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_winFrameBound; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWinFrameBound(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWinFrameBound(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWinFrameBound(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WinFrameBoundContext winFrameBound() {
		WinFrameBoundContext _localctx = new WinFrameBoundContext(_ctx, State);
		EnterRule(_localctx, 174, RULE_winFrameBound);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1500;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,200,_ctx) ) {
			case 1:
				{
				State = 1488; Match(CURRENT);
				State = 1489; Match(ROW);
				}
				break;

			case 2:
				{
				State = 1490; Match(UNBOUNDED);
				State = 1491; Match(PRECEDING);
				}
				break;

			case 3:
				{
				State = 1492; Match(UNBOUNDED);
				State = 1493; Match(FOLLOWING);
				}
				break;

			case 4:
				{
				State = 1494; numberLiteral();
				State = 1495; Match(PRECEDING);
				}
				break;

			case 5:
				{
				State = 1497; numberLiteral();
				State = 1498; Match(FOLLOWING);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SetStmtContext : ParserRuleContext {
		public ITerminalNode SET() { return GetToken(ClickHouseParser.SET, 0); }
		public SettingExprListContext settingExprList() {
			return GetRuleContext<SettingExprListContext>(0);
		}
		public SetStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_setStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSetStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSetStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSetStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SetStmtContext setStmt() {
		SetStmtContext _localctx = new SetStmtContext(_ctx, State);
		EnterRule(_localctx, 176, RULE_setStmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1502; Match(SET);
			State = 1503; settingExprList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ShowStmtContext : ParserRuleContext {
		public ShowStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_showStmt; } }
	 
		public ShowStmtContext() { }
		public virtual void CopyFrom(ShowStmtContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ShowCreateDatabaseStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode DATABASE() { return GetToken(ClickHouseParser.DATABASE, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ShowCreateDatabaseStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowCreateDatabaseStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowCreateDatabaseStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowCreateDatabaseStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowDatabasesStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode DATABASES() { return GetToken(ClickHouseParser.DATABASES, 0); }
		public ShowDatabasesStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowDatabasesStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowDatabasesStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowDatabasesStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowCreateTableStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ShowCreateTableStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowCreateTableStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowCreateTableStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowCreateTableStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowTablesStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode TABLES() { return GetToken(ClickHouseParser.TABLES, 0); }
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ITerminalNode LIKE() { return GetToken(ClickHouseParser.LIKE, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public WhereClauseContext whereClause() {
			return GetRuleContext<WhereClauseContext>(0);
		}
		public LimitClauseContext limitClause() {
			return GetRuleContext<LimitClauseContext>(0);
		}
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public ShowTablesStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowTablesStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowTablesStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowTablesStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowDictionariesStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode DICTIONARIES() { return GetToken(ClickHouseParser.DICTIONARIES, 0); }
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ShowDictionariesStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowDictionariesStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowDictionariesStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowDictionariesStmt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowCreateDictionaryStmtContext : ShowStmtContext {
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ShowCreateDictionaryStmtContext(ShowStmtContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterShowCreateDictionaryStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitShowCreateDictionaryStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShowCreateDictionaryStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ShowStmtContext showStmt() {
		ShowStmtContext _localctx = new ShowStmtContext(_ctx, State);
		EnterRule(_localctx, 178, RULE_showStmt);
		int _la;
		try {
			State = 1547;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,208,_ctx) ) {
			case 1:
				_localctx = new ShowCreateDatabaseStmtContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1505; Match(SHOW);
				State = 1506; Match(CREATE);
				State = 1507; Match(DATABASE);
				State = 1508; databaseIdentifier();
				}
				break;

			case 2:
				_localctx = new ShowCreateDictionaryStmtContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1509; Match(SHOW);
				State = 1510; Match(CREATE);
				State = 1511; Match(DICTIONARY);
				State = 1512; tableIdentifier();
				}
				break;

			case 3:
				_localctx = new ShowCreateTableStmtContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1513; Match(SHOW);
				State = 1514; Match(CREATE);
				State = 1516;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,201,_ctx) ) {
				case 1:
					{
					State = 1515; Match(TEMPORARY);
					}
					break;
				}
				State = 1519;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,202,_ctx) ) {
				case 1:
					{
					State = 1518; Match(TABLE);
					}
					break;
				}
				State = 1521; tableIdentifier();
				}
				break;

			case 4:
				_localctx = new ShowDatabasesStmtContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 1522; Match(SHOW);
				State = 1523; Match(DATABASES);
				}
				break;

			case 5:
				_localctx = new ShowDictionariesStmtContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 1524; Match(SHOW);
				State = 1525; Match(DICTIONARIES);
				State = 1528;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==FROM) {
					{
					State = 1526; Match(FROM);
					State = 1527; databaseIdentifier();
					}
				}

				}
				break;

			case 6:
				_localctx = new ShowTablesStmtContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 1530; Match(SHOW);
				State = 1532;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==TEMPORARY) {
					{
					State = 1531; Match(TEMPORARY);
					}
				}

				State = 1534; Match(TABLES);
				State = 1537;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==FROM || _la==IN) {
					{
					State = 1535;
					_la = _input.La(1);
					if ( !(_la==FROM || _la==IN) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					State = 1536; databaseIdentifier();
					}
				}

				State = 1542;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case LIKE:
					{
					State = 1539; Match(LIKE);
					State = 1540; Match(STRING_LITERAL);
					}
					break;
				case WHERE:
					{
					State = 1541; whereClause();
					}
					break;
				case Eof:
				case FORMAT:
				case INTO:
				case LIMIT:
				case SEMICOLON:
					break;
				default:
					break;
				}
				State = 1545;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==LIMIT) {
					{
					State = 1544; limitClause();
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SystemStmtContext : ParserRuleContext {
		public ITerminalNode SYSTEM() { return GetToken(ClickHouseParser.SYSTEM, 0); }
		public ITerminalNode FLUSH() { return GetToken(ClickHouseParser.FLUSH, 0); }
		public ITerminalNode DISTRIBUTED() { return GetToken(ClickHouseParser.DISTRIBUTED, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode LOGS() { return GetToken(ClickHouseParser.LOGS, 0); }
		public ITerminalNode RELOAD() { return GetToken(ClickHouseParser.RELOAD, 0); }
		public ITerminalNode DICTIONARIES() { return GetToken(ClickHouseParser.DICTIONARIES, 0); }
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public ITerminalNode START() { return GetToken(ClickHouseParser.START, 0); }
		public ITerminalNode STOP() { return GetToken(ClickHouseParser.STOP, 0); }
		public ITerminalNode SENDS() { return GetToken(ClickHouseParser.SENDS, 0); }
		public ITerminalNode FETCHES() { return GetToken(ClickHouseParser.FETCHES, 0); }
		public ITerminalNode MERGES() { return GetToken(ClickHouseParser.MERGES, 0); }
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public ITerminalNode REPLICATED() { return GetToken(ClickHouseParser.REPLICATED, 0); }
		public ITerminalNode SYNC() { return GetToken(ClickHouseParser.SYNC, 0); }
		public ITerminalNode REPLICA() { return GetToken(ClickHouseParser.REPLICA, 0); }
		public SystemStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_systemStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterSystemStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitSystemStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSystemStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SystemStmtContext systemStmt() {
		SystemStmtContext _localctx = new SystemStmtContext(_ctx, State);
		EnterRule(_localctx, 180, RULE_systemStmt);
		int _la;
		try {
			State = 1583;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,211,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1549; Match(SYSTEM);
				State = 1550; Match(FLUSH);
				State = 1551; Match(DISTRIBUTED);
				State = 1552; tableIdentifier();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1553; Match(SYSTEM);
				State = 1554; Match(FLUSH);
				State = 1555; Match(LOGS);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1556; Match(SYSTEM);
				State = 1557; Match(RELOAD);
				State = 1558; Match(DICTIONARIES);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1559; Match(SYSTEM);
				State = 1560; Match(RELOAD);
				State = 1561; Match(DICTIONARY);
				State = 1562; tableIdentifier();
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1563; Match(SYSTEM);
				State = 1564;
				_la = _input.La(1);
				if ( !(_la==START || _la==STOP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1572;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case DISTRIBUTED:
					{
					State = 1565; Match(DISTRIBUTED);
					State = 1566; Match(SENDS);
					}
					break;
				case FETCHES:
					{
					State = 1567; Match(FETCHES);
					}
					break;
				case MERGES:
				case TTL:
					{
					State = 1569;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==TTL) {
						{
						State = 1568; Match(TTL);
						}
					}

					State = 1571; Match(MERGES);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1574; tableIdentifier();
				}
				break;

			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1575; Match(SYSTEM);
				State = 1576;
				_la = _input.La(1);
				if ( !(_la==START || _la==STOP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1577; Match(REPLICATED);
				State = 1578; Match(SENDS);
				}
				break;

			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1579; Match(SYSTEM);
				State = 1580; Match(SYNC);
				State = 1581; Match(REPLICA);
				State = 1582; tableIdentifier();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TruncateStmtContext : ParserRuleContext {
		public ITerminalNode TRUNCATE() { return GetToken(ClickHouseParser.TRUNCATE, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ClusterClauseContext clusterClause() {
			return GetRuleContext<ClusterClauseContext>(0);
		}
		public TruncateStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_truncateStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTruncateStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTruncateStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTruncateStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TruncateStmtContext truncateStmt() {
		TruncateStmtContext _localctx = new TruncateStmtContext(_ctx, State);
		EnterRule(_localctx, 182, RULE_truncateStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1585; Match(TRUNCATE);
			State = 1587;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,212,_ctx) ) {
			case 1:
				{
				State = 1586; Match(TEMPORARY);
				}
				break;
			}
			State = 1590;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,213,_ctx) ) {
			case 1:
				{
				State = 1589; Match(TABLE);
				}
				break;
			}
			State = 1594;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,214,_ctx) ) {
			case 1:
				{
				State = 1592; Match(IF);
				State = 1593; Match(EXISTS);
				}
				break;
			}
			State = 1596; tableIdentifier();
			State = 1598;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==ON) {
				{
				State = 1597; clusterClause();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UseStmtContext : ParserRuleContext {
		public ITerminalNode USE() { return GetToken(ClickHouseParser.USE, 0); }
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public UseStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_useStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterUseStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitUseStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUseStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UseStmtContext useStmt() {
		UseStmtContext _localctx = new UseStmtContext(_ctx, State);
		EnterRule(_localctx, 184, RULE_useStmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1600; Match(USE);
			State = 1601; databaseIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WatchStmtContext : ParserRuleContext {
		public ITerminalNode WATCH() { return GetToken(ClickHouseParser.WATCH, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode EVENTS() { return GetToken(ClickHouseParser.EVENTS, 0); }
		public ITerminalNode LIMIT() { return GetToken(ClickHouseParser.LIMIT, 0); }
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public WatchStmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_watchStmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterWatchStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitWatchStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWatchStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WatchStmtContext watchStmt() {
		WatchStmtContext _localctx = new WatchStmtContext(_ctx, State);
		EnterRule(_localctx, 186, RULE_watchStmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1603; Match(WATCH);
			State = 1604; tableIdentifier();
			State = 1606;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==EVENTS) {
				{
				State = 1605; Match(EVENTS);
				}
			}

			State = 1610;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==LIMIT) {
				{
				State = 1608; Match(LIMIT);
				State = 1609; Match(DECIMAL_LITERAL);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnTypeExprContext : ParserRuleContext {
		public ColumnTypeExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnTypeExpr; } }
	 
		public ColumnTypeExprContext() { }
		public virtual void CopyFrom(ColumnTypeExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ColumnTypeExprNestedContext : ColumnTypeExprContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnTypeExprContext[] columnTypeExpr() {
			return GetRuleContexts<ColumnTypeExprContext>();
		}
		public ColumnTypeExprContext columnTypeExpr(int i) {
			return GetRuleContext<ColumnTypeExprContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnTypeExprNestedContext(ColumnTypeExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnTypeExprNested(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnTypeExprNested(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnTypeExprNested(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnTypeExprParamContext : ColumnTypeExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ColumnTypeExprParamContext(ColumnTypeExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnTypeExprParam(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnTypeExprParam(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnTypeExprParam(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnTypeExprSimpleContext : ColumnTypeExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ColumnTypeExprSimpleContext(ColumnTypeExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnTypeExprSimple(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnTypeExprSimple(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnTypeExprSimple(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnTypeExprComplexContext : ColumnTypeExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnTypeExprContext[] columnTypeExpr() {
			return GetRuleContexts<ColumnTypeExprContext>();
		}
		public ColumnTypeExprContext columnTypeExpr(int i) {
			return GetRuleContext<ColumnTypeExprContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnTypeExprComplexContext(ColumnTypeExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnTypeExprComplex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnTypeExprComplex(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnTypeExprComplex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnTypeExprEnumContext : ColumnTypeExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public EnumValueContext[] enumValue() {
			return GetRuleContexts<EnumValueContext>();
		}
		public EnumValueContext enumValue(int i) {
			return GetRuleContext<EnumValueContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnTypeExprEnumContext(ColumnTypeExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnTypeExprEnum(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnTypeExprEnum(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnTypeExprEnum(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnTypeExprContext columnTypeExpr() {
		ColumnTypeExprContext _localctx = new ColumnTypeExprContext(_ctx, State);
		EnterRule(_localctx, 188, RULE_columnTypeExpr);
		int _la;
		try {
			State = 1659;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,222,_ctx) ) {
			case 1:
				_localctx = new ColumnTypeExprSimpleContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1612; identifier();
				}
				break;

			case 2:
				_localctx = new ColumnTypeExprNestedContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1613; identifier();
				State = 1614; Match(LPAREN);
				State = 1615; identifier();
				State = 1616; columnTypeExpr();
				State = 1623;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 1617; Match(COMMA);
					State = 1618; identifier();
					State = 1619; columnTypeExpr();
					}
					}
					State = 1625;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 1626; Match(RPAREN);
				}
				break;

			case 3:
				_localctx = new ColumnTypeExprEnumContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1628; identifier();
				State = 1629; Match(LPAREN);
				State = 1630; enumValue();
				State = 1635;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 1631; Match(COMMA);
					State = 1632; enumValue();
					}
					}
					State = 1637;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 1638; Match(RPAREN);
				}
				break;

			case 4:
				_localctx = new ColumnTypeExprComplexContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 1640; identifier();
				State = 1641; Match(LPAREN);
				State = 1642; columnTypeExpr();
				State = 1647;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 1643; Match(COMMA);
					State = 1644; columnTypeExpr();
					}
					}
					State = 1649;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 1650; Match(RPAREN);
				}
				break;

			case 5:
				_localctx = new ColumnTypeExprParamContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 1652; identifier();
				State = 1653; Match(LPAREN);
				State = 1655;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1654; columnExprList();
					}
				}

				State = 1657; Match(RPAREN);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnExprListContext : ParserRuleContext {
		public ColumnsExprContext[] columnsExpr() {
			return GetRuleContexts<ColumnsExprContext>();
		}
		public ColumnsExprContext columnsExpr(int i) {
			return GetRuleContext<ColumnsExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnExprListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnExprList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnExprListContext columnExprList() {
		ColumnExprListContext _localctx = new ColumnExprListContext(_ctx, State);
		EnterRule(_localctx, 190, RULE_columnExprList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1661; columnsExpr();
			State = 1666;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,223,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 1662; Match(COMMA);
					State = 1663; columnsExpr();
					}
					} 
				}
				State = 1668;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,223,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnsExprContext : ParserRuleContext {
		public ColumnsExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnsExpr; } }
	 
		public ColumnsExprContext() { }
		public virtual void CopyFrom(ColumnsExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ColumnsExprColumnContext : ColumnsExprContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ColumnsExprColumnContext(ColumnsExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnsExprColumn(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnsExprColumn(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnsExprColumn(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnsExprAsteriskContext : ColumnsExprContext {
		public ITerminalNode ASTERISK() { return GetToken(ClickHouseParser.ASTERISK, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public ColumnsExprAsteriskContext(ColumnsExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnsExprAsterisk(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnsExprAsterisk(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnsExprAsterisk(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnsExprSubqueryContext : ColumnsExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnsExprSubqueryContext(ColumnsExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnsExprSubquery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnsExprSubquery(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnsExprSubquery(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnsExprContext columnsExpr() {
		ColumnsExprContext _localctx = new ColumnsExprContext(_ctx, State);
		EnterRule(_localctx, 192, RULE_columnsExpr);
		int _la;
		try {
			State = 1680;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,225,_ctx) ) {
			case 1:
				_localctx = new ColumnsExprAsteriskContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1672;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (((((_la - 2)) & ~0x3f) == 0 && ((1L << (_la - 2)) & ((1L << (AFTER - 2)) | (1L << (ALIAS - 2)) | (1L << (ALL - 2)) | (1L << (ALTER - 2)) | (1L << (AND - 2)) | (1L << (ANTI - 2)) | (1L << (ANY - 2)) | (1L << (ARRAY - 2)) | (1L << (AS - 2)) | (1L << (ASCENDING - 2)) | (1L << (ASOF - 2)) | (1L << (AST - 2)) | (1L << (ASYNC - 2)) | (1L << (ATTACH - 2)) | (1L << (BETWEEN - 2)) | (1L << (BOTH - 2)) | (1L << (BY - 2)) | (1L << (CASE - 2)) | (1L << (CAST - 2)) | (1L << (CHECK - 2)) | (1L << (CLEAR - 2)) | (1L << (CLUSTER - 2)) | (1L << (CODEC - 2)) | (1L << (COLLATE - 2)) | (1L << (COLUMN - 2)) | (1L << (COMMENT - 2)) | (1L << (CONSTRAINT - 2)) | (1L << (CREATE - 2)) | (1L << (CROSS - 2)) | (1L << (CUBE - 2)) | (1L << (CURRENT - 2)) | (1L << (DATABASE - 2)) | (1L << (DATABASES - 2)) | (1L << (DATE - 2)) | (1L << (DAY - 2)) | (1L << (DEDUPLICATE - 2)) | (1L << (DEFAULT - 2)) | (1L << (DELAY - 2)) | (1L << (DELETE - 2)) | (1L << (DESC - 2)) | (1L << (DESCENDING - 2)) | (1L << (DESCRIBE - 2)) | (1L << (DETACH - 2)) | (1L << (DICTIONARIES - 2)) | (1L << (DICTIONARY - 2)) | (1L << (DISK - 2)) | (1L << (DISTINCT - 2)) | (1L << (DISTRIBUTED - 2)) | (1L << (DROP - 2)) | (1L << (ELSE - 2)) | (1L << (END - 2)) | (1L << (ENGINE - 2)) | (1L << (EVENTS - 2)) | (1L << (EXISTS - 2)) | (1L << (EXPLAIN - 2)) | (1L << (EXPRESSION - 2)) | (1L << (EXTRACT - 2)) | (1L << (FETCHES - 2)) | (1L << (FINAL - 2)) | (1L << (FIRST - 2)) | (1L << (FLUSH - 2)) | (1L << (FOLLOWING - 2)) | (1L << (FOR - 2)) | (1L << (FORMAT - 2)))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (FREEZE - 66)) | (1L << (FROM - 66)) | (1L << (FULL - 66)) | (1L << (FUNCTION - 66)) | (1L << (GLOBAL - 66)) | (1L << (GRANULARITY - 66)) | (1L << (GROUP - 66)) | (1L << (HAVING - 66)) | (1L << (HIERARCHICAL - 66)) | (1L << (HOUR - 66)) | (1L << (ID - 66)) | (1L << (IF - 66)) | (1L << (ILIKE - 66)) | (1L << (IN - 66)) | (1L << (INDEX - 66)) | (1L << (INJECTIVE - 66)) | (1L << (INNER - 66)) | (1L << (INSERT - 66)) | (1L << (INTERVAL - 66)) | (1L << (INTO - 66)) | (1L << (IS - 66)) | (1L << (IS_OBJECT_ID - 66)) | (1L << (JOIN - 66)) | (1L << (KEY - 66)) | (1L << (KILL - 66)) | (1L << (LAST - 66)) | (1L << (LAYOUT - 66)) | (1L << (LEADING - 66)) | (1L << (LEFT - 66)) | (1L << (LIFETIME - 66)) | (1L << (LIKE - 66)) | (1L << (LIMIT - 66)) | (1L << (LIVE - 66)) | (1L << (LOCAL - 66)) | (1L << (LOGS - 66)) | (1L << (MATERIALIZE - 66)) | (1L << (MATERIALIZED - 66)) | (1L << (MAX - 66)) | (1L << (MERGES - 66)) | (1L << (MIN - 66)) | (1L << (MINUTE - 66)) | (1L << (MODIFY - 66)) | (1L << (MONTH - 66)) | (1L << (MOVE - 66)) | (1L << (MUTATION - 66)) | (1L << (NO - 66)) | (1L << (NOT - 66)) | (1L << (NULLS - 66)) | (1L << (OFFSET - 66)) | (1L << (ON - 66)) | (1L << (OPTIMIZE - 66)) | (1L << (OR - 66)) | (1L << (ORDER - 66)) | (1L << (OUTER - 66)) | (1L << (OUTFILE - 66)) | (1L << (OVER - 66)) | (1L << (PARTITION - 66)) | (1L << (POPULATE - 66)) | (1L << (PRECEDING - 66)) | (1L << (PREWHERE - 66)) | (1L << (PRIMARY - 66)))) != 0) || ((((_la - 131)) & ~0x3f) == 0 && ((1L << (_la - 131)) & ((1L << (QUARTER - 131)) | (1L << (RANGE - 131)) | (1L << (RELOAD - 131)) | (1L << (REMOVE - 131)) | (1L << (RENAME - 131)) | (1L << (REPLACE - 131)) | (1L << (REPLICA - 131)) | (1L << (REPLICATED - 131)) | (1L << (RIGHT - 131)) | (1L << (ROLLUP - 131)) | (1L << (ROW - 131)) | (1L << (ROWS - 131)) | (1L << (SAMPLE - 131)) | (1L << (SECOND - 131)) | (1L << (SELECT - 131)) | (1L << (SEMI - 131)) | (1L << (SENDS - 131)) | (1L << (SET - 131)) | (1L << (SETTINGS - 131)) | (1L << (SHOW - 131)) | (1L << (SOURCE - 131)) | (1L << (START - 131)) | (1L << (STOP - 131)) | (1L << (SUBSTRING - 131)) | (1L << (SYNC - 131)) | (1L << (SYNTAX - 131)) | (1L << (SYSTEM - 131)) | (1L << (TABLE - 131)) | (1L << (TABLES - 131)) | (1L << (TEMPORARY - 131)) | (1L << (TEST - 131)) | (1L << (THEN - 131)) | (1L << (TIES - 131)) | (1L << (TIMEOUT - 131)) | (1L << (TIMESTAMP - 131)) | (1L << (TO - 131)) | (1L << (TOP - 131)) | (1L << (TOTALS - 131)) | (1L << (TRAILING - 131)) | (1L << (TRIM - 131)) | (1L << (TRUNCATE - 131)) | (1L << (TTL - 131)) | (1L << (TYPE - 131)) | (1L << (UNBOUNDED - 131)) | (1L << (UNION - 131)) | (1L << (UPDATE - 131)) | (1L << (USE - 131)) | (1L << (USING - 131)) | (1L << (UUID - 131)) | (1L << (VALUES - 131)) | (1L << (VIEW - 131)) | (1L << (VOLUME - 131)) | (1L << (WATCH - 131)) | (1L << (WEEK - 131)) | (1L << (WHEN - 131)) | (1L << (WHERE - 131)) | (1L << (WINDOW - 131)) | (1L << (WITH - 131)) | (1L << (YEAR - 131)) | (1L << (JSON_FALSE - 131)) | (1L << (JSON_TRUE - 131)) | (1L << (IDENTIFIER - 131)))) != 0)) {
					{
					State = 1669; tableIdentifier();
					State = 1670; Match(DOT);
					}
				}

				State = 1674; Match(ASTERISK);
				}
				break;

			case 2:
				_localctx = new ColumnsExprSubqueryContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1675; Match(LPAREN);
				State = 1676; selectUnionStmt();
				State = 1677; Match(RPAREN);
				}
				break;

			case 3:
				_localctx = new ColumnsExprColumnContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1679; columnExpr(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnExprContext : ParserRuleContext {
		public ColumnExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnExpr; } }
	 
		public ColumnExprContext() { }
		public virtual void CopyFrom(ColumnExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ColumnExprTernaryOpContext : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode QUERY() { return GetToken(ClickHouseParser.QUERY, 0); }
		public ITerminalNode COLON() { return GetToken(ClickHouseParser.COLON, 0); }
		public ColumnExprTernaryOpContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprTernaryOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprTernaryOp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprTernaryOp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprAliasContext : ColumnExprContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public AliasContext alias() {
			return GetRuleContext<AliasContext>(0);
		}
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ColumnExprAliasContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprAlias(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprAlias(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprAlias(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprExtractContext : ColumnExprContext {
		public ITerminalNode EXTRACT() { return GetToken(ClickHouseParser.EXTRACT, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public IntervalContext interval() {
			return GetRuleContext<IntervalContext>(0);
		}
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprExtractContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprExtract(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprExtract(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprExtract(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprNegateContext : ColumnExprContext {
		public ITerminalNode DASH() { return GetToken(ClickHouseParser.DASH, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ColumnExprNegateContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprNegate(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprNegate(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprNegate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprSubqueryContext : ColumnExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprSubqueryContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprSubquery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprSubquery(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprSubquery(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprLiteralContext : ColumnExprContext {
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public ColumnExprLiteralContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprArrayContext : ColumnExprContext {
		public ITerminalNode LBRACKET() { return GetToken(ClickHouseParser.LBRACKET, 0); }
		public ITerminalNode RBRACKET() { return GetToken(ClickHouseParser.RBRACKET, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ColumnExprArrayContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprArray(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprArray(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprArray(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprSubstringContext : ColumnExprContext {
		public ITerminalNode SUBSTRING() { return GetToken(ClickHouseParser.SUBSTRING, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode FOR() { return GetToken(ClickHouseParser.FOR, 0); }
		public ColumnExprSubstringContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprSubstring(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprSubstring(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprSubstring(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprCastContext : ColumnExprContext {
		public ITerminalNode CAST() { return GetToken(ClickHouseParser.CAST, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public ColumnTypeExprContext columnTypeExpr() {
			return GetRuleContext<ColumnTypeExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprCastContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprCast(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprCast(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprCast(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprOrContext : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode OR() { return GetToken(ClickHouseParser.OR, 0); }
		public ColumnExprOrContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprOr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprOr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprOr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprPrecedence1Context : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode ASTERISK() { return GetToken(ClickHouseParser.ASTERISK, 0); }
		public ITerminalNode SLASH() { return GetToken(ClickHouseParser.SLASH, 0); }
		public ITerminalNode PERCENT() { return GetToken(ClickHouseParser.PERCENT, 0); }
		public ColumnExprPrecedence1Context(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprPrecedence1(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprPrecedence1(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprPrecedence1(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprPrecedence2Context : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode PLUS() { return GetToken(ClickHouseParser.PLUS, 0); }
		public ITerminalNode DASH() { return GetToken(ClickHouseParser.DASH, 0); }
		public ITerminalNode CONCAT() { return GetToken(ClickHouseParser.CONCAT, 0); }
		public ColumnExprPrecedence2Context(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprPrecedence2(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprPrecedence2(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprPrecedence2(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprPrecedence3Context : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode EQ_DOUBLE() { return GetToken(ClickHouseParser.EQ_DOUBLE, 0); }
		public ITerminalNode EQ_SINGLE() { return GetToken(ClickHouseParser.EQ_SINGLE, 0); }
		public ITerminalNode NOT_EQ() { return GetToken(ClickHouseParser.NOT_EQ, 0); }
		public ITerminalNode LE() { return GetToken(ClickHouseParser.LE, 0); }
		public ITerminalNode GE() { return GetToken(ClickHouseParser.GE, 0); }
		public ITerminalNode LT() { return GetToken(ClickHouseParser.LT, 0); }
		public ITerminalNode GT() { return GetToken(ClickHouseParser.GT, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public ITerminalNode LIKE() { return GetToken(ClickHouseParser.LIKE, 0); }
		public ITerminalNode ILIKE() { return GetToken(ClickHouseParser.ILIKE, 0); }
		public ITerminalNode GLOBAL() { return GetToken(ClickHouseParser.GLOBAL, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ColumnExprPrecedence3Context(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprPrecedence3(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprPrecedence3(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprPrecedence3(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprIntervalContext : ColumnExprContext {
		public ITerminalNode INTERVAL() { return GetToken(ClickHouseParser.INTERVAL, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public IntervalContext interval() {
			return GetRuleContext<IntervalContext>(0);
		}
		public ColumnExprIntervalContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprInterval(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprInterval(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprInterval(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprIsNullContext : ColumnExprContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode IS() { return GetToken(ClickHouseParser.IS, 0); }
		public ITerminalNode NULL_SQL() { return GetToken(ClickHouseParser.NULL_SQL, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ColumnExprIsNullContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprIsNull(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprIsNull(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprIsNull(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprWinFunctionTargetContext : ColumnExprContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode OVER() { return GetToken(ClickHouseParser.OVER, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ColumnExprWinFunctionTargetContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprWinFunctionTarget(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprWinFunctionTarget(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprWinFunctionTarget(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprTrimContext : ColumnExprContext {
		public ITerminalNode TRIM() { return GetToken(ClickHouseParser.TRIM, 0); }
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode BOTH() { return GetToken(ClickHouseParser.BOTH, 0); }
		public ITerminalNode LEADING() { return GetToken(ClickHouseParser.LEADING, 0); }
		public ITerminalNode TRAILING() { return GetToken(ClickHouseParser.TRAILING, 0); }
		public ColumnExprTrimContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprTrim(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprTrim(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprTrim(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprTupleContext : ColumnExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprTupleContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprTuple(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprTuple(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprTuple(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprArrayAccessContext : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode LBRACKET() { return GetToken(ClickHouseParser.LBRACKET, 0); }
		public ITerminalNode RBRACKET() { return GetToken(ClickHouseParser.RBRACKET, 0); }
		public ColumnExprArrayAccessContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprArrayAccess(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprArrayAccess(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprArrayAccess(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprBetweenContext : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode BETWEEN() { return GetToken(ClickHouseParser.BETWEEN, 0); }
		public ITerminalNode AND() { return GetToken(ClickHouseParser.AND, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ColumnExprBetweenContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprBetween(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprBetween(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprBetween(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprParensContext : ColumnExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ColumnExprParensContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprParens(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprParens(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprParens(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprTimestampContext : ColumnExprContext {
		public ITerminalNode TIMESTAMP() { return GetToken(ClickHouseParser.TIMESTAMP, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ColumnExprTimestampContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprTimestamp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprTimestamp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprTimestamp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprAndContext : ColumnExprContext {
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode AND() { return GetToken(ClickHouseParser.AND, 0); }
		public ColumnExprAndContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprAnd(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprAnd(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprAnd(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprTupleAccessContext : ColumnExprContext {
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public ColumnExprTupleAccessContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprTupleAccess(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprTupleAccess(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprTupleAccess(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprCaseContext : ColumnExprContext {
		public ITerminalNode CASE() { return GetToken(ClickHouseParser.CASE, 0); }
		public ITerminalNode END() { return GetToken(ClickHouseParser.END, 0); }
		public ColumnExprContext[] columnExpr() {
			return GetRuleContexts<ColumnExprContext>();
		}
		public ColumnExprContext columnExpr(int i) {
			return GetRuleContext<ColumnExprContext>(i);
		}
		public ITerminalNode[] WHEN() { return GetTokens(ClickHouseParser.WHEN); }
		public ITerminalNode WHEN(int i) {
			return GetToken(ClickHouseParser.WHEN, i);
		}
		public ITerminalNode[] THEN() { return GetTokens(ClickHouseParser.THEN); }
		public ITerminalNode THEN(int i) {
			return GetToken(ClickHouseParser.THEN, i);
		}
		public ITerminalNode ELSE() { return GetToken(ClickHouseParser.ELSE, 0); }
		public ColumnExprCaseContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprCase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprCase(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprCase(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprDateContext : ColumnExprContext {
		public ITerminalNode DATE() { return GetToken(ClickHouseParser.DATE, 0); }
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ColumnExprDateContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprDate(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprDate(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprDate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprNotContext : ColumnExprContext {
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ColumnExprNotContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprNot(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprNot(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprNot(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprWinFunctionContext : ColumnExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode OVER() { return GetToken(ClickHouseParser.OVER, 0); }
		public ITerminalNode[] LPAREN() { return GetTokens(ClickHouseParser.LPAREN); }
		public ITerminalNode LPAREN(int i) {
			return GetToken(ClickHouseParser.LPAREN, i);
		}
		public WindowExprContext windowExpr() {
			return GetRuleContext<WindowExprContext>(0);
		}
		public ITerminalNode[] RPAREN() { return GetTokens(ClickHouseParser.RPAREN); }
		public ITerminalNode RPAREN(int i) {
			return GetToken(ClickHouseParser.RPAREN, i);
		}
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ColumnExprWinFunctionContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprWinFunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprWinFunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprWinFunction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprIdentifierContext : ColumnExprContext {
		public ColumnIdentifierContext columnIdentifier() {
			return GetRuleContext<ColumnIdentifierContext>(0);
		}
		public ColumnExprIdentifierContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprFunctionContext : ColumnExprContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode[] LPAREN() { return GetTokens(ClickHouseParser.LPAREN); }
		public ITerminalNode LPAREN(int i) {
			return GetToken(ClickHouseParser.LPAREN, i);
		}
		public ITerminalNode[] RPAREN() { return GetTokens(ClickHouseParser.RPAREN); }
		public ITerminalNode RPAREN(int i) {
			return GetToken(ClickHouseParser.RPAREN, i);
		}
		public ITerminalNode DISTINCT() { return GetToken(ClickHouseParser.DISTINCT, 0); }
		public ColumnArgListContext columnArgList() {
			return GetRuleContext<ColumnArgListContext>(0);
		}
		public ColumnExprListContext columnExprList() {
			return GetRuleContext<ColumnExprListContext>(0);
		}
		public ColumnExprFunctionContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprFunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprFunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprFunction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ColumnExprAsteriskContext : ColumnExprContext {
		public ITerminalNode ASTERISK() { return GetToken(ClickHouseParser.ASTERISK, 0); }
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public ColumnExprAsteriskContext(ColumnExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnExprAsterisk(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnExprAsterisk(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnExprAsterisk(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnExprContext columnExpr() {
		return columnExpr(0);
	}

	private ColumnExprContext columnExpr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ColumnExprContext _localctx = new ColumnExprContext(_ctx, _parentState);
		ColumnExprContext _prevctx = _localctx;
		int _startState = 194;
		EnterRecursionRule(_localctx, 194, RULE_columnExpr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1811;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,238,_ctx) ) {
			case 1:
				{
				_localctx = new ColumnExprCaseContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 1683; Match(CASE);
				State = 1685;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,226,_ctx) ) {
				case 1:
					{
					State = 1684; columnExpr(0);
					}
					break;
				}
				State = 1692;
				_errHandler.Sync(this);
				_la = _input.La(1);
				do {
					{
					{
					State = 1687; Match(WHEN);
					State = 1688; columnExpr(0);
					State = 1689; Match(THEN);
					State = 1690; columnExpr(0);
					}
					}
					State = 1694;
					_errHandler.Sync(this);
					_la = _input.La(1);
				} while ( _la==WHEN );
				State = 1698;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==ELSE) {
					{
					State = 1696; Match(ELSE);
					State = 1697; columnExpr(0);
					}
				}

				State = 1700; Match(END);
				}
				break;

			case 2:
				{
				_localctx = new ColumnExprCastContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1702; Match(CAST);
				State = 1703; Match(LPAREN);
				State = 1704; columnExpr(0);
				State = 1705; Match(AS);
				State = 1706; columnTypeExpr();
				State = 1707; Match(RPAREN);
				}
				break;

			case 3:
				{
				_localctx = new ColumnExprDateContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1709; Match(DATE);
				State = 1710; Match(STRING_LITERAL);
				}
				break;

			case 4:
				{
				_localctx = new ColumnExprExtractContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1711; Match(EXTRACT);
				State = 1712; Match(LPAREN);
				State = 1713; interval();
				State = 1714; Match(FROM);
				State = 1715; columnExpr(0);
				State = 1716; Match(RPAREN);
				}
				break;

			case 5:
				{
				_localctx = new ColumnExprIntervalContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1718; Match(INTERVAL);
				State = 1719; columnExpr(0);
				State = 1720; interval();
				}
				break;

			case 6:
				{
				_localctx = new ColumnExprSubstringContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1722; Match(SUBSTRING);
				State = 1723; Match(LPAREN);
				State = 1724; columnExpr(0);
				State = 1725; Match(FROM);
				State = 1726; columnExpr(0);
				State = 1729;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (_la==FOR) {
					{
					State = 1727; Match(FOR);
					State = 1728; columnExpr(0);
					}
				}

				State = 1731; Match(RPAREN);
				}
				break;

			case 7:
				{
				_localctx = new ColumnExprTimestampContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1733; Match(TIMESTAMP);
				State = 1734; Match(STRING_LITERAL);
				}
				break;

			case 8:
				{
				_localctx = new ColumnExprTrimContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1735; Match(TRIM);
				State = 1736; Match(LPAREN);
				State = 1737;
				_la = _input.La(1);
				if ( !(_la==BOTH || _la==LEADING || _la==TRAILING) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 1738; Match(STRING_LITERAL);
				State = 1739; Match(FROM);
				State = 1740; columnExpr(0);
				State = 1741; Match(RPAREN);
				}
				break;

			case 9:
				{
				_localctx = new ColumnExprWinFunctionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1743; identifier();
				{
				State = 1744; Match(LPAREN);
				State = 1746;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1745; columnExprList();
					}
				}

				State = 1748; Match(RPAREN);
				}
				State = 1750; Match(OVER);
				State = 1751; Match(LPAREN);
				State = 1752; windowExpr();
				State = 1753; Match(RPAREN);
				}
				break;

			case 10:
				{
				_localctx = new ColumnExprWinFunctionTargetContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1755; identifier();
				{
				State = 1756; Match(LPAREN);
				State = 1758;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1757; columnExprList();
					}
				}

				State = 1760; Match(RPAREN);
				}
				State = 1762; Match(OVER);
				State = 1763; identifier();
				}
				break;

			case 11:
				{
				_localctx = new ColumnExprFunctionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1765; identifier();
				State = 1771;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,233,_ctx) ) {
				case 1:
					{
					State = 1766; Match(LPAREN);
					State = 1768;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
						{
						State = 1767; columnExprList();
						}
					}

					State = 1770; Match(RPAREN);
					}
					break;
				}
				State = 1773; Match(LPAREN);
				State = 1775;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,234,_ctx) ) {
				case 1:
					{
					State = 1774; Match(DISTINCT);
					}
					break;
				}
				State = 1778;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1777; columnArgList();
					}
				}

				State = 1780; Match(RPAREN);
				}
				break;

			case 12:
				{
				_localctx = new ColumnExprLiteralContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1782; literal();
				}
				break;

			case 13:
				{
				_localctx = new ColumnExprNegateContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1783; Match(DASH);
				State = 1784; columnExpr(17);
				}
				break;

			case 14:
				{
				_localctx = new ColumnExprNotContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1785; Match(NOT);
				State = 1786; columnExpr(12);
				}
				break;

			case 15:
				{
				_localctx = new ColumnExprAsteriskContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1790;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if (((((_la - 2)) & ~0x3f) == 0 && ((1L << (_la - 2)) & ((1L << (AFTER - 2)) | (1L << (ALIAS - 2)) | (1L << (ALL - 2)) | (1L << (ALTER - 2)) | (1L << (AND - 2)) | (1L << (ANTI - 2)) | (1L << (ANY - 2)) | (1L << (ARRAY - 2)) | (1L << (AS - 2)) | (1L << (ASCENDING - 2)) | (1L << (ASOF - 2)) | (1L << (AST - 2)) | (1L << (ASYNC - 2)) | (1L << (ATTACH - 2)) | (1L << (BETWEEN - 2)) | (1L << (BOTH - 2)) | (1L << (BY - 2)) | (1L << (CASE - 2)) | (1L << (CAST - 2)) | (1L << (CHECK - 2)) | (1L << (CLEAR - 2)) | (1L << (CLUSTER - 2)) | (1L << (CODEC - 2)) | (1L << (COLLATE - 2)) | (1L << (COLUMN - 2)) | (1L << (COMMENT - 2)) | (1L << (CONSTRAINT - 2)) | (1L << (CREATE - 2)) | (1L << (CROSS - 2)) | (1L << (CUBE - 2)) | (1L << (CURRENT - 2)) | (1L << (DATABASE - 2)) | (1L << (DATABASES - 2)) | (1L << (DATE - 2)) | (1L << (DAY - 2)) | (1L << (DEDUPLICATE - 2)) | (1L << (DEFAULT - 2)) | (1L << (DELAY - 2)) | (1L << (DELETE - 2)) | (1L << (DESC - 2)) | (1L << (DESCENDING - 2)) | (1L << (DESCRIBE - 2)) | (1L << (DETACH - 2)) | (1L << (DICTIONARIES - 2)) | (1L << (DICTIONARY - 2)) | (1L << (DISK - 2)) | (1L << (DISTINCT - 2)) | (1L << (DISTRIBUTED - 2)) | (1L << (DROP - 2)) | (1L << (ELSE - 2)) | (1L << (END - 2)) | (1L << (ENGINE - 2)) | (1L << (EVENTS - 2)) | (1L << (EXISTS - 2)) | (1L << (EXPLAIN - 2)) | (1L << (EXPRESSION - 2)) | (1L << (EXTRACT - 2)) | (1L << (FETCHES - 2)) | (1L << (FINAL - 2)) | (1L << (FIRST - 2)) | (1L << (FLUSH - 2)) | (1L << (FOLLOWING - 2)) | (1L << (FOR - 2)) | (1L << (FORMAT - 2)))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (FREEZE - 66)) | (1L << (FROM - 66)) | (1L << (FULL - 66)) | (1L << (FUNCTION - 66)) | (1L << (GLOBAL - 66)) | (1L << (GRANULARITY - 66)) | (1L << (GROUP - 66)) | (1L << (HAVING - 66)) | (1L << (HIERARCHICAL - 66)) | (1L << (HOUR - 66)) | (1L << (ID - 66)) | (1L << (IF - 66)) | (1L << (ILIKE - 66)) | (1L << (IN - 66)) | (1L << (INDEX - 66)) | (1L << (INJECTIVE - 66)) | (1L << (INNER - 66)) | (1L << (INSERT - 66)) | (1L << (INTERVAL - 66)) | (1L << (INTO - 66)) | (1L << (IS - 66)) | (1L << (IS_OBJECT_ID - 66)) | (1L << (JOIN - 66)) | (1L << (KEY - 66)) | (1L << (KILL - 66)) | (1L << (LAST - 66)) | (1L << (LAYOUT - 66)) | (1L << (LEADING - 66)) | (1L << (LEFT - 66)) | (1L << (LIFETIME - 66)) | (1L << (LIKE - 66)) | (1L << (LIMIT - 66)) | (1L << (LIVE - 66)) | (1L << (LOCAL - 66)) | (1L << (LOGS - 66)) | (1L << (MATERIALIZE - 66)) | (1L << (MATERIALIZED - 66)) | (1L << (MAX - 66)) | (1L << (MERGES - 66)) | (1L << (MIN - 66)) | (1L << (MINUTE - 66)) | (1L << (MODIFY - 66)) | (1L << (MONTH - 66)) | (1L << (MOVE - 66)) | (1L << (MUTATION - 66)) | (1L << (NO - 66)) | (1L << (NOT - 66)) | (1L << (NULLS - 66)) | (1L << (OFFSET - 66)) | (1L << (ON - 66)) | (1L << (OPTIMIZE - 66)) | (1L << (OR - 66)) | (1L << (ORDER - 66)) | (1L << (OUTER - 66)) | (1L << (OUTFILE - 66)) | (1L << (OVER - 66)) | (1L << (PARTITION - 66)) | (1L << (POPULATE - 66)) | (1L << (PRECEDING - 66)) | (1L << (PREWHERE - 66)) | (1L << (PRIMARY - 66)))) != 0) || ((((_la - 131)) & ~0x3f) == 0 && ((1L << (_la - 131)) & ((1L << (QUARTER - 131)) | (1L << (RANGE - 131)) | (1L << (RELOAD - 131)) | (1L << (REMOVE - 131)) | (1L << (RENAME - 131)) | (1L << (REPLACE - 131)) | (1L << (REPLICA - 131)) | (1L << (REPLICATED - 131)) | (1L << (RIGHT - 131)) | (1L << (ROLLUP - 131)) | (1L << (ROW - 131)) | (1L << (ROWS - 131)) | (1L << (SAMPLE - 131)) | (1L << (SECOND - 131)) | (1L << (SELECT - 131)) | (1L << (SEMI - 131)) | (1L << (SENDS - 131)) | (1L << (SET - 131)) | (1L << (SETTINGS - 131)) | (1L << (SHOW - 131)) | (1L << (SOURCE - 131)) | (1L << (START - 131)) | (1L << (STOP - 131)) | (1L << (SUBSTRING - 131)) | (1L << (SYNC - 131)) | (1L << (SYNTAX - 131)) | (1L << (SYSTEM - 131)) | (1L << (TABLE - 131)) | (1L << (TABLES - 131)) | (1L << (TEMPORARY - 131)) | (1L << (TEST - 131)) | (1L << (THEN - 131)) | (1L << (TIES - 131)) | (1L << (TIMEOUT - 131)) | (1L << (TIMESTAMP - 131)) | (1L << (TO - 131)) | (1L << (TOP - 131)) | (1L << (TOTALS - 131)) | (1L << (TRAILING - 131)) | (1L << (TRIM - 131)) | (1L << (TRUNCATE - 131)) | (1L << (TTL - 131)) | (1L << (TYPE - 131)) | (1L << (UNBOUNDED - 131)) | (1L << (UNION - 131)) | (1L << (UPDATE - 131)) | (1L << (USE - 131)) | (1L << (USING - 131)) | (1L << (UUID - 131)) | (1L << (VALUES - 131)) | (1L << (VIEW - 131)) | (1L << (VOLUME - 131)) | (1L << (WATCH - 131)) | (1L << (WEEK - 131)) | (1L << (WHEN - 131)) | (1L << (WHERE - 131)) | (1L << (WINDOW - 131)) | (1L << (WITH - 131)) | (1L << (YEAR - 131)) | (1L << (JSON_FALSE - 131)) | (1L << (JSON_TRUE - 131)) | (1L << (IDENTIFIER - 131)))) != 0)) {
					{
					State = 1787; tableIdentifier();
					State = 1788; Match(DOT);
					}
				}

				State = 1792; Match(ASTERISK);
				}
				break;

			case 16:
				{
				_localctx = new ColumnExprSubqueryContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1793; Match(LPAREN);
				State = 1794; selectUnionStmt();
				State = 1795; Match(RPAREN);
				}
				break;

			case 17:
				{
				_localctx = new ColumnExprParensContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1797; Match(LPAREN);
				State = 1798; columnExpr(0);
				State = 1799; Match(RPAREN);
				}
				break;

			case 18:
				{
				_localctx = new ColumnExprTupleContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1801; Match(LPAREN);
				State = 1802; columnExprList();
				State = 1803; Match(RPAREN);
				}
				break;

			case 19:
				{
				_localctx = new ColumnExprArrayContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1805; Match(LBRACKET);
				State = 1807;
				_errHandler.Sync(this);
				_la = _input.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (ASTERISK - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (LBRACKET - 192)) | (1L << (LPAREN - 192)) | (1L << (PLUS - 192)))) != 0)) {
					{
					State = 1806; columnExprList();
					}
				}

				State = 1809; Match(RBRACKET);
				}
				break;

			case 20:
				{
				_localctx = new ColumnExprIdentifierContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1810; columnIdentifier();
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 1884;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,247,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1882;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,246,_ctx) ) {
					case 1:
						{
						_localctx = new ColumnExprPrecedence1Context(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1813;
						if (!(Precpred(_ctx, 16))) throw new FailedPredicateException(this, "Precpred(_ctx, 16)");
						State = 1814;
						_la = _input.La(1);
						if ( !(((((_la - 199)) & ~0x3f) == 0 && ((1L << (_la - 199)) & ((1L << (ASTERISK - 199)) | (1L << (PERCENT - 199)) | (1L << (SLASH - 199)))) != 0)) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 1815; columnExpr(17);
						}
						break;

					case 2:
						{
						_localctx = new ColumnExprPrecedence2Context(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1816;
						if (!(Precpred(_ctx, 15))) throw new FailedPredicateException(this, "Precpred(_ctx, 15)");
						State = 1817;
						_la = _input.La(1);
						if ( !(((((_la - 204)) & ~0x3f) == 0 && ((1L << (_la - 204)) & ((1L << (CONCAT - 204)) | (1L << (DASH - 204)) | (1L << (PLUS - 204)))) != 0)) ) {
						_errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 1818; columnExpr(16);
						}
						break;

					case 3:
						{
						_localctx = new ColumnExprPrecedence3Context(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1819;
						if (!(Precpred(_ctx, 14))) throw new FailedPredicateException(this, "Precpred(_ctx, 14)");
						State = 1838;
						_errHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(_input,242,_ctx) ) {
						case 1:
							{
							State = 1820; Match(EQ_DOUBLE);
							}
							break;

						case 2:
							{
							State = 1821; Match(EQ_SINGLE);
							}
							break;

						case 3:
							{
							State = 1822; Match(NOT_EQ);
							}
							break;

						case 4:
							{
							State = 1823; Match(LE);
							}
							break;

						case 5:
							{
							State = 1824; Match(GE);
							}
							break;

						case 6:
							{
							State = 1825; Match(LT);
							}
							break;

						case 7:
							{
							State = 1826; Match(GT);
							}
							break;

						case 8:
							{
							State = 1828;
							_errHandler.Sync(this);
							_la = _input.La(1);
							if (_la==GLOBAL) {
								{
								State = 1827; Match(GLOBAL);
								}
							}

							State = 1831;
							_errHandler.Sync(this);
							_la = _input.La(1);
							if (_la==NOT) {
								{
								State = 1830; Match(NOT);
								}
							}

							State = 1833; Match(IN);
							}
							break;

						case 9:
							{
							State = 1835;
							_errHandler.Sync(this);
							_la = _input.La(1);
							if (_la==NOT) {
								{
								State = 1834; Match(NOT);
								}
							}

							State = 1837;
							_la = _input.La(1);
							if ( !(_la==ILIKE || _la==LIKE) ) {
							_errHandler.RecoverInline(this);
							} else {
								if (_input.La(1) == TokenConstants.Eof) {
									matchedEOF = true;
								}

								_errHandler.ReportMatch(this);
								Consume();
							}
							}
							break;
						}
						State = 1840; columnExpr(15);
						}
						break;

					case 4:
						{
						_localctx = new ColumnExprAndContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1841;
						if (!(Precpred(_ctx, 11))) throw new FailedPredicateException(this, "Precpred(_ctx, 11)");
						State = 1842; Match(AND);
						State = 1843; columnExpr(12);
						}
						break;

					case 5:
						{
						_localctx = new ColumnExprOrContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1844;
						if (!(Precpred(_ctx, 10))) throw new FailedPredicateException(this, "Precpred(_ctx, 10)");
						State = 1845; Match(OR);
						State = 1846; columnExpr(11);
						}
						break;

					case 6:
						{
						_localctx = new ColumnExprBetweenContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1847;
						if (!(Precpred(_ctx, 9))) throw new FailedPredicateException(this, "Precpred(_ctx, 9)");
						State = 1849;
						_errHandler.Sync(this);
						_la = _input.La(1);
						if (_la==NOT) {
							{
							State = 1848; Match(NOT);
							}
						}

						State = 1851; Match(BETWEEN);
						State = 1852; columnExpr(0);
						State = 1853; Match(AND);
						State = 1854; columnExpr(10);
						}
						break;

					case 7:
						{
						_localctx = new ColumnExprTernaryOpContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1856;
						if (!(Precpred(_ctx, 8))) throw new FailedPredicateException(this, "Precpred(_ctx, 8)");
						State = 1857; Match(QUERY);
						State = 1858; columnExpr(0);
						State = 1859; Match(COLON);
						State = 1860; columnExpr(8);
						}
						break;

					case 8:
						{
						_localctx = new ColumnExprArrayAccessContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1862;
						if (!(Precpred(_ctx, 19))) throw new FailedPredicateException(this, "Precpred(_ctx, 19)");
						State = 1863; Match(LBRACKET);
						State = 1864; columnExpr(0);
						State = 1865; Match(RBRACKET);
						}
						break;

					case 9:
						{
						_localctx = new ColumnExprTupleAccessContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1867;
						if (!(Precpred(_ctx, 18))) throw new FailedPredicateException(this, "Precpred(_ctx, 18)");
						State = 1868; Match(DOT);
						State = 1869; Match(DECIMAL_LITERAL);
						}
						break;

					case 10:
						{
						_localctx = new ColumnExprIsNullContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1870;
						if (!(Precpred(_ctx, 13))) throw new FailedPredicateException(this, "Precpred(_ctx, 13)");
						State = 1871; Match(IS);
						State = 1873;
						_errHandler.Sync(this);
						_la = _input.La(1);
						if (_la==NOT) {
							{
							State = 1872; Match(NOT);
							}
						}

						State = 1875; Match(NULL_SQL);
						}
						break;

					case 11:
						{
						_localctx = new ColumnExprAliasContext(new ColumnExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_columnExpr);
						State = 1876;
						if (!(Precpred(_ctx, 7))) throw new FailedPredicateException(this, "Precpred(_ctx, 7)");
						State = 1880;
						_errHandler.Sync(this);
						switch (_input.La(1)) {
						case DATE:
						case FIRST:
						case ID:
						case KEY:
						case IDENTIFIER:
							{
							State = 1877; alias();
							}
							break;
						case AS:
							{
							State = 1878; Match(AS);
							State = 1879; identifier();
							}
							break;
						default:
							throw new NoViableAltException(this);
						}
						}
						break;
					}
					} 
				}
				State = 1886;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,247,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ColumnArgListContext : ParserRuleContext {
		public ColumnArgExprContext[] columnArgExpr() {
			return GetRuleContexts<ColumnArgExprContext>();
		}
		public ColumnArgExprContext columnArgExpr(int i) {
			return GetRuleContext<ColumnArgExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnArgListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnArgList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnArgList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnArgList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnArgList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnArgListContext columnArgList() {
		ColumnArgListContext _localctx = new ColumnArgListContext(_ctx, State);
		EnterRule(_localctx, 196, RULE_columnArgList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1887; columnArgExpr();
			State = 1892;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 1888; Match(COMMA);
				State = 1889; columnArgExpr();
				}
				}
				State = 1894;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnArgExprContext : ParserRuleContext {
		public ColumnLambdaExprContext columnLambdaExpr() {
			return GetRuleContext<ColumnLambdaExprContext>(0);
		}
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ColumnArgExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnArgExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnArgExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnArgExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnArgExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnArgExprContext columnArgExpr() {
		ColumnArgExprContext _localctx = new ColumnArgExprContext(_ctx, State);
		EnterRule(_localctx, 198, RULE_columnArgExpr);
		try {
			State = 1897;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,249,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1895; columnLambdaExpr();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1896; columnExpr(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnLambdaExprContext : ParserRuleContext {
		public ITerminalNode ARROW() { return GetToken(ClickHouseParser.ARROW, 0); }
		public ColumnExprContext columnExpr() {
			return GetRuleContext<ColumnExprContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public ColumnLambdaExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnLambdaExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnLambdaExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnLambdaExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnLambdaExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnLambdaExprContext columnLambdaExpr() {
		ColumnLambdaExprContext _localctx = new ColumnLambdaExprContext(_ctx, State);
		EnterRule(_localctx, 200, RULE_columnLambdaExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1918;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case LPAREN:
				{
				State = 1899; Match(LPAREN);
				State = 1900; identifier();
				State = 1905;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 1901; Match(COMMA);
					State = 1902; identifier();
					}
					}
					State = 1907;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 1908; Match(RPAREN);
				}
				break;
			case AFTER:
			case ALIAS:
			case ALL:
			case ALTER:
			case AND:
			case ANTI:
			case ANY:
			case ARRAY:
			case AS:
			case ASCENDING:
			case ASOF:
			case AST:
			case ASYNC:
			case ATTACH:
			case BETWEEN:
			case BOTH:
			case BY:
			case CASE:
			case CAST:
			case CHECK:
			case CLEAR:
			case CLUSTER:
			case CODEC:
			case COLLATE:
			case COLUMN:
			case COMMENT:
			case CONSTRAINT:
			case CREATE:
			case CROSS:
			case CUBE:
			case CURRENT:
			case DATABASE:
			case DATABASES:
			case DATE:
			case DAY:
			case DEDUPLICATE:
			case DEFAULT:
			case DELAY:
			case DELETE:
			case DESC:
			case DESCENDING:
			case DESCRIBE:
			case DETACH:
			case DICTIONARIES:
			case DICTIONARY:
			case DISK:
			case DISTINCT:
			case DISTRIBUTED:
			case DROP:
			case ELSE:
			case END:
			case ENGINE:
			case EVENTS:
			case EXISTS:
			case EXPLAIN:
			case EXPRESSION:
			case EXTRACT:
			case FETCHES:
			case FINAL:
			case FIRST:
			case FLUSH:
			case FOLLOWING:
			case FOR:
			case FORMAT:
			case FREEZE:
			case FROM:
			case FULL:
			case FUNCTION:
			case GLOBAL:
			case GRANULARITY:
			case GROUP:
			case HAVING:
			case HIERARCHICAL:
			case HOUR:
			case ID:
			case IF:
			case ILIKE:
			case IN:
			case INDEX:
			case INJECTIVE:
			case INNER:
			case INSERT:
			case INTERVAL:
			case INTO:
			case IS:
			case IS_OBJECT_ID:
			case JOIN:
			case KEY:
			case KILL:
			case LAST:
			case LAYOUT:
			case LEADING:
			case LEFT:
			case LIFETIME:
			case LIKE:
			case LIMIT:
			case LIVE:
			case LOCAL:
			case LOGS:
			case MATERIALIZE:
			case MATERIALIZED:
			case MAX:
			case MERGES:
			case MIN:
			case MINUTE:
			case MODIFY:
			case MONTH:
			case MOVE:
			case MUTATION:
			case NO:
			case NOT:
			case NULLS:
			case OFFSET:
			case ON:
			case OPTIMIZE:
			case OR:
			case ORDER:
			case OUTER:
			case OUTFILE:
			case OVER:
			case PARTITION:
			case POPULATE:
			case PRECEDING:
			case PREWHERE:
			case PRIMARY:
			case QUARTER:
			case RANGE:
			case RELOAD:
			case REMOVE:
			case RENAME:
			case REPLACE:
			case REPLICA:
			case REPLICATED:
			case RIGHT:
			case ROLLUP:
			case ROW:
			case ROWS:
			case SAMPLE:
			case SECOND:
			case SELECT:
			case SEMI:
			case SENDS:
			case SET:
			case SETTINGS:
			case SHOW:
			case SOURCE:
			case START:
			case STOP:
			case SUBSTRING:
			case SYNC:
			case SYNTAX:
			case SYSTEM:
			case TABLE:
			case TABLES:
			case TEMPORARY:
			case TEST:
			case THEN:
			case TIES:
			case TIMEOUT:
			case TIMESTAMP:
			case TO:
			case TOP:
			case TOTALS:
			case TRAILING:
			case TRIM:
			case TRUNCATE:
			case TTL:
			case TYPE:
			case UNBOUNDED:
			case UNION:
			case UPDATE:
			case USE:
			case USING:
			case UUID:
			case VALUES:
			case VIEW:
			case VOLUME:
			case WATCH:
			case WEEK:
			case WHEN:
			case WHERE:
			case WINDOW:
			case WITH:
			case YEAR:
			case JSON_FALSE:
			case JSON_TRUE:
			case IDENTIFIER:
				{
				State = 1910; identifier();
				State = 1915;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==COMMA) {
					{
					{
					State = 1911; Match(COMMA);
					State = 1912; identifier();
					}
					}
					State = 1917;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1920; Match(ARROW);
			State = 1921; columnExpr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColumnIdentifierContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public ColumnIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_columnIdentifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterColumnIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitColumnIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitColumnIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ColumnIdentifierContext columnIdentifier() {
		ColumnIdentifierContext _localctx = new ColumnIdentifierContext(_ctx, State);
		EnterRule(_localctx, 202, RULE_columnIdentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1926;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,253,_ctx) ) {
			case 1:
				{
				State = 1923; tableIdentifier();
				State = 1924; Match(DOT);
				}
				break;
			}
			State = 1928; nestedIdentifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NestedIdentifierContext : ParserRuleContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public NestedIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_nestedIdentifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterNestedIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitNestedIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNestedIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NestedIdentifierContext nestedIdentifier() {
		NestedIdentifierContext _localctx = new NestedIdentifierContext(_ctx, State);
		EnterRule(_localctx, 204, RULE_nestedIdentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1930; identifier();
			State = 1933;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,254,_ctx) ) {
			case 1:
				{
				State = 1931; Match(DOT);
				State = 1932; identifier();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableExprContext : ParserRuleContext {
		public TableExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableExpr; } }
	 
		public TableExprContext() { }
		public virtual void CopyFrom(TableExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TableExprIdentifierContext : TableExprContext {
		public TableIdentifierContext tableIdentifier() {
			return GetRuleContext<TableIdentifierContext>(0);
		}
		public TableExprIdentifierContext(TableExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableExprIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableExprIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableExprIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableExprSubqueryContext : TableExprContext {
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public SelectUnionStmtContext selectUnionStmt() {
			return GetRuleContext<SelectUnionStmtContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public TableExprSubqueryContext(TableExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableExprSubquery(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableExprSubquery(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableExprSubquery(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableExprAliasContext : TableExprContext {
		public TableExprContext tableExpr() {
			return GetRuleContext<TableExprContext>(0);
		}
		public AliasContext alias() {
			return GetRuleContext<AliasContext>(0);
		}
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public TableExprAliasContext(TableExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableExprAlias(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableExprAlias(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableExprAlias(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TableExprFunctionContext : TableExprContext {
		public TableFunctionExprContext tableFunctionExpr() {
			return GetRuleContext<TableFunctionExprContext>(0);
		}
		public TableExprFunctionContext(TableExprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableExprFunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableExprFunction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableExprFunction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableExprContext tableExpr() {
		return tableExpr(0);
	}

	private TableExprContext tableExpr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		TableExprContext _localctx = new TableExprContext(_ctx, _parentState);
		TableExprContext _prevctx = _localctx;
		int _startState = 206;
		EnterRecursionRule(_localctx, 206, RULE_tableExpr, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1942;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,255,_ctx) ) {
			case 1:
				{
				_localctx = new TableExprIdentifierContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 1936; tableIdentifier();
				}
				break;

			case 2:
				{
				_localctx = new TableExprFunctionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1937; tableFunctionExpr();
				}
				break;

			case 3:
				{
				_localctx = new TableExprSubqueryContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 1938; Match(LPAREN);
				State = 1939; selectUnionStmt();
				State = 1940; Match(RPAREN);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 1952;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,257,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TableExprAliasContext(new TableExprContext(_parentctx, _parentState));
					PushNewRecursionContext(_localctx, _startState, RULE_tableExpr);
					State = 1944;
					if (!(Precpred(_ctx, 1))) throw new FailedPredicateException(this, "Precpred(_ctx, 1)");
					State = 1948;
					_errHandler.Sync(this);
					switch (_input.La(1)) {
					case DATE:
					case FIRST:
					case ID:
					case KEY:
					case IDENTIFIER:
						{
						State = 1945; alias();
						}
						break;
					case AS:
						{
						State = 1946; Match(AS);
						State = 1947; identifier();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					} 
				}
				State = 1954;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,257,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TableFunctionExprContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(ClickHouseParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(ClickHouseParser.RPAREN, 0); }
		public TableArgListContext tableArgList() {
			return GetRuleContext<TableArgListContext>(0);
		}
		public TableFunctionExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableFunctionExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableFunctionExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableFunctionExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableFunctionExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableFunctionExprContext tableFunctionExpr() {
		TableFunctionExprContext _localctx = new TableFunctionExprContext(_ctx, State);
		EnterRule(_localctx, 208, RULE_tableFunctionExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1955; identifier();
			State = 1956; Match(LPAREN);
			State = 1958;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DAY) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (HOUR - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INF - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MINUTE - 64)) | (1L << (MODIFY - 64)) | (1L << (MONTH - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NAN_SQL - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULL_SQL - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (QUARTER - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SECOND - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WEEK - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (YEAR - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0) || ((((_la - 192)) & ~0x3f) == 0 && ((1L << (_la - 192)) & ((1L << (IDENTIFIER - 192)) | (1L << (FLOATING_LITERAL - 192)) | (1L << (OCTAL_LITERAL - 192)) | (1L << (DECIMAL_LITERAL - 192)) | (1L << (HEXADECIMAL_LITERAL - 192)) | (1L << (STRING_LITERAL - 192)) | (1L << (DASH - 192)) | (1L << (DOT - 192)) | (1L << (PLUS - 192)))) != 0)) {
				{
				State = 1957; tableArgList();
				}
			}

			State = 1960; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableIdentifierContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public DatabaseIdentifierContext databaseIdentifier() {
			return GetRuleContext<DatabaseIdentifierContext>(0);
		}
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public TableIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableIdentifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableIdentifierContext tableIdentifier() {
		TableIdentifierContext _localctx = new TableIdentifierContext(_ctx, State);
		EnterRule(_localctx, 210, RULE_tableIdentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1965;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,259,_ctx) ) {
			case 1:
				{
				State = 1962; databaseIdentifier();
				State = 1963; Match(DOT);
				}
				break;
			}
			State = 1967; identifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableArgListContext : ParserRuleContext {
		public TableArgExprContext[] tableArgExpr() {
			return GetRuleContexts<TableArgExprContext>();
		}
		public TableArgExprContext tableArgExpr(int i) {
			return GetRuleContext<TableArgExprContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(ClickHouseParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(ClickHouseParser.COMMA, i);
		}
		public TableArgListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableArgList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableArgList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableArgList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableArgList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableArgListContext tableArgList() {
		TableArgListContext _localctx = new TableArgListContext(_ctx, State);
		EnterRule(_localctx, 212, RULE_tableArgList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1969; tableArgExpr();
			State = 1974;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMMA) {
				{
				{
				State = 1970; Match(COMMA);
				State = 1971; tableArgExpr();
				}
				}
				State = 1976;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TableArgExprContext : ParserRuleContext {
		public NestedIdentifierContext nestedIdentifier() {
			return GetRuleContext<NestedIdentifierContext>(0);
		}
		public TableFunctionExprContext tableFunctionExpr() {
			return GetRuleContext<TableFunctionExprContext>(0);
		}
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public TableArgExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tableArgExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterTableArgExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitTableArgExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTableArgExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TableArgExprContext tableArgExpr() {
		TableArgExprContext _localctx = new TableArgExprContext(_ctx, State);
		EnterRule(_localctx, 214, RULE_tableArgExpr);
		try {
			State = 1980;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,261,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1977; nestedIdentifier();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1978; tableFunctionExpr();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1979; literal();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DatabaseIdentifierContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public DatabaseIdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_databaseIdentifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterDatabaseIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitDatabaseIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDatabaseIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DatabaseIdentifierContext databaseIdentifier() {
		DatabaseIdentifierContext _localctx = new DatabaseIdentifierContext(_ctx, State);
		EnterRule(_localctx, 216, RULE_databaseIdentifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1982; identifier();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FloatingLiteralContext : ParserRuleContext {
		public ITerminalNode FLOATING_LITERAL() { return GetToken(ClickHouseParser.FLOATING_LITERAL, 0); }
		public ITerminalNode DOT() { return GetToken(ClickHouseParser.DOT, 0); }
		public ITerminalNode[] DECIMAL_LITERAL() { return GetTokens(ClickHouseParser.DECIMAL_LITERAL); }
		public ITerminalNode DECIMAL_LITERAL(int i) {
			return GetToken(ClickHouseParser.DECIMAL_LITERAL, i);
		}
		public ITerminalNode OCTAL_LITERAL() { return GetToken(ClickHouseParser.OCTAL_LITERAL, 0); }
		public FloatingLiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_floatingLiteral; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterFloatingLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitFloatingLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFloatingLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FloatingLiteralContext floatingLiteral() {
		FloatingLiteralContext _localctx = new FloatingLiteralContext(_ctx, State);
		EnterRule(_localctx, 218, RULE_floatingLiteral);
		int _la;
		try {
			State = 1992;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case FLOATING_LITERAL:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1984; Match(FLOATING_LITERAL);
				}
				break;
			case DOT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1985; Match(DOT);
				State = 1986;
				_la = _input.La(1);
				if ( !(_la==OCTAL_LITERAL || _la==DECIMAL_LITERAL) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;
			case DECIMAL_LITERAL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1987; Match(DECIMAL_LITERAL);
				State = 1988; Match(DOT);
				State = 1990;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,262,_ctx) ) {
				case 1:
					{
					State = 1989;
					_la = _input.La(1);
					if ( !(_la==OCTAL_LITERAL || _la==DECIMAL_LITERAL) ) {
					_errHandler.RecoverInline(this);
					} else {
						if (_input.La(1) == TokenConstants.Eof) {
							matchedEOF = true;
						}

						_errHandler.ReportMatch(this);
						Consume();
					}
					}
					break;
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberLiteralContext : ParserRuleContext {
		public FloatingLiteralContext floatingLiteral() {
			return GetRuleContext<FloatingLiteralContext>(0);
		}
		public ITerminalNode OCTAL_LITERAL() { return GetToken(ClickHouseParser.OCTAL_LITERAL, 0); }
		public ITerminalNode DECIMAL_LITERAL() { return GetToken(ClickHouseParser.DECIMAL_LITERAL, 0); }
		public ITerminalNode HEXADECIMAL_LITERAL() { return GetToken(ClickHouseParser.HEXADECIMAL_LITERAL, 0); }
		public ITerminalNode INF() { return GetToken(ClickHouseParser.INF, 0); }
		public ITerminalNode NAN_SQL() { return GetToken(ClickHouseParser.NAN_SQL, 0); }
		public ITerminalNode PLUS() { return GetToken(ClickHouseParser.PLUS, 0); }
		public ITerminalNode DASH() { return GetToken(ClickHouseParser.DASH, 0); }
		public NumberLiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numberLiteral; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterNumberLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitNumberLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberLiteralContext numberLiteral() {
		NumberLiteralContext _localctx = new NumberLiteralContext(_ctx, State);
		EnterRule(_localctx, 220, RULE_numberLiteral);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1995;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==DASH || _la==PLUS) {
				{
				State = 1994;
				_la = _input.La(1);
				if ( !(_la==DASH || _la==PLUS) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
			}

			State = 2003;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,265,_ctx) ) {
			case 1:
				{
				State = 1997; floatingLiteral();
				}
				break;

			case 2:
				{
				State = 1998; Match(OCTAL_LITERAL);
				}
				break;

			case 3:
				{
				State = 1999; Match(DECIMAL_LITERAL);
				}
				break;

			case 4:
				{
				State = 2000; Match(HEXADECIMAL_LITERAL);
				}
				break;

			case 5:
				{
				State = 2001; Match(INF);
				}
				break;

			case 6:
				{
				State = 2002; Match(NAN_SQL);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LiteralContext : ParserRuleContext {
		public NumberLiteralContext numberLiteral() {
			return GetRuleContext<NumberLiteralContext>(0);
		}
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode NULL_SQL() { return GetToken(ClickHouseParser.NULL_SQL, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(_ctx, State);
		EnterRule(_localctx, 222, RULE_literal);
		try {
			State = 2008;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INF:
			case NAN_SQL:
			case FLOATING_LITERAL:
			case OCTAL_LITERAL:
			case DECIMAL_LITERAL:
			case HEXADECIMAL_LITERAL:
			case DASH:
			case DOT:
			case PLUS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2005; numberLiteral();
				}
				break;
			case STRING_LITERAL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2006; Match(STRING_LITERAL);
				}
				break;
			case NULL_SQL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2007; Match(NULL_SQL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntervalContext : ParserRuleContext {
		public ITerminalNode SECOND() { return GetToken(ClickHouseParser.SECOND, 0); }
		public ITerminalNode MINUTE() { return GetToken(ClickHouseParser.MINUTE, 0); }
		public ITerminalNode HOUR() { return GetToken(ClickHouseParser.HOUR, 0); }
		public ITerminalNode DAY() { return GetToken(ClickHouseParser.DAY, 0); }
		public ITerminalNode WEEK() { return GetToken(ClickHouseParser.WEEK, 0); }
		public ITerminalNode MONTH() { return GetToken(ClickHouseParser.MONTH, 0); }
		public ITerminalNode QUARTER() { return GetToken(ClickHouseParser.QUARTER, 0); }
		public ITerminalNode YEAR() { return GetToken(ClickHouseParser.YEAR, 0); }
		public IntervalContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interval; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterInterval(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitInterval(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInterval(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntervalContext interval() {
		IntervalContext _localctx = new IntervalContext(_ctx, State);
		EnterRule(_localctx, 224, RULE_interval);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2010;
			_la = _input.La(1);
			if ( !(_la==DAY || ((((_la - 75)) & ~0x3f) == 0 && ((1L << (_la - 75)) & ((1L << (HOUR - 75)) | (1L << (MINUTE - 75)) | (1L << (MONTH - 75)) | (1L << (QUARTER - 75)))) != 0) || ((((_la - 144)) & ~0x3f) == 0 && ((1L << (_la - 144)) & ((1L << (SECOND - 144)) | (1L << (WEEK - 144)) | (1L << (YEAR - 144)))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KeywordContext : ParserRuleContext {
		public ITerminalNode AFTER() { return GetToken(ClickHouseParser.AFTER, 0); }
		public ITerminalNode ALIAS() { return GetToken(ClickHouseParser.ALIAS, 0); }
		public ITerminalNode ALL() { return GetToken(ClickHouseParser.ALL, 0); }
		public ITerminalNode ALTER() { return GetToken(ClickHouseParser.ALTER, 0); }
		public ITerminalNode AND() { return GetToken(ClickHouseParser.AND, 0); }
		public ITerminalNode ANTI() { return GetToken(ClickHouseParser.ANTI, 0); }
		public ITerminalNode ANY() { return GetToken(ClickHouseParser.ANY, 0); }
		public ITerminalNode ARRAY() { return GetToken(ClickHouseParser.ARRAY, 0); }
		public ITerminalNode AS() { return GetToken(ClickHouseParser.AS, 0); }
		public ITerminalNode ASCENDING() { return GetToken(ClickHouseParser.ASCENDING, 0); }
		public ITerminalNode ASOF() { return GetToken(ClickHouseParser.ASOF, 0); }
		public ITerminalNode AST() { return GetToken(ClickHouseParser.AST, 0); }
		public ITerminalNode ASYNC() { return GetToken(ClickHouseParser.ASYNC, 0); }
		public ITerminalNode ATTACH() { return GetToken(ClickHouseParser.ATTACH, 0); }
		public ITerminalNode BETWEEN() { return GetToken(ClickHouseParser.BETWEEN, 0); }
		public ITerminalNode BOTH() { return GetToken(ClickHouseParser.BOTH, 0); }
		public ITerminalNode BY() { return GetToken(ClickHouseParser.BY, 0); }
		public ITerminalNode CASE() { return GetToken(ClickHouseParser.CASE, 0); }
		public ITerminalNode CAST() { return GetToken(ClickHouseParser.CAST, 0); }
		public ITerminalNode CHECK() { return GetToken(ClickHouseParser.CHECK, 0); }
		public ITerminalNode CLEAR() { return GetToken(ClickHouseParser.CLEAR, 0); }
		public ITerminalNode CLUSTER() { return GetToken(ClickHouseParser.CLUSTER, 0); }
		public ITerminalNode CODEC() { return GetToken(ClickHouseParser.CODEC, 0); }
		public ITerminalNode COLLATE() { return GetToken(ClickHouseParser.COLLATE, 0); }
		public ITerminalNode COLUMN() { return GetToken(ClickHouseParser.COLUMN, 0); }
		public ITerminalNode COMMENT() { return GetToken(ClickHouseParser.COMMENT, 0); }
		public ITerminalNode CONSTRAINT() { return GetToken(ClickHouseParser.CONSTRAINT, 0); }
		public ITerminalNode CREATE() { return GetToken(ClickHouseParser.CREATE, 0); }
		public ITerminalNode CROSS() { return GetToken(ClickHouseParser.CROSS, 0); }
		public ITerminalNode CUBE() { return GetToken(ClickHouseParser.CUBE, 0); }
		public ITerminalNode CURRENT() { return GetToken(ClickHouseParser.CURRENT, 0); }
		public ITerminalNode DATABASE() { return GetToken(ClickHouseParser.DATABASE, 0); }
		public ITerminalNode DATABASES() { return GetToken(ClickHouseParser.DATABASES, 0); }
		public ITerminalNode DATE() { return GetToken(ClickHouseParser.DATE, 0); }
		public ITerminalNode DEDUPLICATE() { return GetToken(ClickHouseParser.DEDUPLICATE, 0); }
		public ITerminalNode DEFAULT() { return GetToken(ClickHouseParser.DEFAULT, 0); }
		public ITerminalNode DELAY() { return GetToken(ClickHouseParser.DELAY, 0); }
		public ITerminalNode DELETE() { return GetToken(ClickHouseParser.DELETE, 0); }
		public ITerminalNode DESCRIBE() { return GetToken(ClickHouseParser.DESCRIBE, 0); }
		public ITerminalNode DESC() { return GetToken(ClickHouseParser.DESC, 0); }
		public ITerminalNode DESCENDING() { return GetToken(ClickHouseParser.DESCENDING, 0); }
		public ITerminalNode DETACH() { return GetToken(ClickHouseParser.DETACH, 0); }
		public ITerminalNode DICTIONARIES() { return GetToken(ClickHouseParser.DICTIONARIES, 0); }
		public ITerminalNode DICTIONARY() { return GetToken(ClickHouseParser.DICTIONARY, 0); }
		public ITerminalNode DISK() { return GetToken(ClickHouseParser.DISK, 0); }
		public ITerminalNode DISTINCT() { return GetToken(ClickHouseParser.DISTINCT, 0); }
		public ITerminalNode DISTRIBUTED() { return GetToken(ClickHouseParser.DISTRIBUTED, 0); }
		public ITerminalNode DROP() { return GetToken(ClickHouseParser.DROP, 0); }
		public ITerminalNode ELSE() { return GetToken(ClickHouseParser.ELSE, 0); }
		public ITerminalNode END() { return GetToken(ClickHouseParser.END, 0); }
		public ITerminalNode ENGINE() { return GetToken(ClickHouseParser.ENGINE, 0); }
		public ITerminalNode EVENTS() { return GetToken(ClickHouseParser.EVENTS, 0); }
		public ITerminalNode EXISTS() { return GetToken(ClickHouseParser.EXISTS, 0); }
		public ITerminalNode EXPLAIN() { return GetToken(ClickHouseParser.EXPLAIN, 0); }
		public ITerminalNode EXPRESSION() { return GetToken(ClickHouseParser.EXPRESSION, 0); }
		public ITerminalNode EXTRACT() { return GetToken(ClickHouseParser.EXTRACT, 0); }
		public ITerminalNode FETCHES() { return GetToken(ClickHouseParser.FETCHES, 0); }
		public ITerminalNode FINAL() { return GetToken(ClickHouseParser.FINAL, 0); }
		public ITerminalNode FIRST() { return GetToken(ClickHouseParser.FIRST, 0); }
		public ITerminalNode FLUSH() { return GetToken(ClickHouseParser.FLUSH, 0); }
		public ITerminalNode FOR() { return GetToken(ClickHouseParser.FOR, 0); }
		public ITerminalNode FOLLOWING() { return GetToken(ClickHouseParser.FOLLOWING, 0); }
		public ITerminalNode FORMAT() { return GetToken(ClickHouseParser.FORMAT, 0); }
		public ITerminalNode FREEZE() { return GetToken(ClickHouseParser.FREEZE, 0); }
		public ITerminalNode FROM() { return GetToken(ClickHouseParser.FROM, 0); }
		public ITerminalNode FULL() { return GetToken(ClickHouseParser.FULL, 0); }
		public ITerminalNode FUNCTION() { return GetToken(ClickHouseParser.FUNCTION, 0); }
		public ITerminalNode GLOBAL() { return GetToken(ClickHouseParser.GLOBAL, 0); }
		public ITerminalNode GRANULARITY() { return GetToken(ClickHouseParser.GRANULARITY, 0); }
		public ITerminalNode GROUP() { return GetToken(ClickHouseParser.GROUP, 0); }
		public ITerminalNode HAVING() { return GetToken(ClickHouseParser.HAVING, 0); }
		public ITerminalNode HIERARCHICAL() { return GetToken(ClickHouseParser.HIERARCHICAL, 0); }
		public ITerminalNode ID() { return GetToken(ClickHouseParser.ID, 0); }
		public ITerminalNode IF() { return GetToken(ClickHouseParser.IF, 0); }
		public ITerminalNode ILIKE() { return GetToken(ClickHouseParser.ILIKE, 0); }
		public ITerminalNode IN() { return GetToken(ClickHouseParser.IN, 0); }
		public ITerminalNode INDEX() { return GetToken(ClickHouseParser.INDEX, 0); }
		public ITerminalNode INJECTIVE() { return GetToken(ClickHouseParser.INJECTIVE, 0); }
		public ITerminalNode INNER() { return GetToken(ClickHouseParser.INNER, 0); }
		public ITerminalNode INSERT() { return GetToken(ClickHouseParser.INSERT, 0); }
		public ITerminalNode INTERVAL() { return GetToken(ClickHouseParser.INTERVAL, 0); }
		public ITerminalNode INTO() { return GetToken(ClickHouseParser.INTO, 0); }
		public ITerminalNode IS() { return GetToken(ClickHouseParser.IS, 0); }
		public ITerminalNode IS_OBJECT_ID() { return GetToken(ClickHouseParser.IS_OBJECT_ID, 0); }
		public ITerminalNode JOIN() { return GetToken(ClickHouseParser.JOIN, 0); }
		public ITerminalNode JSON_FALSE() { return GetToken(ClickHouseParser.JSON_FALSE, 0); }
		public ITerminalNode JSON_TRUE() { return GetToken(ClickHouseParser.JSON_TRUE, 0); }
		public ITerminalNode KEY() { return GetToken(ClickHouseParser.KEY, 0); }
		public ITerminalNode KILL() { return GetToken(ClickHouseParser.KILL, 0); }
		public ITerminalNode LAST() { return GetToken(ClickHouseParser.LAST, 0); }
		public ITerminalNode LAYOUT() { return GetToken(ClickHouseParser.LAYOUT, 0); }
		public ITerminalNode LEADING() { return GetToken(ClickHouseParser.LEADING, 0); }
		public ITerminalNode LEFT() { return GetToken(ClickHouseParser.LEFT, 0); }
		public ITerminalNode LIFETIME() { return GetToken(ClickHouseParser.LIFETIME, 0); }
		public ITerminalNode LIKE() { return GetToken(ClickHouseParser.LIKE, 0); }
		public ITerminalNode LIMIT() { return GetToken(ClickHouseParser.LIMIT, 0); }
		public ITerminalNode LIVE() { return GetToken(ClickHouseParser.LIVE, 0); }
		public ITerminalNode LOCAL() { return GetToken(ClickHouseParser.LOCAL, 0); }
		public ITerminalNode LOGS() { return GetToken(ClickHouseParser.LOGS, 0); }
		public ITerminalNode MATERIALIZE() { return GetToken(ClickHouseParser.MATERIALIZE, 0); }
		public ITerminalNode MATERIALIZED() { return GetToken(ClickHouseParser.MATERIALIZED, 0); }
		public ITerminalNode MAX() { return GetToken(ClickHouseParser.MAX, 0); }
		public ITerminalNode MERGES() { return GetToken(ClickHouseParser.MERGES, 0); }
		public ITerminalNode MIN() { return GetToken(ClickHouseParser.MIN, 0); }
		public ITerminalNode MODIFY() { return GetToken(ClickHouseParser.MODIFY, 0); }
		public ITerminalNode MOVE() { return GetToken(ClickHouseParser.MOVE, 0); }
		public ITerminalNode MUTATION() { return GetToken(ClickHouseParser.MUTATION, 0); }
		public ITerminalNode NO() { return GetToken(ClickHouseParser.NO, 0); }
		public ITerminalNode NOT() { return GetToken(ClickHouseParser.NOT, 0); }
		public ITerminalNode NULLS() { return GetToken(ClickHouseParser.NULLS, 0); }
		public ITerminalNode OFFSET() { return GetToken(ClickHouseParser.OFFSET, 0); }
		public ITerminalNode ON() { return GetToken(ClickHouseParser.ON, 0); }
		public ITerminalNode OPTIMIZE() { return GetToken(ClickHouseParser.OPTIMIZE, 0); }
		public ITerminalNode OR() { return GetToken(ClickHouseParser.OR, 0); }
		public ITerminalNode ORDER() { return GetToken(ClickHouseParser.ORDER, 0); }
		public ITerminalNode OUTER() { return GetToken(ClickHouseParser.OUTER, 0); }
		public ITerminalNode OUTFILE() { return GetToken(ClickHouseParser.OUTFILE, 0); }
		public ITerminalNode OVER() { return GetToken(ClickHouseParser.OVER, 0); }
		public ITerminalNode PARTITION() { return GetToken(ClickHouseParser.PARTITION, 0); }
		public ITerminalNode POPULATE() { return GetToken(ClickHouseParser.POPULATE, 0); }
		public ITerminalNode PRECEDING() { return GetToken(ClickHouseParser.PRECEDING, 0); }
		public ITerminalNode PREWHERE() { return GetToken(ClickHouseParser.PREWHERE, 0); }
		public ITerminalNode PRIMARY() { return GetToken(ClickHouseParser.PRIMARY, 0); }
		public ITerminalNode RANGE() { return GetToken(ClickHouseParser.RANGE, 0); }
		public ITerminalNode RELOAD() { return GetToken(ClickHouseParser.RELOAD, 0); }
		public ITerminalNode REMOVE() { return GetToken(ClickHouseParser.REMOVE, 0); }
		public ITerminalNode RENAME() { return GetToken(ClickHouseParser.RENAME, 0); }
		public ITerminalNode REPLACE() { return GetToken(ClickHouseParser.REPLACE, 0); }
		public ITerminalNode REPLICA() { return GetToken(ClickHouseParser.REPLICA, 0); }
		public ITerminalNode REPLICATED() { return GetToken(ClickHouseParser.REPLICATED, 0); }
		public ITerminalNode RIGHT() { return GetToken(ClickHouseParser.RIGHT, 0); }
		public ITerminalNode ROLLUP() { return GetToken(ClickHouseParser.ROLLUP, 0); }
		public ITerminalNode ROW() { return GetToken(ClickHouseParser.ROW, 0); }
		public ITerminalNode ROWS() { return GetToken(ClickHouseParser.ROWS, 0); }
		public ITerminalNode SAMPLE() { return GetToken(ClickHouseParser.SAMPLE, 0); }
		public ITerminalNode SELECT() { return GetToken(ClickHouseParser.SELECT, 0); }
		public ITerminalNode SEMI() { return GetToken(ClickHouseParser.SEMI, 0); }
		public ITerminalNode SENDS() { return GetToken(ClickHouseParser.SENDS, 0); }
		public ITerminalNode SET() { return GetToken(ClickHouseParser.SET, 0); }
		public ITerminalNode SETTINGS() { return GetToken(ClickHouseParser.SETTINGS, 0); }
		public ITerminalNode SHOW() { return GetToken(ClickHouseParser.SHOW, 0); }
		public ITerminalNode SOURCE() { return GetToken(ClickHouseParser.SOURCE, 0); }
		public ITerminalNode START() { return GetToken(ClickHouseParser.START, 0); }
		public ITerminalNode STOP() { return GetToken(ClickHouseParser.STOP, 0); }
		public ITerminalNode SUBSTRING() { return GetToken(ClickHouseParser.SUBSTRING, 0); }
		public ITerminalNode SYNC() { return GetToken(ClickHouseParser.SYNC, 0); }
		public ITerminalNode SYNTAX() { return GetToken(ClickHouseParser.SYNTAX, 0); }
		public ITerminalNode SYSTEM() { return GetToken(ClickHouseParser.SYSTEM, 0); }
		public ITerminalNode TABLE() { return GetToken(ClickHouseParser.TABLE, 0); }
		public ITerminalNode TABLES() { return GetToken(ClickHouseParser.TABLES, 0); }
		public ITerminalNode TEMPORARY() { return GetToken(ClickHouseParser.TEMPORARY, 0); }
		public ITerminalNode TEST() { return GetToken(ClickHouseParser.TEST, 0); }
		public ITerminalNode THEN() { return GetToken(ClickHouseParser.THEN, 0); }
		public ITerminalNode TIES() { return GetToken(ClickHouseParser.TIES, 0); }
		public ITerminalNode TIMEOUT() { return GetToken(ClickHouseParser.TIMEOUT, 0); }
		public ITerminalNode TIMESTAMP() { return GetToken(ClickHouseParser.TIMESTAMP, 0); }
		public ITerminalNode TOTALS() { return GetToken(ClickHouseParser.TOTALS, 0); }
		public ITerminalNode TRAILING() { return GetToken(ClickHouseParser.TRAILING, 0); }
		public ITerminalNode TRIM() { return GetToken(ClickHouseParser.TRIM, 0); }
		public ITerminalNode TRUNCATE() { return GetToken(ClickHouseParser.TRUNCATE, 0); }
		public ITerminalNode TO() { return GetToken(ClickHouseParser.TO, 0); }
		public ITerminalNode TOP() { return GetToken(ClickHouseParser.TOP, 0); }
		public ITerminalNode TTL() { return GetToken(ClickHouseParser.TTL, 0); }
		public ITerminalNode TYPE() { return GetToken(ClickHouseParser.TYPE, 0); }
		public ITerminalNode UNBOUNDED() { return GetToken(ClickHouseParser.UNBOUNDED, 0); }
		public ITerminalNode UNION() { return GetToken(ClickHouseParser.UNION, 0); }
		public ITerminalNode UPDATE() { return GetToken(ClickHouseParser.UPDATE, 0); }
		public ITerminalNode USE() { return GetToken(ClickHouseParser.USE, 0); }
		public ITerminalNode USING() { return GetToken(ClickHouseParser.USING, 0); }
		public ITerminalNode UUID() { return GetToken(ClickHouseParser.UUID, 0); }
		public ITerminalNode VALUES() { return GetToken(ClickHouseParser.VALUES, 0); }
		public ITerminalNode VIEW() { return GetToken(ClickHouseParser.VIEW, 0); }
		public ITerminalNode VOLUME() { return GetToken(ClickHouseParser.VOLUME, 0); }
		public ITerminalNode WATCH() { return GetToken(ClickHouseParser.WATCH, 0); }
		public ITerminalNode WHEN() { return GetToken(ClickHouseParser.WHEN, 0); }
		public ITerminalNode WHERE() { return GetToken(ClickHouseParser.WHERE, 0); }
		public ITerminalNode WINDOW() { return GetToken(ClickHouseParser.WINDOW, 0); }
		public ITerminalNode WITH() { return GetToken(ClickHouseParser.WITH, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyword; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterKeyword(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitKeyword(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitKeyword(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public KeywordContext keyword() {
		KeywordContext _localctx = new KeywordContext(_ctx, State);
		EnterRule(_localctx, 226, RULE_keyword);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2012;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AFTER) | (1L << ALIAS) | (1L << ALL) | (1L << ALTER) | (1L << AND) | (1L << ANTI) | (1L << ANY) | (1L << ARRAY) | (1L << AS) | (1L << ASCENDING) | (1L << ASOF) | (1L << AST) | (1L << ASYNC) | (1L << ATTACH) | (1L << BETWEEN) | (1L << BOTH) | (1L << BY) | (1L << CASE) | (1L << CAST) | (1L << CHECK) | (1L << CLEAR) | (1L << CLUSTER) | (1L << CODEC) | (1L << COLLATE) | (1L << COLUMN) | (1L << COMMENT) | (1L << CONSTRAINT) | (1L << CREATE) | (1L << CROSS) | (1L << CUBE) | (1L << CURRENT) | (1L << DATABASE) | (1L << DATABASES) | (1L << DATE) | (1L << DEDUPLICATE) | (1L << DEFAULT) | (1L << DELAY) | (1L << DELETE) | (1L << DESC) | (1L << DESCENDING) | (1L << DESCRIBE) | (1L << DETACH) | (1L << DICTIONARIES) | (1L << DICTIONARY) | (1L << DISK) | (1L << DISTINCT) | (1L << DISTRIBUTED) | (1L << DROP) | (1L << ELSE) | (1L << END) | (1L << ENGINE) | (1L << EVENTS) | (1L << EXISTS) | (1L << EXPLAIN) | (1L << EXPRESSION) | (1L << EXTRACT) | (1L << FETCHES) | (1L << FINAL) | (1L << FIRST) | (1L << FLUSH) | (1L << FOLLOWING))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (FOR - 64)) | (1L << (FORMAT - 64)) | (1L << (FREEZE - 64)) | (1L << (FROM - 64)) | (1L << (FULL - 64)) | (1L << (FUNCTION - 64)) | (1L << (GLOBAL - 64)) | (1L << (GRANULARITY - 64)) | (1L << (GROUP - 64)) | (1L << (HAVING - 64)) | (1L << (HIERARCHICAL - 64)) | (1L << (ID - 64)) | (1L << (IF - 64)) | (1L << (ILIKE - 64)) | (1L << (IN - 64)) | (1L << (INDEX - 64)) | (1L << (INJECTIVE - 64)) | (1L << (INNER - 64)) | (1L << (INSERT - 64)) | (1L << (INTERVAL - 64)) | (1L << (INTO - 64)) | (1L << (IS - 64)) | (1L << (IS_OBJECT_ID - 64)) | (1L << (JOIN - 64)) | (1L << (KEY - 64)) | (1L << (KILL - 64)) | (1L << (LAST - 64)) | (1L << (LAYOUT - 64)) | (1L << (LEADING - 64)) | (1L << (LEFT - 64)) | (1L << (LIFETIME - 64)) | (1L << (LIKE - 64)) | (1L << (LIMIT - 64)) | (1L << (LIVE - 64)) | (1L << (LOCAL - 64)) | (1L << (LOGS - 64)) | (1L << (MATERIALIZE - 64)) | (1L << (MATERIALIZED - 64)) | (1L << (MAX - 64)) | (1L << (MERGES - 64)) | (1L << (MIN - 64)) | (1L << (MODIFY - 64)) | (1L << (MOVE - 64)) | (1L << (MUTATION - 64)) | (1L << (NO - 64)) | (1L << (NOT - 64)) | (1L << (NULLS - 64)) | (1L << (OFFSET - 64)) | (1L << (ON - 64)) | (1L << (OPTIMIZE - 64)) | (1L << (OR - 64)) | (1L << (ORDER - 64)) | (1L << (OUTER - 64)) | (1L << (OUTFILE - 64)) | (1L << (OVER - 64)) | (1L << (PARTITION - 64)) | (1L << (POPULATE - 64)) | (1L << (PRECEDING - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (PREWHERE - 128)) | (1L << (PRIMARY - 128)) | (1L << (RANGE - 128)) | (1L << (RELOAD - 128)) | (1L << (REMOVE - 128)) | (1L << (RENAME - 128)) | (1L << (REPLACE - 128)) | (1L << (REPLICA - 128)) | (1L << (REPLICATED - 128)) | (1L << (RIGHT - 128)) | (1L << (ROLLUP - 128)) | (1L << (ROW - 128)) | (1L << (ROWS - 128)) | (1L << (SAMPLE - 128)) | (1L << (SELECT - 128)) | (1L << (SEMI - 128)) | (1L << (SENDS - 128)) | (1L << (SET - 128)) | (1L << (SETTINGS - 128)) | (1L << (SHOW - 128)) | (1L << (SOURCE - 128)) | (1L << (START - 128)) | (1L << (STOP - 128)) | (1L << (SUBSTRING - 128)) | (1L << (SYNC - 128)) | (1L << (SYNTAX - 128)) | (1L << (SYSTEM - 128)) | (1L << (TABLE - 128)) | (1L << (TABLES - 128)) | (1L << (TEMPORARY - 128)) | (1L << (TEST - 128)) | (1L << (THEN - 128)) | (1L << (TIES - 128)) | (1L << (TIMEOUT - 128)) | (1L << (TIMESTAMP - 128)) | (1L << (TO - 128)) | (1L << (TOP - 128)) | (1L << (TOTALS - 128)) | (1L << (TRAILING - 128)) | (1L << (TRIM - 128)) | (1L << (TRUNCATE - 128)) | (1L << (TTL - 128)) | (1L << (TYPE - 128)) | (1L << (UNBOUNDED - 128)) | (1L << (UNION - 128)) | (1L << (UPDATE - 128)) | (1L << (USE - 128)) | (1L << (USING - 128)) | (1L << (UUID - 128)) | (1L << (VALUES - 128)) | (1L << (VIEW - 128)) | (1L << (VOLUME - 128)) | (1L << (WATCH - 128)) | (1L << (WHEN - 128)) | (1L << (WHERE - 128)) | (1L << (WINDOW - 128)) | (1L << (WITH - 128)) | (1L << (JSON_FALSE - 128)) | (1L << (JSON_TRUE - 128)))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KeywordForAliasContext : ParserRuleContext {
		public ITerminalNode DATE() { return GetToken(ClickHouseParser.DATE, 0); }
		public ITerminalNode FIRST() { return GetToken(ClickHouseParser.FIRST, 0); }
		public ITerminalNode ID() { return GetToken(ClickHouseParser.ID, 0); }
		public ITerminalNode KEY() { return GetToken(ClickHouseParser.KEY, 0); }
		public KeywordForAliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keywordForAlias; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterKeywordForAlias(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitKeywordForAlias(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitKeywordForAlias(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public KeywordForAliasContext keywordForAlias() {
		KeywordForAliasContext _localctx = new KeywordForAliasContext(_ctx, State);
		EnterRule(_localctx, 228, RULE_keywordForAlias);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2014;
			_la = _input.La(1);
			if ( !(((((_la - 35)) & ~0x3f) == 0 && ((1L << (_la - 35)) & ((1L << (DATE - 35)) | (1L << (FIRST - 35)) | (1L << (ID - 35)) | (1L << (KEY - 35)))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AliasContext : ParserRuleContext {
		public ITerminalNode IDENTIFIER() { return GetToken(ClickHouseParser.IDENTIFIER, 0); }
		public KeywordForAliasContext keywordForAlias() {
			return GetRuleContext<KeywordForAliasContext>(0);
		}
		public AliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alias; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterAlias(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitAlias(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAlias(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AliasContext alias() {
		AliasContext _localctx = new AliasContext(_ctx, State);
		EnterRule(_localctx, 230, RULE_alias);
		try {
			State = 2018;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2016; Match(IDENTIFIER);
				}
				break;
			case DATE:
			case FIRST:
			case ID:
			case KEY:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2017; keywordForAlias();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierContext : ParserRuleContext {
		public ITerminalNode IDENTIFIER() { return GetToken(ClickHouseParser.IDENTIFIER, 0); }
		public IntervalContext interval() {
			return GetRuleContext<IntervalContext>(0);
		}
		public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		public IdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitIdentifier(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifier(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierContext identifier() {
		IdentifierContext _localctx = new IdentifierContext(_ctx, State);
		EnterRule(_localctx, 232, RULE_identifier);
		try {
			State = 2023;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2020; Match(IDENTIFIER);
				}
				break;
			case DAY:
			case HOUR:
			case MINUTE:
			case MONTH:
			case QUARTER:
			case SECOND:
			case WEEK:
			case YEAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2021; interval();
				}
				break;
			case AFTER:
			case ALIAS:
			case ALL:
			case ALTER:
			case AND:
			case ANTI:
			case ANY:
			case ARRAY:
			case AS:
			case ASCENDING:
			case ASOF:
			case AST:
			case ASYNC:
			case ATTACH:
			case BETWEEN:
			case BOTH:
			case BY:
			case CASE:
			case CAST:
			case CHECK:
			case CLEAR:
			case CLUSTER:
			case CODEC:
			case COLLATE:
			case COLUMN:
			case COMMENT:
			case CONSTRAINT:
			case CREATE:
			case CROSS:
			case CUBE:
			case CURRENT:
			case DATABASE:
			case DATABASES:
			case DATE:
			case DEDUPLICATE:
			case DEFAULT:
			case DELAY:
			case DELETE:
			case DESC:
			case DESCENDING:
			case DESCRIBE:
			case DETACH:
			case DICTIONARIES:
			case DICTIONARY:
			case DISK:
			case DISTINCT:
			case DISTRIBUTED:
			case DROP:
			case ELSE:
			case END:
			case ENGINE:
			case EVENTS:
			case EXISTS:
			case EXPLAIN:
			case EXPRESSION:
			case EXTRACT:
			case FETCHES:
			case FINAL:
			case FIRST:
			case FLUSH:
			case FOLLOWING:
			case FOR:
			case FORMAT:
			case FREEZE:
			case FROM:
			case FULL:
			case FUNCTION:
			case GLOBAL:
			case GRANULARITY:
			case GROUP:
			case HAVING:
			case HIERARCHICAL:
			case ID:
			case IF:
			case ILIKE:
			case IN:
			case INDEX:
			case INJECTIVE:
			case INNER:
			case INSERT:
			case INTERVAL:
			case INTO:
			case IS:
			case IS_OBJECT_ID:
			case JOIN:
			case KEY:
			case KILL:
			case LAST:
			case LAYOUT:
			case LEADING:
			case LEFT:
			case LIFETIME:
			case LIKE:
			case LIMIT:
			case LIVE:
			case LOCAL:
			case LOGS:
			case MATERIALIZE:
			case MATERIALIZED:
			case MAX:
			case MERGES:
			case MIN:
			case MODIFY:
			case MOVE:
			case MUTATION:
			case NO:
			case NOT:
			case NULLS:
			case OFFSET:
			case ON:
			case OPTIMIZE:
			case OR:
			case ORDER:
			case OUTER:
			case OUTFILE:
			case OVER:
			case PARTITION:
			case POPULATE:
			case PRECEDING:
			case PREWHERE:
			case PRIMARY:
			case RANGE:
			case RELOAD:
			case REMOVE:
			case RENAME:
			case REPLACE:
			case REPLICA:
			case REPLICATED:
			case RIGHT:
			case ROLLUP:
			case ROW:
			case ROWS:
			case SAMPLE:
			case SELECT:
			case SEMI:
			case SENDS:
			case SET:
			case SETTINGS:
			case SHOW:
			case SOURCE:
			case START:
			case STOP:
			case SUBSTRING:
			case SYNC:
			case SYNTAX:
			case SYSTEM:
			case TABLE:
			case TABLES:
			case TEMPORARY:
			case TEST:
			case THEN:
			case TIES:
			case TIMEOUT:
			case TIMESTAMP:
			case TO:
			case TOP:
			case TOTALS:
			case TRAILING:
			case TRIM:
			case TRUNCATE:
			case TTL:
			case TYPE:
			case UNBOUNDED:
			case UNION:
			case UPDATE:
			case USE:
			case USING:
			case UUID:
			case VALUES:
			case VIEW:
			case VOLUME:
			case WATCH:
			case WHEN:
			case WHERE:
			case WINDOW:
			case WITH:
			case JSON_FALSE:
			case JSON_TRUE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2022; keyword();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierOrNullContext : ParserRuleContext {
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public ITerminalNode NULL_SQL() { return GetToken(ClickHouseParser.NULL_SQL, 0); }
		public IdentifierOrNullContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifierOrNull; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterIdentifierOrNull(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitIdentifierOrNull(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierOrNull(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierOrNullContext identifierOrNull() {
		IdentifierOrNullContext _localctx = new IdentifierOrNullContext(_ctx, State);
		EnterRule(_localctx, 234, RULE_identifierOrNull);
		try {
			State = 2027;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case AFTER:
			case ALIAS:
			case ALL:
			case ALTER:
			case AND:
			case ANTI:
			case ANY:
			case ARRAY:
			case AS:
			case ASCENDING:
			case ASOF:
			case AST:
			case ASYNC:
			case ATTACH:
			case BETWEEN:
			case BOTH:
			case BY:
			case CASE:
			case CAST:
			case CHECK:
			case CLEAR:
			case CLUSTER:
			case CODEC:
			case COLLATE:
			case COLUMN:
			case COMMENT:
			case CONSTRAINT:
			case CREATE:
			case CROSS:
			case CUBE:
			case CURRENT:
			case DATABASE:
			case DATABASES:
			case DATE:
			case DAY:
			case DEDUPLICATE:
			case DEFAULT:
			case DELAY:
			case DELETE:
			case DESC:
			case DESCENDING:
			case DESCRIBE:
			case DETACH:
			case DICTIONARIES:
			case DICTIONARY:
			case DISK:
			case DISTINCT:
			case DISTRIBUTED:
			case DROP:
			case ELSE:
			case END:
			case ENGINE:
			case EVENTS:
			case EXISTS:
			case EXPLAIN:
			case EXPRESSION:
			case EXTRACT:
			case FETCHES:
			case FINAL:
			case FIRST:
			case FLUSH:
			case FOLLOWING:
			case FOR:
			case FORMAT:
			case FREEZE:
			case FROM:
			case FULL:
			case FUNCTION:
			case GLOBAL:
			case GRANULARITY:
			case GROUP:
			case HAVING:
			case HIERARCHICAL:
			case HOUR:
			case ID:
			case IF:
			case ILIKE:
			case IN:
			case INDEX:
			case INJECTIVE:
			case INNER:
			case INSERT:
			case INTERVAL:
			case INTO:
			case IS:
			case IS_OBJECT_ID:
			case JOIN:
			case KEY:
			case KILL:
			case LAST:
			case LAYOUT:
			case LEADING:
			case LEFT:
			case LIFETIME:
			case LIKE:
			case LIMIT:
			case LIVE:
			case LOCAL:
			case LOGS:
			case MATERIALIZE:
			case MATERIALIZED:
			case MAX:
			case MERGES:
			case MIN:
			case MINUTE:
			case MODIFY:
			case MONTH:
			case MOVE:
			case MUTATION:
			case NO:
			case NOT:
			case NULLS:
			case OFFSET:
			case ON:
			case OPTIMIZE:
			case OR:
			case ORDER:
			case OUTER:
			case OUTFILE:
			case OVER:
			case PARTITION:
			case POPULATE:
			case PRECEDING:
			case PREWHERE:
			case PRIMARY:
			case QUARTER:
			case RANGE:
			case RELOAD:
			case REMOVE:
			case RENAME:
			case REPLACE:
			case REPLICA:
			case REPLICATED:
			case RIGHT:
			case ROLLUP:
			case ROW:
			case ROWS:
			case SAMPLE:
			case SECOND:
			case SELECT:
			case SEMI:
			case SENDS:
			case SET:
			case SETTINGS:
			case SHOW:
			case SOURCE:
			case START:
			case STOP:
			case SUBSTRING:
			case SYNC:
			case SYNTAX:
			case SYSTEM:
			case TABLE:
			case TABLES:
			case TEMPORARY:
			case TEST:
			case THEN:
			case TIES:
			case TIMEOUT:
			case TIMESTAMP:
			case TO:
			case TOP:
			case TOTALS:
			case TRAILING:
			case TRIM:
			case TRUNCATE:
			case TTL:
			case TYPE:
			case UNBOUNDED:
			case UNION:
			case UPDATE:
			case USE:
			case USING:
			case UUID:
			case VALUES:
			case VIEW:
			case VOLUME:
			case WATCH:
			case WEEK:
			case WHEN:
			case WHERE:
			case WINDOW:
			case WITH:
			case YEAR:
			case JSON_FALSE:
			case JSON_TRUE:
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2025; identifier();
				}
				break;
			case NULL_SQL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2026; Match(NULL_SQL);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumValueContext : ParserRuleContext {
		public ITerminalNode STRING_LITERAL() { return GetToken(ClickHouseParser.STRING_LITERAL, 0); }
		public ITerminalNode EQ_SINGLE() { return GetToken(ClickHouseParser.EQ_SINGLE, 0); }
		public NumberLiteralContext numberLiteral() {
			return GetRuleContext<NumberLiteralContext>(0);
		}
		public EnumValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumValue; } }
		public override void EnterRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.EnterEnumValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IClickHouseParserListener typedListener = listener as IClickHouseParserListener;
			if (typedListener != null) typedListener.ExitEnumValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IClickHouseParserVisitor<TResult> typedVisitor = visitor as IClickHouseParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEnumValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EnumValueContext enumValue() {
		EnumValueContext _localctx = new EnumValueContext(_ctx, State);
		EnterRule(_localctx, 236, RULE_enumValue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2029; Match(STRING_LITERAL);
			State = 2030; Match(EQ_SINGLE);
			State = 2031; numberLiteral();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 13: return dictionaryAttrDfnt_sempred((DictionaryAttrDfntContext)_localctx, predIndex);

		case 14: return dictionaryEngineClause_sempred((DictionaryEngineClauseContext)_localctx, predIndex);

		case 27: return engineClause_sempred((EngineClauseContext)_localctx, predIndex);

		case 71: return joinExpr_sempred((JoinExprContext)_localctx, predIndex);

		case 97: return columnExpr_sempred((ColumnExprContext)_localctx, predIndex);

		case 103: return tableExpr_sempred((TableExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool dictionaryAttrDfnt_sempred(DictionaryAttrDfntContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return !_localctx.attrs.count("default");

		case 1: return !_localctx.attrs.count("expression");

		case 2: return !_localctx.attrs.count("hierarchical");

		case 3: return !_localctx.attrs.count("injective");

		case 4: return !_localctx.attrs.count("is_object_id");
		}
		return true;
	}
	private bool dictionaryEngineClause_sempred(DictionaryEngineClauseContext _localctx, int predIndex) {
		switch (predIndex) {
		case 5: return !_localctx.clauses.count("source");

		case 6: return !_localctx.clauses.count("lifetime");

		case 7: return !_localctx.clauses.count("layout");

		case 8: return !_localctx.clauses.count("range");

		case 9: return !_localctx.clauses.count("settings");
		}
		return true;
	}
	private bool engineClause_sempred(EngineClauseContext _localctx, int predIndex) {
		switch (predIndex) {
		case 10: return !_localctx.clauses.count("orderByClause");

		case 11: return !_localctx.clauses.count("partitionByClause");

		case 12: return !_localctx.clauses.count("primaryKeyClause");

		case 13: return !_localctx.clauses.count("sampleByClause");

		case 14: return !_localctx.clauses.count("ttlClause");

		case 15: return !_localctx.clauses.count("settingsClause");
		}
		return true;
	}
	private bool joinExpr_sempred(JoinExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 16: return Precpred(_ctx, 3);

		case 17: return Precpred(_ctx, 4);
		}
		return true;
	}
	private bool columnExpr_sempred(ColumnExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 18: return Precpred(_ctx, 16);

		case 19: return Precpred(_ctx, 15);

		case 20: return Precpred(_ctx, 14);

		case 21: return Precpred(_ctx, 11);

		case 22: return Precpred(_ctx, 10);

		case 23: return Precpred(_ctx, 9);

		case 24: return Precpred(_ctx, 8);

		case 25: return Precpred(_ctx, 19);

		case 26: return Precpred(_ctx, 18);

		case 27: return Precpred(_ctx, 13);

		case 28: return Precpred(_ctx, 7);
		}
		return true;
	}
	private bool tableExpr_sempred(TableExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 29: return Precpred(_ctx, 1);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\xE8\x7F4\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x4"+
		"@\t@\x4\x41\t\x41\x4\x42\t\x42\x4\x43\t\x43\x4\x44\t\x44\x4\x45\t\x45"+
		"\x4\x46\t\x46\x4G\tG\x4H\tH\x4I\tI\x4J\tJ\x4K\tK\x4L\tL\x4M\tM\x4N\tN"+
		"\x4O\tO\x4P\tP\x4Q\tQ\x4R\tR\x4S\tS\x4T\tT\x4U\tU\x4V\tV\x4W\tW\x4X\t"+
		"X\x4Y\tY\x4Z\tZ\x4[\t[\x4\\\t\\\x4]\t]\x4^\t^\x4_\t_\x4`\t`\x4\x61\t\x61"+
		"\x4\x62\t\x62\x4\x63\t\x63\x4\x64\t\x64\x4\x65\t\x65\x4\x66\t\x66\x4g"+
		"\tg\x4h\th\x4i\ti\x4j\tj\x4k\tk\x4l\tl\x4m\tm\x4n\tn\x4o\to\x4p\tp\x4"+
		"q\tq\x4r\tr\x4s\ts\x4t\tt\x4u\tu\x4v\tv\x4w\tw\x4x\tx\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x5\x2\xF5\n\x2\x3\x2\x3\x2\x5\x2\xF9\n\x2\x3\x2\x5\x2\xFC\n\x2"+
		"\x3\x2\x5\x2\xFF\n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\x113"+
		"\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x119\n\x4\x3\x4\x3\x4\x3\x4\a\x4\x11E"+
		"\n\x4\f\x4\xE\x4\x121\v\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x128\n"+
		"\x5\x3\x5\x3\x5\x5\x5\x12C\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x133"+
		"\n\x5\x3\x5\x3\x5\x3\x5\x5\x5\x138\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x5\x5\x13F\n\x5\x3\x5\x3\x5\x3\x5\x5\x5\x144\n\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x5\x5\x14A\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x150\n\x5\x3\x5\x3\x5"+
		"\x3\x5\x5\x5\x155\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x15B\n\x5\x3\x5\x3"+
		"\x5\x3\x5\x5\x5\x160\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x166\n\x5\x3\x5"+
		"\x3\x5\x3\x5\x5\x5\x16B\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x171\n\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x5\x5\x17F\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x186\n\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x5\x5\x18D\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5"+
		"\x5\x194\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x19A\n\x5\x3\x5\x3\x5\x3\x5"+
		"\x5\x5\x19F\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x1A5\n\x5\x3\x5\x3\x5\x3"+
		"\x5\x5\x5\x1AA\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x1B0\n\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x1B9\n\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x5\x5\x1C2\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x5\x5\x1CC\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5"+
		"\x5\x1E0\n\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x1E8\n\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x5\x5\x1F7\n\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\a\a\x1FF\n\a\f\a"+
		"\xE\a\x202\v\a\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n"+
		"\x5\n\x20F\n\n\x3\v\x3\v\x3\v\x3\v\x5\v\x215\n\v\x3\f\x3\f\x3\f\x3\f\x5"+
		"\f\x21B\n\f\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\x222\n\r\x3\r\x3\r\x5\r\x226"+
		"\n\r\x3\r\x5\r\x229\n\r\x3\r\x3\r\x3\r\x3\r\x5\r\x22F\n\r\x3\r\x5\r\x232"+
		"\n\r\x3\r\x3\r\x3\r\x3\r\x5\r\x238\n\r\x3\r\x3\r\x5\r\x23C\n\r\x3\r\x5"+
		"\r\x23F\n\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\x24A\n\r"+
		"\x3\r\x3\r\x5\r\x24E\n\r\x3\r\x5\r\x251\n\r\x3\r\x3\r\x3\r\x5\r\x256\n"+
		"\r\x5\r\x258\n\r\x3\r\x5\r\x25B\n\r\x3\r\x5\r\x25E\n\r\x3\r\x3\r\x3\r"+
		"\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\x268\n\r\x3\r\x3\r\x5\r\x26C\n\r\x3\r\x5"+
		"\r\x26F\n\r\x3\r\x5\r\x272\n\r\x3\r\x3\r\x3\r\x5\r\x277\n\r\x5\r\x279"+
		"\n\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\x281\n\r\x3\r\x5\r\x284\n\r\x3"+
		"\r\x5\r\x287\n\r\x3\r\x3\r\x3\r\x3\r\x5\r\x28D\n\r\x3\r\x3\r\x5\r\x291"+
		"\n\r\x3\r\x5\r\x294\n\r\x3\r\x5\r\x297\n\r\x3\r\x5\r\x29A\n\r\x3\r\x5"+
		"\r\x29D\n\r\x3\r\x5\r\x2A0\n\r\x3\r\x3\r\x3\r\x5\r\x2A5\n\r\x3\r\x3\r"+
		"\x3\r\x3\r\x5\r\x2AB\n\r\x3\r\x3\r\x5\r\x2AF\n\r\x3\r\x5\r\x2B2\n\r\x3"+
		"\r\x5\r\x2B5\n\r\x3\r\x3\r\x5\r\x2B9\n\r\x3\xE\x3\xE\x3\xE\x3\xE\a\xE"+
		"\x2BF\n\xE\f\xE\xE\xE\x2C2\v\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3"+
		"\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF"+
		"\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\a\xF\x2DB\n\xF\f\xF\xE\xF\x2DE\v\xF\x3"+
		"\x10\x5\x10\x2E1\n\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\a\x10\x2F7\n\x10\f\x10\xE\x10\x2FA\v\x10\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x5\x12\x304\n\x12\x3"+
		"\x12\x5\x12\x307\n\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\a\x13\x30E\n"+
		"\x13\f\x13\xE\x13\x311\v\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x5\x14\x321\n"+
		"\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\a\x15\x32A\n\x15"+
		"\f\x15\xE\x15\x32D\v\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3"+
		"\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x5\x16\x33E"+
		"\n\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18"+
		"\x3\x18\x3\x18\x5\x18\x34B\n\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\a\x1C\x35A\n\x1C"+
		"\f\x1C\xE\x1C\x35D\v\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x5"+
		"\x1C\x365\n\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\a\x1D\x380\n\x1D\f\x1D"+
		"\xE\x1D\x383\v\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3"+
		" \x3 \x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\a#\x39B\n#\f"+
		"#\xE#\x39E\v#\x3$\x3$\x5$\x3A2\n$\x3$\x3$\x3$\x5$\x3A7\n$\x3$\x5$\x3AA"+
		"\n$\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x5%\x3B6\n%\x3&\x3&\x3&\x5"+
		"&\x3BB\n&\x3&\x5&\x3BE\n&\x3&\x5&\x3C1\n&\x3&\x3&\x5&\x3C5\n&\x3&\x3&"+
		"\x5&\x3C9\n&\x3&\x3&\x5&\x3CD\n&\x3&\x5&\x3D0\n&\x3&\x3&\x5&\x3D4\n&\x5"+
		"&\x3D6\n&\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3)\x3)\x3)\x3*\x3"+
		"*\x3*\x3*\x3*\a*\x3EA\n*\f*\xE*\x3ED\v*\x3*\x3*\x3+\x3+\x3+\x5+\x3F4\n"+
		"+\x3+\x5+\x3F7\n+\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x5,\x401\n,\x3-\x3-"+
		"\x5-\x405\n-\x3-\x3-\x3.\x3.\x3.\x3.\x5.\x40D\n.\x3.\x3.\x5.\x411\n.\x3"+
		".\x3.\x3.\x5.\x416\n.\x3.\x3.\x5.\x41A\n.\x3.\x3.\x5.\x41E\n.\x3.\x3."+
		"\x5.\x422\n.\x3.\x3.\x5.\x426\n.\x5.\x428\n.\x3/\x3/\x3/\x3/\x3/\x3/\x5"+
		"/\x430\n/\x3/\x3/\x5/\x434\n/\x3/\x5/\x437\n/\x3\x30\x3\x30\x3\x30\x3"+
		"\x30\x3\x30\x3\x30\x5\x30\x43F\n\x30\x3\x31\x3\x31\x3\x31\x5\x31\x444"+
		"\n\x31\x3\x31\x3\x31\x3\x31\x5\x31\x449\n\x31\x3\x31\x5\x31\x44C\n\x31"+
		"\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32\x3\x32\a\x32\x454\n\x32\f\x32\xE\x32"+
		"\x457\v\x32\x3\x32\x3\x32\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x5\x33\x460"+
		"\n\x33\x3\x33\x3\x33\x5\x33\x464\n\x33\x3\x34\x3\x34\x3\x34\x5\x34\x469"+
		"\n\x34\x3\x34\x3\x34\x5\x34\x46D\n\x34\x3\x35\x3\x35\x3\x35\x3\x35\x5"+
		"\x35\x473\n\x35\x3\x35\x5\x35\x476\n\x35\x3\x35\x5\x35\x479\n\x35\x3\x35"+
		"\x5\x35\x47C\n\x35\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36\x3"+
		"\x36\x3\x36\x3\x36\a\x36\x488\n\x36\f\x36\xE\x36\x48B\v\x36\x3\x36\x5"+
		"\x36\x48E\n\x36\x3\x37\x3\x37\x5\x37\x492\n\x37\x3\x37\x3\x37\x3\x37\x5"+
		"\x37\x497\n\x37\x3\x37\x5\x37\x49A\n\x37\x3\x37\x3\x37\x3\x38\x3\x38\x3"+
		"\x38\x3\x38\a\x38\x4A2\n\x38\f\x38\xE\x38\x4A5\v\x38\x3\x39\x3\x39\x3"+
		"\x39\x3\x39\x3\x39\x5\x39\x4AC\n\x39\x3:\x5:\x4AF\n:\x3:\x3:\x5:\x4B3"+
		"\n:\x3:\x5:\x4B6\n:\x3:\x3:\x5:\x4BA\n:\x3:\x5:\x4BD\n:\x3:\x5:\x4C0\n"+
		":\x3:\x5:\x4C3\n:\x3:\x5:\x4C6\n:\x3:\x5:\x4C9\n:\x3:\x3:\x5:\x4CD\n:"+
		"\x3:\x3:\x5:\x4D1\n:\x3:\x5:\x4D4\n:\x3:\x5:\x4D7\n:\x3:\x5:\x4DA\n:\x3"+
		":\x5:\x4DD\n:\x3:\x5:\x4E0\n:\x3;\x3;\x3;\x3<\x3<\x3<\x3<\x5<\x4E9\n<"+
		"\x3=\x3=\x3=\x3>\x5>\x4EF\n>\x3>\x3>\x3>\x3>\x3?\x3?\x3?\x3?\x3?\x3?\x3"+
		"?\x3@\x3@\x3@\x3\x41\x3\x41\x3\x41\x3\x42\x3\x42\x3\x42\x3\x42\x3\x42"+
		"\x3\x42\x3\x42\x3\x42\x5\x42\x50A\n\x42\x3\x43\x3\x43\x3\x43\x3\x44\x3"+
		"\x44\x3\x44\x3\x44\x3\x45\x3\x45\x3\x45\x3\x45\x3\x46\x3\x46\x3\x46\x3"+
		"\x46\x3\x46\x3G\x3G\x3G\x3G\x5G\x520\nG\x3H\x3H\x3H\x3I\x3I\x3I\x5I\x528"+
		"\nI\x3I\x5I\x52B\nI\x3I\x3I\x3I\x3I\x5I\x531\nI\x3I\x3I\x3I\x3I\x3I\x3"+
		"I\x5I\x539\nI\x3I\x5I\x53C\nI\x3I\x3I\x3I\x3I\aI\x542\nI\fI\xEI\x545\v"+
		"I\x3J\x5J\x548\nJ\x3J\x3J\x3J\x5J\x54D\nJ\x3J\x5J\x550\nJ\x3J\x5J\x553"+
		"\nJ\x3J\x3J\x5J\x557\nJ\x3J\x3J\x5J\x55B\nJ\x3J\x5J\x55E\nJ\x5J\x560\n"+
		"J\x3J\x5J\x563\nJ\x3J\x3J\x5J\x567\nJ\x3J\x3J\x5J\x56B\nJ\x3J\x5J\x56E"+
		"\nJ\x5J\x570\nJ\x5J\x572\nJ\x3K\x5K\x575\nK\x3K\x3K\x3K\x5K\x57A\nK\x3"+
		"L\x3L\x3L\x3L\x3L\x3L\x3L\x3L\x3L\x5L\x585\nL\x3M\x3M\x3M\x3M\x5M\x58B"+
		"\nM\x3N\x3N\x3N\x5N\x590\nN\x3O\x3O\x3O\aO\x595\nO\fO\xEO\x598\vO\x3P"+
		"\x3P\x5P\x59C\nP\x3P\x3P\x5P\x5A0\nP\x3P\x3P\x5P\x5A4\nP\x3Q\x3Q\x3Q\x5"+
		"Q\x5A9\nQ\x3R\x3R\x3R\aR\x5AE\nR\fR\xER\x5B1\vR\x3S\x3S\x3S\x3S\x3T\x5"+
		"T\x5B8\nT\x3T\x5T\x5BB\nT\x3T\x5T\x5BE\nT\x3U\x3U\x3U\x3U\x3V\x3V\x3V"+
		"\x3V\x3W\x3W\x3W\x3X\x3X\x3X\x3X\x3X\x3X\x5X\x5D1\nX\x3Y\x3Y\x3Y\x3Y\x3"+
		"Y\x3Y\x3Y\x3Y\x3Y\x3Y\x3Y\x3Y\x5Y\x5DF\nY\x3Z\x3Z\x3Z\x3[\x3[\x3[\x3["+
		"\x3[\x3[\x3[\x3[\x3[\x3[\x3[\x5[\x5EF\n[\x3[\x5[\x5F2\n[\x3[\x3[\x3[\x3"+
		"[\x3[\x3[\x3[\x5[\x5FB\n[\x3[\x3[\x5[\x5FF\n[\x3[\x3[\x3[\x5[\x604\n["+
		"\x3[\x3[\x3[\x5[\x609\n[\x3[\x5[\x60C\n[\x5[\x60E\n[\x3\\\x3\\\x3\\\x3"+
		"\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3\\\x3"+
		"\\\x3\\\x3\\\x5\\\x624\n\\\x3\\\x5\\\x627\n\\\x3\\\x3\\\x3\\\x3\\\x3\\"+
		"\x3\\\x3\\\x3\\\x3\\\x5\\\x632\n\\\x3]\x3]\x5]\x636\n]\x3]\x5]\x639\n"+
		"]\x3]\x3]\x5]\x63D\n]\x3]\x3]\x5]\x641\n]\x3^\x3^\x3^\x3_\x3_\x3_\x5_"+
		"\x649\n_\x3_\x3_\x5_\x64D\n_\x3`\x3`\x3`\x3`\x3`\x3`\x3`\x3`\x3`\a`\x658"+
		"\n`\f`\xE`\x65B\v`\x3`\x3`\x3`\x3`\x3`\x3`\x3`\a`\x664\n`\f`\xE`\x667"+
		"\v`\x3`\x3`\x3`\x3`\x3`\x3`\x3`\a`\x670\n`\f`\xE`\x673\v`\x3`\x3`\x3`"+
		"\x3`\x3`\x5`\x67A\n`\x3`\x3`\x5`\x67E\n`\x3\x61\x3\x61\x3\x61\a\x61\x683"+
		"\n\x61\f\x61\xE\x61\x686\v\x61\x3\x62\x3\x62\x3\x62\x5\x62\x68B\n\x62"+
		"\x3\x62\x3\x62\x3\x62\x3\x62\x3\x62\x3\x62\x5\x62\x693\n\x62\x3\x63\x3"+
		"\x63\x3\x63\x5\x63\x698\n\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x6\x63"+
		"\x69F\n\x63\r\x63\xE\x63\x6A0\x3\x63\x3\x63\x5\x63\x6A5\n\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x6C4\n\x63"+
		"\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63"+
		"\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x6D5\n\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x6E1\n\x63"+
		"\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x6EB\n"+
		"\x63\x3\x63\x5\x63\x6EE\n\x63\x3\x63\x3\x63\x5\x63\x6F2\n\x63\x3\x63\x5"+
		"\x63\x6F5\n\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63"+
		"\x3\x63\x3\x63\x5\x63\x701\n\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5"+
		"\x63\x712\n\x63\x3\x63\x3\x63\x5\x63\x716\n\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x5\x63\x727\n\x63\x3\x63\x5\x63\x72A\n\x63\x3\x63\x3\x63\x5"+
		"\x63\x72E\n\x63\x3\x63\x5\x63\x731\n\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3"+
		"\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x73C\n\x63\x3\x63\x3\x63\x3\x63"+
		"\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63"+
		"\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63"+
		"\x754\n\x63\x3\x63\x3\x63\x3\x63\x3\x63\x3\x63\x5\x63\x75B\n\x63\a\x63"+
		"\x75D\n\x63\f\x63\xE\x63\x760\v\x63\x3\x64\x3\x64\x3\x64\a\x64\x765\n"+
		"\x64\f\x64\xE\x64\x768\v\x64\x3\x65\x3\x65\x5\x65\x76C\n\x65\x3\x66\x3"+
		"\x66\x3\x66\x3\x66\a\x66\x772\n\x66\f\x66\xE\x66\x775\v\x66\x3\x66\x3"+
		"\x66\x3\x66\x3\x66\x3\x66\a\x66\x77C\n\x66\f\x66\xE\x66\x77F\v\x66\x5"+
		"\x66\x781\n\x66\x3\x66\x3\x66\x3\x66\x3g\x3g\x3g\x5g\x789\ng\x3g\x3g\x3"+
		"h\x3h\x3h\x5h\x790\nh\x3i\x3i\x3i\x3i\x3i\x3i\x3i\x5i\x799\ni\x3i\x3i"+
		"\x3i\x3i\x5i\x79F\ni\ai\x7A1\ni\fi\xEi\x7A4\vi\x3j\x3j\x3j\x5j\x7A9\n"+
		"j\x3j\x3j\x3k\x3k\x3k\x5k\x7B0\nk\x3k\x3k\x3l\x3l\x3l\al\x7B7\nl\fl\xE"+
		"l\x7BA\vl\x3m\x3m\x3m\x5m\x7BF\nm\x3n\x3n\x3o\x3o\x3o\x3o\x3o\x3o\x5o"+
		"\x7C9\no\x5o\x7CB\no\x3p\x5p\x7CE\np\x3p\x3p\x3p\x3p\x3p\x3p\x5p\x7D6"+
		"\np\x3q\x3q\x3q\x5q\x7DB\nq\x3r\x3r\x3s\x3s\x3t\x3t\x3u\x3u\x5u\x7E5\n"+
		"u\x3v\x3v\x3v\x5v\x7EA\nv\x3w\x3w\x5w\x7EE\nw\x3x\x3x\x3x\x3x\x3x\x2\x2"+
		"\x5\x90\xC4\xD0y\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2"+
		"\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2\x1E\x2 \x2\"\x2$\x2&\x2(\x2*\x2,\x2"+
		".\x2\x30\x2\x32\x2\x34\x2\x36\x2\x38\x2:\x2<\x2>\x2@\x2\x42\x2\x44\x2"+
		"\x46\x2H\x2J\x2L\x2N\x2P\x2R\x2T\x2V\x2X\x2Z\x2\\\x2^\x2`\x2\x62\x2\x64"+
		"\x2\x66\x2h\x2j\x2l\x2n\x2p\x2r\x2t\x2v\x2x\x2z\x2|\x2~\x2\x80\x2\x82"+
		"\x2\x84\x2\x86\x2\x88\x2\x8A\x2\x8C\x2\x8E\x2\x90\x2\x92\x2\x94\x2\x96"+
		"\x2\x98\x2\x9A\x2\x9C\x2\x9E\x2\xA0\x2\xA2\x2\xA4\x2\xA6\x2\xA8\x2\xAA"+
		"\x2\xAC\x2\xAE\x2\xB0\x2\xB2\x2\xB4\x2\xB6\x2\xB8\x2\xBA\x2\xBC\x2\xBE"+
		"\x2\xC0\x2\xC2\x2\xC4\x2\xC6\x2\xC8\x2\xCA\x2\xCC\x2\xCE\x2\xD0\x2\xD2"+
		"\x2\xD4\x2\xD6\x2\xD8\x2\xDA\x2\xDC\x2\xDE\x2\xE0\x2\xE2\x2\xE4\x2\xE6"+
		"\x2\xE8\x2\xEA\x2\xEC\x2\xEE\x2\x2\x1E\b\x2\x5\x5\x1A\x1A\x1D\x1D((ii"+
		"\xAE\xAE\x4\x2\x11\x11\x1F\x1F\x5\x2\x5\x5((ii\x4\x2++--\x4\x2..\x34\x34"+
		"\x5\x2\x10\x10\x9D\x9D\xA3\xA3\x4\x2!!\x8E\x8E\x4\x2UU\x61\x61\x4\x2H"+
		"H\x66\x66\x5\x2\x6\x6\n\n\xE\xE\x6\x2\x6\x6\t\n\xE\xE\x94\x94\x4\x2\x61"+
		"\x61\x8D\x8D\x4\x2\x6\x6\n\n\x4\x2ww\xCD\xCD\x4\x2\r\r+,\x4\x2??^^\x4"+
		"\x2\x86\x86\x90\x90\x4\x2\x45\x45QQ\x3\x2\x9A\x9B\x5\x2\x13\x13``\xAB"+
		"\xAB\x5\x2\xC9\xC9\xDB\xDB\xE4\xE4\x4\x2\xCE\xCF\xDC\xDC\x4\x2PP\x63\x63"+
		"\x3\x2\xC4\xC5\x4\x2\xCF\xCF\xDC\xDC\n\x2&&MMmmoo\x85\x85\x92\x92\xBA"+
		"\xBA\xBF\xBF\xE\x2\x4%\'LNRTlnnpqstv\x83\x86\x91\x93\xB9\xBB\xBE\xC0\xC1"+
		"\x6\x2%%??NN\\\\\x90F\x2\xFE\x3\x2\x2\x2\x4\x112\x3\x2\x2\x2\x6\x114\x3"+
		"\x2\x2\x2\b\x1F6\x3\x2\x2\x2\n\x1F8\x3\x2\x2\x2\f\x1FB\x3\x2\x2\x2\xE"+
		"\x203\x3\x2\x2\x2\x10\x207\x3\x2\x2\x2\x12\x20E\x3\x2\x2\x2\x14\x210\x3"+
		"\x2\x2\x2\x16\x216\x3\x2\x2\x2\x18\x2B8\x3\x2\x2\x2\x1A\x2BA\x3\x2\x2"+
		"\x2\x1C\x2C5\x3\x2\x2\x2\x1E\x2E0\x3\x2\x2\x2 \x2FB\x3\x2\x2\x2\"\x2FF"+
		"\x3\x2\x2\x2$\x308\x3\x2\x2\x2&\x315\x3\x2\x2\x2(\x324\x3\x2\x2\x2*\x331"+
		"\x3\x2\x2\x2,\x341\x3\x2\x2\x2.\x346\x3\x2\x2\x2\x30\x34C\x3\x2\x2\x2"+
		"\x32\x34F\x3\x2\x2\x2\x34\x352\x3\x2\x2\x2\x36\x364\x3\x2\x2\x2\x38\x366"+
		"\x3\x2\x2\x2:\x384\x3\x2\x2\x2<\x387\x3\x2\x2\x2>\x38A\x3\x2\x2\x2@\x38E"+
		"\x3\x2\x2\x2\x42\x392\x3\x2\x2\x2\x44\x396\x3\x2\x2\x2\x46\x39F\x3\x2"+
		"\x2\x2H\x3B5\x3\x2\x2\x2J\x3D5\x3\x2\x2\x2L\x3D7\x3\x2\x2\x2N\x3DA\x3"+
		"\x2\x2\x2P\x3E1\x3\x2\x2\x2R\x3E4\x3\x2\x2\x2T\x3F0\x3\x2\x2\x2V\x3F8"+
		"\x3\x2\x2\x2X\x402\x3\x2\x2\x2Z\x427\x3\x2\x2\x2\\\x436\x3\x2\x2\x2^\x43E"+
		"\x3\x2\x2\x2`\x440\x3\x2\x2\x2\x62\x44F\x3\x2\x2\x2\x64\x463\x3\x2\x2"+
		"\x2\x66\x465\x3\x2\x2\x2h\x46E\x3\x2\x2\x2j\x47D\x3\x2\x2\x2l\x48F\x3"+
		"\x2\x2\x2n\x49D\x3\x2\x2\x2p\x4AB\x3\x2\x2\x2r\x4AE\x3\x2\x2\x2t\x4E1"+
		"\x3\x2\x2\x2v\x4E4\x3\x2\x2\x2x\x4EA\x3\x2\x2\x2z\x4EE\x3\x2\x2\x2|\x4F4"+
		"\x3\x2\x2\x2~\x4FB\x3\x2\x2\x2\x80\x4FE\x3\x2\x2\x2\x82\x501\x3\x2\x2"+
		"\x2\x84\x50B\x3\x2\x2\x2\x86\x50E\x3\x2\x2\x2\x88\x512\x3\x2\x2\x2\x8A"+
		"\x516\x3\x2\x2\x2\x8C\x51B\x3\x2\x2\x2\x8E\x521\x3\x2\x2\x2\x90\x530\x3"+
		"\x2\x2\x2\x92\x571\x3\x2\x2\x2\x94\x579\x3\x2\x2\x2\x96\x584\x3\x2\x2"+
		"\x2\x98\x586\x3\x2\x2\x2\x9A\x58C\x3\x2\x2\x2\x9C\x591\x3\x2\x2\x2\x9E"+
		"\x599\x3\x2\x2\x2\xA0\x5A5\x3\x2\x2\x2\xA2\x5AA\x3\x2\x2\x2\xA4\x5B2\x3"+
		"\x2\x2\x2\xA6\x5B7\x3\x2\x2\x2\xA8\x5BF\x3\x2\x2\x2\xAA\x5C3\x3\x2\x2"+
		"\x2\xAC\x5C7\x3\x2\x2\x2\xAE\x5D0\x3\x2\x2\x2\xB0\x5DE\x3\x2\x2\x2\xB2"+
		"\x5E0\x3\x2\x2\x2\xB4\x60D\x3\x2\x2\x2\xB6\x631\x3\x2\x2\x2\xB8\x633\x3"+
		"\x2\x2\x2\xBA\x642\x3\x2\x2\x2\xBC\x645\x3\x2\x2\x2\xBE\x67D\x3\x2\x2"+
		"\x2\xC0\x67F\x3\x2\x2\x2\xC2\x692\x3\x2\x2\x2\xC4\x715\x3\x2\x2\x2\xC6"+
		"\x761\x3\x2\x2\x2\xC8\x76B\x3\x2\x2\x2\xCA\x780\x3\x2\x2\x2\xCC\x788\x3"+
		"\x2\x2\x2\xCE\x78C\x3\x2\x2\x2\xD0\x798\x3\x2\x2\x2\xD2\x7A5\x3\x2\x2"+
		"\x2\xD4\x7AF\x3\x2\x2\x2\xD6\x7B3\x3\x2\x2\x2\xD8\x7BE\x3\x2\x2\x2\xDA"+
		"\x7C0\x3\x2\x2\x2\xDC\x7CA\x3\x2\x2\x2\xDE\x7CD\x3\x2\x2\x2\xE0\x7DA\x3"+
		"\x2\x2\x2\xE2\x7DC\x3\x2\x2\x2\xE4\x7DE\x3\x2\x2\x2\xE6\x7E0\x3\x2\x2"+
		"\x2\xE8\x7E4\x3\x2\x2\x2\xEA\x7E9\x3\x2\x2\x2\xEC\x7ED\x3\x2\x2\x2\xEE"+
		"\x7EF\x3\x2\x2\x2\xF0\xF4\x5\x4\x3\x2\xF1\xF2\aX\x2\x2\xF2\xF3\a}\x2\x2"+
		"\xF3\xF5\a\xC7\x2\x2\xF4\xF1\x3\x2\x2\x2\xF4\xF5\x3\x2\x2\x2\xF5\xF8\x3"+
		"\x2\x2\x2\xF6\xF7\a\x43\x2\x2\xF7\xF9\x5\xECw\x2\xF8\xF6\x3\x2\x2\x2\xF8"+
		"\xF9\x3\x2\x2\x2\xF9\xFB\x3\x2\x2\x2\xFA\xFC\a\xE3\x2\x2\xFB\xFA\x3\x2"+
		"\x2\x2\xFB\xFC\x3\x2\x2\x2\xFC\xFF\x3\x2\x2\x2\xFD\xFF\x5`\x31\x2\xFE"+
		"\xF0\x3\x2\x2\x2\xFE\xFD\x3\x2\x2\x2\xFF\x3\x3\x2\x2\x2\x100\x113\x5\x6"+
		"\x4\x2\x101\x113\x5\x14\v\x2\x102\x113\x5\x16\f\x2\x103\x113\x5\x18\r"+
		"\x2\x104\x113\x5X-\x2\x105\x113\x5Z.\x2\x106\x113\x5\\/\x2\x107\x113\x5"+
		"^\x30\x2\x108\x113\x5\x66\x34\x2\x109\x113\x5h\x35\x2\x10A\x113\x5j\x36"+
		"\x2\x10B\x113\x5n\x38\x2\x10C\x113\x5\xB2Z\x2\x10D\x113\x5\xB4[\x2\x10E"+
		"\x113\x5\xB6\\\x2\x10F\x113\x5\xB8]\x2\x110\x113\x5\xBA^\x2\x111\x113"+
		"\x5\xBC_\x2\x112\x100\x3\x2\x2\x2\x112\x101\x3\x2\x2\x2\x112\x102\x3\x2"+
		"\x2\x2\x112\x103\x3\x2\x2\x2\x112\x104\x3\x2\x2\x2\x112\x105\x3\x2\x2"+
		"\x2\x112\x106\x3\x2\x2\x2\x112\x107\x3\x2\x2\x2\x112\x108\x3\x2\x2\x2"+
		"\x112\x109\x3\x2\x2\x2\x112\x10A\x3\x2\x2\x2\x112\x10B\x3\x2\x2\x2\x112"+
		"\x10C\x3\x2\x2\x2\x112\x10D\x3\x2\x2\x2\x112\x10E\x3\x2\x2\x2\x112\x10F"+
		"\x3\x2\x2\x2\x112\x110\x3\x2\x2\x2\x112\x111\x3\x2\x2\x2\x113\x5\x3\x2"+
		"\x2\x2\x114\x115\a\a\x2\x2\x115\x116\a\xA0\x2\x2\x116\x118\x5\xD4k\x2"+
		"\x117\x119\x5.\x18\x2\x118\x117\x3\x2\x2\x2\x118\x119\x3\x2\x2\x2\x119"+
		"\x11A\x3\x2\x2\x2\x11A\x11F\x5\b\x5\x2\x11B\x11C\a\xCD\x2\x2\x11C\x11E"+
		"\x5\b\x5\x2\x11D\x11B\x3\x2\x2\x2\x11E\x121\x3\x2\x2\x2\x11F\x11D\x3\x2"+
		"\x2\x2\x11F\x120\x3\x2\x2\x2\x120\a\x3\x2\x2\x2\x121\x11F\x3\x2\x2\x2"+
		"\x122\x123\a\x3\x2\x2\x123\x127\a\x1C\x2\x2\x124\x125\aO\x2\x2\x125\x126"+
		"\at\x2\x2\x126\x128\a\x39\x2\x2\x127\x124\x3\x2\x2\x2\x127\x128\x3\x2"+
		"\x2\x2\x128\x129\x3\x2\x2\x2\x129\x12B\x5J&\x2\x12A\x12C\x5\n\x6\x2\x12B"+
		"\x12A\x3\x2\x2\x2\x12B\x12C\x3\x2\x2\x2\x12C\x1F7\x3\x2\x2\x2\x12D\x12E"+
		"\a\x3\x2\x2\x12E\x132\aR\x2\x2\x12F\x130\aO\x2\x2\x130\x131\at\x2\x2\x131"+
		"\x133\a\x39\x2\x2\x132\x12F\x3\x2\x2\x2\x132\x133\x3\x2\x2\x2\x133\x134"+
		"\x3\x2\x2\x2\x134\x137\x5N(\x2\x135\x136\a\x4\x2\x2\x136\x138\x5\xCEh"+
		"\x2\x137\x135\x3\x2\x2\x2\x137\x138\x3\x2\x2\x2\x138\x1F7\x3\x2\x2\x2"+
		"\x139\x13A\a\x3\x2\x2\x13A\x13E\a\x84\x2\x2\x13B\x13C\aO\x2\x2\x13C\x13D"+
		"\at\x2\x2\x13D\x13F\a\x39\x2\x2\x13E\x13B\x3\x2\x2\x2\x13E\x13F\x3\x2"+
		"\x2\x2\x13F\x140\x3\x2\x2\x2\x140\x143\x5P)\x2\x141\x142\a\x4\x2\x2\x142"+
		"\x144\x5\xCEh\x2\x143\x141\x3\x2\x2\x2\x143\x144\x3\x2\x2\x2\x144\x1F7"+
		"\x3\x2\x2\x2\x145\x146\a\x11\x2\x2\x146\x149\x5\x12\n\x2\x147\x148\a\x45"+
		"\x2\x2\x148\x14A\x5\xD4k\x2\x149\x147\x3\x2\x2\x2\x149\x14A\x3\x2\x2\x2"+
		"\x14A\x1F7\x3\x2\x2\x2\x14B\x14C\a\x18\x2\x2\x14C\x14F\a\x1C\x2\x2\x14D"+
		"\x14E\aO\x2\x2\x14E\x150\a\x39\x2\x2\x14F\x14D\x3\x2\x2\x2\x14F\x150\x3"+
		"\x2\x2\x2\x150\x151\x3\x2\x2\x2\x151\x154\x5\xCEh\x2\x152\x153\aQ\x2\x2"+
		"\x153\x155\x5\x12\n\x2\x154\x152\x3\x2\x2\x2\x154\x155\x3\x2\x2\x2\x155"+
		"\x1F7\x3\x2\x2\x2\x156\x157\a\x18\x2\x2\x157\x15A\aR\x2\x2\x158\x159\a"+
		"O\x2\x2\x159\x15B\a\x39\x2\x2\x15A\x158\x3\x2\x2\x2\x15A\x15B\x3\x2\x2"+
		"\x2\x15B\x15C\x3\x2\x2\x2\x15C\x15F\x5\xCEh\x2\x15D\x15E\aQ\x2\x2\x15E"+
		"\x160\x5\x12\n\x2\x15F\x15D\x3\x2\x2\x2\x15F\x160\x3\x2\x2\x2\x160\x1F7"+
		"\x3\x2\x2\x2\x161\x162\a\x18\x2\x2\x162\x165\a\x84\x2\x2\x163\x164\aO"+
		"\x2\x2\x164\x166\a\x39\x2\x2\x165\x163\x3\x2\x2\x2\x165\x166\x3\x2\x2"+
		"\x2\x166\x167\x3\x2\x2\x2\x167\x16A\x5\xCEh\x2\x168\x169\aQ\x2\x2\x169"+
		"\x16B\x5\x12\n\x2\x16A\x168\x3\x2\x2\x2\x16A\x16B\x3\x2\x2\x2\x16B\x1F7"+
		"\x3\x2\x2\x2\x16C\x16D\a\x1D\x2\x2\x16D\x170\a\x1C\x2\x2\x16E\x16F\aO"+
		"\x2\x2\x16F\x171\a\x39\x2\x2\x170\x16E\x3\x2\x2\x2\x170\x171\x3\x2\x2"+
		"\x2\x171\x172\x3\x2\x2\x2\x172\x173\x5\xCEh\x2\x173\x174\a\xC7\x2\x2\x174"+
		"\x1F7\x3\x2\x2\x2\x175\x176\a*\x2\x2\x176\x177\a\xBC\x2\x2\x177\x1F7\x5"+
		"\xC4\x63\x2\x178\x179\a.\x2\x2\x179\x1F7\x5\x12\n\x2\x17A\x17B\a\x34\x2"+
		"\x2\x17B\x17E\a\x1C\x2\x2\x17C\x17D\aO\x2\x2\x17D\x17F\a\x39\x2\x2\x17E"+
		"\x17C\x3\x2\x2\x2\x17E\x17F\x3\x2\x2\x2\x17F\x180\x3\x2\x2\x2\x180\x1F7"+
		"\x5\xCEh\x2\x181\x182\a\x34\x2\x2\x182\x185\aR\x2\x2\x183\x184\aO\x2\x2"+
		"\x184\x186\a\x39\x2\x2\x185\x183\x3\x2\x2\x2\x185\x186\x3\x2\x2\x2\x186"+
		"\x187\x3\x2\x2\x2\x187\x1F7\x5\xCEh\x2\x188\x189\a\x34\x2\x2\x189\x18C"+
		"\a\x84\x2\x2\x18A\x18B\aO\x2\x2\x18B\x18D\a\x39\x2\x2\x18C\x18A\x3\x2"+
		"\x2\x2\x18C\x18D\x3\x2\x2\x2\x18D\x18E\x3\x2\x2\x2\x18E\x1F7\x5\xCEh\x2"+
		"\x18F\x190\a\x34\x2\x2\x190\x1F7\x5\x12\n\x2\x191\x193\a\x44\x2\x2\x192"+
		"\x194\x5\x12\n\x2\x193\x192\x3\x2\x2\x2\x193\x194\x3\x2\x2\x2\x194\x1F7"+
		"\x3\x2\x2\x2\x195\x196\ah\x2\x2\x196\x199\aR\x2\x2\x197\x198\aO\x2\x2"+
		"\x198\x19A\a\x39\x2\x2\x199\x197\x3\x2\x2\x2\x199\x19A\x3\x2\x2\x2\x19A"+
		"\x19B\x3\x2\x2\x2\x19B\x19E\x5\xCEh\x2\x19C\x19D\aQ\x2\x2\x19D\x19F\x5"+
		"\x12\n\x2\x19E\x19C\x3\x2\x2\x2\x19E\x19F\x3\x2\x2\x2\x19F\x1F7\x3\x2"+
		"\x2\x2\x1A0\x1A1\ah\x2\x2\x1A1\x1A4\a\x84\x2\x2\x1A2\x1A3\aO\x2\x2\x1A3"+
		"\x1A5\a\x39\x2\x2\x1A4\x1A2\x3\x2\x2\x2\x1A4\x1A5\x3\x2\x2\x2\x1A5\x1A6"+
		"\x3\x2\x2\x2\x1A6\x1A9\x5\xCEh\x2\x1A7\x1A8\aQ\x2\x2\x1A8\x1AA\x5\x12"+
		"\n\x2\x1A9\x1A7\x3\x2\x2\x2\x1A9\x1AA\x3\x2\x2\x2\x1AA\x1F7\x3\x2\x2\x2"+
		"\x1AB\x1AC\an\x2\x2\x1AC\x1AF\a\x1C\x2\x2\x1AD\x1AE\aO\x2\x2\x1AE\x1B0"+
		"\a\x39\x2\x2\x1AF\x1AD\x3\x2\x2\x2\x1AF\x1B0\x3\x2\x2\x2\x1B0\x1B1\x3"+
		"\x2\x2\x2\x1B1\x1B2\x5\xCEh\x2\x1B2\x1B3\x5R*\x2\x1B3\x1F7\x3\x2\x2\x2"+
		"\x1B4\x1B5\an\x2\x2\x1B5\x1B8\a\x1C\x2\x2\x1B6\x1B7\aO\x2\x2\x1B7\x1B9"+
		"\a\x39\x2\x2\x1B8\x1B6\x3\x2\x2\x2\x1B8\x1B9\x3\x2\x2\x2\x1B9\x1BA\x3"+
		"\x2\x2\x2\x1BA\x1BB\x5\xCEh\x2\x1BB\x1BC\x5<\x1F\x2\x1BC\x1F7\x3\x2\x2"+
		"\x2\x1BD\x1BE\an\x2\x2\x1BE\x1C1\a\x1C\x2\x2\x1BF\x1C0\aO\x2\x2\x1C0\x1C2"+
		"\a\x39\x2\x2\x1C1\x1BF\x3\x2\x2\x2\x1C1\x1C2\x3\x2\x2\x2\x1C2\x1C3\x3"+
		"\x2\x2\x2\x1C3\x1C4\x5\xCEh\x2\x1C4\x1C5\a\x88\x2\x2\x1C5\x1C6\x5\x10"+
		"\t\x2\x1C6\x1F7\x3\x2\x2\x2\x1C7\x1C8\an\x2\x2\x1C8\x1CB\a\x1C\x2\x2\x1C9"+
		"\x1CA\aO\x2\x2\x1CA\x1CC\a\x39\x2\x2\x1CB\x1C9\x3\x2\x2\x2\x1CB\x1CC\x3"+
		"\x2\x2\x2\x1CC\x1CD\x3\x2\x2\x2\x1CD\x1F7\x5J&\x2\x1CE\x1CF\an\x2\x2\x1CF"+
		"\x1D0\a{\x2\x2\x1D0\x1D1\a\x14\x2\x2\x1D1\x1F7\x5\xC4\x63\x2\x1D2\x1D3"+
		"\an\x2\x2\x1D3\x1F7\x5\x44#\x2\x1D4\x1D5\ap\x2\x2\x1D5\x1DF\x5\x12\n\x2"+
		"\x1D6\x1D7\a\xA8\x2\x2\x1D7\x1D8\a\x31\x2\x2\x1D8\x1E0\a\xC7\x2\x2\x1D9"+
		"\x1DA\a\xA8\x2\x2\x1DA\x1DB\a\xB8\x2\x2\x1DB\x1E0\a\xC7\x2\x2\x1DC\x1DD"+
		"\a\xA8\x2\x2\x1DD\x1DE\a\xA0\x2\x2\x1DE\x1E0\x5\xD4k\x2\x1DF\x1D6\x3\x2"+
		"\x2\x2\x1DF\x1D9\x3\x2\x2\x2\x1DF\x1DC\x3\x2\x2\x2\x1E0\x1F7\x3\x2\x2"+
		"\x2\x1E1\x1E2\a\x88\x2\x2\x1E2\x1F7\a\xAE\x2\x2\x1E3\x1E4\a\x89\x2\x2"+
		"\x1E4\x1E7\a\x1C\x2\x2\x1E5\x1E6\aO\x2\x2\x1E6\x1E8\a\x39\x2\x2\x1E7\x1E5"+
		"\x3\x2\x2\x2\x1E7\x1E8\x3\x2\x2\x2\x1E8\x1E9\x3\x2\x2\x2\x1E9\x1EA\x5"+
		"\xCEh\x2\x1EA\x1EB\a\xA8\x2\x2\x1EB\x1EC\x5\xCEh\x2\x1EC\x1F7\x3\x2\x2"+
		"\x2\x1ED\x1EE\a\x8A\x2\x2\x1EE\x1EF\x5\x12\n\x2\x1EF\x1F0\a\x45\x2\x2"+
		"\x1F0\x1F1\x5\xD4k\x2\x1F1\x1F7\x3\x2\x2\x2\x1F2\x1F3\a\xB2\x2\x2\x1F3"+
		"\x1F4\x5\f\a\x2\x1F4\x1F5\x5\x80\x41\x2\x1F5\x1F7\x3\x2\x2\x2\x1F6\x122"+
		"\x3\x2\x2\x2\x1F6\x12D\x3\x2\x2\x2\x1F6\x139\x3\x2\x2\x2\x1F6\x145\x3"+
		"\x2\x2\x2\x1F6\x14B\x3\x2\x2\x2\x1F6\x156\x3\x2\x2\x2\x1F6\x161\x3\x2"+
		"\x2\x2\x1F6\x16C\x3\x2\x2\x2\x1F6\x175\x3\x2\x2\x2\x1F6\x178\x3\x2\x2"+
		"\x2\x1F6\x17A\x3\x2\x2\x2\x1F6\x181\x3\x2\x2\x2\x1F6\x188\x3\x2\x2\x2"+
		"\x1F6\x18F\x3\x2\x2\x2\x1F6\x191\x3\x2\x2\x2\x1F6\x195\x3\x2\x2\x2\x1F6"+
		"\x1A0\x3\x2\x2\x2\x1F6\x1AB\x3\x2\x2\x2\x1F6\x1B4\x3\x2\x2\x2\x1F6\x1BD"+
		"\x3\x2\x2\x2\x1F6\x1C7\x3\x2\x2\x2\x1F6\x1CE\x3\x2\x2\x2\x1F6\x1D2\x3"+
		"\x2\x2\x2\x1F6\x1D4\x3\x2\x2\x2\x1F6\x1E1\x3\x2\x2\x2\x1F6\x1E3\x3\x2"+
		"\x2\x2\x1F6\x1ED\x3\x2\x2\x2\x1F6\x1F2\x3\x2\x2\x2\x1F7\t\x3\x2\x2\x2"+
		"\x1F8\x1F9\a\x4\x2\x2\x1F9\x1FA\x5\xCEh\x2\x1FA\v\x3\x2\x2\x2\x1FB\x200"+
		"\x5\xE\b\x2\x1FC\x1FD\a\xCD\x2\x2\x1FD\x1FF\x5\xE\b\x2\x1FE\x1FC\x3\x2"+
		"\x2\x2\x1FF\x202\x3\x2\x2\x2\x200\x1FE\x3\x2\x2\x2\x200\x201\x3\x2\x2"+
		"\x2\x201\r\x3\x2\x2\x2\x202\x200\x3\x2\x2\x2\x203\x204\x5\xCEh\x2\x204"+
		"\x205\a\xD2\x2\x2\x205\x206\x5\xC4\x63\x2\x206\xF\x3\x2\x2\x2\x207\x208"+
		"\t\x2\x2\x2\x208\x11\x3\x2\x2\x2\x209\x20A\a\x7F\x2\x2\x20A\x20F\x5\xC4"+
		"\x63\x2\x20B\x20C\a\x7F\x2\x2\x20C\x20D\aN\x2\x2\x20D\x20F\a\xC7\x2\x2"+
		"\x20E\x209\x3\x2\x2\x2\x20E\x20B\x3\x2\x2\x2\x20F\x13\x3\x2\x2\x2\x210"+
		"\x211\a\x11\x2\x2\x211\x212\a\x30\x2\x2\x212\x214\x5\xD4k\x2\x213\x215"+
		"\x5.\x18\x2\x214\x213\x3\x2\x2\x2\x214\x215\x3\x2\x2\x2\x215\x15\x3\x2"+
		"\x2\x2\x216\x217\a\x17\x2\x2\x217\x218\a\xA0\x2\x2\x218\x21A\x5\xD4k\x2"+
		"\x219\x21B\x5\x12\n\x2\x21A\x219\x3\x2\x2\x2\x21A\x21B\x3\x2\x2\x2\x21B"+
		"\x17\x3\x2\x2\x2\x21C\x21D\t\x3\x2\x2\x21D\x221\a#\x2\x2\x21E\x21F\aO"+
		"\x2\x2\x21F\x220\at\x2\x2\x220\x222\a\x39\x2\x2\x221\x21E\x3\x2\x2\x2"+
		"\x221\x222\x3\x2\x2\x2\x222\x223\x3\x2\x2\x2\x223\x225\x5\xDAn\x2\x224"+
		"\x226\x5.\x18\x2\x225\x224\x3\x2\x2\x2\x225\x226\x3\x2\x2\x2\x226\x228"+
		"\x3\x2\x2\x2\x227\x229\x5\x46$\x2\x228\x227\x3\x2\x2\x2\x228\x229\x3\x2"+
		"\x2\x2\x229\x2B9\x3\x2\x2\x2\x22A\x232\a\x11\x2\x2\x22B\x22E\a\x1F\x2"+
		"\x2\x22C\x22D\az\x2\x2\x22D\x22F\a\x8A\x2\x2\x22E\x22C\x3\x2\x2\x2\x22E"+
		"\x22F\x3\x2\x2\x2\x22F\x232\x3\x2\x2\x2\x230\x232\a\x8A\x2\x2\x231\x22A"+
		"\x3\x2\x2\x2\x231\x22B\x3\x2\x2\x2\x231\x230\x3\x2\x2\x2\x232\x233\x3"+
		"\x2\x2\x2\x233\x237\a\x30\x2\x2\x234\x235\aO\x2\x2\x235\x236\at\x2\x2"+
		"\x236\x238\a\x39\x2\x2\x237\x234\x3\x2\x2\x2\x237\x238\x3\x2\x2\x2\x238"+
		"\x239\x3\x2\x2\x2\x239\x23B\x5\xD4k\x2\x23A\x23C\x5\x30\x19\x2\x23B\x23A"+
		"\x3\x2\x2\x2\x23B\x23C\x3\x2\x2\x2\x23C\x23E\x3\x2\x2\x2\x23D\x23F\x5"+
		".\x18\x2\x23E\x23D\x3\x2\x2\x2\x23E\x23F\x3\x2\x2\x2\x23F\x240\x3\x2\x2"+
		"\x2\x240\x241\x5\x1A\xE\x2\x241\x242\x5\x1E\x10\x2\x242\x2B9\x3\x2\x2"+
		"\x2\x243\x244\t\x3\x2\x2\x244\x245\a\x65\x2\x2\x245\x249\a\xB7\x2\x2\x246"+
		"\x247\aO\x2\x2\x247\x248\at\x2\x2\x248\x24A\a\x39\x2\x2\x249\x246\x3\x2"+
		"\x2\x2\x249\x24A\x3\x2\x2\x2\x24A\x24B\x3\x2\x2\x2\x24B\x24D\x5\xD4k\x2"+
		"\x24C\x24E\x5\x30\x19\x2\x24D\x24C\x3\x2\x2\x2\x24D\x24E\x3\x2\x2\x2\x24E"+
		"\x250\x3\x2\x2\x2\x24F\x251\x5.\x18\x2\x250\x24F\x3\x2\x2\x2\x250\x251"+
		"\x3\x2\x2\x2\x251\x257\x3\x2\x2\x2\x252\x253\a\xBE\x2\x2\x253\x255\a\xA6"+
		"\x2\x2\x254\x256\a\xC5\x2\x2\x255\x254\x3\x2\x2\x2\x255\x256\x3\x2\x2"+
		"\x2\x256\x258\x3\x2\x2\x2\x257\x252\x3\x2\x2\x2\x257\x258\x3\x2\x2\x2"+
		"\x258\x25A\x3\x2\x2\x2\x259\x25B\x5\x32\x1A\x2\x25A\x259\x3\x2\x2\x2\x25A"+
		"\x25B\x3\x2\x2\x2\x25B\x25D\x3\x2\x2\x2\x25C\x25E\x5\x36\x1C\x2\x25D\x25C"+
		"\x3\x2\x2\x2\x25D\x25E\x3\x2\x2\x2\x25E\x25F\x3\x2\x2\x2\x25F\x260\x5"+
		"\x34\x1B\x2\x260\x2B9\x3\x2\x2\x2\x261\x262\t\x3\x2\x2\x262\x263\ai\x2"+
		"\x2\x263\x267\a\xB7\x2\x2\x264\x265\aO\x2\x2\x265\x266\at\x2\x2\x266\x268"+
		"\a\x39\x2\x2\x267\x264\x3\x2\x2\x2\x267\x268\x3\x2\x2\x2\x268\x269\x3"+
		"\x2\x2\x2\x269\x26B\x5\xD4k\x2\x26A\x26C\x5\x30\x19\x2\x26B\x26A\x3\x2"+
		"\x2\x2\x26B\x26C\x3\x2\x2\x2\x26C\x26E\x3\x2\x2\x2\x26D\x26F\x5.\x18\x2"+
		"\x26E\x26D\x3\x2\x2\x2\x26E\x26F\x3\x2\x2\x2\x26F\x271\x3\x2\x2\x2\x270"+
		"\x272\x5\x36\x1C\x2\x271\x270\x3\x2\x2\x2\x271\x272\x3\x2\x2\x2\x272\x278"+
		"\x3\x2\x2\x2\x273\x279\x5\x32\x1A\x2\x274\x276\x5\x38\x1D\x2\x275\x277"+
		"\a\x80\x2\x2\x276\x275\x3\x2\x2\x2\x276\x277\x3\x2\x2\x2\x277\x279\x3"+
		"\x2\x2\x2\x278\x273\x3\x2\x2\x2\x278\x274\x3\x2\x2\x2\x279\x27A\x3\x2"+
		"\x2\x2\x27A\x27B\x5\x34\x1B\x2\x27B\x2B9\x3\x2\x2\x2\x27C\x284\a\x11\x2"+
		"\x2\x27D\x280\a\x1F\x2\x2\x27E\x27F\az\x2\x2\x27F\x281\a\x8A\x2\x2\x280"+
		"\x27E\x3\x2\x2\x2\x280\x281\x3\x2\x2\x2\x281\x284\x3\x2\x2\x2\x282\x284"+
		"\a\x8A\x2\x2\x283\x27C\x3\x2\x2\x2\x283\x27D\x3\x2\x2\x2\x283\x282\x3"+
		"\x2\x2\x2\x284\x286\x3\x2\x2\x2\x285\x287\a\xA2\x2\x2\x286\x285\x3\x2"+
		"\x2\x2\x286\x287\x3\x2\x2\x2\x287\x288\x3\x2\x2\x2\x288\x28C\a\xA0\x2"+
		"\x2\x289\x28A\aO\x2\x2\x28A\x28B\at\x2\x2\x28B\x28D\a\x39\x2\x2\x28C\x289"+
		"\x3\x2\x2\x2\x28C\x28D\x3\x2\x2\x2\x28D\x28E\x3\x2\x2\x2\x28E\x290\x5"+
		"\xD4k\x2\x28F\x291\x5\x30\x19\x2\x290\x28F\x3\x2\x2\x2\x290\x291\x3\x2"+
		"\x2\x2\x291\x293\x3\x2\x2\x2\x292\x294\x5.\x18\x2\x293\x292\x3\x2\x2\x2"+
		"\x293\x294\x3\x2\x2\x2\x294\x296\x3\x2\x2\x2\x295\x297\x5\x36\x1C\x2\x296"+
		"\x295\x3\x2\x2\x2\x296\x297\x3\x2\x2\x2\x297\x299\x3\x2\x2\x2\x298\x29A"+
		"\x5\x38\x1D\x2\x299\x298\x3\x2\x2\x2\x299\x29A\x3\x2\x2\x2\x29A\x29C\x3"+
		"\x2\x2\x2\x29B\x29D\x5\x34\x1B\x2\x29C\x29B\x3\x2\x2\x2\x29C\x29D\x3\x2"+
		"\x2\x2\x29D\x29F\x3\x2\x2\x2\x29E\x2A0\x5:\x1E\x2\x29F\x29E\x3\x2\x2\x2"+
		"\x29F\x2A0\x3\x2\x2\x2\x2A0\x2B9\x3\x2\x2\x2\x2A1\x2A4\t\x3\x2\x2\x2A2"+
		"\x2A3\az\x2\x2\x2A3\x2A5\a\x8A\x2\x2\x2A4\x2A2\x3\x2\x2\x2\x2A4\x2A5\x3"+
		"\x2\x2\x2\x2A5\x2A6\x3\x2\x2\x2\x2A6\x2AA\a\xB7\x2\x2\x2A7\x2A8\aO\x2"+
		"\x2\x2A8\x2A9\at\x2\x2\x2A9\x2AB\a\x39\x2\x2\x2AA\x2A7\x3\x2\x2\x2\x2AA"+
		"\x2AB\x3\x2\x2\x2\x2AB\x2AC\x3\x2\x2\x2\x2AC\x2AE\x5\xD4k\x2\x2AD\x2AF"+
		"\x5\x30\x19\x2\x2AE\x2AD\x3\x2\x2\x2\x2AE\x2AF\x3\x2\x2\x2\x2AF\x2B1\x3"+
		"\x2\x2\x2\x2B0\x2B2\x5.\x18\x2\x2B1\x2B0\x3\x2\x2\x2\x2B1\x2B2\x3\x2\x2"+
		"\x2\x2B2\x2B4\x3\x2\x2\x2\x2B3\x2B5\x5\x36\x1C\x2\x2B4\x2B3\x3\x2\x2\x2"+
		"\x2B4\x2B5\x3\x2\x2\x2\x2B5\x2B6\x3\x2\x2\x2\x2B6\x2B7\x5\x34\x1B\x2\x2B7"+
		"\x2B9\x3\x2\x2\x2\x2B8\x21C\x3\x2\x2\x2\x2B8\x231\x3\x2\x2\x2\x2B8\x243"+
		"\x3\x2\x2\x2\x2B8\x261\x3\x2\x2\x2\x2B8\x283\x3\x2\x2\x2\x2B8\x2A1\x3"+
		"\x2\x2\x2\x2B9\x19\x3\x2\x2\x2\x2BA\x2BB\a\xD8\x2\x2\x2BB\x2C0\x5\x1C"+
		"\xF\x2\x2BC\x2BD\a\xCD\x2\x2\x2BD\x2BF\x5\x1C\xF\x2\x2BE\x2BC\x3\x2\x2"+
		"\x2\x2BF\x2C2\x3\x2\x2\x2\x2C0\x2BE\x3\x2\x2\x2\x2C0\x2C1\x3\x2\x2\x2"+
		"\x2C1\x2C3\x3\x2\x2\x2\x2C2\x2C0\x3\x2\x2\x2\x2C3\x2C4\a\xE2\x2\x2\x2C4"+
		"\x1B\x3\x2\x2\x2\x2C5\x2C6\x5\xEAv\x2\x2C6\x2DC\x5\xBE`\x2\x2C7\x2C8\x6"+
		"\xF\x2\x3\x2C8\x2C9\a(\x2\x2\x2C9\x2CA\x5\xE0q\x2\x2CA\x2CB\b\xF\x1\x2"+
		"\x2CB\x2DB\x3\x2\x2\x2\x2CC\x2CD\x6\xF\x3\x3\x2CD\x2CE\a;\x2\x2\x2CE\x2CF"+
		"\x5\xC4\x63\x2\x2CF\x2D0\b\xF\x1\x2\x2D0\x2DB\x3\x2\x2\x2\x2D1\x2D2\x6"+
		"\xF\x4\x3\x2D2\x2D3\aL\x2\x2\x2D3\x2DB\b\xF\x1\x2\x2D4\x2D5\x6\xF\x5\x3"+
		"\x2D5\x2D6\aT\x2\x2\x2D6\x2DB\b\xF\x1\x2\x2D7\x2D8\x6\xF\x6\x3\x2D8\x2D9"+
		"\aZ\x2\x2\x2D9\x2DB\b\xF\x1\x2\x2DA\x2C7\x3\x2\x2\x2\x2DA\x2CC\x3\x2\x2"+
		"\x2\x2DA\x2D1\x3\x2\x2\x2\x2DA\x2D4\x3\x2\x2\x2\x2DA\x2D7\x3\x2\x2\x2"+
		"\x2DB\x2DE\x3\x2\x2\x2\x2DC\x2DA\x3\x2\x2\x2\x2DC\x2DD\x3\x2\x2\x2\x2DD"+
		"\x1D\x3\x2\x2\x2\x2DE\x2DC\x3\x2\x2\x2\x2DF\x2E1\x5 \x11\x2\x2E0\x2DF"+
		"\x3\x2\x2\x2\x2E0\x2E1\x3\x2\x2\x2\x2E1\x2F8\x3\x2\x2\x2\x2E2\x2E3\x6"+
		"\x10\a\x3\x2E3\x2E4\x5$\x13\x2\x2E4\x2E5\b\x10\x1\x2\x2E5\x2F7\x3\x2\x2"+
		"\x2\x2E6\x2E7\x6\x10\b\x3\x2E7\x2E8\x5&\x14\x2\x2E8\x2E9\b\x10\x1\x2\x2E9"+
		"\x2F7\x3\x2\x2\x2\x2EA\x2EB\x6\x10\t\x3\x2EB\x2EC\x5(\x15\x2\x2EC\x2ED"+
		"\b\x10\x1\x2\x2ED\x2F7\x3\x2\x2\x2\x2EE\x2EF\x6\x10\n\x3\x2EF\x2F0\x5"+
		"*\x16\x2\x2F0\x2F1\b\x10\x1\x2\x2F1\x2F7\x3\x2\x2\x2\x2F2\x2F3\x6\x10"+
		"\v\x3\x2F3\x2F4\x5,\x17\x2\x2F4\x2F5\b\x10\x1\x2\x2F5\x2F7\x3\x2\x2\x2"+
		"\x2F6\x2E2\x3\x2\x2\x2\x2F6\x2E6\x3\x2\x2\x2\x2F6\x2EA\x3\x2\x2\x2\x2F6"+
		"\x2EE\x3\x2\x2\x2\x2F6\x2F2\x3\x2\x2\x2\x2F7\x2FA\x3\x2\x2\x2\x2F8\x2F6"+
		"\x3\x2\x2\x2\x2F8\x2F9\x3\x2\x2\x2\x2F9\x1F\x3\x2\x2\x2\x2FA\x2F8\x3\x2"+
		"\x2\x2\x2FB\x2FC\a\x83\x2\x2\x2FC\x2FD\a\\\x2\x2\x2FD\x2FE\x5\xC0\x61"+
		"\x2\x2FE!\x3\x2\x2\x2\x2FF\x306\x5\xEAv\x2\x300\x303\x5\xEAv\x2\x301\x302"+
		"\a\xD8\x2\x2\x302\x304\a\xE2\x2\x2\x303\x301\x3\x2\x2\x2\x303\x304\x3"+
		"\x2\x2\x2\x304\x307\x3\x2\x2\x2\x305\x307\x5\xE0q\x2\x306\x300\x3\x2\x2"+
		"\x2\x306\x305\x3\x2\x2\x2\x307#\x3\x2\x2\x2\x308\x309\a\x99\x2\x2\x309"+
		"\x30A\a\xD8\x2\x2\x30A\x30B\x5\xEAv\x2\x30B\x30F\a\xD8\x2\x2\x30C\x30E"+
		"\x5\"\x12\x2\x30D\x30C\x3\x2\x2\x2\x30E\x311\x3\x2\x2\x2\x30F\x30D\x3"+
		"\x2\x2\x2\x30F\x310\x3\x2\x2\x2\x310\x312\x3\x2\x2\x2\x311\x30F\x3\x2"+
		"\x2\x2\x312\x313\a\xE2\x2\x2\x313\x314\a\xE2\x2\x2\x314%\x3\x2\x2\x2\x315"+
		"\x316\a\x62\x2\x2\x316\x320\a\xD8\x2\x2\x317\x321\a\xC5\x2\x2\x318\x319"+
		"\al\x2\x2\x319\x31A\a\xC5\x2\x2\x31A\x31B\aj\x2\x2\x31B\x321\a\xC5\x2"+
		"\x2\x31C\x31D\aj\x2\x2\x31D\x31E\a\xC5\x2\x2\x31E\x31F\al\x2\x2\x31F\x321"+
		"\a\xC5\x2\x2\x320\x317\x3\x2\x2\x2\x320\x318\x3\x2\x2\x2\x320\x31C\x3"+
		"\x2\x2\x2\x321\x322\x3\x2\x2\x2\x322\x323\a\xE2\x2\x2\x323\'\x3\x2\x2"+
		"\x2\x324\x325\a_\x2\x2\x325\x326\a\xD8\x2\x2\x326\x327\x5\xEAv\x2\x327"+
		"\x32B\a\xD8\x2\x2\x328\x32A\x5\"\x12\x2\x329\x328\x3\x2\x2\x2\x32A\x32D"+
		"\x3\x2\x2\x2\x32B\x329\x3\x2\x2\x2\x32B\x32C\x3\x2\x2\x2\x32C\x32E\x3"+
		"\x2\x2\x2\x32D\x32B\x3\x2\x2\x2\x32E\x32F\a\xE2\x2\x2\x32F\x330\a\xE2"+
		"\x2\x2\x330)\x3\x2\x2\x2\x331\x332\a\x86\x2\x2\x332\x33D\a\xD8\x2\x2\x333"+
		"\x334\al\x2\x2\x334\x335\x5\xEAv\x2\x335\x336\aj\x2\x2\x336\x337\x5\xEA"+
		"v\x2\x337\x33E\x3\x2\x2\x2\x338\x339\aj\x2\x2\x339\x33A\x5\xEAv\x2\x33A"+
		"\x33B\al\x2\x2\x33B\x33C\x5\xEAv\x2\x33C\x33E\x3\x2\x2\x2\x33D\x333\x3"+
		"\x2\x2\x2\x33D\x338\x3\x2\x2\x2\x33E\x33F\x3\x2\x2\x2\x33F\x340\a\xE2"+
		"\x2\x2\x340+\x3\x2\x2\x2\x341\x342\a\x97\x2\x2\x342\x343\a\xD8\x2\x2\x343"+
		"\x344\x5\xA2R\x2\x344\x345\a\xE2\x2\x2\x345-\x3\x2\x2\x2\x346\x347\ax"+
		"\x2\x2\x347\x34A\a\x19\x2\x2\x348\x34B\x5\xEAv\x2\x349\x34B\a\xC7\x2\x2"+
		"\x34A\x348\x3\x2\x2\x2\x34A\x349\x3\x2\x2\x2\x34B/\x3\x2\x2\x2\x34C\x34D"+
		"\a\xB5\x2\x2\x34D\x34E\a\xC7\x2\x2\x34E\x31\x3\x2\x2\x2\x34F\x350\a\xA8"+
		"\x2\x2\x350\x351\x5\xD4k\x2\x351\x33\x3\x2\x2\x2\x352\x353\a\f\x2\x2\x353"+
		"\x354\x5n\x38\x2\x354\x35\x3\x2\x2\x2\x355\x356\a\xD8\x2\x2\x356\x35B"+
		"\x5H%\x2\x357\x358\a\xCD\x2\x2\x358\x35A\x5H%\x2\x359\x357\x3\x2\x2\x2"+
		"\x35A\x35D\x3\x2\x2\x2\x35B\x359\x3\x2\x2\x2\x35B\x35C\x3\x2\x2\x2\x35C"+
		"\x35E\x3\x2\x2\x2\x35D\x35B\x3\x2\x2\x2\x35E\x35F\a\xE2\x2\x2\x35F\x365"+
		"\x3\x2\x2\x2\x360\x361\a\f\x2\x2\x361\x365\x5\xD4k\x2\x362\x363\a\f\x2"+
		"\x2\x363\x365\x5\xD2j\x2\x364\x355\x3\x2\x2\x2\x364\x360\x3\x2\x2\x2\x364"+
		"\x362\x3\x2\x2\x2\x365\x37\x3\x2\x2\x2\x366\x381\x5\x46$\x2\x367\x368"+
		"\x6\x1D\f\x3\x368\x369\x5\x86\x44\x2\x369\x36A\b\x1D\x1\x2\x36A\x380\x3"+
		"\x2\x2\x2\x36B\x36C\x6\x1D\r\x3\x36C\x36D\x5> \x2\x36D\x36E\b\x1D\x1\x2"+
		"\x36E\x380\x3\x2\x2\x2\x36F\x370\x6\x1D\xE\x3\x370\x371\x5@!\x2\x371\x372"+
		"\b\x1D\x1\x2\x372\x380\x3\x2\x2\x2\x373\x374\x6\x1D\xF\x3\x374\x375\x5"+
		"\x42\"\x2\x375\x376\b\x1D\x1\x2\x376\x380\x3\x2\x2\x2\x377\x378\x6\x1D"+
		"\x10\x3\x378\x379\x5\x44#\x2\x379\x37A\b\x1D\x1\x2\x37A\x380\x3\x2\x2"+
		"\x2\x37B\x37C\x6\x1D\x11\x3\x37C\x37D\x5\x8EH\x2\x37D\x37E\b\x1D\x1\x2"+
		"\x37E\x380\x3\x2\x2\x2\x37F\x367\x3\x2\x2\x2\x37F\x36B\x3\x2\x2\x2\x37F"+
		"\x36F\x3\x2\x2\x2\x37F\x373\x3\x2\x2\x2\x37F\x377\x3\x2\x2\x2\x37F\x37B"+
		"\x3\x2\x2\x2\x380\x383\x3\x2\x2\x2\x381\x37F\x3\x2\x2\x2\x381\x382\x3"+
		"\x2\x2\x2\x382\x39\x3\x2\x2\x2\x383\x381\x3\x2\x2\x2\x384\x385\a\x1D\x2"+
		"\x2\x385\x386\a\xC7\x2\x2\x386;\x3\x2\x2\x2\x387\x388\a\x1D\x2\x2\x388"+
		"\x389\a\xC7\x2\x2\x389=\x3\x2\x2\x2\x38A\x38B\a\x7F\x2\x2\x38B\x38C\a"+
		"\x14\x2\x2\x38C\x38D\x5\xC4\x63\x2\x38D?\x3\x2\x2\x2\x38E\x38F\a\x83\x2"+
		"\x2\x38F\x390\a\\\x2\x2\x390\x391\x5\xC4\x63\x2\x391\x41\x3\x2\x2\x2\x392"+
		"\x393\a\x91\x2\x2\x393\x394\a\x14\x2\x2\x394\x395\x5\xC4\x63\x2\x395\x43"+
		"\x3\x2\x2\x2\x396\x397\a\xAE\x2\x2\x397\x39C\x5V,\x2\x398\x399\a\xCD\x2"+
		"\x2\x399\x39B\x5V,\x2\x39A\x398\x3\x2\x2\x2\x39B\x39E\x3\x2\x2\x2\x39C"+
		"\x39A\x3\x2\x2\x2\x39C\x39D\x3\x2\x2\x2\x39D\x45\x3\x2\x2\x2\x39E\x39C"+
		"\x3\x2\x2\x2\x39F\x3A1\a\x37\x2\x2\x3A0\x3A2\a\xD2\x2\x2\x3A1\x3A0\x3"+
		"\x2\x2\x2\x3A1\x3A2\x3\x2\x2\x2\x3A2\x3A3\x3\x2\x2\x2\x3A3\x3A9\x5\xEC"+
		"w\x2\x3A4\x3A6\a\xD8\x2\x2\x3A5\x3A7\x5\xC0\x61\x2\x3A6\x3A5\x3\x2\x2"+
		"\x2\x3A6\x3A7\x3\x2\x2\x2\x3A7\x3A8\x3\x2\x2\x2\x3A8\x3AA\a\xE2\x2\x2"+
		"\x3A9\x3A4\x3\x2\x2\x2\x3A9\x3AA\x3\x2\x2\x2\x3AAG\x3\x2\x2\x2\x3AB\x3B6"+
		"\x5J&\x2\x3AC\x3AD\a\x1E\x2\x2\x3AD\x3AE\x5\xEAv\x2\x3AE\x3AF\a\x17\x2"+
		"\x2\x3AF\x3B0\x5\xC4\x63\x2\x3B0\x3B6\x3\x2\x2\x2\x3B1\x3B2\aR\x2\x2\x3B2"+
		"\x3B6\x5N(\x2\x3B3\x3B4\a\x84\x2\x2\x3B4\x3B6\x5P)\x2\x3B5\x3AB\x3\x2"+
		"\x2\x2\x3B5\x3AC\x3\x2\x2\x2\x3B5\x3B1\x3\x2\x2\x2\x3B5\x3B3\x3\x2\x2"+
		"\x2\x3B6I\x3\x2\x2\x2\x3B7\x3B8\x5\xCEh\x2\x3B8\x3BA\x5\xBE`\x2\x3B9\x3BB"+
		"\x5L\'\x2\x3BA\x3B9\x3\x2\x2\x2\x3BA\x3BB\x3\x2\x2\x2\x3BB\x3BD\x3\x2"+
		"\x2\x2\x3BC\x3BE\x5<\x1F\x2\x3BD\x3BC\x3\x2\x2\x2\x3BD\x3BE\x3\x2\x2\x2"+
		"\x3BE\x3C0\x3\x2\x2\x2\x3BF\x3C1\x5R*\x2\x3C0\x3BF\x3\x2\x2\x2\x3C0\x3C1"+
		"\x3\x2\x2\x2\x3C1\x3C4\x3\x2\x2\x2\x3C2\x3C3\a\xAE\x2\x2\x3C3\x3C5\x5"+
		"\xC4\x63\x2\x3C4\x3C2\x3\x2\x2\x2\x3C4\x3C5\x3\x2\x2\x2\x3C5\x3D6\x3\x2"+
		"\x2\x2\x3C6\x3C8\x5\xCEh\x2\x3C7\x3C9\x5\xBE`\x2\x3C8\x3C7\x3\x2\x2\x2"+
		"\x3C8\x3C9\x3\x2\x2\x2\x3C9\x3CA\x3\x2\x2\x2\x3CA\x3CC\x5L\'\x2\x3CB\x3CD"+
		"\x5<\x1F\x2\x3CC\x3CB\x3\x2\x2\x2\x3CC\x3CD\x3\x2\x2\x2\x3CD\x3CF\x3\x2"+
		"\x2\x2\x3CE\x3D0\x5R*\x2\x3CF\x3CE\x3\x2\x2\x2\x3CF\x3D0\x3\x2\x2\x2\x3D0"+
		"\x3D3\x3\x2\x2\x2\x3D1\x3D2\a\xAE\x2\x2\x3D2\x3D4\x5\xC4\x63\x2\x3D3\x3D1"+
		"\x3\x2\x2\x2\x3D3\x3D4\x3\x2\x2\x2\x3D4\x3D6\x3\x2\x2\x2\x3D5\x3B7\x3"+
		"\x2\x2\x2\x3D5\x3C6\x3\x2\x2\x2\x3D6K\x3\x2\x2\x2\x3D7\x3D8\t\x4\x2\x2"+
		"\x3D8\x3D9\x5\xC4\x63\x2\x3D9M\x3\x2\x2\x2\x3DA\x3DB\x5\xCEh\x2\x3DB\x3DC"+
		"\x5\xC4\x63\x2\x3DC\x3DD\a\xAF\x2\x2\x3DD\x3DE\x5\xBE`\x2\x3DE\x3DF\a"+
		"I\x2\x2\x3DF\x3E0\a\xC5\x2\x2\x3E0O\x3\x2\x2\x2\x3E1\x3E2\x5\xCEh\x2\x3E2"+
		"\x3E3\x5l\x37\x2\x3E3Q\x3\x2\x2\x2\x3E4\x3E5\a\x1A\x2\x2\x3E5\x3E6\a\xD8"+
		"\x2\x2\x3E6\x3EB\x5T+\x2\x3E7\x3E8\a\xCD\x2\x2\x3E8\x3EA\x5T+\x2\x3E9"+
		"\x3E7\x3\x2\x2\x2\x3EA\x3ED\x3\x2\x2\x2\x3EB\x3E9\x3\x2\x2\x2\x3EB\x3EC"+
		"\x3\x2\x2\x2\x3EC\x3EE\x3\x2\x2\x2\x3ED\x3EB\x3\x2\x2\x2\x3EE\x3EF\a\xE2"+
		"\x2\x2\x3EFS\x3\x2\x2\x2\x3F0\x3F6\x5\xEAv\x2\x3F1\x3F3\a\xD8\x2\x2\x3F2"+
		"\x3F4\x5\xC0\x61\x2\x3F3\x3F2\x3\x2\x2\x2\x3F3\x3F4\x3\x2\x2\x2\x3F4\x3F5"+
		"\x3\x2\x2\x2\x3F5\x3F7\a\xE2\x2\x2\x3F6\x3F1\x3\x2\x2\x2\x3F6\x3F7\x3"+
		"\x2\x2\x2\x3F7U\x3\x2\x2\x2\x3F8\x400\x5\xC4\x63\x2\x3F9\x401\a*\x2\x2"+
		"\x3FA\x3FB\a\xA8\x2\x2\x3FB\x3FC\a\x31\x2\x2\x3FC\x401\a\xC7\x2\x2\x3FD"+
		"\x3FE\a\xA8\x2\x2\x3FE\x3FF\a\xB8\x2\x2\x3FF\x401\a\xC7\x2\x2\x400\x3F9"+
		"\x3\x2\x2\x2\x400\x3FA\x3\x2\x2\x2\x400\x3FD\x3\x2\x2\x2\x400\x401\x3"+
		"\x2\x2\x2\x401W\x3\x2\x2\x2\x402\x404\t\x5\x2\x2\x403\x405\a\xA0\x2\x2"+
		"\x404\x403\x3\x2\x2\x2\x404\x405\x3\x2\x2\x2\x405\x406\x3\x2\x2\x2\x406"+
		"\x407\x5\xD0i\x2\x407Y\x3\x2\x2\x2\x408\x409\t\x6\x2\x2\x409\x40C\a#\x2"+
		"\x2\x40A\x40B\aO\x2\x2\x40B\x40D\a\x39\x2\x2\x40C\x40A\x3\x2\x2\x2\x40C"+
		"\x40D\x3\x2\x2\x2\x40D\x40E\x3\x2\x2\x2\x40E\x410\x5\xDAn\x2\x40F\x411"+
		"\x5.\x18\x2\x410\x40F\x3\x2\x2\x2\x410\x411\x3\x2\x2\x2\x411\x428\x3\x2"+
		"\x2\x2\x412\x419\t\x6\x2\x2\x413\x41A\a\x30\x2\x2\x414\x416\a\xA2\x2\x2"+
		"\x415\x414\x3\x2\x2\x2\x415\x416\x3\x2\x2\x2\x416\x417\x3\x2\x2\x2\x417"+
		"\x41A\a\xA0\x2\x2\x418\x41A\a\xB7\x2\x2\x419\x413\x3\x2\x2\x2\x419\x415"+
		"\x3\x2\x2\x2\x419\x418\x3\x2\x2\x2\x41A\x41D\x3\x2\x2\x2\x41B\x41C\aO"+
		"\x2\x2\x41C\x41E\a\x39\x2\x2\x41D\x41B\x3\x2\x2\x2\x41D\x41E\x3\x2\x2"+
		"\x2\x41E\x41F\x3\x2\x2\x2\x41F\x421\x5\xD4k\x2\x420\x422\x5.\x18\x2\x421"+
		"\x420\x3\x2\x2\x2\x421\x422\x3\x2\x2\x2\x422\x425\x3\x2\x2\x2\x423\x424"+
		"\as\x2\x2\x424\x426\a)\x2\x2\x425\x423\x3\x2\x2\x2\x425\x426\x3\x2\x2"+
		"\x2\x426\x428\x3\x2\x2\x2\x427\x408\x3\x2\x2\x2\x427\x412\x3\x2\x2\x2"+
		"\x428[\x3\x2\x2\x2\x429\x42A\a\x39\x2\x2\x42A\x42B\a#\x2\x2\x42B\x437"+
		"\x5\xDAn\x2\x42C\x433\a\x39\x2\x2\x42D\x434\a\x30\x2\x2\x42E\x430\a\xA2"+
		"\x2\x2\x42F\x42E\x3\x2\x2\x2\x42F\x430\x3\x2\x2\x2\x430\x431\x3\x2\x2"+
		"\x2\x431\x434\a\xA0\x2\x2\x432\x434\a\xB7\x2\x2\x433\x42D\x3\x2\x2\x2"+
		"\x433\x42F\x3\x2\x2\x2\x433\x432\x3\x2\x2\x2\x433\x434\x3\x2\x2\x2\x434"+
		"\x435\x3\x2\x2\x2\x435\x437\x5\xD4k\x2\x436\x429\x3\x2\x2\x2\x436\x42C"+
		"\x3\x2\x2\x2\x437]\x3\x2\x2\x2\x438\x439\a:\x2\x2\x439\x43A\a\xF\x2\x2"+
		"\x43A\x43F\x5\x4\x3\x2\x43B\x43C\a:\x2\x2\x43C\x43D\a\x9E\x2\x2\x43D\x43F"+
		"\x5\x4\x3\x2\x43E\x438\x3\x2\x2\x2\x43E\x43B\x3\x2\x2\x2\x43F_\x3\x2\x2"+
		"\x2\x440\x441\aV\x2\x2\x441\x443\aX\x2\x2\x442\x444\a\xA0\x2\x2\x443\x442"+
		"\x3\x2\x2\x2\x443\x444\x3\x2\x2\x2\x444\x448\x3\x2\x2\x2\x445\x449\x5"+
		"\xD4k\x2\x446\x447\aG\x2\x2\x447\x449\x5\xD2j\x2\x448\x445\x3\x2\x2\x2"+
		"\x448\x446\x3\x2\x2\x2\x449\x44B\x3\x2\x2\x2\x44A\x44C\x5\x62\x32\x2\x44B"+
		"\x44A\x3\x2\x2\x2\x44B\x44C\x3\x2\x2\x2\x44C\x44D\x3\x2\x2\x2\x44D\x44E"+
		"\x5\x64\x33\x2\x44E\x61\x3\x2\x2\x2\x44F\x450\a\xD8\x2\x2\x450\x455\x5"+
		"\xCEh\x2\x451\x452\a\xCD\x2\x2\x452\x454\x5\xCEh\x2\x453\x451\x3\x2\x2"+
		"\x2\x454\x457\x3\x2\x2\x2\x455\x453\x3\x2\x2\x2\x455\x456\x3\x2\x2\x2"+
		"\x456\x458\x3\x2\x2\x2\x457\x455\x3\x2\x2\x2\x458\x459\a\xE2\x2\x2\x459"+
		"\x63\x3\x2\x2\x2\x45A\x45B\a\x43\x2\x2\x45B\x464\x5\xEAv\x2\x45C\x464"+
		"\a\xB6\x2\x2\x45D\x45F\x5n\x38\x2\x45E\x460\a\xE3\x2\x2\x45F\x45E\x3\x2"+
		"\x2\x2\x45F\x460\x3\x2\x2\x2\x460\x461\x3\x2\x2\x2\x461\x462\a\x2\x2\x3"+
		"\x462\x464\x3\x2\x2\x2\x463\x45A\x3\x2\x2\x2\x463\x45C\x3\x2\x2\x2\x463"+
		"\x45D\x3\x2\x2\x2\x464\x65\x3\x2\x2\x2\x465\x466\a]\x2\x2\x466\x468\a"+
		"q\x2\x2\x467\x469\x5.\x18\x2\x468\x467\x3\x2\x2\x2\x468\x469\x3\x2\x2"+
		"\x2\x469\x46A\x3\x2\x2\x2\x46A\x46C\x5\x80\x41\x2\x46B\x46D\t\a\x2\x2"+
		"\x46C\x46B\x3\x2\x2\x2\x46C\x46D\x3\x2\x2\x2\x46Dg\x3\x2\x2\x2\x46E\x46F"+
		"\ay\x2\x2\x46F\x470\a\xA0\x2\x2\x470\x472\x5\xD4k\x2\x471\x473\x5.\x18"+
		"\x2\x472\x471\x3\x2\x2\x2\x472\x473\x3\x2\x2\x2\x473\x475\x3\x2\x2\x2"+
		"\x474\x476\x5\x12\n\x2\x475\x474\x3\x2\x2\x2\x475\x476\x3\x2\x2\x2\x476"+
		"\x478\x3\x2\x2\x2\x477\x479\a>\x2\x2\x478\x477\x3\x2\x2\x2\x478\x479\x3"+
		"\x2\x2\x2\x479\x47B\x3\x2\x2\x2\x47A\x47C\a\'\x2\x2\x47B\x47A\x3\x2\x2"+
		"\x2\x47B\x47C\x3\x2\x2\x2\x47Ci\x3\x2\x2\x2\x47D\x47E\a\x89\x2\x2\x47E"+
		"\x47F\a\xA0\x2\x2\x47F\x480\x5\xD4k\x2\x480\x481\a\xA8\x2\x2\x481\x489"+
		"\x5\xD4k\x2\x482\x483\a\xCD\x2\x2\x483\x484\x5\xD4k\x2\x484\x485\a\xA8"+
		"\x2\x2\x485\x486\x5\xD4k\x2\x486\x488\x3\x2\x2\x2\x487\x482\x3\x2\x2\x2"+
		"\x488\x48B\x3\x2\x2\x2\x489\x487\x3\x2\x2\x2\x489\x48A\x3\x2\x2\x2\x48A"+
		"\x48D\x3\x2\x2\x2\x48B\x489\x3\x2\x2\x2\x48C\x48E\x5.\x18\x2\x48D\x48C"+
		"\x3\x2\x2\x2\x48D\x48E\x3\x2\x2\x2\x48Ek\x3\x2\x2\x2\x48F\x491\a\xD8\x2"+
		"\x2\x490\x492\x5t;\x2\x491\x490\x3\x2\x2\x2\x491\x492\x3\x2\x2\x2\x492"+
		"\x493\x3\x2\x2\x2\x493\x494\a\x93\x2\x2\x494\x496\x5\xC0\x61\x2\x495\x497"+
		"\x5\x82\x42\x2\x496\x495\x3\x2\x2\x2\x496\x497\x3\x2\x2\x2\x497\x499\x3"+
		"\x2\x2\x2\x498\x49A\x5\x88\x45\x2\x499\x498\x3\x2\x2\x2\x499\x49A\x3\x2"+
		"\x2\x2\x49A\x49B\x3\x2\x2\x2\x49B\x49C\a\xE2\x2\x2\x49Cm\x3\x2\x2\x2\x49D"+
		"\x4A3\x5p\x39\x2\x49E\x49F\a\xB1\x2\x2\x49F\x4A0\a\x6\x2\x2\x4A0\x4A2"+
		"\x5p\x39\x2\x4A1\x49E\x3\x2\x2\x2\x4A2\x4A5\x3\x2\x2\x2\x4A3\x4A1\x3\x2"+
		"\x2\x2\x4A3\x4A4\x3\x2\x2\x2\x4A4o\x3\x2\x2\x2\x4A5\x4A3\x3\x2\x2\x2\x4A6"+
		"\x4AC\x5r:\x2\x4A7\x4A8\a\xD8\x2\x2\x4A8\x4A9\x5n\x38\x2\x4A9\x4AA\a\xE2"+
		"\x2\x2\x4AA\x4AC\x3\x2\x2\x2\x4AB\x4A6\x3\x2\x2\x2\x4AB\x4A7\x3\x2\x2"+
		"\x2\x4ACq\x3\x2\x2\x2\x4AD\x4AF\x5t;\x2\x4AE\x4AD\x3\x2\x2\x2\x4AE\x4AF"+
		"\x3\x2\x2\x2\x4AF\x4B0\x3\x2\x2\x2\x4B0\x4B2\a\x93\x2\x2\x4B1\x4B3\a\x32"+
		"\x2\x2\x4B2\x4B1\x3\x2\x2\x2\x4B2\x4B3\x3\x2\x2\x2\x4B3\x4B5\x3\x2\x2"+
		"\x2\x4B4\x4B6\x5v<\x2\x4B5\x4B4\x3\x2\x2\x2\x4B5\x4B6\x3\x2\x2\x2\x4B6"+
		"\x4B7\x3\x2\x2\x2\x4B7\x4B9\x5\xC0\x61\x2\x4B8\x4BA\x5x=\x2\x4B9\x4B8"+
		"\x3\x2\x2\x2\x4B9\x4BA\x3\x2\x2\x2\x4BA\x4BC\x3\x2\x2\x2\x4BB\x4BD\x5"+
		"z>\x2\x4BC\x4BB\x3\x2\x2\x2\x4BC\x4BD\x3\x2\x2\x2\x4BD\x4BF\x3\x2\x2\x2"+
		"\x4BE\x4C0\x5|?\x2\x4BF\x4BE\x3\x2\x2\x2\x4BF\x4C0\x3\x2\x2\x2\x4C0\x4C2"+
		"\x3\x2\x2\x2\x4C1\x4C3\x5~@\x2\x4C2\x4C1\x3\x2\x2\x2\x4C2\x4C3\x3\x2\x2"+
		"\x2\x4C3\x4C5\x3\x2\x2\x2\x4C4\x4C6\x5\x80\x41\x2\x4C5\x4C4\x3\x2\x2\x2"+
		"\x4C5\x4C6\x3\x2\x2\x2\x4C6\x4C8\x3\x2\x2\x2\x4C7\x4C9\x5\x82\x42\x2\x4C8"+
		"\x4C7\x3\x2\x2\x2\x4C8\x4C9\x3\x2\x2\x2\x4C9\x4CC\x3\x2\x2\x2\x4CA\x4CB"+
		"\a\xBE\x2\x2\x4CB\x4CD\t\b\x2\x2\x4CC\x4CA\x3\x2\x2\x2\x4CC\x4CD\x3\x2"+
		"\x2\x2\x4CD\x4D0\x3\x2\x2\x2\x4CE\x4CF\a\xBE\x2\x2\x4CF\x4D1\a\xAA\x2"+
		"\x2\x4D0\x4CE\x3\x2\x2\x2\x4D0\x4D1\x3\x2\x2\x2\x4D1\x4D3\x3\x2\x2\x2"+
		"\x4D2\x4D4\x5\x84\x43\x2\x4D3\x4D2\x3\x2\x2\x2\x4D3\x4D4\x3\x2\x2\x2\x4D4"+
		"\x4D6\x3\x2\x2\x2\x4D5\x4D7\x5\x86\x44\x2\x4D6\x4D5\x3\x2\x2\x2\x4D6\x4D7"+
		"\x3\x2\x2\x2\x4D7\x4D9\x3\x2\x2\x2\x4D8\x4DA\x5\x8A\x46\x2\x4D9\x4D8\x3"+
		"\x2\x2\x2\x4D9\x4DA\x3\x2\x2\x2\x4DA\x4DC\x3\x2\x2\x2\x4DB\x4DD\x5\x8C"+
		"G\x2\x4DC\x4DB\x3\x2\x2\x2\x4DC\x4DD\x3\x2\x2\x2\x4DD\x4DF\x3\x2\x2\x2"+
		"\x4DE\x4E0\x5\x8EH\x2\x4DF\x4DE\x3\x2\x2\x2\x4DF\x4E0\x3\x2\x2\x2\x4E0"+
		"s\x3\x2\x2\x2\x4E1\x4E2\a\xBE\x2\x2\x4E2\x4E3\x5\xC0\x61\x2\x4E3u\x3\x2"+
		"\x2\x2\x4E4\x4E5\a\xA9\x2\x2\x4E5\x4E8\a\xC5\x2\x2\x4E6\x4E7\a\xBE\x2"+
		"\x2\x4E7\x4E9\a\xA5\x2\x2\x4E8\x4E6\x3\x2\x2\x2\x4E8\x4E9\x3\x2\x2\x2"+
		"\x4E9w\x3\x2\x2\x2\x4EA\x4EB\a\x45\x2\x2\x4EB\x4EC\x5\x90I\x2\x4ECy\x3"+
		"\x2\x2\x2\x4ED\x4EF\t\t\x2\x2\x4EE\x4ED\x3\x2\x2\x2\x4EE\x4EF\x3\x2\x2"+
		"\x2\x4EF\x4F0\x3\x2\x2\x2\x4F0\x4F1\a\v\x2\x2\x4F1\x4F2\a[\x2\x2\x4F2"+
		"\x4F3\x5\xC0\x61\x2\x4F3{\x3\x2\x2\x2\x4F4\x4F5\a\xBD\x2\x2\x4F5\x4F6"+
		"\x5\xEAv\x2\x4F6\x4F7\a\f\x2\x2\x4F7\x4F8\a\xD8\x2\x2\x4F8\x4F9\x5\xA6"+
		"T\x2\x4F9\x4FA\a\xE2\x2\x2\x4FA}\x3\x2\x2\x2\x4FB\x4FC\a\x82\x2\x2\x4FC"+
		"\x4FD\x5\xC4\x63\x2\x4FD\x7F\x3\x2\x2\x2\x4FE\x4FF\a\xBC\x2\x2\x4FF\x500"+
		"\x5\xC4\x63\x2\x500\x81\x3\x2\x2\x2\x501\x502\aJ\x2\x2\x502\x509\a\x14"+
		"\x2\x2\x503\x504\t\b\x2\x2\x504\x505\a\xD8\x2\x2\x505\x506\x5\xC0\x61"+
		"\x2\x506\x507\a\xE2\x2\x2\x507\x50A\x3\x2\x2\x2\x508\x50A\x5\xC0\x61\x2"+
		"\x509\x503\x3\x2\x2\x2\x509\x508\x3\x2\x2\x2\x50A\x83\x3\x2\x2\x2\x50B"+
		"\x50C\aK\x2\x2\x50C\x50D\x5\xC4\x63\x2\x50D\x85\x3\x2\x2\x2\x50E\x50F"+
		"\a{\x2\x2\x50F\x510\a\x14\x2\x2\x510\x511\x5\x9CO\x2\x511\x87\x3\x2\x2"+
		"\x2\x512\x513\a{\x2\x2\x513\x514\a\x14\x2\x2\x514\x515\x5\xC0\x61\x2\x515"+
		"\x89\x3\x2\x2\x2\x516\x517\a\x64\x2\x2\x517\x518\x5\x9AN\x2\x518\x519"+
		"\a\x14\x2\x2\x519\x51A\x5\xC0\x61\x2\x51A\x8B\x3\x2\x2\x2\x51B\x51C\a"+
		"\x64\x2\x2\x51C\x51F\x5\x9AN\x2\x51D\x51E\a\xBE\x2\x2\x51E\x520\a\xA5"+
		"\x2\x2\x51F\x51D\x3\x2\x2\x2\x51F\x520\x3\x2\x2\x2\x520\x8D\x3\x2\x2\x2"+
		"\x521\x522\a\x97\x2\x2\x522\x523\x5\xA2R\x2\x523\x8F\x3\x2\x2\x2\x524"+
		"\x525\bI\x1\x2\x525\x527\x5\xD0i\x2\x526\x528\a>\x2\x2\x527\x526\x3\x2"+
		"\x2\x2\x527\x528\x3\x2\x2\x2\x528\x52A\x3\x2\x2\x2\x529\x52B\x5\x98M\x2"+
		"\x52A\x529\x3\x2\x2\x2\x52A\x52B\x3\x2\x2\x2\x52B\x531\x3\x2\x2\x2\x52C"+
		"\x52D\a\xD8\x2\x2\x52D\x52E\x5\x90I\x2\x52E\x52F\a\xE2\x2\x2\x52F\x531"+
		"\x3\x2\x2\x2\x530\x524\x3\x2\x2\x2\x530\x52C\x3\x2\x2\x2\x531\x543\x3"+
		"\x2\x2\x2\x532\x533\f\x5\x2\x2\x533\x534\x5\x94K\x2\x534\x535\x5\x90I"+
		"\x6\x535\x542\x3\x2\x2\x2\x536\x538\f\x6\x2\x2\x537\x539\t\n\x2\x2\x538"+
		"\x537\x3\x2\x2\x2\x538\x539\x3\x2\x2\x2\x539\x53B\x3\x2\x2\x2\x53A\x53C"+
		"\x5\x92J\x2\x53B\x53A\x3\x2\x2\x2\x53B\x53C\x3\x2\x2\x2\x53C\x53D\x3\x2"+
		"\x2\x2\x53D\x53E\a[\x2\x2\x53E\x53F\x5\x90I\x2\x53F\x540\x5\x96L\x2\x540"+
		"\x542\x3\x2\x2\x2\x541\x532\x3\x2\x2\x2\x541\x536\x3\x2\x2\x2\x542\x545"+
		"\x3\x2\x2\x2\x543\x541\x3\x2\x2\x2\x543\x544\x3\x2\x2\x2\x544\x91\x3\x2"+
		"\x2\x2\x545\x543\x3\x2\x2\x2\x546\x548\t\v\x2\x2\x547\x546\x3\x2\x2\x2"+
		"\x547\x548\x3\x2\x2\x2\x548\x549\x3\x2\x2\x2\x549\x550\aU\x2\x2\x54A\x54C"+
		"\aU\x2\x2\x54B\x54D\t\v\x2\x2\x54C\x54B\x3\x2\x2\x2\x54C\x54D\x3\x2\x2"+
		"\x2\x54D\x550\x3\x2\x2\x2\x54E\x550\t\v\x2\x2\x54F\x547\x3\x2\x2\x2\x54F"+
		"\x54A\x3\x2\x2\x2\x54F\x54E\x3\x2\x2\x2\x550\x572\x3\x2\x2\x2\x551\x553"+
		"\t\f\x2\x2\x552\x551\x3\x2\x2\x2\x552\x553\x3\x2\x2\x2\x553\x554\x3\x2"+
		"\x2\x2\x554\x556\t\r\x2\x2\x555\x557\a|\x2\x2\x556\x555\x3\x2\x2\x2\x556"+
		"\x557\x3\x2\x2\x2\x557\x560\x3\x2\x2\x2\x558\x55A\t\r\x2\x2\x559\x55B"+
		"\a|\x2\x2\x55A\x559\x3\x2\x2\x2\x55A\x55B\x3\x2\x2\x2\x55B\x55D\x3\x2"+
		"\x2\x2\x55C\x55E\t\f\x2\x2\x55D\x55C\x3\x2\x2\x2\x55D\x55E\x3\x2\x2\x2"+
		"\x55E\x560\x3\x2\x2\x2\x55F\x552\x3\x2\x2\x2\x55F\x558\x3\x2\x2\x2\x560"+
		"\x572\x3\x2\x2\x2\x561\x563\t\xE\x2\x2\x562\x561\x3\x2\x2\x2\x562\x563"+
		"\x3\x2\x2\x2\x563\x564\x3\x2\x2\x2\x564\x566\a\x46\x2\x2\x565\x567\a|"+
		"\x2\x2\x566\x565\x3\x2\x2\x2\x566\x567\x3\x2\x2\x2\x567\x570\x3\x2\x2"+
		"\x2\x568\x56A\a\x46\x2\x2\x569\x56B\a|\x2\x2\x56A\x569\x3\x2\x2\x2\x56A"+
		"\x56B\x3\x2\x2\x2\x56B\x56D\x3\x2\x2\x2\x56C\x56E\t\xE\x2\x2\x56D\x56C"+
		"\x3\x2\x2\x2\x56D\x56E\x3\x2\x2\x2\x56E\x570\x3\x2\x2\x2\x56F\x562\x3"+
		"\x2\x2\x2\x56F\x568\x3\x2\x2\x2\x570\x572\x3\x2\x2\x2\x571\x54F\x3\x2"+
		"\x2\x2\x571\x55F\x3\x2\x2\x2\x571\x56F\x3\x2\x2\x2\x572\x93\x3\x2\x2\x2"+
		"\x573\x575\t\n\x2\x2\x574\x573\x3\x2\x2\x2\x574\x575\x3\x2\x2\x2\x575"+
		"\x576\x3\x2\x2\x2\x576\x577\a \x2\x2\x577\x57A\a[\x2\x2\x578\x57A\a\xCD"+
		"\x2\x2\x579\x574\x3\x2\x2\x2\x579\x578\x3\x2\x2\x2\x57A\x95\x3\x2\x2\x2"+
		"\x57B\x57C\ax\x2\x2\x57C\x585\x5\xC0\x61\x2\x57D\x57E\a\xB4\x2\x2\x57E"+
		"\x57F\a\xD8\x2\x2\x57F\x580\x5\xC0\x61\x2\x580\x581\a\xE2\x2\x2\x581\x585"+
		"\x3\x2\x2\x2\x582\x583\a\xB4\x2\x2\x583\x585\x5\xC0\x61\x2\x584\x57B\x3"+
		"\x2\x2\x2\x584\x57D\x3\x2\x2\x2\x584\x582\x3\x2\x2\x2\x585\x97\x3\x2\x2"+
		"\x2\x586\x587\a\x91\x2\x2\x587\x58A\x5\xA0Q\x2\x588\x589\aw\x2\x2\x589"+
		"\x58B\x5\xA0Q\x2\x58A\x588\x3\x2\x2\x2\x58A\x58B\x3\x2\x2\x2\x58B\x99"+
		"\x3\x2\x2\x2\x58C\x58F\x5\xC4\x63\x2\x58D\x58E\t\xF\x2\x2\x58E\x590\x5"+
		"\xC4\x63\x2\x58F\x58D\x3\x2\x2\x2\x58F\x590\x3\x2\x2\x2\x590\x9B\x3\x2"+
		"\x2\x2\x591\x596\x5\x9EP\x2\x592\x593\a\xCD\x2\x2\x593\x595\x5\x9EP\x2"+
		"\x594\x592\x3\x2\x2\x2\x595\x598\x3\x2\x2\x2\x596\x594\x3\x2\x2\x2\x596"+
		"\x597\x3\x2\x2\x2\x597\x9D\x3\x2\x2\x2\x598\x596\x3\x2\x2\x2\x599\x59B"+
		"\x5\xC4\x63\x2\x59A\x59C\t\x10\x2\x2\x59B\x59A\x3\x2\x2\x2\x59B\x59C\x3"+
		"\x2\x2\x2\x59C\x59F\x3\x2\x2\x2\x59D\x59E\av\x2\x2\x59E\x5A0\t\x11\x2"+
		"\x2\x59F\x59D\x3\x2\x2\x2\x59F\x5A0\x3\x2\x2\x2\x5A0\x5A3\x3\x2\x2\x2"+
		"\x5A1\x5A2\a\x1B\x2\x2\x5A2\x5A4\a\xC7\x2\x2\x5A3\x5A1\x3\x2\x2\x2\x5A3"+
		"\x5A4\x3\x2\x2\x2\x5A4\x9F\x3\x2\x2\x2\x5A5\x5A8\x5\xDEp\x2\x5A6\x5A7"+
		"\a\xE4\x2\x2\x5A7\x5A9\x5\xDEp\x2\x5A8\x5A6\x3\x2\x2\x2\x5A8\x5A9\x3\x2"+
		"\x2\x2\x5A9\xA1\x3\x2\x2\x2\x5AA\x5AF\x5\xA4S\x2\x5AB\x5AC\a\xCD\x2\x2"+
		"\x5AC\x5AE\x5\xA4S\x2\x5AD\x5AB\x3\x2\x2\x2\x5AE\x5B1\x3\x2\x2\x2\x5AF"+
		"\x5AD\x3\x2\x2\x2\x5AF\x5B0\x3\x2\x2\x2\x5B0\xA3\x3\x2\x2\x2\x5B1\x5AF"+
		"\x3\x2\x2\x2\x5B2\x5B3\x5\xEAv\x2\x5B3\x5B4\a\xD2\x2\x2\x5B4\x5B5\x5\xE0"+
		"q\x2\x5B5\xA5\x3\x2\x2\x2\x5B6\x5B8\x5\xA8U\x2\x5B7\x5B6\x3\x2\x2\x2\x5B7"+
		"\x5B8\x3\x2\x2\x2\x5B8\x5BA\x3\x2\x2\x2\x5B9\x5BB\x5\xAAV\x2\x5BA\x5B9"+
		"\x3\x2\x2\x2\x5BA\x5BB\x3\x2\x2\x2\x5BB\x5BD\x3\x2\x2\x2\x5BC\x5BE\x5"+
		"\xACW\x2\x5BD\x5BC\x3\x2\x2\x2\x5BD\x5BE\x3\x2\x2\x2\x5BE\xA7\x3\x2\x2"+
		"\x2\x5BF\x5C0\a\x7F\x2\x2\x5C0\x5C1\a\x14\x2\x2\x5C1\x5C2\x5\xC0\x61\x2"+
		"\x5C2\xA9\x3\x2\x2\x2\x5C3\x5C4\a{\x2\x2\x5C4\x5C5\a\x14\x2\x2\x5C5\x5C6"+
		"\x5\x9CO\x2\x5C6\xAB\x3\x2\x2\x2\x5C7\x5C8\t\x12\x2\x2\x5C8\x5C9\x5\xAE"+
		"X\x2\x5C9\xAD\x3\x2\x2\x2\x5CA\x5D1\x5\xB0Y\x2\x5CB\x5CC\a\x12\x2\x2\x5CC"+
		"\x5CD\x5\xB0Y\x2\x5CD\x5CE\a\b\x2\x2\x5CE\x5CF\x5\xB0Y\x2\x5CF\x5D1\x3"+
		"\x2\x2\x2\x5D0\x5CA\x3\x2\x2\x2\x5D0\x5CB\x3\x2\x2\x2\x5D1\xAF\x3\x2\x2"+
		"\x2\x5D2\x5D3\a\"\x2\x2\x5D3\x5DF\a\x8F\x2\x2\x5D4\x5D5\a\xB0\x2\x2\x5D5"+
		"\x5DF\a\x81\x2\x2\x5D6\x5D7\a\xB0\x2\x2\x5D7\x5DF\a\x41\x2\x2\x5D8\x5D9"+
		"\x5\xDEp\x2\x5D9\x5DA\a\x81\x2\x2\x5DA\x5DF\x3\x2\x2\x2\x5DB\x5DC\x5\xDE"+
		"p\x2\x5DC\x5DD\a\x41\x2\x2\x5DD\x5DF\x3\x2\x2\x2\x5DE\x5D2\x3\x2\x2\x2"+
		"\x5DE\x5D4\x3\x2\x2\x2\x5DE\x5D6\x3\x2\x2\x2\x5DE\x5D8\x3\x2\x2\x2\x5DE"+
		"\x5DB\x3\x2\x2\x2\x5DF\xB1\x3\x2\x2\x2\x5E0\x5E1\a\x96\x2\x2\x5E1\x5E2"+
		"\x5\xA2R\x2\x5E2\xB3\x3\x2\x2\x2\x5E3\x5E4\a\x98\x2\x2\x5E4\x5E5\a\x1F"+
		"\x2\x2\x5E5\x5E6\a#\x2\x2\x5E6\x60E\x5\xDAn\x2\x5E7\x5E8\a\x98\x2\x2\x5E8"+
		"\x5E9\a\x1F\x2\x2\x5E9\x5EA\a\x30\x2\x2\x5EA\x60E\x5\xD4k\x2\x5EB\x5EC"+
		"\a\x98\x2\x2\x5EC\x5EE\a\x1F\x2\x2\x5ED\x5EF\a\xA2\x2\x2\x5EE\x5ED\x3"+
		"\x2\x2\x2\x5EE\x5EF\x3\x2\x2\x2\x5EF\x5F1\x3\x2\x2\x2\x5F0\x5F2\a\xA0"+
		"\x2\x2\x5F1\x5F0\x3\x2\x2\x2\x5F1\x5F2\x3\x2\x2\x2\x5F2\x5F3\x3\x2\x2"+
		"\x2\x5F3\x60E\x5\xD4k\x2\x5F4\x5F5\a\x98\x2\x2\x5F5\x60E\a$\x2\x2\x5F6"+
		"\x5F7\a\x98\x2\x2\x5F7\x5FA\a/\x2\x2\x5F8\x5F9\a\x45\x2\x2\x5F9\x5FB\x5"+
		"\xDAn\x2\x5FA\x5F8\x3\x2\x2\x2\x5FA\x5FB\x3\x2\x2\x2\x5FB\x60E\x3\x2\x2"+
		"\x2\x5FC\x5FE\a\x98\x2\x2\x5FD\x5FF\a\xA2\x2\x2\x5FE\x5FD\x3\x2\x2\x2"+
		"\x5FE\x5FF\x3\x2\x2\x2\x5FF\x600\x3\x2\x2\x2\x600\x603\a\xA1\x2\x2\x601"+
		"\x602\t\x13\x2\x2\x602\x604\x5\xDAn\x2\x603\x601\x3\x2\x2\x2\x603\x604"+
		"\x3\x2\x2\x2\x604\x608\x3\x2\x2\x2\x605\x606\a\x63\x2\x2\x606\x609\a\xC7"+
		"\x2\x2\x607\x609\x5\x80\x41\x2\x608\x605\x3\x2\x2\x2\x608\x607\x3\x2\x2"+
		"\x2\x608\x609\x3\x2\x2\x2\x609\x60B\x3\x2\x2\x2\x60A\x60C\x5\x8CG\x2\x60B"+
		"\x60A\x3\x2\x2\x2\x60B\x60C\x3\x2\x2\x2\x60C\x60E\x3\x2\x2\x2\x60D\x5E3"+
		"\x3\x2\x2\x2\x60D\x5E7\x3\x2\x2\x2\x60D\x5EB\x3\x2\x2\x2\x60D\x5F4\x3"+
		"\x2\x2\x2\x60D\x5F6\x3\x2\x2\x2\x60D\x5FC\x3\x2\x2\x2\x60E\xB5\x3\x2\x2"+
		"\x2\x60F\x610\a\x9F\x2\x2\x610\x611\a@\x2\x2\x611\x612\a\x33\x2\x2\x612"+
		"\x632\x5\xD4k\x2\x613\x614\a\x9F\x2\x2\x614\x615\a@\x2\x2\x615\x632\a"+
		"g\x2\x2\x616\x617\a\x9F\x2\x2\x617\x618\a\x87\x2\x2\x618\x632\a/\x2\x2"+
		"\x619\x61A\a\x9F\x2\x2\x61A\x61B\a\x87\x2\x2\x61B\x61C\a\x30\x2\x2\x61C"+
		"\x632\x5\xD4k\x2\x61D\x61E\a\x9F\x2\x2\x61E\x626\t\x14\x2\x2\x61F\x620"+
		"\a\x33\x2\x2\x620\x627\a\x95\x2\x2\x621\x627\a=\x2\x2\x622\x624\a\xAE"+
		"\x2\x2\x623\x622\x3\x2\x2\x2\x623\x624\x3\x2\x2\x2\x624\x625\x3\x2\x2"+
		"\x2\x625\x627\ak\x2\x2\x626\x61F\x3\x2\x2\x2\x626\x621\x3\x2\x2\x2\x626"+
		"\x623\x3\x2\x2\x2\x627\x628\x3\x2\x2\x2\x628\x632\x5\xD4k\x2\x629\x62A"+
		"\a\x9F\x2\x2\x62A\x62B\t\x14\x2\x2\x62B\x62C\a\x8C\x2\x2\x62C\x632\a\x95"+
		"\x2\x2\x62D\x62E\a\x9F\x2\x2\x62E\x62F\a\x9D\x2\x2\x62F\x630\a\x8B\x2"+
		"\x2\x630\x632\x5\xD4k\x2\x631\x60F\x3\x2\x2\x2\x631\x613\x3\x2\x2\x2\x631"+
		"\x616\x3\x2\x2\x2\x631\x619\x3\x2\x2\x2\x631\x61D\x3\x2\x2\x2\x631\x629"+
		"\x3\x2\x2\x2\x631\x62D\x3\x2\x2\x2\x632\xB7\x3\x2\x2\x2\x633\x635\a\xAD"+
		"\x2\x2\x634\x636\a\xA2\x2\x2\x635\x634\x3\x2\x2\x2\x635\x636\x3\x2\x2"+
		"\x2\x636\x638\x3\x2\x2\x2\x637\x639\a\xA0\x2\x2\x638\x637\x3\x2\x2\x2"+
		"\x638\x639\x3\x2\x2\x2\x639\x63C\x3\x2\x2\x2\x63A\x63B\aO\x2\x2\x63B\x63D"+
		"\a\x39\x2\x2\x63C\x63A\x3\x2\x2\x2\x63C\x63D\x3\x2\x2\x2\x63D\x63E\x3"+
		"\x2\x2\x2\x63E\x640\x5\xD4k\x2\x63F\x641\x5.\x18\x2\x640\x63F\x3\x2\x2"+
		"\x2\x640\x641\x3\x2\x2\x2\x641\xB9\x3\x2\x2\x2\x642\x643\a\xB3\x2\x2\x643"+
		"\x644\x5\xDAn\x2\x644\xBB\x3\x2\x2\x2\x645\x646\a\xB9\x2\x2\x646\x648"+
		"\x5\xD4k\x2\x647\x649\a\x38\x2\x2\x648\x647\x3\x2\x2\x2\x648\x649\x3\x2"+
		"\x2\x2\x649\x64C\x3\x2\x2\x2\x64A\x64B\a\x64\x2\x2\x64B\x64D\a\xC5\x2"+
		"\x2\x64C\x64A\x3\x2\x2\x2\x64C\x64D\x3\x2\x2\x2\x64D\xBD\x3\x2\x2\x2\x64E"+
		"\x67E\x5\xEAv\x2\x64F\x650\x5\xEAv\x2\x650\x651\a\xD8\x2\x2\x651\x652"+
		"\x5\xEAv\x2\x652\x659\x5\xBE`\x2\x653\x654\a\xCD\x2\x2\x654\x655\x5\xEA"+
		"v\x2\x655\x656\x5\xBE`\x2\x656\x658\x3\x2\x2\x2\x657\x653\x3\x2\x2\x2"+
		"\x658\x65B\x3\x2\x2\x2\x659\x657\x3\x2\x2\x2\x659\x65A\x3\x2\x2\x2\x65A"+
		"\x65C\x3\x2\x2\x2\x65B\x659\x3\x2\x2\x2\x65C\x65D\a\xE2\x2\x2\x65D\x67E"+
		"\x3\x2\x2\x2\x65E\x65F\x5\xEAv\x2\x65F\x660\a\xD8\x2\x2\x660\x665\x5\xEE"+
		"x\x2\x661\x662\a\xCD\x2\x2\x662\x664\x5\xEEx\x2\x663\x661\x3\x2\x2\x2"+
		"\x664\x667\x3\x2\x2\x2\x665\x663\x3\x2\x2\x2\x665\x666\x3\x2\x2\x2\x666"+
		"\x668\x3\x2\x2\x2\x667\x665\x3\x2\x2\x2\x668\x669\a\xE2\x2\x2\x669\x67E"+
		"\x3\x2\x2\x2\x66A\x66B\x5\xEAv\x2\x66B\x66C\a\xD8\x2\x2\x66C\x671\x5\xBE"+
		"`\x2\x66D\x66E\a\xCD\x2\x2\x66E\x670\x5\xBE`\x2\x66F\x66D\x3\x2\x2\x2"+
		"\x670\x673\x3\x2\x2\x2\x671\x66F\x3\x2\x2\x2\x671\x672\x3\x2\x2\x2\x672"+
		"\x674\x3\x2\x2\x2\x673\x671\x3\x2\x2\x2\x674\x675\a\xE2\x2\x2\x675\x67E"+
		"\x3\x2\x2\x2\x676\x677\x5\xEAv\x2\x677\x679\a\xD8\x2\x2\x678\x67A\x5\xC0"+
		"\x61\x2\x679\x678\x3\x2\x2\x2\x679\x67A\x3\x2\x2\x2\x67A\x67B\x3\x2\x2"+
		"\x2\x67B\x67C\a\xE2\x2\x2\x67C\x67E\x3\x2\x2\x2\x67D\x64E\x3\x2\x2\x2"+
		"\x67D\x64F\x3\x2\x2\x2\x67D\x65E\x3\x2\x2\x2\x67D\x66A\x3\x2\x2\x2\x67D"+
		"\x676\x3\x2\x2\x2\x67E\xBF\x3\x2\x2\x2\x67F\x684\x5\xC2\x62\x2\x680\x681"+
		"\a\xCD\x2\x2\x681\x683\x5\xC2\x62\x2\x682\x680\x3\x2\x2\x2\x683\x686\x3"+
		"\x2\x2\x2\x684\x682\x3\x2\x2\x2\x684\x685\x3\x2\x2\x2\x685\xC1\x3\x2\x2"+
		"\x2\x686\x684\x3\x2\x2\x2\x687\x688\x5\xD4k\x2\x688\x689\a\xD0\x2\x2\x689"+
		"\x68B\x3\x2\x2\x2\x68A\x687\x3\x2\x2\x2\x68A\x68B\x3\x2\x2\x2\x68B\x68C"+
		"\x3\x2\x2\x2\x68C\x693\a\xC9\x2\x2\x68D\x68E\a\xD8\x2\x2\x68E\x68F\x5"+
		"n\x38\x2\x68F\x690\a\xE2\x2\x2\x690\x693\x3\x2\x2\x2\x691\x693\x5\xC4"+
		"\x63\x2\x692\x68A\x3\x2\x2\x2\x692\x68D\x3\x2\x2\x2\x692\x691\x3\x2\x2"+
		"\x2\x693\xC3\x3\x2\x2\x2\x694\x695\b\x63\x1\x2\x695\x697\a\x15\x2\x2\x696"+
		"\x698\x5\xC4\x63\x2\x697\x696\x3\x2\x2\x2\x697\x698\x3\x2\x2\x2\x698\x69E"+
		"\x3\x2\x2\x2\x699\x69A\a\xBB\x2\x2\x69A\x69B\x5\xC4\x63\x2\x69B\x69C\a"+
		"\xA4\x2\x2\x69C\x69D\x5\xC4\x63\x2\x69D\x69F\x3\x2\x2\x2\x69E\x699\x3"+
		"\x2\x2\x2\x69F\x6A0\x3\x2\x2\x2\x6A0\x69E\x3\x2\x2\x2\x6A0\x6A1\x3\x2"+
		"\x2\x2\x6A1\x6A4\x3\x2\x2\x2\x6A2\x6A3\a\x35\x2\x2\x6A3\x6A5\x5\xC4\x63"+
		"\x2\x6A4\x6A2\x3\x2\x2\x2\x6A4\x6A5\x3\x2\x2\x2\x6A5\x6A6\x3\x2\x2\x2"+
		"\x6A6\x6A7\a\x36\x2\x2\x6A7\x716\x3\x2\x2\x2\x6A8\x6A9\a\x16\x2\x2\x6A9"+
		"\x6AA\a\xD8\x2\x2\x6AA\x6AB\x5\xC4\x63\x2\x6AB\x6AC\a\f\x2\x2\x6AC\x6AD"+
		"\x5\xBE`\x2\x6AD\x6AE\a\xE2\x2\x2\x6AE\x716\x3\x2\x2\x2\x6AF\x6B0\a%\x2"+
		"\x2\x6B0\x716\a\xC7\x2\x2\x6B1\x6B2\a<\x2\x2\x6B2\x6B3\a\xD8\x2\x2\x6B3"+
		"\x6B4\x5\xE2r\x2\x6B4\x6B5\a\x45\x2\x2\x6B5\x6B6\x5\xC4\x63\x2\x6B6\x6B7"+
		"\a\xE2\x2\x2\x6B7\x716\x3\x2\x2\x2\x6B8\x6B9\aW\x2\x2\x6B9\x6BA\x5\xC4"+
		"\x63\x2\x6BA\x6BB\x5\xE2r\x2\x6BB\x716\x3\x2\x2\x2\x6BC\x6BD\a\x9C\x2"+
		"\x2\x6BD\x6BE\a\xD8\x2\x2\x6BE\x6BF\x5\xC4\x63\x2\x6BF\x6C0\a\x45\x2\x2"+
		"\x6C0\x6C3\x5\xC4\x63\x2\x6C1\x6C2\a\x42\x2\x2\x6C2\x6C4\x5\xC4\x63\x2"+
		"\x6C3\x6C1\x3\x2\x2\x2\x6C3\x6C4\x3\x2\x2\x2\x6C4\x6C5\x3\x2\x2\x2\x6C5"+
		"\x6C6\a\xE2\x2\x2\x6C6\x716\x3\x2\x2\x2\x6C7\x6C8\a\xA7\x2\x2\x6C8\x716"+
		"\a\xC7\x2\x2\x6C9\x6CA\a\xAC\x2\x2\x6CA\x6CB\a\xD8\x2\x2\x6CB\x6CC\t\x15"+
		"\x2\x2\x6CC\x6CD\a\xC7\x2\x2\x6CD\x6CE\a\x45\x2\x2\x6CE\x6CF\x5\xC4\x63"+
		"\x2\x6CF\x6D0\a\xE2\x2\x2\x6D0\x716\x3\x2\x2\x2\x6D1\x6D2\x5\xEAv\x2\x6D2"+
		"\x6D4\a\xD8\x2\x2\x6D3\x6D5\x5\xC0\x61\x2\x6D4\x6D3\x3\x2\x2\x2\x6D4\x6D5"+
		"\x3\x2\x2\x2\x6D5\x6D6\x3\x2\x2\x2\x6D6\x6D7\a\xE2\x2\x2\x6D7\x6D8\x3"+
		"\x2\x2\x2\x6D8\x6D9\a~\x2\x2\x6D9\x6DA\a\xD8\x2\x2\x6DA\x6DB\x5\xA6T\x2"+
		"\x6DB\x6DC\a\xE2\x2\x2\x6DC\x716\x3\x2\x2\x2\x6DD\x6DE\x5\xEAv\x2\x6DE"+
		"\x6E0\a\xD8\x2\x2\x6DF\x6E1\x5\xC0\x61\x2\x6E0\x6DF\x3\x2\x2\x2\x6E0\x6E1"+
		"\x3\x2\x2\x2\x6E1\x6E2\x3\x2\x2\x2\x6E2\x6E3\a\xE2\x2\x2\x6E3\x6E4\x3"+
		"\x2\x2\x2\x6E4\x6E5\a~\x2\x2\x6E5\x6E6\x5\xEAv\x2\x6E6\x716\x3\x2\x2\x2"+
		"\x6E7\x6ED\x5\xEAv\x2\x6E8\x6EA\a\xD8\x2\x2\x6E9\x6EB\x5\xC0\x61\x2\x6EA"+
		"\x6E9\x3\x2\x2\x2\x6EA\x6EB\x3\x2\x2\x2\x6EB\x6EC\x3\x2\x2\x2\x6EC\x6EE"+
		"\a\xE2\x2\x2\x6ED\x6E8\x3\x2\x2\x2\x6ED\x6EE\x3\x2\x2\x2\x6EE\x6EF\x3"+
		"\x2\x2\x2\x6EF\x6F1\a\xD8\x2\x2\x6F0\x6F2\a\x32\x2\x2\x6F1\x6F0\x3\x2"+
		"\x2\x2\x6F1\x6F2\x3\x2\x2\x2\x6F2\x6F4\x3\x2\x2\x2\x6F3\x6F5\x5\xC6\x64"+
		"\x2\x6F4\x6F3\x3\x2\x2\x2\x6F4\x6F5\x3\x2\x2\x2\x6F5\x6F6\x3\x2\x2\x2"+
		"\x6F6\x6F7\a\xE2\x2\x2\x6F7\x716\x3\x2\x2\x2\x6F8\x716\x5\xE0q\x2\x6F9"+
		"\x6FA\a\xCF\x2\x2\x6FA\x716\x5\xC4\x63\x13\x6FB\x6FC\at\x2\x2\x6FC\x716"+
		"\x5\xC4\x63\xE\x6FD\x6FE\x5\xD4k\x2\x6FE\x6FF\a\xD0\x2\x2\x6FF\x701\x3"+
		"\x2\x2\x2\x700\x6FD\x3\x2\x2\x2\x700\x701\x3\x2\x2\x2\x701\x702\x3\x2"+
		"\x2\x2\x702\x716\a\xC9\x2\x2\x703\x704\a\xD8\x2\x2\x704\x705\x5n\x38\x2"+
		"\x705\x706\a\xE2\x2\x2\x706\x716\x3\x2\x2\x2\x707\x708\a\xD8\x2\x2\x708"+
		"\x709\x5\xC4\x63\x2\x709\x70A\a\xE2\x2\x2\x70A\x716\x3\x2\x2\x2\x70B\x70C"+
		"\a\xD8\x2\x2\x70C\x70D\x5\xC0\x61\x2\x70D\x70E\a\xE2\x2\x2\x70E\x716\x3"+
		"\x2\x2\x2\x70F\x711\a\xD6\x2\x2\x710\x712\x5\xC0\x61\x2\x711\x710\x3\x2"+
		"\x2\x2\x711\x712\x3\x2\x2\x2\x712\x713\x3\x2\x2\x2\x713\x716\a\xE1\x2"+
		"\x2\x714\x716\x5\xCCg\x2\x715\x694\x3\x2\x2\x2\x715\x6A8\x3\x2\x2\x2\x715"+
		"\x6AF\x3\x2\x2\x2\x715\x6B1\x3\x2\x2\x2\x715\x6B8\x3\x2\x2\x2\x715\x6BC"+
		"\x3\x2\x2\x2\x715\x6C7\x3\x2\x2\x2\x715\x6C9\x3\x2\x2\x2\x715\x6D1\x3"+
		"\x2\x2\x2\x715\x6DD\x3\x2\x2\x2\x715\x6E7\x3\x2\x2\x2\x715\x6F8\x3\x2"+
		"\x2\x2\x715\x6F9\x3\x2\x2\x2\x715\x6FB\x3\x2\x2\x2\x715\x700\x3\x2\x2"+
		"\x2\x715\x703\x3\x2\x2\x2\x715\x707\x3\x2\x2\x2\x715\x70B\x3\x2\x2\x2"+
		"\x715\x70F\x3\x2\x2\x2\x715\x714\x3\x2\x2\x2\x716\x75E\x3\x2\x2\x2\x717"+
		"\x718\f\x12\x2\x2\x718\x719\t\x16\x2\x2\x719\x75D\x5\xC4\x63\x13\x71A"+
		"\x71B\f\x11\x2\x2\x71B\x71C\t\x17\x2\x2\x71C\x75D\x5\xC4\x63\x12\x71D"+
		"\x730\f\x10\x2\x2\x71E\x731\a\xD1\x2\x2\x71F\x731\a\xD2\x2\x2\x720\x731"+
		"\a\xDA\x2\x2\x721\x731\a\xD7\x2\x2\x722\x731\a\xD3\x2\x2\x723\x731\a\xD9"+
		"\x2\x2\x724\x731\a\xD4\x2\x2\x725\x727\aH\x2\x2\x726\x725\x3\x2\x2\x2"+
		"\x726\x727\x3\x2\x2\x2\x727\x729\x3\x2\x2\x2\x728\x72A\at\x2\x2\x729\x728"+
		"\x3\x2\x2\x2\x729\x72A\x3\x2\x2\x2\x72A\x72B\x3\x2\x2\x2\x72B\x731\aQ"+
		"\x2\x2\x72C\x72E\at\x2\x2\x72D\x72C\x3\x2\x2\x2\x72D\x72E\x3\x2\x2\x2"+
		"\x72E\x72F\x3\x2\x2\x2\x72F\x731\t\x18\x2\x2\x730\x71E\x3\x2\x2\x2\x730"+
		"\x71F\x3\x2\x2\x2\x730\x720\x3\x2\x2\x2\x730\x721\x3\x2\x2\x2\x730\x722"+
		"\x3\x2\x2\x2\x730\x723\x3\x2\x2\x2\x730\x724\x3\x2\x2\x2\x730\x726\x3"+
		"\x2\x2\x2\x730\x72D\x3\x2\x2\x2\x731\x732\x3\x2\x2\x2\x732\x75D\x5\xC4"+
		"\x63\x11\x733\x734\f\r\x2\x2\x734\x735\a\b\x2\x2\x735\x75D\x5\xC4\x63"+
		"\xE\x736\x737\f\f\x2\x2\x737\x738\az\x2\x2\x738\x75D\x5\xC4\x63\r\x739"+
		"\x73B\f\v\x2\x2\x73A\x73C\at\x2\x2\x73B\x73A\x3\x2\x2\x2\x73B\x73C\x3"+
		"\x2\x2\x2\x73C\x73D\x3\x2\x2\x2\x73D\x73E\a\x12\x2\x2\x73E\x73F\x5\xC4"+
		"\x63\x2\x73F\x740\a\b\x2\x2\x740\x741\x5\xC4\x63\f\x741\x75D\x3\x2\x2"+
		"\x2\x742\x743\f\n\x2\x2\x743\x744\a\xDD\x2\x2\x744\x745\x5\xC4\x63\x2"+
		"\x745\x746\a\xCC\x2\x2\x746\x747\x5\xC4\x63\n\x747\x75D\x3\x2\x2\x2\x748"+
		"\x749\f\x15\x2\x2\x749\x74A\a\xD6\x2\x2\x74A\x74B\x5\xC4\x63\x2\x74B\x74C"+
		"\a\xE1\x2\x2\x74C\x75D\x3\x2\x2\x2\x74D\x74E\f\x14\x2\x2\x74E\x74F\a\xD0"+
		"\x2\x2\x74F\x75D\a\xC5\x2\x2\x750\x751\f\xF\x2\x2\x751\x753\aY\x2\x2\x752"+
		"\x754\at\x2\x2\x753\x752\x3\x2\x2\x2\x753\x754\x3\x2\x2\x2\x754\x755\x3"+
		"\x2\x2\x2\x755\x75D\au\x2\x2\x756\x75A\f\t\x2\x2\x757\x75B\x5\xE8u\x2"+
		"\x758\x759\a\f\x2\x2\x759\x75B\x5\xEAv\x2\x75A\x757\x3\x2\x2\x2\x75A\x758"+
		"\x3\x2\x2\x2\x75B\x75D\x3\x2\x2\x2\x75C\x717\x3\x2\x2\x2\x75C\x71A\x3"+
		"\x2\x2\x2\x75C\x71D\x3\x2\x2\x2\x75C\x733\x3\x2\x2\x2\x75C\x736\x3\x2"+
		"\x2\x2\x75C\x739\x3\x2\x2\x2\x75C\x742\x3\x2\x2\x2\x75C\x748\x3\x2\x2"+
		"\x2\x75C\x74D\x3\x2\x2\x2\x75C\x750\x3\x2\x2\x2\x75C\x756\x3\x2\x2\x2"+
		"\x75D\x760\x3\x2\x2\x2\x75E\x75C\x3\x2\x2\x2\x75E\x75F\x3\x2\x2\x2\x75F"+
		"\xC5\x3\x2\x2\x2\x760\x75E\x3\x2\x2\x2\x761\x766\x5\xC8\x65\x2\x762\x763"+
		"\a\xCD\x2\x2\x763\x765\x5\xC8\x65\x2\x764\x762\x3\x2\x2\x2\x765\x768\x3"+
		"\x2\x2\x2\x766\x764\x3\x2\x2\x2\x766\x767\x3\x2\x2\x2\x767\xC7\x3\x2\x2"+
		"\x2\x768\x766\x3\x2\x2\x2\x769\x76C\x5\xCA\x66\x2\x76A\x76C\x5\xC4\x63"+
		"\x2\x76B\x769\x3\x2\x2\x2\x76B\x76A\x3\x2\x2\x2\x76C\xC9\x3\x2\x2\x2\x76D"+
		"\x76E\a\xD8\x2\x2\x76E\x773\x5\xEAv\x2\x76F\x770\a\xCD\x2\x2\x770\x772"+
		"\x5\xEAv\x2\x771\x76F\x3\x2\x2\x2\x772\x775\x3\x2\x2\x2\x773\x771\x3\x2"+
		"\x2\x2\x773\x774\x3\x2\x2\x2\x774\x776\x3\x2\x2\x2\x775\x773\x3\x2\x2"+
		"\x2\x776\x777\a\xE2\x2\x2\x777\x781\x3\x2\x2\x2\x778\x77D\x5\xEAv\x2\x779"+
		"\x77A\a\xCD\x2\x2\x77A\x77C\x5\xEAv\x2\x77B\x779\x3\x2\x2\x2\x77C\x77F"+
		"\x3\x2\x2\x2\x77D\x77B\x3\x2\x2\x2\x77D\x77E\x3\x2\x2\x2\x77E\x781\x3"+
		"\x2\x2\x2\x77F\x77D\x3\x2\x2\x2\x780\x76D\x3\x2\x2\x2\x780\x778\x3\x2"+
		"\x2\x2\x781\x782\x3\x2\x2\x2\x782\x783\a\xC8\x2\x2\x783\x784\x5\xC4\x63"+
		"\x2\x784\xCB\x3\x2\x2\x2\x785\x786\x5\xD4k\x2\x786\x787\a\xD0\x2\x2\x787"+
		"\x789\x3\x2\x2\x2\x788\x785\x3\x2\x2\x2\x788\x789\x3\x2\x2\x2\x789\x78A"+
		"\x3\x2\x2\x2\x78A\x78B\x5\xCEh\x2\x78B\xCD\x3\x2\x2\x2\x78C\x78F\x5\xEA"+
		"v\x2\x78D\x78E\a\xD0\x2\x2\x78E\x790\x5\xEAv\x2\x78F\x78D\x3\x2\x2\x2"+
		"\x78F\x790\x3\x2\x2\x2\x790\xCF\x3\x2\x2\x2\x791\x792\bi\x1\x2\x792\x799"+
		"\x5\xD4k\x2\x793\x799\x5\xD2j\x2\x794\x795\a\xD8\x2\x2\x795\x796\x5n\x38"+
		"\x2\x796\x797\a\xE2\x2\x2\x797\x799\x3\x2\x2\x2\x798\x791\x3\x2\x2\x2"+
		"\x798\x793\x3\x2\x2\x2\x798\x794\x3\x2\x2\x2\x799\x7A2\x3\x2\x2\x2\x79A"+
		"\x79E\f\x3\x2\x2\x79B\x79F\x5\xE8u\x2\x79C\x79D\a\f\x2\x2\x79D\x79F\x5"+
		"\xEAv\x2\x79E\x79B\x3\x2\x2\x2\x79E\x79C\x3\x2\x2\x2\x79F\x7A1\x3\x2\x2"+
		"\x2\x7A0\x79A\x3\x2\x2\x2\x7A1\x7A4\x3\x2\x2\x2\x7A2\x7A0\x3\x2\x2\x2"+
		"\x7A2\x7A3\x3\x2\x2\x2\x7A3\xD1\x3\x2\x2\x2\x7A4\x7A2\x3\x2\x2\x2\x7A5"+
		"\x7A6\x5\xEAv\x2\x7A6\x7A8\a\xD8\x2\x2\x7A7\x7A9\x5\xD6l\x2\x7A8\x7A7"+
		"\x3\x2\x2\x2\x7A8\x7A9\x3\x2\x2\x2\x7A9\x7AA\x3\x2\x2\x2\x7AA\x7AB\a\xE2"+
		"\x2\x2\x7AB\xD3\x3\x2\x2\x2\x7AC\x7AD\x5\xDAn\x2\x7AD\x7AE\a\xD0\x2\x2"+
		"\x7AE\x7B0\x3\x2\x2\x2\x7AF\x7AC\x3\x2\x2\x2\x7AF\x7B0\x3\x2\x2\x2\x7B0"+
		"\x7B1\x3\x2\x2\x2\x7B1\x7B2\x5\xEAv\x2\x7B2\xD5\x3\x2\x2\x2\x7B3\x7B8"+
		"\x5\xD8m\x2\x7B4\x7B5\a\xCD\x2\x2\x7B5\x7B7\x5\xD8m\x2\x7B6\x7B4\x3\x2"+
		"\x2\x2\x7B7\x7BA\x3\x2\x2\x2\x7B8\x7B6\x3\x2\x2\x2\x7B8\x7B9\x3\x2\x2"+
		"\x2\x7B9\xD7\x3\x2\x2\x2\x7BA\x7B8\x3\x2\x2\x2\x7BB\x7BF\x5\xCEh\x2\x7BC"+
		"\x7BF\x5\xD2j\x2\x7BD\x7BF\x5\xE0q\x2\x7BE\x7BB\x3\x2\x2\x2\x7BE\x7BC"+
		"\x3\x2\x2\x2\x7BE\x7BD\x3\x2\x2\x2\x7BF\xD9\x3\x2\x2\x2\x7C0\x7C1\x5\xEA"+
		"v\x2\x7C1\xDB\x3\x2\x2\x2\x7C2\x7CB\a\xC3\x2\x2\x7C3\x7C4\a\xD0\x2\x2"+
		"\x7C4\x7CB\t\x19\x2\x2\x7C5\x7C6\a\xC5\x2\x2\x7C6\x7C8\a\xD0\x2\x2\x7C7"+
		"\x7C9\t\x19\x2\x2\x7C8\x7C7\x3\x2\x2\x2\x7C8\x7C9\x3\x2\x2\x2\x7C9\x7CB"+
		"\x3\x2\x2\x2\x7CA\x7C2\x3\x2\x2\x2\x7CA\x7C3\x3\x2\x2\x2\x7CA\x7C5\x3"+
		"\x2\x2\x2\x7CB\xDD\x3\x2\x2\x2\x7CC\x7CE\t\x1A\x2\x2\x7CD\x7CC\x3\x2\x2"+
		"\x2\x7CD\x7CE\x3\x2\x2\x2\x7CE\x7D5\x3\x2\x2\x2\x7CF\x7D6\x5\xDCo\x2\x7D0"+
		"\x7D6\a\xC4\x2\x2\x7D1\x7D6\a\xC5\x2\x2\x7D2\x7D6\a\xC6\x2\x2\x7D3\x7D6"+
		"\aS\x2\x2\x7D4\x7D6\ar\x2\x2\x7D5\x7CF\x3\x2\x2\x2\x7D5\x7D0\x3\x2\x2"+
		"\x2\x7D5\x7D1\x3\x2\x2\x2\x7D5\x7D2\x3\x2\x2\x2\x7D5\x7D3\x3\x2\x2\x2"+
		"\x7D5\x7D4\x3\x2\x2\x2\x7D6\xDF\x3\x2\x2\x2\x7D7\x7DB\x5\xDEp\x2\x7D8"+
		"\x7DB\a\xC7\x2\x2\x7D9\x7DB\au\x2\x2\x7DA\x7D7\x3\x2\x2\x2\x7DA\x7D8\x3"+
		"\x2\x2\x2\x7DA\x7D9\x3\x2\x2\x2\x7DB\xE1\x3\x2\x2\x2\x7DC\x7DD\t\x1B\x2"+
		"\x2\x7DD\xE3\x3\x2\x2\x2\x7DE\x7DF\t\x1C\x2\x2\x7DF\xE5\x3\x2\x2\x2\x7E0"+
		"\x7E1\t\x1D\x2\x2\x7E1\xE7\x3\x2\x2\x2\x7E2\x7E5\a\xC2\x2\x2\x7E3\x7E5"+
		"\x5\xE6t\x2\x7E4\x7E2\x3\x2\x2\x2\x7E4\x7E3\x3\x2\x2\x2\x7E5\xE9\x3\x2"+
		"\x2\x2\x7E6\x7EA\a\xC2\x2\x2\x7E7\x7EA\x5\xE2r\x2\x7E8\x7EA\x5\xE4s\x2"+
		"\x7E9\x7E6\x3\x2\x2\x2\x7E9\x7E7\x3\x2\x2\x2\x7E9\x7E8\x3\x2\x2\x2\x7EA"+
		"\xEB\x3\x2\x2\x2\x7EB\x7EE\x5\xEAv\x2\x7EC\x7EE\au\x2\x2\x7ED\x7EB\x3"+
		"\x2\x2\x2\x7ED\x7EC\x3\x2\x2\x2\x7EE\xED\x3\x2\x2\x2\x7EF\x7F0\a\xC7\x2"+
		"\x2\x7F0\x7F1\a\xD2\x2\x2\x7F1\x7F2\x5\xDEp\x2\x7F2\xEF\x3\x2\x2\x2\x110"+
		"\xF4\xF8\xFB\xFE\x112\x118\x11F\x127\x12B\x132\x137\x13E\x143\x149\x14F"+
		"\x154\x15A\x15F\x165\x16A\x170\x17E\x185\x18C\x193\x199\x19E\x1A4\x1A9"+
		"\x1AF\x1B8\x1C1\x1CB\x1DF\x1E7\x1F6\x200\x20E\x214\x21A\x221\x225\x228"+
		"\x22E\x231\x237\x23B\x23E\x249\x24D\x250\x255\x257\x25A\x25D\x267\x26B"+
		"\x26E\x271\x276\x278\x280\x283\x286\x28C\x290\x293\x296\x299\x29C\x29F"+
		"\x2A4\x2AA\x2AE\x2B1\x2B4\x2B8\x2C0\x2DA\x2DC\x2E0\x2F6\x2F8\x303\x306"+
		"\x30F\x320\x32B\x33D\x34A\x35B\x364\x37F\x381\x39C\x3A1\x3A6\x3A9\x3B5"+
		"\x3BA\x3BD\x3C0\x3C4\x3C8\x3CC\x3CF\x3D3\x3D5\x3EB\x3F3\x3F6\x400\x404"+
		"\x40C\x410\x415\x419\x41D\x421\x425\x427\x42F\x433\x436\x43E\x443\x448"+
		"\x44B\x455\x45F\x463\x468\x46C\x472\x475\x478\x47B\x489\x48D\x491\x496"+
		"\x499\x4A3\x4AB\x4AE\x4B2\x4B5\x4B9\x4BC\x4BF\x4C2\x4C5\x4C8\x4CC\x4D0"+
		"\x4D3\x4D6\x4D9\x4DC\x4DF\x4E8\x4EE\x509\x51F\x527\x52A\x530\x538\x53B"+
		"\x541\x543\x547\x54C\x54F\x552\x556\x55A\x55D\x55F\x562\x566\x56A\x56D"+
		"\x56F\x571\x574\x579\x584\x58A\x58F\x596\x59B\x59F\x5A3\x5A8\x5AF\x5B7"+
		"\x5BA\x5BD\x5D0\x5DE\x5EE\x5F1\x5FA\x5FE\x603\x608\x60B\x60D\x623\x626"+
		"\x631\x635\x638\x63C\x640\x648\x64C\x659\x665\x671\x679\x67D\x684\x68A"+
		"\x692\x697\x6A0\x6A4\x6C3\x6D4\x6E0\x6EA\x6ED\x6F1\x6F4\x700\x711\x715"+
		"\x726\x729\x72D\x730\x73B\x753\x75A\x75C\x75E\x766\x76B\x773\x77D\x780"+
		"\x788\x78F\x798\x79E\x7A2\x7A8\x7AF\x7B8\x7BE\x7C8\x7CA\x7CD\x7D5\x7DA"+
		"\x7E4\x7E9\x7ED";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SqlParser.ClickHouse.Antlr4File2
