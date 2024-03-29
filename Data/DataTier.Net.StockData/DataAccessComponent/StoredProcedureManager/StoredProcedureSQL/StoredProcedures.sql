Use [StockData]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Insert a new RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Insert >>>'

    End

GO

Create PROCEDURE RawImport_Insert

    -- Add the parameters for the stored procedure here
    @Close nvarchar(255),
    @Date nvarchar(255),
    @High nvarchar(255),
    @Low nvarchar(255),
    @Open nvarchar(255),
    @Per nvarchar(255),
    @Ticker nvarchar(255),
    @Vol nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [RawImport]
    ([Close],[Date],[High],[Low],[Open],[Per],[Ticker],[Vol])

    -- Begin Values List
    Values(@Close, @Date, @High, @Low, @Open, @Per, @Ticker, @Vol)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Update an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Update >>>'

    End

GO

Create PROCEDURE RawImport_Update

    -- Add the parameters for the stored procedure here
    @Close nvarchar(255),
    @Date nvarchar(255),
    @High nvarchar(255),
    @Id int,
    @Low nvarchar(255),
    @Open nvarchar(255),
    @Per nvarchar(255),
    @Ticker nvarchar(255),
    @Vol nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [RawImport]

    -- Update Each field
    Set [Close] = @Close,
    [Date] = @Date,
    [High] = @High,
    [Low] = @Low,
    [Open] = @Open,
    [Per] = @Per,
    [Ticker] = @Ticker,
    [Vol] = @Vol

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Find an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Find >>>'

    End

GO

Create PROCEDURE RawImport_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Close],[Date],[High],[Id],[Low],[Open],[Per],[Ticker],[Vol]

    -- From tableName
    From [RawImport]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Delete an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Delete >>>'

    End

GO

Create PROCEDURE RawImport_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [RawImport]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Returns all RawImport objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_FetchAll >>>'

    End

GO

Create PROCEDURE RawImport_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Close],[Date],[High],[Id],[Low],[Open],[Per],[Ticker],[Vol]

    -- From tableName
    From [RawImport]

END

-- Thank you for using DataTier.Net.

