/****** Object:  StoredProcedure [dbo].[UpdateInstrument]    Script Date: 12/14/2023 2:50:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure to update instrument information
ALTER PROCEDURE [dbo].[UpdateInstrument]     
(     
   @ID INT ,   
   @Name NVARCHAR(50),    
   @TypeInstrument NVARCHAR(50),   
   @Condition NVARCHAR(50),   
   @Price DECIMAL(18, 2),
   @Description NVARCHAR(255),
   @Year INT,
   @Color NVARCHAR(50),
   @Material NVARCHAR(50)
)     
AS     
BEGIN     
   UPDATE listing    
   SET 
       Name = @Name,     
       TypeInstrument = @TypeInstrument,     
       Condition = @Condition,   
       Price = @Price,
       Description = @Description,
       Year = @Year,
       Color = @Color,
       Material = @Material     
   WHERE ID = @ID     
END
