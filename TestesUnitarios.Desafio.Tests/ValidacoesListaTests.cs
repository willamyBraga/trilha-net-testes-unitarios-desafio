using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //PROBLEMA: Ao passar uma lista com diversos números, mas sem o número 10, deve retornar falso, pois não encontrou o 10 na lista

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var encontrouNumero10 = lista.Contains(numeroParaProcurar);

        // Assert
        Assert.False(encontrouNumero10);
    }

    //TODO: Corrigir a anotação [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //problema: Ao passar uma lista com diversos números, mas sem o número 10, deve retornar falso, pois não encontrou o 10 na lista

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        // Act
        var resultadoAtual = lista.Select(x => x * 2).ToList();

        // Assert
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //problema: Ao passar uma lista de números inteiros, sendo o maior deles 9, deve retornar o 9 como maior elemento dentro dessa lista

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var maiorNumero = lista.Max();

        // Assert
        Assert.Equal(9, maiorNumero);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    { 
        // Problema: Ao passar uma lista de números inteiros, sendo o menor deles -8,
        // deve retornar o -8 como menor elemento dentro dessa lista

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var menorNumero = lista.Min();

        // Assert
        Assert.Equal(-8, menorNumero);
    }
}
