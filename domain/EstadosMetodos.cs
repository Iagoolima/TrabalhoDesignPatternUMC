// using TrabalhoDesignPatternUMC.estados.estadosConcretos;
//
// namespace TrabalhoDesignPatternUMC;
//
// public class EstadosMetodos
// {
//     
//     private int tempoManutencaoSoma;
//     
//         
//     public void setSoma(Estado estado)
//     {
//         if (estado is Fechado)
//         {
//             tempoManutencaoSoma = 1 * 30;
//             Timer timer = new Timer(TimerCallback, null, 0, 1000);
//         }
//     }
//
//     public Estado getSoma(Estado estado)
//     {
//         if (estado is Fechado)
//         {
//             Console.WriteLine("ERRO 500: Por favor, volte mais tarde \n");
//             Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoSoma + " segundos");
//         }
//         return estado;
//     }
//     //
//     // public void setSubtracao(bool subtracao)
//     // {
//     //     this.subtracao = subtracao;
//     //     
//     //     if (!subtracao)
//     //     {
//     //         tempoManutencaoSubtracao = 1 * 30;
//     //         Timer timer = new Timer(TimerCallback, null, 0, 1000); 
//     //     }
//     // }
//     //
//     // public bool getsubtracao()
//     // {
//     //     if (!subtracao)
//     //     {
//     //         Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoSubtracao + " segundos");
//     //     }
//     //     return subtracao;
//     // }
//     //
//     // public void setDivisao(bool divisao)
//     // {
//     //     this.divisao = divisao;
//     //     
//     //     if (!divisao)
//     //     {
//     //         tempoManutencaoDivisao = 1 * 30;
//     //         Timer timer = new Timer(TimerCallback, null, 0, 1000); 
//     //     }
//     // }
//     //
//     // public bool getDivisao()
//     // {
//     //     if (!divisao)
//     //     {
//     //         Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoDivisao + " segundos");
//     //     }
//     //     return divisao;
//     // }
//     //
//     // public void setMultiplicacao(bool multiplicacao)
//     // {
//     //     this.multiplicacao = multiplicacao;
//     //     
//     //     if (!multiplicacao)
//     //     {
//     //         tempoManutencaoMultiplicacao = 1 * 30;
//     //         Timer timer = new Timer(TimerCallback, null, 0, 1000); 
//     //     }
//     // }
//     //
//     // public bool getMultiplicacao()
//     // {
//     //     if (!multiplicacao)
//     //     {
//     //         Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoMultiplicacao + " segundos");
//     //     }
//     //     return multiplicacao;
//     // }
//
//     private void TimerCallback(Object o)
//     {
//         tempoManutencaoSoma--;
//         if (tempoManutencaoSoma <= 0)
//         {
//             if (this.soma) 
//             {
//                 Estado estadoAberto = new Aberto();
//                 this.setSoma(estadoAberto);
//             }
//         }
//         
//         tempoManutencaoSubtracao--;
//         if (tempoManutencaoSubtracao <= 0)
//         {
//             this.subtracao = true;
//         }
//         
//         tempoManutencaoDivisao--;
//         if (tempoManutencaoDivisao <= 0)
//         {
//             this.divisao = true;
//         }
//         
//         tempoManutencaoMultiplicacao--;
//         if (tempoManutencaoMultiplicacao <= 0)
//         {
//             this.multiplicacao = true;
//         }
//     }
// }