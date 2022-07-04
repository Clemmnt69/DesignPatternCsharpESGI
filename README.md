# ESGI - Design Pattern en C#

## Session du 04/07/2022 : 8h – 9h30 | Abstract Factory
Installation de .NET 
Création d’un repos GIT
Présentation d’un schéma classique de présentation des designs patterns
Le design pattern `Factory abstract` ( Usine abstraite )

Création d’un projet sur VS Code (« console app »)
Mise en place d’une interface « FabriquerVehicule » qui permet la signature d’une fonction d’une méthode.
Le but de ce pattern est de résoudre tous les problèmes liés à la création de classes et au fait de surcharger la classe mère.

### Intérogation : Explication la partie « Scooter » du schéma UML.

![Schéma UML 1](img/UML_1.PNG)

Un scooter peut être électrique ou essence, et sa création est disponible depuis le catalogue.

Nous avons l’interface `FabriquerVehicule`«  », deux variantes `Electrique` et `Essence`, servent l’interface en implémentant l’interface `FabriquerVehicule`. En choisissant de fabriquer un scooter, on choisit quelle variante utiliser permettant d’implémenter le véhicule avec les propriétés d’un scooter, qui va elle appeler la fabrique concrète qui est en charge de crée un véhicule électrique 

## Session du 04/07/2022 : 9h45 – 11h15 | Patern Builder

### Objectif : créé un constructeur de liasse de document 
Réaliser la création d'objets complexes sans avoir à s'occuper des problèmes d'implémentations

### Exemple basique / UML
![Schéma UML 3](img/UML_3.PNG)

### Exemple avec le contexte de liasse véhicule / UML
![Schéma UML 4](img/UML_4.PNG)

