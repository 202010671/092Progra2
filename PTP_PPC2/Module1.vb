Module Module1

    Public Const MOSMALL = 65.5
    Public Const MOMEDIUM = 85.99
    Public Const MOLARGE = 99.99

    Public Const MALGODÓN = 15
    Public Const MSEDA = 23.99
    Public Const MLONA = 30.99

    Public Const YSMALL = 2
    Public Const YMEDIUM = 2.5
    Public Const YLARGE = 3

    Public PrecioDeCosto As Double = 0
    Public PrecioDeVenta As Double = 0
    Public TotalCosto As Double = 0

    Public Sub Calcular(ByVal material As String, ByVal tamaño As String, ByVal Cantidad As Double)

        Select Case tamaño

            Case "SMALL"
                Select Case material
                    Case "Algodón"
                        PrecioDeCosto = Cantidad * MOSMALL + Cantidad * MALGODÓN * YSMALL
                    Case "Seda"
                        PrecioDeCosto = Cantidad * MOSMALL + Cantidad * MSEDA * YSMALL
                    Case "Lona"
                        PrecioDeCosto = Cantidad * MOSMALL + Cantidad * MLONA * YSMALL
                End Select

            Case "MEDIUM"
                Select Case material
                    Case "Algodón"
                        PrecioDeCosto = Cantidad * MOMEDIUM + Cantidad * MALGODÓN * YMEDIUM
                    Case "Seda"
                        PrecioDeCosto = Cantidad * MOMEDIUM + Cantidad * MSEDA * YMEDIUM
                    Case "Lona"
                        PrecioDeCosto = Cantidad * MOMEDIUM + Cantidad * MLONA * YMEDIUM
                End Select

            Case "LARGE"
                Select Case material
                    Case "Algodón"
                        PrecioDeCosto = Cantidad * MOLARGE + Cantidad * MALGODÓN * YLARGE
                    Case "Seda"
                        PrecioDeCosto = Cantidad * MOLARGE + Cantidad * MSEDA * YLARGE
                    Case "Lona"
                        PrecioDeCosto = Cantidad * MOLARGE + Cantidad * MLONA * YLARGE
                End Select

        End Select

        PrecioDeVenta = PrecioDeCosto + 0.65 * PrecioDeCosto

        TotalCosto = PrecioDeCosto * (Cantidad)

    End Sub




End Module
