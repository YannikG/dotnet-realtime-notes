using System;
using Microsoft.AspNetCore.SignalR;
using YannikG.Dotnet.RealtimeNotes.Web.Models;

namespace YannikG.Dotnet.RealtimeNotes.Web.Hubs
{
	public class NoteHub : Hub
	{
		public async Task CreateNoteAsync(NoteModel model)
		{

		}
	}
}

