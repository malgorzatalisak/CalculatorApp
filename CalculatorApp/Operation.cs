using System;

public class Operation
{
    public string OperationName { get; set; }
    public double Operand1 { get; set; }
    public double? Operand2 { get; set; }
    public Func<double, double, double> BinaryFunction { get; set; }
    public Func<double, double> UnaryFunction { get; set; }

    public Operation(string operationName, Func<double, double, double> binaryFunction)
    {
        OperationName = operationName;
        BinaryFunction = binaryFunction;
    }

    public Operation(string operationName, Func<double, double> unaryFunction)
    {
        OperationName = operationName;
        UnaryFunction = unaryFunction;
    }
}
