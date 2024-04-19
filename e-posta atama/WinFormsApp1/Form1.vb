Public Class Form1
    Dim tipsayac, egitimsayac, hukuksayac, muhsayac, sayac As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ad, soyad, uni, eposta As String
        Dim n As Integer

        ad = Strings.Left(adtxt.Text, 3)
        soyad = Strings.Right(soyadtxt.Text, 3)
        n = Strings.InStr(unitxt.Text, " ")         ' kaçıncı karakter olduğu boşluktan itibaren karakterli al
        uni = Strings.Left(unitxt.Text, (n - 1))         ' soldan itibaren karakterlerini al n-1

        eposta = Strings.LCase(ad & soyad & "@" & uni & ".edu.tr")
        eposta = Strings.Replace(eposta, "ş", "s")
        eposta = Strings.Replace(eposta, "ı", "i")
        eposta = Strings.Replace(eposta, "ü", "u")
        eposta = Strings.Replace(eposta, "ö", "o")
        eposta = Strings.Replace(eposta, "ç", "c")
        eposta = Strings.Replace(eposta, "ğ", "g")
        eposta = Strings.Replace(eposta, "ondokuz", "omu") 'ondokuz yazısı varsa onu omu olarak değiştir
        eposta = Strings.Replace(eposta, "anadolu", "and")



        Dim fakultekodu, yil, sira As String 'numara atama 

        yil = Strings.Right(System.DateTime.Today.Year, 2) '2023  sistem saati 2023 yılındaysa 23 bilgisini al 

        If fakultetxt.Text = "Tıp Fakultesi" Then
            fakultekodu = "01"
            tipsayac += 1
            sayac = tipsayac

        ElseIf fakultetxt.Text = "Egitim Fakultesi" Then
            fakultekodu = "02"
            egitimsayac += 1
            sayac = egitimsayac

        ElseIf fakultetxt.Text = "Hukuk Fakultesi" Then
            fakultekodu = "03"
            hukuksayac += 1
            sayac = hukuksayac

        ElseIf fakultetxt.Text = "Muhendislik Fakultesi" Then
            fakultekodu = "04"
            muhsayac += 1
            sayac = muhsayac
        End If

        'formuller buradaydı'

        sira = Format(sayac, "000") 'format yazmaktansa sayacı 3 haneli yaz

        ListBox1.Items.Add(adtxt.Text & " " & soyadtxt.Text)
        ListBox1.Items.Add(eposta & "  " & yil & fakultekodu & sira)



    End Sub

End Class


'If Strings.Len(sayac.ToString) = 1 Then
'    sira = "000" & sayac.ToString

'ElseIf Strings.Len(sayac.ToString) = 2 Then
'    sira = "00" & sayac.ToString

'ElseIf Strings.Len(sayac.ToString) = 3 Then
'    sira = "0" & sayac.ToString

'ElseIf Strings.Len(sayac.ToString) = 4 Then
'    sira = sayac.ToString
'End If


