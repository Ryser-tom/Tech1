MATCH (a:Arrêt), (b:Arrêt) 
WHERE a.nom="P+R Bernex" AND b.nom="Vuillonnex" 
CREATE (a)-[:Bus_47 {Terminus:["Lully-Croisée"]}]->(b)
return a,b