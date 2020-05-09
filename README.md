# WPFBootstrapUI

The Bootstrap like UI for WPF.

### **Features**

* Modern styles.
* Targets .Net Framework >= 4.5.
* No packages dependencies.

### **Quick start**

* Create a new WPF app.
* Install from nuget: _Install-Package WPFBootstrapUI_.
* Edit the App.xaml to following:

```
<Application x:Class="BootstrapUISample.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;Component/Styles/Colors.xaml" />
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;Component/Styles/Fonts.xaml" />
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;Component/Themes/BootstrapUI.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

**Edit the MainWindow.xaml to following:**

```
<Window
    ...
    xmlns:bootstrap="http://schemas.rpj.com/WPFBootstrapUI"
    xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
    xmlns:local="clr-namespace:BootstrapUISample"
    Title="MainWindow"
    Width="800"
    Height="450"
    WindowStartupLocation="CenterScreen"
    WindowState="Maximized">
     <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        <bootstrap:Alert
            Grid.Row="0"
            Content="Hola Mundo" />
        <Button
            Grid.Row="1"
            Content="Hello World" />
    </Grid>
 </Window>
```

More information in the [wiki](https://github.com/RandyPJ/WPFBootstrapUI/wiki/Inicio)


