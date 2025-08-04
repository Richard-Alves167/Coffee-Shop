function Loading() {
    let loadDiv = document.createElement("div");
    loadDiv.setAttribute("id", "loadContainer");
    let loadImage = document.createElement("img");
    loadImage.setAttribute("src", "/images/cats/runningCat.gif");
    let loadSpan = document.createElement("span");
    loadSpan.textContent = "Loading . . .";
    loadDiv.appendChild(loadImage);
    loadDiv.appendChild(loadSpan);
    document.body.appendChild(loadDiv);

    setTimeout(() => document.body.removeChild(loadDiv), 2500);
}