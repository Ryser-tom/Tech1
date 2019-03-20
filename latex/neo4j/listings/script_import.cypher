CREATE (b:Arrêt {nom:'P+R Bernex', geo:'x: 0, y: 0'})
CREATE (v:Arrêt {nom:'Vuillonnex', geo:'x: 0, y: 0'})
CREATE (bp:Arrêt {nom:'Bernex-Place', geo:'x: 0, y: 0'})
CREATE (bm:Arrêt {nom:'Bernex-Mairie', geo:'x: 0, y: 0'})
CREATE (be:Arrêt {nom:'Bernex-Eglise', geo:'x: 0, y: 0'})
CREATE (bs:Arrêt {nom:'Bernex-Saule', geo:'x: 0, y: 0'})
CREATE (bv:Arrêt {nom:'Bernex-Vailly', geo:'x: 0, y: 0'})
CREATE (sev:Arrêt {nom:'Sézenove-Village', geo:'x: 0, y: 0'})
CREATE (c:Arrêt {nom:'Cottenets', geo:'x: 0, y: 0'})
CREATE (pp:Arrêt {nom:'Pré-Polly', geo:'x: 0, y: 0'})
CREATE (lc:Arrêt {nom:'Lully-Croisée', geo:'x: 0, y: 0'})

CREATE (sf:Arrêt {nom:'Sézenove-Ferrand', geo:'x: 0, y: 0'})
CREATE (ma:Arrêt {nom:'Maisonnette', geo:'x: 0, y: 0'})
CREATE (cdld:Arrêt {nom:'Chemin de la Douane', geo:'x: 0, y: 0'})
CREATE (lsdt:Arrêt {nom:'Laconnex-Stand de tir', geo:'x: 0, y: 0'})
CREATE (lv:Arrêt {nom:'Laconnex-Village', geo:'x: 0, y: 0'})
CREATE (mo:Arrêt {nom:'Mollaz', geo:'x: 0, y: 0'})
CREATE (sov:Arrêt {nom:'Soral-Village', geo:'x: 0, y: 0'})
CREATE (sm:Arrêt {nom:'Soral-Mairie', geo:'x: 0, y: 0'})
CREATE (slm:Arrêt {nom:'Sur-Le-Moulin', geo:'x: 0, y: 0'})
CREATE (s:Arrêt {nom:'Sézegnin', geo:'x: 0, y: 0'})
CREATE (lr:Arrêt {nom:'Le Renfort', geo:'x: 0, y: 0'})
CREATE (lt:Arrêt {nom:'La Tuilière', geo:'x: 0, y: 0'})
CREATE (av:Arrêt {nom:'Athenaz-Village', geo:'x: 0, y: 0'})
CREATE (ae:Arrêt {nom:'Athenaz-Ecole', geo:'x: 0, y: 0'})

CREATE
  (b)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(v),
  (v)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(bp),
  (bp)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(bm),
  (bm)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(be),
  (be)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(bs),
  (bs)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(bv),
  (bv)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(sev),
  (sev)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(c),
  (c)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(pp),
  (pp)-[:Bus_47 {Terminus: ['Lully-Croisée']}]->(lc),
  
  (b)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(v),
  (v)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(bp),
  (bp)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(bm),
  (bm)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(be),
  (be)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(bs),
  (bs)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(bv),
  (bv)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(sev),
  (sev)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(c),
  (c)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(pp),
  (pp)<-[:Bus_47 {Terminus: ['p+r Bernex']}]-(lc),

  (sf)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(ma),
  (ma)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(cdld),
  (cdld)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(lsdt),
  (lsdt)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(lv),
  (lv)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(mo),
  (mo)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(sov),
  (sov)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(sm),
  (sm)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(slm),
  (slm)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(s),
  (s)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(lr),
  (lr)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(lt),
  (lt)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(av),
  (av)-[:Bus_L {Terminus: ['Athenaz-Ecole']}]->(ae),

  (sf)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(ma),
  (ma)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(cdld),
  (cdld)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(lsdt),
  (lsdt)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(lv),
  (lv)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(mo),
  (mo)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(sov),
  (sov)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(sm),
  (sm)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(slm),
  (slm)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(s),
  (s)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(lr),
  (lr)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(lt),
  (lt)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(av),
  (av)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(ae),

  (b)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(v),
  (v)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(bp),
  (bp)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(bm),
  (bm)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(be),
  (be)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(bs),
  (bs)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(bv),
  (bv)<-[:Bus_L {Terminus: ['p+r Bernex']}]-(sf),

  (b)-[:Bus_L {Terminus: ['p+r Bernex']}]->(v),
  (v)-[:Bus_L {Terminus: ['p+r Bernex']}]->(bp),
  (bp)-[:Bus_L {Terminus: ['p+r Bernex']}]->(bm),
  (bm)-[:Bus_L {Terminus: ['p+r Bernex']}]->(be),
  (be)-[:Bus_L {Terminus: ['p+r Bernex']}]->(bs),
  (bs)-[:Bus_L {Terminus: ['p+r Bernex']}]->(bv),
  (bv)-[:Bus_L {Terminus: ['p+r Bernex']}]->(sf)