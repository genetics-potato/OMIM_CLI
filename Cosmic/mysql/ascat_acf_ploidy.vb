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
''' A tab separated file listing the ploidy and aberrant cell fraction (purity estimate), for TCGA samples re-analysed using ASCAT. (ascat_acf_ploidy).\nascat_acf_ploidy.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `ascat_acf_ploidy`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `ascat_acf_ploidy` (
'''   `Cancer_Type_Code` varchar(45) NOT NULL COMMENT 'The disease code (decode available from https://tcga-data.nci.nih.gov/datareports/codeTablesReport.htm).',
'''   `Sample` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
'''   `Aberrant_Cell_Fraction(Purity)` varchar(45) DEFAULT NULL COMMENT 'The aberrant cell fraction (purity estimate).',
'''   `Ploidy` varchar(45) DEFAULT NULL COMMENT 'The ploidy of the genome.',
'''   PRIMARY KEY (`Cancer_Type_Code`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the ploidy and aberrant cell fraction (purity estimate), for TCGA samples re-analysed using ASCAT. (ascat_acf_ploidy).\nascat_acf_ploidy.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("ascat_acf_ploidy", Database:="cosmic", SchemaSQL:="
CREATE TABLE `ascat_acf_ploidy` (
  `Cancer_Type_Code` varchar(45) NOT NULL COMMENT 'The disease code (decode available from https://tcga-data.nci.nih.gov/datareports/codeTablesReport.htm).',
  `Sample` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
  `Aberrant_Cell_Fraction(Purity)` varchar(45) DEFAULT NULL COMMENT 'The aberrant cell fraction (purity estimate).',
  `Ploidy` varchar(45) DEFAULT NULL COMMENT 'The ploidy of the genome.',
  PRIMARY KEY (`Cancer_Type_Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the ploidy and aberrant cell fraction (purity estimate), for TCGA samples re-analysed using ASCAT. (ascat_acf_ploidy).\nascat_acf_ploidy.tsv';")>
Public Class ascat_acf_ploidy: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' The disease code (decode available from https://tcga-data.nci.nih.gov/datareports/codeTablesReport.htm).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Cancer_Type_Code"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Cancer_Type_Code"), XmlAttribute> Public Property Cancer_Type_Code As String
''' <summary>
''' The name of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample")> Public Property Sample As String
''' <summary>
''' The aberrant cell fraction (purity estimate).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Aberrant_Cell_Fraction(Purity)"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Aberrant_Cell_Fraction(Purity)")> Public Property Aberrant_Cell_Fraction_Purity_ As String
''' <summary>
''' The ploidy of the genome.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Ploidy"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Ploidy")> Public Property Ploidy As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `ascat_acf_ploidy` (`Cancer_Type_Code`, `Sample`, `Aberrant_Cell_Fraction(Purity)`, `Ploidy`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `ascat_acf_ploidy` (`Cancer_Type_Code`, `Sample`, `Aberrant_Cell_Fraction(Purity)`, `Ploidy`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `ascat_acf_ploidy` WHERE `Cancer_Type_Code` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `ascat_acf_ploidy` SET `Cancer_Type_Code`='{0}', `Sample`='{1}', `Aberrant_Cell_Fraction(Purity)`='{2}', `Ploidy`='{3}' WHERE `Cancer_Type_Code` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `ascat_acf_ploidy` WHERE `Cancer_Type_Code` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Cancer_Type_Code)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `ascat_acf_ploidy` (`Cancer_Type_Code`, `Sample`, `Aberrant_Cell_Fraction(Purity)`, `Ploidy`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Cancer_Type_Code, Sample, Aberrant_Cell_Fraction_Purity_, Ploidy)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Cancer_Type_Code}', '{Sample}', '{Aberrant_Cell_Fraction_Purity_}', '{Ploidy}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `ascat_acf_ploidy` (`Cancer_Type_Code`, `Sample`, `Aberrant_Cell_Fraction(Purity)`, `Ploidy`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Cancer_Type_Code, Sample, Aberrant_Cell_Fraction_Purity_, Ploidy)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `ascat_acf_ploidy` SET `Cancer_Type_Code`='{0}', `Sample`='{1}', `Aberrant_Cell_Fraction(Purity)`='{2}', `Ploidy`='{3}' WHERE `Cancer_Type_Code` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Cancer_Type_Code, Sample, Aberrant_Cell_Fraction_Purity_, Ploidy, Cancer_Type_Code)
    End Function
#End Region
Public Function Clone() As ascat_acf_ploidy
                  Return DirectCast(MyClass.MemberwiseClone, ascat_acf_ploidy)
              End Function
End Class


End Namespace
