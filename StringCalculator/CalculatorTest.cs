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

    private string CadenaStringDevolver(string input)
    {
        return input;
    }
}
