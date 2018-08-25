function findVariableNames(input) {
    let variables =[];
    let regex = /\b_([a-zA-Z0-9]+)\b/g;
    let match = regex.exec(input);

    while(match) {
        variables.push(match[1]);
        match = regex.exec(input);
    }

    console.log(variables.join(","));
}

findVariableNames("The _id and _age variables are both integers.");