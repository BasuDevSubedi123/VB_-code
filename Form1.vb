
'Basu dev subedi 
'display band member and what they does 
'date 10/17 
Public Class Form1
    Private Sub displayBeatles(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBeatles.CheckedChanged
        Me.lblMember1.Text = "John Lennon- Guitar and Vocals"
        Me.lblMember2.Text = "Ringo Starr – Drums and Vocals"
        Me.lblMember3.Text = "Paul McCartney – Bass and Vocals"
        Me.lblMember4.Text = "George Harrison – Lead Guitar and Vocals"
        Me.lblMember5.Text = ""
    End Sub


    Private Sub displayMetallica(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMetallica.CheckedChanged
        Me.lblMember1.Text = "Robert Trujillo – Bass"
        Me.lblMember2.Text = "James Hetfield – Guitar and Vocals"
        Me.lblMember3.Text = "Lars Ulrich – Drums"
        Me.lblMember4.Text = "Kirk Hammett – Guitar"
        Me.lblMember5.Text = ""
    End Sub

    Private Sub displayRedHotPeppers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRedHotPeppers.CheckedChanged
        Me.lblMember1.Text = "Anthony Kiedas – Vocals"
        Me.lblMember2.Text = "Flea – Bass"
        Me.lblMember3.Text = "Flea – Bass"
        Me.lblMember4.Text = "Chad Smith – Drums"
        Me.lblMember5.Text = ""
    End Sub

    Private Sub displayNirvana(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNirvana.CheckedChanged
        Me.lblMember1.Text = "Krist Novoselic – Bass"
        Me.lblMember2.Text = "Kurt Cobain – Guitar and Vocals"
        Me.lblMember3.Text = "Dave Grohl – Drums"
        Me.lblMember4.Text = ""
        Me.lblMember5.Text = ""
    End Sub

    Private Sub displayFooFighters(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFooFighters.CheckedChanged
        Me.lblMember1.Text = "Dave Grohl – Guitar and Vocals"
        Me.lblMember2.Text = "Taylor Hawkins – Drums"
        Me.lblMember3.Text = "Pat Smear – Guitar"
        Me.lblMember4.Text = "Nate Mendel – Bass"
        Me.lblMember5.Text = "Chris Shiflett – Lead Guitar and Backing Vocals"
    End Sub
End Class
