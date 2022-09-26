# .NET refreshing course

# C# Types
- System.Type, a Namespace for Type Denitions
	- Value Type
		- Resides in Stack and Holds the Data that will be used during execution
		- The 'typeof()' data is known to the CLR during the execution, e.g. int, float, double, etc.
		- byte, short/ushort, int/uint, long/ulong -- Full Integers
		- float, double -- Floating point
		- decimal, the big value store
		- char

	- Reference Type
		- The Stack contains the identifier whihc holds the data
		- The Heap contains the 'typeof()' data and actual data

		- System.Object, a Top level declaration
		- Following Types For Reference Types
			- Object / object
			- string
			- Arrays
			- Collections
			- Classes
	- Convert Value-Type-Into-Reference-Type, known as Boxing
		- The Hep Contains the DatatType of Value type as First Entry and second entry actual value
	- System.Collections .nET framework 1.0 and 1.1
		- Contains Collection Classes to store large volume of the data but each data entry is stored as object *(Boxing)
			- ArrayList, LinkedList, etc.
		- Since UnBoxing is needed to read data from Collection classes this reduces the performance hence use 'Generics'
			- System.Collections.Generics
				- List<T>
				- Queue<T>
				- Stack<T>
				- Dictionary<K,V>
				- HashSet<V>
				- KeyValuePair<K,V>
	- Best Practices to be Taken into Consideration before Processing String or any reference types
		- Make sure that, you check for Empty string or null string
		- This check will prevent the un-necessary processing of the string whihc may result into the applciation crash
	- The Array is a Reference Type
		- Any array defined in .NET will be an isntance of 'System.Array' class
			- This class has its own methods which can be used by array declaratrion
			- The Array is Fixed-Size Contegous Value Storage 
				- We cannot easily define the Array as Dynamic Array
			- Use Collections Instead
				- Each record in collection is object
# Application Development using Object Oriented Programming (OOPs)
1. Class
	- Foundation of OOPs
	- Data Members
		- used to store data
	- Member Funcation aka Methods
		- Define Behavior for data stored in class
	- Properties
		- Fields those are used to validate Data Memebers as well as set behavior on Data Members
- OOPs with Access Spercifiers
	- Public: Accessible Everwhere, Private: Only in declaring class, Protected: In declaring class and its derived class, Internal: Withing a namespaces across all classes in the namespace, Protected Internal: All classes within an namespace as well derive class in other namespace, (private protected C# 7.0+ : Derive class as Provate Member)
- OOPs Access Modifiers
	- USed to define behavior of class and members 
		- abstract: The class cannot be instantiated and MUST be inherited. THis class cnot be instantiated
		- sealed: The class whican canot be inherited
		- static: The class need to create create an instance to access its members, instead public members of class can be accessed directly using class name
		- virtual: Applied on method so that ikts can be overiden byt method in derive class
		- abstract: Used in abstract class to define a method as abstract method, this method does not have any implementation and derived class MUST provide implementation to this method by overrding it
		- overrides: Used by the method in derived class to override either virtual or abstract method of the base class
		- new: Used by the method in derived class to shadow methodmof the base class
- Inheritence
	- Process of deriving a class from base class where the base class has a general reusable information and the derive class uses the re-usable information of base class as it is and add specific information in the derive class
	- The inheritence implements 'is-a' relationship
		- e.g. If Staff is base class and Doctor class is derived from Staff class then we can say Doctor 'is-a' Staff
	- Inheritence Types
		- Simple Inheritence: One Base class has one derive class
			- e.g.
				- class Base {}
				- class Derive:Base{}
		- Hierarchical Intherience
			- Multiple classes are derived from One Base class
			- e.g.
				- class Base {}
				- class Derive1:Base{}, class Derive2:Base{},....
		- Multi-Level Inheritence
			- The Derive class act as a base class for further derived class
			- e.g.
				- class Base {}
				- class Derive:Base{}
				- class Derive1:Derive{}
	- NO MULTIPLE INHERITENCE SUPPORTED BY .NET LANGUAGES

- Abstract Classes
	- The class that cnnot be instantiated
	- This class MUST be inherited
	- This class May have methgods with default implmentation which can be extended by derived classes or used as it is by derived classes, such methods MUST be modified as 'virtual' methods 
	- This class may have some methods w/o any implementation and the derived class MUST implemenet them with logic, these methods MUST be modifired as 'abstract' methods 


- Upcasting
	- Define a Reference of the Base class and pass an instance of derived class to it
	- e.g.
		- class Shape{}
		- class Circle : Chape {}

		- Circle c = new Circle; instance of Circle, the derived class
		- Shape shape = c; the upcasting
- Downcasting
	- Define a reference of the Base class
		- Shape shape;
	- Instantiate it using the Derive class
		- shape = new Circle();
	- Define an additional reference of the derive class and pass the base class reference which is instantiated using the instance of the derive class
		- Circle circle = (Circle)shape;

- Using Polymorphism
	- This is used to provide a mechansim to compile-time as-well-as run-time to decide which method from which class it to be accessed based on the Class Instance Available while executing the application
	- Compile-Time Polymorphism
		- The Class instance is already created and has knowledge of the method that is to be Invoked, provided the class method is overrding its base class method
	- Runtime or Dynamic Polymorphism
		- The Runtime detect an instance of the class of which method is to be called 

- Generally
	- The class that contains a gateway method is ideally a final class, means this class MUST not be inherited
	- Make this class as 'sealed' class

- If we need to share a common data across all the classes within a Layer, then use the 'static' class with static members (Data Members and methods)
	- The Static Class Cannot be Instantiated
	- This is Thread-Safe, means that the class is loaded and its lifecycle is managed by the MainThread allocated to the application by the .NET Runtime (CLR)

- Controlling the Classes and its members Within Namespace as well as other Namespaces
	- This will help to create a class as well as its members with predefined scope so that they won't be  accessible in add-hoc way
	
- Interfaces
	- They are contracts thise are implemeneted by classes to provide the standard method structure, so that the class amnd its methods are accessible using an interface reference 
	- Use intrefaces to establish communicatoin across Homogenious or Hetrohenious Applications
	- Facts
		- A Class can implement one-or-more interfaces
		- A Calss can derive from 'One-Base-Class' but can implement multiple interfaces, but this is not Multiple Inheritence
		- A Class can implement Interface with following ways
			- Implicit Implementation: The methods defined in interface are own by the class. These methods can be accessible using class instance as well as interface reference instantiated using the class
			- Explicit Implementation: Methods defined in interface are implemeneted by class, but these methods are owned by the interface, means these methods are only accesible using interface reference instantiated using the class 
				- This is recommended when class implements multiple interfaces and more than one interface have same samethod with same signeture and class wants to implement both these methods seperately with differn logic
- Abstract Class Vs Interfaces
	- Abstract class is fastest in Verticle serach for BAse class within an assembly or namespace
		- Common Starndard for Implementation across all classes in highly cohesive application use Abstract class
		- e.g.
			- Stream class under System.IO namespace
				- FileStream, NetworkStream, MemoryStream, etc.
	- Use Interface when the communciation standard is implemented across herizontal application
		- e.g.
			- All Collections in .NET implements 'IEnumerable' interface for reading data from Collection
			- Hence We can easily read data from one-type-of-collection and write into other-type-of-collection
				- e.g.
					- List to Array
			
- Language Specific Enhancements in C# .NET 3.5 with C# 3.0
	- Lambda Expressions
		- Used when a method accepts a delegate as its input parameter 
		- The delegate encapsulate the method implementation
	- Extension Methods
		- Used to define an additional utilities to an existing class of which code is not accessible or the class cannot be inherited (sealed class) or the class is alrerady used in production which we cannot change/modify
- Programming Structure using Language-Integrated-Query (LINQ)  .NET 3.5 with C# 3.0
	- Bring Object and Data Together
	- In-Memory Collection Processing for Reading (and optionally writing)
	- Expression Extension Methods
		- Thses Methods accepts 'Lambda Expression as input paframeter'
			- Where(), OrderBy(), OrderByDescending(), GroupBy(), Select(), Take(), Skip(), First(), Last(), FirstOrDefault(), LastOrDefault(), etc.
	- Imperative Operators
		- where, select, order by desc, order by, group by, etc. 
- Use of Task Parallel Librarh (TPL) future of C# and hence .NET App deveopment .NET 4.0+ with C# 4.0+
	- Encapsulate the Threads and asynchronous operations using Task class
	- Performs Parallel Processing of the Collection (Huge data) by encapsulating the Threads by using CPUs on the machine to improve performance using 'Parallel' class 
	- The ConcurrentCollection to share collection across muktiple threads
		- System.Collections.Concurrent
			- Thread-Safe Collections
				- ConcurrentBag
				- ConcurrentDictionary
				- ConcurrentStack
				- ConcurrentQueue

# TDD
1. Unit Testing
	- NUnit
		- Mist Popular Feramesowek that is used to test Code with Each (Or most of the lines of Code)
		- Opes Source
		- Integrated with Visualb stuidio
	- MsUnit & xUnit
		- Frameowerks priveded by Microsoft

2. Packaes
	- mUnit
	- Use ade Adapter
3. Object Model
	- TestClass Attbute
		-  THis is aplied on th class whih Contains The Method for wrting the unit Test
	- TestMethod Attrubite that spepfies that The test code will be exsecued when TGest runs
	- Assertion
		- This is a Expected Assertion
		- Comparision
		- Object Type Equality
			- Equao 
			- Greatethan, LessThan, AsType, AsExcception