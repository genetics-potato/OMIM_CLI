REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @3/30/2017 10:01:19 PM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_snp_effects`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_snp_effects` (
'''   `drug` varchar(45) NOT NULL,
'''   `protein_name` varchar(45) DEFAULT NULL,
'''   `gene_symbol` varchar(45) DEFAULT NULL,
'''   `uniprot` varchar(45) DEFAULT NULL,
'''   `rs_ID` varchar(45) DEFAULT NULL,
'''   `defining_change` varchar(45) DEFAULT NULL,
'''   `description` varchar(45) DEFAULT NULL,
'''   `allele` varchar(45) DEFAULT NULL,
'''   `pubmed_id` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_snp_effects", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_snp_effects` (
  `drug` varchar(45) NOT NULL,
  `protein_name` varchar(45) DEFAULT NULL,
  `gene_symbol` varchar(45) DEFAULT NULL,
  `uniprot` varchar(45) DEFAULT NULL,
  `rs_ID` varchar(45) DEFAULT NULL,
  `defining_change` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `allele` varchar(45) DEFAULT NULL,
  `pubmed_id` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_snp_effects: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("protein_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="protein_name")> Public Property protein_name As String
    <DatabaseField("gene_symbol"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="gene_symbol")> Public Property gene_symbol As String
    <DatabaseField("uniprot"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="uniprot")> Public Property uniprot As String
    <DatabaseField("rs_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="rs_ID")> Public Property rs_ID As String
    <DatabaseField("defining_change"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="defining_change")> Public Property defining_change As String
    <DatabaseField("description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="description")> Public Property description As String
    <DatabaseField("allele"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="allele")> Public Property allele As String
    <DatabaseField("pubmed_id"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="pubmed_id")> Public Property pubmed_id As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_snp_effects` (`drug`, `protein_name`, `gene_symbol`, `uniprot`, `rs_ID`, `defining_change`, `description`, `allele`, `pubmed_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_snp_effects` (`drug`, `protein_name`, `gene_symbol`, `uniprot`, `rs_ID`, `defining_change`, `description`, `allele`, `pubmed_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_snp_effects` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_snp_effects` SET `drug`='{0}', `protein_name`='{1}', `gene_symbol`='{2}', `uniprot`='{3}', `rs_ID`='{4}', `defining_change`='{5}', `description`='{6}', `allele`='{7}', `pubmed_id`='{8}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_snp_effects` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_snp_effects` (`drug`, `protein_name`, `gene_symbol`, `uniprot`, `rs_ID`, `defining_change`, `description`, `allele`, `pubmed_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, protein_name, gene_symbol, uniprot, rs_ID, defining_change, description, allele, pubmed_id)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{protein_name}', '{gene_symbol}', '{uniprot}', '{rs_ID}', '{defining_change}', '{description}', '{allele}', '{pubmed_id}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_snp_effects` (`drug`, `protein_name`, `gene_symbol`, `uniprot`, `rs_ID`, `defining_change`, `description`, `allele`, `pubmed_id`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, protein_name, gene_symbol, uniprot, rs_ID, defining_change, description, allele, pubmed_id)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_snp_effects` SET `drug`='{0}', `protein_name`='{1}', `gene_symbol`='{2}', `uniprot`='{3}', `rs_ID`='{4}', `defining_change`='{5}', `description`='{6}', `allele`='{7}', `pubmed_id`='{8}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
End Class


End Namespace
