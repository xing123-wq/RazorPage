--CREATE TABLE YUANZHAN(
--ID INT NOT NULL,
--[NAME] NVARCHAR(20) NOT NULL
--)
--ALTER TABLE YUANZHAN
--ADD CONSTRAINT  PK_ID1 PRIMARY KEY(ID)
--INSERT YUANZHAN VALUES(1,N'飞哥')
--INSERT YUANZHAN VALUES(2,N'曾俊清')
--SELECT *FROM YUANZHAN
--DROP TABLE YUANZHAN

--CREATE TABLE Student (
--ID INT ,
--[NAME] NVARCHAR(10),
--AGE INT,
--STARTIME DATETIME,
--)
--INSERT Student VALUES(1,N'曾俊清',22,'2019/9/8')
--INSERT Student VALUES(2,N'阿泰',16,'2019/9/12')
--INSERT Student VALUES(3,N'陈百万',24,'2019/9/18')
--INSERT Student VALUES(4,N'王新',23,'2019/9/15')
--INSERT Student VALUES(5,N'于维谦',22,'2019/9/1')
--DROP TABLE Student
--SELECT *FROM Student
--TRUNCATE TABLE Student
--UPDATE Student SET AGE=20 WHERE ID=1

--在User表中：
--查找没有录入密码的用户
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户

--CREATE TABLE [User](
--Id INT ,
--UserName NVARCHAR ,
--[PassWord] INT
--)
--ALTER TABLE [User]
--ALTER COLUMN [UserName] NVARCHAR(10) 
--INSERT [User] VALUES(1,N'管理员飞哥','12345')
--INSERT [User] VALUES(2,N'17bang','23456')
--INSERT [User] VALUES(3,N'管理员','12345')
--INSERT [User](Id,UserName) VALUES(4,N'飞哥')
--INSERT [User] VALUES(4,N'17bang飞哥','23456')
--INSERT [User] VALUES(5,N'飞哥17bang','23456')
--INSERT [User] VALUES(6,N'飞17bang哥','23456')
--INSERT [User] VALUES(7,N'飞哥管理员','12345')
--INSERT [User] VALUES(8,N'飞管理员哥','12345')
--SELECT  * FROM [User]
--SELECT/DELETE * FROM [User] WHERE [UserName] LIKE N'%17bang%' 
--SELECT/DELETE * FROM [User] WHERE [UserName] LIKE N'%管理员%'
--SELECT/DELETE * FROM [User] WHERE [PassWord] IS NULL
--DROP TABLE [User]

--在Problem表中：
--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助

--CREATE TABLE [Problem](
--Reward INT,
--Created DATETIME,
--Title NVARCHAR(20)
--)
--ALTER TABLE [Problem] 
--INSERT [Problem] VALUES (12,'2019/10/14',N'C#')
--INSERT [Problem] VALUES (8,'2019/10/10',N'JS')
--INSERT [Problem] VALUES (18,'2019/10/8',N'CSS')
--INSERT [Problem] VALUES (28,'2019/10/15',N'HTML')
--SELECT * FROM [Problem]
--UPDATE [Problem] SET Title=N'【推荐】'+Title WHERE Reward>10
--UPDATE [Problem] SET Title=N'【加急】'+Title WHERE Reward>20 AND Created>'2019/10/10'
--DELETE [Problem] WHERE Title LIKE N'【%】%'


--在Keyword表中：
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
--删除所有使用次数为奇数的Keyword

--CREATE TABLE [Keyword](
--Used INT)
--ALTER TABLE [Keyword]
--ADD [Name] NVARCHAR(10) 
--SELECT * FROM [Keyword]
--INSERT [Keyword] VALUES (5,N'飞哥')
--INSERT [Keyword] VALUES (0,N'阿泰')
--INSERT [Keyword](Name) VALUES (N'王新')
--INSERT [Keyword] VALUES (15,N'陈百万')
--INSERT [Keyword] VALUES (55,N'于维谦')
--INSERT [Keyword] VALUES (105,N'曾俊清')
--INSERT [Keyword] VALUES (20,N'杨进文')
--SELECT *FROM [Keyword] WHERE [Used] <50 AND [Used] >10 
--SELECT *FROM [Keyword] WHERE [Used] BETWEEN 10 AND 50
--UPDATE [Keyword] SET [Used]=1 WHERE [Used]<=0 OR [Used] IS NULL OR [Used]>100
--DELETE [Keyword] WHERE [Used]%2=1
--DROP TABLE Keyword

--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
--1.查找出Author为“飞哥”的、Reward最多的3条求助（如果Reward有并列第三的数据，一并显示出来）
--2.查找Title中第5个起，字符不为“数据库”的求助
--3.所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
--4.查找并统计出每个作者的：求助数量、悬赏总金额和平均值
--SELECT *FROM Problem	
--TRUNCATE TABLE Problem
--ALTER TABLE Problem
--ADD ID INT NOT NULL
--ADD Num INT
--ADD Author NVARCHAR(10)
--INSERT Problem VALUES (10,'2019/10/10',N'数据库123',1,N'飞哥',1)
--INSERT Problem VALUES (15,'2019/10/11',N'123数据库',2,N'飞哥',2)
--INSERT Problem VALUES (20,'2019/10/12',N'12345数据库',2,N'飞哥',3)
--INSERT Problem VALUES (30,'2019/10/13',N'123数据库45',3,N'飞哥',4)
--INSERT Problem VALUES (10,'2019/10/14',N'1数2据3库4',1,N'飞哥',5)
--INSERT Problem VALUES (10,'2019/10/15',N'1234数据库',3,N'阿泰',6)
--INSERT Problem VALUES (30,'2019/10/16',N'数据123库',1,N'阿泰',7)
--INSERT Problem VALUES (15,'2019/10/17',N'1234数据库',2,N'飞哥',8)
--SELECT * FROM Problem WHERE Author=N'飞哥' 
--SELECT TOP 3  WITH TIES * FROM Problem WHERE Author = N'飞哥'  ORDER BY  Reward DESC
--SELECT *FROM Problem WHERE Title NOT LIKE N'____%数据库%'

--SELECT Author,Reward  FROM Problem 
--ORDER BY Author DESC,Reward DESC

--SELECT Author,SUM(Num) AS SNum FROM Problem GROUP BY Author
--SELECT Author,SUM(Reward) AS SReward FROM Problem GROUP BY Author
--SELECT Author,AVG(Reward)AS AReward FROM Problem GROUP BY Author
--SELECT Author,AVG(Num) AS ANum FROM Problem GROUP BY Author


--新建表TMessage(Id, FromUser, ToUser, UrgentLevel, Kind, HasRead, IsDelete, Content)，
--使用该表和SQL语句，证明：
--唯一约束依赖于唯一索引
--主键上可以是非聚集索引
--SQL Server不会为外键自动添加索引
--SELECT *FROM TMessage
--TRUNCATE TABLE TMessage
--CREATE TABLE TMessage(
--Id INT NOT NULL,
--FromUser NVARCHAR(20) NULL,
--ToUser NVARCHAR(20) NULL,
--Kind NVARCHAR(20) NULL,
--HasRead BIT NULL,
--IsDelete BIT NULL,
--Content NVARCHAR(20) NULL,
--UrgentLevel INT NOT NULL
--)
--INSERT TMessage VALUES(1,N'阿泰',N'飞哥',N'C#',1,0,N'C#第一',1)
--INSERT TMessage VALUES(2,N'阿泰',N'陈百万',N'JS',1,1,N'for循环',2)
--INSERT TMessage VALUES(3,N'曾俊清',N'飞哥',N'CSS',0,0,N'背景颜色',3)
--INSERT TMessage VALUES(4,N'于维谦',N'飞哥',N'HTML',0,0,N'p标签',4)
--INSERT TMessage VALUES(5,N'曾俊清',N'陈百万',N'CSS',1,1,N'border边框',5)
--INSERT TMessage VALUES(6,N'陈百万',N'飞哥',N'HTML',1,0,N'a标签',6)
--INSERT TMessage VALUES(7,N'王新',N'飞哥',N'C#',1,0,N'if语句',7)
--INSERT TMessage VALUES(8,N'王新',N'曾俊清',N'C#',0,0,N'while语句',8)
--INSERT TMessage VALUES(9,N'阿泰',N'曾俊清',N'JS',1,1,N'this用法',9)
--SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint
--FROM sys.indexes
--WHERE object_id = OBJECT_ID('TMessage')

--ALTER TABLE TMessage
--ADD CONSTRAINT UQ_UrgentLevel UNIQUE(UrgentLevel)
--DROP CONSTRAINT UQ_UrgentLevel
--CREATE INDEX IX_UL ON TMessage(UrgentLevel)
--DROP INDEX TMessage.IX_UL

--CREATE CLUSTERED INDEX IX_UL ON TMessage(UrgentLevel)
--ALTER TABLE TMessage
--ADD CONSTRAINT PK_ID PRIMARY KEY(Id)

--ALTER TABLE TMessage
--ADD YID INT 
--ADD CONSTRAINT FK_TMessage_YUANZHAN FOREIGN KEY(YID) REFERENCES YUANZHAN(ID)



--打印如下所示的等腰三角形：
--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
--创建一个单行表值函数GetLatestEnroll(INT n)，返回最近入学的n为同学
--创建一个多行表值函数GetByAge(INT n, BIT asc)，
--如果asc为1，返回年龄最小的n位同学；否则，返回年龄最大的n位同学。
--在表TProblem中：
--  找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--  找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--DECLARE @NUM INT =1 ,@A INT = 3
--WHILE @NUM<8 AND @A>-1 
--BEGIN
--PRINT 
--SPACE(@A)+REPLICATE(@NUM, @NUM)
--SET @NUM += 2
--SET @A -=1
--END

--CREATE FUNCTION GetBigger(@A INT,@B INT)
--RETURNS INT
--AS
--BEGIN
--DECLARE @Result INT
--IF (@A>@B)
--    SET @Result = @A
--ELSE
--    SET @Result = @B
--RETURN @Result
--END
--	PRINT dbo.GetBigger(1,3)

--CREATE FUNCTION GetLatestEnroll(@n INT )
--RETURNS TABLE 
--RETURN SELECT TOP (@n) *FROM Student ORDER BY STARTIME DESC
--SELECT *FROM GetLatestEnroll(2)

--CREATE FUNCTION GetByAge(@N INT , @ASC BIT)
--RETURNS @AGETABLE TABLE(ID INT , [NAME] NVARCHAR(10), AGE INT ,STARTIME DATETIME)
--AS
--BEGIN
--IF @ASC =1
--INSERT @AGETABLE SELECT TOP (@N)*FROM Student ORDER BY AGE
--ELSE 
--INSERT @AGETABLE SELECT TOP (@N)*FROM Student ORDER BY AGE DESC
--RETURN
--END
--DROP FUNCTION GetByAge
--SELECT *FROM GetByAge(2,0)

--SELECT * FROM Problem
--SELECT * FROM Problem WHERE DATEPART(WEEKDAY,Created)=7 OR DATEPART(WEEKDAY,Created)=1
--SELECT CONVERT(decimal(10,2),ROUND(AVG(Reward*1.0),2)) AS SReward  FROM Problem GROUP BY Author
--UPDATE Problem SET Title = N'Test-数据库123' WHERE ID=1
--UPDATE Problem SET Title = N'test数据库123' WHERE ID=3
--UPDATE Problem SET Title = N'[test]数据库123' WHERE ID=5
--SELECT * FROM Problem WHERE Title LIKE 'test%' OR Title LIKE '#[test#]%' ESCAPE '#' OR Title LIKE 'Test-%'
--UPDATE Problem SET Title =N'TEST' + SUBSTRING(CAST(Title AS nvarchar),5,LEN(Title)) WHERE Title LIKE 'test%' 
--UPDATE Problem SET Title =N'[TEST]' + SUBSTRING(CAST(Title AS nvarchar),7,LEN(Title)) WHERE  Title LIKE '#[test#]%' ESCAPE '#'


--用户资料，新建用户资料（Profile）表，和Register形成1:1关联（有无约束？）。用SQL语句演示：
--新建一个填写了用户资料的注册用户
--通过Id查找获得某注册用户及其用户资料
--删除某个Id的注册用户
--CREATE TABLE [Profile](
--ID INT IDENTITY NOT NULL,
--[NAME] NVARCHAR(10) NOT NULL,
--CONSTRAINT PK_Profile_ID PRIMARY KEY(ID)
--)
--CREATE TABLE Register (
--ID INT  NOT NULL,
--AGE INT NOT NULL,
--[WEIGHT] INT NULL,
--HEIGHT INT NULL,
--CONSTRAINT PK_Register_ID PRIMARY KEY(ID)
--)
SELECT * FROM [Profile]
SELECT * FROM Register
--DROP TABLE [Profile]
--DROP  TABLE Register
--INSERT [Profile] VALUES(N'飞哥')
--DECLARE @PID INT =@@IDENTITY
--INSERT Register VALUES(@PID, 28,60,170)
--INSERT [Profile] VALUES(N'阿泰')
--DECLARE @PID INT =@@IDENTITY
--INSERT Register VALUES(@PID,16,55,175)
--INSERT [Profile] VALUES(N'百万')
--DECLARE @PID INT =@@IDENTITY
--INSERT Register VALUES(@PID,24,65,180)
--INSERT [Profile] VALUES(N'大飞哥')
--DECLARE @PID INT =@@IDENTITY
--INSERT Register VALUES(@PID,23,50,165)
--DELETE FROM [Profile] WHERE ID=3
--DELETE FROM Register WHERE ID=3

--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字
--SELECT * FROM Problem
--SELECT * FROM Keyword
--SELECT * FROM KeywordToProblem
--SELECT * FROM KeywordToStudent WHERE StudentID=1
--SELECT * FROM KeywordToStudent WHERE KeywordID=2
--DELETE  FROM Student WHERE ID=3
--DELETE FROM KeywordToStudent WHERE StudentID =3
--DELETE FROM Keyword WHERE ID = 4
--DELETE FROM KeywordToStudent WHERE KeywordID=4
--TRUNCATE TABLE Keyword
--CREATE TABLE Keyword(
--ID INT NOT NULL,
--COURSE NVARCHAR(10) NOT NULL
--)
--INSERT Keyword VALUES (1,N'C#')
--INSERT Keyword VALUES (2,N'CSS')
--INSERT Keyword VALUES (3,N'HTML')
--INSERT Keyword VALUES (4,N'JS')
--ALTER TABLE Keyword
--ADD CONSTRAINT PK_Keyword_ID PRIMARY KEY(ID)
--CREATE TABLE KeywordToProblem(
--ProblemID INT NOT NULL,
--KeywordID INT NOT NULL
--)
--ALTER TABLE KeywordToProblem
--ADD CONSTRAINT FK_KeywordToProblem_ProblemID
--FOREIGN KEY(ProblemID) 
--REFERENCES Problem(ID)
--ALTER TABLE KeywordToProblem
--ADD CONSTRAINT FK_KeywordToProblem_KeywordID
--FOREIGN KEY(KeywordID) 
--REFERENCES Keyword(ID)
--TRUNCATE TABLE KeywordToProblem
--INSERT KeywordToProblem VALUES(1,1)
--INSERT KeywordToProblem VALUES(1,2)
--INSERT KeywordToProblem VALUES(1,3)
--INSERT KeywordToProblem VALUES(1,4)
--INSERT KeywordToProblem VALUES(2,2)
--INSERT KeywordToProblem VALUES(2,4)
--INSERT KeywordToProblem VALUES(3,4)
--INSERT KeywordToProblem VALUES(4,1)
--INSERT KeywordToProblem VALUES(5,1)
--INSERT KeywordToProblem VALUES(6,1)
--INSERT KeywordToProblem VALUES(6,3)
--INSERT KeywordToProblem VALUES(6,4)
--INSERT KeywordToProblem VALUES(7,2)
--INSERT KeywordToProblem VALUES(7,3)
--INSERT KeywordToProblem VALUES(8,1)
--INSERT KeywordToProblem VALUES(8,2)
--INSERT KeywordToProblem VALUES(8,4)

--帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，
--即：某个用户，在某个时间，因为某某原因，获得若干积分
SELECT * FROM Credit
DROP TABLE Credit
--CREATE TABLE Credit(
--ID INT NOT NULL,
--UserName NVARCHAR(10) NOT NULL,
--[Time] DATETIME,
--[Type] NVARCHAR(25) NOT NULL,
--Detailed NVARCHAR(25) NOT NULL,
--Reward INT NOT NULL
--INSERT Credit VALUES(1,N'阿泰','2019/10/26',N'注册',N'使用了别人的邀请码',10)


--发布求助，在Problem和Register之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
--将该求助的作者改成另外一个用户
--删除该用户
SELECT * FROM Problem
SELECT * FROM Register
--ALTER TABLE Problem
--ADD FK_ID INT 
--ADD CONSTRAINT PK_Problem_ID PRIMARY KEY(ID)
--ADD CONSTRAINT PK_Problem_Register_ID FOREIGN KEY(FK_ID) REFERENCES Register(ID)
--UPDATE Problem SET FK_ID=1 WHERE Author=N'飞哥'
--UPDATE Problem SET FK_ID=2 WHERE Author=N'阿泰'
--UPDATE Problem SET Reward = NULL WHERE ID=1
--UPDATE Problem SET FK_ID = NULL WHERE ID=7
--UPDATE Problem SET Author = NULL WHERE ID =7


--以Problem中的数据为基础，使用SELECT INTO，
--新建一个Author和Reward都没有NULL值的新表：NewProblem 
--（把原Problem里Author或Reward为NULL值的数据删掉）
--SELECT * FROM Problem
--SELECT * FROM NewProblem
--SELECT * INTO NewProblem FROM Problem WHERE Reward IS NOT NULL AND Author IS NOT NULL
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中
--INSERT NewProblem SELECT * FROM Problem WHERE Reward IS NULL 
--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，
--然后用新表ProblemStatus存放上述数据
--UPDATE Problem SET Reward = 10 WHERE ID = 1
--UPDATE Problem SET Author=N'阿泰' WHERE ID = 7 distinct   
--SELECT DISTINCT
--MAX( Reward) OVER(PARTITION BY Author) AS MAXReward,
--MIN( Reward) OVER(PARTITION BY Author) AS MINReward,
--AVG( Reward) OVER(PARTITION BY Author) AS AVGReward
--,Author 
--INTO ProblemStatus
--FROM Problem 
--SELECT * FROM ProblemStatus
--使用CASE...WHEN，颠倒TProblem中的NeedRemote
--（以前是1的，现在变成0；以前是0的，现在变成1）
SELECT * FROM Problem
--ALTER TABLE Problem
--ADD NeedRemote BIT NULL
--UPDATE Problem SET NeedRemote= CASE WHEN Author=N'飞哥' THEN 1 ELSE 0 END
--UPDATE Problem SET NeedRemote= CASE WHEN NeedRemote=1 THEN 0 ELSE 1 END


--有一些标题以test、[test]或者Test-开头的求助，找到他们并把这些前缀都换成大写
--UPDATE Problem
--SET Title =
--CASE
--WHEN Title LIKE 'test%' 
--THEN N'TEST' + SUBSTRING(Title ,5,LEN(Title)) 
--WHEN Title LIKE '#[test#]%' ESCAPE '#' 
--THEN N'[TEST]' + SUBSTRING(Title,7,LEN(Title))
--WHEN Title LIKE 'Test-%'
--THEN N'Test-'+  SUBSTRING(Title,6,LEN(Title))
--ELSE Title 
--END
--SELECT * FROM Problem

--为求助添加一个发布时间（TPublishTime），使用子查询：
--删除每个作者悬赏最低的求助
--找到从未成为邀请人的用户
--如果一篇求助的关键字大于3个，将它的悬赏值翻倍
--查出所有发布一篇以上（不含一篇）文章的用户信息
--查找每个作者最近发布的一篇文章
--查出每一篇求助的悬赏都大于5个帮帮币的作者
SELECT * FROM Problem 
SELECT * FROM Keyword
SELECT * FROM KeywordToProblem ORDER BY ProblemID
--UPDATE Problem SET FK_ID = 2 WHERE FK_ID IS NULL
--UPDATE Problem SET Reward = 5 WHERE ID = 1
--UPDATE Problem SET Author = N'大飞哥' WHERE ID = 2
--UPDATE Problem SET Created = '2019/10/16' WHERE ID=5
--DELETE KeywordToProblem 
--WHERE ProblemID IN (SELECT ID FROM Problem P1
--WHERE Reward =
--(SELECT MIN(Reward) FROM Problem P2
--WHERE P1.Author=P2.Author))

--DELETE Problem WHERE ID IN
--(SELECT ID FROM Problem P1
--WHERE Reward = (SELECT MIN(Reward) FROM Problem P2
--WHERE P1.Author = P2.Author))
-------
--SELECT ID FROM Problem
--WHERE Author NOT IN 
--(SELECT Author FROM Problem)
-----

--UPDATE Problem SET Reward = Reward*2
--WHERE ID IN (
--SELECT * FROM Problem
--WHERE ID IN
--(SELECT ProblemID FROM KeywordToProblem 
--GROUP BY ProblemID HAVING COUNT(*)>2))
-------

--SELECT * FROM Problem
--WHERE ID = (SELECT ID
--FROM Problem 
--WHERE Author = 
--(SELECT Author FROM Problem 
--GROUP BY Author HAVING COUNT(*)<=1))
----SELECT * FROM Problem 


--SELECT Title,Author,Created FROM Problem  WHERE ID IN 
--(SELECT ID FROM Problem P1 WHERE Created IN
--(SELECT  MAX(Created) OVER (PARTITION BY Author) AS NEWCreated
--FROM Problem P2
--WHERE P1.Author=P2.Author))
-------

--SELECT DISTINCT Author FROM Problem WHERE Author NOT IN 
--(SELECT Author FROM Problem WHERE Reward !> 5)
-------


--一起帮每月各发布了求助多少篇
--SELECT * FROM Problem
SELECT [TIME], COUNT(*) AS NUM FROM
(SELECT MONTH(Created) AS [TIME] FROM Problem ) AS t 
GROUP BY t.[TIME] 
GO
WITH T AS (
SELECT MONTH(Created) AS [TIME] FROM Problem)
SELECT COUNT(*) AS NUM,[TIME] FROM T GROUP BY T.[TIME]
-------------------------
GO
--每月发布的求助中，悬赏最多的3篇
SELECT * FROM Problem
SELECT * FROM (
SELECT ROW_NUMBER ()
OVER(PARTITION BY MONTH(Created)
ORDER BY Reward DESC
)
AS M,Reward,Created,Author
FROM Problem ) AS T
WHERE T.M  BETWEEN 1 AND 3
GO
WITH R AS
(SELECT ROW_NUMBER ()
OVER(PARTITION BY MONTH(Created)
ORDER BY Reward DESC
)
AS M,Reward,Author, Created
FROM Problem )
SELECT * FROM R
WHERE R.M  BETWEEN 1 AND 3
----------
GO
--每个作者，每月发布的，悬赏最多的3篇
SELECT * FROM Problem
SELECT *FROM (
SELECT ROW_NUMBER() OVER
(PARTITION BY Author,MONTH(Created)
ORDER BY Reward DESC)
AS A,Reward,Author, MONTH(Created) AS C
FROM Problem) AS R
WHERE R.A BETWEEN 1 AND 3
GO
WITH R AS (
SELECT ROW_NUMBER()
OVER (PARTITION BY Author,MONTH(Created)
ORDER BY Reward DESC) AS A,Reward,Author,MONTH(Created) AS C
FROM Problem)
SELECT *FROM R
WHERE R.A BETWEEN 1 AND 3
-------
GO
--分别按发布时间和悬赏数量进行分页查询的结果
SELECT * FROM Problem ORDER BY Created
SELECT * FROM Problem ORDER BY Created
OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY
SELECT * FROM Problem ORDER BY Reward
SELECT * FROM Problem ORDER BY Reward
OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY

GO

--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE Response(
Id INT NOT NULL,
Content NVARCHAR(25),
AuthorId INT NOT NULL,
ProblemId INT NOT NULL,
CreateTime DATETIME NULL,
)
INSERT Response VALUES(1,N'C#',1,1,'2019/11/1')
INSERT Response VALUES(2,N'C#',2,2,'2019/10/1')
INSERT Response VALUES(3,N'HTML',3,3,'2019/11/8')
INSERT Response VALUES(4,N'JS',4,4,'2019/11/20')
INSERT Response VALUES(5,N'CSS',5,5,'2019/9/5')
INSERT Response VALUES(6,N'JS',6,6,'2019/10/5')
INSERT Response VALUES(7,N'HTML',7,7,'2019/11/10')
INSERT Response VALUES(8,N'C#',8,8,'2019/11/20')
DROP TABLE Response
--然后生成一个视图 
--VResponse(ResponseId, Content, AuthorId, AuthorName, ProblemAuthorName, ProblemId, ProblemTitle, CreateTime)，
--要求该视图：能展示应答作者的用户名、应答对应求助的标题和作者用户名 （JOIN）
--           只显示求助悬赏值大于5的数据 （JOIN）
--           已被加密
--           保证其使用的基表结构无法更改
SELECT * FROM Response
SELECT * FROM Problem
--SELECT * FROM VResponse
SELECT * FROM [User]

GO
CREATE VIEW dbo.VResponse 
(ResponseId, Content, AuthorId, ProblemId, CreateTime,Reward,ProblemTitle,AuthorName, ProblemAuthorName)
WITH ENCRYPTION, SCHEMABINDING 
AS 
SELECT R.Id, R.Content, R.AuthorId, R.ProblemId, R.CreateTime , P.Reward, P.Title,P.Author,U.UserName
FROM dbo.Response R
INNER JOIN dbo.Problem P ON R.Id=P.ID
INNER JOIN dbo.[User] U ON R.Id=U.Id
WHERE Reward > 5   
GO


--演示：在Response中插入一条数据，却不能在视图中显示
--INSERT VResponse(ResponseId, Content, AuthorId, ProblemId, CreateTime) VALUES(9,N'SQL',9,9,'2019/11/2')
INSERT VResponse(Reward,ProblemTitle,AuthorName) VALUES (1,N'234数据库',N'飞哥') 
SELECT * FROM Problem
SELECT * FROM VResponse
--INSERT VResponse(ProblemAuthorName) VALUES (N'飞哥')
--修改VResponse，让其能避免上述情形
GO
ALTER VIEW dbo.VResponse 
(ResponseId, Content, AuthorId, ProblemId, CreateTime,Reward,ProblemTitle,AuthorName, ProblemAuthorName)
WITH ENCRYPTION, SCHEMABINDING 
AS 
SELECT R.Id, R.Content, R.AuthorId, R.ProblemId, R.CreateTime , P.Reward, P.Title,P.Author,U.UserName
FROM dbo.Response R
INNER JOIN dbo.Problem P ON R.ProblemId=P.ID
INNER JOIN dbo.[User] UR ON R.AuthorId=U.Id
INNER JOIN dbo.[User] UP ON UP.Id=UR.Id
WHERE Reward > 5
WITH CHECK OPTION
GO
--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，
--要求该视图：
--能反映求助的标题、使用关键字数量和悬赏
--在ProblemId上有一个唯一聚集索引
--在ProblemReward上有一个非聚集索引
SELECT * FROM Problem
SELECT * FROM VProblemKeyword
GO
CREATE VIEW VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
WITH SCHEMABINDING
AS
SELECT ID,Title,Reward,Num FROM dbo.Problem
GO
CREATE UNIQUE CLUSTERED INDEX IX_VProblemKeyword_ProblemId ON VProblemKeyword(ProblemId)
CREATE INDEX IX_VProblemKeyword_ProblemReward ON VProblemKeyword(ProblemReward)

SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint
FROM sys.indexes
WHERE object_id = OBJECT_ID('VProblemKeyword')

--在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化
SELECT* FROM Problem
SELECT * FROM VProblemKeyword
INSERT Problem VALUES (5,'2019/10/10',N'123数据库4',1,N'飞哥',9,1,0)
DELETE Problem WHERE ID=9

GO

--1、联表查出求助的标题和作者用户名
--2、查找并删除从未发布过求助的用户
--3、用一句SELECT显示出用户和他的邀请人用户名
--4、17bang的关键字有“一级”“二级”和其他“普通级”的区别：
--请在表Keyword中添加一个字段，记录这种关系
--然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称


SELECT * FROM Problem
SELECT u.UserName,p.Title FROM [User] u JOIN Problem p ON u.Id = p.ID

DELETE [User] FROM [User] u JOIN Problem p ON u.Id = p.ID
WHERE Id NOT IN (SELECT DISTINCT InvitedBy FROM [User])

SELECT UserName FROM [User] WHERE Id IN (SELECT InviteID FROM [User] GROUP BY InviteID)
SELECT * FROM [User]
SELECT u1.UserName,u2.UserName AS InviteName FROM [User] u1 
INNER JOIN [User] u2 ON u1.InviteID=u2.Id
WHERE u2.Id IN (SELECT InviteID FROM [User])
GO

SELECT * FROM Keyword
SELECT K3.KeyWords,K2.KeyWords,K1.KeyWords FROM Keyword K1 
FULL JOIN Keyword K2 ON K1.ID=K2.GradewordID 
FULL JOIN Keyword K3 ON K2.ID=K3.GradewordID 
WHERE K2.ID IN (SELECT GradewordID FROM Keyword) OR K3.ID IN (SELECT GradewordID FROM Keyword)
ORDER BY K3.ID

--5、17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），
--他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
--建议和文章没有悬赏（Reward）
--建议多一个类型：Kind NVARCHAR(20)）
--文章多一个分类：Category INT）
--请按上述描述建表。然后，
--用一个SQL语句按显示某用户发表的求助、建议和文章的Title、Content，
--并按PublishTime降序排列
SELECT * FROM Problem
SELECT * FROM Suggest
SELECT * FROM Article
SELECT * FROM [User]

SELECT ID Title, Content,PublishTime FROM Problem 
WHERE Id =(SELECT Id FROM [User] WHERE UserName =N'飞哥')
UNION ALL
SELECT Id Title, Content,PublishTime FROM Suggest 
WHERE Id =(SELECT Id FROM [User] WHERE UserName =N'飞哥')
UNION ALL
SELECT Id Title, Content,PublishTime FROM Article
WHERE Id =(SELECT Id FROM [User] WHERE UserName =N'飞哥')
ORDER BY PublishTime DESC 
GO
--用户（Reigister）发布一篇悬赏币若干的求助（Problem），
--他的帮帮币（BMoney）也会相应减少，但他的帮帮币总额不能少于0分：
--请综合使用TRY...CATCH和事务完成上述需求。
SELECT * FROM [User]
SELECT * FROM Problem
SELECT * FROM BMoney
GO
BEGIN TRAN
BEGIN TRY 
DECLARE @NUM INT = 50
	INSERT Problem(Reward,ID) VALUES(@NUM,9)
	UPDATE BMoney SET BangMoney -= @NUM WHERE Id = 
	(SELECT Id FROM [User] WHERE UserName = N'飞哥')
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	PRINT N'提交失败！'
END CATCH
COMMIT TRAN






