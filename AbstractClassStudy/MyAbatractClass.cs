namespace AbstractClassStudy
{
    // Abstract class: is a restricted class that cannot be used to create objects
    // (to access it, it must be inherited from another class).
    public abstract class MyAbstractClass
    {
        private readonly string? _name;

        // Abstract class can have constructors.
        public MyAbstractClass() { }

        // Abstract class can have constructors.
        public MyAbstractClass(string name)
        {
            _name = name;
        }

        // Abstract properties
        public abstract int X { get; }
        public abstract int Y { get; }



        // You can then define one or more abstract methods and non-abstract (regular) methods in the class
        // Declare methods that will be overridden. Use the "abstract" keyword.
        // Abstract method: can only be used in an abstract class, and it does not have a body.
        // The body is provided by the derived class (inherited from).
        public abstract void AbstractClassMethod1();
        public abstract void AbstractClassMethod2();

        // We can create regular methods in abstract class.
        public int AbstractClassMethod3()
        {
            return 1;
        }

        // We can create regular methods in abstract class.
        public async Task AbstractClassSleepMethod(int sleepTimeInMilliseconds)
        { 
            await Task.Delay(sleepTimeInMilliseconds);
        }

        // Static method.
        public static int GetValue2()
        {
            return 1;
        }
    }
}
