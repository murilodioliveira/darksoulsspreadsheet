Dim level As Integer
Dim nextLevel As Integer

level = 11


If level < 12 Then
	nextLevel = (0.0795 * level^2) + (16.245 * level) + 640.49
Else
    nextLevel = (0.02 * level ^ 3) + (3.06 * level ^ 2) + (105.6 * level) - 895
End If


Console.WriteLine (nextLevel)