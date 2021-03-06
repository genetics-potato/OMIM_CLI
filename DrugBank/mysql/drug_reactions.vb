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
''' DROP TABLE IF EXISTS `drug_reactions`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_reactions` (
'''   `drug` varchar(45) NOT NULL,
'''   `sequence` varchar(45) DEFAULT NULL,
'''   `left1` varchar(45) DEFAULT NULL,
'''   `left2` varchar(45) DEFAULT NULL,
'''   `left3` varchar(45) DEFAULT NULL,
'''   `left4` varchar(45) DEFAULT NULL,
'''   `left5` varchar(45) DEFAULT NULL,
'''   `right1` varchar(45) DEFAULT NULL,
'''   `right2` varchar(45) DEFAULT NULL,
'''   `right3` varchar(45) DEFAULT NULL,
'''   `right4` varchar(45) DEFAULT NULL,
'''   `right5` varchar(45) DEFAULT NULL,
'''   `enzymes` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_reactions", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_reactions` (
  `drug` varchar(45) NOT NULL,
  `sequence` varchar(45) DEFAULT NULL,
  `left1` varchar(45) DEFAULT NULL,
  `left2` varchar(45) DEFAULT NULL,
  `left3` varchar(45) DEFAULT NULL,
  `left4` varchar(45) DEFAULT NULL,
  `left5` varchar(45) DEFAULT NULL,
  `right1` varchar(45) DEFAULT NULL,
  `right2` varchar(45) DEFAULT NULL,
  `right3` varchar(45) DEFAULT NULL,
  `right4` varchar(45) DEFAULT NULL,
  `right5` varchar(45) DEFAULT NULL,
  `enzymes` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_reactions: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("sequence"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="sequence")> Public Property sequence As String
    <DatabaseField("left1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="left1")> Public Property left1 As String
    <DatabaseField("left2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="left2")> Public Property left2 As String
    <DatabaseField("left3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="left3")> Public Property left3 As String
    <DatabaseField("left4"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="left4")> Public Property left4 As String
    <DatabaseField("left5"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="left5")> Public Property left5 As String
    <DatabaseField("right1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="right1")> Public Property right1 As String
    <DatabaseField("right2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="right2")> Public Property right2 As String
    <DatabaseField("right3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="right3")> Public Property right3 As String
    <DatabaseField("right4"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="right4")> Public Property right4 As String
    <DatabaseField("right5"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="right5")> Public Property right5 As String
    <DatabaseField("enzymes"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="enzymes")> Public Property enzymes As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_reactions` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_reactions` SET `drug`='{0}', `sequence`='{1}', `left1`='{2}', `left2`='{3}', `left3`='{4}', `left4`='{5}', `left5`='{6}', `right1`='{7}', `right2`='{8}', `right3`='{9}', `right4`='{10}', `right5`='{11}', `enzymes`='{12}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_reactions` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, sequence, left1, left2, left3, left4, left5, right1, right2, right3, right4, right5, enzymes)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{sequence}', '{left1}', '{left2}', '{left3}', '{left4}', '{left5}', '{right1}', '{right2}', '{right3}', '{right4}', '{right5}', '{enzymes}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_reactions` (`drug`, `sequence`, `left1`, `left2`, `left3`, `left4`, `left5`, `right1`, `right2`, `right3`, `right4`, `right5`, `enzymes`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, sequence, left1, left2, left3, left4, left5, right1, right2, right3, right4, right5, enzymes)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_reactions` SET `drug`='{0}', `sequence`='{1}', `left1`='{2}', `left2`='{3}', `left3`='{4}', `left4`='{5}', `left5`='{6}', `right1`='{7}', `right2`='{8}', `right3`='{9}', `right4`='{10}', `right5`='{11}', `enzymes`='{12}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_reactions
                  Return DirectCast(MyClass.MemberwiseClone, drug_reactions)
              End Function
End Class


End Namespace
