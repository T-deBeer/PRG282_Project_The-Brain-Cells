CREATE TABLE [dbo].[CompositeTable]
(
	[Student_Number] INT NOT NULL,
	[Module_Code] VARCHAR(10) NOT NULL ,
	Constraint "FK_tblComposite_tblStudent" Foreign Key 
		(
			"Student_Number"
		) REFERENCES [dbo].[StudentTable] (
			"Student_Number"
		),
	Constraint "FK_tblComposite_tblModule" Foreign Key 
		(
			"Module_Code"
		) REFERENCES [dbo].[ModuleTable] (
			"Module_Code"
		)
)