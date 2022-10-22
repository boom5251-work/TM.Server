CREATE TRIGGER [Stop_Delete]
	ON [dbo].[Stops]
	FOR DELETE
	AS
	BEGIN
		SET NOCOUNT ON

		DECLARE @ID BIGINT
		SET @ID = (SELECT Id FROM deleted)

		DELETE [dbo].[RoutesStops]
		WHERE StopId IN (@ID)
	END