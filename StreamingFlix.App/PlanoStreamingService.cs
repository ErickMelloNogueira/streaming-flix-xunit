namespace StreamingFlix.App
{
    public class PlanoStreamingService
    {
        // Retorna a classificação com base na quantidade de telas
        public string ObterClassificacaoPorQualidade(int telasSimultaneas)
        {
            if (telasSimultaneas == 1)
                return "BÁSICO";
            if (telasSimultaneas == 2)
                return "PADRÃO";
            if (telasSimultaneas >= 4)
                return "PREMIUM";
            
            return "NÃO DEFINIDO";
        }

        // Calcula a mensalidade aplicando os descontos por tempo de contrato
        public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
        {
            if (mesesContratados >= 12)
            {
                // 20% de desconto
                return (int)(valorBase * 0.80);
            }
            else if (mesesContratados >= 6)
            {
                // 10% de desconto
                return (int)(valorBase * 0.90);
            }
            
            // Sem desconto para menos de 6 meses
            return valorBase;
        }

        // Valida o acesso ao conteúdo adulto
        public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
        {
            // Retorna true apenas se for maior/igual a 18 E o controle parental estiver desativado (false)
            return idade >= 18 && !controleParentalAtivo;
        }
    }
}