REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/30 9:02:46


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `pathway_drugs`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `pathway_drugs` (
'''   `pathway_smpdb_id` varchar(45) NOT NULL,
'''   `drug` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`pathway_smpdb_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("pathway_drugs", Database:="drugbank", SchemaSQL:="
CREATE TABLE `pathway_drugs` (
  `pathway_smpdb_id` varchar(45) NOT NULL,
  `drug` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pathway_smpdb_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class pathway_drugs: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("pathway_smpdb_id"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45")> Public Property pathway_smpdb_id As String
    <DatabaseField("drug"), DataType(MySqlDbType.VarChar, "45")> Public Property drug As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45")> Public Property name As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `pathway_drugs` (`pathway_smpdb_id`, `drug`, `name`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `pathway_drugs` (`pathway_smpdb_id`, `drug`, `name`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `pathway_drugs` WHERE `pathway_smpdb_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `pathway_drugs` SET `pathway_smpdb_id`='{0}', `drug`='{1}', `name`='{2}' WHERE `pathway_smpdb_id` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `pathway_drugs` WHERE `pathway_smpdb_id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, pathway_smpdb_id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `pathway_drugs` (`pathway_smpdb_id`, `drug`, `name`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, pathway_smpdb_id, drug, name)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{pathway_smpdb_id}', '{drug}', '{name}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `pathway_drugs` (`pathway_smpdb_id`, `drug`, `name`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, pathway_smpdb_id, drug, name)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `pathway_drugs` SET `pathway_smpdb_id`='{0}', `drug`='{1}', `name`='{2}' WHERE `pathway_smpdb_id` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, pathway_smpdb_id, drug, name, pathway_smpdb_id)
    End Function
#End Region
End Class


End Namespace
