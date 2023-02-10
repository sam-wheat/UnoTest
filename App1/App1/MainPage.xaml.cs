using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page, INotifyPropertyChanged
{
    private int _SomeProperty;
    public int SomeProperty 
    { 
        get => _SomeProperty;
        set => SetProp(ref _SomeProperty, value);
    }

    public MainPage()
    {
        this.InitializeComponent();
        DataContext = this;
        SomeProperty = 500;
    }


    #region INotifyPropertyChanged implementation
    public event PropertyChangedEventHandler? PropertyChanged;
    public void RaisePropertyChanged([CallerMemberNameAttribute] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public void SetProp<T>(ref T prop, T value, [CallerMemberNameAttribute] string propertyName = "")
    {
        if (!Object.Equals(prop, value))
        {
            prop = value;
            RaisePropertyChanged(propertyName);
        }
    }
    #endregion
}
