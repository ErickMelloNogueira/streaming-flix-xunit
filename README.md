# Streaming Flix

## Visão Geral da Aplicação
O **Streaming Flix** é uma aplicação desenvolvida no âmbito da disciplina de Garantia da Qualidade de Software[cite: 1]. O sistema simula as regras de negócio do *backend* de uma plataforma de *streaming*, sendo responsável por classificar os planos de subscrição consoante o número de ecrãs, calcular descontos de mensalidade baseados no tempo de fidelização e validar o acesso a conteúdos adultos através da verificação de idade e das definições de controlo parental[cite: 4].

## Requisitos Técnicos
Para compilar e executar este projeto, é necessário ter instalado o seguinte ambiente:
- **.NET SDK**: Versão 10.0[cite: 1, 4]

## Como Clonar e Executar o Projeto
Siga os passos abaixo para transferir o projeto para a sua máquina local e compilá-lo[cite: 4]:

1. **Clonar o repositório:**
   Abra o terminal e execute o seguinte comando:
   ```bash
   git clone [https://github.com/ErickMelloNogueira/streaming-flix-xunit.git](https://github.com/ErickMelloNogueira/streaming-flix-xunit.git)
   ```

2. **Aceder à pasta do projeto:**
   ```bash
   cd streaming-flix-xunit
   ```

3. **Restaurar dependências e compilar a solução:**
   ```bash
   dotnet build
   ```

## Como Executar os Testes Unitários
O projeto inclui uma suite de testes automatizados para garantir a fiabilidade das regras de negócio. Para executar todos os testes via *Command Line Interface* (CLI), utilize o comando na raiz do projeto[cite: 4]:

```bash
dotnet test
```

## Cobertura de Testes Parametrizados
A garantia de qualidade foi implementada utilizando o *framework* **xUnit**[cite: 1, 4]. Foram escritos testes parametrizados utilizando os atributos `[Theory]` e `[InlineData]` que asseguram uma cobertura abrangente dos seguintes cenários[cite: 2, 4]:
- **Classificação de Planos**: Valida a atribuição correta dos pacotes "BÁSICO", "PADRÃO" e "PREMIUM" dependendo do número de ecrãs[cite: 2].
- **Cálculo de Desconto**: Garante a precisão matemática na aplicação de descontos de 10% (contratos de 6 a 11 meses) e 20% (contratos de 12 meses ou mais)[cite: 2, 3].
- **Validação de Acesso**: Assegura que o conteúdo adulto só é libertado quando o utilizador tem idade igual ou superior a 18 anos e a restrição do controlo parental se encontra desativada[cite: 2, 3].
