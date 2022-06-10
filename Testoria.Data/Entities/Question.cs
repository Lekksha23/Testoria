namespace Testoria.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public int TestId { get; set; }
        public int Difficulty { get; set; }
    }
}
