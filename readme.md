# DeviceConsole

> View Logs and Execute Commands on device

Device Console provides a way for you to see logs, warnings, errors, exceptions, and stack traces in your application. Any logs that would appear in Unity's console will now appear in your application making it easy for you to debug on device.

The original asset is [here](https://www.assetstore.unity3d.com/en/#!/content/57193).

## Usage

Simply drag `Assets/DeviceConsole/Plugins/DeviceConsole/PrebuiltConsoles/Dark/DeviceConsole_Dark` or  `Assets/DeviceConsole/Plugins/DeviceConsole/PrebuiltConsoles/Light/DeviceConsole_Light` to your scene.

To create new command, create a new static function and mark it with `[DebugCommandAttribute (<command_name>, <command_description>, <command_arguments_description>)]`

## Setup

1. Clone this repo and use it as a base for your new project
2. Install `npm` and `yarn`
3. Update `package.json` to include DeviceConsole like so

    ```
        "DeviceConsole": "ssh://github.com/minhhh/DeviceConsole.git#v0.0.1"
    ```
4. Run `npm run unity` and wait for it to install all necessary packages


## Changelog

**0.0.1**

* Initial commit

<br/>
