-- Stored Proc
-- It is a Database Programmable Object, that is created once
-- and it is always resides into the Database Engine
-- This object is required by the Client using its name and this
-- object can optionally have parameters like input and output
-- The SP can perform following operations
	-- Implementing Programming Constructs e.g. If..Else Statements
	-- Loop
	-- They can have Exception Handling aka Error Handling
	-- They can perform CRUD Operations
-- Syntax
	-- Create | Alter Procedure  [NAME] (@Parameter DataType IN|OUT....)
	-- AS
	-- Begin
		-- Logic
	-- End
	-- Go (Complete a SP as an Execution Block/Body and Execute it)

-- Execution of SP
	-- Exec [Name] @Parameter,,,,, in any


-- A Simple Stored Procedure to read all Employees


Create Procedure sp_getAllEmployees
As
Begin
	select * from Employee
End
Go

Exec sp_getAllEmployees;
Go

-- Passing Input Parameters to SP
-- Default is input parameter

create procedure sp_GetEmployeesByDesination
 @Designation varchar(200)
As
Begin
	select EmpNo, EmpName, Designation, Salary, DeptNo
	From Employee
	where Designation=@Designation;
End
Go

Exec sp_GetEmployeesByDesination @Designation='Manager';
Go

-- Declaring Local Variables in SP to use them inside the SP Block
-- abd optionally using them to return data from Stored Proc

create proc sp_GetSumSalaryByDeptNo
 @DeptNo int
As
-- Declare Local Variables here
   Declare @SumSalary int; -- This is Not output parameter 
Begin
  select @SumSalary = Sum(Salary)
  from Employee
  Where DeptNo = @DeptNo;

  -- Use the return statement
  return @SumSalary;
End
Go
-- Declare a Variable for Storing data
Declare @SumSal int;
-- Execute the SPand collect the result into the delcare variable
exec @SumSal = sp_GetSumSalaryByDeptNo @DeptNo=20;
-- Print the Result
Select @SumSal;
Go

-- The Stored Procedure with Out Parameter
create proc sp_GetSumSalaryByDeptNoAndOutParam
 @DeptNo int,
 @ResulantSum int OUTPUT
As
-- Declare Local Variables here
   Declare @SumSalary int; -- This is Not output parameter 
Begin
  select @SumSalary = Sum(Salary)
  from Employee
  Where DeptNo = @DeptNo;

  -- Use Create a Reultant as a Select statrement that will
  -- create a Cursor and will store data in Output variable
  select @ResulantSum = @SumSalary;
End
Go

-- Declare a Variable for Storing data
Declare @SumSal int;
-- Execute the SPand collect the result into the delcare variable
exec sp_GetSumSalaryByDeptNoAndOutParam @DeptNo=20,@ResulantSum=@SumSal Output;
-- Print the Result
Select @SumSal;
Go

-- SP for Insert Operations
Create Proc sp_InsertDept
	@DeptNo int, @DeptName varchar(100), @Location varchar(100), @Capacity int
As
Begin
  Insert into Department (DeptNo, DeptName, Location, Capacity)
  values
  (@DeptNo,@DeptName,@Location,@Capacity);
End
Go
 Exec sp_InsertDept @DeptNo=70,@DeptName='Transport', @Location='Mumbai', @Capacity=900;
 Go

 Select * from Department;
 Go

 -- Lets write the Stored Procedure that will handle exception
 -- The SQL Server Standard Error Functions
 -- Error_Number(), Error_Message(), Error_SEVERITY(), ERROR_STATE()

 Create Proc sp_InsertDeptWithExceptionHandling
	@DeptNo int, @DeptName varchar(100), @Location varchar(100), @Capacity int
As
Begin
  Begin Try
	  Insert into Department (DeptNo, DeptName, Location, Capacity)
	  values
	  (@DeptNo,@DeptName,@Location,@Capacity);
  End Try
  Begin Catch
	-- Lets catch the exception
	select ERROR_NUMBER() as Error_Number,
		   ERROR_MESSAGE() as Error_Message,
		   ERROR_SEVERITY() as Error_Severity,
		   ERROR_STATE() as Error_State

  End Catch
End
Go
 Exec  sp_InsertDeptWithExceptionHandling @DeptNo=70,@DeptName='Transport', @Location='Mumbai', @Capacity=900;
 Go


create Proc sp_GetSumSalaryConditionally
   @DeptNo int
As
Begin
	-- if the @DeptNo is -Ve then return Error Message in Cursor
	if @DeptNo <= 0
		 select 'DeptNo cannot be 0 or -Ve';
	else
		Select Sum(Salary) as Salary 
		From Employee
		Where DeptNo=@DeptNo;
End
Go

exec sp_GetSumSalaryConditionally @DeptNo = 0;
Go


-- Working with Transactions
-- Insert into Department as well as into Employee as a Single Trsanction

Create Proc sp_MultiTableInsert
  @DeptNo int, @DeptName varchar(100), @Location varchar(100), @Capacity int,
  @EmpNo int, @EmpName varchar(200), @Designation varchar(200), @Salary int
As
Begin
	Begin Tran
	  Begin Try	
		-- Insert Dept
		Insert into Department (DeptNo, DeptName, Location,Capacity)
		Values
		(@DeptNo, @DeptName, @Location, @Capacity);
		-- Insert Emp
		Insert into Employee (EmpNo, EmpName, Designation, Salary,DeptNo)
		Values
		(@EmpNo, @EmpName, @Designation, @Salary, @DeptNo);
		 -- If No Error Coomit Transaction
		 COMMIT Transaction
	  End Try
	  Begin Catch
		-- Rollback Changes if Error Occurres
		ROLLBACK Transaction
	  End Catch	
End
Go

exec  sp_MultiTableInsert @DeptNo=1001, @DeptName='Warehouse', @Location='Mumbai', @Capacity=250, @EmpNo=2002, @EmpName='Rahul', @Designation='Director', @Salary=88999; 
Go
 
Select * from Department;
Select * From Employee;

Insert into Employee Values (2003, 'MAhesh', 'Manager', 700000, 12);
