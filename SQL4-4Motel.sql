USE [MotelManager]
GO
/****** Object:  Table [dbo].[BILL]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDRoom] [int] NULL,
	[IDStaff] [varchar](20) NULL,
	[TotalMoney] [money] NULL,
	[Date] [datetime] NULL,
	[Paid] [bit] NULL,
 CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[ID] [varchar](20) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[DateOfBirth] [datetime] NULL,
	[Address] [nvarchar](100) NULL,
	[NumberPhone] [varchar](20) NULL,
	[Sexual] [nvarchar](10) NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOTELROOM]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOTELROOM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [nvarchar](50) NULL,
	[StateRoom] [bit] NULL,
	[IDRoomRank] [int] NULL,
	[IDRoomRange] [int] NULL,
 CONSTRAINT [PK_MOTELROOM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PARTICULARSERVICE]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARTICULARSERVICE](
	[IDBill] [int] NOT NULL,
	[IDService] [int] NOT NULL,
	[OldIndex] [int] NULL,
	[NewIndex] [int] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_PARTICULARSERVICE] PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC,
	[IDService] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REINTINFOR]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REINTINFOR](
	[IDCustomer] [varchar](20) NOT NULL,
	[IDRoom] [int] NOT NULL,
	[CheckInDate] [datetime] NULL,
	[CheckOutDate] [datetime] NULL,
 CONSTRAINT [PK_REINTINFOR] PRIMARY KEY CLUSTERED 
(
	[IDCustomer] ASC,
	[IDRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLE]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROOMRANGE]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOMRANGE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RangeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ROOMRANGE_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROOMRANK]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOMRANK](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RankName] [nvarchar](50) NULL,
	[Price] [money] NULL,
	[Deposits] [money] NULL,
	[About] [nvarchar](20) NULL,
 CONSTRAINT [PK_ROOMRANK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICE]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_SERVICE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[ID] [varchar](20) NOT NULL,
	[StaffName] [nvarchar](50) NULL,
	[DateOfBirth] [datetime] NULL,
	[Address] [nvarchar](100) NULL,
	[NumberPhone] [varchar](20) NULL,
	[UserName] [varchar](40) NULL,
	[Sexual] [nvarchar](10) NULL,
 CONSTRAINT [PK_STAFF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_STAFF] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[UserName] [varchar](40) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[IDRole] [int] NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_MOTELROOM] FOREIGN KEY([IDRoom])
REFERENCES [dbo].[MOTELROOM] ([ID])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_MOTELROOM]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_STAFF] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[STAFF] ([ID])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_STAFF]
GO
ALTER TABLE [dbo].[MOTELROOM]  WITH CHECK ADD  CONSTRAINT [FK_MOTELROOM_ROOMRANGE] FOREIGN KEY([IDRoomRange])
REFERENCES [dbo].[ROOMRANGE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MOTELROOM] CHECK CONSTRAINT [FK_MOTELROOM_ROOMRANGE]
GO
ALTER TABLE [dbo].[MOTELROOM]  WITH CHECK ADD  CONSTRAINT [FK_MOTELROOM_ROOMRANK] FOREIGN KEY([IDRoomRank])
REFERENCES [dbo].[ROOMRANK] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MOTELROOM] CHECK CONSTRAINT [FK_MOTELROOM_ROOMRANK]
GO
ALTER TABLE [dbo].[PARTICULARSERVICE]  WITH CHECK ADD  CONSTRAINT [FK_PARTICULARSERVICE_BILL] FOREIGN KEY([IDBill])
REFERENCES [dbo].[BILL] ([ID])
GO
ALTER TABLE [dbo].[PARTICULARSERVICE] CHECK CONSTRAINT [FK_PARTICULARSERVICE_BILL]
GO
ALTER TABLE [dbo].[PARTICULARSERVICE]  WITH CHECK ADD  CONSTRAINT [FK_PARTICULARSERVICE_SERVICE] FOREIGN KEY([IDService])
REFERENCES [dbo].[SERVICE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PARTICULARSERVICE] CHECK CONSTRAINT [FK_PARTICULARSERVICE_SERVICE]
GO
ALTER TABLE [dbo].[REINTINFOR]  WITH CHECK ADD  CONSTRAINT [FK_REINTINFOR_CUSTOMER] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[CUSTOMER] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[REINTINFOR] CHECK CONSTRAINT [FK_REINTINFOR_CUSTOMER]
GO
ALTER TABLE [dbo].[REINTINFOR]  WITH CHECK ADD  CONSTRAINT [FK_REINTINFOR_MOTELROOM] FOREIGN KEY([IDRoom])
REFERENCES [dbo].[MOTELROOM] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[REINTINFOR] CHECK CONSTRAINT [FK_REINTINFOR_MOTELROOM]
GO
ALTER TABLE [dbo].[USER]  WITH CHECK ADD  CONSTRAINT [FK_USER_ROLE] FOREIGN KEY([IDRole])
REFERENCES [dbo].[ROLE] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[USER] CHECK CONSTRAINT [FK_USER_ROLE]
GO
ALTER TABLE [dbo].[USER]  WITH CHECK ADD  CONSTRAINT [FK_USER_STAFF] FOREIGN KEY([UserName])
REFERENCES [dbo].[STAFF] ([UserName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[USER] CHECK CONSTRAINT [FK_USER_STAFF]
GO
/****** Object:  StoredProcedure [dbo].[USP_CountCustomer]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountCustomer]
as
begin
	select count(*) from CUSTOMER 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountRange]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountRange]
as
begin
	select count(*) from ROOMRANGE 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountRank]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountRank]
as
begin
	select count(*) from ROOMRANK
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountRentInfo]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountRentInfo]
as
begin
	select count(*) from REINTINFOR 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountRoom]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountRoom]
as
begin
	select count(*) from MOTELROOM
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountService]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountService]
as
begin
	select count(*) from SERVICE
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CountStaff]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CountStaff]
as
begin
	select count(*) from STAFF 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageCustomer]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageCustomer]
@bd int,@kt int
as
begin
	select *
	from CUSTOMER
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageRange]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageRange]
@bd int,@kt int
as
begin
	select *
	from ROOMRANGE
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageRank]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageRank]
@bd int,@kt int
as
begin
	select *
	from ROOMRANK
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageRentInfo]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageRentInfo]
@bd int,@kt int
as
begin
	select *
	from REINTINFOR
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageRoom]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_PageRoom]
@bd int,@kt int
as
begin
	select *
	from MOTELROOM
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageService]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageService]
@bd int, @kt int
as
begin
	select *
	from SERVICE
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PageStaff]    Script Date: 4/4/2021 3:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_PageStaff]
@bd int,@kt int
as
begin
	select *
	from STAFF
	order by (select 1)
	offset @bd rows fetch next @kt rows only
end
GO
