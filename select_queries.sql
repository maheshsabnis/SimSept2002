-- Where clouse
select EmpNo, EmpName, Designation, Salary from Employee where DeptNo=10;

select EmpNo, EmpName, DeptNo, Salary from Employee where Designation='Director';

Select EmpNo, EmpName, DeptNo, Salary, (Salary * 0.1) as Tax ,Designation
From Employee;

select EmpNo, EmpName, DeptName, Designation, Salary, Location
From Employee, Department
Where Employee.DeptNo = Department.DeptNo;

-- Pattern Matching using 'Like' operator
-- Print Employee Details for all Employees Start with 
-- Character M
select * from Employee where EmpName Like 'M%';
-- Data in specific values using 'In' operator
-- Print Employees only in Specific DeptNo
select * from Employee Where DeptNo In(10,30,50);  
-- OR operator
select * from Employee Where DeptNo=10 or DeptNo=30 or DeptNo=50;
-- AND Operator using the Range operator
-- Between is equivalent to Salary >=300000 AND Salary <=500000
select * from Employee where Salary Between 300000 AND 500000;
-- Order By ascending (Default)
select * from Employee Order by EmpName;
-- Order by desc
select * from Employee Order by EmpName desc;
-- Aggrigate function
-- min(), max(), sum()
select Designation, max(Salary) from Employee
Group by Designation;
-- groupby
select DeptNo, Sum(Salary) from Employee
group by DeptNo;

-- Pagination Queries aka Limit Operators

select top(5) * from Employee;

select count(*) from Employee; 

-- Read Specific value record from Table
-- e.g. Reading Second MAx Salary using SubQuery

select Max(Salary) from Employee 
where Salary<(select Max(Salary) from Employee);

-- Using OffSet to Read data by Skipping Some Rows and then Fetch next rows

select top(3) * from Employee
  Order By EmpName desc; 

  select Empname from employee order by salary offset 1 rows;
 
SELECT EmpNo, EmpName
FROM Employee
ORDER BY EmpNo
OFFSET 3 ROWS FETCH NEXT 6 ROWS ONLY
 
-- join
-- Why?
-- When the data is acattered across tables then to read 
--matched and unmatched data across these related table 
-- better we MUST use Joins
-- Inner Join aka Simple Join (Default), returns only matched records

select EmpNo, EmpName, DeptName, Designation, Salary, Location
From Employee, Department
Where Employee.DeptNo = Department.DeptNo;

-- Left Join
-- All Data from Left table that matched with right table will be read
-- for all unmatched values fpr rihgght table the null values
-- will be returned (Used in Reporting Apps )

select EmpNo, EmpName, DeptName, Designation, Salary, Location
From Department
Left Join Employee
on  Department.DeptNo = Employee.DeptNo;

-- Right Join, Opposite Of Left Join
select EmpNo, EmpName, DeptName, Designation, Salary, Location
From Department
Right Join Employee
on  Department.DeptNo = Employee.DeptNo;


