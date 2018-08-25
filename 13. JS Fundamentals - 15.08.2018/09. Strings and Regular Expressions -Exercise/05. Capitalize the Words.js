function capitalizeWords(text) {
    let result = text.toLowerCase().split(" ");

    for(let i = 0; i<result.length;i++){
        result[i] = result[i][0].toUpperCase()+result[i].substr(1);
    }

  console.log(result.join(" "));
}

capitalizeWords('Capitalize these words');
