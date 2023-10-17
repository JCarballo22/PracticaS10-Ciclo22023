Module Module1

    Sub Main()

        'Arreglo()
        ForEach()
        Console.Read()
    End Sub

    Sub Arreglo()
        Dim arreglo = New Integer() {4, 8, 6, 7, 2, 9, 1}
        Console.WriteLine("El elemento de la posición 3 es " & arreglo(3))
        Console.WriteLine("El tamaño es " & arreglo.Length)


    End Sub

    Sub ForEach()
        Dim mascotas = New String() {"Perro", "Gato", "Conejo", "Gallina", "Ratos", "Iguana"}
        For i = 0 To mascotas.Length - 1
            Console.WriteLine("la mascota " & i + 1 & " es " & mascotas(i))
        Next

        For Each mascota In mascotas
            Console.WriteLine("La mascota es " & mascota)
        Next

    End Sub


End Module
