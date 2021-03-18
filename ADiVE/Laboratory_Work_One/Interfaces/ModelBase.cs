using System;
using System.Collections.Generic;
using System.Reflection;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Laboratory_Work_One.Interfaces
{
    public abstract class ModelBase
    {
        public static void SetSizeWindow(double width, double height)
        {
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Width = width, Height = height });
            ApplicationView.PreferredLaunchViewSize = new Size(width, height);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        public virtual List<string> GetProperties(string nObj)
        {
            List<string> properties = new List<string>();
            PropertyInfo[] propertyInfo = Type.GetType(nObj).GetProperties();

            foreach (var property in propertyInfo)
                properties.Add(property.Name);

            return properties;
        }

        public virtual void OpenWindow(Type sourcePageType, object arguments)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(sourcePageType, arguments);
        }
    }
}
