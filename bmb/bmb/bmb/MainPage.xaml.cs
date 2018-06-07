using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bmb
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var books = GetMockBooks();
            BookListView.ItemsSource = books;

		}
        List<BookModel> GetMockBooks()
        {
            var books = new List<BookModel>();
            books.Add(new BookModel()
            {
                BookName = "BookName:The Road Not Taken",
                Author = "Author:Robert Frost",
                Price = 500,
                Rating = 4,
                Bookimage = "image1.jpg",
                Summary = "very nice collection of poems"
            });

            books.Add(new BookModel()
            {
                BookName = "BookName: Kite Runner",
                Author = "Author:Khaled Hosseini",
                Price = 451,
                Rating = 4,
                Bookimage = "image2.jpg",
                Summary = "Bestseller for a reason",

            });
            books.Add(new BookModel()
            {
                BookName = "BookName:Inferno",
                Author = "Author: Dan Brown",
                Price = 263,
                Rating = 3,
                Bookimage = "image3.jpg",
                Summary="Great book",
                
            });
            return books;
        }
        private void BookListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            Navigation.PushAsync(new bookdetailspage(selectedBook));
        }
    }
}
