/****** Object:  StoredProcedure [dbo].[GetInstrumentByID]    Script Date: 12/14/2023 2:50:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure to get an instrument by ID
ALTER PROCEDURE [dbo].[GetInstrumentByID]
(    
    @ID INT
)    
AS     
BEGIN     
    SELECT * FROM listing WHERE ID = @ID
END

