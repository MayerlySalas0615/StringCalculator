namespace StringCalculator;

public class CalculatorTest
{
    [Fact]
    public void Cadena_String_1_Devuelve_1()
    {
        //Arrange
        string input = "1";
        
        //Act
        var resultado= CadenaStringDevolver(input);
        
        //Assert
        Assert.Equal(input, resultado);

    }

    [Fact]
    public void Cadena_String_2_Devuelve_2()
    {
        //Arrange
        string input = "2";
        
        //Act
        var resultado= CadenaStringDevolver(input);
        
        //Assert
        Assert.Equal(input, resultado);
    }

    private string CadenaStringDevolver(string input)
    {
        return "1";
    }
}
