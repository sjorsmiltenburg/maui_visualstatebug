using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_maui_windows_visualstategroupbug
{
    public static class MyVisualStateExtension
    {
        public static readonly BindableProperty MyVisualStateProperty = BindableProperty.CreateAttached(
            propertyName: "MyVisualState",
            returnType: typeof(VisualState),
            declaringType: typeof(Grid),
            defaultValue: new VisualState() { Name = "Inactive" },
            propertyChanged: OnVisualStateChanged,
            defaultBindingMode: BindingMode.TwoWay);

        static void OnVisualStateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            VisualStateManager.GoToState((VisualElement)bindable, ((VisualState)newValue).Name);
        }
    }
}
