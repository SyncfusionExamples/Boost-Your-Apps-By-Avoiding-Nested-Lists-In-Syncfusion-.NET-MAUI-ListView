using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NestedListViewSample
{
    public class RowTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ParentTemplate { get; set; }
        public DataTemplate ChildTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var card = (Row)item;
            return card.Kind switch
            {
                RowKind.Parent => ParentTemplate,
                RowKind.Child => ChildTemplate,
                _ => ChildTemplate
            };
        }
    }

}