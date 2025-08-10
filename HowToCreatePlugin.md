# 📦 Guide de création d'un plugin

Ce document explique comment créer un plugin pour **[Nom de ton projet]**.

## ✏️ Étapes de création

1. **Copier le code de `SamplePlugin`**
   - Ouvre le dossier `SamplePlugin` fourni dans le projet.
   - Copie l’intégralité des fichiers source.

2. **Créer un projet Class Library (.NET Framework)**
   - Dans Visual Studio :  
     - `Fichier` → `Nouveau` → `Projet`  
     - Choisir **Bibliothèque de classes (.NET Framework)**.  
     - Nommer le projet (ex. : `MonPlugin`).

3. **Coller le code**
   - Colle les fichiers copiés de `SamplePlugin` dans ton nouveau projet.

4. **Ajouter les références nécessaires**
   - Dans l’Explorateur de solutions → clic droit sur **Références** → `Ajouter une référence...`
   - Cocher :
     - `PresentationCore`
     - `PresentationFramework`
     - `WindowsBase`

5. **Compiler le projet**
   - Menu **Générer** → `Générer la solution`.
   - Le fichier `.dll` généré correspond à ton plugin.

## 📂 Structure attendue

```
MonPlugin/
 ├─ MonPlugin.md
 ├─ ...
 └─ MonPlugin.dll  ← plugin compilé

