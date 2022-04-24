var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDistributedMemoryCache()
                .AddSession(options => {
                    options.Cookie = new CookieBuilder
                    {
                        Name = "DeltaLogSession",
                        HttpOnly = true,
                        SecurePolicy = CookieSecurePolicy.Always,
                        IsEssential = true,
                        SameSite = SameSiteMode.Strict
                    };
                })
                .AddAntiforgery()
                .AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
