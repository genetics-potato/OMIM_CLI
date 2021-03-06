REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/10/24 11:04:04


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `drug_price`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `drug_price` (
'''   `drug` varchar(45) NOT NULL,
'''   `description` varchar(45) DEFAULT NULL,
'''   `cost` varchar(45) DEFAULT NULL,
'''   `unit` varchar(45) DEFAULT NULL,
'''   `currency` varchar(45) DEFAULT NULL
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("drug_price", Database:="drugbank", SchemaSQL:="
CREATE TABLE `drug_price` (
  `drug` varchar(45) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `cost` varchar(45) DEFAULT NULL,
  `unit` varchar(45) DEFAULT NULL,
  `currency` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class drug_price: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("drug"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="drug")> Public Property drug As String
    <DatabaseField("description"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="description")> Public Property description As String
    <DatabaseField("cost"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="cost")> Public Property cost As String
    <DatabaseField("unit"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="unit")> Public Property unit As String
    <DatabaseField("currency"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="currency")> Public Property currency As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `drug_price` WHERE ;</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `drug_price` SET `drug`='{0}', `description`='{1}', `cost`='{2}', `unit`='{3}', `currency`='{4}' WHERE ;</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `drug_price` WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___DELETE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, drug, description, cost, unit, currency)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{drug}', '{description}', '{cost}', '{unit}', '{currency}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `drug_price` (`drug`, `description`, `cost`, `unit`, `currency`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, drug, description, cost, unit, currency)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `drug_price` SET `drug`='{0}', `description`='{1}', `cost`='{2}', `unit`='{3}', `currency`='{4}' WHERE ;
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Throw New NotImplementedException("Table key was Not found, unable To generate ___UPDATE_SQL_Invoke automatically, please edit this Function manually!")
    End Function
#End Region
Public Function Clone() As drug_price
                  Return DirectCast(MyClass.MemberwiseClone, drug_price)
              End Function
End Class


End Namespace
