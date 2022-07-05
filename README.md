# ESGI - Design Pattern en C#

Les patrons de conception (design patterns) sont des
solutions classiques à des problèmes récurrents de la
conception de logiciels. 
Pour un patron, un schéma éxiste, restant personnalisable pour répondre à un problème récurrent dans votre code.

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

![Schéma UML 2](img/UML_2.PNG)

Un scooter peut être électrique ou essence, et sa création est disponible depuis le catalogue.

Nous avons l’interface `FabriquerVehicule`, deux variantes `Electrique` et `Essence`, servent l’interface en implémentant l’interface `FabriquerVehicule`. 
En choisissant de fabriquer un scooter, on choisit quelle variante utiliser permettant d’implémenter le véhicule avec les propriétés d’un scooter, qui va elle appeler la fabrique concrète qui est en charge de crée un véhicule électrique 

## Session du 04/07/2022 : 9h45 – 11h15 | Patern Builder

### Objectif : Besoin de construire des objets complexes sans connaître son implémentation.
Réaliser la création d'objets ayant plusieurs implémentations, dit complexes, sans avoir à s'occuper des problèmes d'implémentations avec une utilisation pour séparer la logique interne et client.

### Exemple basique / UML
![Schéma UML 3](img/UML_3.PNG)

### Exemple avec le contexte de liasse véhicule / UML
![Schéma UML 4](img/UML_4.PNG)

## Session du 04/07/2022 : 11h30 – 13h | Structure liasse véhicule 

`Commande` est une classe abstraite qui est basée sur la `Factory Methode`

`Client` est elle aussi une classe abstraite

![Schéma UML 5](img/UML_5.PNG)

Présentation de la `Factory Méthode : Generic`

![Schéma UML 6](img/UML_6.PNG)

## Session du 05/07/2022 : 14h00 - 15h30 | Singleton

Le singleton est un patron de conception de création qui garantit et exige que l’instance d’une classe n’existe que en un seul exemplaire unique, en donnat un acces à cette instance pour l'intégralité de l'application

Un pattern Abstract va etre susceptible d'utiliser ce type d'instance unique.

### Un exemple du singleton 

![Schéma UML 8](img/UML_8.PNG)

### Dans le cas de notre application 

On va utiliser la classe `liasse`.

![Schéma UML 7](img/UML_7.PNG)

### Exercice : Création d'une instance globale du vendeur

Exemple de mon singleton

```csharp
public class Vendeur
{
    private static Vendeur _instance = null;
    public decimal primes { get; set; }

    private Vendeur() {
    }

    public static Vendeur Instance()
    {
        if (_instance == null)
            _instance = new Vendeur();
        return _instance;
    }
}
```csharp

```csharp
static void Main(string[] args)
{
    Vendeur vendeur1 = Vendeur.Instance();
    Vendeur vendeur2 = Vendeur.Instance();

    vendeur1.primes = 455;
    if(vendeur2.primes == vendeur1.primes)
        Console.WriteLine("Singleton ok");
    else
        Console.WriteLine("Singleton ko");
}
```csharp


