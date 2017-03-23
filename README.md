# Quoi de neuf dans Visual Studio 2017
Survol de nouvelles fonctionnalités de Visual Studio 2017

## Mise en contexte
Le 7 mars 2017 nous a amené la version 2017 de Visual Studio, toujours disponible en version Community, Professional et Enterprise.

Voici donc les fonctionnalités qui ont retenu notre attention et qui vont fort probablement vous aider dans vos projets.

## L'installation
Avant même de parler de ce que Visual Studio 2017 va vous apporter, on peut parler de l'installateur, qui a été complètement refait. Il est maintenant plus facile de sélectionner individuellement les composantes que nous avons besoin, ou encore de les ajouter via des "Workloads", qui sont essentiellement des regroupements de composantes nécessaires selon certains besoins. 
Par exemple, et vous pouvez le constater avec les captures d'écran ci-bas, le workload "Universal Windows Platform development" nous sélectionnera les versions du framework, le compilateur et tous les outils nécessaires à ce type de projet.

##### Workloads
![Workload](images/workload.png)

##### Composantes
![Composantes](images/composantes.png)

Un autre élément qu'on peut noter (que vous pouvez voir sur les captures) est qu'il est possible de donner un "nickname" à notre installation. Puisqu'il est possible d'installer deux versions de Visual Studio 2017 sur le même ordinateur (Community et Professional, par exemple), il est donc possible de donner un surnom à l'installation, pour permettre de facilement les distinguer dans le menu de démarrage.

## Améliorations de l'IDE
Une des plus grandes améliorations qu'on peut voir dans cette nouvelle version est la performance. Un gros travail d'optimisation a été fait pour réduire le temps de démarrage et le temps de chargement des solutions. Selon Microsoft, le temps de démarrage serait 50% plus rapide qu'avant lors de la première utilisation.
Pour bien le constater, j'ai fait le test de comparer l'ouverture d'une solution sur laquelle j'ai travaillé récemment, qui contenait 15 projets. Pour un temps d'ouverture d'environ 10 secondes avec Visual Studio 2015, on passait à seulement 6 secondes avec la version 2017. 
Malgré cette différence assez notable, je me suis demandé si l'option de "Lightweight Solution Load", qui a été ajoutée pour permettre de charger plus rapidement et pour mieux utiliser la mémoire, pourrait me permettre d'améliorer ce temps. J'ai donc activé l'option pour ma solution (cette option n'est pas activée par défaut) et refait le test, pour en arriver à un temps d'ouverture de 3 secondes.
Je vous laisse le soin de faire le test avec vos solutions, mais je crois qu'on peut considérer l'objectif de performance comme atteint !

## Page de démarrage
Beaucoup de changements sur cette page qui nous est offerte à l'ouverture de l'application. 
Un premier changement, quoique mineur, est la possibilité de cacher la section "Developer News". Pour ceux qui ne consultent pas ces nouvelles, cela permettra de laisser toute la place aux récents projets et à la création de nouveaux.
Parlant de nouveaux projets, nous avons là un changement qui sera selon moi le bienvenue pour beaucoup de gens. Dans les versions précédantes de Visual Studio, la création d'un nouveau projet nous ouvrait tout simplement le dialogue de sélection de gabarit de projet. 

Avec 2017, une section de la page est maintenant dédiée à la création de projets, en nous permettant de choisir parmis les gabarits de projets récemment utilisés 
![Recent](images/recent.png)

ou encore avec la barre de recherche de gabarit.
![Recherche](images/recherche.png)

Dans la majorité des cas, il sera donc possible de démarrer un nouveau projet directement à partir de cet écran.

## Navigation de code
Beaucoup de choses ont été mises en place pour améliorer la navigation dans notre code.

##### Go To All
La première est la fonction de "Go To All", qui nous amène ce dialogue de recherche:
![Gotoall](images/gotoall.png)

Il est donc possible à partir de cette barre de recherche de chercher à travers tous les types, membres, fichiers et d'accéder à la classe. Plus besoin de naviguer vers la classe en passant par l'explorateur de solution, tout pourra se faire sans que nos doigts quittent le clavier.

##### Find All References
Le panneau pour trouver toutes les références est fréquemment utilisé pour avoir une liste de toutes les références à une classe ou un objet. 
Jusqu'à Visual Studio 2017, cette liste de résultats pouvait nous donner l'information sur le projet et le fichier où la référence était, mais simplement par le texte contenu dans la ligne affichée sur la référence.

Souhaitons donc la bienvenue à ce panneau, version améliorée:
![Findallreferences](images/findallreferences.png)

On peut tout d'abord remarquer qu'il est possible de grouper les résultats de la recherche. Cette capture montre un groupement par projet puis par définition, mais plusieurs autres options s'offrent à nous pour grouper selon nos besoins.
On remarque aussi la colorisation des résultats, pour aider à comprendre le contexte de la référence qui nous est affichée, qu'on retrouve également dans l'affichage de l'extrait du code entourant la référence.

##### Structure Guide Lines
Dans sa plus simple utilisation, cette fonctionnalité nous permet d'avoir un indicatif visuel pour nous aider à visualiser la strucutre de notre code. La valeur ajoutée de ceci nous vient lorsqu'on dépose le curseur de notre souris sur ces lignes. En effet, une info-bulle nous sera affichée, avec le début de notre bloc de code et de ses blocs parents. Il est donc possible de voir facilement le contexte de notre bloc de code, sans avoir à naviguer de bas en haut et de haut en bas dans notre fichier.
![Guidelines](images/guidelines.png)

## Ouverture de dossiers
La polyvalence faisant partie intégrale de notre métier, il arrive parfois que nous devons travailler sur autre chose qu'une solution faite en .NET. Avec cette nouvelle version de Visual Studio, il nous est maintenant possible d'ouvrir le dossier de ces projets (un projet PHP par exemple), et d'y travailler, avec surbrillance de la syntaxe et beaucoup de fonctionnalités comme la navigation et la recherche à travers le dossier.

Il est même possible d'ouvrir un dossier dans Visual Studio directement à partir de l'explorateur de fichier, avec une nouvelle commande ajoutée au menu contextuel. 

