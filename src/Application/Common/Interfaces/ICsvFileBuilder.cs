using TemplateApi.Application.TodoLists.Queries.ExportTodos;

namespace TemplateApi.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
