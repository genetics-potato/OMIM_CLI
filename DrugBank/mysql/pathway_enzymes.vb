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
''' DROP TABLE IF EXISTS `pathway_enzymes`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `pathway_enzymes` (
'''   `uniprotID` varchar(45) NOT NULL,
'''   `pathway_smpdb_id` varchar(45) NOT NULL,
'''   `drugID` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `enzyme_drugbankID` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("pathway_enzymes", Database:="drugbank", SchemaSQL:="
CREATE TABLE `pathway_enzymes` (
  `uniprotID` varchar(45) NOT NULL,
  `pathway_smpdb_id` varchar(45) NOT NULL,
  `drugID` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `enzyme_drugbankID` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class pathway_enzymes: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uniprotID"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="uniprotID")> Public Property uniprotID As String
    <DatabaseField("pathway_smpdb_id"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="pathway_smpdb_id")> Public Property pathway_smpdb_id As String
    <DatabaseField("drugID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="drugID")> Public Property drugID As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
    <DatabaseField("enzyme_drugbankID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="enzyme_drugbankID")> Public Property enzyme_drugbankID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `pathway_enzymes` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `pathway_enzymes` SET `uniprotID`='{0}', `pathway_smpdb_id`='{1}', `drugID`='{2}', `name`='{3}', `enzyme_drugbankID`='{4}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `pathway_enzymes` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uniprotID, pathway_smpdb_id, drugID, name, enzyme_drugbankID)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uniprotID}', '{pathway_smpdb_id}', '{drugID}', '{name}', '{enzyme_drugbankID}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `pathway_enzymes` (`uniprotID`, `pathway_smpdb_id`, `drugID`, `name`, `enzyme_drugbankID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uniprotID, pathway_smpdb_id, drugID, name, enzyme_drugbankID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `pathway_enzymes` SET `uniprotID`='{0}', `pathway_smpdb_id`='{1}', `drugID`='{2}', `name`='{3}', `enzyme_drugbankID`='{4}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As pathway_enzymes
                  Return DirectCast(MyClass.MemberwiseClone, pathway_enzymes)
              End Function
End Class


End Namespace
