Public Class AutoFightMg

    'Inherits MyDmBase

    Property scope

    Property attackKey

    Property sideDistance

    Property movePersistTime

    Property zoneWidth

    Property interval

    Private winW = dm.getw

    Private dm As New Dm.dmsoft


    Sub fightAuto()

        Dim back = isGoalInRange()

        If back(0) Then

            If back(1) = "right" Then

                dm.KeyPressChar("right")

            Else

                dm.KeyPressChar("left")

            End If

            attack()

        Else

            moveAuto()

        End If



    End Sub

    Sub moveAuto()

        Select Case isInTheSide()

            Case "false"

                move("left")

            Case "right"

                move("left")

            Case "left"

                move("right")

        End Select


    End Sub


    Function isInTheSide()

        Dim x = gainRolePX()

        If x <= sideDistance Then

            Return "left"

        ElseIf x >= zoneWidth - sideDistance Then

            Return "right"

        Else
            Return "false"

        End If

    End Function


    Sub attack()

        dm.KeyPressChar(attackKey)


    End Sub

    Sub move(ByVal d)

        dm.KeyDownChar(d)

        Threading.Thread.Sleep(interval)

        dm.KeyUpChar(d)

    End Sub

    Function isGoalInRange()

        Dim goalP = gainGoalPX()

        Dim roleP = gainRolePX()

        Dim distance = Math.Abs(goalP - roleP)

        Return {distance <= scope, IIf(roleP > goalP, "left", "right")}

    End Function


    Function gainRolePX()

        Dim x = 0

        '找字获取或是other

        Return x

    End Function

    Function gainGoalPX()

        Dim x = 0

        '找字获取或是other




        Return x

    End Function


End Class
