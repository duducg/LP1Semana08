```mermaid
---
title : AnimalKingdom Classes  
---
classDiagram
Animal<|--Bat 
Animal<|--Bee
Animal<|--Cat
Animal<|--Dog
Dog..|>IMammal 
Bat..|>IMammal
Cat..|>IMammal
Bat..|>ICanFly
Bee..|>ICanFly

class ICanFly
<<interface>> ICanFly

class IMammal
<<interface>> IMammal


```