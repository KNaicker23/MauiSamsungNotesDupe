using System.Security.Cryptography.X509Certificates;
using Android.Provider;
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

			new Note
			{
				Title = "Shopping List",
				Content = "Lotion,eggs,sourdough bread,butter,milk",
				Date = "Today"

			},
			new Note
			{ 
				Title = "Rasam Ingredients",
				Content = "Curry leaves,garlic,dry chillies,tamarind,spice mix",
				Date = "Yesterday"
			
			},
			new Note
			{ 
				Title = "Reminder",
				Content = "Call Dr Kaskar for Vit D",
				Date = "3 days ago"
			
			},
			new Note
			{ 
				Title = "Series",
				Content = "Prison Break Season 4 Episode 6",
				Date = "Last week"
			
			
			},
			new Note
			{ 
				Title = "Timetable",
				Content = "Technical drawings tutorial at 14h00",
				Date = "2 months ago"
			
			}

		};
		
		//need to bind to coll.view
	
	
	}
}