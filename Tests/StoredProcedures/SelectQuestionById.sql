create procedure [dbo].[Question_SelectById]
        @Id int
as
begin
    select
        [Text],
        [Difficulty],
        [Number],
        [TestId]
    from dbo.[Question]
	where Id = @Id
end
