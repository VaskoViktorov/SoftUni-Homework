function printLetters(input){

    let arr = Array.from(input);

    for(let char in arr){
        console.log(`str[${char}] -> ${arr[char]}`)
    }
}

printLetters("Hello");