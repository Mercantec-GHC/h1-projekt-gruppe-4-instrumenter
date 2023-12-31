/****** Object:  StoredProcedure [dbo].[GetAllInstruments]    Script Date: 12/14/2023 2:50:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure to get all instruments
ALTER PROCEDURE [dbo].[GetAllInstruments]   
AS   
BEGIN   
    SELECT
        ID,
        Name,
        TypeInstrument,
        Condition,
        Price,
        Description,
        Year,
        Color,
        Material
    FROM listing
END

-- Syntax for renaming a stored procedure
EXEC sp_rename 'usp_AddInstrument', 'AddInstrument';
