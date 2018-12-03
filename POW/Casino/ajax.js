let NUMBEROFIMAGES = 10; // Nombre total d'images demandées au service web
let COUTPARTIRAGE = 100; // Coût par tirage de chats
let GAINSIGAGNE = 10000; // La somme qu'on gagne si les 3 chats sont identiques
let wallet;
let images = [];
let tmp;

// Fonction pour aligner les images dans les DIV
function valign(elem){	
	let marge = (elem.parentElement.clientHeight - elem.height) / 2;
	elem.style.marginTop = marge+"px";
}

function get_image(){
	var xhttp = new XMLHttpRequest();
	xhttp.onreadystatechange = function() {
	  if (this.readyState == 4 && this.status == 200) {
		  let result = JSON.parse(this.responseText).file;
		console.log(result);
		tmp = result;
	  }
	};
	xhttp.open("GET", "https://aws.random.cat/meow", true);
	xhttp.send();
}
function test_type(link){
	let res = link.split(".");
	if (res[res.length - 1] === "jpg" || res[res.length - 1] === "jpeg" || res[res.length - 1] === "png" ) {
		return true;	
	}
	return false;
}
function jq_ajax(){
	$.ajax({
		url : 'https://aws.random.cat/meow', // La ressource ciblée
		type : 'GET', // Le type de la requête HTTP
		dataType : 'json', // Le type de données à recevoir, ici, du json.
		success: function( result ) {
			tmp = result.file;
			if (test_type(tmp)) {
				images.push(tmp);
			}
			if (images.length < NUMBEROFIMAGES) {
				jq_ajax();
			}
		  }
	 });
	 wallet = GAINSIGAGNE;
}
function tirage(){
	let rnd1 = Math.floor((Math.random() * 9));
	let rnd2 = Math.floor((Math.random() * 9));
	let rnd3 = Math.floor((Math.random() * 9));

	$("#image1").attr("src",images[rnd1]);
	$("#image2").attr("src",images[rnd2]);
	$("#image3").attr("src",images[rnd3]);

	if (rnd1 == rnd2 && rnd1 == rnd3) {
		$("#resultat").text("bravo vous avez gagné 100'000");
		wallet += GAINSIGAGNE;
	}else{
		$("#resultat").text("Dommage, réessayer");
		wallet -= COUTPARTIRAGE;
	}

	$("#montant").text(wallet);
	if (wallet <= 0) {
		$("#resultat").text("Vous n'avez plus d'argent");
		$("input").attr("enabled",false);
	}
}
