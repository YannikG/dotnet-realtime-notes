using System;
using Microsoft.Extensions.Options;
using YannikG.Dotnet.RealtimeNotes.Web.Options;
using Microsoft.Data.Sqlite;

namespace YannikG.Dotnet.RealtimeNotes.Web.Repositories.Implementations
{
	public class BaseSqliteRepository
	{
        protected readonly SqliteConfig Config;

        public BaseSqliteRepository(IOptions<SqliteConfig> config)
        {
            if (config.Value is null)
                throw new ArgumentException("config cannot be null!");

            Config = config.Value;
        }

        protected SqliteConnection GetConnection()
        {
            return new SqliteConnection(Config.DatabaseName);
        }
    }
}

