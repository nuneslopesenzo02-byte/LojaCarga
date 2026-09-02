
namespace LojaCarga
{
    class Estacao
    {
        //propriedades (ATRIBUTOS)
        
        public string ?Motorista { get; set; }

        public double CapacidadeKWh { get; set; }

        public double PorcentagemAtual { get; set; }

        public double PotenciaKw { get; set; }


        //MÉTODOS (AÇÕES)

        //MÉTODO CALCULAR KW NECESSARIOS PARA CARREGAR BÁTERIA
        public double CalcularKWNecessarios()
        {
            double porcentagemFaltantes = (100.00 - PorcentagemAtual / 100);
            return CapacidadeKWh * porcentagemFaltantes;
        }

        //MÉTODO PARA CALCULAR TEMPO / HORA NECESSÁRIOS

        public double CalcularTempoHoras() 
        {
            return CalcularKWNecessarios() / PotenciaKw;
        
        }

        //MÉTODO PARA SABER O VALOR CARREGADOR
        public double CalcularValor() 
        {
            const double PRECO_POR_KWH = 2.50;
            return CalcularKWNecessarios() * PRECO_POR_KWH;
        
        }

        //MÉTODO PARA SABER SE O CARREGAMENTO É RAPIDO
        public bool CarregamentoRapido()
        {
            return (PotenciaKw >= 50.0) && (CalcularTempoHoras() < 1.0);
        }


    
    
    
    
    
    }

}
