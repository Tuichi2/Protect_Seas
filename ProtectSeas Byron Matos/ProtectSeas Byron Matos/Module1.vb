Module Module1
    'Un modulo vaya que es raro no es asi?, bueno use el modulo ya que este permite guardar codigos o variables en este caso
    'puesto que este modulo me permite poder crear una clase que pueda hacer referencia en cualquier formulario algo similar a
    'lo que pasa en java, en este casa quiero enseñar unas variables de un form a otro form.

    Public precio As Double
    Public nototal As Double = 0
    'estas son las variables que por el momento voy a implementar en mi form6
    Public tarjeta, cvv As Decimal
    Public fecha As String = DateTime.Now.ToShortDateString()
End Module
