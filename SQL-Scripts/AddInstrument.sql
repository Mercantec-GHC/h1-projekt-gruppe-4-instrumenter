/****** Object:  StoredProcedure [dbo].[AddInstrument]    Script Date: 12/14/2023 2:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure to add a new instrument
ALTER PROCEDURE [dbo].[AddInstrument]    
(   
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
    INSERT INTO listing (Name, TypeInstrument, Condition, Price, Description, Year, Color, Material)    
    VALUES (@Name, @TypeInstrument, @Condition, @Price, @Description, @Year, @Color, @Material)    
END
