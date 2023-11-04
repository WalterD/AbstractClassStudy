namespace AbstractClassStudy
{
    // An abstract class must be inherit. Decorating an abstract class with "sealed" modifier generates an error.
    sealed abstract class MyAbstractClass3 
    {
        public int AbstractClassMethod1()
        {
            return 1;
        }

        public int AbstractClassMethod2()
        {
            return 1;
        }
    }
