# WPFBootstrapUI

The Bootstrap like UI for WPF.

### **Caracteristicas**

* Estilo moderno.
* Soporte para .Net Framework >= 4.5 <= 4.8.

### **Inicio rápido**

* Crea un nuevo proyecto WPF.
* Instala el paquete nuget: _Install-Package WPFBootstrapUI_ (Coming soon).
* Edita el archivo App.xaml y agrega el siguiente código **XAML**:

```
<Application x:Class="BootstrapUISample.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    StartupUri="MainWindow.xaml">
    <Application.Resources>
         <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;component/Colors/Colors.xaml" />
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;component/Fonts/FontFamilies.xaml" />
                <ResourceDictionary Source="pack://application:,,,/WPFBootstrapUI;component/Themes/WPFBootstrapUI.Base.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

**Edite el MainWindow.xaml con el siguiente código:**

```
<Window
    ...
    xmlns:bootstrap="http://schemas.rpj.com/WPFBootstrapUI"
    xmlns:iconPacks="http://metro.mahapps.com/winfx/xaml/iconpacks"
    xmlns:local="clr-namespace:BootstrapUISample"
    Title="MainWindow"
    Width="800"
    Height="450"
    Icon="{iconPacks:FontAwesomeImage Kind=BootstrapBrands, Brush=White}"
    Style="{StaticResource window-primary}"
    WindowStartupLocation="CenterScreen"
    WindowState="Maximized">
     <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        <bootstrap:Alert
            Grid.Row="0"
            Content="Hola Mundo"
            Style="{StaticResource alert-primary}" />
        <Button
            Grid.Row="1"
            Content="Hello World"
            Style="{StaticResource btn-primary}" />
    </Grid>
 </Window>
```

Más información en el [wiki](https://github.com/RandyPJ/WPFBootstrapUI/wiki/Inicio)


