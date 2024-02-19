using LR3_ASP_Zhyhlova;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeService>();
var app = builder.Build();
app.MapGet("/task1", CalculateRequest);
app.MapGet("/task2", TimeRequest);

// - Task 1
async Task CalculateRequest(HttpContext context)
{
    context.Response.ContentType = "text/html; charset=utf-8";
    var calcService = app.Services.GetService<CalcService>();
    await context.Response.WriteAsync($"<h3><center>5 + 5 = {calcService?.Add(5, 5)}</center></h3>");
    await context.Response.WriteAsync($"<h3><center>10 - 5 = {calcService?.Subtract(10, 5)}</center></h3>");
    await context.Response.WriteAsync($"<h3><center>5 * 5 = {calcService?.Multiply(5, 5)}</center></h3>");
    await context.Response.WriteAsync($"<h3><center>10 / 5 = {calcService?.Divide(10, 5)}</center></h3>");
}

// - Task 2
async Task TimeRequest(HttpContext context)
{
    context.Response.ContentType = "text/html; charset=utf-8";
    var ts = app.Services.GetService<TimeService>();
    await context.Response.WriteAsync(ts.CalculateTime());
}

app.Run();