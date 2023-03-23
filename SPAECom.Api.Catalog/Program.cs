using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPAECom.Api.Catalog.Data;
using SPAECom.Api.Catalog.Repository;
using SPAECom.Api.Catalog.Repository.Provider;


var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddDbContext<DatabaseContext>(options => {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

    // automapper
    IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
    builder.Services.AddSingleton(mapper);
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


    builder.Services.AddScoped<IProductRepository, ProductRepository>();
    builder.Services.AddControllers();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SPAECom.Api.Catalog v1"));
    }
    //app.UseAuthentication();
    //app.UseAuthorization();
    app.UseRouting();
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();

