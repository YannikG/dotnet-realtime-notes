using System;
using Dapper;
using Microsoft.Extensions.Options;
using YannikG.Dotnet.RealtimeNotes.Web.Models;
using YannikG.Dotnet.RealtimeNotes.Web.Options;

namespace YannikG.Dotnet.RealtimeNotes.Web.Repositories.Implementations
{
	public class NoteSqliteRepository : BaseSqliteRepository, INoteRepository
    {
        public NoteSqliteRepository(IOptions<SqliteConfig> config) : base(config)
        {
        }

        public async Task<NoteModel> CreateNoteAsync(NoteModel model)
        {
            using(var connection = GetConnection())
            {
                var result = await connection.QueryFirstAsync<int>($"INSERT INTO {Config.NoteTableName} (Text,Date,Position)" +
                        $" VALUES (@Text, @Date, @Position) RETURNING ID", model
                    ).ConfigureAwait(false);

                model.Id = result;

                return model;
            }
        }

        public async Task DeleteNoteAsync(int id)
        {
            using (var connection = GetConnection())
            {
                await connection.ExecuteAsync($"DELETE FROM {Config.NoteTableName} WHERE Id = @id", new { id = id });
            }
        }

        public async Task<List<NoteModel>> GetAllNotesAsync()
        {
            using (var connection = GetConnection())
            {
                var result = await connection.QueryAsync<NoteModel>($"SELECT * FROM {Config.NoteTableName}").ConfigureAwait(false);

                return result.ToList();
            }
        }

        public async Task<NoteModel> UpdateNoteAsync(int id, NoteModel model)
        {
            using (var connection = GetConnection())
            {
                await connection.ExecuteAsync($"UPDATE {Config.NoteTableName} SET " +
                    $"Text = @Text, Position = @Position", model
                    );
            }

            return model;
        }
    }
}

