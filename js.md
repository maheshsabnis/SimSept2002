# JavaScript Application Development
- JavaScript Object Model
	- The 'object' is  highest level Type, everything is Object
	- Standard Objects
		- window, the current loaded browser
		- document, the HTML Document Object Model (DOM) loaded in browser
	- Types
		- Number, numeric values
		- String, textual data
		- Array, collection of values
		- Date, the 'Date()' object
		- Math, Mathematical Operations
		- Object
			- Array, Date, and function
		- JSON Object aka literal, keya value pair of declarations
			- var obj = { key:value,.....};
		- The 'console' object
			- This is used to print messaged on Console WIndows as well as Browser's console 

	- Variable declaration
		- the 'var' keyword
		- e.g.
			- var x;
				- x can have any value e.g. numeric, string, array, object, function
	- PProgramming COnstructs
		- conditions
			- if(){...}, if(){....}else {....}, if(){....}else if{}
			- switch(CONDITION){case '': .... break; }
		- Iteration
			- for..loop
			- for..in loop, simplication of for..loop
			- while..loop
			- do..while
		- Operators
			-	 +,-,*,/
			- The '+' is by default used for string concatination
			- >,<, >=,<=
			- ==, the 'value comparision'
				- e.g. 
					- 1 == "1"; is true
			- ===, the deep equality, the type and value both MUST be same
				- e.g.
					- 1 === 1; is true
					- 1 === "1"; is false
			- !==, not equal to
			- || OR
			- && AND

			
	- Methods
		- Associated with Objects
			- window.onload, it's an event based method that is executed when the browser is loaded
			- document.getElementById(), used to extract and HTML element based on it's 'id'
			- document.getElementsByTag(), returns an array of HTMl elements having same Tag e.g. 
```` html
		<input type='text'/><input type='text'/><input type='text'/><input type='text'/><input type='text'/>
````
			- JavaScript
```` javascript
		var inputs =document.getElementsByTagName('input'); // return an array of all input types 
````
			- document.getElementsByClass(); return an array of HTML elements having same classs name
			- document.addEventListener('EVENT', callback function, boolean)
				- Used to attach an event with HTML element
			- document.querySelector(Criteria)
				- return a HTML Element object based upon the criteria
			- Array Methods
				- push(), pop(), sort(), shift(), unshift(), slice(), splice(), indexOf(), lastIndexOf(), etc.
				- te length property
			- String methods
				- toLowerCase(), toUpperCase(), subStr(), etc.
			- Object methods
				- create(), assign()
		- events
			- click, mouseenter, mouseleave, change, keyup, keydown
			- e.g. Defining an event to HTML Element
```` html
	<input type='button' id='btn'/>
````
```` javascript
		// 1. Read the HTML Element based on its id
		var btn = document.getElementById('btn');
		// 2. Arrach an event, the 'false' mens that event and its callback will be released
		btn.addEventListener('click', function(){.....}, false);
````
- Functions
	- Modular approach to write a logic in JavaScript
	- The 'function' keyword
	- These can be used to create a data encapsulation in JavaScript like a class
	- Three Types of functions
		- The Reference function, we can store a function in a variable
			- This function uses 'this' prefix to represent the 'public' declaration
			- The public declarations can be accessed using an instance of the function
```` javascript
	 var myObject = function(){
		 this.f1=function(){.....};
		 this.f2 = function(){.....}
	 };

	 // instantiate it
	 var obj = myObject();
	 obj.f1(); obj.f2.();
````
		- A function aka a close function
			- This is a complete function body that returns a JSON object	
			- All these return key:value pairs arre public
```` javascript
		function MyObject(){
		   // some private declaration here...
			function privateFucntion(){......};
			var x = 10;
			// public return object
		   return {
		      f1:function(){....},
			  f2:function(){......},
			  prop:value
		   };
		};

		// define an instance of  MyObject
		var obj = new MyObject();
		obj.f1();obj.f2();

````
		- Immediately Invocable Function Expression (IIFE) aka self-executable JavaScript aka a Module creation in JavaScript
			- this will be executed by default when a window is loaded
```` javascript
	(function(){.......})();
````
			- The Module using IIFE
```` javascript
	var module =(function(){
		//some local functions
		function f1(){......};
		function f2()P{......};

		// public return out of the Module
		return {
			func1:f1,
			func2:f2
		};
	   
	})();	


	 
	module.func1();
	module.func2();
````
		

- Communication
	- XmlHttpRequest object Ajax call
	- jQuery $.ajax()
	
	- jQuery
		- The '$' object, the jQuery Object 
	- instead of using window.onload
		- $(document).ready(function(){........});
	- inserted of document.getElementById()
		- $("#id of HTMLElement")
	- instead of document.getElementsByTagName()
		- $("TAG-NAME"), e.g. $('input'); all input elements
	- instead of using document.getElementsByClassName()
		- $(".CLASS-NAME"), e.g. $('.c1')l where 'c1' is a class atrribute of HTMl element
	- instead of document.addEventListener() for attacheing event
		- $("#id of HTML Element").on('event-name', function callback)
	- $.each(), a function for itartion
	- All Syntax of JavaScript is supported by jQuery
	- ASP.NET MVC 4+
		- The default support for jQuery