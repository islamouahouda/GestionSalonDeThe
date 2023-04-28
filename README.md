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
