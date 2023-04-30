var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.TryAddSingleton<ISampleService, SampleService>();
services.AddMvc();
services.AddSoapCore();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.UseSoapEndpoint<ISampleService>("/Service.asmx", 
    new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});
app.MapGet("/", () => "Hello World!");
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
app.Run();
       