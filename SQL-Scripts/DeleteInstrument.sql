/****** Object:  StoredProcedure [dbo].[DeleteInstrument]    Script Date: 12/14/2023 2:49:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure to delete an instrument by ID
ALTER PROCEDURE [dbo].[DeleteInstrument]    
(     
   @ID INT     
)     
AS      
BEGIN     
   DELETE FROM listing WHERE ID = @ID     
END
