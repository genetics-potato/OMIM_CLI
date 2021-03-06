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
''' A tab separated file listing the details of all mutations in COSMIC which are known to confer drug resistance. (CosmicResistanceMutations).\nCosmicResistanceMutations.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `resistance_mutations`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `resistance_mutations` (
'''   `Sample_name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Sample_id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Gene_Name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
'''   `Transcript` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier (accession number) of the gene.',
'''   `Census_Gene` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer Gene Census (Yes, or No).',
'''   `Drug_Name` varchar(45) DEFAULT NULL COMMENT ' The name of the drug which the mutation confers resistance to.',
'''   `ID_Mutation` varchar(45) DEFAULT NULL COMMENT 'The unique mutation identifier (COSM).',
'''   `AA_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society.',
'''   `CDS_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
'''   `Primary_Tissue` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
'''   `Tissue_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
'''   `Tissue_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
'''   `Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
'''   `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
'''   `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
'''   `Pubmed_ID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
'''   `CGP_Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
'''   `Somatic_Status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper. ',
'''   `Sample_Source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
'''   `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
'''   `Genome Coordinates (GRCh38)` varchar(45) DEFAULT NULL COMMENT 'The genome location of the mutation (chr:start..end), on the specified genome version.',
'''   PRIMARY KEY (`Sample_name`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the details of all mutations in COSMIC which are known to confer drug resistance. (CosmicResistanceMutations).\nCosmicResistanceMutations.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("resistance_mutations", Database:="cosmic", SchemaSQL:="
CREATE TABLE `resistance_mutations` (
  `Sample_name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Sample_id` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Gene_Name` varchar(45) DEFAULT NULL COMMENT 'The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.',
  `Transcript` varchar(45) DEFAULT NULL COMMENT 'The transcript identifier (accession number) of the gene.',
  `Census_Gene` varchar(45) DEFAULT NULL COMMENT 'Is the gene in the Cancer Gene Census (Yes, or No).',
  `Drug_Name` varchar(45) DEFAULT NULL COMMENT ' The name of the drug which the mutation confers resistance to.',
  `ID_Mutation` varchar(45) DEFAULT NULL COMMENT 'The unique mutation identifier (COSM).',
  `AA_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society.',
  `CDS_Mutation` varchar(45) DEFAULT NULL COMMENT 'The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.',
  `Primary_Tissue` varchar(45) DEFAULT NULL COMMENT 'The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.',
  `Tissue_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 1) of the samples tissue of origin.',
  `Tissue_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further sub classification (level 2) of the samples tissue of origin.',
  `Histology` varchar(45) DEFAULT NULL COMMENT 'The histological classification of the sample.',
  `Histology_Subtype_1` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 1) of the sample.',
  `Histology_Subtype_2` varchar(45) DEFAULT NULL COMMENT 'Further histological classification (level 2) of the sample.',
  `Pubmed_ID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.',
  `CGP_Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this sample.',
  `Somatic_Status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper. ',
  `Sample_Source` varchar(45) DEFAULT NULL COMMENT 'Describes where the sample has originated from including the tumour type.',
  `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `Genome Coordinates (GRCh38)` varchar(45) DEFAULT NULL COMMENT 'The genome location of the mutation (chr:start..end), on the specified genome version.',
  PRIMARY KEY (`Sample_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the details of all mutations in COSMIC which are known to confer drug resistance. (CosmicResistanceMutations).\nCosmicResistanceMutations.tsv';")>
Public Class resistance_mutations: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_name"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_name"), XmlAttribute> Public Property Sample_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_id")> Public Property Sample_id As String
''' <summary>
''' The gene name for which the data has been curated in COSMIC. In most cases this is the accepted HGNC identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene_Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene_Name")> Public Property Gene_Name As String
''' <summary>
''' The transcript identifier (accession number) of the gene.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Transcript"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Transcript")> Public Property Transcript As String
''' <summary>
''' Is the gene in the Cancer Gene Census (Yes, or No).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Census_Gene"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Census_Gene")> Public Property Census_Gene As String
''' <summary>
'''  The name of the drug which the mutation confers resistance to.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Drug_Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Drug_Name")> Public Property Drug_Name As String
''' <summary>
''' The unique mutation identifier (COSM).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("ID_Mutation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="ID_Mutation")> Public Property ID_Mutation As String
''' <summary>
''' The change that has occurred in the peptide sequence. Formatting is based on the recommendations made by the Human Genome Variation Society.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("AA_Mutation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="AA_Mutation")> Public Property AA_Mutation As String
''' <summary>
''' The change that has occurred in the nucleotide sequence. Formatting is identical to the method used for the peptide sequence.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("CDS_Mutation"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="CDS_Mutation")> Public Property CDS_Mutation As String
''' <summary>
''' The primary tissue/cancer from which the sample originated. More details on the tissue classification are avaliable from here. In COSMIC we have standard classification system for tissue types and sub types because they vary a lot between different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Primary_Tissue"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Primary_Tissue")> Public Property Primary_Tissue As String
''' <summary>
''' Further sub classification (level 1) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Tissue_Subtype_1"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tissue_Subtype_1")> Public Property Tissue_Subtype_1 As String
''' <summary>
''' Further sub classification (level 2) of the samples tissue of origin.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Tissue_Subtype_2"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tissue_Subtype_2")> Public Property Tissue_Subtype_2 As String
''' <summary>
''' The histological classification of the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Histology"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Histology")> Public Property Histology As String
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
''' The PUBMED ID for the paper that the sample was noted in, linking to pubmed to provide more details of the publication.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_ID")> Public Property Pubmed_ID As String
''' <summary>
''' Lists the unique Ids of studies that have involved this sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("CGP_Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="CGP_Study")> Public Property CGP_Study As String
''' <summary>
''' Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        Variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper. 
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Somatic_Status"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Somatic_Status")> Public Property Somatic_Status As String
''' <summary>
''' Describes where the sample has originated from including the tumour type.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample_Source"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample_Source")> Public Property Sample_Source As String
''' <summary>
''' Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Zygosity"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Zygosity")> Public Property Zygosity As String
''' <summary>
''' The genome location of the mutation (chr:start..end), on the specified genome version.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Genome Coordinates (GRCh38)"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Genome Coordinates (GRCh38)")> Public Property Genome_Coordinates__GRCh38_ As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `resistance_mutations` (`Sample_name`, `Sample_id`, `Gene_Name`, `Transcript`, `Census_Gene`, `Drug_Name`, `ID_Mutation`, `AA_Mutation`, `CDS_Mutation`, `Primary_Tissue`, `Tissue_Subtype_1`, `Tissue_Subtype_2`, `Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Pubmed_ID`, `CGP_Study`, `Somatic_Status`, `Sample_Source`, `Zygosity`, `Genome Coordinates (GRCh38)`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `resistance_mutations` (`Sample_name`, `Sample_id`, `Gene_Name`, `Transcript`, `Census_Gene`, `Drug_Name`, `ID_Mutation`, `AA_Mutation`, `CDS_Mutation`, `Primary_Tissue`, `Tissue_Subtype_1`, `Tissue_Subtype_2`, `Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Pubmed_ID`, `CGP_Study`, `Somatic_Status`, `Sample_Source`, `Zygosity`, `Genome Coordinates (GRCh38)`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `resistance_mutations` WHERE `Sample_name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `resistance_mutations` SET `Sample_name`='{0}', `Sample_id`='{1}', `Gene_Name`='{2}', `Transcript`='{3}', `Census_Gene`='{4}', `Drug_Name`='{5}', `ID_Mutation`='{6}', `AA_Mutation`='{7}', `CDS_Mutation`='{8}', `Primary_Tissue`='{9}', `Tissue_Subtype_1`='{10}', `Tissue_Subtype_2`='{11}', `Histology`='{12}', `Histology_Subtype_1`='{13}', `Histology_Subtype_2`='{14}', `Pubmed_ID`='{15}', `CGP_Study`='{16}', `Somatic_Status`='{17}', `Sample_Source`='{18}', `Zygosity`='{19}', `Genome Coordinates (GRCh38)`='{20}' WHERE `Sample_name` = '{21}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `resistance_mutations` WHERE `Sample_name` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_name)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `resistance_mutations` (`Sample_name`, `Sample_id`, `Gene_Name`, `Transcript`, `Census_Gene`, `Drug_Name`, `ID_Mutation`, `AA_Mutation`, `CDS_Mutation`, `Primary_Tissue`, `Tissue_Subtype_1`, `Tissue_Subtype_2`, `Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Pubmed_ID`, `CGP_Study`, `Somatic_Status`, `Sample_Source`, `Zygosity`, `Genome Coordinates (GRCh38)`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_name, Sample_id, Gene_Name, Transcript, Census_Gene, Drug_Name, ID_Mutation, AA_Mutation, CDS_Mutation, Primary_Tissue, Tissue_Subtype_1, Tissue_Subtype_2, Histology, Histology_Subtype_1, Histology_Subtype_2, Pubmed_ID, CGP_Study, Somatic_Status, Sample_Source, Zygosity, Genome_Coordinates__GRCh38_)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_name}', '{Sample_id}', '{Gene_Name}', '{Transcript}', '{Census_Gene}', '{Drug_Name}', '{ID_Mutation}', '{AA_Mutation}', '{CDS_Mutation}', '{Primary_Tissue}', '{Tissue_Subtype_1}', '{Tissue_Subtype_2}', '{Histology}', '{Histology_Subtype_1}', '{Histology_Subtype_2}', '{Pubmed_ID}', '{CGP_Study}', '{Somatic_Status}', '{Sample_Source}', '{Zygosity}', '{Genome_Coordinates__GRCh38_}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `resistance_mutations` (`Sample_name`, `Sample_id`, `Gene_Name`, `Transcript`, `Census_Gene`, `Drug_Name`, `ID_Mutation`, `AA_Mutation`, `CDS_Mutation`, `Primary_Tissue`, `Tissue_Subtype_1`, `Tissue_Subtype_2`, `Histology`, `Histology_Subtype_1`, `Histology_Subtype_2`, `Pubmed_ID`, `CGP_Study`, `Somatic_Status`, `Sample_Source`, `Zygosity`, `Genome Coordinates (GRCh38)`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_name, Sample_id, Gene_Name, Transcript, Census_Gene, Drug_Name, ID_Mutation, AA_Mutation, CDS_Mutation, Primary_Tissue, Tissue_Subtype_1, Tissue_Subtype_2, Histology, Histology_Subtype_1, Histology_Subtype_2, Pubmed_ID, CGP_Study, Somatic_Status, Sample_Source, Zygosity, Genome_Coordinates__GRCh38_)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `resistance_mutations` SET `Sample_name`='{0}', `Sample_id`='{1}', `Gene_Name`='{2}', `Transcript`='{3}', `Census_Gene`='{4}', `Drug_Name`='{5}', `ID_Mutation`='{6}', `AA_Mutation`='{7}', `CDS_Mutation`='{8}', `Primary_Tissue`='{9}', `Tissue_Subtype_1`='{10}', `Tissue_Subtype_2`='{11}', `Histology`='{12}', `Histology_Subtype_1`='{13}', `Histology_Subtype_2`='{14}', `Pubmed_ID`='{15}', `CGP_Study`='{16}', `Somatic_Status`='{17}', `Sample_Source`='{18}', `Zygosity`='{19}', `Genome Coordinates (GRCh38)`='{20}' WHERE `Sample_name` = '{21}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_name, Sample_id, Gene_Name, Transcript, Census_Gene, Drug_Name, ID_Mutation, AA_Mutation, CDS_Mutation, Primary_Tissue, Tissue_Subtype_1, Tissue_Subtype_2, Histology, Histology_Subtype_1, Histology_Subtype_2, Pubmed_ID, CGP_Study, Somatic_Status, Sample_Source, Zygosity, Genome_Coordinates__GRCh38_, Sample_name)
    End Function
#End Region
Public Function Clone() As resistance_mutations
                  Return DirectCast(MyClass.MemberwiseClone, resistance_mutations)
              End Function
End Class


End Namespace
