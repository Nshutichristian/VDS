# VDS Lite – Virtual Design Studio Prototype (Unity + XR)

This Unity project is a prototype for a Virtual Design Studio (VDS Lite), created as part of the CST-320 course. It focuses on implementing XR interaction features using OpenXR and the XR Interaction Toolkit for Meta Quest devices.

## 🛠 Project Features

✅ Teleportation using left thumbstick  
✅ Object grabbing and manipulation (cube, triangle, sphere, cylinder)  
✅ Two-handed scaling and rotation (0.2x–3x)  
✅ Physics-based interactions with proper collision and stacking  
✅ World-space color-picker UI with four color buttons  
✅ Snapshot feature: renders camera view to a whiteboard  
✅ Dynamic floating UI panel (Spawn, Toggle Gravity, Reset)  
✅ In-app metrics overlay (FPS, frame time, block count, gravity state)  
✅ Multimodal feedback (sound, visual highlight, haptics on grab/release and collision)  
✅ Meta Quest 2/3 device testing support  

## 🎮 Controls

| Action             | Control                         |
|--------------------|----------------------------------|
| Teleport           | Left thumbstick                 |
| Grab object        | Grip button (both hands)        |
| Two-hand scale     | Use both grips and move apart   |
| Change color       | Tap UI buttons or press Y       |
| Snapshot capture   | Click snapshot button in UI     |
| Toggle overlay     | Y button (left) or B button (right) |

## 📁 Project Structure

- `Assets/` – Unity scenes, scripts (e.g. ToggleColorY.cs, OverlayMetrics.cs), prefabs, UI, materials
- `Packages/` – Package configurations (OpenXR, XR Toolkit, Input System)
- `ProjectSettings/` – Unity settings including XR, input bindings
- `RenderTextures/` – Contains SnapTex used in snapshot feature

## 🚀 Setup Instructions

1. Clone or download this repo
2. Open in **Unity 2022.3.40f1**
3. Ensure these are installed via Package Manager:
   - XR Interaction Toolkit
   - OpenXR Plugin
   - Input System
4. Connect Meta Quest (Air Link or USB Link)
5. Play in Editor or build to device to test full functionality

## 📷 Snapshot Feature

Captures the view from `SnapshotCamera` to a `SnapTex` RenderTexture  
Displays output in real time on `SnapshotDisplay` using an Unlit Material

## 🧪 Self-Usability Test (Task 5)

- Scenario: Spawn 3 blocks, scale one to 2x, toggle gravity off, reset scene
- Tracked: FPS, block count, gravity status, haptics
- Captured video using Quest recording
- Findings:
  - ❌ Pain Point 1: Input confusion (toggle with wrong hand)
  - ❌ Pain Point 2: Scaling sometimes causes jitter/clipping
  - ✅ Quick Win: Clamped scaling and improved button highlights

## 📌 Known Issues

- Snapshot thumbnail may not refresh if camera is disabled
- Color UI buttons can become unreachable if moved
- Overlay may overlap with scene elements if not repositioned

## 👨‍🎓 Author

**Christian Nshuti Manzi**  
Created for the CST-320 XR Course with Professor Isac Artzi  
Completed solo as a Collaborative Learning Community (CLC) assignment.

---

📁 Includes: Technical Report, Screencast (60s), Unity Project Folder  
🔗 GitHub Repo: [https://github.com/Nshutichristian/VDS](https://github.com/Nshutichristian/VDS)
