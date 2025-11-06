Imports MySql.Data.MySqlClient

Public Class DBHandler
    ' This class will eventually contain all mysql functions
    Public Shared currentUser() As String = {"", "", "", "", "", "", "", "", ""}

    ' denina connection string dont remove
    'Private ConnectionString As String = "server=localhost;user=root;database=MyPMS;port=3306;password=washer22456;"
    Private ConnectionString As String = "server=localhost;user=root;database=MyPMS;port=3306;password=;"

    Private conn As MySqlConnection
    Public Sub New()
        conn = New MySqlConnection(ConnectionString)
    End Sub

    ' Method to authenticate user (unchanged)
    Public Function AuthenticateUser(EmployeeID As String, Password As String) As Boolean
        Dim sql As String = "SELECT ID, Employee_Name, Employee_ID, Password, Role, Status, TIME_FORMAT(TimeIn, '%h:%i %p'), TIME_FORMAT(TimeOut, '%h:%i %p'), Salary FROM EmployeeTable WHERE Employee_ID = @EmployeeID AND Password = @Password"
        Dim authenticated As Boolean = False

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID)
                cmd.Parameters.AddWithValue("@password", Password)

                Using dReader As MySqlDataReader = cmd.ExecuteReader()
                    If dReader.Read() Then
                        authenticated = True
                        currentUser = {
                                        dReader("ID").ToString(), dReader("Employee_Name").ToString(), EmployeeID, Password,
                                        dReader("Role").ToString(), dReader("Status").ToString(), dReader("TIME_FORMAT(TimeIn, '%h:%i %p')").ToString(),
                                        dReader("TIME_FORMAT(TimeOut, '%h:%i %p')").ToString(), dReader("Salary").ToString()
                                    }
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return authenticated
    End Function

    ' ================= HR DASHBOARD METHODS ==================

    Public Function Get_HRDB_Stats() As DataTable
        Dim sql As String = "SELECT Employee_Name AS EmployeeName, Employee_ID AS EmployeeID, Role, Status, FORMAT(TimeIn, 'hh:mm') AS TimeIn, FORMAT(TimeOut, 'hh:mm') AS TimeOut, Salary FROM employeetable ORDER BY EmployeeName"
        Return Read(sql)
    End Function


    ' ==================== GENERIC METHODS ====================
    Public Function Read(sql As String) As DataTable
        Dim dt As New DataTable()

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return dt
    End Function

    Public Function ReadWithParameters(sql As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return dt
    End Function

    Public Function ExecuteNonQuery(sql As String) As Integer
        Dim rowsAffected As Integer = 0

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return rowsAffected
    End Function

    Public Function ExecuteNonQueryWithParameters(sql As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim rowsAffected As Integer = 0

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return rowsAffected
    End Function

    Public Function Insert(tableName As String, parameters As Dictionary(Of String, Object)) As Boolean
        Dim columns As String = String.Join(", ", parameters.Keys)
        Dim values As String = String.Join(", ", parameters.Keys.Select(Function(k) "@" & k.Replace("@", "")))
        Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({values})"

        Return ExecuteNonQueryWithParameters(sql, parameters) > 0
    End Function

    Public Function Update(tableName As String, parameters As Dictionary(Of String, Object), whereClause As String) As Boolean
        Dim setClause As String = String.Join(", ", parameters.Keys.Select(Function(k) $"{k} = @{k.Replace("@", "")}"))
        Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}"

        Return ExecuteNonQueryWithParameters(sql, parameters) > 0
    End Function

    Public Function Delete(tableName As String, whereClause As String) As Boolean
        Dim sql As String = $"DELETE FROM {tableName} WHERE {whereClause}"

        Return ExecuteNonQuery(sql) > 0
    End Function

    Public Function DeleteWithParameters(tableName As String, whereClause As String, parameters As Dictionary(Of String, Object)) As Boolean
        Dim sql As String = $"DELETE FROM {tableName} WHERE {whereClause}"

        Return ExecuteNonQueryWithParameters(sql, parameters) > 0
    End Function

    Public Function TestConnection() As Boolean
        Try
            conn.Open()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function

    Public Sub Dispose()
        If conn IsNot Nothing Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Dispose()
        End If
    End Sub

End Class
