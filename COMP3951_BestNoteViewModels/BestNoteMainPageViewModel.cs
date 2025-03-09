using COMP3951_BestNoteServices;
using COMP3951_BestNoteViewModels.FileManagement;

namespace COMP3951_BestNoteViewModels;

public partial class BestNoteMainPageViewModel : ObservableObject
{
    #region Services
    public BestNoteFileManagerService BestNoteFileManagerService { get; private set; }
    #endregion

    #region SubViewModels
    public BestNoteFileManagerViewModel BestNoteFileManagerViewModel { get; private set; }
    #endregion

    public BestNoteMainPageViewModel()
    {
        #region Services
        BestNoteFileManagerService = new BestNoteFileManagerService();
        #endregion

        #region ViewModels
        BestNoteFileManagerViewModel = new BestNoteFileManagerViewModel(BestNoteFileManagerService);
        #endregion
    }
}
