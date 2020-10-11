# TP FNAC

## Résumé

Dans ce TP, nous allons mettre en place les bases de notre future site e-commerce pour concurencer la FNAC.

## Exercice

1. Implémenter la classe Livre
Un livre a :
    - Un auteur
    - Un titre
    - Un prix (fixe de 15 euros)
    - Une fonction d'affichage 

1. Implémenter la classe Panier
Un panier a :
   - Une liste de livres (```List<Livre>```)
   - Un prix total des achats
   - Une fonction d'affichage

3. Mettre en place une réduction de 5% si on commande plus de 5 livres

4. Mettre en place une reduction de 10% si on commande plus de 5 livres du même auteur
5. Nous décidons de vendre de nouveaux types de livres
    - Manga (prix 6,50 €)
    - Romans (prix 5€)
    - BD (prix 15 €)
    - Comic (prix 20 €)