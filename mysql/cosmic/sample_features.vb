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
''' ll the features related to a sample from the current release in a tab separated file. (CosmicSample).\nCosmicSample.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `sample_features`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `sample_features` (
'''   `Sample_id` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Id_tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Id_Ind` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
'''   `Primary_Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Site_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Site_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Site_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
'''   `Primary_Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Histology_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
'''   `Therapy_Relationship` varchar(45) DEFAULT NULL COMMENT 'Relates the time-point of tissue sampling to the drug therapy used to treat the tumour.',
'''   `Sample_Differentiator` varchar(45) DEFAULT NULL COMMENT 'Gives additional information if more than one sample (e.g. carcinomatous and sarcomatous components) from a tumour has been screened for mutations or if samples from a tumour were taken at different time points.',
'''   `Mutation_Allele_Specification` varchar(45) DEFAULT NULL COMMENT 'Where a publication has information on more than one mutation for one gene in a sample and reports whether or not the mutations occurred on the same or different chromosomes.',
'''   `Msi` varchar(45) DEFAULT NULL COMMENT 'If microsatellite instability data is given in the publication per sample then High, Low, Stable/Low, MSI or Stable is reported in COSMIC. Unknown is the default.',
'''   `Average_Ploidy` varchar(45) DEFAULT NULL COMMENT 'The average ploidy of the sample, calculated from copy number data (where available).',
'''   `Whole_Genome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole genome screened.',
'''   `Whole_Exome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole exome sequenced.',
'''   `Sample_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional sample information e.g. % mutant allele burden.',
'''   `Drug_Response` varchar(45) DEFAULT NULL COMMENT 'Clinical and in vitro responses to drugs (particularly targeted drugs). Phrasing based on RECIST guidelines. Note that in COSMIC, SD (stable disease) and PD (progressive disease) = clinical primary non response.',
'''   `Grade` varchar(45) DEFAULT NULL COMMENT 'Grade of tumour. The phrase ''Some Grade data are given in publication'' is used when publication reports grade data or when data hasn''t been given per sample. More detailed data follow commonly used grading systems in tumours.',
'''   `Age_at_tumour_recurrence` varchar(45) DEFAULT NULL COMMENT 'Where both primary and recurrent tumour samples from an individual have been screened for mutations and the age (in years) of the patient at the time of the recurrence is different to that at diagnosis.',
'''   `Stage` varchar(45) DEFAULT NULL COMMENT 'Stage of tumour. The phrase ''Some Stage data are given in publication'' is used when publication reports stage data or when data hasn''t been given per sample. More detailed data follow commonly used staging systems in tumours.',
'''   `Cytogenetics` varchar(45) DEFAULT NULL COMMENT 'Karyotype of the tumour.',
'''   `Metastatic_Site` varchar(45) DEFAULT NULL COMMENT 'Tissue site of any metastases identified in an individual.',
'''   `Tumour_Source` varchar(45) DEFAULT NULL COMMENT 'Source of tumour tissue sample e.g. primary, metastasis.',
'''   `Tumour_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional tumour information e.g. metachronous tumour.',
'''   `Age` varchar(45) DEFAULT NULL COMMENT 'Age (in years) of individual at diagnosis.',
'''   `Ethnicity` varchar(45) DEFAULT NULL COMMENT 'Ethnicity (e.g. Caucasian) of individual.',
'''   `Environmental_Variables` varchar(45) DEFAULT NULL COMMENT 'Environmental variables to which an individual has been exposed (e.g. viral exposure, smoking status).',
'''   `Germline_Mutation` varchar(45) DEFAULT NULL COMMENT 'Gene name/mutation if a germline mutation as well as a somatic mutation has been detected in the same gene in the same tumour sample.',
'''   `Therapy` varchar(45) DEFAULT NULL COMMENT 'Any significant treatment an individual has received prior to mutation screening.',
'''   `Family` varchar(45) DEFAULT NULL COMMENT 'Any familial cancer history for an individual or familial relationships of individuals screened for mutations in the same publication.',
'''   `Normal_tissue_tested` varchar(45) DEFAULT NULL COMMENT 'If normal tissue from the same individual has been screened for mutations.',
'''   `Gender` varchar(45) DEFAULT NULL COMMENT 'Sex of individual.',
'''   `Individual_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional individual information (e.g. age group, hereditary syndromes).',
'''   `NCI_code` varchar(45) DEFAULT NULL COMMENT 'NCI thesaurus code for tumour histological classification.',
'''   PRIMARY KEY (`Sample_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='ll the features related to a sample from the current release in a tab separated file. (CosmicSample).\nCosmicSample.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("sample_features", Database:="cosmic", SchemaSQL:="
CREATE TABLE `sample_features` (
  `Sample_id` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Sample_name` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id_tumour` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Id_Ind` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.',
  `Primary_Site` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Site_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Site_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Site_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 3) of the samples tissue of origin.',
  `Primary_Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Histology_Subtype_3` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 3) of the sample.',
  `Therapy_Relationship` varchar(45) DEFAULT NULL COMMENT 'Relates the time-point of tissue sampling to the drug therapy used to treat the tumour.',
  `Sample_Differentiator` varchar(45) DEFAULT NULL COMMENT 'Gives additional information if more than one sample (e.g. carcinomatous and sarcomatous components) from a tumour has been screened for mutations or if samples from a tumour were taken at different time points.',
  `Mutation_Allele_Specification` varchar(45) DEFAULT NULL COMMENT 'Where a publication has information on more than one mutation for one gene in a sample and reports whether or not the mutations occurred on the same or different chromosomes.',
  `Msi` varchar(45) DEFAULT NULL COMMENT 'If microsatellite instability data is given in the publication per sample then High, Low, Stable/Low, MSI or Stable is reported in COSMIC. Unknown is the default.',
  `Average_Ploidy` varchar(45) DEFAULT NULL COMMENT 'The average ploidy of the sample, calculated from copy number data (where available).',
  `Whole_Genome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole genome screened.',
  `Whole_Exome_Screen` varchar(45) DEFAULT NULL COMMENT '''y'' if the sample was whole exome sequenced.',
  `Sample_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional sample information e.g. % mutant allele burden.',
  `Drug_Response` varchar(45) DEFAULT NULL COMMENT 'Clinical and in vitro responses to drugs (particularly targeted drugs). Phrasing based on RECIST guidelines. Note that in COSMIC, SD (stable disease) and PD (progressive disease) = clinical primary non response.',
  `Grade` varchar(45) DEFAULT NULL COMMENT 'Grade of tumour. The phrase ''Some Grade data are given in publication'' is used when publication reports grade data or when data hasn''t been given per sample. More detailed data follow commonly used grading systems in tumours.',
  `Age_at_tumour_recurrence` varchar(45) DEFAULT NULL COMMENT 'Where both primary and recurrent tumour samples from an individual have been screened for mutations and the age (in years) of the patient at the time of the recurrence is different to that at diagnosis.',
  `Stage` varchar(45) DEFAULT NULL COMMENT 'Stage of tumour. The phrase ''Some Stage data are given in publication'' is used when publication reports stage data or when data hasn''t been given per sample. More detailed data follow commonly used staging systems in tumours.',
  `Cytogenetics` varchar(45) DEFAULT NULL COMMENT 'Karyotype of the tumour.',
  `Metastatic_Site` varchar(45) DEFAULT NULL COMMENT 'Tissue site of any metastases identified in an individual.',
  `Tumour_Source` varchar(45) DEFAULT NULL COMMENT 'Source of tumour tissue sample e.g. primary, metastasis.',
  `Tumour_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional tumour information e.g. metachronous tumour.',
  `Age` varchar(45) DEFAULT NULL COMMENT 'Age (in years) of individual at diagnosis.',
  `Ethnicity` varchar(45) DEFAULT NULL COMMENT 'Ethnicity (e.g. Caucasian) of individual.',
  `Environmental_Variables` varchar(45) DEFAULT NULL COMMENT 'Environmental variables to which an individual has been exposed (e.g. viral exposure, smoking status).',
  `Germline_Mutation` varchar(45) DEFAULT NULL COMMENT 'Gene name/mutation if a germline mutation as well as a somatic mutation has been detected in the same gene in the same tumour sample.',
  `Therapy` varchar(45) DEFAULT NULL COMMENT 'Any significant treatment an individual has received prior to mutation screening.',
  `Family` varchar(45) DEFAULT NULL COMMENT 'Any familial cancer history for an individual or familial relationships of individuals screened for mutations in the same publication.',
  `Normal_tissue_tested` varchar(45) DEFAULT NULL COMMENT 'If normal tissue from the same individual has been screened for mutations.',
  `Gender` varchar(45) DEFAULT NULL COMMENT 'Sex of individual.',
  `Individual_Remark` varchar(45) DEFAULT NULL COMMENT 'Any additional individual information (e.g. age group, hereditary syndromes).',
  `NCI_code` varchar(45) DEFAULT NULL COMMENT 'NCI thesaurus code for tumour histological classification.',
  PRIMARY KEY (`Sample_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='ll the features related to a sample from the current release in a tab separated file. (CosmicSample).\nCosmicSample.tsv';")>
Public Class sample_features: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_id"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_id"), XmlAttribute> Public Property Sample_id As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_name")> Public Property Sample_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id_tumour"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id_tumour")> Public Property Id_tumour As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers. These samples are from the ICGC and TCGA.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id_Ind"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id_Ind")> Public Property Id_Ind As String
''' <summary>
''' The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary_Site"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary_Site")> Public Property Primary_Site As String
''' <summary>
''' Further sub classification (level 1) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_1")> Public Property Site_Subtype_1 As String
''' <summary>
''' Further sub classification (level 2) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_2")> Public Property Site_Subtype_2 As String
''' <summary>
''' Further sub classification (level 3) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Site_Subtype_3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Site_Subtype_3")> Public Property Site_Subtype_3 As String
''' <summary>
''' The histological classification of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary_Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary_Histology")> Public Property Primary_Histology As String
''' <summary>
''' Further histological classification (level 1) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_1")> Public Property Histology_Subtype_1 As String
''' <summary>
''' Further histological classification (level 2) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_2")> Public Property Histology_Subtype_2 As String
''' <summary>
''' Further histological classification (level 3) of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology_Subtype_3"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology_Subtype_3")> Public Property Histology_Subtype_3 As String
''' <summary>
''' Relates the time-point of tissue sampling to the drug therapy used to treat the tumour.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Therapy_Relationship"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Therapy_Relationship")> Public Property Therapy_Relationship As String
''' <summary>
''' Gives additional information if more than one sample (e.g. carcinomatous and sarcomatous components) from a tumour has been screened for mutations or if samples from a tumour were taken at different time points.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_Differentiator"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_Differentiator")> Public Property Sample_Differentiator As String
''' <summary>
''' Where a publication has information on more than one mutation for one gene in a sample and reports whether or not the mutations occurred on the same or different chromosomes.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation_Allele_Specification"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation_Allele_Specification")> Public Property Mutation_Allele_Specification As String
''' <summary>
''' If microsatellite instability data is given in the publication per sample then High, Low, Stable/Low, MSI or Stable is reported in COSMIC. Unknown is the default.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Msi"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Msi")> Public Property Msi As String
''' <summary>
''' The average ploidy of the sample, calculated from copy number data (where available).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Average_Ploidy"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Average_Ploidy")> Public Property Average_Ploidy As String
''' <summary>
''' ''y'' if the sample was whole genome screened.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Whole_Genome_Screen"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Whole_Genome_Screen")> Public Property Whole_Genome_Screen As String
''' <summary>
''' ''y'' if the sample was whole exome sequenced.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Whole_Exome_Screen"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Whole_Exome_Screen")> Public Property Whole_Exome_Screen As String
''' <summary>
''' Any additional sample information e.g. % mutant allele burden.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_Remark"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_Remark")> Public Property Sample_Remark As String
''' <summary>
''' Clinical and in vitro responses to drugs (particularly targeted drugs). Phrasing based on RECIST guidelines. Note that in COSMIC, SD (stable disease) and PD (progressive disease) = clinical primary non response.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Drug_Response"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Drug_Response")> Public Property Drug_Response As String
''' <summary>
''' Grade of tumour. The phrase ''Some Grade data are given in publication'' is used when publication reports grade data or when data hasn''t been given per sample. More detailed data follow commonly used grading systems in tumours.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Grade"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Grade")> Public Property Grade As String
''' <summary>
''' Where both primary and recurrent tumour samples from an individual have been screened for mutations and the age (in years) of the patient at the time of the recurrence is different to that at diagnosis.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Age_at_tumour_recurrence"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Age_at_tumour_recurrence")> Public Property Age_at_tumour_recurrence As String
''' <summary>
''' Stage of tumour. The phrase ''Some Stage data are given in publication'' is used when publication reports stage data or when data hasn''t been given per sample. More detailed data follow commonly used staging systems in tumours.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Stage"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Stage")> Public Property Stage As String
''' <summary>
''' Karyotype of the tumour.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Cytogenetics"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Cytogenetics")> Public Property Cytogenetics As String
''' <summary>
''' Tissue site of any metastases identified in an individual.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Metastatic_Site"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Metastatic_Site")> Public Property Metastatic_Site As String
''' <summary>
''' Source of tumour tissue sample e.g. primary, metastasis.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Tumour_Source"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tumour_Source")> Public Property Tumour_Source As String
''' <summary>
''' Any additional tumour information e.g. metachronous tumour.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Tumour_Remark"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tumour_Remark")> Public Property Tumour_Remark As String
''' <summary>
''' Age (in years) of individual at diagnosis.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Age"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Age")> Public Property Age As String
''' <summary>
''' Ethnicity (e.g. Caucasian) of individual.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Ethnicity"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Ethnicity")> Public Property Ethnicity As String
''' <summary>
''' Environmental variables to which an individual has been exposed (e.g. viral exposure, smoking status).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Environmental_Variables"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Environmental_Variables")> Public Property Environmental_Variables As String
''' <summary>
''' Gene name/mutation if a germline mutation as well as a somatic mutation has been detected in the same gene in the same tumour sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Germline_Mutation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Germline_Mutation")> Public Property Germline_Mutation As String
''' <summary>
''' Any significant treatment an individual has received prior to mutation screening.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Therapy"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Therapy")> Public Property Therapy As String
''' <summary>
''' Any familial cancer history for an individual or familial relationships of individuals screened for mutations in the same publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Family"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Family")> Public Property Family As String
''' <summary>
''' If normal tissue from the same individual has been screened for mutations.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Normal_tissue_tested"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Normal_tissue_tested")> Public Property Normal_tissue_tested As String
''' <summary>
''' Sex of individual.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gender"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gender")> Public Property Gender As String
''' <summary>
''' Any additional individual information (e.g. age group, hereditary syndromes).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Individual_Remark"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Individual_Remark")> Public Property Individual_Remark As String
''' <summary>
''' NCI thesaurus code for tumour histological classification.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("NCI_code"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="NCI_code")> Public Property NCI_code As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `sample_features` (`Sample_id`, `Sample_name`, `Id_tumour`, `Id_Ind`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Therapy_Relationship`, `Sample_Differentiator`, `Mutation_Allele_Specification`, `Msi`, `Average_Ploidy`, `Whole_Genome_Screen`, `Whole_Exome_Screen`, `Sample_Remark`, `Drug_Response`, `Grade`, `Age_at_tumour_recurrence`, `Stage`, `Cytogenetics`, `Metastatic_Site`, `Tumour_Source`, `Tumour_Remark`, `Age`, `Ethnicity`, `Environmental_Variables`, `Germline_Mutation`, `Therapy`, `Family`, `Normal_tissue_tested`, `Gender`, `Individual_Remark`, `NCI_code`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `sample_features` (`Sample_id`, `Sample_name`, `Id_tumour`, `Id_Ind`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Therapy_Relationship`, `Sample_Differentiator`, `Mutation_Allele_Specification`, `Msi`, `Average_Ploidy`, `Whole_Genome_Screen`, `Whole_Exome_Screen`, `Sample_Remark`, `Drug_Response`, `Grade`, `Age_at_tumour_recurrence`, `Stage`, `Cytogenetics`, `Metastatic_Site`, `Tumour_Source`, `Tumour_Remark`, `Age`, `Ethnicity`, `Environmental_Variables`, `Germline_Mutation`, `Therapy`, `Family`, `Normal_tissue_tested`, `Gender`, `Individual_Remark`, `NCI_code`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `sample_features` WHERE `Sample_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `sample_features` SET `Sample_id`='{0}', `Sample_name`='{1}', `Id_tumour`='{2}', `Id_Ind`='{3}', `Primary_Site`='{4}', `Site_Subtype_1`='{5}', `Site_Subtype_2`='{6}', `Site_Subtype_3`='{7}', `Primary_Histology`='{8}', `Histology_Subtype_1`='{9}', `Histology_Subtype_2`='{10}', `Histology_Subtype_3`='{11}', `Therapy_Relationship`='{12}', `Sample_Differentiator`='{13}', `Mutation_Allele_Specification`='{14}', `Msi`='{15}', `Average_Ploidy`='{16}', `Whole_Genome_Screen`='{17}', `Whole_Exome_Screen`='{18}', `Sample_Remark`='{19}', `Drug_Response`='{20}', `Grade`='{21}', `Age_at_tumour_recurrence`='{22}', `Stage`='{23}', `Cytogenetics`='{24}', `Metastatic_Site`='{25}', `Tumour_Source`='{26}', `Tumour_Remark`='{27}', `Age`='{28}', `Ethnicity`='{29}', `Environmental_Variables`='{30}', `Germline_Mutation`='{31}', `Therapy`='{32}', `Family`='{33}', `Normal_tissue_tested`='{34}', `Gender`='{35}', `Individual_Remark`='{36}', `NCI_code`='{37}' WHERE `Sample_id` = '{38}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `sample_features` WHERE `Sample_id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `sample_features` (`Sample_id`, `Sample_name`, `Id_tumour`, `Id_Ind`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Therapy_Relationship`, `Sample_Differentiator`, `Mutation_Allele_Specification`, `Msi`, `Average_Ploidy`, `Whole_Genome_Screen`, `Whole_Exome_Screen`, `Sample_Remark`, `Drug_Response`, `Grade`, `Age_at_tumour_recurrence`, `Stage`, `Cytogenetics`, `Metastatic_Site`, `Tumour_Source`, `Tumour_Remark`, `Age`, `Ethnicity`, `Environmental_Variables`, `Germline_Mutation`, `Therapy`, `Family`, `Normal_tissue_tested`, `Gender`, `Individual_Remark`, `NCI_code`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_id, Sample_name, Id_tumour, Id_Ind, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Therapy_Relationship, Sample_Differentiator, Mutation_Allele_Specification, Msi, Average_Ploidy, Whole_Genome_Screen, Whole_Exome_Screen, Sample_Remark, Drug_Response, Grade, Age_at_tumour_recurrence, Stage, Cytogenetics, Metastatic_Site, Tumour_Source, Tumour_Remark, Age, Ethnicity, Environmental_Variables, Germline_Mutation, Therapy, Family, Normal_tissue_tested, Gender, Individual_Remark, NCI_code)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_id}', '{Sample_name}', '{Id_tumour}', '{Id_Ind}', '{Primary_Site}', '{Site_Subtype_1}', '{Site_Subtype_2}', '{Site_Subtype_3}', '{Primary_Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Histology_Subtype_3}', '{Therapy_Relationship}', '{Sample_Differentiator}', '{Mutation_Allele_Specification}', '{Msi}', '{Average_Ploidy}', '{Whole_Genome_Screen}', '{Whole_Exome_Screen}', '{Sample_Remark}', '{Drug_Response}', '{Grade}', '{Age_at_tumour_recurrence}', '{Stage}', '{Cytogenetics}', '{Metastatic_Site}', '{Tumour_Source}', '{Tumour_Remark}', '{Age}', '{Ethnicity}', '{Environmental_Variables}', '{Germline_Mutation}', '{Therapy}', '{Family}', '{Normal_tissue_tested}', '{Gender}', '{Individual_Remark}', '{NCI_code}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `sample_features` (`Sample_id`, `Sample_name`, `Id_tumour`, `Id_Ind`, `Primary_Site`, `Site_Subtype_1`, `Site_Subtype_2`, `Site_Subtype_3`, `Primary_Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Histology_Subtype_3`, `Therapy_Relationship`, `Sample_Differentiator`, `Mutation_Allele_Specification`, `Msi`, `Average_Ploidy`, `Whole_Genome_Screen`, `Whole_Exome_Screen`, `Sample_Remark`, `Drug_Response`, `Grade`, `Age_at_tumour_recurrence`, `Stage`, `Cytogenetics`, `Metastatic_Site`, `Tumour_Source`, `Tumour_Remark`, `Age`, `Ethnicity`, `Environmental_Variables`, `Germline_Mutation`, `Therapy`, `Family`, `Normal_tissue_tested`, `Gender`, `Individual_Remark`, `NCI_code`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_id, Sample_name, Id_tumour, Id_Ind, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Therapy_Relationship, Sample_Differentiator, Mutation_Allele_Specification, Msi, Average_Ploidy, Whole_Genome_Screen, Whole_Exome_Screen, Sample_Remark, Drug_Response, Grade, Age_at_tumour_recurrence, Stage, Cytogenetics, Metastatic_Site, Tumour_Source, Tumour_Remark, Age, Ethnicity, Environmental_Variables, Germline_Mutation, Therapy, Family, Normal_tissue_tested, Gender, Individual_Remark, NCI_code)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `sample_features` SET `Sample_id`='{0}', `Sample_name`='{1}', `Id_tumour`='{2}', `Id_Ind`='{3}', `Primary_Site`='{4}', `Site_Subtype_1`='{5}', `Site_Subtype_2`='{6}', `Site_Subtype_3`='{7}', `Primary_Histology`='{8}', `Histology_Subtype_1`='{9}', `Histology_Subtype_2`='{10}', `Histology_Subtype_3`='{11}', `Therapy_Relationship`='{12}', `Sample_Differentiator`='{13}', `Mutation_Allele_Specification`='{14}', `Msi`='{15}', `Average_Ploidy`='{16}', `Whole_Genome_Screen`='{17}', `Whole_Exome_Screen`='{18}', `Sample_Remark`='{19}', `Drug_Response`='{20}', `Grade`='{21}', `Age_at_tumour_recurrence`='{22}', `Stage`='{23}', `Cytogenetics`='{24}', `Metastatic_Site`='{25}', `Tumour_Source`='{26}', `Tumour_Remark`='{27}', `Age`='{28}', `Ethnicity`='{29}', `Environmental_Variables`='{30}', `Germline_Mutation`='{31}', `Therapy`='{32}', `Family`='{33}', `Normal_tissue_tested`='{34}', `Gender`='{35}', `Individual_Remark`='{36}', `NCI_code`='{37}' WHERE `Sample_id` = '{38}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_id, Sample_name, Id_tumour, Id_Ind, Primary_Site, Site_Subtype_1, Site_Subtype_2, Site_Subtype_3, Primary_Histology, Histology_Subtype_1, Histology_Subtype_2, Histology_Subtype_3, Therapy_Relationship, Sample_Differentiator, Mutation_Allele_Specification, Msi, Average_Ploidy, Whole_Genome_Screen, Whole_Exome_Screen, Sample_Remark, Drug_Response, Grade, Age_at_tumour_recurrence, Stage, Cytogenetics, Metastatic_Site, Tumour_Source, Tumour_Remark, Age, Ethnicity, Environmental_Variables, Germline_Mutation, Therapy, Family, Normal_tissue_tested, Gender, Individual_Remark, NCI_code, Sample_id)
    End Function
#End Region
Public Function Clone() As sample_features
                  Return DirectCast(MyClass.MemberwiseClone, sample_features)
              End Function
End Class


End Namespace
