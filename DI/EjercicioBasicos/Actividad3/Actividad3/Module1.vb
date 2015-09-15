Module Module1

    Sub Main()
        ' Se pedirá el tiempo en segundos y se dará en HH:MM:SS
        Dim segundos, sec, temporal, m, h As Int64
        Console.Write("Introduzca el valor en segundos: ")
        segundos = Convert.ToInt64(Console.ReadLine())
        sec = segundos Mod 60 ' segundos
        temporal = segundos / 60 ' minutos
        m = temporal Mod 24
        h = temporal / 24 ' horas
        Console.WriteLine("Resultado: " + h.ToString() + ":" + m.ToString() + ":" + sec.ToString())
        Console.ReadKey()




    End Sub

End Module
