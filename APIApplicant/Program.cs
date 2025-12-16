using APIApplicant.Entity;
using APIApplicant.Model;
using APIApplicant.Entity;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", new CorsPolicy

{
    Origins = { "*" },
    Headers = { "*" },
    Methods = { "*" },
}));

builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("CorsPolicy");
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Welcome to Recruitment System!");

app.MapPost("/SaveApplicant", (ApplicantInputDto std) =>
{
    DataContext context = new DataContext();
    var applicant = new Applicant();
    applicant.FirstName = std.FirstName;
    applicant.LastName = std.LastName;
    applicant.Phone = std.Phone;
    applicant.Email = std.Email;
    applicant.CV = std.CV;
    applicant.ApplicationLetter = std.ApplicationLetter;
    applicant.Reference = std.Reference;
    applicant.DateAdded = DateTime.Now;
    context.Add(applicant);
    context.SaveChanges();
    return Results.Ok("Save Successfully");
});
app.MapGet("/GetApplicant", () =>
{
    DataContext context = new DataContext();
    var Applicants = context.Set<Applicant>().ToList();
    return Results.Ok(Applicants);


});

app.Run();
