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
''' CosmicStructExport.tsv\n\nStructural Variants\n\nAll structural variants from the current release in a tab separated file. (CosmicStructExport).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_struct_export`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_struct_export` (
'''   `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual.',
'''   `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
'''   `Mutation Type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.',
'''   `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19 ',
'''   `Description` varchar(45) DEFAULT NULL COMMENT 'A syntax which describes the structural variant, based on HGVS recommendations.',
'''   `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
'''   `ID_STUDY` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
'''   PRIMARY KEY (`Sample name`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicStructExport.tsv\n\nStructural Variants\n\nAll structural variants from the current release in a tab separated file. (CosmicStructExport).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_struct_export", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_struct_export` (
  `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Mutation Id` varchar(45) DEFAULT NULL COMMENT 'unique mutation identifier.',
  `Mutation Type` varchar(45) DEFAULT NULL COMMENT 'Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19 ',
  `Description` varchar(45) DEFAULT NULL COMMENT 'A syntax which describes the structural variant, based on HGVS recommendations.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  `ID_STUDY` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this structural mutation.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicStructExport.tsv\n\nStructural Variants\n\nAll structural variants from the current release in a tab separated file. (CosmicStructExport).';")>
Public Class cosmic_struct_export: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample name"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample name"), XmlAttribute> Public Property Sample_name As String
''' <summary>
''' The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary Site"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary Site")> Public Property Primary_Site As String
''' <summary>
''' Further sub classification (level 1) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 1")> Public Property Site_Subtype_1 As String
''' <summary>
''' Further sub classification (level 2) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 2")> Public Property Site_Subtype_2 As String
''' <summary>
''' Further sub classification (level 3) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site Subtype 3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site Subtype 3")> Public Property Site_Subtype_3 As String
''' <summary>
''' The histological classification of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary Histology")> Public Property Primary_Histology As String
''' <summary>
''' Further histological classification (level 1) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 1")> Public Property Histology_Subtype_1 As String
''' <summary>
''' Further histological classification (level 2) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 2")> Public Property Histology_Subtype_2 As String
''' <summary>
''' Further histological classification (level 3) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology Subtype 3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology Subtype 3")> Public Property Histology_Subtype_3 As String
''' <summary>
''' unique mutation identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Id")> Public Property Mutation_Id As String
''' <summary>
''' Type of mutation : Intra/Inter (chromosomal), tandem duplication, deletion, inversion, complex substitutions, complex amplicons.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation Type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Type")> Public Property Mutation_Type As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19 
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("GRCh"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="GRCh")> Public Property GRCh As String
''' <summary>
''' A syntax which describes the structural variant, based on HGVS recommendations.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Description")> Public Property Description As String
''' <summary>
''' The PUBMED ID for the paper that the sample was noted in.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_PMID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_PMID")> Public Property Pubmed_PMID As String
''' <summary>
''' Lists the unique Ids of studies that have involved this structural mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("ID_STUDY"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="ID_STUDY")> Public Property ID_STUDY As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_struct_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Id`, `Mutation Type`, `GRCh`, `Description`, `Pubmed_PMID`, `ID_STUDY`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_struct_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Id`, `Mutation Type`, `GRCh`, `Description`, `Pubmed_PMID`, `ID_STUDY`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_struct_export` WHERE `Sample name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_struct_export` SET `Sample name`='{0}', `Primary Site`='{1}', `Site Subtype 1`='{2}', `Site Subtype 2`='{3}', `Site Subtype 3`='{4}', `Primary Histology`='{5}', `Histology Subtype 1`='{6}', `Histology Subtype 2`='{7}', `Histology Subtype 3`='{8}', `Mutation Id`='{9}', `Mutation Type`='{10}', `GRCh`='{11}', `Description`='{12}', `Pubmed_PMID`='{13}', `ID_STUDY`='{14}' WHERE `Sample name` = '{15}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_struct_export` WHERE `Sample name` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_name)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_struct_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Id`, `Mutation Type`, `GRCh`, `Description`, `Pubmed_PMID`, `ID_STUDY`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Id, Mutation_Type, GRCh, Description, Pubmed_PMID, ID_STUDY)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_name}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Mutation_Id}', '{Mutation_Type}', '{GRCh}', '{Description}', '{Pubmed_PMID}', '{ID_STUDY}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_struct_export` (`Sample name`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Mutation Id`, `Mutation Type`, `GRCh`, `Description`, `Pubmed_PMID`, `ID_STUDY`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Id, Mutation_Type, GRCh, Description, Pubmed_PMID, ID_STUDY)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_struct_export` SET `Sample name`='{0}', `Primary Site`='{1}', `Site Subtype 1`='{2}', `Site Subtype 2`='{3}', `Site Subtype 3`='{4}', `Primary Histology`='{5}', `Histology Subtype 1`='{6}', `Histology Subtype 2`='{7}', `Histology Subtype 3`='{8}', `Mutation Id`='{9}', `Mutation Type`='{10}', `GRCh`='{11}', `Description`='{12}', `Pubmed_PMID`='{13}', `ID_STUDY`='{14}' WHERE `Sample name` = '{15}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_name, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Mutation_Id, Mutation_Type, GRCh, Description, Pubmed_PMID, ID_STUDY, Sample_name)
    End Function
#End Region
Public Function Clone() As cosmic_struct_export
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_struct_export)
              End Function
End Class


End Namespace
