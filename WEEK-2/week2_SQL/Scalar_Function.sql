
CREATE TABLE Department2(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employee2 (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Department2(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);


INSERT INTO Department2(DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');


INSERT INTO Employee2 (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-01');


SELECT * FROM Department2;
SELECT * FROM Employee2;

--Annual Salary = Monthly Salary × 12
CREATE OR ALTER FUNCTION fn_CalculateAnnualSalary
(
    @EmployeeID INT
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10, 2);

    SELECT @AnnualSalary = Salary * 12
    FROM Employee2
    WHERE EmployeeID = @EmployeeID;

    RETURN @AnnualSalary;
END;
GO

SELECT dbo.fn_CalculateAnnualSalary(1) AS AnnualSalary;


SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary AS MonthlySalary,
    dbo.fn_CalculateAnnualSalary(EmployeeID) AS AnnualSalary
FROM Employee2;


