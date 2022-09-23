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

	