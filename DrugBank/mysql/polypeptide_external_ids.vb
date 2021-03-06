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
''' DROP TABLE IF EXISTS `polypeptide_external_ids`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `polypeptide_external_ids` (
'''   `polypeptide` varchar(45) NOT NULL,
'''   `resource` varchar(45) DEFAULT NULL,
'''   `id` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("polypeptide_external_ids", Database:="drugbank", SchemaSQL:="
CREATE TABLE `polypeptide_external_ids` (
  `polypeptide` varchar(45) NOT NULL,
  `resource` varchar(45) DEFAULT NULL,
  `id` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class polypeptide_external_ids: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("polypeptide"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="polypeptide")> Public Property polypeptide As String
    <DatabaseField("resource"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="resource")> Public Property resource As String
    <DatabaseField("id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="id")> Public Property id As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `polypeptide_external_ids` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `polypeptide_external_ids` SET `polypeptide`='{0}', `resource`='{1}', `id`='{2}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `polypeptide_external_ids` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, polypeptide, resource, id)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{polypeptide}', '{resource}', '{id}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `polypeptide_external_ids` (`polypeptide`, `resource`, `id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, polypeptide, resource, id)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `polypeptide_external_ids` SET `polypeptide`='{0}', `resource`='{1}', `id`='{2}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As polypeptide_external_ids
                  Return DirectCast(MyClass.MemberwiseClone, polypeptide_external_ids)
              End Function
End Class


End Namespace
