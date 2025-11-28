using System.Collections.ObjectModel;

namespace NestedListViewSample;

public enum RowKind { Parent, Child }

public class Row
{
    public RowKind Kind { get; set; }
    public string Text { get; set; }
    public string ParentId { get; set; }
}