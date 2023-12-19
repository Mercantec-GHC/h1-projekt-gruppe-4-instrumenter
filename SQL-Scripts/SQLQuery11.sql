-- Procedure to get instruments based on selected values
CREATE PROCEDURE [dbo].[GetInstrumentsByDrums]
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
    WHERE TypeInstrument = 'Drums'
END
