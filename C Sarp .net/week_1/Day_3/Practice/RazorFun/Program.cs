var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();// 1 - 
var app = builder.Build();


app.UseStaticFiles(); 
app.UseRouting();  
app.UseAuthorization();  

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}"); // 3 -

app.Run();