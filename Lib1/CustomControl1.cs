using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib1;
public partial class CustomControl1 : Control
{
    // Constant
    public int IntProperty
    {
        get { return (int)GetValue(IntPropertyProperty); }
        set { SetValue(IntPropertyProperty, value); }
    }

    public static readonly DependencyProperty IntPropertyProperty =
        DependencyProperty.Register("IntProperty", typeof(int), typeof(CustomControl1), new PropertyMetadata(0, (s, e) => {
            int x = Convert.ToInt32(e.NewValue);
        }));


    // Binding
    public int IntProperty2
    {
        get { return (int)GetValue(IntPropertyProperty2); }
        set { SetValue(IntPropertyProperty2, value); }
    }

    public static readonly DependencyProperty IntPropertyProperty2 =
        DependencyProperty.Register("IntProperty2", typeof(int), typeof(CustomControl1), new PropertyMetadata(0, (s, e) => {
            int x = Convert.ToInt32(e.NewValue);
        }));


    // Binding ElementName
    public int IntProperty3
    {
        get { return (int)GetValue(IntPropertyProperty3); }
        set { SetValue(IntPropertyProperty3, value); }
    }

    public static readonly DependencyProperty IntPropertyProperty3 =
        DependencyProperty.Register("IntProperty3", typeof(int), typeof(CustomControl1), new PropertyMetadata(0, (s, e) => {
            int x = Convert.ToInt32(e.NewValue);
        }));


    public CustomControl1()
    {
        this.DefaultStyleKey = typeof(CustomControl1);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
    }
}
