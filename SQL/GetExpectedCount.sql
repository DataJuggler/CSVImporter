-- Set The Table Id To Your Table
Declare @TableId int
Set @TableId = 1 -- change to your TableId

-- Variable to hold the ExpectedCount
Declare @ExpectedCount int

-- Print Out The Expected Count
Set @ExpectedCount = (Select Count(*) From DTNField Where PrimaryKey = 0)
Print 'Expected Count: ' + Cast(@ExpectedCount as nvarchar)




