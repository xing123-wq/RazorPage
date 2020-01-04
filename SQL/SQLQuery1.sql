--新建一个数据库：17bang，能指定/查看该数据库存放位置
--观察“一起帮”的注册和发布求助功能，试着建立表User：包含字段UserName（用户名），Password（密码）
--CREATE DATABASE[17bang]
--CREATE TABLE [dbo].[User](
--[UserName] NVARCHAR(10) NOT NULL,
--[Password] INT NOT NULL
----)
--ALTER TABLE [dbo].[yuanzhan] 		
--ADD Age DECIMAL(3,1)  NULL --添加列
--DROP COLUMN Reward

--INSERT [User] (UserName,[Password],Id,Score) VALUES(N'阿泰','1235',1,98)
--INSERT [User] (UserName,[Password],Id,Score) VALUES(N'阿泰','1235',1,98)
--INSERT [User] (UserName,[Password],Id,Score) VALUES(N'阿泰','1235',1,98)
--INSERT [User] (UserName,[Password],Id,Score) VALUES(N'阿泰','1235',1,98)
--INSERT [User] (UserName,[Password],Id,Score) VALUES(N'阿泰','1235',1,98)
--SELECT * FROM [User] WHERE [Score] IS NULL 
--DELETE [User] WHERE Score IS NULL   --删除score为值NULL的

--INSERT [User] (UserName,[Password],Id) VALUES(N'阿泰','1235',1)
--INSERT [User] (UserName,[Password],Id) VALUES(N'阿泰','1244',2)
--INSERT [User] (UserName,[Password],Id) VALUES(N'阿泰','1324',3)
--INSERT [User] (UserName,[Password],Id) VALUES(N'阿泰','2134',4)
--INSERT [User] (UserName,[Password],Id) VALUES(N'阿泰','1238',5)
--ALTER TABLE [User]
--ADD CONSTRAINT PK_Id PRIMARY KEY(Id) 
--观察“一起帮”的发布求助功能，试着建立表Problem，包含：Id，主键，自增字段Title（标题），不能为空Content（正文），
--不能为空NeedRemoteHelp（需要远程求助），默认为需要，Reward（悬赏），PublishDateTime（发布时间）……请为这些列选择合适的数据类型。
--CREATE TABLE yuanzhan(
--	Id INT PRIMARY KEY,		--Id是主键，不能为NULL不能重复
--	Title INT UNIQUE IDENTITY,     --Title不能重复,自增
--	Content DATETIME NOT NULL,	--Content不能为空,DATETIME时间类型
--	PublishDateTime SMALLINT CHECK(PublishDateTime>0),	--PublishDateTime必须大于0
--	Reward FLOAT,                    --没有约束
--	NeedRemoteHelp BIT DEFAULT(1),         --默认为1
--)
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp)VALUES('1','2019/10/17',23,'98','122')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp)VALUES('2','2019/10/17',24,'98','182')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp)VALUES('3','2019/10/17',25,'96','172')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp)VALUES('4','2019/10/17',26,'97','162')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp)VALUES('5','2019/10/17',27,'99','192')

--在Problem表的基础上：删除Title列，再添加Title列将Content的类型更改为NTEXT或NVARCHAR(MAX)为NeedRemoteHelp添加NOT NULL约束，
--再删除NeedRemoteHelp上NOT NULL的约束添加自定义约束，让Reward不能小于10备份TProblem表，
--再用两种方式删除/恢复TProblem中所有数据删除TProblem表本身（含表结构和行数据）在User表上的基础上：添加Id列，
--让Id成为主键添加约束，让UserName不能重复将所有User的Password改为：'1234'观察一起帮的关键字功能，
--新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5;

--在User表中：查找没有录入密码的用户删除用户名（UserName）中包含“管理员”或者“17bang”
--字样的用户在Problem表中：给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助在Keyword表中：找出所有被使用次数（Used）
--大于10小于50的关键字名称（Name）如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，
--将其更新为1删除所有使用次数为奇数的Keyword注意，上述作业需要自己插入数据进行测试。
--INSERT [User](Username,[password])VALUES(N'管理员',1234)
--INSERT [User](Username,[password])VALUES(N'17bang',1234)
--SELECT * FROM [User] WHERE [Password] IS NULL 
--DELETE [User] WHERE UserName LIKE  N'%管理员%' OR Username LIKE N'%17bang%' 
--UPDATE Problem set Title=N'【推荐】'+Title Where Reward>10
--UPDATE Problem set Title=N'【加急】'+Title WHERE Reward>20 AND CREATED>'2019/10/10'
--DELETE [Problem] WHERE [Title] LIKE N'【%】%'
--SELECT [Name] FROM [Keyword] WHERE User>10 AND User<50
--UPDATE Keyword set used=1 where used<=0 OR used>100 or used IS NULL
--CREATE TABLE [dbo].Keyword(
--[Used] NVARCHAR(10) NOT NULL,
--[Name] INT NOT NULL
--)
--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，
--以便能完成以下操作： 查找出Author为“飞哥”的、Reward最多的3条求助（如果Reward有并列第三的数据，一并显示出来） 
--查找Title中第5个起，字符不为“数据库”的求助 所有求助，先按作者“分组”，
--然后在“分组”中按悬赏从大到小排序查找并统计出每个作者的：求助数量、悬赏总金额和平均值
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp,Authorg)VALUES('6','2019/10/17',27,'3','192',N'飞哥')
--SELECT*FROM Problem WHERE Authorg = N'飞哥'
--SELECT *FROM Problem WHERE  Reward<3
--SELECT *FROM Problem
--UPDATE Problem SET Authorg=N'飞哥'
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp,Authorg)VALUES('7','2019/10/17',27,'1','192',N'飞哥')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp,Authorg)VALUES('8','2019/10/17',27,'2','192',N'飞哥')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp,Authorg)VALUES('9','2019/10/17',27,'1','192',N'飞哥')
--INSERT Problem(Id,Content,PublishDateTime,Reward,NeedRemoteHelp,Authorg)VALUES('10','2019/10/17',27,'3','192',NULL)
--CREATE TAble Keyword(
--Author NVARCHAR(10)  NOT NULL,
--Reward INT NOT NULL,
--Title INT UNIQUE IDENTITY
----)

--ALTER TABLE Keyword 		
----ADD Nunber NVARCHAR(10) NOT NULL
--ADD Title1 NVARCHAR(10)
--DROP COLUMN Title 
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',38,12,N'143数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',39,5,N'123数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',31,2,N'153数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',35,3,N'163数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',33,1,N'183数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',32,32,N'113数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',12,0,N'133数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',40,9,N'153数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',15,6,N'163数据库')
--INSERT Keyword(Author,Reward,Nunber,Title1)VALUES(N'飞哥',18,4,N'124数据库')
--SELECT *FROM Keyword

--SELECT TOP 3 *FROM Keyword WHERE Author=N'飞哥' ORDER BY Reward DESC --查找排序
--SELECT *FROM Keyword WHERE Title1 NOT LIKE'___数据库%'
--SELECT Author,Reward,COUNT(Author)AS() 
--SELECT*FROM Keyword
--GROUP BY Author
--ORDER BY Reward DESC
--SELECT Author ,Reward FROM Keyword
--GROUP BY Author
--ORDER BY Author DESC, Reward DESC 

--SELECT Author ,MAX(Reward) AS RewardMAX FROM Keyword
--GROUP BY Author
--ORDER BY Author DESC

--ALTER TABLE Keyword ADD Author NVARCHAR(128)
--SELECT Author,COUNT(Reward)AS HelpCOUNT,AVG(Reward),SUM(Reward)FROM Keyword
--GROUP BY Author

--SELECT * FROM Problem ORDER BY Reward ASC   --从小到大
--SELECT * FROM Problem ORDER BY Reward DESC  --从大到小  

--DROP DATABASE[17bang]   --删除数据库

--USE master  -- 确保当前数据库没有被使用
--GO          -- 批处理结束标记（可忽略）
--BACKUP DATABASE [yuanzhan] TO DISK = 'D:\\yuanzhan.bak'     -- 将数据库备份到C盘17bang.bak
--RESTORE DATABASE [yuanzhan] FROM DISK = 'D:\\yuanzhan.bak'  -- 根据C盘17bang.bak恢复数据库

--SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint
--FROM sys.indexes
--WHERE object_id = OBJECT_ID('Keyword')

--DROP INDEX Keyword.UQ__Keyword__2CB664DC934CC551

--CREATE UNIQUE CLUSTERED INDEX IX_Keyword_Reward ON Keyword(Reward)   --在keyword上建立一个聚集索引列

--CREATE UNIQUE NONCLUSTERED INDEX IX_Keyword_Age ON Keyword(Nunber)

--建立索引
--CREATE TABLE Teacher(
--	Id INT,
--	[Name] NVARCHAR(25),
--	Age INT,
--	Gender BIT
--)
----CREATE UNIQUE CLUSTERED INDEX IX_Teacher_Id ON Teacher(Id)

--CREATE INDEX IX_Teacher_Age_Gender ON Teacher(Age, Gender)

--DROP INDEX Teacher.IX_Teacher_Id

--CREATE UNIQUE NONCLUSTERED INDEX IX_Teacher_Age ON Teacher(Age)

--CREATE UNIQUE INDEX IX_Teacher_Name ON Teacher([Name])  -- 非聚集唯一索引
--CREATE INDEX IX_Teacher_Gender ON Teacher(Gender)  -- 非聚集非唯一索引（不写UNIQUE即可）

-- 因为要获取整个表数据，所以无论Student是否有聚集索引都会执行全表扫描
--SELECT * FROM yuanzhan
---- 仅当Student上没有聚集索引时使用，因为不能确定表中是否只有一个N'大飞哥' 
--SELECT * FROM yuanzhan WHERE [Name] = N'大飞哥' 

--CREATE TABLE yuanzhan(
--	Id INT PRIMARY KEY,		--Id是主键，不能为NULL不能重复
--	[Name] NVARCHAR(10) NOT NULL,
--	Title INT UNIQUE IDENTITY,     --Title不能重复,自增
--	Content DATETIME NOT NULL,	--Content不能为空,DATETIME时间类型
--	PublishDateTime SMALLINT CHECK(PublishDateTime>0),	--PublishDateTime必须大于0
--	Age FLOAT,                    --没有约束
--	NeedRemoteHelp BIT DEFAULT(1),         --默认为1
--)

--DROP TABLE yuanzhan --删除表
---- Student表在Id上建立了聚集索引，注意SELECT后是*
--SELECT * FROM yuanzhan WHERE Id = 3
---- Student表在Age上建立了非聚集索引，注意SELECT后仅有Age（实际上是不是没有意义？）
--SELECT Age FROM yuanzhan WHERE Age = 23

--CREATE UNIQUE NONCLUSTERED INDEX IX_Teacher_Age ON yuanzhan(Age) --非聚集索引

--SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint
--FROM sys.indexes
--WHERE object_id = OBJECT_ID('yuanzhan')


--DROP INDEX yuanzhan.IX_Teacher_Age --删除索引

--SELECT * FROM Teacher WHERE  Gender= 0

--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(1,N'飞哥',32,1,1)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(2,N'大飞哥',36,0,1)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(3,N'彭志强',23,1,1)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(4,N'阿泰',16,0,0)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(5,N'王新',90,1,1)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(6,N'于维谦',76,1,1)
--INSERT Teacher (Id,[Name],Age,Gender,Adult)VALUES(7,N'ZJQ',32,0,1)

--CREATE TABLE Teacher(
--Id INT PRIMARY KEY NOT NULL,
--[Name] NVARCHAR(10) NOT NULL,
--Age INT NOT NULL,
--Gender INT NOT NULL ,
--Adult INT NOT NULL 
--)

--DECLARE @name NVARCHAR(10)   -- 声明INT类型的变量@name 
--SET @name = N'飞哥'         -- 将N'feige'赋值给变量@name
--PRINT @name                  -- 输出@name的内容

--DECLARE @age  INT=17
--IF @age>18 PRINT 'Adult'
--ELSE PRINT 'Teenager'

--DECLARE @n INT = 1
--WHILE(@n<10)   --只要@n小于5，就执行下面BEGIN和END之间（循环体）的语句
--BEGIN
--	SET @n+=1 --没循环一次，@n就加1，直到@n=5时，就会结束循环
--	PRINT @n  
--END

--CREATE FUNCTION YzAdd(@a INT, @b INT=10)    -- 创建函数YzAdd,该函数有两个INT类型的参数@a和@b
--RETURNS INT                              -- 函数返回的类型也是INT
--AS                                       -- 可省略
--BEGIN                                    -- BEGIN和END包裹的部分就是“函数体”
--	RETURN @a + @b                   -- 将@a和@b相加的结果返回
--END
--PRINT dbo.YzAdd(12,DEFAULT)

--CREATE FUNCTION YzInlineTable(@number INT)
--RETURNS TABLE                               -- 直接使用TABLE关键字
--RETURN SELECT TOP (@number) * FROM yuanzhan  -- 不能有BEGIN...END

--SELECT * FROM YzInlineTable(1)

--DROP Function dbo.YzAdd --删除函数
--ALTER TABLE yuanzhan
----ADD Adult BIT
--DROP COLUMN Adult

--DECLARE	@NUM INT=1 ,@SPACE INT=3
--WHILE @NUM<8
--BEGIN
--PRINT SPACE(@SPACE)+REPLICATE(@NUM,@NUM)
--SET @NUM+=2
--SET @SPACE-=1
--END



--DECLARE @n INT = 1 ,@Q INT=3
--WHILE @n<8   --只要@n小于5，就执行下面BEGIN和END之间（循环体）的语句
--BEGIN
--	PRINT SPACE (@Q)+REPLICATE(@n,@n)
--	SET @n+=2 --没循环一次，@n就加1，直到@n=5时，就会结束循环
--    SET @Q-=1
--END

--CREATE FUNCTION font(@number INT)
--RETURNS TABLE                               -- 直接使用TABLE关键字
--RETURN SELECT TOP (@number) * FROM Keyword

--SELECT * FROM font(1)   
--SELECT * FROM Keyword

--CREATE FUNCTION aitai(@id INT, @name NVARCHAR(20))
--RETURNS @t TABLE(Id INT, [Name] NVARCHAR(20))  
---- 1、要有一个标量
---- 2、要有返回的“表”的定义
--AS
--BEGIN
--	INSERT @t VALUES(@id, @name)   --通过INSERT语句给返回值标量赋值
--	RETURN                         --只需要使用一个RETURN关键字即可 
--END
--SELECT * FROM aitai(12,N'阿泰12')    --表函数要用 select*from进行调用，调用表函数。

--PRINT LOWER('SAIFGSFSJA')      



--PRINT  CONVERT(INT, 27.83) - 20
--PRINT  CAST(27.83 AS INT) - 20
--PRINT 23.323-20
--DECLARE @@Lingth NVARCHAR(100)
--SET @@Lingth=N'华府的身份后发哈随风该说法哦好尬覅苏'
----PRINT LEN (@@Lingth)  --取字符串的长度
--PRINT LTRIM(@@Lingth)   --去掉前面的空格
--PRINT SUBSTRING(@@Lingth,3,7)  --从左向右截取value的n个字符

--定义一个函数GENDER(INT a, INT b)，可以取a和b之间的更大的一个值
--CREATE FUNCTION GENDER(@a INT,@b INT)
--RETURNS INT
--BEGIN
-- DECLARE @RESULT INT
-- IF @a>@b
-- SET @RESULT=@a
-- ELSE
-- SET @RESULT=@b
-- RETURN @RESULT
--END
--PRINT dbo.GENDER(5,3)

--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助
-- CREATE FUNCTION GetLatestPublish(@n INT)
-- RETURNS TABLE 
-- RETURN SELECT TOP (@n) * FROM Teacher	ORDER BY [Age] DESC
 --创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。
 --CREATE FUNCTION GetByReward(@n INT, @ass BIT)
 --RETURNS @t TABLE ([NAME] NVARCHAR(10))
 --AS
 --BEGIN
	--IF @ass=1
	--	INSERT @t SELECT TOP (@n) * FROM  Problem ORDER BY Reward  ASC
	--ELSE
	--	INSERT @t SELECT TOP (@n) * FROM  Problem ORDER BY Reward DESC
 --END

-- CREATE TABLE Problem(
-- Id INT NOT NULL PRIMARY KEY  IDENTITY,
-- [Name] NVARCHAR(10) NOT NULL UNIQUE,
-- Reward INT 
-- )

--INSERT Problem VALUES (N'阿泰',12)
--INSERT Problem VALUES (N'飞哥',2)
--INSERT Problem VALUES (N'大飞哥',1) 
--INSERT Problem VALUES (N'谦总',30)

-- --SELECT * FROM Problem
-- DROP TABLE Problem --删除表单

--SELECT * FROM Problem WHERE DATEPART (OW,CreateTine)=7 OR 
--DATEPART (OW,CreateTine)=1
--SELECT Auter, ROUND (AVG(Reward*1.00,7,2))  AS[AVG] FROM Problem
--GROUP BY Autor
PRINT CAST (ROUND (7*1.0/2,2)AS DECIMAL(10,1))
DELETE FROM Student WHERE Age>30
SELECT *FROM Student



SELECT Id, Reward, 
Reward-(SELECT AVG(Reward) FROM Problem) AS Gap 
FROM Problem

SELECT Id, [Name], Score,
CASE                                        -- CASE的启动
	WHEN Score>=80 THEN 'Excellent'        -- 如果Score>=80，该列结果为'Excellent'
	WHEN Score>=60 THEN 'Pass'             -- 注意排序！
	ELSE 'Failed'                          -- 之前的条件均不能满足
END  AS Tscore                                       -- CASE的结束
FROM Student

SELECT ROW_NUMBER()      -- 排名函数
OVER(PARTITION BY Age    -- 按Age进行分组（区，一个窗口）
     ORDER BY Score DESC)     -- 组内按Score排序
AS GID,    
Age, [Name], Score       -- 列名
FROM Student

ALTER TABLE Student               -- 修改表
ADD CONSTRAINT FK_Teacher_Id      -- 添加约束，指定约束名称，外键建议以FK开头，后跟表和列名
FOREIGN KEY (TeacherId)           -- 约束类型：外键，且外键列为TeacherId
REFERENCES Teacher(Id)            -- 外键表为Teacher，作为外键使用的列为Teacher上的Id



DELETE Student WHERE Id>7 

SELECT * FROM Student
--SELECT *FROM Teacher

SELECT [NAME],
MAX(CASE Subject WHEN 'C#' THEN Score ELSE 0 END) C#,
MAX(CASE Subject WHEN 'SQL' THEN Score ELSE 0 END) [SQL],
MAX(CASE Subject WHEN 'Javascript' THEN Score ELSE 0 END) Javascript
FROM TSCORE
GROUP BY [Name]

SELECT * FROM TSCORE



SELECT
MAX(Score) OVER(PARTITION BY Age       -- 使用了聚合函数MAX()
ORDER BY Score                         -- 可以省略
) AS Best,
Age, [Name], Score  ,                  -- GROUP BY 就无法显示[Name], Score
MAX(Score) OVER(PARTITION BY Age)-Score AS TOS   -- 获取和同年龄段最好成绩的差距（不能使用别名）
FROM Student

INSERT Student VALUES(N'阿泰',16,95,'2019/10/27',8)

DELETE Student WHERE Id=15

SELECT ROW_NUMBER()      -- 排名函数
OVER(PARTITION BY Age    -- 按Age进行分组（区，一个窗口）
     ORDER BY Score)     -- 组内按Score排序
AS GID,    
Age, [Name], Score       -- 列名
FROM Student

SELECT * FROM TSCORE

CREATE TABLE Problem(
	Id INT PRIMARY KEY IDENTITY,		--Id是主键，不能为NULL不能重复
	[Name] NVARCHAR(10),     --Title不能重复,自增
	Content DATETIME,	--Content不能为空,DATETIME时间类型
	Score SMALLINT CHECK(Score>0) , --次数
	Reward FLOAT,                    --没有约束
)

INSERT Problem VALUES (N'阿泰','2019/10/29',34,30)
INSERT Problem VALUES (N'ZJQ','2019/1/9',3,40)
INSERT Problem VALUES (N'YWQ','2019/9/29',33,50)
INSERT Problem VALUES (N'PZQ','2019/3/19',60,60)
INSERT Problem VALUES (N'WX','2019/8/20',90,58)
INSERT Problem VALUES (N'YJW','2019/12/9',80,80)
INSERT Problem VALUES (N'CBW','2019/10/1',65,98)
INSERT Problem VALUES (N'FG','2019/10/23',78,75)

SELECT * FROM Problem

SELECT Id,[Name],Reward AS Author
INTO NewProblem 
FROM Problem
SELECT * FROM NewProblem

SELECT MAX(Score)
OVER(PARTITION BY Age)AS BERS,
Age,[Name],Score
FROM Student

SELECT *FROM Student

SELECT MAX(Score),Age
FROM Student
GROUP BY Age

SELECT * FROM Student
SELECT * FROM Teacher

ALTER TABLE Student               -- 修改表
ADD CONSTRAINT FK_Teacher_Id      -- 添加约束，指定约束名称，外键建议以FK开头，后跟表和列名
FOREIGN KEY (TeacherId)           -- 约束类型：外键，且外键列为TeacherId
REFERENCES Teacher(Id)            -- 外键表为Teacher，作为外键使用的列为Teacher上的Id


SELECT Id, Reward, 
Reward-(SELECT AVG(Reward) FROM TProblem) AS Gap 
FROM TProblem
--AVG 求平均值

SELECT * FROM TProblem 

SELECT Id,[Name],Age FROM Teacher
WHERE Id IN(SELECT TeacherId FROM Student)

DELETE Student 
WHERE Id NOT IN (                                -- 使用NOT IN进行集合操作
SELECT MAX(Id) FROM Student GROUP BY Score)      -- 其结果是一个集合

SELECT FromProvince FROM City WHERE Id
=(SELECT FromCityId FROM Student
WHERE [Name]=N'***')

SELECT * FROM TSCORE oe                  -- 给外部表一个别名oe（必须）
WHERE Score = (
    SELECT MAX(Score) FROM TSCORE ie     -- 给内部表一个别名ie（必须）
    WHERE oe.[Name] = ie.[Name]    -- 在内部查询中使用了外部的UserName
    -- 不再需要GROUP
)

SELECT * FROM(
    SELECT Id, 
    Id*2 AS DoubleId      -- 这是一个计算列，注意一定要加上一个别名
    FROM Student) ns      -- 这个ns的别名也是一样必须要有的，即使没有后面的WHERE子句
WHERE ns.DoubleId > 10    -- WHERE 子句使用子查询表别名ns

CREATE UNIQUE CLUSTERED INDEX IX_Student_Id ON Student(Id) --聚集索引
CREATE UNIQUE NONCLUSTERED INDEX IX_Student_Score ON Student (Score)   --非聚集索引

SELECT * FROM Student

SELECT * FROM Student s
JOIN City c
ON s.FromCityId=c.Id
--WHERE s.Id>5
ORDER BY c.FromCity

UPDATE Student SET  Score += 10
WHERE FromCityId IN (
SELECT Id FROM City WHERE FromProvince = N'重庆')  --集合
--把fromprovince是重庆的，人的成绩加10

UPDATE Student SET  Score -= 10
FROM Student S JOIN City C
ON S.FromCityId=C.Id
WHERE C.FromProvince=N'重庆'

DELETE Student 
WHERE Id NOT IN (                                -- 使用NOT IN进行集合操作
SELECT MAX(Id) FROM Student GROUP BY Score)   

SELECT * FROM Student WHERE Score IN(89,93,95)

SELECT * FROM Student oe                  -- 给外部表一个别名oe（必须）
WHERE Score = (
    SELECT MAX(Score) FROM Student ie     -- 给内部表一个别名ie（必须）
    WHERE oe.[Name] = ie.[Name]    -- 在内部查询中使用了外部的Name
    -- 不再需要GROUP
)

SELECT * FROM Student


SELECT * FROM Student S
FULL JOIN City C
ON S.FromCityId=C.Id
WHERE S.FromCityId IS NULL AND C.Id IS NULL

SELECT * FROM Student S
JOIN Teacher T
ON S.TeacherId=T.Id

SELECT TOP 3 Score FROM Student-- 查询最上面的3行
ORDER BY Score DESC
SELECT DISTINCT TOP 3  Score FROM Student
SELECT * FROM Student
ORDER BY Score DESC, Age ASC

SELECT Age,COUNT(*) AS[COUNT] 
FROM Student
GROUP BY Age

SELECT  Age,MAX(Score) AS TScore FROM Student
GROUP BY Age
HAVING MAX(Score)>80

SELECT * FROM Student


SELECT * FROM Student s
JOIN City c
ON s.FromCityId=c.Id

SELECT [Name] FROM Student
UNION
SELECT [Author] FROM Problem --纵向连接
GROUP BY [Author]

	SELECT  Age,COUNT(Score) AS Cscore,
	MAX(Score) AS TScore FROM Student s  
	--- 只能出现GROUP BY 后面的列名，
	----要出现其他的所有字段都要加聚合函数.
	 JOIN City c
	ON s.FromCityId=c.Id
	GROUP BY Age  ---GROUP BY 后面的列名


SELECT s.Age,COUNT(*) AS Cscore,MAX(Score) AS TScore FROM Student s
JOIN City c
ON s.FromCityId=c.Id
GROUP BY Age
HAVING MAX(Score)<80

SELECT * INTO Exam FROM Student
WHERE Id>5

SELECT * FROM V_Student
SELECT * FROM Student
SELECT * FROM Problem
GO

CREATE VIEW V_Problem    -- V_Student是新创建View的名称
AS
SELECT Id, [Name], 
YEAR(Enroll) YearEnroll,   -- 新增的计算列
Month(Enroll) MonthEnroll, -- 必须指定列名
Day(Enroll) DayEnroll,     -- 列名不能重复
Age, Score, IsFemale
FROM Problem
GROUP BY  Score
--WHERE Id>5
-- 还可以添加其他的WHERE/GROUP/HAVING等子句
GO

SELECT * FROM Student s
JOIN City c
ON s.FromCityId=c.Id
WHERE c.FromProvince=N'山东' 

SELECT * FROM dbo.spt_values
SELECT * FROM V_Student
-- 建一个临时表
CREATE TABLE #tmp_Student(
    tId INT IDENTITY,
    sId INT)

-- 插入数据，生成自增rId
INSERT #tmp_Student(sId)
SELECT Id FROM Student ORDER BY Score

-- JOIN获取Student完整数据
SELECT * FROM #tmp_Student 
JOIN Student ON #tmp_Student.sId = Student.Id
WHERE #tmp_Student .tId BETWEEN 4 AND 6  ---BETWEEN 4 AND 6：在4和6之间


SELECT * INTO #tmp_KeyWorld FROM Student
WHERE Id>5

SELECT * FROM Student s
LEFT JOIN City c
ON s.FromCityId=c.Id
WHERE s.Score>80

SELECT * FROM Student s
LEFT JOIN City c
ON s.FromCityId=c.Id
AND s.Score>80

ALTER TABLE BangMoney
ADD CONSTRAINT CK_BangMoney_Balance CHECK(Balance>=0)
---添加约束Balance必须大于等于0

BEGIN TRY
    BEGIN TRANSACTION
        UPDATE BangMoney SET 
		Balance += 100 WHERE [Name] = N'幸龙泰';
        UPDATE BangMoney SET
		Balance -= 100 WHERE [Name] = N'陈元';
    COMMIT TRANSACTION      -- 没有异常就会提交事务
END TRY
BEGIN CATCH
    ROLLBACK                -- 出现异常就会回滚事务
END CATCH

SELECT * FROM BangMoney