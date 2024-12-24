# Projet Tetris

████████╗███████╗████████╗██████╗ ██╗███████╗    ██████╗ ██████╗  ██████╗      ██╗███████╗ ██████╗████████╗
╚══██╔══╝██╔════╝╚══██╔══╝██╔══██╗██║██╔════╝    ██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝██╔════╝╚══██╔══╝
   ██║   █████╗     ██║   ██████╔╝██║███████╗    ██████╔╝██████╔╝██║   ██║     ██║█████╗  ██║        ██║
   ██║   ██╔══╝     ██║   ██╔══██╗██║╚════██║    ██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝  ██║        ██║
   ██║   ███████╗   ██║   ██║  ██║██║███████║    ██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗╚██████╗   ██║
   ╚═╝   ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚══════╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚════╝  ╚══════╝ ╚═════╝   ╚═╝

## Notions

- Documentation C# : Classe
- Documentation C# : Héritage
- Documentation C# : Timers
- Documentation C# : Bitmap
- Documentation C# : Graphiques
- Documentation Visual Studio : Winform

## Notion optionnelle

- Documentation C++ : Patron de conception (c'est une documentation C++ mais c'est plus une façon de coder, populaire dans les jeux vidéo)

## Instructions

Vous devez utiliser Visual Studio (pas Visual Studio Code) pour réaliser votre programme.

Créez votre propre jeu Tetris ! Créez un menu avec les boutons "Jouer", "Options" et "Quitter" et faites-les fonctionner.
- Le bouton Jouer doit lancer le jeu
- Le bouton Options doit contenir des options configurables
- Le bouton Quitter doit évidemment quitter le jeu

### Partie 1 - Jeu

C'est ici que les utilisateurs marqueront des points dans votre jeu.

#### Par où commencer ?

##### Dessin

Tout d'abord, vous devez créer une grille dans votre interface, c'est ici que les utilisateurs joueront. Vous devez utiliser des éléments dans Winform pour le faire. Cette grille vous permettra de :
- Gérer les collisions
- Faire bouger vos formes en mettant à jour votre grille dans le temps

Vous pouvez définir votre forme comme vous le souhaitez, mais nous recommandons de créer une classe pour cela.

Votre forme doit :
- Avoir une taille
- Avoir une couleur
- Avoir une forme
- Pouvoir tourner sauf à côté d'un mur ou d'une autre forme

Vous devez avoir une zone où les utilisateurs peuvent voir :
- Leur score
- La prochaine forme à venir

##### Timer

Chaque jeu (ou presque) a un timer, il vous permettra de mettre à jour l'état du jeu.

Avec le timer, vous devez :
- Mettre à jour les animations
- Augmenter la vitesse du jeu en fonction du score

##### Gameplay

C'est la façon de jouer au jeu avec les éléments que vous avez mis dans votre jeu. Vous pouvez réinventer la façon de jouer à Tetris si vous le souhaitez, mais vous devez faire fonctionner la base du jeu réel.

Voici les éléments que vous devez mettre dans votre jeu :
- Utiliser les touches pour déplacer votre forme de droite à gauche
- Faire apparaître une forme aléatoire en haut de la grille
- Faire tomber la forme
- Faire tomber la forme plus rapidement lorsque l'utilisateur appuie sur la touche bas
- Faire disparaître la ligne si elle est complète
- Augmenter le score lorsqu'une ligne est complétée
- Game over si la forme tombe en haut de la grille

Vous pouvez ajouter des éléments de gameplay si vous le souhaitez.

### Partie bonus

C'est une partie optionnelle.

Voici une liste de possibilités que vous pouvez ajouter à votre jeu :
- Ajouter un menu où les utilisateurs pourront naviguer entre les boutons "Jouer", "Options" et "Quitter".
- Sauvegarder votre partie en cours et la charger
- Faire une animation pour le menu avec un Tetris jouant seul aléatoirement
- Nettoyer la grille lorsque l'utilisateur atteint un certain score
- Ajouter des malus
- Ajouter des modes de jeu
- Faire une IA qui apprend seule à jouer, fait un score incroyable et prend le contrôle de l'humanité (oubliez celle-là ^^')

## Packages autorisés

Vous pouvez utiliser tous les packages système fournis avec C# dans Visual Studio.