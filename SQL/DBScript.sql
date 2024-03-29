USE [master]
GO
/****** Object:  Database [OrderManagementSystem]    Script Date: 2019-11-15 4:42:02 PM ******/
CREATE DATABASE [OrderManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OrderManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OrderManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OrderManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OrderManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OrderManagementSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrderManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrderManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OrderManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrderManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrderManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OrderManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrderManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OrderManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [OrderManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrderManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrderManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrderManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OrderManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OrderManagementSystem] SET QUERY_STORE = OFF
GO
USE [OrderManagementSystem]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2019-11-15 4:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [nvarchar](5) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[FirstName] [nvarchar](40) NULL,
	[LastName] [nvarchar](40) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](15) NULL,
 CONSTRAINT [PK__Employee__7AD04FF1150DA8A4] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2019-11-15 4:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](25) NULL,
	[UserTypeID] [numeric](4, 0) NULL,
 CONSTRAINT [PK__Users__1788CCACD7A6C254] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userTypes]    Script Date: 2019-11-15 4:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userTypes](
	[UserTypeID] [numeric](4, 0) NOT NULL,
	[UserTypeName] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'0EAK3', N'ONMIY', N'Henry ', N'Brown', N'henry.b@hitech.com', N'5143368954')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'1U4H8', N'P3PY5', N'Nithin', N'Joy', N'nithin.kj@hotmail.com', N'4382269336')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'32J14', N'32124621-2A07-4C3C-B18A-6BA72CD618B8', N'Nithin', N'J', N'nithin.kj@hotmail.com', N'4382269336')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'48SQL', N'BZQ67', N'Peter', N'Wang', N'peter.w@hitech.com', N'5143871456')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'6O478', N'M51HP', N'Jennifer', N'Bouchard', N'jennifer.b@hitech.com', N'4382758468')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'8H2E5', N'3FA70E7E-0FA3-4DFB-B773-A6D6EF26A21C', N'Kim', N'Hoa Nguyen', N'kim.n@hitech.com', N'5142758468')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'96KZV', N'E3EC7385-3D8B-442D-9823-E684D202FD67', N'Albert', N'Abraham', N'albert.a@hitech.com', N'5142758963')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'PKOBT', N'C8147C61-F74D-4D48-B0A0-F7A04F11142C', N'Jithin', N'Joy', N'jithinjoy@live.com', N'9895247009')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'QQ1XQ', N'8FFE1D70-259F-4FFA-B0DA-EB1C4A0ED789', N'Mary', N'Brown', N'mary.b@hitech.com', N'4382247895')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'XHMVO', N'ADB2AA99-B1E3-44ED-B687-9EDA4A657A95', N'Nithin', N'Joy', N'nithin.kj@hotmail.com', N'4382269336')
INSERT [dbo].[Employees] ([EmployeeID], [UserID], [FirstName], [LastName], [Email], [Phone]) VALUES (N'ZN7O6', N'F4C8E463-A4FB-4FDF-8210-883215898F55', N'Thomas', N'Moore', N'thomas.m@hitech.com', N'5143368954')
INSERT [dbo].[Users] ([UserID], [Password], [UserTypeID]) VALUES (N'BZQ67', N'KTAP7XFNU9KTX88', CAST(4 AS Numeric(4, 0)))
INSERT [dbo].[Users] ([UserID], [Password], [UserTypeID]) VALUES (N'M51HP', N'QRXCXGDUG4WZAFN', CAST(5 AS Numeric(4, 0)))
INSERT [dbo].[Users] ([UserID], [Password], [UserTypeID]) VALUES (N'ONMIY', N'YL4LYHP6AMI14ZT', CAST(2 AS Numeric(4, 0)))
INSERT [dbo].[Users] ([UserID], [Password], [UserTypeID]) VALUES (N'P3PY5', N'NRVHC8DVNG1BN9J', CAST(3 AS Numeric(4, 0)))
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(1 AS Numeric(4, 0)), N'Other')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(2 AS Numeric(4, 0)), N'MIS Manager')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(3 AS Numeric(4, 0)), N'Sales Manager')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(4 AS Numeric(4, 0)), N'Inventory Controller')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(5 AS Numeric(4, 0)), N'Order Clerks')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(6 AS Numeric(4, 0)), N'Accountant')
INSERT [dbo].[userTypes] ([UserTypeID], [UserTypeName]) VALUES (CAST(7 AS Numeric(4, 0)), N'Test')
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__1788CCADDCE9A921]    Script Date: 2019-11-15 4:42:03 PM ******/
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [UQ__Employee__1788CCADDCE9A921] UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([UserID])
REFERENCES [dbo].[Employees] ([UserID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[userTypes] ([UserTypeID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
/****** Object:  StoredProcedure [dbo].[GenerateAndSaveUserIDandPassword]    Script Date: 2019-11-15 4:42:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Pourpose: update userid in employees table and insert values into users table and returns the details
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

CREATE PROCEDURE [dbo].[GenerateAndSaveUserIDandPassword]
	@UserType numeric(4),
	@UserID nvarchar(9),
	@EmployeeID nvarchar(5),
	@Password nvarchar(20)
AS

IF @UserType != 0 
BEGIN
	BEGIN TRAN
		UPDATE Employees SET UserID = @UserID WHERE EmployeeID = @EmployeeID;
		INSERT INTO Users VALUES (@UserID, @Password, @UserType);
	COMMIT
END
SELECT u.UserID AS UserID,u.Password AS Password,u.UserTypeID AS UserTypeID,ut.UserTypeName AS UserTypeName from Users u
inner join userTypes ut on 
				u.UserTypeID = ut.UserTypeID
where u.UserID = @UserID and
		u.Password = @Password

;



GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetails]    Script Date: 2019-11-15 4:42:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Pourpose: delete userid in employees table and remove values from users table for the user id
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

CREATE PROCEDURE [dbo].[GetEmployeeDetails]
	
AS

SELECT	e.EmployeeID, 
		e.FirstName,
		e.LastName, 
		e.Email, 
		e.Phone, 
		CASE WHEN len(e.UserID) > 5 THEN 'Not Applicable'
		ELSE ut.UserTypeName
		END AS Role, 
		CASE WHEN len(e.UserID) > 5 THEN 'Not Available'
		     ELSE e.UserID
		END
			 AS UserID
FROM Employees e
LEFT OUTER JOIN Users u ON e.UserID = u.UserID
LEFT OUTER JOIN userTypes ut  ON ut.UserTypeID = u.UserTypeID
ORDER BY
FirstName,
LastName,
EmployeeID



GO
/****** Object:  StoredProcedure [dbo].[RemoveUserIDPassword]    Script Date: 2019-11-15 4:42:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Pourpose: delete userid in employees table and remove values from users table for the user id
Created By: Nithin & Roneet
Date Created: 2019 - 11 - 09  
*/

CREATE PROCEDURE [dbo].[RemoveUserIDPassword]
	@UserID nvarchar(9)
	
AS

DELETE FROM Users WHERE UserID = @UserID;
UPDATE Employees SET UserID = NEWID() WHERE UserID = @UserID;





GO
USE [master]
GO
ALTER DATABASE [OrderManagementSystem] SET  READ_WRITE 
GO
