using System;
using System.Diagnostics;

// Atualmente, uma tentativa de melhor esforço é feita para executar finalizadores para todos os objetos finalizáveis ​​durante o desligamento, incluindo objetos alcançáveis. A execução de finalizadores para objetos alcançáveis ​​não é confiável, pois os objetos estão em um estado indefinido.
// Não execute finalizadores no desligamento (para objetos alcançáveis ​​ou inacessíveis)
// Sob esta proposta, não é garantido que todos os objetos finalizáveis ​​serão finalizados antes do desligamento.
// https://stackoverflow.com/questions/44732234/why-does-the-finalize-destructor-example-not-work-in-net-core
// https://docs.microsoft.com/en-us/dotnet/api/system.object.finalize?view=netframework-4.8#how-finalization-works
public class ExampleClass
{
    Stopwatch sw;

    public ExampleClass()
    {
        sw = Stopwatch.StartNew();
        Console.WriteLine("Instantiated object");
    }

    public void ShowDuration()
    {
        Console.WriteLine("This instance of {0} has been in existence for {1}",
                          this, sw.Elapsed);
    }

    ~ExampleClass()
    {
        Console.WriteLine("Finalizing object");
        sw.Stop();
        Console.WriteLine("This instance of {0} has been in existence for {1}",
                          this, sw.Elapsed);
    }
}

public class Demo
{
    public static void Main()
    {
        ExampleClass ex = new ExampleClass();
        ex.ShowDuration();
    }
}
// The example displays output like the following:
//    Instantiated object
//    This instance of ExampleClass has been in existence for 00:00:00.0011060
//    Finalizing object
//    This instance of ExampleClass has been in existence for 00:00:00.0036294