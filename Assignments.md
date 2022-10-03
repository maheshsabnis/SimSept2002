# Date: 22-09-2022

1. Take the following String

"The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is With a Mind to Kill by Anthony Horowitz, published in May 2022. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.

The character—also known by the code number 007 (pronounced "double-O-seven")—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time."

Perform Following Operatrions on the Above String
	- Findout Number of Words
	- Findout Number of Statements
	- Findout Number of Digits
	- Foindout Number of Special Characters
	- Convert the string in Tital Case i.e. First Character of Each word in Upper case
2. Take a following Array
	- string [] Names = new string [] 
	{
		"Mahesh", "Mukesh", "Manoj", "Manish", "Madhukar", "Madhusudan", "Mukund", "Ramesh", "Rajesh", "Rohit", "Ram", "Ravi", "Ravindranath", "Tejas", "Trilok", "Trivikram", "Tarun", "Vikram", "Vikas", "Vinod", "Vasideo", "Vasudev", "Chaitanya", "Chirag", "Chinmay", "Chimanrao", "Gundyabhau","Ganesh", "Ganesh"
	}

	- Perform Following Operations
		- Sort Arrya in Alphabetic Order of each String
		- Sort Srray by Length of String
		- Print all strings having First 4 Matching Characters

# Date:23-Sept-2022

1. MOdify the CS_OOPs_As_Application Project by adding a new Logic class for Nurse of name NurseLogic, this class will have methods for Add,Update,Delete and Read Nurse data. Similarly Modify the Doctor Logic class for Add,Update,Delete and TRead Doctor data. The NurseLogic class should also calcuate Income of Nurse.
2. Save the Doctor data and Nuser Data into the Dictionary 

# Date: 24-Sept-2022

1. Verify the following scenarios on Object Oriented Programming
	- Can we have Private Constructor in Class, if yes then what is use of it?
	- Can we have static constructor in class, if yes then what is use of it?
	- Can we have private or proctected virtual or abstract method in abstract class?
	- Can we override public virtual methods of abstract class using protected or private mthods of derive class?
	- Can we have abstract method in non abstract class?
	- Can we have sealed class modifier for derive class?
	- Can we have virtual methods in sealed class?
	- Can abstract class contains private data members in it?
	- Can we have abstract method in sealed class?
	- Can we create an instance of base class and cast it to the derive class?
	- Can we cast the derive class instance to base class?
	- Can we access the public virtual methods of base class w/o overriding these method in derive class using an instance of the derive class?
	- Can we assign the reference of base class to derive class instance?
	- Can we have not-static members in static class?
	- Can we access static data members in non-static methods? 
	- Can one interface implement other interface if yes then what is use of it?
	- Can a interface implement multiple interfaces if yes then what is use of it?  
2. Implement following LINQ Queries
	- Print a Second Max salary of employee for each designation
	- Print only those employees starts from character 'R' (upper or lower case)
	- Print Middle 6 records from the Collection
	- Update the Salary for each Employee with designation as 'Lead' by 5% ansd hence also calculate TDS as 15% of new salary
	- Print all Employees group by Designation and print them with sum of salary at the bottom of each group
	

# Date :26-09-2022
1. Write a test on the Login() method to check if the Login is successful or failed and also chek if the UserName and/or password arte empty
2. Write auNit Test on GetEmployee() to verify that the Method returns List of Employee
3. Write a test on  GetDetails() method that accepts 'id' make sure that id 'id' is 0 the method return null, if id is -ve then excepytion is throw and if employee is found based on id then make sure that the Employee object is retrurned with data in it  

# Date : 27-09-2022
1. Go thriugh the Thread, Parallel, and Task Projects first to understand them
2. Modify the code of CS_Parallel project which process the collection Parallely by writing each processed record in seperate file
	- Make sure that this file is written Asyncronously (use of Task Object) 


# Date: 28-Sept-2022

1. Use Scrips from Git to Create Department and Employee Table
2. Implement following
	- Try to Add Not null Column name 'Experience' in Employee Table
	- Print Max(Salary) Per DeptName and display result as EmpNo,EmpName, DeptName,Salary
	- Print Min(Salary) Per DeptName and display result as EmpNo,EmpName, DeptName,Salary
	- Print EmpName and DeptName of Employee Having Max and Min Salary (2 Select Statements)
	- Display Second Max Salary and Second Min Salary group by DeptName
	- Show EMployees only in Information Technology and Human Resource DeptName

# Date:29-Sept-2022
1. Create a Stored Procedure that will perform Insert operation in to the Employee table with following condition check
	- EmpNo MUST not be 0
	- EmpName MUST be String w/o any Special Characters
	- Deisgnation MUST be one of the following value
		- Director, Manager, Lead, Associate
	- Salary MUST be with the following rules
		- Director, Salary >= 900000
		- Manager, Salary >= 700000 to 899999
		- Lead, Salary >= 500000 to 699999
		- Associate, Salary >= 300000 to 499999
	- If Conditions for EmpNo, EMpName, Designation and Salary are not satisfied then raise error that
		- EmpNo is Invalid, Designation is not correct, EMpName is invalid, Salary range is invalid
	- MAke sure that DeptNo is already available inb Department Table to preven an un-necessary Referential Integrity or Foireign Key Error
		- If not then Raise an exceptio / erro saying that the DeptNo is not Found in Department Table
	- If the Capacity of Department is already full with Employees then the new Insert of Employee in that department MUST be rejected	 
		- e.g. If DeptNo 10 has Max Capacity is 5 and if already 5 Employees are present in Dept 10 in Employee Table then this new Employee Request must rais an exception saying that The Capacity is full

#Date: 30-09-2022
1. Perform CRUD Operations on Employee Table bt Creating Employee Class
2. Create a Class Named DbOperations with following method
	-CreateRecords(List<Department> depts, List<Employee> emps)
	 {
		 // Logic for Inserting Department and Employees based on the following
			- a. Make sure that the Capacity of Department is not full, if capacity is full then do not add employee in that department
			- b. If ValidateData() is true, then only add Depts and Emps
			- c. Make sure that the DeptNo is present while adding Employee this menas that in Each Employee record of List<Employee>, tye DeptNo value MUST be present in Department Table 
			- d. Save Transactions
				- Use AddRange() instead of Add()
	 }
	 - private bool ValidateData(Department dept, Employee emp)
	 {
		 // check for validation as
			- All String Coloumns are MUST
			- All Numeric Columns are Positive
			return true;
	 }

# Date:03-Oct-2022
1. Go through the MVC App, add a new Product COntroller and add its action Methods and Views.  
2. While Creating/Updating the Product MAke sure that the Product Data is valid based on Following Rules
	- The ProductId Must not be repeted (Now)
	- Make sure that the Price of the product MUSt be greater tha or equal to BasePrice of the category selected for the Product (Now)
	- MAke sure that the Edit View for Product also shows the Dropdow for Category Names
	- Make sure that the CategoryId is not repeted (Now)
	
