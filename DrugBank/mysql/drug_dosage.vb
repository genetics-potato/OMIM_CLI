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
''' DROP TABLE IF EXISTS `drug_dosage`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_dosage` (
'''   `drug` varchar(45) NOT NULL,
'''   `form` varchar(45) DEFAULT NULL,
'''   `route` varchar(45) DEFAULT NULL,
'''   `strength` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_dosage", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_dosage` (
  `drug` varchar(45) NOT NULL,
  `form` varchar(45) DEFAULT NULL,
  `route` varchar(45) DEFAULT NULL,
  `strength` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_dosage: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("form"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="form")> Public Property form As String
    <DatabaseField("route"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="route")> Public Property route As String
    <DatabaseField("strength"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="strength")> Public Property strength As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_dosage` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_dosage` SET `drug`='{0}', `form`='{1}', `route`='{2}', `strength`='{3}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_dosage` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, form, route, strength)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{form}', '{route}', '{strength}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, form, route, strength)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_dosage` SET `drug`='{0}', `form`='{1}', `route`='{2}', `strength`='{3}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_dosage
                  Return DirectCast(MyClass.MemberwiseClone, drug_dosage)
              End Function
End Class


End Namespace
