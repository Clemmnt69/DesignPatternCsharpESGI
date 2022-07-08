# DESIGN PATTERN PROJET : ADAPTER

## Auteur 
Clément QUIQUANDON M1 AL

## Objectif 
Construire un formulaire au format HTML 

## Documentation

### Démmarage

1. Choix du nom du formulaire `format : string`, représenté par le titre du formulaire : `<h1>`

2. Choix du nombre de zones souhaitée, `format : int`, représenté par le nombre de : `<div>` 

3. Choix du nombre de champs souhaité, pour chaques zones `format : int`

4. Choix du `type` de champs souhaité, pour chaques champs `format : string`, représenté en fonction du choix qui peut etre `label`, `input`, `date`, `checkbox`, `button`.

5. Choix de la `class` CSS souhaitée, pour chaques champs `format : string`, représenté par `class : "votreClass";`, la saisie peut etre vide si vous n'avez pas de class CSS.

6. Choix du `style` CSS souhaité, pour chaques champs `format : string`, représenté par `style : "votreStyle";`, la saisie peut etre vide si vous n'avez pas de style CSS.

7. Choix du `placeholder` CSS souhaité, pour chaques champs `format : string`, représenté par  `placeholder : "votrePlaceholder";`, la saisie peut etre vide si vous n'avez pas de placeholder.

8. Choix de la `value` souhaitée, pour chaques champs `format : string`, représenté par  `value : "votreValeur";`, la saisie peut etre vide si vous n'avez pas de valeur par défaut.

### Résultats

Contexte : Je veux construire un formulaire d'envoie de mail classique pour mon site vitrine avec un nom, email, objet, une case à cocher me rappeler.
Mon formulaire va comporter 2 zones, une de saisie et une de validation avec un bouton.

### Rendu de l'application : 

Nom du formulaire : `Envoyer Mail`

Nombre de zone : `2`

Nombre de champs : `9`

Format HTML du formulaire : 

```html
<h1 style='text-align : center;'> Envoyer Mail </h1>
<div id='Zone_1'>
    <label id='Champs_1_Zone_1'>Nom</label>
    <input id='Champs_2_Zone_1' type='input'></input>
    <label id='Champs_3_Zone_1' >Email</label>
    <input id='Champs_4_Zone_1' type='input'></input>
    <label id='Champs_5_Zone_1' >Objet</label>
    <input id='Champs_6_Zone_1' type='input'></input>
    <label id='Champs_7_Zone_1' >Me rappeler ?</label>
    <input id='Champs_8_Zone_1' type='checkbox'></input>
</div>
<div id='Zone_2'>
    <button id='Champs_1_Zone_2' type='button'>Valider </button>
</div>
```