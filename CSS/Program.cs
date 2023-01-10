var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // wwwroot klasörü içerisindeki static dosyalarý eriþime açar. gerekli parametreler ile farklý folderlerida açabiliriz. bunu asp.net core middleware konusunda konuþuruz...


app.MapGet("/", () => "Selam!");
app.Run();
