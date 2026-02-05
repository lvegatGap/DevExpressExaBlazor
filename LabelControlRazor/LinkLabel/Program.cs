using Gap.Blazor.DevE.Components;
using LinkLabel.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTelerikBlazor();

builder.Services.AddControllers();
builder.Services.AddHttpClient();

// Add services to the container.
builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddScoped<Gap.Blazor.Application>();
builder.Services.AddTransient<ITabOrderService, MainTabOrderService>();
builder.Services.AddTransient<FocusService>();
builder.Services.AddTransient<TabControlTabService>();
builder.Services.AddTransient<ContainerTabOrderService>();
builder.Services.AddDynamicControlServices();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ClipboardService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();

app.UseAntiforgery();
app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Map API controllers
});

app.UseHttpsRedirection();

app.UseStaticFiles();
StaticService.Context = app;
app.MapRazorComponents<App>()
.AddInteractiveServerRenderMode();

app.Run();