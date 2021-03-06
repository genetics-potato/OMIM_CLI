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
''' DROP TABLE IF EXISTS `drug_external_links`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_external_links` (
'''   `drug` varchar(45) NOT NULL,
'''   `resource` varchar(45) DEFAULT NULL,
'''   `url` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_external_links", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_external_links` (
  `drug` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_external_links: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("resource"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="resource")> Public Property resource As String
    <DatabaseField("url"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="url")> Public Property url As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_external_links` (`drug`, `resource`, `url`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_external_links` (`drug`, `resource`, `url`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_external_links` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_external_links` SET `drug`='{0}', `resource`='{1}', `url`='{2}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_external_links` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_external_links` (`drug`, `resource`, `url`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, resource, url)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{resource}', '{url}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_external_links` (`drug`, `resource`, `url`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, resource, url)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_external_links` SET `drug`='{0}', `resource`='{1}', `url`='{2}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_external_links
                  Return DirectCast(MyClass.MemberwiseClone, drug_external_links)
              End Function
End Class


End Namespace
