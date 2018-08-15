function letterOccInString(input, letter) {
    let occ = 0;
    for(let i = 0;i<input.length;i++){
        if(input[i] === letter){
            occ++;
        }
    }
    console.log(occ);
}
