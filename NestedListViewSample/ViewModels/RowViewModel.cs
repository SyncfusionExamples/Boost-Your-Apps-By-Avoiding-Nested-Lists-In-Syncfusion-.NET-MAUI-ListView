using System.Collections.ObjectModel;
namespace NestedListViewSample;

/// <summary>
/// View model that exposes a flat list of parent/child rows for a single SfListView.
/// </summary>
/// <remarks>
/// Rows are ordered so parent rows precede their related child rows (linked by ParentId).
/// Suitable for DataTemplateSelector scenarios with heterogeneous row types.
/// </remarks>
public class RowViewModel
{
    /// <summary>
    /// Flat list of parent and child rows for a single SfListView.
    /// </summary>
    public ObservableCollection<Row> Rows { get; } = new();

    /// <summary>
    /// Seeds demo data. Parent rows control related Child rows via <see cref="Row.ParentId"/>.
    /// </summary>
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