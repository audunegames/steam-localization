# Audune Steam Localization Integration

[![openupm](https://img.shields.io/npm/v/com.audune.localization.steam?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.audune.localization.steam/)

This package includes a locale selector that uses the Steam client language to select the locale for the localization system provided by the [Audune Localization](https://github.com/audunegames/localization) package.

## Installation

### Requirements

This package depends on the following packages:

* [Localization](https://openupm.com/packages/com.audune.localization/), version **1.0.0** or higher.
* [Steamworks.NET](https://openupm.com/packages/com.rlabrecque.steamworks.net/), version **20.0.0** or higher.

If you're installing the required packages from the [OpenUPM registry](https://openupm.com/), make sure to add a scoped registry with the URL `https://package.openupm.com` and the required scopes before installing the packages.

### Installing from the OpenUPM registry

To install this package as a package from the OpenUPM registry in the Unity Editor, use the following steps:

* In the Unity editor, navigate to **Edit › Project Settings... › Package Manager**.
* Add the following Scoped Registry, or edit the existing OpenUPM entry to include the new Scope:

```
Name:     package.openupm.com
URL:      https://package.openupm.com
Scope(s): com.audune.localization.steam
```

* Navigate to **Window › Package Manager**.
* Click the **+** icon and click **Add package by name...**
* Enter the following name in the corresponding field and click **Add**:

```
com.audune.localization.steam
```

### Installing as a Git package

To install this package as a Git package in the Unity Editor, use the following steps:

* In the Unity editor, navigate to **Window › Package Manager**.
* Click the **+** icon and click **Add package from git URL...**
* Enter the following URL in the URL field and click **Add**:

```
https://github.com/audunegames/steam-localization-integration.git
```

## License

This package is licensed under the GNU GPL 3.0 license. See `LICENSE.txt` for more information.
