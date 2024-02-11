Module Module1
    Public h As Integer
    Public Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Public Declare Sub CloseDevice Lib "k8055d.dll" ()
    Public Declare Function Version Lib "k8055d.dll" () As Integer
    Public Declare Function SearchDevices Lib "k8055d.dll" () As Integer
    Public Declare Function SetCurrentDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Public Declare Function ReadAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Integer
    Public Declare Sub ReadAllAnalog Lib "k8055d.dll" (ByRef Data1 As Integer, ByRef Data2 As Integer)
    Public Declare Sub OutputAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer, ByVal Data As Integer)
    Public Declare Sub OutputAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    Public Declare Sub ClearAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub SetAllAnalog Lib "k8055d.dll" ()
    Public Declare Sub ClearAllAnalog Lib "k8055d.dll" ()
    Public Declare Sub SetAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    Public Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    Public Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub SetAllDigital Lib "k8055d.dll" ()
    Public Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    Public Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    Public Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    Public Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    Public Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)
End Module
