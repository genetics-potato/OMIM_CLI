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
''' polypeptide sequence data and function annotations
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `polypeptide_sequences`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `polypeptide_sequences` (
'''   `polypeptide` varchar(45) NOT NULL,
'''   `aa` varchar(45) DEFAULT NULL,
'''   `nt` varchar(45) DEFAULT NULL,
'''   `pfam` varchar(45) DEFAULT NULL COMMENT 'pfam ID list, using ; character as the delimiter',
'''   `go_bp` varchar(45) DEFAULT NULL,
'''   `go_cc` varchar(45) DEFAULT NULL,
'''   `go_mf` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='polypeptide sequence data and function annotations';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("polypeptide_sequences", Database:="drugbank", SchemaSQL:="
CREATE TABLE `polypeptide_sequences` (
  `polypeptide` varchar(45) NOT NULL,
  `aa` varchar(45) DEFAULT NULL,
  `nt` varchar(45) DEFAULT NULL,
  `pfam` varchar(45) DEFAULT NULL COMMENT 'pfam ID list, using ; character as the delimiter',
  `go_bp` varchar(45) DEFAULT NULL,
  `go_cc` varchar(45) DEFAULT NULL,
  `go_mf` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='polypeptide sequence data and function annotations';")>
Public Class polypeptide_sequences: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("polypeptide"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="polypeptide")> Public Property polypeptide As String
    <DatabaseField("aa"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="aa")> Public Property aa As String
    <DatabaseField("nt"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="nt")> Public Property nt As String
''' <summary>
''' pfam ID list, using ; character as the delimiter
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("pfam"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="pfam")> Public Property pfam As String
    <DatabaseField("go_bp"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="go_bp")> Public Property go_bp As String
    <DatabaseField("go_cc"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="go_cc")> Public Property go_cc As String
    <DatabaseField("go_mf"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="go_mf")> Public Property go_mf As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `polypeptide_sequences` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `polypeptide_sequences` SET `polypeptide`='{0}', `aa`='{1}', `nt`='{2}', `pfam`='{3}', `go_bp`='{4}', `go_cc`='{5}', `go_mf`='{6}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `polypeptide_sequences` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, polypeptide, aa, nt, pfam, go_bp, go_cc, go_mf)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{polypeptide}', '{aa}', '{nt}', '{pfam}', '{go_bp}', '{go_cc}', '{go_mf}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `polypeptide_sequences` (`polypeptide`, `aa`, `nt`, `pfam`, `go_bp`, `go_cc`, `go_mf`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, polypeptide, aa, nt, pfam, go_bp, go_cc, go_mf)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `polypeptide_sequences` SET `polypeptide`='{0}', `aa`='{1}', `nt`='{2}', `pfam`='{3}', `go_bp`='{4}', `go_cc`='{5}', `go_mf`='{6}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As polypeptide_sequences
                  Return DirectCast(MyClass.MemberwiseClone, polypeptide_sequences)
              End Function
End Class


End Namespace
