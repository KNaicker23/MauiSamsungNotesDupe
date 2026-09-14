using MauiSamsungNotesDupe.Models;

namespace MauiSamsungNotesDupe;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
		LoadNotes();
	}

	private void LoadNotes()
	{
		var notes = new List<Note>
		{
			new()
			{
				Title = "Shopping List",
				Content = "Lotion, eggs, sourdough bread, butter, milk",
				Date = "Today"
			},
			new()
			{
				Title = "Rasam Ingredients",
				Content = "Curry leaves, garlic, dry chillies, tamarind, spice mix",
				Date = "Yesterday"
			},
			new()
			{
				Title = "Reminder",
				Content = "Call Dr Kaskar for Vit D",
				Date = "3 days ago"
			},
			new()
			{
				Title = "Series",
				Content = "Prison Break Season 4 Episode 6",
				Date = "Last week"
			},
			new()
			{
				Title = "Timetable",
				Content = "Technical drawings tutorial at 14h00",
				Date = "2 months ago"
			}
		};

		NotesCollectionView.ItemsSource = notes;
	}

  

    private void NewPdfClicked_Clicked(object sender, EventArgs e)
    {

    }

    private void SearchButtonClicked_Clicked(object sender, EventArgs e)
    {

    }

    private void NewNoteButton_Clicked(object sender, EventArgs e)
    {

    }
}