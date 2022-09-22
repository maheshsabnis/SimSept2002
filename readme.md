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