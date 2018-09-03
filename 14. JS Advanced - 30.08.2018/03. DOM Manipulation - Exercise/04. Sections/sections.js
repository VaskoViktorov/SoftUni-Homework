function create(sentences) {
    let body = document.getElementById("content");

    for(let sentence of sentences){
        let div = document.createElement("div");
        let p = document.createElement("p");
        p.style.display = "none";
        p.textContent = sentence;

        div.appendChild(p);
        div.addEventListener('click',show);

        body.appendChild(div);
    }
    document.addEventListener("onclick", show);
    function show(event) {
        event.target.children[0].style.display = 'block';
    }
}