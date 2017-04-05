REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/4/5 11:30:40


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_classification`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_classification` (
'''   `drug` varchar(45) NOT NULL,
'''   `description` varchar(45) DEFAULT NULL,
'''   `direct_parent` varchar(45) DEFAULT NULL,
'''   `kingdom` varchar(45) DEFAULT NULL,
'''   `superclass` varchar(45) DEFAULT NULL,
'''   `class` varchar(45) DEFAULT NULL,
'''   `subclass` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_classification", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_classification` (
  `drug` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `direct_parent` varchar(45) DEFAULT NULL,
  `kingdom` varchar(45) DEFAULT NULL,
  `superclass` varchar(45) DEFAULT NULL,
  `class` varchar(45) DEFAULT NULL,
  `subclass` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_classification: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="description")> Public Property description As String
    <DatabaseField("direct_parent"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="direct_parent")> Public Property direct_parent As String
    <DatabaseField("kingdom"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="kingdom")> Public Property kingdom As String
    <DatabaseField("superclass"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="superclass")> Public Property superclass As String
    <DatabaseField("class"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="class")> Public Property [class] As String
    <DatabaseField("subclass"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="subclass")> Public Property subclass As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_classification` (`drug`, `description`, `direct_parent`, `kingdom`, `superclass`, `class`, `subclass`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_classification` (`drug`, `description`, `direct_parent`, `kingdom`, `superclass`, `class`, `subclass`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_classification` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_classification` SET `drug`='{0}', `description`='{1}', `direct_parent`='{2}', `kingdom`='{3}', `superclass`='{4}', `class`='{5}', `subclass`='{6}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_classification` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_classification` (`drug`, `description`, `direct_parent`, `kingdom`, `superclass`, `class`, `subclass`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, description, direct_parent, kingdom, superclass, [class], subclass)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{description}', '{direct_parent}', '{kingdom}', '{superclass}', '{[class]}', '{subclass}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_classification` (`drug`, `description`, `direct_parent`, `kingdom`, `superclass`, `class`, `subclass`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, description, direct_parent, kingdom, superclass, [class], subclass)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_classification` SET `drug`='{0}', `description`='{1}', `direct_parent`='{2}', `kingdom`='{3}', `superclass`='{4}', `class`='{5}', `subclass`='{6}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
End Class


End Namespace
