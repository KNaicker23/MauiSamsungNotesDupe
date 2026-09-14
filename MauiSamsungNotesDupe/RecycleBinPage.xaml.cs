using MauiSamsungNotesDupe.Models;

namespace MauiSamsungNotesDupe;

public partial class RecycleBinPage : ContentPage
{
	public RecycleBinPage()
	{
		InitializeComponent();
		LoadDeletedNote();
	}

	private void LoadDeletedNote()
	{
		var deletedNotes = new List<Note>
		{
			new() { Title = "Holiday Ideas", Content = "Visit the Drakensberg and book a cabin", Date = "Yesterday" },
			new() { Title = "Recipe", Content = "Tomatoes, basil, mozzarella, olive oil", Date = "3 days ago" },
			new() { Title = "Project Notes", Content = "Review the final design before Friday", Date = "Last week" }
		};

		BindingContext = new[]
		{
			deletedNotes[Random.Shared.Next(deletedNotes.Count)]
		};
	}
}