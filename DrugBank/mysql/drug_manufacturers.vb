REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @3/30/2017 10:01:19 PM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_manufacturers`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_manufacturers` (
'''   `drug` varchar(45) NOT NULL,
'''   `generic` varchar(45) DEFAULT NULL,
'''   `url` varchar(45) DEFAULT NULL,
'''   `manufacturer` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_manufacturers", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_manufacturers` (
  `drug` varchar(45) NOT NULL,
  `generic` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL,
  `manufacturer` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_manufacturers: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("generic"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="generic")> Public Property generic As String
    <DatabaseField("url"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="url")> Public Property url As String
    <DatabaseField("manufacturer"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="manufacturer")> Public Property manufacturer As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_manufacturers` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_manufacturers` SET `drug`='{0}', `generic`='{1}', `url`='{2}', `manufacturer`='{3}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_manufacturers` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, generic, url, manufacturer)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{generic}', '{url}', '{manufacturer}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, generic, url, manufacturer)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_manufacturers` SET `drug`='{0}', `generic`='{1}', `url`='{2}', `manufacturer`='{3}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
End Class


End Namespace
