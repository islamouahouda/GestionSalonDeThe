# GestionSalonDeThe

# Tp: Réalisation d’une application Gestion d’un Salon de Thé

### Pr. A. BENABBOU ADO .net 

**Objectif :** Réaliser une application de Gestion d’un Salon de Thé. On suppose que le salon sert uniquement des boissons.

La base de données contiendra les tables suivantes, les clés primaires sont soulignées et les clés étrangères sont préfixées par # :

Table Serveurs : 
- Id Serveur
- Nom et prénom

Table Boissons : 
- Id Boisson
- Désignation
- Prix
- QtéStock

Table Commandes : 
- Id Commande
- DateCom
- HeureCom
- #IdServeur

Table BoissonsCommandées : 
- #Id Boisson
- #Id Commande
- Quantité commandée

### Fonctionnalités :

- Gestion des serveurs
- Gestion des boissons
- Gestion des commandes
- Lister pour chaque serveur le bilan des commandes de la journée

### Architecture des forms 

1. **Gestion des serveurs**
    - FormServeurs
        - DataGridView pour afficher la liste des serveurs avec les colonnes : IdServeur, Nom, Prénom.
        - Boutons : Ajouter, Modifier, Supprimer
        - Les boutons Modifier et Supprimer seront activés lorsqu'un serveur est sélectionné dans la liste.

2. **Gestion des boissons**
    - FormBoissons
        - DataGridView pour afficher la liste des boissons avec les colonnes : IdBoisson, Nom, Prix, Description.
        - Boutons : Ajouter, Modifier, Supprimer
        - Les boutons Modifier et Supprimer seront activés lorsqu'une boisson est sélectionnée dans la liste.

3. **Gestion des commandes**
    - FormCommandes
        - DataGridView pour afficher la liste des commandes avec les colonnes : IdCommande, IdServeur, NomServeur, DateCommande, Total.
        - Boutons : Ajouter, Modifier, Supprimer, Détails
        - Les boutons Modifier, Supprimer et Détails seront activés lorsqu'une commande est sélectionnée dans la liste.
        - Un bouton "Rafraîchir" pour actualiser la liste des commandes.

4. **Bilan des commandes de la journée pour chaque serveur**
    - FormBilanServeurs
        - ComboBox pour sélectionner la date pour laquelle afficher le bilan.
        - DataGridView pour afficher le bilan des commandes de la journée avec les colonnes : IdServeur, NomServeur, NombreDeCommandes, TotalDesCommandes.
        - Un bouton "Afficher" pour afficher le bilan des commandes pour la date sélectionnée.
        - Un bouton "Rafraîchir" pour actualiser la liste des serveurs et le bilan.

