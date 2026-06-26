# 🐱 AnimaFelis

> A pixel-art emotional virtual pet mobile game focused on emotional well-being and habit formation.

Built with **Unity 6.3 LTS** · **C#** · **Android**

---

## 📖 About

AnimaFelis is a 2D mobile game where players care for a pixel-art cat whose mood and health reflect the player's daily habits. The pet reacts expressively to neglect, play, feeding, and rest — making emotional well-being tangible and interactive.

This project serves as a Final Year Project (FYP) and primary portfolio piece, demonstrating mobile game development, UI/UX design, and state-driven systems.

---

## ✅ Current Implementation

### Core Systems
- **Pet State Machine** — 5 emotional states: `HAPPY`, `SAD`, `HUNGRY`, `TIRED`, `NEGLECTED`
- **Stat System** — 3 live stats tracked in real time: Hunger, Happiness, Energy
- **Stat Decay** — stats decrease over time, driving state transitions automatically

### UI
- Dark purple (`#1a1a2e`) background theme with lavender (`#e8b4f8`) accents
- 3 stat bar sliders (HungerBar, HappinessBar, EnergyBar) wired to the state machine
- 4 action buttons anchored to the bottom of screen via a ButtonPanel:
  - 🐟 Feed · 🧶 Play · 🌙 Rest · 🫧 Clean
  - Custom pixel-art icons (normal + pressed states)
  - All buttons wired to PetStateMachine methods and tested in Play mode

### Art & Animation
- 32×32px pixel-art cat sprite (Point filter, RGBA 32-bit)
- Idle blink animation with ear and tail movement
- Idle sway animation

---

## 🔜 Planned Features

### Next Up
- [ ] Pixel-art stat bar icons (16×16px) placed left of each slider
- [ ] Button press animations

### Short Term
- [ ] Per-state sprite variants (happy, sad, hungry, tired, neglected expressions)
- [ ] State transition animations
- [ ] Stat icon visual feedback (pulse/shake when stat is low)
- [ ] Sound effects for actions and state changes

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

| Layer | Tool |
|---|---|
| Engine | Unity 6.3 LTS |
| Language | C# |
| Art | Pixilart (pixel art) |
| Target Platform | Android |
| Version Control | Git / GitHub |

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
- [`animafelis-mood-logger`](https://github.com/AzuMaooo/animafelis-mood-logger) — Mood logging app (Java, Android Studio)

---

## 👩‍💻 Author

**AzuMaooo** · Year 2 Software Engineering, UTAR
