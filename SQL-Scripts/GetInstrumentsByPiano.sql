-- Procedure to get instruments based on selected values
CREATE PROCEDURE [dbo].[GetInstrumentsByPiano]
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
    WHERE CONVERT(NVARCHAR(MAX), TypeInstrument) = 'Piano'
END
