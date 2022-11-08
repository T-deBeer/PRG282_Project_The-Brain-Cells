CREATE TABLE [dbo].[StudentTable]
(
	[Student_Number] INT IDENTITY(1,1) NOT NUll,
	[Student_Name]  VARCHAR(20) NOT NULL ,
	[Student_Surname]	VARCHAR(40) NOT NULL,
	[Student_Image] IMAGE NULL	,
	[Student_DOB]	DATE CHECK(Student_DOB>getdate()) NOT NULL,
	[Student_Gender] VARCHAR(10) CHECK([Student_Gender] ='Male' OR [Student_Gender] = 'Female' OR [Student_Gender] = 'Other') NOT NULL,
	[Student_Phone] VARCHAR(10) NOT NULL,
	[Student_Address] VARCHAR (200) NOT NULL,
	CONSTRAINT "PK_StudentID" PRIMARY KEY CLUSTERED
	(
		"Student_Number"
	)
)
