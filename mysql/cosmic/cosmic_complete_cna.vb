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
''' CosmicCompleteCNA.tsv\n\nCopy Number Variants\n\nAll copy number abberations from the current release in a tab separated file. For more information on copy number data, please see here. (CosmicCompleteCNA).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_complete_cna`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_complete_cna` (
'''   `CNV_ID` varchar(45) NOT NULL COMMENT 'The unique identifier for the variant (not stable, differs between releases).',
'''   `Id gene` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
'''   `Gene name` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
'''   `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Sample Name` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
'''   `Total_CN` varchar(45) DEFAULT NULL COMMENT 'The sum of the major and minor allele counts eg if ABB, total copy number = 3.',
'''   `Minor Allele` varchar(45) DEFAULT NULL COMMENT 'The number of copies of the least frequent allele eg if ABB, minor allele = A ( 1 copy) and major allele = B ( 2 copies).',
'''   `Mut Type` varchar(45) DEFAULT NULL COMMENT 'Defined as Gain or Loss. For ICGC samples; as defined in the original data. For TCGA samples reanalysed with ASCAT -\n\n        GAIN = average genome ploidy &lt;= 2.7 AND total copy number >= 5 OR average genome ploidy > 2.7 AND total copy number >= 9\n        LOSS = average genome ploidy &lt;= 2.7 AND total copy number = 0 OR average ge',
'''   `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this copy number variation.',
'''   `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
'''   `Chromosome:G_Start..G_Stop` varchar(45) DEFAULT NULL COMMENT 'The genomic coordinates of the variation.',
'''   PRIMARY KEY (`CNV_ID`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicCompleteCNA.tsv\n\nCopy Number Variants\n\nAll copy number abberations from the current release in a tab separated file. For more information on copy number data, please see here. (CosmicCompleteCNA).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_complete_cna", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_complete_cna` (
  `CNV_ID` varchar(45) NOT NULL COMMENT 'The unique identifier for the variant (not stable, differs between releases).',
  `Id gene` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
  `Gene name` varchar(45) DEFAULT NULL COMMENT 'The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).',
  `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Primary Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology Subtype 1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology Subtype 2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology Subtype 3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Sample Name` varchar(45) DEFAULT NULL COMMENT 'The name of the sample.',
  `Total_CN` varchar(45) DEFAULT NULL COMMENT 'The sum of the major and minor allele counts eg if ABB, total copy number = 3.',
  `Minor Allele` varchar(45) DEFAULT NULL COMMENT 'The number of copies of the least frequent allele eg if ABB, minor allele = A ( 1 copy) and major allele = B ( 2 copies).',
  `Mut Type` varchar(45) DEFAULT NULL COMMENT 'Defined as Gain or Loss. For ICGC samples; as defined in the original data. For TCGA samples reanalysed with ASCAT -\n\n        GAIN = average genome ploidy &lt;= 2.7 AND total copy number >= 5 OR average genome ploidy > 2.7 AND total copy number >= 9\n        LOSS = average genome ploidy &lt;= 2.7 AND total copy number = 0 OR average ge',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this copy number variation.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
  `Chromosome:G_Start..G_Stop` varchar(45) DEFAULT NULL COMMENT 'The genomic coordinates of the variation.',
  PRIMARY KEY (`CNV_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicCompleteCNA.tsv\n\nCopy Number Variants\n\nAll copy number abberations from the current release in a tab separated file. For more information on copy number data, please see here. (CosmicCompleteCNA).';")>
Public Class cosmic_complete_cna: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' The unique identifier for the variant (not stable, differs between releases).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("CNV_ID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="CNV_ID"), XmlAttribute> Public Property CNV_ID As String
''' <summary>
''' The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id gene"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id gene")> Public Property Id_gene As String
''' <summary>
''' The ID and symbol of the gene which overlaps the copy number segment (or ''-'' where there is no overlapping gene).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene name")> Public Property Gene_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Sample"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Sample")> Public Property Id_Sample As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id tumour"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id tumour")> Public Property Id_tumour As String
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
''' The name of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample Name")> Public Property Sample_Name As String
''' <summary>
''' The sum of the major and minor allele counts eg if ABB, total copy number = 3.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Total_CN"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Total_CN")> Public Property Total_CN As String
''' <summary>
''' The number of copies of the least frequent allele eg if ABB, minor allele = A ( 1 copy) and major allele = B ( 2 copies).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Minor Allele"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Minor Allele")> Public Property Minor_Allele As String
''' <summary>
''' Defined as Gain or Loss. For ICGC samples; as defined in the original data. For TCGA samples reanalysed with ASCAT -\n\n        GAIN = average genome ploidy &lt;= 2.7 AND total copy number >= 5 OR average genome ploidy > 2.7 AND total copy number >= 9\n        LOSS = average genome ploidy &lt;= 2.7 AND total copy number = 0 OR average ge
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mut Type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mut Type")> Public Property Mut_Type As String
''' <summary>
''' Lists the unique Ids of studies that have involved this copy number variation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Study")> Public Property Id_Study As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("GRCh"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="GRCh")> Public Property GRCh As String
''' <summary>
''' The genomic coordinates of the variation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Chromosome:G_Start..G_Stop"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Chromosome:G_Start..G_Stop")> Public Property Chromosome_G_Start__G_Stop As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_complete_cna` (`CNV_ID`, `Id gene`, `Gene name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Sample Name`, `Total_CN`, `Minor Allele`, `Mut Type`, `Id Study`, `GRCh`, `Chromosome:G_Start..G_Stop`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_complete_cna` (`CNV_ID`, `Id gene`, `Gene name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Sample Name`, `Total_CN`, `Minor Allele`, `Mut Type`, `Id Study`, `GRCh`, `Chromosome:G_Start..G_Stop`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_complete_cna` WHERE `CNV_ID` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_complete_cna` SET `CNV_ID`='{0}', `Id gene`='{1}', `Gene name`='{2}', `Id Sample`='{3}', `Id tumour`='{4}', `Primary Site`='{5}', `Site Subtype 1`='{6}', `Site Subtype 2`='{7}', `Site Subtype 3`='{8}', `Primary Histology`='{9}', `Histology Subtype 1`='{10}', `Histology Subtype 2`='{11}', `Histology Subtype 3`='{12}', `Sample Name`='{13}', `Total_CN`='{14}', `Minor Allele`='{15}', `Mut Type`='{16}', `Id Study`='{17}', `GRCh`='{18}', `Chromosome:G_Start..G_Stop`='{19}' WHERE `CNV_ID` = '{20}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_complete_cna` WHERE `CNV_ID` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, CNV_ID)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_complete_cna` (`CNV_ID`, `Id gene`, `Gene name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Sample Name`, `Total_CN`, `Minor Allele`, `Mut Type`, `Id Study`, `GRCh`, `Chromosome:G_Start..G_Stop`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, CNV_ID, Id_gene, Gene_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Sample_Name, Total_CN, Minor_Allele, Mut_Type, Id_Study, GRCh, Chromosome_G_Start__G_Stop)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{CNV_ID}', '{Id_gene}', '{Gene_name}', '{Id_Sample}', '{Id_tumour}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Sample_Name}', '{Total_CN}', '{Minor_Allele}', '{Mut_Type}', '{Id_Study}', '{GRCh}', '{Chromosome_G_Start__G_Stop}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_complete_cna` (`CNV_ID`, `Id gene`, `Gene name`, `Id Sample`, `Id tumour`, `Primary Site`, `Site Subtype 1`, `Site Subtype 2`, `Site Subtype 3`, `Primary Histology`, `Histology Subtype 1`, `Histology Subtype 2`, `Histology Subtype 3`, `Sample Name`, `Total_CN`, `Minor Allele`, `Mut Type`, `Id Study`, `GRCh`, `Chromosome:G_Start..G_Stop`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, CNV_ID, Id_gene, Gene_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Sample_Name, Total_CN, Minor_Allele, Mut_Type, Id_Study, GRCh, Chromosome_G_Start__G_Stop)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_complete_cna` SET `CNV_ID`='{0}', `Id gene`='{1}', `Gene name`='{2}', `Id Sample`='{3}', `Id tumour`='{4}', `Primary Site`='{5}', `Site Subtype 1`='{6}', `Site Subtype 2`='{7}', `Site Subtype 3`='{8}', `Primary Histology`='{9}', `Histology Subtype 1`='{10}', `Histology Subtype 2`='{11}', `Histology Subtype 3`='{12}', `Sample Name`='{13}', `Total_CN`='{14}', `Minor Allele`='{15}', `Mut Type`='{16}', `Id Study`='{17}', `GRCh`='{18}', `Chromosome:G_Start..G_Stop`='{19}' WHERE `CNV_ID` = '{20}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, CNV_ID, Id_gene, Gene_name, Id_Sample, Id_tumour, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Sample_Name, Total_CN, Minor_Allele, Mut_Type, Id_Study, GRCh, Chromosome_G_Start__G_Stop, CNV_ID)
    End Function
#End Region
Public Function Clone() As cosmic_complete_cna
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_complete_cna)
              End Function
End Class


End Namespace
