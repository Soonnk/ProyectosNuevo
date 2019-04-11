Imports System
Imports System.Configuration
Imports System.Web.Configuration
Public Class ConfigManager
    'Private Shared Function GetConfiguration() As Configuration
    '    Dim path As String 'Path del archivo de configuracion
    '    Dim config As Configuration   'Objeto configuracion
    '    If System.Web.HttpContext.Current Is Nothing Then
    '        'Windows
    '        path = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName)
    '        config = ConfigurationManager.OpenExeConfiguration(path)
    '    Else
    '        'Web
    '        path = System.Web.HttpContext.Current.Request.ApplicationPath
    '        config = WebConfigurationManager.OpenWebConfiguration(path)
    '    End If
    '    Return config
    'End Function

    'Public Shared Function GetValue(ByVal Key As String) As String
    '    Dim config As Configuration
    '    Dim Value As String
    '    Try
    '        'Obtengo configuracion
    '        config = GetConfiguration()

    '        Try
    '            'obtengo valor
    '            Value = config.AppSettings.Settings(Key).Value
    '        Catch ex As Exception
    '            'Si no existe creo una exception
    '            Throw New KeyNotFoundException(String.Format("Error: la clave '{0}' no existe en el archivo configuración.", Key), ex)
    '        End Try
    '        Return Value

    '    Finally
    '        config = Nothing
    '    End Try
    'End Function

    'Public Shared Sub SetValue(ByVal Key As String, ByVal value As String)
    '    Dim config As Configuration
    '    Try
    '        'Obtengo configuracion
    '        config = GetConfiguration()

    '        Try
    '            'obtengo valor
    '            config.AppSettings.Settings.Item(Key).Value = value
    '            config.Save(ConfigurationSaveMode.Modified)
    '        Catch ex As Exception
    '            'Si no existe creo una exception
    '            Throw New KeyNotFoundException(String.Format("Error: la clave '{0}' no existe en el archivo configuración.", Key), ex)
    '        End Try
    '    Finally
    '        config = Nothing
    '    End Try
    'End Sub
End Class
