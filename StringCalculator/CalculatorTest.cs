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
    public void Cadena_String_1y2_Devuelve_Suma_da_3()
    {
        //Arrange
        string cadena = "1,2";
        
        //Act
        string resultado = CadenaStringDevolver(cadena);
        
        //Assert
        Assert.Equal("3", resultado);
    }
    
    [Fact]
    public void Cadena_String_1mas2_Devuelve_Suma_da_3()
    {
        //Arrange
        string cadena = "1+2";
        
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
    
    private string CadenaStringDevolver(string cadena)
    {
        
        int num1 = 0;
        int num2 = 0;

        if (cadena.Contains(","))
        {
            var numeros = cadena.Split(',');
            return (int.Parse(numeros[0]) + int.Parse(numeros[1])).ToString();
        }
        
        if (cadena.Contains("+"))
        {
            var numeros = cadena.Split('+');
            return (int.Parse(numeros[0]) + int.Parse(numeros[1])).ToString();
        }
        
        if (cadena.Contains("-"))
        {
            var numeros = cadena.Split('-');
            
            num1 = string.IsNullOrWhiteSpace(numeros[0]) ? 0 : int.Parse(numeros[0]);
            num2 = string.IsNullOrWhiteSpace(numeros[1]) ? 0 : int.Parse(numeros[1]);
            
            return (num1 - num2).ToString();
        }
        
        return cadena;
    }
}
