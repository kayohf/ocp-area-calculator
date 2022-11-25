/*
* ocp-area-calculator
*
* Esse é um teste simples de Open-Closed principle para um calculador de área,
* aonde a classe apenas tem a responsabilidade de retornar o valor de uma área
* que será executada por uma Func<> que contém as regras para se ter a tal área.
*
* Falta aqui tratar a exception que pode ocorrer com a Func<> que vai ser executada.
* 
*/

var areaC = new AreaCalculator<double>();

Func<double, double> CircleRule = (double radius) => {
    return Math.PI * (radius * radius);
};

Func<double, double> SquareRule = (double lengthOfOneSide) => {
    return lengthOfOneSide * lengthOfOneSide;
};

areaC.filter(CircleRule, 10);

Console.WriteLine($"Circle Rule: {areaC.result}");

areaC.filter(SquareRule, 10);

Console.WriteLine($"Square Rule: {areaC.result}");

public class AreaCalculator<T> {
    public T? result { get { return _result; } } 
    private T? _result { get;set; }

    public void filter(Func<T?, T> filterRule, T value) {
        _result = filterRule(value);
    }

}