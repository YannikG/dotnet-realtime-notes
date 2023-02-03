using System;
namespace YannikG.Dotnet.RealtimeNotes.Web.Models
{
	public class NoteModel
	{
		public int Id { get; set; }
		public string Text { get; set; } = string.Empty;
		public DateTime Date { get; set; } = DateTime.Now;
		public int Position { get; set; }
	}
}

