Voici ton README mis à jour pour préciser que **toutes** les fonctionnalités, y compris celles de base, sont développées sous forme de plugins afin de maximiser la modularité, la maintenance et le débogage.
J’ai intégré la précision dès l’introduction, dans la section “Système de Plugins”, et ajusté les parties “Contributions” et “Résumé des Modules” pour que ce soit cohérent.

---

# 📚 Agent Personnel de Révision - Cahier des Charges

## 🎯 Objectif

Développer une application minimaliste et interactive servant d’assistant personnel pour organiser, suivre et améliorer les sessions de révision selon la méthode Pomodoro.
**Toutes les fonctionnalités (y compris celles de base) sont implémentées sous forme de plugins**, afin de faciliter le développement, la modularité, le débogage et l’extension future par la communauté.
L’agent vise à augmenter la productivité, à réduire les distractions et à générer des rapports statistiques détaillés.

---

## Visuels

## Lien vers la dernière vidéo de mise à jour : [https://youtu.be/r4YPtQZm2AY](https://youtu.be/r4YPtQZm2AY)

## 🖥️ Interface Générale

* **Démarrage automatique au lancement du système**

* **Interface initiale épurée, thème sombre**

  * Demande à l'utilisateur s'il souhaite réviser

    * Si **non** : l'agent se ferme
    * Si **oui** : l’interface complète s’ouvre

* **Interface compacte** (petit carré en haut à gauche de l’écran)

  * **Extension automatique** en quart d’écran lorsque le curseur passe dessus

---

## ⏱️ Fonctionnalités de Suivi

> ⚙️ **Remarque importante** : chacune de ces fonctionnalités est un **plugin** officiel inclus dans la version de base.
> Elles peuvent être activées/désactivées individuellement ou remplacées par des versions personnalisées.

### Suivi du temps et de l'activité

* Traque du **temps total de révision**
* Suivi des **applications utilisées** :

  * Temps d’utilisation global
  * Temps en mode plein écran
* Export des données vers :

  * **Agenda personnel**
  * **Graphiques statistiques**
  * **Home Assistant** :

    * Envoi d'informations (état de session, début/fin de pause, chapitre terminé…)
    * Réception de commandes (changer de piste audio, valider une étape…)

### Méthode Pomodoro

* Possibilité de **configurer plusieurs modes Pomodoro** (ex: 25/5, 30/10, etc.)
* Prise en charge du **cycle Pomodoro complet** :

  * 3 sessions de travail + pause courte
  * 1 session de travail + pause longue
* Démarrage d’un Pomodoro lance une **piste audio** personnalisée

  * Gestion des pistes :

    * Ajouter / supprimer / modifier
    * Passer à la suivante facilement
  * Statistiques sur les pistes :

    * Durée moyenne d’écoute
    * Fréquences d’utilisation selon l’heure et le jour

---

## 📆 Planification et Organisation

*(Plugin intégré par défaut)*

* Agenda intégré avec visualisation des **sessions de travail** et des **pauses**
* Possibilité d’**ajouter une activité planifiée** à chaque session
* Construction d’un **planning personnalisé** selon les objectifs

---

## 🚫 Blocage de Distractions

*(Plugin intégré par défaut)*

* **Liste de programmes bannis**
* **Liste de sites interdits** avec extension navigateur liée à l’agent

---

## ✅ Marquage de Progression

*(Plugin intégré par défaut)*

* **Bouton “Leçon / Chapitre terminé”** avec enregistrement statistique

---

## 📊 Statistiques et Visualisation

*(Plugin intégré par défaut)*

* Graphiques dynamiques, filtres avancés, corrélations entre données

---

## 🔧 Fonctionnalités Secondaires

*(Plugins intégrés par défaut, désactivables)*

* Intégration avec Notion
* Suivi du navigateur
* Chatbot intelligent (Ollama)

---

## 🧩 Système de Plugins Communautaires

**Architecture 100 % modulaire** :

> Toutes les fonctionnalités, même celles présentes par défaut, sont développées sous forme de **plugins officiels**.
> Cela permet de :

* Remplacer facilement un module natif par une version modifiée.
* Ajouter de nouvelles fonctionnalités indépendamment du noyau.
* Faciliter le débogage et la maintenance.

Les plugins sont classés en **trois catégories** :

### 1. 🎨 Plugins de **Style**

* Modifient l'apparence de l'application
* Thèmes officiels et personnalisés possibles

### 2. 🛠️ Plugins **Modifier**

* Modifient ou remplacent le comportement de modules existants

### 3. ✨ Plugins **Features**

* Ajoutent des fonctionnalités totalement nouvelles
* Peuvent remplacer un plugin natif de base

### 📦 Packs personnalisés

* Packs contenant un ensemble complet de plugins + configuration utilisateur

---

## 🔒 Confidentialité

* Toutes les données sont stockées localement
* Aucun envoi externe sans autorisation

---

## 🤝 Contributions

* Toute contribution **doit respecter l’architecture 100 % plugin**.
* Les fonctionnalités natives actuelles sont elles-mêmes des plugins officiels.
* Les nouvelles idées peuvent être proposées comme :

  * Amélioration d’un plugin officiel
  * Création d’un plugin supplémentaire

---

## 🗂️ Résumé des Modules Clés (Plugins Officiels Inclus)

| Plugin officiel       | Fonctionnalité principale                |
| --------------------- | ---------------------------------------- |
| Interface graphique   | Affichage compact, thème sombre          |
| Suivi de session      | Temps, applications, sites, pistes audio |
| Méthode Pomodoro      | Timers, cycles, gestion audio            |
| Blocage distractions  | Programmes et sites bannis               |
| Planification         | Agenda et activités planifiées           |
| Statistiques          | Graphiques et corrélations               |
| Home Assistant Bridge | Échange bidirectionnel avec la domotique |
| Intégration Notion    | Suivi des pages en temps réel            |
| Chatbot IA            | Réponses selon les données               |
| Gestion de plugins    | Styles, Modifiers, Features, Packs       |

 
