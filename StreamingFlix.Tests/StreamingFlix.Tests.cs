
using Xunit;
using StreamingFlix.App;

namespace StreamingFlix.Tests
{
    public class PlanoStreamingServiceTests
    {
        private readonly PlanoStreamingService _service;

        public PlanoStreamingServiceTests()
        {
            // Instancia o serviço criado na etapa do Desenvolvedor 1
            _service = new PlanoStreamingService();
        }

        // Teste 1: Classificação de Planos
        [Theory]
        [InlineData(1, "BÁSICO")]
        [InlineData(2, "PADRÃO")]
        [InlineData(4, "PREMIUM")]
        public void ObterClassificacaoPorQualidade_DeveRetornarClassificacaoCorreta(int telas, string resultadoEsperado)
        {
            // Act
            var resultado = _service.ObterClassificacaoPorQualidade(telas);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste 2: Cálculo de Desconto
        [Theory]
        [InlineData(50, 1, 50)]   // sem desconto
        [InlineData(50, 6, 45)]   // 10% de desconto
        [InlineData(50, 12, 40)]  // 20% de desconto
        public void CalcularMensalidadeComDesconto_DeveAplicarDescontoCorreto(int valorBase, int meses, int resultadoEsperado)
        {
            // Act
            var resultado = _service.CalcularMensalidadeComDesconto(valorBase, meses);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste 3: Validação de Acesso
        [Theory]
        [InlineData(20, false, true)]  // Maior de idade, sem restrição -> true
        [InlineData(20, true, false)]  // Maior de idade, com restrição -> false
        [InlineData(16, false, false)] // Menor de idade -> false
        public void PodeAcessarConteudoAdulto_DeveValidarIdadeEControleParental(int idade, bool controleParental, bool resultadoEsperado)
        {
            // Act
            var resultado = _service.PodeAcessarConteudoAdulto(idade, controleParental);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}

