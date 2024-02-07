Public Class CTekstiPooraja
    Implements ITeisendused

    'Klassi CTekstiPooraja atribuudid (muutujad)
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    'Liidese omaduste (atribuutide) seadistimamine

    'Atribuut intAlgus seadistamine
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol 'atribuudi küsimusel tagasta intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Atribuut intLopp seadistamine
    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol 'atribuudi küsimusel tagasta intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Atribuut strTekst seadistamine
    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst 'atribuudi küsimusel tagasta strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Meetod, mis pöörab tagurpidi
    'sisendparamteetrina strSisendTekst antud avaldise
    'ja salvestab väärtuse atribuuti strPooratavTekst

    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    'Meetod, mis võtab atribuunist
    'strSisendTekst väärtuse
    'ja pöörab selle stringi tagurpidi
    Private Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst

        Return StrReverse(strPooratavTekst)
    End Function
End Class
