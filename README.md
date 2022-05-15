# DuckDnsAgent
Automatically update your DuckDns domains with your computer IP

Developed with C# with .Net 5 framework. Windows Form project.

## How to run

- Copy /release/ content on safe location (C:\Program Files\DuckDnsAgent\ for example)
- Execute {YOUR_PROGRAM_LOCATION}\DuckDnsAgent.exe

DuckDnsAgent is on the right side of your taskbar. Click on the yellow duck icon to show UI and configure the agent.

To run the program when you log on:

- Create a shortcut of DuckDnsAgent.exe
- Windows + R > shell:startup
- Move the shortcut to the new explorer window opened.

## How to build

### Prerequires
- Git bash
- Dotnet SDK (already included with Visual Studio (not vscode))

### Build step

```
PS git clone https://github.com/SAUFRAS0FT/DuckDnsAgent.git
PS cd DuckDnsAgent
PS dotnet build
```

Compiled executable is located at: 

DuckDnsAgent\bin\Debug\net5.0-windows\DuckDnsAgent.exe
