public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value;  }
    }

    public void MyMethod()
    {
        // Accessing a field directly instead of using the property
        _myField = 10;
    }
}