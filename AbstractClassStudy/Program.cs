using AbstractClassStudy;

// Ref: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
// Ref: https://www.bytehide.com/blog/abstract-class-vs-interface-csharp


// Note: this project won't compile.




// Trying to create an instance of an abstract class will generate an error.
var myAbstractClass = new MyAbstractClass();


// MyAbstractClass2 contains no "abstract" methods, only regular ones.
// Still, we can't create an instance of it.
var myAbstractClass2 = new MyAbstractClass2();


// Calling a static method from an abstract class seems to work OK.
var k = MyAbstractClass.GetValue2();


var myClass = new MyClass();
var i = myClass.MyMethod(); // Calling method in MyClass that uses method from the abstract class.
await myClass.AbstractClassSleepMethod(1000); // Calling a method in the abstract class.
var value = myClass.AbstractClassMethod3(); // Calling a method in the abstract class.



// Abstract class has to be inherited.
// All methods marked as "abstract" must be overridden, or it won't compile.
class MyClass : MyAbstractClass // <- Error because not all "abstract" method are overridden.
{
    // Use "override" keyword to override the base class method. 
    public override void AbstractClassMethod1()
    {
        throw new NotImplementedException();
    }

    public int MyMethod()
    {
        // Calling a method in the abstract class.
        var value = AbstractClassMethod3();
        return value;
    }
}


/* Abstract Classes vs Interfaces
 
Key Differences Between Abstract Classes and Interfaces in C#
    Abstract classes can contain implemented methods, while interfaces only contain method signatures* (* - see c# 8 version for changes).
    Classes can implement multiple interfaces, but they can inherit from only one abstract class.
    Abstract classes can have constructors, while interfaces cannot.
    Abstract classes can have fields and properties, while interfaces can only have properties.
    Abstract classes are typically used for creating a base class for other classes to inherit from, 
    while interfaces are used for defining a contract that classes must implement.
 
 
 
 
When to Use an Abstract Class vs When to Use an Interface in C#
    As a general rule, you should use an abstract class when creating a base class that needs to be inherited 
    by other classes in a class hierarchy. If you need to define a behavior that can be implemented by multiple 
    unrelated classes, you should use an interface.
    If you need to add new members or behavior to a base class, you can add them to an abstract class. 
    However, if you need to add behavior to an existing class that cannot inherit from a new base class, 
    you can use an interface.
    Another important consideration when deciding between an abstract class and an interface is the level 
    of abstraction needed. Abstract classes can provide a higher level of abstraction than interfaces, 
    as they can include both abstract and non-abstract members. Interfaces, on the other hand, 
    only include abstract members.
    It’s also worth noting that while a class can inherit from multiple interfaces, 
    it can only inherit from one abstract class. This means that if you need to provide multiple behaviors 
    to a class, using interfaces may be a better option. 
 
 */