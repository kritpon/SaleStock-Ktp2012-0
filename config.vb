Module config
    'Friend _ini As New Setting.IniFile(_Directory & "\Config.ini")
    'Friend _Directory As String = My.Application.Info.DirectoryPath

    ' Friend _Directory As String = "\\192.168.1.3\ProgramSA\Config" ' "\\192.168.1.5\ProgramSA\Config"


    ' Friend _ini As New Setting.IniFile(_Directory & "\Config.ini")

    Sub LoadSetting()

        'strConn = _ini.ReadValue("SetSystem", "svParthDataSource") 'ของพี่กวางที่เรียกconfig.ini
        strConn = DBConnString.strConn1

    End Sub


End Module