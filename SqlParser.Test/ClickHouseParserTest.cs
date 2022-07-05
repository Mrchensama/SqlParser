using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using SqlParser.ClickHouse;
using SqlParser.ClickHouse.Antlr4File2;

namespace SqlParser.Test
{
    [TestClass]
    public class ClickHouseParserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            String sql = @"SELECT
	createdDate,
	createdAt,
	orderId,
	lawyerShareAmt / 100,
	orderType,
	orderMedia,
	lawyerId,
IF
	( lawyerId IN ( 12403313, 12403238, 12403832, 12403230, 12403337 ), '自营', '非自营' ) isofficelawyer,
	CONTENT,
	isServer,
	payOrderAt,
	beginServerAt,
IF
	( beginServerAt >= '2022-01-01 00:00:00', beginServerAt - payOrderAt, 0 ) `开始服务间隔时间`,
	commentProfessionDegree `专业能力星级`,
	commentResponseSpeed `响应速度星级`,
	commentServiceAttitude `服务态度星级` 
FROM
	dwm.V_DWM_ORDER_PUBLIC_FACT_FINANCE_Iwhere createdDate >= yesterday ( ) 
	AND bdName = '律图' 
	AND orderClass = '付费咨询' 
	AND isPay = 1";
            ClickHouseLexer lexer = new ClickHouseLexer(new AntlrInputStream(sql));
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            ClickHouseParser parser = new ClickHouseParser(commonTokenStream);
            parser.AddErrorListener(ClickHouseErrorListener.INSTANCE);
            var queryStmtContext = parser.queryStmt();
            QueryStmtVisitor visitor = new QueryStmtVisitor().init();
            queryStmtContext.Accept(visitor);
            var temp = visitor.getParserVo();
            Assert.IsNotNull(temp);
        }
        /// <summary>
        /// 读取转换器
        /// </summary>
        public class QueryStmtVisitor : ClickHouseParserBaseVisitor<MetaDdlSqlParserVo>
        {
            public MetaDdlSqlParserVo parserVo { set; get; }
            public List<MetaDdlColumns> columnsList { set; get; }
            public ColumnDefVisitor columnDefVisitor { set; get; }

            public QueryStmtVisitor init()
            {
                parserVo = new MetaDdlSqlParserVo();
                columnsList = new List<MetaDdlColumns>();
                columnDefVisitor = new ColumnDefVisitor();
                return this;
            }

            public MetaDdlSqlParserVo getParserVo()
            {
                parserVo.columnDefList = columnsList;
                return parserVo;
            }

            public override MetaDdlSqlParserVo VisitTableCommentClause(ClickHouseParser.TableCommentClauseContext ctx)
            {
                parserVo.tableDesc = ctx.Stop.Text;
                parserVo.tableChinese = ctx.Stop.Text;
                return base.VisitTableCommentClause(ctx);
            }

            public override MetaDdlSqlParserVo VisitDatabaseIdentifier(ClickHouseParser.DatabaseIdentifierContext ctx)
            {
                parserVo.dbName = ctx.GetText();
                return base.VisitDatabaseIdentifier(ctx);
            }

            public override MetaDdlSqlParserVo VisitTableIdentifier(ClickHouseParser.TableIdentifierContext ctx)
            {
                if (string.IsNullOrEmpty(parserVo.tableName))
                {
                    parserVo.tableName = ctx.stop.Text;
                }
                else
                {
                    parserVo.newTableName = ctx.stop.Text;
                }
                return base.VisitTableIdentifier(ctx);
            }

            public override MetaDdlSqlParserVo VisitAlterTableClauseModify(ClickHouseParser.AlterTableClauseModifyContext ctx)
            {
                return base.VisitAlterTableClauseModify(ctx);
            }

            public override MetaDdlSqlParserVo VisitTableColumnDfnt(ClickHouseParser.TableColumnDfntContext ctx)
            {
                ctx.Accept(columnDefVisitor.init());
                MetaDdlColumns column = columnDefVisitor.getColumn();
                columnsList.Add(column);
                return base.VisitTableColumnDfnt(ctx);
            }

            public override MetaDdlSqlParserVo VisitAddAfterColumnName(ClickHouseParser.AddAfterColumnNameContext ctx)
            {
                MetaDdlColumns column = columnsList.Last();
                return base.VisitAddAfterColumnName(ctx);
            }
        }


        /**
         * 解析字段用的visitor
         */
        public class ColumnDefVisitor : ClickHouseParserBaseVisitor<MetaDdlColumns>
        {
            private MetaDdlColumns column { set; get; }

            public ColumnDefVisitor init()
            {
                column = new MetaDdlColumns();
                return this;
            }

            public MetaDdlColumns getColumn()
            {
                return column;
            }

            public override MetaDdlColumns VisitColumnCommentClause(ClickHouseParser.ColumnCommentClauseContext ctx)
            {
                String columnChinese = ctx.stop.Text;
                if (string.IsNullOrEmpty(columnChinese))
                {
                    if (columnChinese.StartsWith("'") || columnChinese.StartsWith("\""))
                    {
                        columnChinese = columnChinese.Substring(1);
                    }
                    if (columnChinese.EndsWith("'") || columnChinese.EndsWith("\""))
                    {
                        columnChinese = columnChinese.Substring(0, columnChinese.Length - 1);
                    }
                    column.columnChinese = columnChinese;
                }
                return base.VisitColumnCommentClause(ctx);
            }

            public override MetaDdlColumns VisitNestedIdentifier(ClickHouseParser.NestedIdentifierContext ctx)
            {
                column.columnName = removeInvalidChar(ctx.Stop.Text);
                return base.VisitNestedIdentifier(ctx);
            }

            public override MetaDdlColumns VisitColumnTypeExprSimple(ClickHouseParser.ColumnTypeExprSimpleContext ctx)
            {
                column.type = ctx.Start.Text;
                return base.VisitColumnTypeExprSimple(ctx);
            }

            public override MetaDdlColumns VisitColumnTypeExprComplex(ClickHouseParser.ColumnTypeExprComplexContext ctx)
            {
                column.type = ctx.Start.Text;
                return base.VisitColumnTypeExprComplex(ctx);
            }

            public override MetaDdlColumns VisitColumnTypeExprEnum(ClickHouseParser.ColumnTypeExprEnumContext ctx)
            {
                column.type = ctx.Start.Text;
                return base.VisitColumnTypeExprEnum(ctx);
            }
            public override MetaDdlColumns VisitColumnTypeExprNested(ClickHouseParser.ColumnTypeExprNestedContext ctx)
            {
                column.type = ctx.Start.Text;
                return base.VisitColumnTypeExprNested(ctx);
            }

            public override MetaDdlColumns VisitColumnTypeExprParam(ClickHouseParser.ColumnTypeExprParamContext ctx)
            {
                column.type = ctx.Start.Text;
                return base.VisitColumnTypeExprParam(ctx);
            }
        }

        public class ClickHouseErrorListener : BaseErrorListener
        {
            public static ClickHouseErrorListener INSTANCE = new ClickHouseErrorListener();
            public override void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine, [NotNull] string msg, [Nullable] RecognitionException e)
            {
                throw new Exception("CK解析异常line " + line + ":" + charPositionInLine + " " + msg);
            }
            public void syntaxError(IRecognizer recognizer, Object offendingSymbol, int line, int charPositionInLine, String msg, RecognitionException e)
            {
            }
        }

        public static String removeInvalidChar(String origin)
        {
            if (string.IsNullOrEmpty(origin))
            {
                return origin;
            }
            return origin.Replace("`", "");
        }

        public class MetaDdlSqlParserVo
        {
            /***字段定义列表*/
            public List<MetaDdlColumns> columnDefList { set; get; }
            /***表名*/
            public String tableName { set; get; }
            /***新表名，仅修改表名可用*/
            public String newTableName { set; get; }
            /***表中文名*/
            public String tableChinese { set; get; }
            /***表描述*/
            public String tableDesc { set; get; }
            /***库名*/
            public String dbName { set; get; }

        }

        public class MetaDdlColumns
        {

            /***字段名*/
            public String columnName { set; get; }

            /***原始字段名*/
            public String originColumnName { set; get; }

            /***字段名-中文*/
            public String columnChinese { set; get; }

            /***字段类型*/
            public String type { set; get; }

            /***字段长度*/
            public String length { set; get; }

        }

    }
}