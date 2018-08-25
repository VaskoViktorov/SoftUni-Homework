function magicMatrices(matrix) {

    let sum = matrix[0].reduce((a,b) => a+b);

    for(let col=1; col<matrix.length; col++) {

        let sumCol = 0;
        for(let row=0; row<matrix.length; row++) {
            sumCol += matrix[row][col];
        }

        if(sum !== sumCol || sum !== matrix[col].reduce((a,b) => a+b)) {
            return console.log("false")
        }
    }

    console.log("true");
}