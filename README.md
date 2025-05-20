# VDS Lite – Virtual Design Studio Prototype (Unity + XR)

This Unity project is a prototype for a Virtual Design Studio (VDS Lite), created as part of the CST-320 course. It focuses on implementing XR interaction features using OpenXR and the XR Interaction Toolkit for Meta Quest devices.

## 🛠 Project Features

- ✅ Teleportation using left thumbstick
- ✅ Object grabbing and manipulation (cube, triangle, sphere, cylinder)
- ✅ World-space color-picker UI with four color buttons
- ✅ Snapshot feature: renders camera view to a whiteboard
- ✅ Meta Quest 2/3 device testing support

## 🎮 Controls

| Action                  | Control                     |
|------------------------|-----------------------------|
| Teleport               | Left thumbstick             |
| Grab object            | Grip button (both hands)    |
| Change color           | Tap UI buttons or Y button  |
| Snapshot capture       | Click snapshot button in UI |

## 📁 Project Structure

- `Assets/` – All Unity scenes, scripts (e.g. `ToggleColorY.cs`), materials, prefabs, and UI
- `Packages/` – Unity package configuration (OpenXR, XR Toolkit)
- `ProjectSettings/` – Unity settings (XR setup, Input System, etc.)

## 🚀 Setup Instructions

1. Clone or download this repo
2. Open in **Unity 2022.3.40f1**
3. Make sure the following are installed via Package Manager:
   - XR Interaction Toolkit
   - OpenXR Plugin
   - Input System
4. Connect your Meta Quest (Air Link or USB)
5. Hit **Play** to test in Editor, or build to device for full experience

## 📷 Snapshot Feature

Captures the current view using `Camera.Render()` and `RenderTexture` and displays it on a whiteboard in the scene.

## 📌 Known Issues

- Snapshot thumbnail may not update consistently
- Color UI may not appear on certain headsets
- Teleportation beyond scene boundaries still possible

## 👨‍🎓 Author

**Christian Nshuti Manzi**  
_Created as part of CST-320 XR course with Professor Isac Artzi_

---

