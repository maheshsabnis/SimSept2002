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

# Task Parallel Programming

1. Parallel class
	- Requests CLR for Threads to Procss the collection
	- The code need not to create and manage threads, instead they will be managed internally
	- Methods
		- Paralle.For()
		- Parallel.ForEah()
		- Parallel.Invoke()
			- We can perfrom Multiple tasks internally inside 'Invoke()' methods
2. Task
	- This represents a unit of Asynchronous Execution
		- Create a Thread
		- Dedicate an operation on the thread
		- Execute the Thread
			- Get Return Value from Task
			- Continue from one Task to Another Task and passes data across these tasks
	- The CLR Async Methods
		- These method name ends with 'Async()'
		- All these methods returns 'Task' Object
	- The .NET 4.5+
		- The 'async' method modifer, that represents the is executed asynchronously and it has at least one statement  or a method call that perform Async operations
		- In 'async' method, the statement that perform asyn operations must be applied with 'await' keyword
			- All File Methods
			- All Data Access Methods
			- All Network Methods
			- ASP.NET MVC and API executes the Request using 'ExecuteAsync()' method
			- Async HttpHandler and HttpModule
			

# Using EntityFramework
- EntityFramework Package
	- DbContext class
		- USed to Manage the Database Connection using the ConnectionString
		- Managed the Table Mapping of CLR Class with Database Tables using DbSet<T> class
		- Manages Db Transaction
			- SaveChanges() and SaveChangesAsync()
	- DbSet<T> class
		- Maps the CLR class of name 'T' with Database Table of Name 'T'
		- e.g.
			If the Table name is 'Department' then the CLR class Name will be 'Department'
		- Methods to Perform Read/Write Operations
			- Add(CLR Object) and AddAsync(Array of CLR Objects)
				- Add new Record(s) in Table
			- Remove(CLR Object)
				- Removes the CLR Object
			- Find(id) and FincAsync(id)
				- Search Recod Based on Primary Key
	- Pseduo code
		- Consider the CompanyContext is DbContext class that manages the Connection and Mapping and 'ctx' is an instance of the class
		- Consider 'Employees' is a DbSet<Employee> wheer Employee is CLR class that maps with the 'Employee' Table
		- Read All Records
			- var result = ctx.Employees.ToList(); or var result = ctx.Employees.ToListAsync();
		- Read a Single Record from Employees based on Primary Key e.g. EmpNo
			- var emp =ctx.Employees.Find(EmpNo); 
			- var emp = ctx.Employees.FindAsync(EmpNo);
		- To Add OR Append new Record in Employee Table
			- Create an Instance of Employee class and set values for all of its properties
				- e.g.	
					- EMployee emp = new Employee();
					0 emp.EmpNo=101l emp.EmpName="ABC";.....
			- Pass this object to Add() or AddAsync() method of DbSet
				- ctx.Employees.Add(emp);
				- ctx.Employees.AddAsync(emp);
			- Commit Transaction
				- ctx.SaveChanges();
				- ctx.SaveChangesAsync();
		- To Update Record
			- Search Record Based on Primary Key using Find() or FinsAsync() method
			- Pass this record to Remove() Method
				- ctx.Employees.Revove(emp);
			- Commit Transaction by calling SaveChanges() or SaveChangesAsync() method
		- To Delete Record	
			- Search Record based on Primary Key
			- Update its property values
			- Commit Transactions
- EF Approaches
	- Database First Approach
		- Generate entites based on database
		- Approach is used when the database need not be updated or its production ready or the Older Application is migrated to new application	by keeping database as-it-is
		- Use the Visual Studio EntityFramework Template to Generate Classes from database
			- This will also Generate XML files which may be an overhead
		- USe the 'Package Managed Console'
			- Tools->Nuget Package Manager -> Package Manager Console
			- Run the following command
				- Scaffold-DbContext "CONNECTION-STRING" Microsdoft.EntityFramework.SqlServer- OutputDir Models
					- The Application will buld first and the connect to Database usign the ConnectionString and generate classed for all tables
				-  Scaffold-DbContext "CONNECTION-STRING" Microsdoft.EntityFramework.SqlServer- OutputDir Models -Tables [COMMA-SEPERATED-NAMES -OF-TABLES] 
- Open-Close-Principal (OCP)
	- The System (Software) MUST be open for Enhancements/Extensions but MUST be close for Modifications
- If the Model Design aka Coinceptual design require changes or customization based on Customrs' needs as well as the customer may have liberty to use different database than suggested by you (or used by your product), then consider using 'Code-First Approach'
	- Steps for Working with Code-First
		- Create a Conceptual Logical Model (aka Entity Class)
			- Classes with Public Properties
			- Each Class will Have  a 'Key' property
				- This property will act as a Primary Identrity Key
				- This is implemented using the 'KeyAttribute' class from 'System.ComponentModel.DataAnnotations' package
					- Install-Package System.ComponentModel.Annotations
			- It is recommended that, properties should be applied with Data Annotations Rules i.e. Constraints
				- e.g. Required, Compare, RegEx, StringLength, etc.
			- If a relation is required across these models then use the One-to-Many and One-to-One Relation
		- Configure the Project to use EntityFramework
			- Use the package that is required for establising connection with Database
				- EntityFramework.SqlServer
			- Define a Database Conenction String in Configuration File 
			- Create a class that is derived from 'DbContext' class
				- The constructor of this class will be responsible to read the Connection String from Configuration
				- Define DbSet<T> properties in this class, where T is the Entity Class
				- Override the OnModelCreating() method
		- Generate Migration
			- The Class that will generate a Script to create database table(s)
			- Step 1
				- Enable Migrations for the project
					- PM&gt; Enable-Migrations
				- Add Migration to create a Class
					- PM&gt; Add-Migration [MIGRATION-NAME]
				- Update Database
					- This will execute the script to creare database and tables using the DbContext class
					- PM&gt; Update-Database 
			- Enforce a Specific Migration
				- Update-Database –TargetMigration:[MIGRATION-NAME]
- Fluent APIs
	- They are the approaches of using the Code-First by explicitly defing the Database Table Mapping on CLR Class properties using the code
	- The 'DbModelBuilder' class contains an 'Entity<T>()' , a generic method that is used to map the Model class to Table with all its properties
		- HasKey()
		- Property()  method that further allows to define MaxLenght, Relationships across Model class properties

# Programming with MVC

1. Project Structure
	- Models Folder
		- This Contains all Model / Entity Classes
		- We can also have Business Logic oin Sub-Folders
	- Controllers
		- Contains All MVC Controllers
	- Views
		- Contains a Sub-Folder that matches with Controller Class Name and contains views for each action method from the Controller
	- Scripts
		- Contains all JavaScript libraries and Files those send to Browser when the HTTP Request is received and View is rendered back to the Browser
	- App_Data
		- Contains Data Files e.g. SQL Server Local DB File (Not-Recommended)
		- Xml Files
		- JSON Files
	- App_Start
		- This contains Logic for Identity Management 
	- Contents 
		- Contains Bootstrap CSS for Look and Feel for UI
	- Fonts
		- Contains Fonts those are used by the Bootstrap
	- Global.asax	
		- The File that will start the Request Processing for MVC Apps
			- Initialize the Application
			- Create a Route Table
			- Load all Global Objects e.g. Filters
			- Create Bundle for All JavaScript Files those are send to Browser
	- Web.Config file
		- Contains Application Level Configurations e.g. ConnectionStrings, HttpHandlers, httpModules, etc.
	- Startup.cs
		- Thsi will staert the Application and hence load all Identity Modules aka Open Web Interface for .NET (OWIN)
- Programming Steps
	- Create Models
		- Entities, Data Access, Logic, etc.
	- Create Controllers With Action Methods
		- Validations
		- Security
		- Filters
		- Exceptions
	- Views
		- Generate Views to show data
- MVC Packages
	- System.Web.Mvc
		- MVC Runtime
		- Execute The MVC Request Processing
	- Packages for Views
		- System.Web.Razor
			- A New View Engine for MVC
			- Combination of C# and HTML, .cshtml
		- System.Web.WebPages
			- manages the execution 
		- System.Web.WebPages.Razor
			- Execute Razor View on MVC Runtime
	- System.Web.Routing
		- Used to Create and Manage the Route Table

- Controller
	- An Important part of MVC whihc is a class that accepts HTTP Request
	- THis further Evaluates the HTTP request and Exccutes methods from the Controller class
		- Each Public Method of Controller class is 'Action Method' because it is activated and executed based on HTTP Request
		- By default each Public method is HTTP-GET, means it will be executed with HTTP GET request received from the end-user
		- To execute the method with HTTP-POST request, it MUST be applied with [HttpPost] Attribute
		- Each action method returns a 'View' and Pass data received from Model layer so tthat View can show it
	- The 'ControllerBase' is the base class and its has following properties and Methods
		- Properties
			- RouteData
				- Used for Detecting the URL based on which the Controller and its action method will be executed using the  'RouteTemplate' 'ReuteConfig.cs' file
```` csharp
	public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
````

				- {controller}/{action}/{id} , the RouteTemplate
					- controller: The Name of the Controller in URL
					- action: The NAme of the Action Method in URL
					- id: The URL Parameter that is passed to the method. This is Optional
				- RouteData will read the URL
					- http://Myserver/MyApp/MyCtrl/MyAction/10
						- controller:MyCtrl
						- action:MyAction
						- id:10
					- The 'MyCtrl' will be loaded and its MyAction method will be executed by passing 10 as a parameter to it
			- ModelState
				- Of the Type ModelStateDictionary
					- This Represents the Model Validation applied on Model class that is Posted to the Action Method using HttpPost request
					- This has 'IsValid' property, this is set to false if the validation fails
						- ModelState.IsValid

			- ViewData: Of the type ViewDataDictionary, used to pass data dynamically from Action Method to View and Back. Similarly we have 'ViewBag' (Introducted in MVC 3) 
			- TempData: USed to send data across Controllers
			- Request: HttpRequest, Response:HttpResponse
			- User: IPrincipal, Used to Read the Current Login User
		- Method
			- View()
				- return View from Action Method
				- Various overloads
					- View(MODEL), View(VIEW-NAME-AS-STRING), View(VIEW-NAME-AS-STRING, MODEL), etc.
			- The View i.e. the .cshtml file from the sub-folder matched with the controller name of View Fol;der whihc match with the Action Name ( by default) will be returned
				- e.g. If Controller Name is 'MyController' that has Action Methods 'MyAction', then the 'Views' folder will have 'My' sub-folder and then it will have the 'MyAction.cshtml' view file that will be returned by default 
 
			- OnException(), OnAuthorization(), etc.

		- Interfaces Impleted by The 'Controller' class
			- IActionFilter: Used to Load an Executed Additional Logic that is applied on Controller class or its action method while requets Processing e.g. Logging Request, Custom Exception, etc.
			- IAuthenticationFilter: Used to for executing the Authorize and Authentication Filer for Security 
			- IAuthorizationFilter:: Used to for executing the Authorize and Authentication Filer for Security 
			- IDisposable: Unload the Controller class from Memory
			- IExceptionFilter:Load the Standard Exception Handling for the Controller
			- IResultFilter:THis will take of the Result responded after the action Method is executed 
			- IAsyncController: Used if the COntroller contains an async action methods
			- IController: The Controller Contract
			- IAsyncManagerContainer: Manages Async Action Execution
- To Add View, Right-Click on the Action Method and Select the 'Add View' from Context Menu, then select the Folowing information from the next window (This Process is known as 'Scaffolding')
	- Enter View Name, Note by defalt it will be same as the name of the action method that is right-clicked
	- Select View Template Type from following options
		- List: Show List of Model Data of the Model class i.e. IEnumerable&lt;Model&gt;
		- Create: A new Instance of Model class to accept data from End-USer to create new entry in database
		- Edit: An Instance of Model class which is supposed to be edited
		- Delete: An Instance of teh Model class which is to be deleted
		- Details: An Instance of Model class which is read-only
		- Empty: This does not have any HTML UI, we cna create it as per the need
		- Empty (Without Model): No model class, this is used fro JavaScript
	- Select the 'Model' class of which data is to be shown on View 
- View
	- Strongly Typed - Page View aka View, Accept Model and it is executed like an individual Page and show and accept data
	- Strongly Typed - Partial View aka User Control, Accept Model and it is executed like an a 'Re-Usable UI' on Page View
	- A Page View w/o Model Object. We can used thos for HTML and JavaScript design
- View is always executed on Server, it has a BAse class called as 'WebViewPage<TModel>'
	- The 'TModel' represents the Model class passed to View while scaffolding
	- The WebViewPage<TModel> class has following Properties
		- The 'Model' of the Type 'TModel', represents the Model class type opassed to view while scaffolding
			- e.g. If View Template is 'List' and model class passwd to it is 'Category', then TModel will be 
```` csharp
			IEnumerable<Category>
````
			- Hence the 'Model' property will be Collection of Category object 
		- The 'Html', of the type HtmlHelper<TModel>, used to generate the HTMl UI by loading HTML UI Helper method on the View
		- The 'ViewData' of teh Type 'ViewDataDictionary', used to show data other than provided by the Model class to View 

