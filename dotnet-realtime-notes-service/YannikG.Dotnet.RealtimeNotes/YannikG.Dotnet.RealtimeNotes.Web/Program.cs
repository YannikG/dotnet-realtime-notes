
using YannikG.Dotnet.RealtimeNotes.Web.Hubs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapHub<NoteHub>("/notehub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

