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
''' A tab separated file showing the relationship between the Cancer Gene Census, COSMIC ID, Gene Name, HGNC ID and Entrez ID. (CosmicHGNC).\nCosmicHGNC.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `hgnc`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `hgnc` (
'''   `cosmic_ID` varchar(45) NOT NULL COMMENT 'COSMIC Gene ID (COSG*).',
'''   `cosmic_gene_name` varchar(45) DEFAULT NULL COMMENT 'Gene name used in COSMIC.',
'''   `entrez_ID` varchar(45) DEFAULT NULL COMMENT 'Entrez ID mapping.',
'''   `HGNC_ID` varchar(45) DEFAULT NULL COMMENT 'HGNC mapping.',
'''   `mutated?` varchar(45) DEFAULT NULL COMMENT 'Does the gene have coding mutations y/n.',
'''   `cancer_census?` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer gene census y/n.',
'''   `expert_curated?` varchar(45) DEFAULT NULL COMMENT 'Has the gene been manually curated by the team of expert curators y/n.',
'''   PRIMARY KEY (`cosmic_ID`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file showing the relationship between the Cancer Gene Census, COSMIC ID, Gene Name, HGNC ID and Entrez ID. (CosmicHGNC).\nCosmicHGNC.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("hgnc", Database:="cosmic", SchemaSQL:="
CREATE TABLE `hgnc` (
  `cosmic_ID` varchar(45) NOT NULL COMMENT 'COSMIC Gene ID (COSG*).',
  `cosmic_gene_name` varchar(45) DEFAULT NULL COMMENT 'Gene name used in COSMIC.',
  `entrez_ID` varchar(45) DEFAULT NULL COMMENT 'Entrez ID mapping.',
  `HGNC_ID` varchar(45) DEFAULT NULL COMMENT 'HGNC mapping.',
  `mutated?` varchar(45) DEFAULT NULL COMMENT 'Does the gene have coding mutations y/n.',
  `cancer_census?` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer gene census y/n.',
  `expert_curated?` varchar(45) DEFAULT NULL COMMENT 'Has the gene been manually curated by the team of expert curators y/n.',
  PRIMARY KEY (`cosmic_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file showing the relationship between the Cancer Gene Census, COSMIC ID, Gene Name, HGNC ID and Entrez ID. (CosmicHGNC).\nCosmicHGNC.tsv';")>
Public Class hgnc: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' COSMIC Gene ID (COSG*).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("cosmic_ID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="cosmic_ID"), XmlAttribute> Public Property cosmic_ID As String
''' <summary>
''' Gene name used in COSMIC.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("cosmic_gene_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="cosmic_gene_name")> Public Property cosmic_gene_name As String
''' <summary>
''' Entrez ID mapping.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("entrez_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="entrez_ID")> Public Property entrez_ID As String
''' <summary>
''' HGNC mapping.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("HGNC_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="HGNC_ID")> Public Property HGNC_ID As String
''' <summary>
''' Does the gene have coding mutations y/n.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("mutated?"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="mutated?")> Public Property mutated_ As String
''' <summary>
''' Is the gene in the Cancer gene census y/n.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("cancer_census?"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="cancer_census?")> Public Property cancer_census_ As String
''' <summary>
''' Has the gene been manually curated by the team of expert curators y/n.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("expert_curated?"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="expert_curated?")> Public Property expert_curated_ As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `hgnc` (`cosmic_ID`, `cosmic_gene_name`, `entrez_ID`, `HGNC_ID`, `mutated?`, `cancer_census?`, `expert_curated?`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `hgnc` (`cosmic_ID`, `cosmic_gene_name`, `entrez_ID`, `HGNC_ID`, `mutated?`, `cancer_census?`, `expert_curated?`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `hgnc` WHERE `cosmic_ID` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `hgnc` SET `cosmic_ID`='{0}', `cosmic_gene_name`='{1}', `entrez_ID`='{2}', `HGNC_ID`='{3}', `mutated?`='{4}', `cancer_census?`='{5}', `expert_curated?`='{6}' WHERE `cosmic_ID` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `hgnc` WHERE `cosmic_ID` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, cosmic_ID)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `hgnc` (`cosmic_ID`, `cosmic_gene_name`, `entrez_ID`, `HGNC_ID`, `mutated?`, `cancer_census?`, `expert_curated?`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, cosmic_ID, cosmic_gene_name, entrez_ID, HGNC_ID, mutated_, cancer_census_, expert_curated_)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{cosmic_ID}', '{cosmic_gene_name}', '{entrez_ID}', '{HGNC_ID}', '{mutated_}', '{cancer_census_}', '{expert_curated_}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `hgnc` (`cosmic_ID`, `cosmic_gene_name`, `entrez_ID`, `HGNC_ID`, `mutated?`, `cancer_census?`, `expert_curated?`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, cosmic_ID, cosmic_gene_name, entrez_ID, HGNC_ID, mutated_, cancer_census_, expert_curated_)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `hgnc` SET `cosmic_ID`='{0}', `cosmic_gene_name`='{1}', `entrez_ID`='{2}', `HGNC_ID`='{3}', `mutated?`='{4}', `cancer_census?`='{5}', `expert_curated?`='{6}' WHERE `cosmic_ID` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, cosmic_ID, cosmic_gene_name, entrez_ID, HGNC_ID, mutated_, cancer_census_, expert_curated_, cosmic_ID)
    End Function
#End Region
Public Function Clone() As hgnc
                  Return DirectCast(MyClass.MemberwiseClone, hgnc)
              End Function
End Class


End Namespace
