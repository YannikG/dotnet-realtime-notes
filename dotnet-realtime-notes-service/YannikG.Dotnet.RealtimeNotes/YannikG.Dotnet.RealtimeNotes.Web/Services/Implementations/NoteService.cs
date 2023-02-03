using System;
using YannikG.Dotnet.RealtimeNotes.Web.Models;
using YannikG.Dotnet.RealtimeNotes.Web.Repositories;

namespace YannikG.Dotnet.RealtimeNotes.Web.Services.Implementations
{
	public class NoteService : INoteService
	{
        private readonly INoteRepository noteRepository;

		public NoteService(INoteRepository repository)
		{
            this.noteRepository = noteRepository;
		}

        public Task<NoteModel> CreateNoteAsync(NoteModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNoteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<NoteModel> UpdateNoteAsync(int id, NoteModel model)
        {
            throw new NotImplementedException();
        }
    }
}

