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
''' DROP TABLE IF EXISTS `drug_manufacturers`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_manufacturers` (
'''   `drug` int(11) NOT NULL,
'''   `generic` varchar(45) DEFAULT NULL,
'''   `url` varchar(45) DEFAULT NULL,
'''   `manufacturer` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_manufacturers`
''' --
''' 
''' LOCK TABLES `drug_manufacturers` WRITE;
''' /*!40000 ALTER TABLE `drug_manufacturers` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_manufacturers` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_manufacturers", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_manufacturers` (
  `drug` int(11) NOT NULL,
  `generic` varchar(45) DEFAULT NULL,
  `url` varchar(45) DEFAULT NULL,
  `manufacturer` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_manufacturers: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("generic"), DataType(MySqlDbType.VarChar, "45")> Public Property generic As String
    <DatabaseField("url"), DataType(MySqlDbType.VarChar, "45")> Public Property url As String
    <DatabaseField("manufacturer"), DataType(MySqlDbType.VarChar, "45")> Public Property manufacturer As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_manufacturers` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_manufacturers` SET `drug`='{0}', `generic`='{1}', `url`='{2}', `manufacturer`='{3}' WHERE `drug` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_manufacturers` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, generic, url, manufacturer)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_manufacturers` (`drug`, `generic`, `url`, `manufacturer`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, generic, url, manufacturer)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_manufacturers` SET `drug`='{0}', `generic`='{1}', `url`='{2}', `manufacturer`='{3}' WHERE `drug` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, generic, url, manufacturer, drug)
    End Function
#End Region
End Class


End Namespace
