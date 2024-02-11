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
            Return intAlgusSymbol 'atribuudi k�simusel tagasta intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value 'atribuudi v��rtuste seadistamine
        End Set
    End Property

    'Atribuut intLopp seadistamine
    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol 'atribuudi k�simusel tagasta intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value 'atribuudi v��rtuste seadistamine
        End Set
    End Property

    'Atribuut strTekst seadistamine
    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst 'atribuudi k�simusel tagasta strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value 'atribuudi v��rtuste seadistamine
        End Set
    End Property

    'Meetod, mis p��rab tagurpidi
    'sisendparamteetrina strSisendTekst antud avaldise
    'ja salvestab v��rtuse atribuuti strPooratavTekst

    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    'Meetod, mis v�tab atribuunist
    'strSisendTekst v��rtuse
    'ja p��rab selle stringi tagurpidi
    Private Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst

        Return StrReverse(strPooratavTekst)
    End Function
End Class

Public Class CAlgoritmilinePooraja
    Implements ITeisendused

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get

        End Get
        Set(value As String)

        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst

    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst

    End Function
End Class