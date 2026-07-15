# 🐱 AnimaFelis

> A pixel-art emotional virtual pet mobile game focused on emotional well-being and habit formation.

Built with **Unity 6.3 LTS** · **C#** · **Android**

---
## Gameplay Demo

<p align="center">
  <img src="docs/burntloaf.png" width="240" alt="AnimaFelis home screen"/>
  <img src="docs/EmotionDemo.gif" width="240" alt="AnimaFelis gameplay demo"/>
</p>

**Current build features:**
- Pixel-art cat with idle blink and sway animations
- 4 stat bars (Hunger, Happiness, Energy, Cleanliness) with real-time decay
- 5-state emotion system (Happy, Sad, Hungry, Tired, Neglected) driven by stat thresholds
- Sleep mechanic with gradual energy regeneration and button locking during sleep
- Overeating penalty (feeding past a hunger threshold reduces happiness)
- Combo "neglected" state triggered when multiple stats drop critically low simultaneously
- Mobile portrait UI (1080x2400) with pixel-perfect scaling across resolutions
- Built in Unity 6.3 LTS (C#) targeting Android

---

## About

AnimaFelis is a 2D mobile game where players care for a pixel-art cat whose mood and health reflect the player's daily habits. The pet reacts expressively to neglect, play, feeding, and rest, making emotional well-being tangible and interactive.

This project is a self-directed Final Year Project (FYP) and primary portfolio piece, demonstrating mobile game development in Unity, state-driven game systems, PixelArt UI design, and iterative gameplay design.

---

## Current Implementation

### Core Systems

- **Emotion Engine** — 5 emotional states: `HAPPY`, `SAD`, `HUNGRY`, `TIRED`, `NEGLECTED`
- **Stat System** — 4 stats tracked in real time: Hunger, Happiness, Energy, Cleanliness
- **Stat Decay** — all 4 stats decrease over time at tuned rates, driving automatic state transitions
- **Sleep Mechanic** — gradual rest/sleep toggle with button locking during sleep state; Energy restores on wake
- **Overeating Penalty** — feeding when Hunger is full triggers a negative happiness penalty
- **Cleanliness Drain** — Cleanliness drains independently; low cleanliness affects overall pet state

### UI

- Dark purple (`#1a1a2e`) background theme with lavender (`#e8b4f8`) accents
- 4 stat bar sliders (HungerBar, HappinessBar, EnergyBar, CleanlinessBar) wired to the emotion engine
- 4 action buttons anchored to the bottom of screen via a ButtonPanel:
  * 🐟 Feed · 🧶 Play · 🌙 Rest · 🫧 Clean
  * Custom pixel-art icons (normal + pressed states via Sprite Swap)
  * Conditional state-based locking (e.g. buttons lock during sleep)

### Art & Animation

- 32×32px pixel-art cat sprite (Point filter, RGBA 32-bit)
- Idle blink animation with ear and tail movement
- Idle sway animation
- All pixel-art UI assets designed in Pixel Studio

---

## Planned Features

## Roadmap

### Done
- [x] Core pet state machine (5 emotions, 4 decaying stats)
- [x] Action buttons (Feed, Play, Rest, Clean) wired to gameplay logic
- [x] Per-state sprite variants (happy, sad, hungry, tired, neglected)
- [x] Sleep mechanic with gradual energy fill and button locking
- [x] Overeating/Overplaying/Too-clean penalties
- [x] Combo "neglected" state (multiple stats critically low at once)
- [x] PixelArt stat bar icons
- [x] Mobile portrait UI (1080x2400), tested across resolutions

### Next Up
- [ ] Outdoor exploration mode (grid-based overworld)
  - [ ] Tilemap setup
  - [ ] Grid movement script
  - [ ] Cat directional walk animations
  - [ ] Camera follow
  - [ ] Scene transition from home scene
  - [ ] Stat system integration (outdoor actions affect stats)
- [ ] Sound effects for actions and state changes
- [ ] Button press animations

### Medium Term
- [ ] Habit tracker integration, real-world habits feed pet stats
- [ ] Daily check-in system (mood logging tied to pet mood)
- [ ] Notification system (pet reminds you when neglected)
- [ ] Save/load system (persist pet state between sessions)

### Long Term
- [ ] Multiple pet types / unlockable skins
- [ ] MiniGames triggered by the Play action
- [ ] Android build and Play Store deployment
- [ ] WebGL build for browser demo (stretch goal)
---

## Tech Stack

![Unity](https://img.shields.io/badge/Unity-6.3%20LTS-black?logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Android-3DDC84?logo=android&logoColor=white)
![Git](https://img.shields.io/badge/Version%20Control-Git-F05032?logo=git&logoColor=white)

- **Engine:** Unity 6.3 LTS
- **Language:** C#
- **Target Platform:** Android
- **Art:** Custom pixel art (32x32, drawn in Pixel Studio)
- **Architecture:** Single state machine (`PetStateMachine`) driving stat decay, emotion transitions, and sprite swapping via a single `SpriteRenderer`

## 📁 Project Structure

```
AnimaFelis/
├── Assets/
│   ├── Animations/     # Sprite animation clips and controllers
│   ├── Scripts/        # C# game logic (PetStateMachine.cs, ...)
│   ├── Scenes/         # Unity scenes
│   └── Sprites/        # Pixel-art sprites and icons
├── .gitignore
└── README.md
```

---

## 🔗 Related Projects

These Android/Java prototypes were built first to validate the core logic before moving to Unity:

- [`animafelis-pet-state`](https://github.com/AzuMaooo/animafelis-pet-state) — Pet state machine: 5 states, 3 stats, 4 actions (Java, Android Studio)
- [`animafelis-mood-logger`](https://github.com/AzuMaooo/animafelis-mood-logger) — Mood logging app with real-time scrollable history (Java, Android Studio)

---

## 👩‍💻 Author

**Lai Zie Jin (AzuMaooo)** · Year 2 Software Engineering, UTAR Sungai Long Campus

Solo developer on all AnimaFelis projects. Seeking a game development internship (October 2026, Singapore).

[LinkedIn](https://linkedin.com/in/zie-jin-lai) · [GitHub](https://github.com/AzuMaooo)
