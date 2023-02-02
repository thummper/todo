using System.Collections.Generic;
using Todo.Models;

namespace Todo.Services;

public class Database
{
	public IEnumerable<TodoItem> GetItems() =>
	new[]
	{
	new TodoItem() { Description = "Walk the dog" },
	new TodoItem() { Description = "Buy some cheese" },
	new TodoItem() { Description = "Buy even more cheese", IsChecked = true }
	};
}