# 📍 Roadmap – Agent Personnel de Révision (C# WPF)

## 📦 Version 1.0 – MVP Fonctionnel

### 🎯 Objectifs :
- Interface minimaliste
- Timer Pomodoro configurable
- Lecture audio
- Blocage d'applications
- Stockage des sessions

---

### ✅ Base du projet
- [ ] Créer le projet Visual Studio (.NET 8, WPF)
- [ ] Configurer le thème sombre global (`App.xaml`)
- [ ] Définir la structure des dossiers (`Models`, `ViewModels`, `Views`, `Services`, etc.)
- [ ] Gérer le démarrage automatique au lancement de Windows
- [ ] Créer l'icône de la zone de notification (tray icon)

---

### 🧠 Interface Utilisateur
- [ ] UI compacte en haut à gauche de l’écran (250x250px max)
- [ ] Animation d’agrandissement au survol
- [ ] Message initial “Souhaitez-vous réviser ?”
- [ ] Fenêtre principale avec :
  - [ ] Timer
  - [ ] Statut de session
  - [ ] Bouton “Leçon terminée”

---

### ⏱️ Timer Pomodoro
- [ ] Implémenter `DispatcherTimer` pour décompte
- [ ] Ajouter modes personnalisables (25/5, 30/10…)
- [ ] Notification intelligente fin de cycle
- [ ] Pause et reprise
- [ ] Sauvegarde des durées en base SQLite

---

### 🎵 Musique de Révision
- [ ] Intégrer `NAudio` pour la lecture de MP3
- [ ] Interface simple pour :
  - [ ] Ajouter / supprimer des pistes
  - [ ] Passer à la piste suivante
- [ ] Lancer la musique au démarrage du Pomodoro

---

### 🔒 Blocage de Distractions
- [ ] Interface de gestion des applications interdites
- [ ] Blocage des processus interdits (via `Process.Kill()`)
- [ ] Rafraîchissement toutes les 5 secondes

---

### 💾 Stockage local (SQLite)
- [ ] Création de la base de données locale
- [ ] Table `Sessions` (temps, durée, musique, apps actives…)
- [ ] Fonction d’insertion après chaque session
- [ ] Prévoir table `PistesAudio` et `Progression`

---

## 📈 Version 2.0 – Statistiques et Analyse

### 📊 Statistiques
- [ ] Intégration de `LiveCharts2` pour affichage des graphes
- [ ] Graphiques : temps total / semaine, jour, heure
- [ ] Corrélations :
  - [ ] Piste audio vs performance
  - [ ] Heures de la journée vs productivité

---

### ✅ Marquage de progression
- [ ] Bouton "Chapitre terminé" + formulaire de saisie
- [ ] Sauvegarde dans SQLite
- [ ] Affichage sur les statistiques

---

## 🌐 Version 3.0 – Connectivité et Intelligence

### 🌍 Historique navigateur (optionnel)
- [ ] Créer une extension Chrome/Firefox simple (Manifest V3)
- [ ] Lier à l'app via WebSocket / HTTP local
- [ ] Affichage dans les statistiques

---

### 🧠 Intégration avec Notion
- [ ] Connexion API Notion via `HttpClient`
- [ ] Suivi des pages consultées / éditées
- [ ] Affichage graphique du temps passé par page

---

### 🤖 Chatbot intelligent (Ollama)
- [ ] Lancement local d’un serveur Ollama
- [ ] Requêtes à l’API via `HttpClient`
- [ ] Affichage conversationnel (TextBox + ListBox)

---

## 📦 Version 4.0 – Finitions

### 🎮 Gamification & Export
- [ ] Export CSV/PDF des données
- [ ] Médailles / badges (durée cumulée, jours consécutifs…)
- [ ] Synchronisation multi-appareils (via stockage cloud ou dossier partagé)

---

### 🔒 Vie privée
- [ ] Interface de gestion des données :
  - [ ] Export
  - [ ] Suppression complète
- [ ] Aucun envoi de données sans consentement explicite

---

## 🏁 Suivi global

| Module                         | Statut     |
|-------------------------------|------------|
| Interface compacte             | ⬜ À faire  |
| Timer Pomodoro                 | ⬜ À faire  |
| Blocage de distractions        | ⬜ À faire  |
| Audio et playlist              | ⬜ À faire  |
| Sauvegarde en SQLite           | ⬜ À faire  |
| Graphiques & stats             | ⬜ À faire  |
| Notion API                     | ⬜ À faire  |
| Historique navigateur          | ⬜ À faire  |
| Assistant IA (Ollama)          | ⬜ À faire  |
| Export CSV/PDF                 | ⬜ À faire  |
| Gamification                   | ⬜ À faire  |
| Vie privée / confidentialité   | ⬜ À faire  |

---

📌 **Mise à jour régulière conseillée. Garde ce fichier à la racine du projet pour suivre ta progression.**
