using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bmb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bookdetailspage : ContentPage
    {
        private BookModel Book_Selected { get; set; }
        public bookdetailspage(BookModel SelectedBook)
        {
            InitializeComponent();
            Book_Selected = SelectedBook;
            image.Source = Book_Selected.Bookimage;
            title.Text = Book_Selected.BookName;
            Author.Text = Book_Selected.Author;
            Summary.Text = Book_Selected.Summary;
        }
        public void OnButtonClicked(object sender, EventArgs args)
        {
            DisplayAlert("alert", "We dont have any books", "ok");
        }
    }
}