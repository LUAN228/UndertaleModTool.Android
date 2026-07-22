# UndertaleModTool Mobile (Android Edition)

[![License](https://img.shields.io/github/license/UnderminersTeam/UndertaleModTool?logo=github)](LICENSE.txt)
[![Build Status](https://img.shields.io/github/actions/workflow/status/YOUR_USERNAME/YOUR_REPO/build-android.yml?branch=main&label=Android%20Build)](https://github.com/)

A community-driven Android port of the renowned **UndertaleModTool**, powered by **Avalonia UI** and **UndertaleModLib**. Edit GameMaker games directly on your mobile device!

> *\* (Carrying the power to modify GameMaker data files right in your pocket...)*
> 
> *\* (It fills you with determination.)*

---

## 📱 Features

* **Portable GameMaker Editing:** Read, edit, and reconstruct `data.win` and `game.droid` files directly on Android.
* **Powered by UndertaleModLib:** Full compatibility with modern versions of Undertale, Deltarune, and other GameMaker Studio engine releases.
* **Touch-Friendly UI:** Redesigned interface layout built specifically for mobile screens using Avalonia UI.
* **GML VM Code & Asset Inspection:** View decompiled scripts, modify strings, inspect sprites, and tweak game parameters on the go.
* **Cloud Built:** Fully automated builds via GitHub Actions—no heavy Android SDK required on your computer to compile!

---

## 🚀 Quick Start (Android)

1. Go to the **Releases** section of this repository.
2. Download the latest `.apk` build (e.g., `UTMT-Android-v1.0.apk`).
3. Install the APK on your Android device (ensure "Install from unknown sources" is enabled in your browser settings if prompted).
4. Launch **UTMT Mobile**.
5. Grant storage/file access permissions when requested.
6. Tap **Open File** and select your target `data.win` or `game.droid` file to start modding!

---

## 🛠️ How to Build from Source (GitHub Actions)

You don't need a heavy local setup to build this APK. You can use **GitHub Actions** directly:

1. **Fork** this repository to your GitHub account.
2. Navigate to the **Actions** tab and enable workflows.
3. Push changes or trigger the workflow manually (`workflow_dispatch`).
4. Once completed, download the fresh `.apk` artifact generated in the run summary.

### Local Compilation (.NET 8 SDK)
If you prefer building locally on Linux or PC:

```bash
# Install the Android workload
dotnet workload install android

# Publish the Android project
dotnet publish UndertaleModTool.Android/UndertaleModTool.Android.csproj -c Release -f net8.0-android
