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
''' cancer_gene_census.csv\n\nA list of all cancer census genes from the current release in a comma separated file. This file is exported from here and the format is the same. (cancer_gene_census).
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `cancer_gene_census`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `cancer_gene_census` (
'''   `Gene Symbol` varchar(45) NOT NULL,
'''   `Name` varchar(45) DEFAULT NULL,
'''   `Entrez GeneId` varchar(45) DEFAULT NULL,
'''   `Genome Location` varchar(45) DEFAULT NULL,
'''   `Chr Band` varchar(45) DEFAULT NULL,
'''   `Somatic` varchar(45) DEFAULT NULL,
'''   `Germline` varchar(45) DEFAULT NULL,
'''   `Tumour Types(Somatic)` varchar(45) DEFAULT NULL,
'''   `Tumour Types(Germline)` varchar(45) DEFAULT NULL,
'''   `Cancer Syndrome` varchar(45) DEFAULT NULL,
'''   `Tissue Type` varchar(45) DEFAULT NULL,
'''   `Molecular Genetics` varchar(45) DEFAULT NULL,
'''   `Role in Cancer` varchar(45) DEFAULT NULL,
'''   `Mutation Types` varchar(45) DEFAULT NULL,
'''   `Translocation Partner` varchar(45) DEFAULT NULL,
'''   `Other Germline Mut` varchar(45) DEFAULT NULL,
'''   `Other Syndrome` varchar(45) DEFAULT NULL,
'''   `Synonyms` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`Gene Symbol`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='cancer_gene_census.csv\n\nA list of all cancer census genes from the current release in a comma separated file. This file is exported from here and the format is the same. (cancer_gene_census).';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("cancer_gene_census", Database:="cosmic", SchemaSQL:="
CREATE TABLE `cancer_gene_census` (
  `Gene Symbol` varchar(45) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Entrez GeneId` varchar(45) DEFAULT NULL,
  `Genome Location` varchar(45) DEFAULT NULL,
  `Chr Band` varchar(45) DEFAULT NULL,
  `Somatic` varchar(45) DEFAULT NULL,
  `Germline` varchar(45) DEFAULT NULL,
  `Tumour Types(Somatic)` varchar(45) DEFAULT NULL,
  `Tumour Types(Germline)` varchar(45) DEFAULT NULL,
  `Cancer Syndrome` varchar(45) DEFAULT NULL,
  `Tissue Type` varchar(45) DEFAULT NULL,
  `Molecular Genetics` varchar(45) DEFAULT NULL,
  `Role in Cancer` varchar(45) DEFAULT NULL,
  `Mutation Types` varchar(45) DEFAULT NULL,
  `Translocation Partner` varchar(45) DEFAULT NULL,
  `Other Germline Mut` varchar(45) DEFAULT NULL,
  `Other Syndrome` varchar(45) DEFAULT NULL,
  `Synonyms` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Gene Symbol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='cancer_gene_census.csv\n\nA list of all cancer census genes from the current release in a comma separated file. This file is exported from here and the format is the same. (cancer_gene_census).';")>
Public Class cancer_gene_census: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("Gene Symbol"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene Symbol"), XmlAttribute> Public Property Gene_Symbol As String
    <DatabaseField("Name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Name")> Public Property Name As String
    <DatabaseField("Entrez GeneId"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Entrez GeneId")> Public Property Entrez_GeneId As String
    <DatabaseField("Genome Location"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Genome Location")> Public Property Genome_Location As String
    <DatabaseField("Chr Band"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Chr Band")> Public Property Chr_Band As String
    <DatabaseField("Somatic"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Somatic")> Public Property Somatic As String
    <DatabaseField("Germline"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Germline")> Public Property Germline As String
    <DatabaseField("Tumour Types(Somatic)"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tumour Types(Somatic)")> Public Property Tumour_Types_Somatic_ As String
    <DatabaseField("Tumour Types(Germline)"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tumour Types(Germline)")> Public Property Tumour_Types_Germline_ As String
    <DatabaseField("Cancer Syndrome"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Cancer Syndrome")> Public Property Cancer_Syndrome As String
    <DatabaseField("Tissue Type"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Tissue Type")> Public Property Tissue_Type As String
    <DatabaseField("Molecular Genetics"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Molecular Genetics")> Public Property Molecular_Genetics As String
    <DatabaseField("Role in Cancer"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Role in Cancer")> Public Property Role_in_Cancer As String
    <DatabaseField("Mutation Types"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Mutation Types")> Public Property Mutation_Types As String
    <DatabaseField("Translocation Partner"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Translocation Partner")> Public Property Translocation_Partner As String
    <DatabaseField("Other Germline Mut"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Other Germline Mut")> Public Property Other_Germline_Mut As String
    <DatabaseField("Other Syndrome"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Other Syndrome")> Public Property Other_Syndrome As String
    <DatabaseField("Synonyms"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="Synonyms")> Public Property Synonyms As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `cancer_gene_census` (`Gene Symbol`, `Name`, `Entrez GeneId`, `Genome Location`, `Chr Band`, `Somatic`, `Germline`, `Tumour Types(Somatic)`, `Tumour Types(Germline)`, `Cancer Syndrome`, `Tissue Type`, `Molecular Genetics`, `Role in Cancer`, `Mutation Types`, `Translocation Partner`, `Other Germline Mut`, `Other Syndrome`, `Synonyms`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `cancer_gene_census` (`Gene Symbol`, `Name`, `Entrez GeneId`, `Genome Location`, `Chr Band`, `Somatic`, `Germline`, `Tumour Types(Somatic)`, `Tumour Types(Germline)`, `Cancer Syndrome`, `Tissue Type`, `Molecular Genetics`, `Role in Cancer`, `Mutation Types`, `Translocation Partner`, `Other Germline Mut`, `Other Syndrome`, `Synonyms`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `cancer_gene_census` WHERE `Gene Symbol` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `cancer_gene_census` SET `Gene Symbol`='{0}', `Name`='{1}', `Entrez GeneId`='{2}', `Genome Location`='{3}', `Chr Band`='{4}', `Somatic`='{5}', `Germline`='{6}', `Tumour Types(Somatic)`='{7}', `Tumour Types(Germline)`='{8}', `Cancer Syndrome`='{9}', `Tissue Type`='{10}', `Molecular Genetics`='{11}', `Role in Cancer`='{12}', `Mutation Types`='{13}', `Translocation Partner`='{14}', `Other Germline Mut`='{15}', `Other Syndrome`='{16}', `Synonyms`='{17}' WHERE `Gene Symbol` = '{18}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `cancer_gene_census` WHERE `Gene Symbol` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Gene_Symbol)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `cancer_gene_census` (`Gene Symbol`, `Name`, `Entrez GeneId`, `Genome Location`, `Chr Band`, `Somatic`, `Germline`, `Tumour Types(Somatic)`, `Tumour Types(Germline)`, `Cancer Syndrome`, `Tissue Type`, `Molecular Genetics`, `Role in Cancer`, `Mutation Types`, `Translocation Partner`, `Other Germline Mut`, `Other Syndrome`, `Synonyms`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Gene_Symbol, Name, Entrez_GeneId, Genome_Location, Chr_Band, Somatic, Germline, Tumour_Types_Somatic_, Tumour_Types_Germline_, Cancer_Syndrome, Tissue_Type, Molecular_Genetics, Role_in_Cancer, Mutation_Types, Translocation_Partner, Other_Germline_Mut, Other_Syndrome, Synonyms)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Gene_Symbol}', '{Name}', '{Entrez_GeneId}', '{Genome_Location}', '{Chr_Band}', '{Somatic}', '{Germline}', '{Tumour_Types_Somatic_}', '{Tumour_Types_Germline_}', '{Cancer_Syndrome}', '{Tissue_Type}', '{Molecular_Genetics}', '{Role_in_Cancer}', '{Mutation_Types}', '{Translocation_Partner}', '{Other_Germline_Mut}', '{Other_Syndrome}', '{Synonyms}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `cancer_gene_census` (`Gene Symbol`, `Name`, `Entrez GeneId`, `Genome Location`, `Chr Band`, `Somatic`, `Germline`, `Tumour Types(Somatic)`, `Tumour Types(Germline)`, `Cancer Syndrome`, `Tissue Type`, `Molecular Genetics`, `Role in Cancer`, `Mutation Types`, `Translocation Partner`, `Other Germline Mut`, `Other Syndrome`, `Synonyms`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Gene_Symbol, Name, Entrez_GeneId, Genome_Location, Chr_Band, Somatic, Germline, Tumour_Types_Somatic_, Tumour_Types_Germline_, Cancer_Syndrome, Tissue_Type, Molecular_Genetics, Role_in_Cancer, Mutation_Types, Translocation_Partner, Other_Germline_Mut, Other_Syndrome, Synonyms)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `cancer_gene_census` SET `Gene Symbol`='{0}', `Name`='{1}', `Entrez GeneId`='{2}', `Genome Location`='{3}', `Chr Band`='{4}', `Somatic`='{5}', `Germline`='{6}', `Tumour Types(Somatic)`='{7}', `Tumour Types(Germline)`='{8}', `Cancer Syndrome`='{9}', `Tissue Type`='{10}', `Molecular Genetics`='{11}', `Role in Cancer`='{12}', `Mutation Types`='{13}', `Translocation Partner`='{14}', `Other Germline Mut`='{15}', `Other Syndrome`='{16}', `Synonyms`='{17}' WHERE `Gene Symbol` = '{18}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Gene_Symbol, Name, Entrez_GeneId, Genome_Location, Chr_Band, Somatic, Germline, Tumour_Types_Somatic_, Tumour_Types_Germline_, Cancer_Syndrome, Tissue_Type, Molecular_Genetics, Role_in_Cancer, Mutation_Types, Translocation_Partner, Other_Germline_Mut, Other_Syndrome, Synonyms, Gene_Symbol)
    End Function
#End Region
Public Function Clone() As cancer_gene_census
                  Return DirectCast(MyClass.MemberwiseClone, cancer_gene_census)
              End Function
End Class


End Namespace
