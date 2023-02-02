using ReactiveUI;
using Todo.Models;

namespace Todo.ViewModels;

public class AddItemViewModel : ViewModelBase
{
	private string description;

	public AddItemViewModel()
	{
		var okEnabled = this.WhenAnyValue(x => x.Description, x => !string.IsNullOrEmpty(x));

		Ok = ReactiveCommand.Create(() => new TodoItem() { Description = Description }, okEnabled);
		Cancel = ReactiveCommand.Create(() => { });
	}
	
	
	
}