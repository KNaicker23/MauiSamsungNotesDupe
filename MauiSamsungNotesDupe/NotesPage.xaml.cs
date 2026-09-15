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
			},
			new()
			{ 
				Title = "Meter number",
				Content = "903847300283",
				Date = "1 week ago"
			
			},
			new()
			{ 
				Title = "Shah Rukh Khan movies",
				Content = "Om Shanti Om , Jawan, Kal ho na Ho, Khabi khushi kabhi gham",
				Date = "A day ago"
				
			},
			new()
			{ 
				Title = "Burfee recipe",
				Content = "2 cups water, rose water, milk powder, sugar,elaichi powder",
				Date = "19 Nov 2025"
			
			
			},
			new()
			{ 
				Title = "Discrete math",
				Content = "Go over partitions and Kruskal's Theorem",
				Date = "30 Nov 2025"
			
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