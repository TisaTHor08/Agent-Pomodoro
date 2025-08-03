# 📚 Agent Personnel de Révision - Cahier des Charges

## 🎯 Objectif
Développer une application minimaliste et interactive servant d’assistant personnel pour organiser, suivre et améliorer les sessions de révision selon la méthode Pomodoro. L'agent vise à augmenter la productivité, à réduire les distractions et à générer des rapports statistiques détaillés.

---

## 🖥️ Interface Générale

- **Démarrage automatique au lancement du système**
- **Interface initiale épurée, thème sombre**
  - Demande à l'utilisateur s'il souhaite réviser
    - Si **non** : l'agent se ferme
    - Si **oui** : l’interface complète s’ouvre

- **Interface compacte** (petit carré en haut à gauche de l’écran)
  - **Extension automatique** en quart d’écran lorsque le curseur passe dessus

---

## ⏱️ Fonctionnalités de Suivi

### Suivi du temps et de l'activité
- Traque du **temps total de révision**
- Suivi des **applications utilisées** :
  - Temps d’utilisation global
  - Temps en mode plein écran
- Export des données vers :
  - **Agenda personnel**
  - **Graphiques statistiques**
  - **Home Assistant** :
    - Envoi d'informations (état de session, début/fin de pause, chapitre terminé…)
    - Réception de commandes (changer de piste audio, valider une étape…)

### Méthode Pomodoro
- Possibilité de **configurer plusieurs modes Pomodoro** (ex: 25/5, 30/10, etc.)
- Prise en charge du **cycle Pomodoro complet** :
  - 3 sessions de travail + pause courte
  - 1 session de travail + pause longue
- Démarrage d’un Pomodoro lance une **piste audio** personnalisée
  - Gestion des pistes :
    - Ajouter / supprimer / modifier
    - Passer à la suivante facilement
  - Statistiques sur les pistes :
    - Durée moyenne d’écoute
    - Fréquences d’utilisation selon l’heure et le jour

---

## 📆 Planification et Organisation

### Agenda intégré
- Visualisation des **sessions de travail** et des **pauses**
- Possibilité d’**ajouter une activité planifiée** à chaque session de travail
- Construction d’un **planning personnalisé** selon les objectifs

---

## 🚫 Blocage de Distractions

- **Liste de programmes bannis** durant la révision
  - Édition via une interface intuitive
  - Empêche leur lancement durant la session

- **Liste de sites web interdits**
  - Blocage via une extension de navigateur personnalisée liée à l’agent
  - Liste éditable par l'utilisateur

---

## ✅ Marquage de Progression

- **Bouton “Leçon / Chapitre terminé”**
  - Permet d’enregistrer la progression
  - Intégration dans les graphiques et l’agenda pour analyses détaillées

---

## 📊 Statistiques et Visualisation

- **Page dédiée aux statistiques**
  - Graphiques dynamiques et interactifs
  - Nombreux filtres (période, durée, type de contenu, activité, etc.)
  - Corrélations entre activités (ex: temps de concentration vs. pistes audio vs. sites consultés)

- **Notifications intelligentes**
  - Affichage “Faire une pause” lorsque le timer de travail est écoulé
  - Timer de pause suivi d’un bouton “Remise au travail”

---

## 🔧 Fonctionnalités Secondaires

### Intégration avec Notion
- Connexion à un compte Notion personnel
  - Suivi en temps réel :
    - Pages ouvertes
    - Pages éditées
    - Pages supprimées
  - Affichage sous forme de graphiques

### Suivi du navigateur
- Historique des sites consultés
  - Classés par heure et durée
  - Visualisation graphique

### Chatbot intelligent (Ollama)
- Intégration d’un assistant conversationnel
  - Répond aux questions de l’utilisateur
  - Accès aux :
    - Statistiques de révision
    - Pages Notion connectées

---

## 🧩 Système de Plugins Communautaires

- Architecture prévue pour **étendre l’application** avec des modules externes
- Les plugins sont classés en **trois catégories distinctes** :

### 1. 🎨 Plugins de **Style**
- Modifient **l'apparence de l'application**
- Un **style par défaut** est fourni par le développeur
- Possibilité pour la communauté de créer des **thèmes visuels complets**
- Gestion intuitive via une interface dédiée

### 2. 🛠️ Plugins **Modifier**
- Permettent de **modifier des comportements natifs** de l’application
- Exemples : 
  - Personnalisation des appels à Home Assistant
  - Redéfinition des connexions avec Notion
  - Ajustements de règles Pomodoro ou de format de statistiques

### 3. ✨ Plugins **Features**
- Ajoutent des **fonctionnalités entièrement nouvelles**
- Peuvent inclure :
  - Un ou plusieurs modules fonctionnels
  - Nouveaux onglets ou ajout dans des onglets existants
- Chaque Feature utilise obligatoirement le **système de style natif** pour rester compatible avec les plugins de style

### 📦 Packs personnalisés
- Système de **packs partagés** :
  - Peuvent contenir un ensemble de plugins : Styles, Modifiers, Features
  - Inclus les **fichiers de configuration utilisateur**
  - Import/export simple pour **partager un setup complet**

---

## 🔒 Confidentialité
- Toutes les données personnelles sont stockées localement
- Aucun envoi externe sans autorisation explicite de l'utilisateur

---

## 🗂️ Résumé des Modules Clés

| Module                | Fonctionnalité principale                                 |
|----------------------|------------------------------------------------------------|
| Interface graphique   | Affichage compact et ergonomique, thème sombre             |
| Suivi de session      | Temps, applications, sites, pistes audio                   |
| Méthode Pomodoro      | Minuterie, rythme complet, musique, pauses intelligentes   |
| Blocage de distractions | Programmes et sites bannis pendant la session            |
| Planification         | Agenda des tâches, activités par session, planning         |
| Statistiques          | Graphiques détaillés, corrélations, filtres avancés        |
| Intégration Home Assistant | Échange bidirectionnel d’infos domotiques            |
| Intégration Notion    | Suivi des pages éditées en temps réel                      |
| Assistant (chatbot)   | Réponses personnalisées selon les données                  |
| Plugins               | Styles, Modificateurs, Nouvelles fonctionnalités, Packs    |

---

**Projet pensé pour booster la concentration, analyser les habitudes de travail et optimiser chaque session de révision.**
