using System;

public class TextInput
{
    protected string str;

    virtual public void Add(char c)
    {
        str += c;
    }

    public string GetValue()
    {
        return str;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if(Char.IsDigit(c))
        {
            str += c;
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.ReadLine();
    }
}
