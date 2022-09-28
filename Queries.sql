-- create database
Create Database RFCompany;
-- Use the Database so that All TRansactions
-- e.g. Data Definition Language (DDL) e.g. Create, Alter
-- Data Manipulation Language (DML) statements will be 
-- executed under this database context

use RFCompany;

-- Create Table
Create Table Department(
  DeptNo int Primary Key,
  DeptName varchar(100),
  Location varchar(100)
);
-- Alter Columns DeptName and Location by adding 'Not Null' Constraints
Alter Table Department Alter Column DeptName varchar(100) Not Null;
Alter Table Department Alter Column Location varchar(100) Not Null;

-- Alter Table by Modifying the COlumn
Alter Table Department Add Capcity int not null; 

--Alter Table to Rename the Capcity to Capacity
-- using 'sp_rename' to rename the columns
--				Original Name		Name Name
Exec sp_rename 'Department.Capcity', 'Capacity';

-- Lets Insert Data into Department Table
Insert into Department Values(10, 'Information Technology', 'Pune', 400);

Insert into Department Values(20, 'Human Resource', 'Pune', 45);
Insert into Department Values(30, 'Maintenence', 'Pune', 13);
Insert into Department Values(40, 'Projects', 'Pune', 8000);
Insert into Department Values(50, 'Accounts', 'Pune', 800);


Select * from Department;


Create Table Employee(
  EmpNo int Primary Key,
  EmpName varchar(200) Not Null,
  Designation varchar(200) Not Null,
  Salary int Not Null,
  DeptNo int Not Null References Department(DeptNo) -- Foreign Key
);

-- Drop Table
Drop Table Employee;

-- Drop Column
Alter Table Employee Drop Column Designation;

Alter Table Employee Add Designation Varchar(200) Not Null; 

insert into Employee Values (101, 'Mahesh', 'Director', 900000, 10);
insert into Employee Values (102, 'Tejas', 'Director', 900000, 20);
insert into Employee Values (103, 'Ramesh', 'Director', 900000, 30);
insert into Employee Values (104, 'Sharad', 'Director', 900000, 40);
insert into Employee Values (105, 'Sanjay', 'Director', 900000, 50);
insert into Employee Values (106, 'Vijay', 'Manager', 900000, 10);
insert into Employee Values (107, 'Vilas', 'Manager', 900000, 20);
insert into Employee Values (108, 'Abhay', 'Manager', 900000, 30);
insert into Employee Values (109, 'Vivek', 'Manager', 900000, 40);
insert into Employee Values (110, 'Satish', 'Manager', 900000, 50);
insert into Employee Values (111, 'Mukesh', 'Lead', 900000, 10);
insert into Employee Values (112, 'Sandeep', 'Lead', 900000, 20);
insert into Employee Values (113, 'Vinay', 'Lead', 900000, 30);
insert into Employee Values (114, 'Kaustubh', 'Lead', 900000, 40);
insert into Employee Values (115, 'Tushar', 'Lead', 900000, 50);
insert into Employee Values (116, 'Krishna', 'Associate', 900000, 10);
insert into Employee Values (117, 'Arav', 'Associate', 900000, 20);
insert into Employee Values (118, 'Nainesh', 'Associate', 900000, 30);
insert into Employee Values (119, 'Aditya', 'Associate', 900000, 40);
insert into Employee Values (120, 'Sujay', 'Associate', 900000, 50);

Select * from Employee;

