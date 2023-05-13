# CatML

[![NuGet](https://img.shields.io/nuget/v/CatML.svg)](https://www.nuget.org/packages/CatML)
[![NuGet](https://img.shields.io/nuget/dt/CatML.svg)](https://www.nuget.org/packages/CatML)

A CatML is an alternative Xaml controls toolkit for Avalonia.

## Usage

Install NuGet package https://www.nuget.org/packages/CatML/

```xaml
<box xmlns="https://github.com/avaloniaui"
     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
     xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
     xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
     mc:Ignorable="d" d:DesignWidth="800" d:DesignHeight="450"
     x:Class="CatML.Demo.mainBox"
     width="800" height="600"
     mark="CatML">
  <carpet width="800" height="600">
    <litter name="Login Form" x="350" y="50" />

    <litter name="Username" x="50" y="100" />
    <post name="Username" x="200" y="100" />

    <litter name="Password" x="50" y="200" />
    <post name="Password" x="200" y="200" />

    <litter name="User Type" x="50" y="300" />
    <catnip name="UserType" x="200" y="300">
      <option>Admin</option>
      <option>User</option>
    </catnip>

    <litter name="Volume" x="50" y="400" />
    <laser name="Volume" min="0" max="100" x="200" y="400" />

    <toy name="Login" x="350" y="500">
      <paw>
        <!-- login action goes here -->
      </paw>
    </toy>
  </carpet>
</box>
```

```csharp
namespace CatML.Demo;

public partial class mainBox : box
{
    public mainBox()
    {
        InitializeComponent();
    }
}
```

## License

CatML is licensed under the [MIT license](LICENSE.TXT).
