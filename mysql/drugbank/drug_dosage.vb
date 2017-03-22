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
''' DROP TABLE IF EXISTS `drug_dosage`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_dosage` (
'''   `drug` int(11) NOT NULL,
'''   `form` varchar(45) DEFAULT NULL,
'''   `route` varchar(45) DEFAULT NULL,
'''   `strength` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_dosage`
''' --
''' 
''' LOCK TABLES `drug_dosage` WRITE;
''' /*!40000 ALTER TABLE `drug_dosage` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_dosage` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_dosage", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_dosage` (
  `drug` int(11) NOT NULL,
  `form` varchar(45) DEFAULT NULL,
  `route` varchar(45) DEFAULT NULL,
  `strength` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_dosage: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("form"), DataType(MySqlDbType.VarChar, "45")> Public Property form As String
    <DatabaseField("route"), DataType(MySqlDbType.VarChar, "45")> Public Property route As String
    <DatabaseField("strength"), DataType(MySqlDbType.VarChar, "45")> Public Property strength As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_dosage` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_dosage` SET `drug`='{0}', `form`='{1}', `route`='{2}', `strength`='{3}' WHERE `drug` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_dosage` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, form, route, strength)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_dosage` (`drug`, `form`, `route`, `strength`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, form, route, strength)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_dosage` SET `drug`='{0}', `form`='{1}', `route`='{2}', `strength`='{3}' WHERE `drug` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, form, route, strength, drug)
    End Function
#End Region
End Class


End Namespace
