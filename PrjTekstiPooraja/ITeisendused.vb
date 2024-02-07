Public Interface ITeisendused
    Property intAlgus As Integer    'Teksti esimese sümboli ASCII koodi jaoks
    Property intLopp As Integer     'Teksti esimese sümboli ASCII koodi jaoks
    Property strTekst As String     'kasutaja sisestatud teksti jaoks

    Function pooraTekst() As String       'liidese meetodid koodi
    Sub teisendaTekst(ByRef strSisendTekst As String)   'ei oma
End Interface
