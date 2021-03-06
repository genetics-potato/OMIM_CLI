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
''' CosmicNCV.tsv\n\nNon coding variants\n\nA tab separated file of all non-coding mutations from the current release. (CosmicNCV).\n
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cosmic_ncv`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cosmic_ncv` (
'''   `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
'''   `Id NCV` varchar(45) DEFAULT NULL COMMENT 'unique non-coding variant identifier.',
'''   `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
'''   `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
'''   `Genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnate of the mutation.',
'''   `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.   ',
'''   `WT SEQ` varchar(45) DEFAULT NULL COMMENT 'wild type sequence.',
'''   `MUT SEQ` varchar(45) DEFAULT NULL COMMENT 'Mutated sequence.',
'''   `SNP` varchar(45) DEFAULT NULL COMMENT ' All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
'''   `FATHMM_MKL_NON_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL non-coding score. A p-value ranging from 0 to 1 where >= 0.7 is functionally significant.',
'''   `FATHMM_MKL_NON_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification. More details from here.',
'''   `FATHMM_MKL_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL coding score (p-value ranging from 0 to 1).',
'''   `FATHMM_MKL_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification (coding). More details from here.',
'''   `Whole Genome Reseq` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome is sequenced.',
'''   `Whole_Exome` varchar(45) DEFAULT NULL COMMENT 'if the enitre exome is sequenced.',
'''   `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this non coding mutation.',
'''   `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
'''   PRIMARY KEY (`Sample name`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicNCV.tsv\n\nNon coding variants\n\nA tab separated file of all non-coding mutations from the current release. (CosmicNCV).\n';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cosmic_ncv", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cosmic_ncv` (
  `Sample name` varchar(45) NOT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id Sample` varchar(45) DEFAULT NULL COMMENT 'A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.',
  `Id NCV` varchar(45) DEFAULT NULL COMMENT 'unique non-coding variant identifier.',
  `Zygosity` varchar(45) DEFAULT NULL COMMENT 'Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.',
  `GRCh` varchar(45) DEFAULT NULL COMMENT 'The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     ',
  `Genome position` varchar(45) DEFAULT NULL COMMENT 'The genomic cooridnate of the mutation.',
  `Mutation somatic status` varchar(45) DEFAULT NULL COMMENT 'Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.   ',
  `WT SEQ` varchar(45) DEFAULT NULL COMMENT 'wild type sequence.',
  `MUT SEQ` varchar(45) DEFAULT NULL COMMENT 'Mutated sequence.',
  `SNP` varchar(45) DEFAULT NULL COMMENT ' All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.',
  `FATHMM_MKL_NON_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL non-coding score. A p-value ranging from 0 to 1 where >= 0.7 is functionally significant.',
  `FATHMM_MKL_NON_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification. More details from here.',
  `FATHMM_MKL_CODING_SCORE` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL coding score (p-value ranging from 0 to 1).',
  `FATHMM_MKL_CODING_GROUPS` varchar(45) DEFAULT NULL COMMENT 'FATHMM-MKL group classification (coding). More details from here.',
  `Whole Genome Reseq` varchar(45) DEFAULT NULL COMMENT 'if the enitre genome is sequenced.',
  `Whole_Exome` varchar(45) DEFAULT NULL COMMENT 'if the enitre exome is sequenced.',
  `Id Study` varchar(45) DEFAULT NULL COMMENT 'Lists the unique Ids of studies that have involved this non coding mutation.',
  `Pubmed_PMID` varchar(45) DEFAULT NULL COMMENT 'The PUBMED ID for the paper that the sample was noted in.',
  PRIMARY KEY (`Sample name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='CosmicNCV.tsv\n\nNon coding variants\n\nA tab separated file of all non-coding mutations from the current release. (CosmicNCV).\n';")>
Public Class cosmic_ncv: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Sample name"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Sample name"), XmlAttribute> Public Property Sample_name As String
''' <summary>
''' A sample is an instance of a portion of a tumour being examined for mutations. The sample name can be derived from a number of sources. In many cases it originates from the cell line name. Other sources include names assigned by the annotators, or an incremented number assigned during an anonymisation process. A number of samples can be taken from a single tumour and a number of tumours can be obtained from one individual. A sample id is used to identify a sample within the COSMIC database. There can be multiple ids, if the same sample has been entered into the database multiple times from different papers.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Sample"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Sample")> Public Property Id_Sample As String
''' <summary>
''' unique non-coding variant identifier.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id NCV"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id NCV")> Public Property Id_NCV As String
''' <summary>
''' Information on whether the mutation was reported to be homozygous , heterozygous or unknown within the sample.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Zygosity"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Zygosity")> Public Property Zygosity As String
''' <summary>
''' The coordinate system used -\n\n        38 = GRCh38/Hg38\n        37 = GRCh37/Hg19     
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("GRCh"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="GRCh")> Public Property GRCh As String
''' <summary>
''' The genomic cooridnate of the mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Genome position"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Genome position")> Public Property Genome_position As String
''' <summary>
''' Information on whether the sample was reported to be Confirmed Somatic, Previously Reported or Variant of unknown origin -\n\n        variant of unknown origin = when the mutation is known to be somatic but the tumour was sequenced without a matched normal.\n        Confirmed Somatic = if the mutation has been confimed to be somatic in the experiment by sequencing both the tumour and a matched normal from the same patient.\n        Previously observed = when the mutation has been reported as somatic previously but not in current paper.   
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Mutation somatic status"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation somatic status")> Public Property Mutation_somatic_status As String
''' <summary>
''' wild type sequence.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("WT SEQ"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="WT SEQ")> Public Property WT_SEQ As String
''' <summary>
''' Mutated sequence.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("MUT SEQ"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="MUT SEQ")> Public Property MUT_SEQ As String
''' <summary>
'''  All the known SNPs are flagged as ''y'' defined by the 1000 genomes project, dbSNP and a panel of 378 normal (non-cancer) samples from Sanger CGP sequencing.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("SNP"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="SNP")> Public Property SNP As String
''' <summary>
''' FATHMM-MKL non-coding score. A p-value ranging from 0 to 1 where >= 0.7 is functionally significant.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM_MKL_NON_CODING_SCORE"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM_MKL_NON_CODING_SCORE")> Public Property FATHMM_MKL_NON_CODING_SCORE As String
''' <summary>
''' FATHMM-MKL group classification. More details from here.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM_MKL_NON_CODING_GROUPS"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM_MKL_NON_CODING_GROUPS")> Public Property FATHMM_MKL_NON_CODING_GROUPS As String
''' <summary>
''' FATHMM-MKL coding score (p-value ranging from 0 to 1).
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM_MKL_CODING_SCORE"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM_MKL_CODING_SCORE")> Public Property FATHMM_MKL_CODING_SCORE As String
''' <summary>
''' FATHMM-MKL group classification (coding). More details from here.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("FATHMM_MKL_CODING_GROUPS"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="FATHMM_MKL_CODING_GROUPS")> Public Property FATHMM_MKL_CODING_GROUPS As String
''' <summary>
''' if the enitre genome is sequenced.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Whole Genome Reseq"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Whole Genome Reseq")> Public Property Whole_Genome_Reseq As String
''' <summary>
''' if the enitre exome is sequenced.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Whole_Exome"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Whole_Exome")> Public Property Whole_Exome As String
''' <summary>
''' Lists the unique Ids of studies that have involved this non coding mutation.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Id Study"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Id Study")> Public Property Id_Study As String
''' <summary>
''' The PUBMED ID for the paper that the sample was noted in.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Pubmed_PMID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Pubmed_PMID")> Public Property Pubmed_PMID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cosmic_ncv` (`Sample name`, `Id Sample`, `Id NCV`, `Zygosity`, `GRCh`, `Genome position`, `Mutation somatic status`, `WT SEQ`, `MUT SEQ`, `SNP`, `FATHMM_MKL_NON_CODING_SCORE`, `FATHMM_MKL_NON_CODING_GROUPS`, `FATHMM_MKL_CODING_SCORE`, `FATHMM_MKL_CODING_GROUPS`, `Whole Genome Reseq`, `Whole_Exome`, `Id Study`, `Pubmed_PMID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cosmic_ncv` (`Sample name`, `Id Sample`, `Id NCV`, `Zygosity`, `GRCh`, `Genome position`, `Mutation somatic status`, `WT SEQ`, `MUT SEQ`, `SNP`, `FATHMM_MKL_NON_CODING_SCORE`, `FATHMM_MKL_NON_CODING_GROUPS`, `FATHMM_MKL_CODING_SCORE`, `FATHMM_MKL_CODING_GROUPS`, `Whole Genome Reseq`, `Whole_Exome`, `Id Study`, `Pubmed_PMID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cosmic_ncv` WHERE `Sample name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cosmic_ncv` SET `Sample name`='{0}', `Id Sample`='{1}', `Id NCV`='{2}', `Zygosity`='{3}', `GRCh`='{4}', `Genome position`='{5}', `Mutation somatic status`='{6}', `WT SEQ`='{7}', `MUT SEQ`='{8}', `SNP`='{9}', `FATHMM_MKL_NON_CODING_SCORE`='{10}', `FATHMM_MKL_NON_CODING_GROUPS`='{11}', `FATHMM_MKL_CODING_SCORE`='{12}', `FATHMM_MKL_CODING_GROUPS`='{13}', `Whole Genome Reseq`='{14}', `Whole_Exome`='{15}', `Id Study`='{16}', `Pubmed_PMID`='{17}' WHERE `Sample name` = '{18}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cosmic_ncv` WHERE `Sample name` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Sample_name)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cosmic_ncv` (`Sample name`, `Id Sample`, `Id NCV`, `Zygosity`, `GRCh`, `Genome position`, `Mutation somatic status`, `WT SEQ`, `MUT SEQ`, `SNP`, `FATHMM_MKL_NON_CODING_SCORE`, `FATHMM_MKL_NON_CODING_GROUPS`, `FATHMM_MKL_CODING_SCORE`, `FATHMM_MKL_CODING_GROUPS`, `Whole Genome Reseq`, `Whole_Exome`, `Id Study`, `Pubmed_PMID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Sample_name, Id_Sample, Id_NCV, Zygosity, GRCh, Genome_position, Mutation_somatic_status, WT_SEQ, MUT_SEQ, SNP, FATHMM_MKL_NON_CODING_SCORE, FATHMM_MKL_NON_CODING_GROUPS, FATHMM_MKL_CODING_SCORE, FATHMM_MKL_CODING_GROUPS, Whole_Genome_Reseq, Whole_Exome, Id_Study, Pubmed_PMID)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Sample_name}', '{Id_Sample}', '{Id_NCV}', '{Zygosity}', '{GRCh}', '{Genome_position}', '{Mutation_somatic_status}', '{WT_SEQ}', '{MUT_SEQ}', '{SNP}', '{FATHMM_MKL_NON_CODING_SCORE}', '{FATHMM_MKL_NON_CODING_GROUPS}', '{FATHMM_MKL_CODING_SCORE}', '{FATHMM_MKL_CODING_GROUPS}', '{Whole_Genome_Reseq}', '{Whole_Exome}', '{Id_Study}', '{Pubmed_PMID}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cosmic_ncv` (`Sample name`, `Id Sample`, `Id NCV`, `Zygosity`, `GRCh`, `Genome position`, `Mutation somatic status`, `WT SEQ`, `MUT SEQ`, `SNP`, `FATHMM_MKL_NON_CODING_SCORE`, `FATHMM_MKL_NON_CODING_GROUPS`, `FATHMM_MKL_CODING_SCORE`, `FATHMM_MKL_CODING_GROUPS`, `Whole Genome Reseq`, `Whole_Exome`, `Id Study`, `Pubmed_PMID`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Sample_name, Id_Sample, Id_NCV, Zygosity, GRCh, Genome_position, Mutation_somatic_status, WT_SEQ, MUT_SEQ, SNP, FATHMM_MKL_NON_CODING_SCORE, FATHMM_MKL_NON_CODING_GROUPS, FATHMM_MKL_CODING_SCORE, FATHMM_MKL_CODING_GROUPS, Whole_Genome_Reseq, Whole_Exome, Id_Study, Pubmed_PMID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cosmic_ncv` SET `Sample name`='{0}', `Id Sample`='{1}', `Id NCV`='{2}', `Zygosity`='{3}', `GRCh`='{4}', `Genome position`='{5}', `Mutation somatic status`='{6}', `WT SEQ`='{7}', `MUT SEQ`='{8}', `SNP`='{9}', `FATHMM_MKL_NON_CODING_SCORE`='{10}', `FATHMM_MKL_NON_CODING_GROUPS`='{11}', `FATHMM_MKL_CODING_SCORE`='{12}', `FATHMM_MKL_CODING_GROUPS`='{13}', `Whole Genome Reseq`='{14}', `Whole_Exome`='{15}', `Id Study`='{16}', `Pubmed_PMID`='{17}' WHERE `Sample name` = '{18}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Sample_name, Id_Sample, Id_NCV, Zygosity, GRCh, Genome_position, Mutation_somatic_status, WT_SEQ, MUT_SEQ, SNP, FATHMM_MKL_NON_CODING_SCORE, FATHMM_MKL_NON_CODING_GROUPS, FATHMM_MKL_CODING_SCORE, FATHMM_MKL_CODING_GROUPS, Whole_Genome_Reseq, Whole_Exome, Id_Study, Pubmed_PMID, Sample_name)
    End Function
#End Region
Public Function Clone() As cosmic_ncv
                  Return DirectCast(MyClass.MemberwiseClone, cosmic_ncv)
              End Function
End Class


End Namespace
