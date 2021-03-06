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
''' DROP TABLE IF EXISTS `drug_targets`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_targets` (
'''   `drug` varchar(45) NOT NULL,
'''   `target_id` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `organism` varchar(45) DEFAULT NULL,
'''   `actions` varchar(45) DEFAULT NULL,
'''   `known_action` varchar(45) DEFAULT NULL,
'''   `polypeptide` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_targets", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_targets` (
  `drug` varchar(45) NOT NULL,
  `target_id` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `organism` varchar(45) DEFAULT NULL,
  `actions` varchar(45) DEFAULT NULL,
  `known_action` varchar(45) DEFAULT NULL,
  `polypeptide` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_targets: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("target_id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="target_id")> Public Property target_id As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
    <DatabaseField("organism"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="organism")> Public Property organism As String
    <DatabaseField("actions"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="actions")> Public Property actions As String
    <DatabaseField("known_action"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="known_action")> Public Property known_action As String
    <DatabaseField("polypeptide"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="polypeptide")> Public Property polypeptide As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_targets` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_targets` SET `drug`='{0}', `target_id`='{1}', `name`='{2}', `organism`='{3}', `actions`='{4}', `known_action`='{5}', `polypeptide`='{6}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_targets` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, target_id, name, organism, actions, known_action, polypeptide)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{target_id}', '{name}', '{organism}', '{actions}', '{known_action}', '{polypeptide}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_targets` (`drug`, `target_id`, `name`, `organism`, `actions`, `known_action`, `polypeptide`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, target_id, name, organism, actions, known_action, polypeptide)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_targets` SET `drug`='{0}', `target_id`='{1}', `name`='{2}', `organism`='{3}', `actions`='{4}', `known_action`='{5}', `polypeptide`='{6}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_targets
                  Return DirectCast(MyClass.MemberwiseClone, drug_targets)
              End Function
End Class


End Namespace
