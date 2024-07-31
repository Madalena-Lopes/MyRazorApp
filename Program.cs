var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); //adiciona suporte para paginas Razor. Como outros tipo Maui... .AddControllers


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseHttpsRedirection();  //erro 404 pode ser por falta disto (http ->https)
app.UseStaticFiles(); //temos q criar pasta wwwroot(padr�o web). Necess�rio tb para usar imagens ou qq outro arquivo est�tico (css, json).

//mapeamento das paginas,criar urls personalizados ou dar um simples nome a uma p�gina e ele o encotrar
app.UseRouting(); // crial url personalizados
app.MapRazorPages(); //criar uma simples p�gina

app.Run();
