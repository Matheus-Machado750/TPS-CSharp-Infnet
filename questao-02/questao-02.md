O C# consegue funcionar em diferentes sistemas operacionais porque utiliza uma
linguagem intermediária chamada IL (Intermediate Language). Quando escrevemos um
código C#, o compilador transforma esse código em IL, em vez de gerar diretamente
instruções específicas para Windows ou Linux. Essa IL é independente do sistema
operacional e do processador. Quando o programa é executado, o CLR (Common
Language Runtime) carrega o código e utiliza o compilador JIT (Just-In-Time) para
transformar a IL em código de máquina compatível com o computador. Portanto, o
compilador C# produz a IL, enquanto o JIT transforma essa IL em instruções que o
processador consegue executar. Assim, o mesmo código pode funcionar em Windows e
Linux, desde que exista um ambiente .NET compatível instalado e que o programa não
dependa de recursos exclusivos de um sistema operacional.
