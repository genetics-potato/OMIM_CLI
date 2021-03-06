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
''' DROP TABLE IF EXISTS `drug_patents`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_patents` (
'''   `drug` varchar(45) NOT NULL,
'''   `number` varchar(45) DEFAULT NULL,
'''   `country` varchar(45) DEFAULT NULL,
'''   `approved` varchar(45) DEFAULT NULL,
'''   `expires` varchar(45) DEFAULT NULL,
'''   `pediatric_extension` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_patents", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_patents` (
  `drug` varchar(45) NOT NULL,
  `number` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `approved` varchar(45) DEFAULT NULL,
  `expires` varchar(45) DEFAULT NULL,
  `pediatric_extension` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_patents: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("number"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="number")> Public Property number As String
    <DatabaseField("country"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="country")> Public Property country As String
    <DatabaseField("approved"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="approved")> Public Property approved As String
    <DatabaseField("expires"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="expires")> Public Property expires As String
    <DatabaseField("pediatric_extension"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="pediatric_extension")> Public Property pediatric_extension As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_patents` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_patents` SET `drug`='{0}', `number`='{1}', `country`='{2}', `approved`='{3}', `expires`='{4}', `pediatric_extension`='{5}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_patents` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, number, country, approved, expires, pediatric_extension)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{number}', '{country}', '{approved}', '{expires}', '{pediatric_extension}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, number, country, approved, expires, pediatric_extension)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_patents` SET `drug`='{0}', `number`='{1}', `country`='{2}', `approved`='{3}', `expires`='{4}', `pediatric_extension`='{5}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_patents
                  Return DirectCast(MyClass.MemberwiseClone, drug_patents)
              End Function
End Class


End Namespace
