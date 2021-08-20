# percentage

![CI](https://github.com/thumperward/percentage/workflows/CI/badge.svg)

![Screenshot](percentage.png)

See your battery percentage in the Windows 10 system tray.

Original project by [kas](https://github.com/kas/percentage).

## Installing

-   [Download the latest release](https://github.com/thumperward/percentage/releases).
-   Put `percentage.exe` in your startup folder (to get to your startup folder,
    press `Windows + R`, type `shell:startup`, and press enter).

## Compiling

This project was compiled with Visual Studio Professional 2015.

To compile using a Windows Docker image with this pre-installed, first install 
Docker Desktop and configure it to run Windows containers, then change to the 
root directory of the repository and run the following:

```powershell
docker run -v "$(pwd)\:C:\Build\" nugardt/msbuild:15.5 msbuild C:\Build\percentage\percentage.sln /property:Configuration=Release
```

Alternatively, simply open the project in the provided devcontainer and run:

```sh
msbuild percentage/percentage.sln -p:Configuration=Release
```

The output binary is in `percentage/percentage/bin/release`.

## Contributing

I created this project with a very basic understanding of developing C# desktop
applications and contributions are extremely welcome!
