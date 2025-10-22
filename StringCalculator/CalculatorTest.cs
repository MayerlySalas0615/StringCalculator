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
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal(cadena, resultado);
    }

    [Fact]
    public void Cadena_String_1y2_Devuelve_Suma_es_3()
    {
        //Arrange
        string cadena = "1,2";
        
        //Act
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal("3", resultado);
    }
    
    private string CadenaStringDevolver(string cadena)
    {
        return cadena;
    }
}
