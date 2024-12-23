using LogingInWithMiddleWare.LoginMiddleWare;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Invoking custom middleware
app.UseloginMiddleware();

app.Run(async context => {
    await context.Response.WriteAsync("No response");
});

app.Run();
