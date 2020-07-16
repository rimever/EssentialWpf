using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace Chapter6_12
{
    public class LocalNameTemplateSelector:DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is XmlElement data)
            {
                return (container as FrameworkElement)?.FindResource(data.LocalName) as DataTemplate;
            }
            return null;
        }
    }
}
