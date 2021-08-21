# percentage

![CI](https://github.com/kas/percentage/workflows/CI/badge.svg)

![Screenshot](percentage.png)

See your battery percentage in the Windows 10 system tray.

## Installing

-   [Download the latest release](https://github.com/kas/percentage/releases).
-   Put `percentage.exe` in your startup folder (to get to your startup folder,
    press `Windows + R`, type `shell:startup`, and press enter).

## Compiling

This project was compiled with Visual Studio Community 2019.

Select ".NET desktop development" when setting up Visual Studio.

To compile using a Windows Docker image with this pre-installed, first install 
Docker Desktop and configure it to run Windows containers, then change to the 
root directory of the repository and run the following:

```powershell
docker run -v "$(pwd)\:C:\Build\" nugardt/msbuild:15.5 msbuild \
  C:\Build\percentage\percentage.sln /property:Configuration=Release
```

Alternatively, simply open the project in the provided devcontainer and run:

```sh
msbuild percentage/percentage.sln -p:Configuration=Release
```

The output binary is in `percentage/percentage/bin/release`.

## Contributions

My goal for this project is to keep it as simple as possible. I welcome 
suggestions, but for complicated features I'd recommend forking the project.
