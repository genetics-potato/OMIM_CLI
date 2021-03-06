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
''' DROP TABLE IF EXISTS `drug_atc_code`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_atc_code` (
'''   `drug` varchar(45) NOT NULL,
'''   `code` varchar(45) DEFAULT NULL,
'''   `level1_code` varchar(45) DEFAULT NULL,
'''   `level1_description` varchar(45) DEFAULT NULL,
'''   `level2_code` varchar(45) DEFAULT NULL,
'''   `level2_description` varchar(45) DEFAULT NULL,
'''   `level3_code` varchar(45) DEFAULT NULL,
'''   `level3_description` varchar(45) DEFAULT NULL,
'''   `level4_code` varchar(45) DEFAULT NULL,
'''   `level4_description` varchar(45) DEFAULT NULL,
'''   `level5_code` varchar(45) DEFAULT NULL,
'''   `level5_description` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_atc_code", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_atc_code` (
  `drug` varchar(45) NOT NULL,
  `code` varchar(45) DEFAULT NULL,
  `level1_code` varchar(45) DEFAULT NULL,
  `level1_description` varchar(45) DEFAULT NULL,
  `level2_code` varchar(45) DEFAULT NULL,
  `level2_description` varchar(45) DEFAULT NULL,
  `level3_code` varchar(45) DEFAULT NULL,
  `level3_description` varchar(45) DEFAULT NULL,
  `level4_code` varchar(45) DEFAULT NULL,
  `level4_description` varchar(45) DEFAULT NULL,
  `level5_code` varchar(45) DEFAULT NULL,
  `level5_description` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_atc_code: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="code")> Public Property code As String
    <DatabaseField("level1_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level1_code")> Public Property level1_code As String
    <DatabaseField("level1_description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level1_description")> Public Property level1_description As String
    <DatabaseField("level2_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level2_code")> Public Property level2_code As String
    <DatabaseField("level2_description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level2_description")> Public Property level2_description As String
    <DatabaseField("level3_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level3_code")> Public Property level3_code As String
    <DatabaseField("level3_description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level3_description")> Public Property level3_description As String
    <DatabaseField("level4_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level4_code")> Public Property level4_code As String
    <DatabaseField("level4_description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level4_description")> Public Property level4_description As String
    <DatabaseField("level5_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level5_code")> Public Property level5_code As String
    <DatabaseField("level5_description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level5_description")> Public Property level5_description As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_atc_code` (`drug`, `code`, `level1_code`, `level1_description`, `level2_code`, `level2_description`, `level3_code`, `level3_description`, `level4_code`, `level4_description`, `level5_code`, `level5_description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_atc_code` (`drug`, `code`, `level1_code`, `level1_description`, `level2_code`, `level2_description`, `level3_code`, `level3_description`, `level4_code`, `level4_description`, `level5_code`, `level5_description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_atc_code` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_atc_code` SET `drug`='{0}', `code`='{1}', `level1_code`='{2}', `level1_description`='{3}', `level2_code`='{4}', `level2_description`='{5}', `level3_code`='{6}', `level3_description`='{7}', `level4_code`='{8}', `level4_description`='{9}', `level5_code`='{10}', `level5_description`='{11}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_atc_code` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_atc_code` (`drug`, `code`, `level1_code`, `level1_description`, `level2_code`, `level2_description`, `level3_code`, `level3_description`, `level4_code`, `level4_description`, `level5_code`, `level5_description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, code, level1_code, level1_description, level2_code, level2_description, level3_code, level3_description, level4_code, level4_description, level5_code, level5_description)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{code}', '{level1_code}', '{level1_description}', '{level2_code}', '{level2_description}', '{level3_code}', '{level3_description}', '{level4_code}', '{level4_description}', '{level5_code}', '{level5_description}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_atc_code` (`drug`, `code`, `level1_code`, `level1_description`, `level2_code`, `level2_description`, `level3_code`, `level3_description`, `level4_code`, `level4_description`, `level5_code`, `level5_description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, code, level1_code, level1_description, level2_code, level2_description, level3_code, level3_description, level4_code, level4_description, level5_code, level5_description)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_atc_code` SET `drug`='{0}', `code`='{1}', `level1_code`='{2}', `level1_description`='{3}', `level2_code`='{4}', `level2_description`='{5}', `level3_code`='{6}', `level3_description`='{7}', `level4_code`='{8}', `level4_description`='{9}', `level5_code`='{10}', `level5_description`='{11}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_atc_code
                  Return DirectCast(MyClass.MemberwiseClone, drug_atc_code)
              End Function
End Class


End Namespace
