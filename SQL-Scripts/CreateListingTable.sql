CREATE TABLE [dbo].[Listing](
	[name] [text] NULL,
	[TypeInstrument] [text] NULL,
	[Condition] [text] NULL,
	[Price] [int] NULL,
	[description] [text] NULL,
	[color] [text] NULL,
	[material] [text] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL
)

