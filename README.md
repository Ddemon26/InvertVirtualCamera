# VCInvertCamera

The `VCInvertCamera` class is a Unity script used to control the inversion of the camera's X and Y axes. This script is typically attached to a GameObject that has a `CinemachineFreeLook` component.

## Properties

- **public CinemachineFreeLook freeLookComponent**: This is the `CinemachineFreeLook` component that this script controls. It is typically attached to the same GameObject as this script.
- **public Bool InvertXAxis**: This boolean value determines whether to invert the X axis. It can either be a constant value or a variable.
- **public Bool InvertYAxis**: This boolean value determines whether to invert the Y axis. It can either be a constant value or a variable.
- **public bool AlwaysUpdate**: This boolean value determines whether to always update the inversion in the `Update` method. If it's true, the `ToggleInversion` method is called in every frame.

## Methods

- **private void OnValidate()**: This method is called in the Unity editor whenever the script is loaded or a value is changed in the Inspector. It checks if `freeLookComponent` is null, and if it is, it assigns the `CinemachineFreeLook` component attached to the same GameObject to `freeLookComponent`.
- **private void Update()**: This method is called once per frame. If `AlwaysUpdate` is true, it calls the `ToggleInversion` method.
- **public void ToggleInversion()**: This method toggles the inversion of the X and Y axes. If `freeLookComponent` is not null, it sets the `m_InvertInput` property of `m_XAxis` and `m_YAxis` to the value of `InvertXAxis` and `InvertYAxis` respectively. If `freeLookComponent` is null, it logs an error message.
