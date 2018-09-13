Module Module1

    Sub Main()
        Dim sensestrand As List(Of nucleotide)
        Dim currentnucleotide As nucleotide
        Dim pentosesugar As Boolean = 0 ' 0 = deoxyribose (DNA), 1 = ribose (RNA)
        currentnucleotide._molecule_sugar.data = pentosesugar


    End Sub

    Sub getsensestring()

    End Sub

    Class nucleotide
        Structure molecule
            Structure pentosesugar
                Public text As String
                Public data As Boolean
            End Structure

            Structure nitrogenousbase
                Public text As String
                Public data As Byte
            End Structure
        End Structure

        Public _molecule As New molecule
        Public _molecule_sugar As New molecule.pentosesugar
        Public _molecule_base As New molecule.nitrogenousbase

        Public Sub update()
            Select Case _molecule_sugar.data
                Case 0
                    _molecule_sugar.text = "Deoxyribose"
                Case 1
                    _molecule_sugar.text = "Ribose"
            End Select
            Select Case _molecule_base.data
                Case 0
                    _molecule_base.text = "Adenine"
                Case 1 ' varies between DNA (Thymine) and RNA (Uracil)
                    If _molecule_sugar.data = 0 Then
                        _molecule_base.text = "Thymine"
                    Else
                        _molecule_base.text = "Uracil"
                    End If
                Case 2
                    _molecule_base.text = "Guamine"
                Case 3
                    _molecule_base.text = "Cytosine"
            End Select
        End Sub
    End Class
End Module
