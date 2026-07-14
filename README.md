# 🐱 AnimaFelis

> A pixel-art emotional virtual pet mobile game focused on emotional well-being and habit formation.

Built with **Unity 6.3 LTS** · **C#** · **Android**

---

## 🎮 Demo

> Screenshots and gameplay GIF coming soon — active development in progress.

<!-- Once you have a GIF or screenshot, replace the line above with:
![AnimaFelis Gameplay](Assets/Screenshots/gameplay.gif)
-->

**Current build features:**
- Pixel-art cat with idle blink and sway animations
- 4 stat bars (Hunger, Happiness, Energy, Cleanliness) with real-time decay
- 4 action buttons (Feed, Play, Rest, Clean) with press-state animations and conditional locking
- 5-state emotion engine driving pet behaviour automatically

---

## 📖 About

AnimaFelis is a 2D mobile game where players care for a pixel-art cat whose mood and health reflect the player's daily habits. The pet reacts expressively to neglect, play, feeding, and rest — making emotional well-being tangible and interactive.

This project is a self-directed Final Year Project (FYP) and primary portfolio piece, demonstrating mobile game development in Unity, state-driven game systems, pixel-art UI design, and iterative gameplay design.

---

## ✅ Current Implementation

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
- All pixel-art UI assets designed in Pixilart

---

## 🔜 Planned Features

### Next Up

- [ ] Per-state sprite variants (happy, sad, hungry, tired, neglected expressions)
- [ ] State transition animations
- [ ] Pixel-art stat bar icons (16×16px) placed left of each slider

### Short Term

- [ ] Stat icon visual feedback (pulse/shake when stat is low)
- [ ] Sound effects for actions and state changes
- [ ] Button press animations

### Medium Term

- [ ] Habit tracker integration — real-world habits feed pet stats
- [ ] Daily check-in system (mood logging tied to pet mood)
- [ ] Notification system (pet sends reminders when neglected)
- [ ] Save/load system (persist pet state between sessions)

### Long Term

- [ ] Multiple pet types / unlockable skins
- [ ] Mini-games triggered by play action
- [ ] Android build and Play Store deployment

---

## 🛠️ Tech Stack

| Layer           | Tool                    |
| --------------- | ----------------------- |
| Engine          | Unity 6.3 LTS           |
| Language        | C#                      |
| Art             | Pixilart (pixel art)    |
| Target Platform | Android                 |
| Version Control | Git / GitHub            |
| IDE             | Visual Studio           |
| AI Assist       | GitHub Copilot          |

---

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
