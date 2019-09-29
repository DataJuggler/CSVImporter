Declare @TableId int
Set @TableId = 3 -- change to your TableId    Example: Select * From DTNTable to find your table

Declare @PrimaryKeyFieldOrdinal int
Set @PrimaryKeyFieldOrdinal = (Select FieldOrdinal From DTNField Where PrimaryKey = 1 And TableId = @TableId) 

-- This query build the PropertyName = Value pairs for C# insert statements
Select '                    rawImport.' + FieldName + ' = words[' + Cast((FieldOrdinal - 1) As nvarchar) + '].Text;' from DTNField
Where TableId = @TableId And PrimaryKey = 0 And FieldOrdinal < @PrimaryKeyFieldOrdinal
Union All
Select '                    rawImport.' + FieldName + ' = words[' + Cast((FieldOrdinal - 2) As nvarchar) + '].Text;' from DTNField
Where TableId = @TableId And PrimaryKey = 0 And FieldOrdinal > @PrimaryKeyFieldOrdinal




