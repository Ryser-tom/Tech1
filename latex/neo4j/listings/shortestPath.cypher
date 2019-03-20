 MATCH (a:Arrêt),(r:Arrêt) 
WHERE a.nom = "Athenaz-Ecole"
AND r.nom = "Lully-Croisée" 
MATCH p = shortestPath((a)-[*]->(r)) 
return p