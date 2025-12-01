namespace NestedListViewSample;

/// <summary>
/// Distinguishes parent and child rows.
/// </summary>
public enum RowKind { Parent, Child }

/// <summary>
/// Flat row model for a single SfListView. Parent/Child relationship is indicated by <see cref="Kind"/> and <see cref="ParentId"/>.
/// </summary>
public sealed class Row
{
    /// <summary>
    /// Row type: Parent or Child.
    /// </summary>
    public RowKind Kind { get; set; }

    /// <summary>
    /// Display text for the row.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Identifier of the parent row. For Parent rows, set to a unique ID (e.g., "P1");
    /// </summary>
    public string ParentId { get; set; } = string.Empty;
}