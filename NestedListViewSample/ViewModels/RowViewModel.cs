using System.Collections.ObjectModel;

namespace NestedListViewSample;

public class RowViewModel
{

    public ObservableCollection<Row> Rows { get; } = new();

    public RowViewModel()
    {

        Rows = new ObservableCollection<Row>
        {
            new Row { Kind = RowKind.Parent, Text = "Parent 1", ParentId = "P1" },
            new Row { Kind = RowKind.Child,  Text = "Child 1.1", ParentId = "P1" },
            new Row { Kind = RowKind.Child,  Text = "Child 1.2", ParentId = "P1" },
            new Row { Kind = RowKind.Child,  Text = "Child 1.3", ParentId = "P1" },

            new Row { Kind = RowKind.Parent, Text = "Parent 2", ParentId = "P2" },
            new Row { Kind = RowKind.Child,  Text = "Child 2.1", ParentId = "P2" },
            new Row { Kind = RowKind.Child,  Text = "Child 2.2", ParentId = "P2" },
            new Row { Kind = RowKind.Child,  Text = "Child 2.3", ParentId = "P2" },
            new Row { Kind = RowKind.Child,  Text = "Child 2.4", ParentId = "P2" },

            new Row { Kind = RowKind.Parent, Text = "Parent 3", ParentId = "P3" },
            new Row { Kind = RowKind.Child,  Text = "Child 3.1", ParentId = "P3" },
            new Row { Kind = RowKind.Child,  Text = "Child 3.2", ParentId = "P3" },

            new Row { Kind = RowKind.Parent, Text = "Parent 4", ParentId = "P4" },
            new Row { Kind = RowKind.Child,  Text = "Child 4.1", ParentId = "P4" },

            new Row { Kind = RowKind.Parent, Text = "Parent 5", ParentId = "P5" },
            new Row { Kind = RowKind.Child,  Text = "Child 5.1", ParentId = "P5" },
            new Row { Kind = RowKind.Child,  Text = "Child 5.2", ParentId = "P5" },
            new Row { Kind = RowKind.Child,  Text = "Child 5.3", ParentId = "P5" },
        };
    }
}