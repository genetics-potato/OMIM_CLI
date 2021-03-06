REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/10/24 11:04:04


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_pathways`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_pathways` (
'''   `drug` varchar(45) NOT NULL,
'''   `smpdb_id` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `category` varchar(45) DEFAULT NULL,
'''   `enzymes` varchar(45) DEFAULT NULL COMMENT 'using ; character as delimiter'
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_pathways", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_pathways` (
  `drug` varchar(45) NOT NULL,
  `smpdb_id` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  `enzymes` varchar(45) DEFAULT NULL COMMENT 'using ; character as delimiter'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_pathways: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("smpdb_id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="smpdb_id")> Public Property smpdb_id As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
    <DatabaseField("category"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="category")> Public Property category As String
    <DatabaseField("enzymes"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="enzymes")> Public Property enzymes As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_pathways` (`drug`, `smpdb_id`, `name`, `category`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_pathways` (`drug`, `smpdb_id`, `name`, `category`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_pathways` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_pathways` SET `drug`='{0}', `smpdb_id`='{1}', `name`='{2}', `category`='{3}', `enzymes`='{4}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_pathways` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_pathways` (`drug`, `smpdb_id`, `name`, `category`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, smpdb_id, name, category, enzymes)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{smpdb_id}', '{name}', '{category}', '{enzymes}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_pathways` (`drug`, `smpdb_id`, `name`, `category`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, smpdb_id, name, category, enzymes)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_pathways` SET `drug`='{0}', `smpdb_id`='{1}', `name`='{2}', `category`='{3}', `enzymes`='{4}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_pathways
                  Return DirectCast(MyClass.MemberwiseClone, drug_pathways)
              End Function
End Class


End Namespace
