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


Public Class CAlgoritmilinePooraja
    Implements ITeisendused
    'Klassi CAlgoritmilinePooraja atribuudid (muutujad)
    Private intAlgusSym As Integer
    Private intLoppSym As Integer
    Private strPooratavTxt As String


    'Liidese omaduste (atribuutide) seadistimamine

    'Atribuut intAlgus seadistamine
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSym 'atribuudi küsimusel tagasta intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSym = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Atribuut intLopp seadistamine
    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSym 'atribuudi küsimusel tagasta intLoppSymbol
        End Get
        Set(value As Integer)
            strPooratavTxt = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Atribuut strTekst seadistamine
    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTxt 'atribuudi küsimusel tagasta strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTxt = value 'atribuudi väärtuste seadistamine
        End Set
    End Property

    'Funktsioon algoritmiliselt teksti tagurpidi pööramiseks
    Public Function reversedText() As String
        Dim tempArray As String = " "
        Dim i As Integer
        For i = strTekst.Length - 1 To 0 Step -1
            tempArray &= strTekst(i)
        Next
        Return tempArray
    End Function

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        strPooratavTxt = reversedText(strSisendTekst)
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Return reversedText(strPooratavTxt)
    End Function

End Class