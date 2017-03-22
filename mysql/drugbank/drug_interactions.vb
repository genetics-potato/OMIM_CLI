REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @2017/3/22 17:02:03


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_interactions`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_interactions` (
'''   `drug` int(11) NOT NULL,
'''   `partner` varchar(45) DEFAULT NULL,
'''   `partner_name` varchar(45) DEFAULT NULL,
'''   `partner_description` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_interactions`
''' --
''' 
''' LOCK TABLES `drug_interactions` WRITE;
''' /*!40000 ALTER TABLE `drug_interactions` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_interactions` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_interactions", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_interactions` (
  `drug` int(11) NOT NULL,
  `partner` varchar(45) DEFAULT NULL,
  `partner_name` varchar(45) DEFAULT NULL,
  `partner_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_interactions: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("partner"), DataType(MySqlDbType.VarChar, "45")> Public Property partner As String
    <DatabaseField("partner_name"), DataType(MySqlDbType.VarChar, "45")> Public Property partner_name As String
    <DatabaseField("partner_description"), DataType(MySqlDbType.VarChar, "45")> Public Property partner_description As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_interactions` (`drug`, `partner`, `partner_name`, `partner_description`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_interactions` (`drug`, `partner`, `partner_name`, `partner_description`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_interactions` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_interactions` SET `drug`='{0}', `partner`='{1}', `partner_name`='{2}', `partner_description`='{3}' WHERE `drug` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_interactions` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_interactions` (`drug`, `partner`, `partner_name`, `partner_description`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, partner, partner_name, partner_description)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_interactions` (`drug`, `partner`, `partner_name`, `partner_description`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, partner, partner_name, partner_description)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_interactions` SET `drug`='{0}', `partner`='{1}', `partner_name`='{2}', `partner_description`='{3}' WHERE `drug` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, partner, partner_name, partner_description, drug)
    End Function
#End Region
End Class


End Namespace
