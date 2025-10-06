var sectionProfile = document.getElementsByClassName("profile")[0];
var sectionOrder = document.getElementsByClassName("order")[0];
var sectionFavorite = document.getElementsByClassName("favorite")[0];
var sectionAvaliation = document.getElementsByClassName("avaliation")[0];
var sectionInformation = document.getElementsByClassName("information")[0];

var optionSections = document.getElementsByClassName("titleSection");

function openSection(menuOption) {
    var optionSelected = menuOption.id;
    sectionProfile.style.display = "none";
    sectionOrder.style.display = "none";
    sectionFavorite.style.display = "none";
    sectionAvaliation.style.display = "none";
    sectionInformation.style.display = "none";

    switch (optionSelected) {
        case "profile":
            sectionProfile.style.display = "flex";
            break;
        case "order":
            sectionOrder.style.display = "flex";
            break;
        case "favorite":
            sectionFavorite.style.display = "flex";
            break;
        case "avaliation":
            sectionAvaliation.style.display = "flex";
            break;
        case "information":
            sectionInformation.style.display = "flex";
            break;
        default:
            console.error("Invalid option selected: " + optionSelected);
    }

    for (var i = 0; i < optionSections.length; i++) {
        optionSections[i].classList.remove('active');
    }

    menuOption.classList.add('active');
}

function OpenImageIconUser() {
    let containerDiv = document.getElementById("containerSelectUserImage");
    containerDiv.style.display = "flex";
}

function CloseImageIconUser() {
    let containerDiv = document.getElementById("containerSelectUserImage");
    containerDiv.style.display = "none";
}

function VisualizarImagemSelecionada(inputFile, idTagImg) {
    tagImage = document.getElementById(idTagImg);
    inputFile.addEventListener("change", (event) => {
        const file = event.target.files[0];
        if (!file) {
            tagImage.style.display = "none";
            return;
        }

        const url = URL.createObjectURL(file);
        tagImage.style.display = "flex";
        tagImage.src = url;
    });
}

function OpenAdressInfoContainer(buttonChield) {
    let parentElement = buttonChield.parentNode;
    let adressInfoContainer = parentElement.querySelector(":last-child");
    adressInfoContainer.style.display = "flex";
}

function CloseAdressInfoContainer(buttonChield) {
    let parentElement = buttonChield.parentNode.parentNode;
    let parentElementContainer = parentElement.parentNode;
    parentElementContainer.style.display = "none";
}

function OpenAddAdressContainer() {
    let adressContainer = document.getElementById("adressContainer");
    adressContainer.style.display = "flex";
}

function CloseAddAdressContainer() {
    let adressContainer = document.getElementById("adressContainer");
    adressContainer.style.display = "none";
}