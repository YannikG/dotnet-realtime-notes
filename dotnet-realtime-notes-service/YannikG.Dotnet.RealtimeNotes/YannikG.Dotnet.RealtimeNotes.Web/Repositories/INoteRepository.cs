using System;
using YannikG.Dotnet.RealtimeNotes.Web.Models;

namespace YannikG.Dotnet.RealtimeNotes.Web.Repositories
{
	public interface INoteRepository
	{
        public Task<NoteModel> CreateNoteAsync(NoteModel model);
        public Task<NoteModel> UpdateNoteAsync(int id, NoteModel model);
        public Task DeleteNoteAsync(int id);
        public Task<List<NoteModel>> GetAllNotesAsync();
    }
}

