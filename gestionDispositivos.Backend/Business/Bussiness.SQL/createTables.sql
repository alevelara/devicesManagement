IF NOT EXISTS (Select * from [Devices].sys.objects where name = 'gateway')
		BEGIN
			CREATE TABLE [Devices].[dbo].[gateway](
										[id] [int] IDENTITY(1,1) NOT NULL,
										[serial_number] [nvarchar](50) NOT NULL,
										[brand] [nvarchar](100) NULL,
										[model] [nvarchar](100) NULL,
										[ip] [nvarchar](20) NOT NULL,
										[port] [nvarchar](4) NULL,
						CONSTRAINT [PK_gateway] PRIMARY KEY CLUSTERED 
				(
					[id] ASC
				)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
				) ON [PRIMARY];
		END;

	IF NOT EXISTS (Select * from [Devices].sys.objects where name = 'light_meter')
		BEGIN
			CREATE TABLE [Devices].[dbo].[light_meter](
								[id] [int] IDENTITY(1,1) NOT NULL,
								[serial_number] [nvarchar](50) NOT NULL,
								[brand] [nvarchar](100) NULL,
								[model] [nvarchar](100) NULL,
				CONSTRAINT [PK_light_meter] PRIMARY KEY CLUSTERED 
		(
			[id] ASC
		)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
		) ON [PRIMARY];

		END;

	IF NOT EXISTS (Select * from [Devices].sys.objects where name = 'water_meter')
		BEGIN
			CREATE TABLE [Devices].[dbo].[water_meter](
								[id] [int] IDENTITY(1,1) NOT NULL,
								[serial_number] [nvarchar](50) NOT NULL,
								[brand] [nvarchar](100) NULL,
								[model] [nvarchar](100) NULL,
				CONSTRAINT [PK_water_meter] PRIMARY KEY CLUSTERED 
		(
			[id] ASC
		)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
		) ON [PRIMARY]
		
		END;