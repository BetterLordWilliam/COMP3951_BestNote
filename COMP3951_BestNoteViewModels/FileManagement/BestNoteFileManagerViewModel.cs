using COMP3951_BestNoteServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Collections;
using System.Collections.ObjectModel;

namespace COMP3951_BestNoteViewModels.FileManagement;

public partial class BestNoteFileManagerViewModel : ObservableObject
{
    private BestNoteFileManagerService bfs;

    public ObservableCollection<string> TestStrings { get; set; } 

    public BestNoteFileManagerViewModel(BestNoteFileManagerService bfs)
    {

        this.bfs = bfs;
        TestStrings = new ObservableCollection<string> { "Will", "Otterbein", "Mos", "Will", "Otterbein", "Mos", "ASD" };
    }
}
