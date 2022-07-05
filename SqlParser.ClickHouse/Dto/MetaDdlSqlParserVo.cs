using System;
using System.Collections.Generic;

namespace SqlParser.ClickHouse.Dto
{
    public class MetaDdlSqlParserVo
    {
        /***字段定义列表*/
        private List<MetaDdlColumns> columnDefList { set; get; }
        /***表名*/
        private String tableName { set; get; }
        /***新表名，仅修改表名可用*/
        private String newTableName { set; get; }
        /***表中文名*/
        private String tableChinese { set; get; }
        /***表描述*/
        private String tableDesc { set; get; }
        /***库名*/
        private String dbName { set; get; }
    }
    public class MetaDdlColumns
    {
        /***字段名*/
        private String columnName { set; get; }

        /***原始字段名*/
        private String originColumnName { set; get; }

        /***字段名-中文*/
        private String columnChinese { set; get; }

        /***字段类型*/
        private String type { set; get; }

        /***字段长度*/
        private String length { set; get; }

    }
}
