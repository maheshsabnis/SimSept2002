-- What are Triggres?
-- They are Database's Internal Events
-- They MUST be Configured Explicitly so that when a Table is inserted, updated, Deleted
-- then the corresponding log must be generated in Seperate Log or Audit Table

Create Table DepartmentAudit (
	 AuditId int identity(1,1) Primary Key,
	 AuditedDeptNo int not null,
	 AuditDate Date Not Null
);
Go

-- Create a Trigger that will Create a Audit Entry into the DepartmentAudit Table when a new
-- record is inserted in Department Table

Create Trigger Trigger_InsertDepartment
on Department -- Table Name that th trigget will monitor
After InSert -- The Trigger Condition
As
Begin
	Declare @DeptNo int
	-- get the DeptNo from the Inserted Operation on Department Insert Statement
	select @DeptNo=DeptNo from Inserted 
	-- Insert into the DepartmentAudit Table
	Insert into DepartmentAudit
	Values
	(
	   @DeptNo, GETDATE()
	);
End
Go

exec sp_InsertDept @DeptNo=451, @DeptName='Warehouse', @Location='Mumbai', @Capacity=667;
Go
Select * from DepartmentAudit;


Delete from Department where DeptNo=451; 





