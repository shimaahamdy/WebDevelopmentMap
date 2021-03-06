USE [master]
GO
/****** Object:  Database [EMPLOYEES]    Script Date: 3/6/2022 2:39:41 PM ******/
CREATE DATABASE [EMPLOYEES]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EMPLOYEES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EMPLOYEES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EMPLOYEES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EMPLOYEES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EMPLOYEES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EMPLOYEES] SET ARITHABORT OFF 
GO
ALTER DATABASE [EMPLOYEES] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EMPLOYEES] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [EMPLOYEES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EMPLOYEES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EMPLOYEES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EMPLOYEES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EMPLOYEES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EMPLOYEES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EMPLOYEES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EMPLOYEES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EMPLOYEES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EMPLOYEES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EMPLOYEES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EMPLOYEES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EMPLOYEES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EMPLOYEES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EMPLOYEES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EMPLOYEES] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EMPLOYEES] SET  MULTI_USER 
GO
ALTER DATABASE [EMPLOYEES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EMPLOYEES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EMPLOYEES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EMPLOYEES] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EMPLOYEES] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EMPLOYEES', N'ON'
GO
ALTER DATABASE [EMPLOYEES] SET QUERY_STORE = OFF
GO
USE [EMPLOYEES]
GO
/****** Object:  Table [dbo].[City]    Script Date: 3/6/2022 2:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[cityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
	[cID] [int] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[cityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 3/6/2022 2:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[countryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[countryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Depts]    Script Date: 3/6/2022 2:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depts](
	[DeptID] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[DeptDesc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Depts] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emps]    Script Date: 3/6/2022 2:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emps](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpFname] [nvarchar](50) NOT NULL,
	[EmpLname] [nvarchar](50) NOT NULL,
	[EmpSalary] [float] NULL,
	[EmpHDate] [smalldatetime] NULL,
	[dID] [int] NOT NULL,
	[CtyID] [int] NULL,
 CONSTRAINT [PK_Emps] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (2, N'Cairooo', 1)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (3, N'Alexandria', 3)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (4, N'Ismalia', 1)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (5, N'NY', 2)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (6, N'LA', 2)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (7, N'Manhatten', 3)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (8, N'London', 3)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (9, N'Paris', 4)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (10, N'Minia', 1)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (14, N'Aswan', 1)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (16, N'LosAngelos', 2)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (20, N'newCairoCity..........123', 1)
INSERT [dbo].[City] ([cityID], [CityName], [cID]) VALUES (21, N'Sheihk Zayed', 1)
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([countryID], [CountryName]) VALUES (1, N'Egypt')
INSERT [dbo].[Country] ([countryID], [CountryName]) VALUES (2, N'USA')
INSERT [dbo].[Country] ([countryID], [CountryName]) VALUES (3, N'UK')
INSERT [dbo].[Country] ([countryID], [CountryName]) VALUES (4, N'France')
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[Depts] ON 

INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (1, N'HR', NULL)
INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (2, N'Finance', NULL)
INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (3, N'Accounting', NULL)
INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (4, N'R&D', NULL)
INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (5, N'QA & Testing', NULL)
INSERT [dbo].[Depts] ([DeptID], [DeptName], [DeptDesc]) VALUES (6, N'Development', NULL)
SET IDENTITY_INSERT [dbo].[Depts] OFF
GO
SET IDENTITY_INSERT [dbo].[Emps] ON 

INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (1, N'Mahmouuuud', N'Aly       ', 1000, CAST(N'2000-11-11T00:00:00' AS SmallDateTime), 4, 3)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (2, N'Ahmad ', N'Fahmy     ', 1500, CAST(N'2005-05-05T00:00:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (3, N'Mostafa', N'Ibrahim   ', 2500, CAST(N'2002-06-06T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (4, N'Mohamed', N'Fouad     ', 2000, CAST(N'2002-06-06T00:00:00' AS SmallDateTime), 1, 9)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (6, N'Nahla', N'Fouad', 4000, CAST(N'2005-05-05T00:00:00' AS SmallDateTime), 1, 6)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (9, N'Mohammed', N'A.Fattah', 2000, CAST(N'2005-05-05T00:00:00' AS SmallDateTime), 1, 6)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (11, N'Hany', N'Saleh', 5000, CAST(N'2005-05-05T00:00:00' AS SmallDateTime), 1, 8)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (15, N'Omar', N'Fahmy', 2000, CAST(N'2005-05-05T00:00:00' AS SmallDateTime), 5, 2)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (16, N'Manar', N'Aly', 2000, NULL, 4, 6)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (17, N'Mona', N'Fahmy', 1000, CAST(N'2008-03-17T05:49:00' AS SmallDateTime), 5, 6)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (18, N'Nadia', N'Karam', 1600, CAST(N'2008-03-17T05:54:00' AS SmallDateTime), 4, 4)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (19, N'Amin', N'Rady', 2000, CAST(N'2008-03-17T05:59:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (21, N'g', N'g', 44, CAST(N'2008-03-17T11:24:00' AS SmallDateTime), 3, 4)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (22, N's22222', N's', 55, CAST(N'2008-03-17T11:29:00' AS SmallDateTime), 4, 8)
INSERT [dbo].[Emps] ([EmpID], [EmpFname], [EmpLname], [EmpSalary], [EmpHDate], [dID], [CtyID]) VALUES (24, N'Tim', N'Smith', 4500, CAST(N'2008-04-03T14:33:00' AS SmallDateTime), 2, 7)
SET IDENTITY_INSERT [dbo].[Emps] OFF
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([cID])
REFERENCES [dbo].[Country] ([countryID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Emps] FOREIGN KEY([cID])
REFERENCES [dbo].[Emps] ([EmpID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Emps]
GO
ALTER TABLE [dbo].[Emps]  WITH CHECK ADD  CONSTRAINT [FK_Emps_Depts] FOREIGN KEY([dID])
REFERENCES [dbo].[Depts] ([DeptID])
GO
ALTER TABLE [dbo].[Emps] CHECK CONSTRAINT [FK_Emps_Depts]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 3/6/2022 2:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertEmployee]
@fname nvarchar(50),
@lname nvarchar(50),
@salary float,
@city int,
@HDate datetime,
@dept int

AS
INSERT INTO Emps
(EmpFname, EmpLName, EmpSalary,ctyID,empHdate, Did)
VALUES (@fname, @lname, @salary,@city,@Hdate, @dept);
GO
USE [master]
GO
ALTER DATABASE [EMPLOYEES] SET  READ_WRITE 
GO
