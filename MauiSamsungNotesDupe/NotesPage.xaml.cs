using System.Security.Cryptography.X509Certificates;

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
		//var notes = new List<Note>
		List<Note> notes = new List<Note>();
		{

			notes.Add(new Note
			{
				Title = "Shopping List",
				Content = "Lotion,eggs,sourdough bread,butter,milk",
				Date = "Today"

			});
			notes.Add(new Note
			{
				Title = "Rasam Ingredients",
				Content = "Curry leaves,garlic,dry chillies,tamarind,spice mix",
				Date = "Yesterday"

			});
			notes.Add(new Note
			{
				Title = "Reminder",
				Content = "Call Dr Kaskar for Vit D",
				Date = "3 days ago"

			});
			notes.Add(new Note
			{
				Title = "Series",
				Content = "Prison Break Season 4 Episode 6",
				Date = "Last week"


			});
			notes.Add(new Note
			{
				Title = "Timetable",
				Content = "Technical drawings tutorial at 14h00",
				Date = "2 months ago"

			});

		}
		;

        //need to bind to coll.view

        BindingContext = this;

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