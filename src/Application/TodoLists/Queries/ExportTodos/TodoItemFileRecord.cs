using TemplateApi.Application.Common.Mappings;
using TemplateApi.Domain.Entities;

namespace TemplateApi.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
