namespace StringCalculator;

public class CalculatorTest
{
    [Theory]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("456")]
    public void Cadena_String_1_Devuelve_1(string cadenaTexto)
    {
        //Act
        var resultado= CadenaStringDevolver(cadenaTexto);
        
        //Assert
        Assert.Equal(cadenaTexto, resultado);
    }

    [Fact]
    public void Cadena_String_menos2_devuelve_menos2()
    {
        //Arrange
        string cadena = "-2";
        
        //Act
        string resultado = CadenaNegativos(cadena);
        
        //Assert
        Assert.Equal(cadena, resultado);
    }

    private string CadenaNegativos(string cadena)
    {
        throw new NotImplementedException();
    }

    private string CadenaStringDevolver(string input)
    {
        return input;
    }
}
