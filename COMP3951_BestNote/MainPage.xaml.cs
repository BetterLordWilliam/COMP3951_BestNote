using COMP3951_BestNoteViewModels;
using COMP3951_BestNoteViewModels.FileManagement;

namespace COMP3951_BestNote
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BestNoteMainPageViewModel();
        }
    }
}
