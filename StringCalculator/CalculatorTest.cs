namespace StringCalculator;

public class CalculatorTest
{
    [Theory]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("456")]
    public void CadenaStringDevuelveString(string cadenaTexto)
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
    
    [Theory]
    [InlineData("1,2")]
    [InlineData("1+2")]
    public void Cadena_String_1mas2_Devuelve_Suma3(string cadena)
    {
        //Act
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal("3", resultado);
    }
    
    [Fact]
    public void Cadena_String_4menos2_Devuelve_Resta_2()
    {
        //Arrange
        string cadena = "4-2";
        
        //Act
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal("2", resultado);
    }

    [Fact]
    public void Cadena_String_menos4menos10DevolverMenos14()
    {
        //Arrange
        string cadena = "-4-10";
        
        //Act
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal("-14", resultado);
    }
    

    private string CadenaStringDevolver(string cadena)
    {
        
        if (cadena.Contains(",") || cadena.Contains("+"))
        {
            string separador = cadena.Contains(",") ? "," : "+";
            var numeros = cadena.Split( separador );
            return (int.Parse(numeros[0]) + int.Parse(numeros[1])).ToString();
        }
        
        if (cadena.Contains("-"))
        {
            var numeros = cadena.Split('-');

            int num1 = string.IsNullOrWhiteSpace(numeros[0]) ? 0 : int.Parse(numeros[0]);
            int num2 = string.IsNullOrWhiteSpace(numeros[1]) ? 0 : int.Parse(numeros[1]);
            int num3 = numeros.Length > 2 && !string.IsNullOrWhiteSpace(numeros[2]) ? int.Parse(numeros[2]) : 0;

            return (num1 - num2 - num3).ToString();
        }
        
        return cadena;
    }
}
