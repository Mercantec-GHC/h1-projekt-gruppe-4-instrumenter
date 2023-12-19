-- Procedure to get instruments based on selected values
CREATE PROCEDURE [dbo].[GetInstrumentsByGuitar]
    @InstrumentType NVARCHAR(MAX)
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
    WHERE TypeInstrument = 'Guitar'
END
