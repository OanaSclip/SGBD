
BEGIN TRAN
	UPDATE TableB SET Name = 'NameB' WHERE Id = 1


	UPDATE TableA SET Name = 'NameA' WHERE Id = 1	
COMMIT TRAN