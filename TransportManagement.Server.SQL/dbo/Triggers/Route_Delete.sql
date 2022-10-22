CREATE TRIGGER [Route_Delete]
	ON [dbo].[Routes]
	FOR DELETE
	AS
	BEGIN
		SET NOCOUNT ON

		DECLARE @ID BIGINT
		SET @ID = (SELECT Id FROM deleted)

		DELETE [dbo].[RoutesStops]
		WHERE RouteId IN (@ID)
	END