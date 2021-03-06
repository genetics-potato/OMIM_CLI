REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/10/24 11:04:05


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' A comma separated table of COSMIC cancer classification information. (classification).\nclassification.csv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `classification`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `classification` (
'''   `Site_Primary` varchar(45) NOT NULL COMMENT 'Primary tissue specified in the publication.',
'''   `Site_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
'''   `Site_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
'''   `Site_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
'''   `Histology` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in the publication.',
'''   `Hist_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
'''   `Hist_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
'''   `Hist_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
'''   `Site_Primary_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary tissue specified in COSMIC.',
'''   `Site_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
'''   `Site_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
'''   `Site_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
'''   `Histology_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in COSMIC.',
'''   `Hist_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
'''   `Hist_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
'''   `Hist_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
'''   PRIMARY KEY (`Site_Primary`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A comma separated table of COSMIC cancer classification information. (classification).\nclassification.csv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("classification", Database:="cosmic", SchemaSQL:="
CREATE TABLE `classification` (
  `Site_Primary` varchar(45) NOT NULL COMMENT 'Primary tissue specified in the publication.',
  `Site_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Site_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Site_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in the publication.',
  `Histology` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in the publication.',
  `Hist_Subtype1` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Hist_Subtype2` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Hist_Subtype3` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in the publication.',
  `Site_Primary_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary tissue specified in COSMIC.',
  `Site_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Site_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Site_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub tissue specified in COSMIC.',
  `Histology_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Primary histology specified in COSMIC.',
  `Hist_Subtype1_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  `Hist_Subtype2_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  `Hist_Subtype3_COSMIC` varchar(45) DEFAULT NULL COMMENT 'Sub histology specified in COSMIC.',
  PRIMARY KEY (`Site_Primary`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A comma separated table of COSMIC cancer classification information. (classification).\nclassification.csv';")>
Public Class classification: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' Primary tissue specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Primary"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Primary"), XmlAttribute> Public Property Site_Primary As String
''' <summary>
''' Sub tissue specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype1")> Public Property Site_Subtype1 As String
''' <summary>
''' Sub tissue specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype2")> Public Property Site_Subtype2 As String
''' <summary>
''' Sub tissue specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype3")> Public Property Site_Subtype3 As String
''' <summary>
''' Primary histology specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology")> Public Property Histology As String
''' <summary>
''' Sub histology specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype1")> Public Property Hist_Subtype1 As String
''' <summary>
''' Sub histology specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype2")> Public Property Hist_Subtype2 As String
''' <summary>
''' Sub histology specified in the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype3")> Public Property Hist_Subtype3 As String
''' <summary>
''' Primary tissue specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Primary_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Primary_COSMIC")> Public Property Site_Primary_COSMIC As String
''' <summary>
''' Sub tissue specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype1_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype1_COSMIC")> Public Property Site_Subtype1_COSMIC As String
''' <summary>
''' Sub tissue specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype2_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype2_COSMIC")> Public Property Site_Subtype2_COSMIC As String
''' <summary>
''' Sub tissue specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype3_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype3_COSMIC")> Public Property Site_Subtype3_COSMIC As String
''' <summary>
''' Primary histology specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_COSMIC")> Public Property Histology_COSMIC As String
''' <summary>
''' Sub histology specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype1_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype1_COSMIC")> Public Property Hist_Subtype1_COSMIC As String
''' <summary>
''' Sub histology specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype2_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype2_COSMIC")> Public Property Hist_Subtype2_COSMIC As String
''' <summary>
''' Sub histology specified in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Hist_Subtype3_COSMIC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Hist_Subtype3_COSMIC")> Public Property Hist_Subtype3_COSMIC As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `classification` (`Site_Primary`, `Site_Subtype1`, `Site_Subtype2`, `Site_Subtype3`, `Histology`, `Hist_Subtype1`, `Hist_Subtype2`, `Hist_Subtype3`, `Site_Primary_COSMIC`, `Site_Subtype1_COSMIC`, `Site_Subtype2_COSMIC`, `Site_Subtype3_COSMIC`, `Histology_COSMIC`, `Hist_Subtype1_COSMIC`, `Hist_Subtype2_COSMIC`, `Hist_Subtype3_COSMIC`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `classification` (`Site_Primary`, `Site_Subtype1`, `Site_Subtype2`, `Site_Subtype3`, `Histology`, `Hist_Subtype1`, `Hist_Subtype2`, `Hist_Subtype3`, `Site_Primary_COSMIC`, `Site_Subtype1_COSMIC`, `Site_Subtype2_COSMIC`, `Site_Subtype3_COSMIC`, `Histology_COSMIC`, `Hist_Subtype1_COSMIC`, `Hist_Subtype2_COSMIC`, `Hist_Subtype3_COSMIC`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `classification` WHERE `Site_Primary` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `classification` SET `Site_Primary`='{0}', `Site_Subtype1`='{1}', `Site_Subtype2`='{2}', `Site_Subtype3`='{3}', `Histology`='{4}', `Hist_Subtype1`='{5}', `Hist_Subtype2`='{6}', `Hist_Subtype3`='{7}', `Site_Primary_COSMIC`='{8}', `Site_Subtype1_COSMIC`='{9}', `Site_Subtype2_COSMIC`='{10}', `Site_Subtype3_COSMIC`='{11}', `Histology_COSMIC`='{12}', `Hist_Subtype1_COSMIC`='{13}', `Hist_Subtype2_COSMIC`='{14}', `Hist_Subtype3_COSMIC`='{15}' WHERE `Site_Primary` = '{16}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `classification` WHERE `Site_Primary` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Site_Primary)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `classification` (`Site_Primary`, `Site_Subtype1`, `Site_Subtype2`, `Site_Subtype3`, `Histology`, `Hist_Subtype1`, `Hist_Subtype2`, `Hist_Subtype3`, `Site_Primary_COSMIC`, `Site_Subtype1_COSMIC`, `Site_Subtype2_COSMIC`, `Site_Subtype3_COSMIC`, `Histology_COSMIC`, `Hist_Subtype1_COSMIC`, `Hist_Subtype2_COSMIC`, `Hist_Subtype3_COSMIC`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Site_Primary, Site_Subtype1, Site_Subtype2, Site_Subtype3, Histology, Hist_Subtype1, Hist_Subtype2, Hist_Subtype3, Site_Primary_COSMIC, Site_Subtype1_COSMIC, Site_Subtype2_COSMIC, Site_Subtype3_COSMIC, Histology_COSMIC, Hist_Subtype1_COSMIC, Hist_Subtype2_COSMIC, Hist_Subtype3_COSMIC)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Site_Primary}', '{Site_Subtype1}', '{Site_Subtype2}', '{Site_Subtype3}', '{Histology}', '{Hist_Subtype1}', '{Hist_Subtype2}', '{Hist_Subtype3}', '{Site_Primary_COSMIC}', '{Site_Subtype1_COSMIC}', '{Site_Subtype2_COSMIC}', '{Site_Subtype3_COSMIC}', '{Histology_COSMIC}', '{Hist_Subtype1_COSMIC}', '{Hist_Subtype2_COSMIC}', '{Hist_Subtype3_COSMIC}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `classification` (`Site_Primary`, `Site_Subtype1`, `Site_Subtype2`, `Site_Subtype3`, `Histology`, `Hist_Subtype1`, `Hist_Subtype2`, `Hist_Subtype3`, `Site_Primary_COSMIC`, `Site_Subtype1_COSMIC`, `Site_Subtype2_COSMIC`, `Site_Subtype3_COSMIC`, `Histology_COSMIC`, `Hist_Subtype1_COSMIC`, `Hist_Subtype2_COSMIC`, `Hist_Subtype3_COSMIC`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Site_Primary, Site_Subtype1, Site_Subtype2, Site_Subtype3, Histology, Hist_Subtype1, Hist_Subtype2, Hist_Subtype3, Site_Primary_COSMIC, Site_Subtype1_COSMIC, Site_Subtype2_COSMIC, Site_Subtype3_COSMIC, Histology_COSMIC, Hist_Subtype1_COSMIC, Hist_Subtype2_COSMIC, Hist_Subtype3_COSMIC)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `classification` SET `Site_Primary`='{0}', `Site_Subtype1`='{1}', `Site_Subtype2`='{2}', `Site_Subtype3`='{3}', `Histology`='{4}', `Hist_Subtype1`='{5}', `Hist_Subtype2`='{6}', `Hist_Subtype3`='{7}', `Site_Primary_COSMIC`='{8}', `Site_Subtype1_COSMIC`='{9}', `Site_Subtype2_COSMIC`='{10}', `Site_Subtype3_COSMIC`='{11}', `Histology_COSMIC`='{12}', `Hist_Subtype1_COSMIC`='{13}', `Hist_Subtype2_COSMIC`='{14}', `Hist_Subtype3_COSMIC`='{15}' WHERE `Site_Primary` = '{16}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Site_Primary, Site_Subtype1, Site_Subtype2, Site_Subtype3, Histology, Hist_Subtype1, Hist_Subtype2, Hist_Subtype3, Site_Primary_COSMIC, Site_Subtype1_COSMIC, Site_Subtype2_COSMIC, Site_Subtype3_COSMIC, Histology_COSMIC, Hist_Subtype1_COSMIC, Hist_Subtype2_COSMIC, Hist_Subtype3_COSMIC, Site_Primary)
    End Function
#End Region
Public Function Clone() As classification
                  Return DirectCast(MyClass.MemberwiseClone, classification)
              End Function
End Class


End Namespace
