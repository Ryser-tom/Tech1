let speed = 5;
setInterval(move, 1);

function move() {
    superman.style.left = (parseInt(superman.style.left) + speed +"px");
    if (parseInt(superman.style.left) >= 500) {
        superman.style.left = "-200px";
    }
}
function changevitesse(value){
    speed = value;
}
//1700