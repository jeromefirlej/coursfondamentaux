# Puissance 4

## Règles du jeu
Le but du jeu est d'aligner une suite de 4 pions de même couleur sur une grille comptant 6 rangées et 7 colonnes.

Chaque joueur dispose de 21 pions d'une couleur (par convention, en général jaune ou rouge). 

Tour à tour, les deux joueurs placent un pion dans la colonne de leur choix, le pion coulisse alors jusqu'à la position la plus basse possible dans la dite colonne à la suite de quoi c'est à l'adversaire de jouer. 

Le vainqueur est le joueur qui réalise le premier un alignement (horizontal, vertical ou diagonal) consécutif d'au moins quatre pions de sa couleur. 

Si, alors que toutes les cases de la grille de jeu sont remplies, aucun des deux joueurs n'a réalisé un tel alignement, la partie est déclarée nulle.

## Ecrivez une implémentation du puissance 4

L'implémentation doit utiliser les notions vu en cours de :
- Interface
- Héritage 

Le projet doit être découpé en plusieurs classes

Les interactions joueurs (choix du coup, affichage du plateau de jeu) doivent être fait exclusivement dans le fichier program.cs

## Aide
Comment je matérialise le plateau de jeu?

Résoudre d'abord le problème par un sens (horizontal, vertical) avant d'implémenter les autres sens.