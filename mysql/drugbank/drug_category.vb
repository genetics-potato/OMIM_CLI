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
''' DROP TABLE IF EXISTS `drug_category`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_category` (
'''   `drug` int(11) NOT NULL,
'''   `category` varchar(45) DEFAULT NULL,
'''   `mesh_id` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`drug`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `drug_category`
''' --
''' 
''' LOCK TABLES `drug_category` WRITE;
''' /*!40000 ALTER TABLE `drug_category` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `drug_category` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_category", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_category` (
  `drug` int(11) NOT NULL,
  `category` varchar(45) DEFAULT NULL,
  `mesh_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`drug`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_category: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property drug As Long
    <DatabaseField("category"), DataType(MySqlDbType.VarChar, "45")> Public Property category As String
    <DatabaseField("mesh_id"), DataType(MySqlDbType.VarChar, "45")> Public Property mesh_id As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_category` (`drug`, `category`, `mesh_id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_category` (`drug`, `category`, `mesh_id`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_category` WHERE `drug` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_category` SET `drug`='{0}', `category`='{1}', `mesh_id`='{2}' WHERE `drug` = '{3}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_category` WHERE `drug` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, drug)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_category` (`drug`, `category`, `mesh_id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, category, mesh_id)
    End Function
''' <summary>
''' ```SQL
''' REPLACE INTO `drug_category` (`drug`, `category`, `mesh_id`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, category, mesh_id)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_category` SET `drug`='{0}', `category`='{1}', `mesh_id`='{2}' WHERE `drug` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, drug, category, mesh_id, drug)
    End Function
#End Region
End Class


End Namespace
