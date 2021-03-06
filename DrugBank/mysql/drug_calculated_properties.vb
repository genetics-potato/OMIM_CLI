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
''' DROP TABLE IF EXISTS `drug_calculated_properties`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_calculated_properties` (
'''   `drug` varchar(45) NOT NULL,
'''   `kind` varchar(45) DEFAULT NULL,
'''   `value` varchar(45) DEFAULT NULL,
'''   `source` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_calculated_properties", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_calculated_properties` (
  `drug` varchar(45) NOT NULL,
  `kind` varchar(45) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL,
  `source` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_calculated_properties: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("kind"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="kind")> Public Property kind As String
    <DatabaseField("value"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="value")> Public Property value As String
    <DatabaseField("source"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="source")> Public Property source As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_calculated_properties` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_calculated_properties` SET `drug`='{0}', `kind`='{1}', `value`='{2}', `source`='{3}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_calculated_properties` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, kind, value, source)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{kind}', '{value}', '{source}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_calculated_properties` (`drug`, `kind`, `value`, `source`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, kind, value, source)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_calculated_properties` SET `drug`='{0}', `kind`='{1}', `value`='{2}', `source`='{3}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_calculated_properties
                  Return DirectCast(MyClass.MemberwiseClone, drug_calculated_properties)
              End Function
End Class


End Namespace
