using APIApplicant.Entity;
using APIApplicant.Entity;
using APIApplicant.Model;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

app.MapPost("/SaveJobVacancy", (JobVacancyInputDto std) =>
{
    DataContext context = new DataContext();
    var vacancy = new JobVacancy();
    vacancy.IdPosition = std.IdPosition;
    vacancy.NumberOfPosition = std.NumberOfPosition;
    vacancy.Description = std.Description;
    vacancy.DateFrom = std.DateFrom;
    vacancy.DateTo = std.DateTo;

    context.Add(vacancy);
    context.SaveChanges();
    return Results.Ok("Save Successfully");
});

app.MapPost("/SaveApplication", (ApplicationIputDto std) =>
{
    DataContext context = new DataContext();
    var application = new Application();
    application.IdApplicant = std.IdApplicant;
    application.IsActive = true;
    application.Date = DateTime.Now;
    application.UserAdded = "System";
    application.DateAdded = DateTime.Now ;

    context.Add(application);
    context.SaveChanges();
    return Results.Ok("Save Successfully");
});

app.MapPost("/SaveInterview", (InterviewInputDto std) =>
{
    DataContext context = new DataContext();
    var interview = new Interview();
    interview.IdPosition = std.IdPosition;
    interview.IdApplicant = std.IdApplicant;
    interview.IsActive = true;
    interview.InterviewDate = new DateOnly();;
    interview.TimeFrom = std.TimeFrom;
    interview.TimeTo = std.TimeTo;
    interview.UserAdded = "System";
    interview.DateAdded = DateTime.Now;

    context.Add(interview);
    context.SaveChanges();
    return Results.Ok("Save Successfully");
});

app.MapPost("/SaveOffer", (OfferInputDto std) =>
{
    DataContext context = new DataContext();
    var offer = new Offer();
    offer.IdApplicant = std.IdApplicant;
    offer.IdPosition = std.IdPosition;
    offer.Salary = std.Salary;
    offer.UserAdded = "System";
    offer.DateAdded = DateTime.Now;

    context.Add(offer);
    context.SaveChanges();
    return Results.Ok("Save Successfully");
});
app.MapGet("/GetApplicant", () =>
{
    DataContext context = new DataContext();
    var Applicants = context.Set<Applicant>().ToList();
    return Results.Ok(Applicants);


});


app.MapGet("/GetJobVacancy", () =>
{
    DataContext context = new DataContext();
    var job = context.Set<JobVacancy>().ToList();
    return Results.Ok(job);


});
app.MapGet("/GetApplication", () =>
{
    DataContext context = new DataContext();
    var applications
    = context.Set<Application>().ToList();
    return Results.Ok(applications);


});

app.MapGet("/GetInterview", () =>
{
    DataContext context = new DataContext();
    var interviews
    = context.Set<Interview>().ToList();
    return Results.Ok(interviews);


});

app.MapGet("/GetOffer", () =>
{
    DataContext context = new DataContext();
    var offers
    = context.Set<Offer>().ToList();
    return Results.Ok(offers);


});

app.MapDelete("/DeleteInterview/{Id:Guid}", (Guid Id) =>
{
    using var context = new DataContext();

    var interview = context.Interviews.FirstOrDefault(i => i.Id == Id);

    if (interview == null)
    {
        return Results.NotFound("Interview not found");
    }

    context.Interviews.Remove(interview);
    context.SaveChanges();

    return Results.Ok("Interview deleted successfully");
});

app.MapPut("/UpdateInterview/{Id:Guid}", (Guid Id, InterviewInputDto dto) =>
{
    using var context = new DataContext();

    var interview = context.Interviews.FirstOrDefault(i => i.Id == Id);

    if (interview == null)
    {
        return Results.NotFound("Interview not found");
    }

    interview.IdPosition = dto.IdPosition;
    interview.IdApplicant = dto.IdApplicant;
    interview.InterviewDate = dto.InterviewDate;
    interview.TimeFrom = dto.TimeFrom;
    interview.TimeTo = dto.TimeTo;

    context.SaveChanges();

    return Results.Ok("Interview updated successfully");
});


app.Run();
