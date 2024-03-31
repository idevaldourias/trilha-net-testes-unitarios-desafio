using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        bool retorno = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.False(retorno);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        List<int> listaMultiplicada = _validacoes.MultiplicarNumerosLista(lista, 2);

        Assert.Equal(resultadoEsperado, listaMultiplicada);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };

        int retorno = _validacoes.RetornarMaiorNumeroLista(lista);

        Assert.Equal(9, retorno);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };

        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        Assert.Equal(-8, resultado);
    }
}
