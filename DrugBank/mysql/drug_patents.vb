REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 1.0.0.0

REM  Dump @3/28/2017 10:09:14 PM


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_patents`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_patents` (
'''   `drug` int(11) NOT NULL,
'''   `number` varchar(45) DEFAULT NULL,
'''   `country` varchar(45) DEFAULT NULL,
'''   `approved` varchar(45) DEFAULT NULL,
'''   `expires` varchar(45) DEFAULT NULL,
'''   `pediatric_extension` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_patents`
''' --
''' 
''' LOCK TABLES `drug_patents` WRITE;
''' /*!40000 ALTER TABLE `drug_patents` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_patents` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_patents", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_patents` (
  `drug` int(11) NOT NULL,
  `number` varchar(45) DEFAULT NULL,
  `country` varchar(45) DEFAULT NULL,
  `approved` varchar(45) DEFAULT NULL,
  `expires` varchar(45) DEFAULT NULL,
  `pediatric_extension` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_patents: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("number"), DataType(MySqlDbType.VarChar, "45")> Public Property number As String
    <DatabaseField("country"), DataType(MySqlDbType.VarChar, "45")> Public Property country As String
    <DatabaseField("approved"), DataType(MySqlDbType.VarChar, "45")> Public Property approved As String
    <DatabaseField("expires"), DataType(MySqlDbType.VarChar, "45")> Public Property expires As String
    <DatabaseField("pediatric_extension"), DataType(MySqlDbType.VarChar, "45")> Public Property pediatric_extension As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_patents` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_patents` SET `drug`='{0}', `number`='{1}', `country`='{2}', `approved`='{3}', `expires`='{4}', `pediatric_extension`='{5}' WHERE `drug` = '{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_patents` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, number, country, approved, expires, pediatric_extension)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_patents` (`drug`, `number`, `country`, `approved`, `expires`, `pediatric_extension`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, number, country, approved, expires, pediatric_extension)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_patents` SET `drug`='{0}', `number`='{1}', `country`='{2}', `approved`='{3}', `expires`='{4}', `pediatric_extension`='{5}' WHERE `drug` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, number, country, approved, expires, pediatric_extension, drug)
    End Function
#End Region
End Class


End Namespace
