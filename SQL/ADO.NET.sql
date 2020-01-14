DELETE DREAM WHERE [Name]= N'王铁柱'

SELECT  * FROM DREAM

SELECT [Name],COUNT(1) FROM DREAM GROUP BY [Name] HAVING COUNT(1)>1

Delete DREAM Where [Name] Not In (Select Max([Name]) From DREAM Group By [Name])


DELETE FROM DREAM 
WHERE [Name] IN
(SELECT [Name] FROM 
( SELECT [Name] FROM DREAM 
GROUP BY [Name] HAVING 
COUNT(1) > 1) AS temtable );  