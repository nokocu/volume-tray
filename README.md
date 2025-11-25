<p align="center">
  <img src="https://raw.githubusercontent.com/nokocu/volume-tray/master/src/assets/logo.png" width="128px" height="128px" alt="Volume Tray logo">
</p>
<h1 align="center">Volume Trey</h1>

<p align="center">
  <a href="https://github.com/nokocu/volume-trayreleases" target="_blank">
    <img src="https://img.shields.io/github/v/release/nokocu/volume-tray" alt="Latest release" />
  </a> 
  <a href="https://github.com/nokocu/volume-tray/releases" target="_blank">
    <img src="https://img.shields.io/github/downloads/nokocu/volume-tray/total" alt="Total downloads" />
  </a> 
</p>

Volume Tray prevents apps from opening with 100% volume and makes managing each program's volume easier. 

image
<img src="" />

## Features
- Global hotkeys to control the volume of any application
- Global hotkeys to control the volume of current output device
- Global hotkeys to control the volume of foreground application
- Global hotkeys to mute current output device
- Global hotkeys to change your default output device to another active device
- Set active output device as the default one by selecting it in the tray icon context menu
- On screen display notifications
- Change volume by hotkeys with your preferred adjustment step
- Limiting the volume of the launched application if its volume is at 100% to your preferred value
- In-app volume mixer which can be opened by global hotkey or by clicking on the tray icon
- Dark/light theme based on your Windows accent color

### Design & Personalization

Volume Tray will automatically adjust the look and feel to match your Windows version and preferences. Additional options are available to select the Windows version and theme of your choice.

image
<img src="" />

## Download

**Download the lastest version from the [Releases page](https://github.com/nokocu/volume-tray/releases).**


## Install via Package Manager

### Windows Package Manager

```powershell
winget install xanderfrangos.twinkletray
```

### Chocolatey (unofficial)

[Chocolatey](https://chocolatey.org/) users can download and install Volume Tray from Chocolatey's Community Repository by installing the `volume-tray` package:

```powershell
choco install volume-tray
```

To upgrade to the latest approved package version, run the following command:

```powershell
choco upgrade volume-tray
```

## Usage

- Download from the [Releases page](https://github.com/nokocu/volume-tray/releases) and run the installer EXE.
- Once installation has finished, you should see the Volume Tray icon in your system tray. 
- Click the icon to bring up the Adjust Brightness flyout. 
- Click away to hide the flyout.
- Right-click the system tray icon to quit.

**Known issues:**
- 

<!-- ## [NOT YET IMPLEMENTED] Command Line Arguments

Volume Tray supports changes from the command line. Volume Tray must already be running. Multiple arguments will override each other.

For example: `"%LocalAppData%\Programs\volume-tray\Volume Tray.exe" --ProcessName=Name --Offset=-30` -->
<!-- 
- `--Example` Does something. Starts at 1. *Example: `--Example=1`* -->


## Build Instructions
If you wish to run a development build of Volume Tray:

- Download or clone.
- Install the build tools for [`node-gyp`](https://github.com/nodejs/node-gyp#installation), if not already installed. You may already have these from installing NodeJS.
- Run `npm install`.
- Run `npm run build` to build an executable or `npm start` to run a development build.

*Note: Volume Tray must be built on Windows.*

## Special Thanks

Volume Tray is forked from [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray) and [Volumey](https://github.com/G-Stas/Volumey). It was built using frameworks & libraries such as [Electron](https://electronjs.org/), [Node.js](https://nodejs.org/), [node-ddcci](https://github.com/hensm/node-ddcci), and [win32-displayconfig](<https://github.com/djsweet/win32-displayconfig>). 

## License

This project combines code from:
- [Volumey](https://github.com/G-Stas/Volumey) (GPL-3.0 License)
- [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray) (MIT License)

As required by GPL-3.0, the project is distributed under the GPL-3.0 License. See licenses\LICENSE-VOLUMEY and licenses\LICENSE-TWINKLE-TRAY for details.