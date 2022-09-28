use RFCompany;

-- Update Salary of Manager as 700000
update Employee Set Salary=700000 where Designation='Manager'; 
-- Update Salary of Lead as 500000
update Employee Set Salary=500000 where Designation='Lead';
-- Update Salary of Associate as 300000
update Employee Set Salary=300000 where Designation='Associate';

select * from Employee;