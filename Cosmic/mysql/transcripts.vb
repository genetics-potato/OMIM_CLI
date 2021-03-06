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
''' A tab separated file listing the gene name and transcript accession for each gene ID. (CosmicTranscripts).\nCosmicTranscripts.tsv
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `transcripts`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `transcripts` (
'''   `Gene_ID` varchar(45) NOT NULL COMMENT 'The unique ID of the gene.',
'''   `gene_name` varchar(45) DEFAULT NULL COMMENT 'The name of the gene.',
'''   `transcript_ID` varchar(45) DEFAULT NULL COMMENT 'The accession of the transcript.',
'''   PRIMARY KEY (`Gene_ID`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the gene name and transcript accession for each gene ID. (CosmicTranscripts).\nCosmicTranscripts.tsv';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping events for database 'cosmic'
''' --
''' 
''' --
''' -- Dumping routines for database 'cosmic'
''' --
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2017-04-05 11:30:32
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("transcripts", Database:="cosmic", SchemaSQL:="
CREATE TABLE `transcripts` (
  `Gene_ID` varchar(45) NOT NULL COMMENT 'The unique ID of the gene.',
  `gene_name` varchar(45) DEFAULT NULL COMMENT 'The name of the gene.',
  `transcript_ID` varchar(45) DEFAULT NULL COMMENT 'The accession of the transcript.',
  PRIMARY KEY (`Gene_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='A tab separated file listing the gene name and transcript accession for each gene ID. (CosmicTranscripts).\nCosmicTranscripts.tsv';")>
Public Class transcripts: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' The unique ID of the gene.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Gene_ID"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="Gene_ID"), XmlAttribute> Public Property Gene_ID As String
''' <summary>
''' The name of the gene.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("gene_name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="gene_name")> Public Property gene_name As String
''' <summary>
''' The accession of the transcript.
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("transcript_ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="transcript_ID")> Public Property transcript_ID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `transcripts` (`Gene_ID`, `gene_name`, `transcript_ID`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `transcripts` (`Gene_ID`, `gene_name`, `transcript_ID`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `transcripts` WHERE `Gene_ID` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `transcripts` SET `Gene_ID`='{0}', `gene_name`='{1}', `transcript_ID`='{2}' WHERE `Gene_ID` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `transcripts` WHERE `Gene_ID` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Gene_ID)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `transcripts` (`Gene_ID`, `gene_name`, `transcript_ID`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Gene_ID, gene_name, transcript_ID)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Gene_ID}', '{gene_name}', '{transcript_ID}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `transcripts` (`Gene_ID`, `gene_name`, `transcript_ID`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Gene_ID, gene_name, transcript_ID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `transcripts` SET `Gene_ID`='{0}', `gene_name`='{1}', `transcript_ID`='{2}' WHERE `Gene_ID` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Gene_ID, gene_name, transcript_ID, Gene_ID)
    End Function
#End Region
Public Function Clone() As transcripts
                  Return DirectCast(MyClass.MemberwiseClone, transcripts)
              End Function
End Class


End Namespace
