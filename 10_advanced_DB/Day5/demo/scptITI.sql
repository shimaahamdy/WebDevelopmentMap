USE [master]
GO
/****** Object:  Database [ITI]    Script Date: 2021-12-30 3:05:53 PM ******/
CREATE DATABASE [ITI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ITI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ITI.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ITI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ITI_log.ldf' , SIZE = 6912KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ITI] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ITI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ITI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ITI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ITI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ITI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ITI] SET ARITHABORT OFF 
GO
ALTER DATABASE [ITI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ITI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ITI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ITI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ITI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ITI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ITI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ITI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ITI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ITI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ITI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ITI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ITI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ITI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ITI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ITI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ITI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ITI] SET RECOVERY FULL 
GO
ALTER DATABASE [ITI] SET  MULTI_USER 
GO
ALTER DATABASE [ITI] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [ITI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ITI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ITI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ITI] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ITI', N'ON'
GO
ALTER DATABASE [ITI] SET QUERY_STORE = OFF
GO
USE [ITI]
GO
/****** Object:  User [koko]    Script Date: 2021-12-30 3:05:53 PM ******/
CREATE USER [koko] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [iti]    Script Date: 2021-12-30 3:05:53 PM ******/
CREATE USER [iti] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [iti]    Script Date: 2021-12-30 3:05:53 PM ******/
CREATE SCHEMA [iti]
GO
/****** Object:  UserDefinedFunction [dbo].[messagename]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[messagename](@student int)
returns nvarchar(60)
begin
    declare @firstname nvarchar(50)
	declare @lastname nvarchar(50)
	declare @messagen nvarchar(60)
	select @firstname =s.St_Fname from Student s where s.St_Id=@student
	select @lastname =s.St_Lname from Student s where s.St_Id=@student
	if @firstname = NUll and @lastname = NULL
		select @messagen='First name & last name are null'
	else if @firstname = NULL
	    select @messagen='last name is null'
	else if @lastname = NULL
	    select @messagen='first name is null'
		
	else
		select @messagen='First name & last name are not '
return @messagen	
end 
GO
/****** Object:  UserDefinedFunction [dbo].[monthname]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[monthname](@DayDate date)
returns nvarchar(20)
begin
declare @monthname nvarchar(20)
	select @monthname = datename(mm,getdate())
return @monthname	
end 
GO
/****** Object:  UserDefinedFunction [dbo].[nums]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[nums](@x int, @y int) 
returns @numbers table
		(
		 num int
		)
as
begin
     set @y = @y-1
     while @x <@y
		begin
		 set @x=@x+1
		 insert @numbers select @x
		 
		end
    
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[studname]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[studname](@name varchar(50)) 
returns @names table
		(
		 student_id int primary key,
		 student_name nvarchar(50)
		)
as
begin
    if @name='fullname'
		insert @names
		select st_id,isnull(st_fname,'')+' '+isnull(st_lname ,'')
		from student
	
	else if @name='firstname'
		insert  into @names
		select st_id,isnull(st_fname,'')
		from student
   else if @name='lastname'
        insert  into @names
		select st_id,isnull(st_Lname,'')
		from student
	else 
	    insert into @names
		select st_id,NULL
		from Student
    
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[value]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[value](@x int, @y int) 
returns @numbers table
		(
		 num int
		)
as
begin
     while @x <@y
		begin
		 set @x=@x+1
		 insert @numbers select @x
		end
    
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[valuexy]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[valuexy](@x int, @y int) 
returns @numbers table
		(
		 num int
		)
as
begin
     while @x <@y
		begin
		 set @x=@x+1
		 insert @numbers select @x
		end
    
return
end
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[St_Id] [int] NOT NULL,
	[St_Fname] [nvarchar](50) NULL,
	[St_Lname] [nchar](10) NULL,
	[St_Address] [nvarchar](100) NULL,
	[St_Age] [int] NULL,
	[Dept_Id] [int] NULL,
	[St_super] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[St_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Dept_Id] [int] NOT NULL,
	[Dept_Name] [nvarchar](50) NULL,
	[Dept_Desc] [nvarchar](100) NULL,
	[Dept_Location] [nvarchar](50) NULL,
	[Dept_Manager] [int] NULL,
	[Manager_hiredate] [date] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Dept_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[depname]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[depname](@student int)
returns table
as 
return
(
select st_fname + ''+ s.St_Lname as fullname, d.Dept_Name
from student s, Department d
where s.Dept_Id=d.Dept_Id and s.St_Id=@student
)
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[Ins_Id] [int] NOT NULL,
	[Ins_Name] [nvarchar](50) NULL,
	[Ins_Degree] [nvarchar](50) NULL,
	[Salary] [money] NULL,
	[Dept_Id] [int] NULL,
	[bouns] [int] NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[Ins_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[mangerdate]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[mangerdate](@manger int)
returns table
as 
return
(
select d.Dept_Manager,d.Dept_Name,ins.Ins_Name,d.Manager_hiredate
from Instructor ins, Department d
where d.Dept_Manager = ins.Ins_Id and ins.Ins_Id=@manger
)
GO
/****** Object:  Table [dbo].[Course]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Crs_Id] [int] NOT NULL,
	[Crs_Name] [nvarchar](50) NULL,
	[Crs_Duration] [int] NULL,
	[Top_Id] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Crs_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stud_Course]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stud_Course](
	[Crs_Id] [int] NOT NULL,
	[St_Id] [int] NOT NULL,
	[Grade] [int] NULL,
 CONSTRAINT [PK_Stud_Course] PRIMARY KEY CLUSTERED 
(
	[Crs_Id] ASC,
	[St_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[studentcourse]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[studentcourse](fullname,coursename)
as 
	select s.St_Fname+' '+s.St_Lname,c.Crs_Name
	from Student s,Course c,Stud_Course sc
	where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id and sc.Grade>50
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[Top_Id] [int] NOT NULL,
	[Top_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[Top_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ins_Course]    Script Date: 2021-12-30 3:05:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ins_Course](
	[Ins_Id] [int] NOT NULL,
	[Crs_Id] [int] NOT NULL,
	[Evaluation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ins_Course] PRIMARY KEY CLUSTERED 
(
	[Ins_Id] ASC,
	[Crs_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
