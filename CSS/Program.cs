var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // wwwroot klas�r� i�erisindeki static dosyalar� eri�ime a�ar. gerekli parametreler ile farkl� folderlerida a�abiliriz. bunu asp.net core middleware konusunda konu�uruz...


app.MapGet("/", () => "Selam!");
app.Run();
