/****** Object:  Table [dbo].[listing]    Script Date: 12/15/2023 9:29:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

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
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


