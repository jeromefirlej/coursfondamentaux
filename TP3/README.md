# La classe compte

## Objectif :  
*	Créer une classe dérivée.
*	Ajouter des méthodes à une classe dérivée.
*	Redéfinir des méthodes dans une classe dérivée.

## Énonce:

*	Un compte bancaire possède à tout moment une donnée : son solde. Ce solde peut être positif (compte créditeur) ou négatif (compte débiteur).
*	Chaque compte est caractérisé par un code incrémenté automatiquement.
*	le code et le solde d'un compte sont accessibles en lecture seulement.
*	A sa création, un compte bancaire a un solde nul et un code incrémenté.
*	Il est aussi possible de créer un compte en précisant son solde initial.
*	Utiliser son compte consiste à pouvoir y faire des dépôts et des retraits. Pour ces deux opérations, il faut connaître le montant de l'opération.
*	L'utilisateur peut aussi consulter le solde de son compte par la méthode ToString().
*	Un compte Epargne est un compte bancaire qui possède en plus un champ « Taux Intérêt=6 » et une méthode calculIntérêt() qui permet de mettre à jour le solde en tenant compte des intérêts.
*	Un ComptePayant est un compte bancaire pour lequel chaque opération de retrait et de versement est payante et vaut 5 € .
## Questions :
1.	Définir la classe Compte.
2.	Définir la classe CompteEpargne.
3.	Définir la classe ComptePayant.
4.	Créer un programme permettant de tester ces classes avec les actions suivantes:
    *	Créer une instance de la classe Compte , une autre de la classe CompteEpargne et une instance de la classe ComptePayant
    *	Faire appel à la méthode déposer() de chaque instance pour déposer une somme quelconque dans ces comptes.
    *	Faire appel à la méthode retirer() de chaque instance pour retirer une somme quelconque de ces comptes.
    *	Faire appel à la méthode calculInterêt() du compte Epargne.
    *	Afficher le solde des 3 comptes.

