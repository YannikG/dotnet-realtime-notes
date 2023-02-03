using System;
using YannikG.Dotnet.RealtimeNotes.Web.Models;

namespace YannikG.Dotnet.RealtimeNotes.Web.Services
{
	public interface INoteService
	{
		public Task<NoteModel> CreateNoteAsync(NoteModel model);
		public Task<NoteModel> UpdateNoteAsync(int id, NoteModel model);
		public Task DeleteNoteAsync(int id);
	}
}

