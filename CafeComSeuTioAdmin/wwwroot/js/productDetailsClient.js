function NewStarAvaliation(input) {
    for (i = 1; i <= 5; i++) {
        var starSelected = document.getElementById("newStarImgValue" + i);
        starSelected.setAttribute("src", "/images/iconsAction/estrelaVazia.png");
    }
    var starValue = input.value;
    for (i = 1; i <= starValue; i++) {
        var starSelected = document.getElementById("newStarImgValue" + i);
        starSelected.setAttribute("src", "/images/iconsAction/estrelaCheia.png");
    }
}
function EditStarAvaliation(input) {
    for (i = 1; i <= 5; i++) {
        var starSelected = document.getElementById("editStarImgValue" + i);
        starSelected.setAttribute("src", "/images/iconsAction/estrelaVazia.png");
    }
    var starValue = input.value;
    for (i = 1; i <= starValue; i++) {
        var starSelected = document.getElementById("editStarImgValue" + i);
        starSelected.setAttribute("src", "/images/iconsAction/estrelaCheia.png");
    }
}

