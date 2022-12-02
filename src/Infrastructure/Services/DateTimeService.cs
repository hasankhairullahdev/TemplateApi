using TemplateApi.Application.Common.Interfaces;

namespace TemplateApi.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
